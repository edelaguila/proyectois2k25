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
            // 1) Traer empleados activos y días laborales
            var empleados = controlador.ObtenerEmpleados();
            int diasLaborales = DiasLaboralesMes(mes, anio);

            foreach (var emp in empleados)
            {
                // 2) Cargar datos del periodo
                var asistencias = controlador.ObtenerAsistenciasEmpleado(emp.Id, mes, anio);
                var permisos = controlador.ObtenerPermisosEmpleado(emp.Id, mes, anio);
                var excepciones = controlador.ObtenerExcepcionesSeptimo(emp.Id, anio);

                // 3) Días trabajados (Presente o Permiso CON goce)
                int diasTrabajados = asistencias
                    .Where(a =>
                        a.Estado == "Presente" ||
                        (a.Estado == "Permiso"
                         && permisos.Any(p => p.ConGoce
                                           && a.Fecha >= p.Inicio
                                           && a.Fecha <= p.Fin)))
                    .Select(a => a.Fecha.Date)
                    .Distinct()
                    .Count();

                // 4) Faltas (incluye Permiso SIN goce y estado "Falta")
                var faltas = asistencias
                    .Where(a =>
                        !(a.Estado == "Presente"
                       || (a.Estado == "Permiso"
                           && permisos.Any(p => p.ConGoce
                                             && a.Fecha >= p.Inicio
                                             && a.Fecha <= p.Fin))))
                    .Select(a => a.Fecha.Date)
                    .Distinct()
                    .ToList();

                // 5) Horas extra (>8h diarias)
                double totalHE = asistencias
                    .Select(a => (a.HoraSalida - a.HoraEntrada).TotalHours - 8)
                    .Where(h => h > 0)
                    .Sum();

                // 6) Deducción de séptimo día por cada semana con faltas no exentas
                var semanasConFaltas = faltas
                    .Select(f => GetSemanaDelAño(f, anio))
                    .Distinct();

                int semanasADescuentar = semanasConFaltas
                    .Count(sem => !excepciones.Any(e => e.Semana == sem && e.Exento));

                decimal desc7mo = semanasADescuentar * (emp.SalarioBase / diasLaborales);

                // 7) Montos parciales
                decimal pagoBase = (emp.SalarioBase / diasLaborales) * diasTrabajados;
                decimal pagoHE = (decimal)totalHE * emp.SalarioHora * 1.5m;
                decimal descFaltas = faltas.Count * (emp.SalarioHora * 8m);

                // 8) Salario total
                decimal salarioTotal = pagoBase
                                     + pagoHE
                                     - (descFaltas + desc7mo);

                /// Insertar en tbl_salarios_mensuales
                controlador.InsertarSalarioMensual(new Sentencia.SalarioMensualRecord
                {
                    IdEmpleado = emp.Id,
                    Mes = mes,
                    Anio = anio,
                    PagoBase = pagoBase,
                    PagoHorasExtra = pagoHE,
                    Deducciones = descFaltas + desc7mo,
                    SalarioTotal = salarioTotal
                });
            }
        }

        private int DiasLaboralesMes(int mes, int anio)
        {
            int total = DateTime.DaysInMonth(anio, mes), labor = 0;
            for (int d = 1; d <= total; d++)
            {
                var day = new DateTime(anio, mes, d).DayOfWeek;
                if (day != DayOfWeek.Saturday && day != DayOfWeek.Sunday)
                    labor++;
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
