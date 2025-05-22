using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Globalization;

namespace Capa_Modelo_AsistenciaYFaltas
{
    public class Sentencia
    {
        Conexion cn = new Conexion();


        // 2) Insertar línea cruda en staging
        public void InsertarAsistenciaPreeliminar(string linea)
        {
            using (var cmd = new OdbcCommand("INSERT INTO tbl_asistencias_preeliminar(linea) VALUES(?)", cn.conexion()))
            {
                cmd.Parameters.AddWithValue("?", linea);
                cmd.ExecuteNonQuery();
            }
        }

        // 3) Leer asistencias desde staging (para el botón Cargar)
        public List<AsistenciaInfo> GetAsistenciasPreeliminarInfo()
        {
            var lineas = GetAsistenciasPreeliminar();  // List<string>
            var lista = new List<AsistenciaInfo>();

            foreach (var linea in lineas)
            {
                // Mismo parseo que tenías en el Form, pero aquí:
                var partes = linea.Split(']');
                if (partes.Length < 2) continue;

                string fechaTexto = partes[0].Trim('[', ']');
                string resto = partes[1].TrimStart(':');
                var hv = resto.Split(',');
                var horas = hv[0].Split('-');
                if (hv.Length < 2 || horas.Length < 2) continue;

                if (!DateTime.TryParseExact(fechaTexto, "dd-MM-yyyy",
                        CultureInfo.InvariantCulture, DateTimeStyles.None, out var fecha))
                    continue;
                if (!TimeSpan.TryParse(horas[0], out var he)) continue;
                if (!TimeSpan.TryParse(horas[1], out var hs)) continue;
                if (!int.TryParse(hv[1].Trim('.'), out var idEmp)) continue;

                var estado = (he == TimeSpan.Zero && hs == TimeSpan.Zero) ? "Falta" : "Presente";

                lista.Add(new AsistenciaInfo
                {
                    IdEmpleado = idEmp,
                    Fecha = fecha,
                    HoraEntrada = he,
                    HoraSalida = hs,
                    Estado = estado
                });
            }

            return lista;
        }

        // 4) Ejecutar SP que vuelca staging a tbl_asistencias
        //public void ProcesarAsistenciasPreeliminarTodas()
        //{
        //    using (var cmd = new OdbcCommand("CALL procesar_asistencias_preeliminar();", cn.conexion()))
        //    {
        //        cmd.ExecuteNonQuery();
        //    }
        //}

        // 5) Limpiar staging tras procesar (opcional)
        public void LimpiarStaging()
        {
            using (var cmd = new OdbcCommand(
                "DELETE FROM tbl_asistencias_preeliminar WHERE procesada = 1;", cn.conexion()))
            {
                cmd.ExecuteNonQuery();
            }
        }

        // 6) Permisos aprobados en el mes/año
        public List<PermisoInfo> GetPermisos(int idEmpleado, int mes, int anio)
        {
            var lista = new List<PermisoInfo>();
            string sql = @"
                SELECT fecha_inicio, fecha_fin, aprobado, con_goce_sueldo
                  FROM tbl_permisos
                 WHERE fk_id_empleado = ?
                   AND MONTH(fecha_inicio) = ?
                   AND YEAR(fecha_inicio) = ?
                   AND aprobado = 1;";

            using (var cmd = new OdbcCommand(sql, cn.conexion()))
            {
                cmd.Parameters.AddWithValue("?", idEmpleado);
                cmd.Parameters.AddWithValue("?", mes);
                cmd.Parameters.AddWithValue("?", anio);

                using (var dr = cmd.ExecuteReader())
                {
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
                }
            }

            return lista;
        }

        // 7) Excepciones de séptimo día
        public List<ExcepcionInfo> GetExcepcionesSeptimo(int idEmpleado, int anio)
        {
            var lista = new List<ExcepcionInfo>();
            string sql = @"
                SELECT semana, anio, exento
                  FROM tbl_excepcion_septimo
                 WHERE fk_id_empleado = ?
                   AND anio = ?;";

            using (var cmd = new OdbcCommand(sql, cn.conexion()))
            {
                cmd.Parameters.AddWithValue("?", idEmpleado);
                cmd.Parameters.AddWithValue("?", anio);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new ExcepcionInfo
                        {
                            Semana = dr.GetInt32(0),
                            Anio = dr.GetInt32(1),
                            Exento = dr.GetInt32(2) == 1
                        });
                    }
                }
            }

            return lista;
        }

        // 8) Persistir salario mensual
        public void InsertarSalarioMensual(SalarioMensualRecord sal)
        {
            string sql = @"
                INSERT INTO tbl_salarios_mensuales
                  (fk_id_empleado, mes, anio, pago_base,
                   pago_horas_extra, deducciones, salario_total)
                VALUES (?, ?, ?, ?, ?, ?, ?);";

            using (var cmd = new OdbcCommand(sql, cn.conexion()))
            {
                cmd.Parameters.AddWithValue("?", sal.IdEmpleado);
                cmd.Parameters.AddWithValue("?", sal.Mes);
                cmd.Parameters.AddWithValue("?", sal.Anio);
                cmd.Parameters.AddWithValue("?", sal.PagoBase);
                cmd.Parameters.AddWithValue("?", sal.PagoHorasExtra);
                cmd.Parameters.AddWithValue("?", sal.Deducciones);
                cmd.Parameters.AddWithValue("?", sal.SalarioTotal);
                cmd.ExecuteNonQuery();
            }
        }

        // 9) Registrar exención de séptimo día
        public void InsertarExcepcionSeptimo(int idEmpleado, int semana, int anio)
        {
            using (var cmd = new OdbcCommand(
                "INSERT INTO tbl_excepcion_septimo (fk_id_empleado, semana, anio, exento) VALUES (?, ?, ?, 1);",
                cn.conexion()))
            {
                cmd.Parameters.AddWithValue("?", idEmpleado);
                cmd.Parameters.AddWithValue("?", semana);
                cmd.Parameters.AddWithValue("?", anio);
                cmd.ExecuteNonQuery();
            }
        }

        public List<AsistenciaInfo> GetAsistencias(int idEmpleado, int mes, int anio)
        {
            var lista = new List<AsistenciaInfo>();
            string sql = @"
        SELECT fecha, hora_entrada, hora_salida, estado_asistencia 
          FROM tbl_asistencias
         WHERE fk_id_empleado = ?
           AND MONTH(fecha) = ?
           AND YEAR(fecha) = ?;";

            using (var cmd = new OdbcCommand(sql, cn.conexion()))
            {
                cmd.Parameters.AddWithValue("?", idEmpleado);
                cmd.Parameters.AddWithValue("?", mes);
                cmd.Parameters.AddWithValue("?", anio);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new AsistenciaInfo
                        {
                            Fecha = dr.GetDateTime(0),
                            HoraEntrada = TimeSpan.Parse(dr.GetString(1)),
                            HoraSalida = TimeSpan.Parse(dr.GetString(2)),
                            Estado = dr.GetString(3),
                            IdEmpleado = idEmpleado
                        });
                    }
                }
            }

            return lista;
        }

        public List<string> GetAsistenciasPreeliminar()
        {
            List<string> lista = new List<string>();
            string sql = "SELECT linea FROM tbl_asistencias_preeliminar WHERE procesada = 0;";
            using (var cmd = new OdbcCommand(sql, cn.conexion()))
            {
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(dr.GetString(0));
                    }
                }
            }
            return lista;
        }


        public List<Empleado> ObtenerEmpleadosActivos()
        {
            var lista = new List<Empleado>();
            string sql = @"
        SELECT e.pk_clave,
               e.empleados_nombre,
               e.empleados_apellido,
               c.contratos_salario,
               c.contratos_jornada_semanal
        FROM tbl_empleados e
        JOIN tbl_contratos c
          ON c.fk_clave_empleado = e.pk_clave
        WHERE e.estado = 1
          AND c.estado = 1;";
            var cmd = new OdbcCommand(sql, cn.conexion());
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                decimal salarioBase = dr.GetDecimal(3);
                int jornadaSemanal = dr.GetInt32(4);
                decimal salarioHora = salarioBase / (jornadaSemanal * 4m);

                lista.Add(new Empleado
                {
                    Id = dr.GetInt32(0),
                    Nombre = dr.GetString(1),
                    Apellido = dr.GetString(2),
                    SalarioBase = salarioBase,
                    JornadaSemanal = jornadaSemanal,
                    SalarioHora = salarioHora
                });
            }

            dr.Close();
            return lista;
        }


        public class Empleado
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public decimal SalarioBase { get; set; }
            public decimal SalarioHora { get; set; }
            public int JornadaSemanal { get; set; }
        }

        public void InsertarAsistenciaProcesada(int idEmpleado, DateTime fecha, TimeSpan horaEntrada, TimeSpan horaSalida, string estado)
        {
            string sql = @"
        INSERT INTO tbl_asistencias (fk_id_empleado, fecha, hora_entrada, hora_salida, estado_asistencia)
        VALUES (?, ?, ?, ?, ?);";

            using (var cmd = new OdbcCommand(sql, cn.conexion()))
            {
                cmd.Parameters.AddWithValue("?", idEmpleado);
                cmd.Parameters.AddWithValue("?", fecha);
                cmd.Parameters.AddWithValue("?", horaEntrada);
                cmd.Parameters.AddWithValue("?", horaSalida);
                cmd.Parameters.AddWithValue("?", estado);
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertarFalta(FaltaRecord falta)
        {
            string sql = @"INSERT INTO tbl_control_faltas
        (faltas_fecha_falta, faltas_mes, faltas_justificacion,
         fk_clave_empleado, estado, justificada, fk_id_permiso, fk_id_excepcion)
        VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

            using (var cmd = new OdbcCommand(sql, cn.conexion()))
            {
                cmd.Parameters.AddWithValue("?", falta.Fecha);
                cmd.Parameters.AddWithValue("?", falta.MesTexto);
                cmd.Parameters.AddWithValue("?", falta.Justificacion);
                cmd.Parameters.AddWithValue("?", falta.IdEmpleado);
                cmd.Parameters.AddWithValue("?", falta.Estado);
                cmd.Parameters.AddWithValue("?", falta.Justificada);
                cmd.Parameters.AddWithValue("?", (object)falta.IdPermiso ?? DBNull.Value);
                cmd.Parameters.AddWithValue("?", (object)falta.IdExcepcion ?? DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertarHorasExtra(HorasExtraRecord horas)
        {
            string sql = @"INSERT INTO tbl_horas_extra
        (horas_mes, horas_cantidad_horas, fk_clave_empleado, estado)
        VALUES (?, ?, ?, ?)";

            using (var cmd = new OdbcCommand(sql, cn.conexion()))
            {
                cmd.Parameters.AddWithValue("?", horas.MesTexto);
                cmd.Parameters.AddWithValue("?", horas.CantidadHoras);
                cmd.Parameters.AddWithValue("?", horas.IdEmpleado);
                cmd.Parameters.AddWithValue("?", horas.Estado);
                cmd.ExecuteNonQuery();
            }
        }

        // 10) Obtener faltas de un empleado en un mes/año
        public List<FaltaRecord> ObtenerFaltasEmpleado(int idEmpleado, int mes, int anio)
        {
            var lista = new List<FaltaRecord>();
            string sql = @"
        SELECT faltas_fecha_falta, faltas_mes, faltas_justificacion,
               fk_clave_empleado, estado, justificada,
               fk_id_permiso, fk_id_excepcion
          FROM tbl_control_faltas
         WHERE fk_clave_empleado = ?
           AND MONTH(faltas_fecha_falta) = ?
           AND YEAR(faltas_fecha_falta) = ?;";

            using (var cmd = new OdbcCommand(sql, cn.conexion()))
            {
                cmd.Parameters.AddWithValue("?", idEmpleado);
                cmd.Parameters.AddWithValue("?", mes);
                cmd.Parameters.AddWithValue("?", anio);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new FaltaRecord
                        {
                            Fecha = dr.GetDateTime(0),
                            MesTexto = dr.GetString(1),
                            Justificacion = dr.GetString(2),
                            IdEmpleado = dr.GetInt32(3),
                            Estado = dr.GetInt32(4),
                            Justificada = dr.GetInt32(5),
                            IdPermiso = dr.IsDBNull(6) ? (int?)null : dr.GetInt32(6),
                            IdExcepcion = dr.IsDBNull(7) ? (int?)null : dr.GetInt32(7)
                        });
                    }
                }
            }

            return lista;
        }

        // 11) Obtener horas extra de un empleado en un mes/año
        public List<HorasExtraRecord> ObtenerHorasExtraEmpleado(int idEmpleado, int mes, int anio)
        {
            var lista = new List<HorasExtraRecord>();
            // Asumo que 'horas_mes' es el nombre del mes, y no hay año en la tabla;
            // filtramos por empleado y mes-calculado en C#
            string sql = @"
        SELECT horas_mes, horas_cantidad_horas, fk_clave_empleado, estado
          FROM tbl_horas_extra
         WHERE fk_clave_empleado = ?;";

            using (var cmd = new OdbcCommand(sql, cn.conexion()))
            {
                cmd.Parameters.AddWithValue("?", idEmpleado);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var mesTexto = dr.GetString(0);
                        // Convertir mesTexto+anio a fecha para filtrar
                        if (DateTime.TryParseExact(
                                $"01-{mesTexto}-{anio}",
                                "dd-MMMM-yyyy",
                                CultureInfo.InvariantCulture,
                                DateTimeStyles.None,
                                out var fecha))
                        {
                            if (fecha.Month == mes)
                            {
                                lista.Add(new HorasExtraRecord
                                {
                                    MesTexto = mesTexto,
                                    CantidadHoras = dr.GetInt32(1),
                                    IdEmpleado = dr.GetInt32(2),
                                    Estado = dr.GetInt32(3)
                                });
                            }
                        }
                    }
                }
            }

            return lista;
        }


        public class AsistenciaInfo
        {
            public DateTime Fecha { get; set; }
            public TimeSpan HoraEntrada { get; set; }
            public TimeSpan HoraSalida { get; set; }
            public string Estado { get; set; }
            public int IdEmpleado { get; set; }
        }

        public class PermisoInfo
        {
            public DateTime Inicio { get; set; }
            public DateTime Fin { get; set; }
            public bool Aprobado { get; set; }
            public bool ConGoce { get; set; }
        }
        public class FaltaRecord
        {
            public DateTime Fecha { get; set; }
            public string MesTexto { get; set; }
            public string Justificacion { get; set; }
            public int IdEmpleado { get; set; }
            public int Estado { get; set; }
            public int Justificada { get; set; }
            public int? IdPermiso { get; set; }
            public int? IdExcepcion { get; set; }
        }
        public class HorasExtraRecord
        {
            public string MesTexto { get; set; }
            public int CantidadHoras { get; set; }
            public int IdEmpleado { get; set; }
            public int Estado { get; set; }
        }
        public class ExcepcionInfo
        {
            public int Semana { get; set; }
            public int Anio { get; set; }
            public bool Exento { get; set; }
        }

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
