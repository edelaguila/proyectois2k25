using Capa_Modelo_Capacitacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa_Modelo_Capacitacion
{
    public class sentencias
    {
        conexion con = new conexion();

        public List<KeyValuePair<int, string>> ObtenerNiveles()
        {
            List<KeyValuePair<int, string>> listaNiveles = new List<KeyValuePair<int, string>>();

            string query = "SELECT pk_id_nivel, nivel_nombre FROM tbl_nivelcompetencia WHERE estado = 1"; // Filtro por estado activo

            using (OdbcConnection conn = con.Conexion())
            {
                if (conn != null)
                {
                    OdbcCommand cmd = new OdbcCommand(query, conn);
                    OdbcDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listaNiveles.Add(
                            new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1))
                        );
                    }

                    reader.Close();
                    con.desconexion(conn); // opcional, el using también la cierra
                }
            }

            return listaNiveles;
        }


        // Método para obtener empleados
        public List<KeyValuePair<int, string>> ObtenerEmpleados()
        {
            List<KeyValuePair<int, string>> listaEmpleados = new List<KeyValuePair<int, string>>();
            string query = "SELECT pk_clave, empleados_nombre FROM tbl_empleados";

            using (OdbcConnection conn = con.Conexion())
            {
                if (conn != null)
                {
                    OdbcCommand cmd = new OdbcCommand(query, conn);
                    OdbcDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listaEmpleados.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                    }

                    reader.Close();
                    con.desconexion(conn);
                }
            }

            return listaEmpleados;
        }

        // Método para obtener capacitaciones
        public List<KeyValuePair<int, string>> ObtenerCapacitaciones()
        {
            List<KeyValuePair<int, string>> listaCapacitaciones = new List<KeyValuePair<int, string>>();
            string query = "SELECT pk_id_capacitacion, capacitaciones_nombre FROM tbl_capacitaciones";

            using (OdbcConnection conn = con.Conexion())
            {
                if (conn != null)
                {
                    OdbcCommand cmd = new OdbcCommand(query, conn);
                    OdbcDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listaCapacitaciones.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                    }

                    reader.Close();
                    con.desconexion(conn);
                }
            }

            return listaCapacitaciones;
        }

        public int InsertarNota(int fkEmpleado, int fkCapacitacion, int fknivel, decimal puntaje, string fecha)
        {
            int idGenerado = 0;
            using (OdbcConnection cnx = con.Conexion())
            {
                string query = "INSERT INTO tbl_notas (fk_id_empleado, fk_id_capacitacion, fk_id_nivel, notas_puntaje, notas_fecha, estado) " +
                               "VALUES (?, ?, ?, ?, ?, 1)";

                using (OdbcCommand cmd = new OdbcCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@fkEmpleado", fkEmpleado);
                    cmd.Parameters.AddWithValue("@fkCapacitacion", fkCapacitacion);
                    cmd.Parameters.AddWithValue("@nivel", fknivel);
                    cmd.Parameters.AddWithValue("@puntaje", puntaje.ToString(System.Globalization.CultureInfo.InvariantCulture));
                    cmd.Parameters.AddWithValue("@fecha", fecha);

                    cmd.ExecuteNonQuery();

                    // Obtener el ID autogenerado
                    cmd.CommandText = "SELECT LAST_INSERT_ID()";
                    using (OdbcCommand cmdId = new OdbcCommand("SELECT LAST_INSERT_ID()", cnx))
                    {
                        idGenerado = Convert.ToInt32(cmdId.ExecuteScalar());
                    }
                }
            }
            return idGenerado;
        }


        // Dentro de la clase Sentencias
        public int ObtenerIdEmpleado(string nombreEmpleado)
        {
            int id = 0;
            using (OdbcConnection cnx = con.Conexion())
            {
                string query = "SELECT pk_clave FROM tbl_empleados WHERE empleados_nombre = ?";
                using (OdbcCommand cmd = new OdbcCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@nombreEmpleado", nombreEmpleado);
                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = reader.GetInt32(0);
                        }
                    }
                }
            }
            return id;
        }

        public int ObtenerIdCapacitacion(string nombreCapacitacion)
        {
            int id = 0;
            using (OdbcConnection cnx = con.Conexion())
            {
                string query = "SELECT pk_id_capacitacion FROM tbl_capacitaciones WHERE capacitaciones_nombre = ?";
                using (OdbcCommand cmd = new OdbcCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@nombreCapacitacion", nombreCapacitacion);
                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = reader.GetInt32(0);
                        }
                    }
                }
            }
            return id;
        }


        public DataTable ObtenerNotas()
{
    DataTable tabla = new DataTable();

    using (OdbcConnection cnx = con.Conexion())
    {
        // Consulta SQL actualizada para obtener los nombres de empleados, capacitaciones y niveles
        string query = @"
        SELECT
            n.pk_id_nota,
            e.empleados_nombre AS Empleado,          -- Nombre del empleado
            c.capacitaciones_nombre AS Capacitacion, -- Nombre de la capacitación
            nc.nivel_nombre AS Nivel,                -- Nombre del nivel
            n.notas_puntaje,                         -- Puntaje
            n.notas_fecha,                           -- Fecha de la nota
            n.estado                                 -- Estado de la nota
        FROM tbl_notas n
        INNER JOIN tbl_empleados e ON n.fk_id_empleado = e.pk_clave
        INNER JOIN tbl_capacitaciones c ON n.fk_id_capacitacion = c.pk_id_capacitacion
        INNER JOIN tbl_nivelcompetencia nc ON n.fk_id_nivel = nc.pk_id_nivel
        WHERE n.estado = 1";  // Asegúrate de que 'estado' sea una columna válida

        using (OdbcCommand cmd = new OdbcCommand(query, cnx))
        {
            using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
            {
                da.Fill(tabla);
            }
        }
    }

    return tabla;
}


        public DataTable BusquedaNotas(string filtro)
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection cnx = con.Conexion())
            {
                string query = @"
        SELECT
            n.pk_id_nota,
            e.empleados_nombre AS Empleado,
            c.capacitaciones_nombre AS Capacitacion,
            nc.nivel_nombre AS Nivel,
            n.notas_puntaje,
            n.notas_fecha,
            n.estado
        FROM tbl_notas n
        INNER JOIN tbl_empleados e ON n.fk_id_empleado = e.pk_clave
        INNER JOIN tbl_capacitaciones c ON n.fk_id_capacitacion = c.pk_id_capacitacion
        INNER JOIN tbl_nivelcompetencia nc ON n.fk_id_nivel = nc.pk_id_nivel
        WHERE n.estado = 1 AND (
            e.empleados_nombre LIKE ? OR
            c.capacitaciones_nombre LIKE ? OR
            nc.nivel_nombre LIKE ? OR
            CAST(n.notas_puntaje AS CHAR) LIKE ? OR
            CAST(n.notas_fecha AS CHAR) LIKE ?
        )";

                using (OdbcCommand cmd = new OdbcCommand(query, cnx))
                {
                    string textoBusqueda = "%" + filtro + "%";
                    for (int i = 0; i < 5; i++)
                        cmd.Parameters.AddWithValue("?", textoBusqueda);

                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }

            return tabla;
        }


        //public bool existeNotaEmpleadoCapacitacion(int fkEmpleado, int fkCapacitacion)
        //{
        //    bool existe = false;
        //    string consulta = "SELECT COUNT(*) FROM tbl_notas WHERE fk_id_empleado = @empleado AND fk_id_capacitacion = @capacitacion AND estado = 1";

        //    using (OdbcConnection cnx = con.Conexion())
        //    {
        //        if (cnx != null)
        //        {
        //            using (OdbcCommand cmd = new OdbcCommand(consulta, cnx))
        //            {
        //                cmd.Parameters.AddWithValue("@empleado", fkEmpleado);
        //                cmd.Parameters.AddWithValue("@capacitacion", fkCapacitacion);

        //                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
        //                existe = resultado > 0;
        //            }

        //            con.desconexion(cnx); // Opcional, por si quieres cerrarla explícitamente
        //        }
        //    }

        //    return existe;
        //}

        ////PARA EL MODO EDICION
        //public bool existeNotaEmpleadoCapacitacionExcepto(int idNota, int fkEmpleado, int fkCapacitacion)
        //{
        //    bool existe = false;
        //    string consulta = "SELECT COUNT(*) FROM tbl_notas WHERE fk_id_empleado = ? AND fk_id_capacitacion = ? AND id_nota <> ? AND estado = 1";

        //    using (OdbcConnection cnx = con.Conexion())
        //    {
        //        cnx.Open();

        //        using (OdbcCommand cmd = new OdbcCommand(consulta, cnx))
        //        {
        //            cmd.Parameters.AddWithValue("?", fkEmpleado);
        //            cmd.Parameters.AddWithValue("?", fkCapacitacion);
        //            cmd.Parameters.AddWithValue("?", idNota);

        //            int resultado = Convert.ToInt32(cmd.ExecuteScalar());
        //            existe = resultado > 0;
        //        }
        //    }

        //    return existe;
        //}



        public int ObtenerSiguienteIdNota()
        {
            int siguienteId = 1; // Por defecto en caso de tabla vacía

            using (OdbcConnection cnx = con.Conexion())
            {
                string query = "SELECT IFNULL(MAX(pk_id_nota), 0) + 1 FROM tbl_notas";

                using (OdbcCommand cmd = new OdbcCommand(query, cnx))
                {
                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null)
                    {
                        siguienteId = Convert.ToInt32(resultado);
                    }
                }
            }

            return siguienteId;
        }


        public bool ActualizarNota(int idNota, int fkEmpleado, int fkCapacitacion, string nivel, decimal puntaje, string fecha)
        {
            bool resultado = false;
            using (OdbcConnection cnx = con.Conexion())
            {
                string query = "UPDATE tbl_notas SET fk_id_empleado = ?, fk_id_capacitacion = ?, notas_nivel = ?, notas_puntaje = ?, notas_fecha = ? WHERE pk_id_nota = ?";

                using (OdbcCommand cmd = new OdbcCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@fkEmpleado", fkEmpleado);
                    cmd.Parameters.AddWithValue("@fkCapacitacion", fkCapacitacion);
                    cmd.Parameters.AddWithValue("@nivel", nivel);
                    cmd.Parameters.AddWithValue("@puntaje", puntaje.ToString(System.Globalization.CultureInfo.InvariantCulture));
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@idNota", idNota);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        resultado = true;
                    }
                }
            }
            return resultado;
        }

        public bool EditarNota(int idNota, int fkEmpleado, int fkCapacitacion, int fkNivel, decimal puntaje, string fecha)
        {
            bool exito = false;

            using (OdbcConnection cnx = con.Conexion())
            {
                string query = @"
            UPDATE tbl_notas
            SET 
                fk_id_empleado = ?, 
                fk_id_capacitacion = ?, 
                fk_id_nivel = ?, 
                notas_puntaje = ?, 
                notas_fecha = ?
            WHERE pk_id_nota = ?";

                using (OdbcCommand cmd = new OdbcCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@fk_id_empleado", fkEmpleado);
                    cmd.Parameters.AddWithValue("@fk_id_capacitacion", fkCapacitacion);
                    cmd.Parameters.AddWithValue("@fk_id_nivel", fkNivel);
                    cmd.Parameters.AddWithValue("@notas_puntaje", puntaje);
                    cmd.Parameters.AddWithValue("@notas_fecha", fecha);
                    cmd.Parameters.AddWithValue("@pk_id_nota", idNota);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        exito = true;
                    }
                }
            }

            return exito;
        }

        public bool EliminarNota(int idNota)
        {
            using (OdbcConnection cnx = con.Conexion())
            {
                string query = "UPDATE tbl_notas SET estado = 0 WHERE pk_id_nota = ?";
                using (OdbcCommand cmd = new OdbcCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("?", idNota);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }


    }
}
