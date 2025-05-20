using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Controlador_AsistenciaYFaltas;
using Capa_Modelo_AsistenciaYFaltas;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
namespace Modelo_Vista_AsistenciaYFaltas

{
    public class NominaService
    {

        private Controlador controlador = new Controlador();
        public void GenerarNomina(int mes, int anio)
        {
            // 1) Traer empleados (con SalarioBase, SalarioHora, JornadaSemanal)
            var empleados = controlador.ObtenerEmpleados();
            int diasLaborales = DiasLaboralesMes(mes, anio);

            foreach (var emp in empleados)
            {
                // 2) Leer asistencias ya volcadas en tbl_asistencias
                var asistencias = controlador.ObtenerAsistenciasPreeliminarInfo()
     .Where(a => a.IdEmpleado == emp.Id
              && a.Fecha.Month == mes
              && a.Fecha.Year == anio)
     .ToList();
                var permisos = controlador.ObtenerPermisosEmpleado(emp.Id, mes, anio);
                var excepciones = controlador.ObtenerExcepcionesSeptimo(emp.Id, anio);

                // 3) Contar días trabajados (Presente o Permiso con goce)
                int diasTrabajados = asistencias
             .Where(a => a.Estado == "Presente" || a.Estado == "Permiso")
             .Select(a => a.Fecha.Date)
             .Distinct()
             .Count();

                // 4) Identificar faltas (incluye Permiso sin goce)
                var faltas = asistencias
                    .Where(a =>
                        !(a.Estado == "Presente"
                       || (a.Estado == "Permiso"
                           && permisos.Any(p =>
                                p.ConGoce
                             && a.Fecha >= p.Inicio
                             && a.Fecha <= p.Fin))))
                    .Select(a => a.Fecha.Date)
                    .Distinct()
                    .ToList();
                foreach (var fechaFalta in faltas)
                {
                    var permiso = permisos.FirstOrDefault(p =>
                        fechaFalta >= p.Inicio &&
                        fechaFalta <= p.Fin);

                    controlador.InsertarFalta(new Sentencia.FaltaRecord
                    {
                        Fecha = fechaFalta,
                        MesTexto = new DateTime(anio, mes, 1).ToString("MMMM", CultureInfo.InvariantCulture),
                        Justificacion = permiso != null ? "Permiso" : "Sin justificar",
                        IdEmpleado = emp.Id,
                        Estado = 1,
                        Justificada = permiso != null ? 1 : 0,
                        IdPermiso = permiso != null ? (int?)permisos.IndexOf(permiso) + 1 : null,
                        IdExcepcion = null
                    });
                }

                // 5) Horas extra: excedentes de 8h diarias
                double totalHE = asistencias
                    .Select(a => (a.HoraSalida - a.HoraEntrada).TotalHours - 8)
                    .Where(h => h > 0)
                    .Sum();
                if (totalHE > 0)
                {
                    controlador.InsertarHorasExtra(new Sentencia.HorasExtraRecord
                    {
                        MesTexto = new DateTime(anio, mes, 1).ToString("MMMM", CultureInfo.InvariantCulture),
                        CantidadHoras = (int)Math.Round(totalHE),
                        IdEmpleado = emp.Id,
                        Estado = 1
                    });
                }

                // 6) Semanas con faltas no exentas para séptimo día
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

                // 9) Persistir en tbl_salarios_mensuales
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

        // Días laborales en mes (sin sábados/domingos)
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

        // Semana ISO de una fecha
        private int GetSemanaDelAño(DateTime fecha, int anio)
        {
            return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                fecha,
                CalendarWeekRule.FirstDay,
                DayOfWeek.Monday);
        }
    }
}