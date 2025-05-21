using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_AsistenciaYFaltas;
using System.Data;

namespace Capa_Controlador_AsistenciaYFaltas
{
    public class Controlador
    {
        private readonly Sentencia sn = new Sentencia();
        // 1) Inserta cada línea cruda en tbl_asistencias_preeliminar
        public void InsertarAsistenciaPreliminar(string linea)
        {
            sn.InsertarAsistenciaPreeliminar(linea);
        }

        

        // 3) Inserta las filas pendientes desde staging a tbl_asistencias (SP)
        //public void ProcesarAsistenciasPreliminar()
        //{
        //    sn.ProcesarAsistenciasPreeliminarTodas();
        //}

        // 4) Opcional: limpia el staging tras procesar
        public void LimpiarStaging()
        {
            sn.LimpiarStaging();
        }

        // 5) Devuelve todos los empleados activos (con salario, hora y jornada)
        public List<Sentencia.Empleado> ObtenerEmpleados()
        {
            return sn.ObtenerEmpleadosActivos();
        }

        // 6) Obtiene permisos aprobados para un empleado en mes/año
        public List<Sentencia.PermisoInfo> ObtenerPermisosEmpleado(int idEmpleado, int mes, int anio)
        {
            return sn.GetPermisos(idEmpleado, mes, anio);
        }

        // 7) Obtiene exenciones de séptimo día de un empleado para un año
        public List<Sentencia.ExcepcionInfo> ObtenerExcepcionesSeptimo(int idEmpleado, int anio)
        {
            return sn.GetExcepcionesSeptimo(idEmpleado, anio);
        }

        // 8) Registra una exención de séptimo día
        public void AgregarExcepcionSeptimo(int idEmpleado, int semana, int anio)
        {
            sn.InsertarExcepcionSeptimo(idEmpleado, semana, anio);
        }

        // 9) Inserta el registro calculado de salario mensual
        public void InsertarSalarioMensual(Sentencia.SalarioMensualRecord salario)
        {
            sn.InsertarSalarioMensual(salario);
        }
        // 10
        public List<Sentencia.AsistenciaInfo> ObtenerAsistenciasEmpleado(int idEmpleado, int mes, int anio)
        {
            return sn.GetAsistencias(idEmpleado, mes, anio);
        }



        public List<Sentencia.AsistenciaInfo> ObtenerAsistenciasPreeliminarInfo()
{
            return sn.GetAsistenciasPreeliminarInfo();
        }

        // 12) Insertar horas extra detectadas
        public void InsertarHorasExtra(Sentencia.HorasExtraRecord horas)
        {
            sn.InsertarHorasExtra(horas);
        }

        public void InsertarFalta(Sentencia.FaltaRecord falta)
        {
            sn.InsertarFalta(falta);
        }
        public void InsertarAsistenciaProcesada(int idEmpleado, DateTime fecha, TimeSpan horaEntrada, TimeSpan horaSalida, string estado)
        {
            sn.InsertarAsistenciaProcesada(idEmpleado, fecha, horaEntrada, horaSalida, estado);
        }

        
        public List<Sentencia.FaltaRecord> ObtenerFaltasPorEmpleado(int idEmpleado, int mes, int anio)
        {
            return sn.ObtenerFaltasEmpleado(idEmpleado, mes, anio);
        }

     
        public List<Sentencia.HorasExtraRecord> ObtenerHorasExtraPorEmpleado(int idEmpleado, int mes, int anio)
        {
            return sn.ObtenerHorasExtraEmpleado(idEmpleado, mes, anio);
        }

    }
}