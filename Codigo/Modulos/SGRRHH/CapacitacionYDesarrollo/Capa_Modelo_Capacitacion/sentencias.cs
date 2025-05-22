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

    public class Parametros
    {
        public decimal LimiteVerde { get; set; }
        public decimal LimiteAmarillo { get; set; }
    }
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
        public List<KeyValuePair<int, string>> ObtenerEmpleadosPorDepartamento(int idDepartamento)
        {
            List<KeyValuePair<int, string>> listaEmpleados = new List<KeyValuePair<int, string>>();
            string query = @"
        SELECT pk_clave, empleados_nombre 
        FROM tbl_empleados 
        WHERE fk_id_departamento = ?";  // Asumiendo que la tabla tbl_empleados tiene esta columna

            using (OdbcConnection conn = con.Conexion())
            {
                if (conn != null)
                {
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idDepartamento", idDepartamento);

                        using (OdbcDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listaEmpleados.Add(new KeyValuePair<int, string>(
                                    reader.GetInt32(0), reader.GetString(1)));
                            }
                        }
                    }

                    con.desconexion(conn);
                }
            }

            return listaEmpleados;
        }

        public int ObtenerIdDepartamentoPorCapacitacion(int idCapacitacion)
        {
            int idDepartamento = -1;
            string query = "SELECT fk_id_departamento FROM tbl_capacitaciones WHERE pk_id_capacitacion = ?";

            using (OdbcConnection conn = con.Conexion())
            {
                if (conn != null)
                {
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idCapacitacion", idCapacitacion);

                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            idDepartamento = id;
                        }
                    }

                    con.desconexion(conn);
                }
            }

            return idDepartamento;
        }




        // Método para obtener capacitaciones
        public List<KeyValuePair<int, string>> ObtenerCapacitaciones()
        {
            List<KeyValuePair<int, string>> listaCapacitaciones = new List<KeyValuePair<int, string>>();
            string query = "SELECT pk_id_capacitacion, capacitaciones_nombre FROM tbl_capacitaciones WHERE estado = 1";

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

        public List<KeyValuePair<int, string>> ObtenerCapacitacionesPorDepartamento(int idDepartamento)
        {
            List<KeyValuePair<int, string>> lista = new List<KeyValuePair<int, string>>();

            string query = @"
        SELECT c.pk_id_capacitacion, c.capacitaciones_nombre 
        FROM tbl_capacitaciones c
        WHERE c.fk_id_departamento = ?
        AND c.pk_id_capacitacion NOT IN (
            SELECT fk_id_capacitacion FROM tbl_cierres WHERE estado = 1
        );";

            using (OdbcConnection conn = con.Conexion())
            {
                if (conn != null)
                {
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idDepartamento", idDepartamento);

                        using (OdbcDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string nombre = reader.GetString(1);
                                lista.Add(new KeyValuePair<int, string>(id, nombre));
                            }
                        }
                    }

                    con.desconexion(conn);
                }
            }

            return lista;
        }

        public int ObtenerSiguienteIDCierre()
        {
            int nuevoID = 1;

            using (OdbcConnection conn = con.Conexion())
            {
                string query = "SELECT MAX(pk_id_cierre) FROM tbl_cierres";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        nuevoID = Convert.ToInt32(result) + 1;
                    }
                }

                con.desconexion(conn);
            }

            return nuevoID;
        }

        public bool CambiarEstadoCapacitacion(int idCapacitacion, int nuevoEstado)
        {
            using (OdbcConnection cnx = con.Conexion())
            {
                string query = "UPDATE tbl_capacitaciones SET estado = ? WHERE pk_id_capacitacion = ?";
                using (OdbcCommand cmd = new OdbcCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("?", nuevoEstado);
                    cmd.Parameters.AddWithValue("?", idCapacitacion);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }


        public List<KeyValuePair<int, string>> ObtenerDepartamentos()
        {
            List<KeyValuePair<int, string>> listaDepartamentos = new List<KeyValuePair<int, string>>();
            string query = "SELECT pk_id_departamento, departamentos_nombre_departamento FROM tbl_departamentos";

            using (OdbcConnection conn = con.Conexion())
            {
                if (conn != null)
                {
                    OdbcCommand cmd = new OdbcCommand(query, conn);
                    OdbcDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listaDepartamentos.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                    }

                    reader.Close();
                    con.desconexion(conn);
                }
            }

            return listaDepartamentos;
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

        // PARA OBTENER EL DEPARTAMENTO DE LA CAPACITACION
        public string ObtenerNombreDepartamentoPorCapacitacion(int idCapacitacion)
        {
            string nombreDepartamento = "";

            using (OdbcConnection cnx = con.Conexion())
            {
                string query = @"
            SELECT d.departamentos_nombre_departamento
            FROM tbl_capacitaciones c
            INNER JOIN tbl_departamentos d ON c.fk_id_departamento = d.pk_id_departamento
            WHERE c.pk_id_capacitacion = ?";

                using (OdbcCommand cmd = new OdbcCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@idCapacitacion", idCapacitacion);

                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nombreDepartamento = reader.GetString(0);
                        }
                    }
                }
            }

            return nombreDepartamento;
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


        public Parametros ObtenerParametros()
        {
            Parametros parametros = new Parametros();

            string query = "SELECT LimiteVerde, LimiteAmarillo FROM tbl_parametros WHERE Pk_id_parametro = 1"; // o la lógica adecuada

            using (OdbcConnection conn = con.Conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            parametros.LimiteVerde = reader.GetDecimal(0);
                            parametros.LimiteAmarillo = reader.GetDecimal(1);
                        }
                    }
                }
                con.desconexion(conn);
            }

            return parametros;
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

        //PROMEDIO NOTAS
        public decimal promediarNotas(int idDepartamento, int idCapacitacion)
        {
            decimal promedio = 0;

            using (OdbcConnection cnx = con.Conexion())
            {
                string query = @"SELECT AVG(n.notas_puntaje)
                         FROM tbl_notas n
                         INNER JOIN tbl_empleados e ON n.fk_id_empleado = e.pk_clave
                         WHERE e.fk_id_departamento = ? AND n.fk_id_capacitacion = ? AND n.estado = 1 AND e.estado = 1";

                using (OdbcCommand cmd = new OdbcCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("?", idDepartamento);
                    cmd.Parameters.AddWithValue("?", idCapacitacion);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                        promedio = Convert.ToDecimal(result);
                }
            }

            return promedio;
        }

        //PROMEDIO ASISTENCIA
        public decimal calcularAsistencia(int idDepartamento, int idCapacitacion)
        {
            decimal porcentaje = 0;

            using (OdbcConnection cnx = con.Conexion())
            {
                // Total empleados del departamento
                string totalQuery = "SELECT COUNT(*) FROM tbl_empleados WHERE fk_id_departamento = ? AND estado = 1";
                int totalEmpleados = 0;

                using (OdbcCommand cmd = new OdbcCommand(totalQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("?", idDepartamento);
                    totalEmpleados = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // Empleados con notas para la capacitación
                string conNotasQuery = @"SELECT COUNT(DISTINCT n.fk_id_empleado)
                                 FROM tbl_notas n
                                 INNER JOIN tbl_empleados e ON n.fk_id_empleado = e.pk_clave
                                 WHERE e.fk_id_departamento = ? AND n.fk_id_capacitacion = ? AND n.estado = 1 AND e.estado = 1";
                int empleadosConNotas = 0;

                using (OdbcCommand cmd = new OdbcCommand(conNotasQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("?", idDepartamento);
                    cmd.Parameters.AddWithValue("?", idCapacitacion);
                    empleadosConNotas = Convert.ToInt32(cmd.ExecuteScalar());
                }

                if (totalEmpleados > 0)
                    porcentaje = (empleadosConNotas / (decimal)totalEmpleados) * 100;
            }

            return porcentaje;
        }


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


        //CRUD DE CIERRES
        public void InsertarCierre(int idDepartamento, int idCapacitacion, decimal puntuacion, decimal porcentajeAsistencia, DateTime fecha)
        {
            string query = "INSERT INTO tbl_cierres (fk_id_departamento, fk_id_capacitacion, cierres_puntuacion, cierres_porcentaje_asistencia, cierre_fecha) " +
                           "VALUES (?, ?, ?, ?, ?)";
            using (OdbcCommand cmd = new OdbcCommand(query, con.Conexion()))
            {
                cmd.Parameters.AddWithValue("@idDepartamento", idDepartamento);
                cmd.Parameters.AddWithValue("@idCapacitacion", idCapacitacion);
                cmd.Parameters.AddWithValue("@puntuacion", puntuacion);
                cmd.Parameters.AddWithValue("@porcentajeAsistencia", porcentajeAsistencia);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerCierres()
        {
            DataTable dt = new DataTable();
            string query = @"
        SELECT 
            c.pk_id_cierre AS ID,
            d.departamentos_nombre_departamento AS Departamento,
            cap.capacitaciones_nombre AS Capacitacion,
            c.cierres_puntuacion AS Puntuación,
            c.cierres_porcentaje_asistencia AS PorcentajeAsistencia,
            c.cierre_fecha AS Fecha
        FROM tbl_cierres c
        JOIN tbl_departamentos d ON c.fk_id_departamento = d.pk_id_departamento
        JOIN tbl_capacitaciones cap ON c.fk_id_capacitacion = cap.pk_id_capacitacion
        WHERE c.estado = 1";

            using (OdbcDataAdapter da = new OdbcDataAdapter(query, con.Conexion()))
            {
                da.Fill(dt);
            }
            return dt;
        }


        public bool InsertarParametros(decimal limiteVerde, decimal limiteAmarillo)
        {
            using (OdbcConnection cnx = con.Conexion())
            {
                string query = "INSERT INTO tbl_parametros (LimiteVerde, LimiteAmarillo) VALUES (?, ?)";
                using (OdbcCommand cmd = new OdbcCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("?", limiteVerde);
                    cmd.Parameters.AddWithValue("?", limiteAmarillo);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public void ActualizarNivelCompetencia(int idCapacitacion, string colorSemaforo)
        {
            using (OdbcConnection cnx = con.Conexion())
            {
                // 1. Obtener el departamento, competencia y nivel final desde tbl_capacitaciones
                string query1 = "SELECT fk_id_departamento, fk_id_competencia, fk_id_capacitaciones_nivelfinal FROM tbl_capacitaciones WHERE pk_id_capacitacion = ?";
                int idDepartamento = 0, idCompetencia = 0;
                string nivelFinal = "D";

                using (OdbcCommand cmd = new OdbcCommand(query1, cnx))
                {
                    cmd.Parameters.AddWithValue("?", idCapacitacion);
                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idDepartamento = reader.GetInt32(0);
                            idCompetencia = reader.GetInt32(1);
                            nivelFinal = reader.GetString(2);
                        }
                        else return; // No se encontró la capacitación
                    }
                }

                // 2. Verificar si ya existe un registro en tbl_departamentos_competencia
                string queryCheck = "SELECT nivelactual FROM tbl_departamentos_competencias WHERE fk_id_departamento = ? AND fk_id_competencia = ?";
                string nivelActual = null;

                using (OdbcCommand cmd = new OdbcCommand(queryCheck, cnx))
                {
                    cmd.Parameters.AddWithValue("?", idDepartamento);
                    cmd.Parameters.AddWithValue("?", idCompetencia);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        nivelActual = result.ToString();
                }

                // 3. Si ya existe: actualizar nivel según el color del semáforo
                if (nivelActual != null)
                {
                    List<string> niveles = new List<string> { "A", "B", "C", "D" };
                    int index = niveles.IndexOf(nivelActual.ToUpper());
                    int nuevoIndex = index;

                    if (colorSemaforo == "verde" && index > 0)
                        nuevoIndex = index - 1; // subir
                    else if (colorSemaforo == "rojo" && index < niveles.Count - 1)
                        nuevoIndex = index + 1; // bajar
                    else
                        return; // sin cambio

                    string queryUpdate = "UPDATE tbl_departamentos_competencias SET nivelactual = ?, estado = 1 WHERE fk_id_departamento = ? AND fk_id_competencia = ?";
                    using (OdbcCommand cmd = new OdbcCommand(queryUpdate, cnx))
                    {
                        cmd.Parameters.AddWithValue("?", niveles[nuevoIndex]);
                        cmd.Parameters.AddWithValue("?", idDepartamento);
                        cmd.Parameters.AddWithValue("?", idCompetencia);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    // 4. No existe: insertar nuevo registro
                    string nuevoNivel = (colorSemaforo == "verde") ? nivelFinal : "D";
                    string queryInsert = "INSERT INTO tbl_departamentos_competencias (fk_id_departamento, fk_id_competencia, nivelactual, estado) VALUES (?, ?, ?, 1)";
                    using (OdbcCommand cmd = new OdbcCommand(queryInsert, cnx))
                    {
                        cmd.Parameters.AddWithValue("?", idDepartamento);
                        cmd.Parameters.AddWithValue("?", idCompetencia);
                        cmd.Parameters.AddWithValue("?", nuevoNivel);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }


        public bool ActualizarParametros(decimal nuevoVerde, decimal nuevoAmarillo)
        {
            using (OdbcConnection cnx = con.Conexion())
            {
                string query = "UPDATE tbl_parametros SET LimiteVerde = ?, LimiteAmarillo = ? WHERE Pk_id_parametro = 1";
                using (OdbcCommand cmd = new OdbcCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("?", nuevoVerde);
                    cmd.Parameters.AddWithValue("?", nuevoAmarillo);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        //CONSEGUIR IDs
        public int ObtenerIdCompetenciaDesdeCapacitacion(int idCapacitacion)
        {
            int idCompetencia = -1;
            using (OdbcConnection cnx = con.Conexion())
            {
                string query = "SELECT fk_id_competencia FROM tbl_capacitaciones WHERE pk_id_capacitacion = @id";
                using (OdbcCommand cmd = new OdbcCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@id", idCapacitacion); // Aquí estaba el error
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        idCompetencia = Convert.ToInt32(result);
                }
            }
            return idCompetencia;
        }

        public string ObtenerNivelActual(int idDepartamento, int idCompetencia)
        {
            string nivel = "No definido";

            using (OdbcConnection cnx = con.Conexion())
            {
                string query = @"SELECT nivelactual 
                         FROM tbl_departamentos_competencias 
                         WHERE fk_id_departamento = @idDepto AND fk_id_competencia = @idComp";
                using (OdbcCommand cmd = new OdbcCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@idDepto", idDepartamento);
                    cmd.Parameters.AddWithValue("@idComp", idCompetencia);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        nivel = result.ToString();
                }
            }

            return nivel;
        }

        public string ObtenerNombreCompetencia(int idCompetencia)
        {
            string nombre = "Desconocida";

            using (OdbcConnection cnx = con.Conexion())
            {
                string query = "SELECT nombre_competencia FROM tbl_competencias WHERE Pk_id_competencia = @id";
                using (OdbcCommand cmd = new OdbcCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@id", idCompetencia);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        nombre = result.ToString();
                }
            }

            return nombre;
        }

        public void ActualizarONivelarCompetencia(int idDepartamento, int idCompetencia, string nuevoNivel)
        {
            using (OdbcConnection cnx = con.Conexion())
            {
                string queryExiste = @"SELECT COUNT(*) 
                               FROM tbl_departamentos_competencias 
                               WHERE fk_id_departamento = @idDepto AND fk_id_competencia = @idComp";

                using (OdbcCommand cmd = new OdbcCommand(queryExiste, cnx))
                {
                    cmd.Parameters.AddWithValue("@idDepto", idDepartamento);
                    cmd.Parameters.AddWithValue("@idComp", idCompetencia);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        // Ya existe, entonces se actualiza
                        string update = @"UPDATE tbl_departamentos_competencias 
                                  SET nivelactual = @nivel 
                                  WHERE fk_id_departamento = @idDepto AND fk_id_competencia = @idComp";
                        using (OdbcCommand updateCmd = new OdbcCommand(update, cnx))
                        {
                            updateCmd.Parameters.AddWithValue("@nivel", nuevoNivel);
                            updateCmd.Parameters.AddWithValue("@idDepto", idDepartamento);
                            updateCmd.Parameters.AddWithValue("@idComp", idCompetencia);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // No existe, entonces se inserta
                        string insert = @"INSERT INTO tbl_departamentos_competencias 
                                  (fk_id_departamento, fk_id_competencia, nivelactual) 
                                  VALUES (@idDepto, @idComp, @nivel)";
                        using (OdbcCommand insertCmd = new OdbcCommand(insert, cnx))
                        {
                            insertCmd.Parameters.AddWithValue("@idDepto", idDepartamento);
                            insertCmd.Parameters.AddWithValue("@idComp", idCompetencia);
                            insertCmd.Parameters.AddWithValue("@nivel", nuevoNivel);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public void InsertarONivelarCompetenciaDesdeUI(int idDepartamento, int idCompetencia, string nivelFinal, string colorSemaforo)
        {
            using (OdbcConnection cnx = con.Conexion())
            {
                // 1. Verificar si ya existe
                string queryCheck = "SELECT nivelactual FROM tbl_departamentos_competencias WHERE fk_id_departamento = ? AND fk_id_competencia = ?";
                string nivelActual = null;

                using (OdbcCommand cmd = new OdbcCommand(queryCheck, cnx))
                {
                    cmd.Parameters.AddWithValue("?", idDepartamento);
                    cmd.Parameters.AddWithValue("?", idCompetencia);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        nivelActual = result.ToString();
                }

                List<string> niveles = new List<string> { "A", "B", "C", "D" };

                // 2. Si ya existe, actualizar el nivel
                if (nivelActual != null)
                {
                    int index = niveles.IndexOf(nivelActual.ToUpper());
                    int nuevoIndex = index;

                    if (colorSemaforo == "verde" && index > 0)
                        nuevoIndex = index + 1;
                    else if (colorSemaforo == "rojo" && index < niveles.Count - 1)
                        nuevoIndex = index - 1;
                    else
                        return; // sin cambio

                    string queryUpdate = "UPDATE tbl_departamentos_competencias SET nivelactual = ?, estado = 1 WHERE fk_id_departamento = ? AND fk_id_competencia = ?";
                    using (OdbcCommand cmd = new OdbcCommand(queryUpdate, cnx))
                    {
                        cmd.Parameters.AddWithValue("?", niveles[nuevoIndex]);
                        cmd.Parameters.AddWithValue("?", idDepartamento);
                        cmd.Parameters.AddWithValue("?", idCompetencia);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    // 3. No existe: insertar nuevo
                    string nuevoNivel = (colorSemaforo == "verde") ? nivelFinal : "D";
                    string queryInsert = "INSERT INTO tbl_departamentos_competencias (fk_id_departamento, fk_id_competencia, nivelactual, estado) VALUES (?, ?, ?, 1)";
                    using (OdbcCommand cmd = new OdbcCommand(queryInsert, cnx))
                    {
                        cmd.Parameters.AddWithValue("?", idDepartamento);
                        cmd.Parameters.AddWithValue("?", idCompetencia);
                        cmd.Parameters.AddWithValue("?", nuevoNivel);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }


    }
}
