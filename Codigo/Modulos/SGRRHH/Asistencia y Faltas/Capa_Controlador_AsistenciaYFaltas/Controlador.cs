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

        // Inserta asistencia cruda en tabla preliminar
        public void InsertarAsistenciaPreliminar(string linea)
        {
            sn.InsertarAsistenciaPreeliminar(linea);
        }

        // Obtener todos los empleados activos
        public List<Sentencia.Empleado> ObtenerEmpleados()
        {
            return sn.ObtenerEmpleadosActivos();
        }

        // Obtener asistencias de un empleado en un mes y año
        public List<Sentencia.AsistenciaInfo> ObtenerAsistenciasEmpleado(int idEmpleado, int mes, int anio)
        {
            return sn.GetAsistencias(idEmpleado, mes, anio);
        }

        // Obtener permisos de un empleado en un mes y año
        public List<Sentencia.PermisoInfo> ObtenerPermisosEmpleado(int idEmpleado, int mes, int anio)
        {
            return sn.GetPermisos(idEmpleado, mes, anio);
        }

        // Obtener excepciones de séptimo día de un empleado
        public List<Sentencia.ExcepcionInfo> ObtenerExcepcionesSeptimo(int idEmpleado, int anio)
        {
            return sn.GetExcepcionesSeptimo(idEmpleado, anio);
        }


        // Registrar exención de séptimo día
        public void AgregarExcepcionSeptimo(int idEmpleado, int semana, int anio)
        {
            sn.InsertarExcepcionSeptimo(idEmpleado, semana, anio);
        }

        // Insertar registro en tbl_salarios_mensuales
        public void InsertarSalarioMensual(Sentencia.SalarioMensualRecord salario)
        {
            sn.InsertarSalarioMensual(salario);
        }
    }
}

