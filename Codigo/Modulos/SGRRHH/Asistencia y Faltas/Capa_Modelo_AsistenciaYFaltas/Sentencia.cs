using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_AsistenciaYFaltas
{
    public class Sentencia
    {
        Conexion cn = new Conexion();
        // Obtiene empleados activos con su salario desde el contrato
        public List<Empleado> ObtenerEmpleadosActivos()
        {
            var lista = new List<Empleado>();
            string sql = @"
                SELECT e.pk_clave, c.contratos_salario
                FROM tbl_empleados e
                JOIN tbl_contratos c
                  ON c.fk_clave_empleado = e.pk_clave
                WHERE e.estado = 1
                  AND c.estado = 1";
            var cmd = new OdbcCommand(sql, cn.conexion());
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                decimal salarioBase = dr.GetDecimal(1);
                // Suponemos 160 horas laborales al mes para derivar salario horario
                decimal salarioHora = salarioBase / 160m;

                lista.Add(new Empleado
                {
                    Id = dr.GetInt32(0),
                    SalarioBase = salarioBase,
                    SalarioHora = salarioHora
                });
            }
            dr.Close();
            return lista;
        }

   
        public class Empleado
        {
            public int Id { get; set; }
            public decimal SalarioBase { get; set; }
            public decimal SalarioHora { get; set; }
        }

        public List<AsistenciaInfo> GetAsistencias(int idEmpleado, int mes, int anio)
        {
            var lista = new List<AsistenciaInfo>();
            string sql = @"
                SELECT fecha, hora_entrada, hora_salida, estado_asistencia 
                FROM tbl_asistencias 
                WHERE fk_id_empleado = ? AND MONTH(fecha) = ? AND YEAR(fecha) = ?;";
            var cmd = new OdbcCommand(sql, cn.conexion());
            cmd.Parameters.AddWithValue("?", idEmpleado);
            cmd.Parameters.AddWithValue("?", mes);
            cmd.Parameters.AddWithValue("?", anio);

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new AsistenciaInfo
                {
                    Fecha = dr.GetDateTime(0),
                    HoraEntrada = TimeSpan.Parse(dr.GetString(1)),
                    HoraSalida = TimeSpan.Parse(dr.GetString(2)),
                    Estado = dr.GetString(3)
                });
            }
            dr.Close();
            return lista;
        }

        public void InsertarAsistenciaPreeliminar(string linea)
        {
            var cmd = new OdbcCommand("CALL insertar_asistencia_preeliminar(?)", cn.conexion());
            cmd.Parameters.AddWithValue("?", linea);
            cmd.ExecuteNonQuery();
        }

        public List<PermisoInfo> GetPermisos(int idEmpleado, int mes, int anio)
        {
            var lista = new List<PermisoInfo>();
            string sql = @"
                SELECT fecha_inicio, fecha_fin, aprobado, con_goce_sueldo
                FROM tbl_permisos
                WHERE fk_id_empleado = ?
                  AND MONTH(fecha_inicio) = ? AND YEAR(fecha_inicio) = ?
                  AND aprobado = 1;";
            var cmd = new OdbcCommand(sql, cn.conexion());
            cmd.Parameters.AddWithValue("?", idEmpleado);
            cmd.Parameters.AddWithValue("?", mes);
            cmd.Parameters.AddWithValue("?", anio);

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new PermisoInfo
                {
                    Inicio = dr.GetDateTime(0),
                    Fin = dr.GetDateTime(1),
                    Aprobado = dr.GetInt32(2) == 1,
                    ConGoce = dr.GetInt32(3) == 1
                });
            }
            dr.Close();
            return lista;
        }

        public List<ExcepcionInfo> GetExcepcionesSeptimo(int idEmpleado, int anio)
        {
            var lista = new List<ExcepcionInfo>();
            string sql = @"
                SELECT semana, anio, exento
                FROM tbl_excepcion_septimo
                WHERE fk_id_empleado = ? AND anio = ?;";
            var cmd = new OdbcCommand(sql, cn.conexion());
            cmd.Parameters.AddWithValue("?", idEmpleado);
            cmd.Parameters.AddWithValue("?", anio);

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new ExcepcionInfo
                {
                    Semana = dr.GetInt32(0),
                    Anio = dr.GetInt32(1),
                    Exento = dr.GetInt32(2) == 1
                });
            }
            dr.Close();
            return lista;
        }

        public void InsertarSalarioMensual(SalarioMensualRecord sal)
        {
            string sql = @"
        INSERT INTO tbl_salarios_mensuales
        (fk_id_empleado, mes, anio, pago_base, pago_horas_extra, deducciones, salario_total)
        VALUES (?, ?, ?, ?, ?, ?, ?);";
            var cmd = new OdbcCommand(sql, cn.conexion());
            cmd.Parameters.AddWithValue("?", sal.IdEmpleado);
            cmd.Parameters.AddWithValue("?", sal.Mes);
            cmd.Parameters.AddWithValue("?", sal.Anio);
            cmd.Parameters.AddWithValue("?", sal.PagoBase);
            cmd.Parameters.AddWithValue("?", sal.PagoHorasExtra);
            cmd.Parameters.AddWithValue("?", sal.Deducciones);
            cmd.Parameters.AddWithValue("?", sal.SalarioTotal);
            cmd.ExecuteNonQuery();
        }

        public void InsertarExcepcionSeptimo(int idEmpleado, int semana, int anio)
        {
            var cmd = new OdbcCommand(
                "INSERT INTO tbl_excepcion_septimo (fk_id_empleado, semana, anio, exento) VALUES (?, ?, ?, 1);",
                cn.conexion());
            cmd.Parameters.AddWithValue("?", idEmpleado);
            cmd.Parameters.AddWithValue("?", semana);
            cmd.Parameters.AddWithValue("?", anio);
            cmd.ExecuteNonQuery();
        }

        // Nuevo método para registrar salario mensual
      

        // Modelos
        public class AsistenciaInfo
        {
            public DateTime Fecha { get; set; }
            public TimeSpan HoraEntrada { get; set; }
            public TimeSpan HoraSalida { get; set; }
            public string Estado { get; set; }
        }

        public class PermisoInfo
        {
            public DateTime Inicio { get; set; }
            public DateTime Fin { get; set; }
            public bool Aprobado { get; set; }
            public bool ConGoce { get; set; }
        }

        public class ExcepcionInfo
        {
            public int Semana { get; set; }
            public int Anio { get; set; }
            public bool Exento { get; set; }
        }

        public class NominaRecord
        {
            public int IdEmpleado { get; set; }
            public int Mes { get; set; }
            public int Anio { get; set; }
            public decimal PagoBase { get; set; }
            public decimal PagoHorasExtra { get; set; }
            public decimal Deducciones { get; set; }
        }

        // Nuevo DTO para salarios mensuales
        public class SalarioMensualRecord
        {
            public int IdEmpleado { get; set; }
            public int Mes { get; set; }
            public int Anio { get; set; }
            public decimal PagoBase { get; set; }
            public decimal PagoHorasExtra { get; set; }
            public decimal Deducciones { get; set; }
            public decimal SalarioTotal { get; set; }
        }
    }
}
