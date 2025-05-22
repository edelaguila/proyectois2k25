using Capa_Modelo_Liquidaciones;
using System;
using System.Data;

namespace Capa_Controlador_Liquidaciones
{
    public class Controlador
    {
        /* ------------------------------------------- Código por Gabriela Suc ------------------------------------------- */

        Sentencias sn = new Sentencias();

        // Método para obtener todos los empleados
        public DataTable meObtenerEmpleados()
        {
            return sn.funObtenerEmpleados();
        }

        // Método para obtener el salario de un empleado
        public decimal meObtenerSalario(int empleadoId)
        {
            return sn.meObtenerSalario(empleadoId);
        }

        // Método para obtener la fecha de alta de un empleado
        public DateTime? meObtenerFechaAlta(int empleadoId)
        {
            return sn.meObtenerFechaAlta(empleadoId);
        }

        // Método para obtener la fecha de baja de un empleado
        public DateTime? meObtenerFechaBaja(int empleadoId)
        {
            return sn.meObtenerFechaBaja(empleadoId);
        }

        // Método para calcular los días laborados de un empleado en el año actual
        public int meCalcularDiasLaborados(int empleadoId)
        {
            return sn.meCalcularDiasLaborados(empleadoId);
        }


        // Método para calcular el aguinaldo
        public decimal meCalcularAguinaldo(int empleadoId, int diasLaborados)
        {
            decimal salario = meObtenerSalario(empleadoId);
            return sn.meCalcularAguinaldo(empleadoId, diasLaborados, salario);
        }

        // Insertar el cálculo del aguinaldo en la tabla
        public void meGuardarAguinaldoDeduPerpEmp(int empleadoId, decimal aguinaldo)
        {
            try
            {
                sn.meInsertarAguinaldoDeduPerpEmp(empleadoId, aguinaldo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el aguinaldo en tbl_dedu_perp_emp: " + ex.Message);
            }
        }

        // Insertar el aguinaldo en la tabla
        public void meGuardarAguinaldoLiquidacionTrabajadores(int empleadoId, decimal aguinaldo, int diasLaborados, decimal vacaciones, decimal bono14)
        {
            try
            {
                sn.meInsertarAguinaldoLiquidacionTrabajadores(empleadoId, aguinaldo, diasLaborados, vacaciones, bono14);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el aguinaldo en tbl_liquidacion_trabajadores: " + ex.Message);
            }
        }

        // Método para calcular las vacaciones
        public decimal meCalcularVacaciones(int empleadoId, int diasLaborados)
        {
            decimal salario = meObtenerSalario(empleadoId);
            return sn.meCalcularVacaciones(empleadoId, diasLaborados, salario);
        }

        // Insertar el cálculo de las vacaciones en la tabla tbl_dedu_perp_emp
        public void meInsertarVacacionesDeduPerpEmp(int empleadoId, decimal vacaciones)
        {
            try
            {
                sn.proInsertarVacacionesDeduPerpEmp(empleadoId, vacaciones);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar las vacaciones en tbl_dedu_perp_emp: " + ex.Message);
            }
        }

        // Método para calcular el Bono 14
        public decimal meCalcularBono14(int empleadoId)
        {
            decimal salario = meObtenerSalario(empleadoId);

            // Calcular el Bono 14
            return sn.meCalcularBono14(empleadoId, salario);
        }

        // Insertar el cálculo del Bono 14 en la tabla tbl_dedu_perp_emp
        public void meInsertarBono14DeduPerpEmp(int empleadoId, decimal bono14)
        {
            try
            {
                sn.meInsertarBono14DeduPerpEmp(empleadoId, bono14);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el Bono 14 en tbl_dedu_perp_emp: " + ex.Message);
            }
        }

        public bool meVerificarExistenciaLiquidacion(int empleadoId)
        {
            return sn.meVerificarExistenciaLiquidacion(empleadoId);
        }

        public DataTable meObtenerLiquidacionesTrabajadores()
        {
            return sn.funObtenerLiquidacionesTrabajadores();
        }
    }
}
