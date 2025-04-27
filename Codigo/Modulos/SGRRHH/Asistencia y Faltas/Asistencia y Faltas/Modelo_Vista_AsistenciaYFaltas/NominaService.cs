using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Controlador_AsistenciaYFaltas;
using Capa_Modelo_AsistenciaYFaltas;

namespace Modelo_Vista_AsistenciaYFaltas
{
    public class NominaService
    {
        private Controlador controlador = new Controlador();

        public void GenerarNomina(int mes, int anio)
        {
            var empleados = controlador.ObtenerEmpleados();
            int diasLaborales = DiasLaboralesMes(mes, anio);

            foreach (var emp in empleados)
            {
                var asistencias = controlador.ObtenerAsistenciasEmpleado(emp.Id, mes, anio);
                var permisos = controlador.ObtenerPermisosEmpleado(emp.Id, mes, anio);
                var excepciones = controlador.ObtenerExcepcionesSeptimo(emp.Id, anio);

                // Días laborados
                int diasTrabajados = asistencias
                    .Where(a =>
                        a.Estado == "Presente" ||
                        (a.Estado == "Permiso" &&
                         permisos.Any(p => p.ConGoce &&
                                          a.Fecha >= p.Inicio &&
                                          a.Fecha <= p.Fin)))
                    .Select(a => a.Fecha.Date)
                    .Distinct()
                    .Count();

                // Faltas
                var faltas = asistencias
                    .Where(a => a.Estado == "Falta" &&
                                !permisos.Any(p => p.ConGoce &&
                                                  a.Fecha >= p.Inicio &&
                                                  a.Fecha <= p.Fin))
                    .Select(a => a.Fecha.Date)
                    .Distinct()
                    .ToList();

                // Horas extra
                double totalHE = asistencias
                    .Select(a => (a.HoraSalida - a.HoraEntrada).TotalHours - 8)
                    .Where(h => h > 0)
                    .Sum();

                // ¿Descontar séptimo día?
                bool descontar7mo = faltas.Any() &&
                    !excepciones.Any(e =>
                        GetSemanaDelAño(faltas.First(), anio) == e.Semana && e.Exento);

                // Cálculo de montos
                decimal pagoBase = (emp.SalarioBase / diasLaborales) * diasTrabajados;
                decimal pagoHE = (decimal)totalHE * emp.SalarioHora * 1.5m;
                decimal descFaltas = faltas.Count * (emp.SalarioHora * 8m);
                decimal desc7mo = descontar7mo
                    ? (emp.SalarioBase / diasLaborales)
                    : 0m;

                // Guardar
                controlador.InsertarNominaEmpleado(new Sentencia.NominaRecord
                {
                    IdEmpleado = emp.Id,
                    Mes = mes,
                    Anio = anio,
                    PagoBase = pagoBase,
                    PagoHorasExtra = pagoHE,
                    Deducciones = descFaltas + desc7mo
                });
            }
        }

        private int DiasLaboralesMes(int mes, int anio)
        {
            int total = DateTime.DaysInMonth(anio, mes), labor = 0;
            for (int d = 1; d <= total; d++)
            {
                var day = new DateTime(anio, mes, d).DayOfWeek;
                if (day != DayOfWeek.Saturday && day != DayOfWeek.Sunday) labor++;
            }
            return labor;
        }

        private int GetSemanaDelAño(DateTime fecha, int anio)
        {
            var ci = System.Globalization.CultureInfo.CurrentCulture;
            return ci.Calendar.GetWeekOfYear(
                fecha,
                System.Globalization.CalendarWeekRule.FirstDay,
                DayOfWeek.Monday);
        }
    }
}
