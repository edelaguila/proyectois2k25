using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Capa_Modelo_Navegador
{
    public class sentencias
    {
        conexion cn = new conexion();

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 
        // Método que llena una tabla con datos relacionados a otra tabla si es necesario.
        public OdbcDataAdapter LlenaTbl(string sTabla, List<Tuple<string, string, string, string>> relacionesForaneas)
        {
            OdbcConnection conn = cn.ProbarConexion();

            try
            {
                // Verifica que las relaciones no sean nulas
                if (relacionesForaneas == null)
                {
                    relacionesForaneas = new List<Tuple<string, string, string, string>>();
                }

                // Verificar que la conexión esté activa
                if (conn == null)
                {
                    throw new InvalidOperationException("La conexión a la base de datos no está disponible.");
                }
				
				// Mejoras en las validaciones--Hecho por José Andrés Verón y Elvir Sandoval 31/01/2025
                if (string.IsNullOrEmpty(sTabla) || sTabla.Any(c => !char.IsLetterOrDigit(c) && c != '_'))
                {
                    throw new ArgumentException("El nombre de la tabla no es válido.");
                }
				
                // Obtener los campos de la tabla principal de forma dinámica
                string[] sCamposDesc = ObtenerCampos(sTabla);
                if (sCamposDesc == null || sCamposDesc.Length == 0)
                {
                    throw new InvalidOperationException("No se pudieron obtener los campos de la tabla principal.");
                }

                // Inicia con el primer campo de la tabla
                string sCamposSelect = sTabla + "." + sCamposDesc[0];

                // Diccionario para evitar duplicados de columnas
                Dictionary<string, int> dicColumnasRegistradas = new Dictionary<string, int>();
                dicColumnasRegistradas[sCamposDesc[0]] = 1;

                // Obtener las propiedades de las columnas de la tabla principal
                var vColumnasPropiedades = ObtenerColumnasYPropiedades(sTabla);
                if (vColumnasPropiedades == null)
                {
                    throw new InvalidOperationException("No se pudieron obtener las propiedades de las columnas de la tabla.");
                }

                // Recorrer los campos de la tabla principal
                foreach (var (sNombreColumna, bEsAutoIncremental, bEsClaveForanea, bEsTinyInt) in vColumnasPropiedades)
                {
                    // Evitar agregar la columna principal dos veces
                    if (sNombreColumna == sCamposDesc[0])
                        continue;

                    // Si es una clave foránea, buscar si hay una relación foránea que la reemplace
                    bool columnaReemplazada = false;

                    foreach (var relacion in relacionesForaneas)
                    {
                        if (string.IsNullOrEmpty(relacion.Item1) || string.IsNullOrEmpty(relacion.Item2) || string.IsNullOrEmpty(relacion.Item3) || string.IsNullOrEmpty(relacion.Item4))
                        {
                            throw new ArgumentException("Uno de los valores en las relaciones foráneas es nulo o vacío.");
                        }

                        string sTablaRelacionada = relacion.Item1;
                        string sCampoDescriptivo = relacion.Item2;
                        string sColumnaForanea = relacion.Item3;

                        // Si la columna actual es una clave foránea, la reemplazamos por su campo descriptivo
                        if (sNombreColumna == sColumnaForanea)
                        {
                            sCamposSelect += ", " + sTablaRelacionada + "." + sCampoDescriptivo + " AS " + sCampoDescriptivo;
                            dicColumnasRegistradas[sCampoDescriptivo] = 1;
                            columnaReemplazada = true;
                            break;
                        }
                    }

                    // Si no fue reemplazada como clave foránea, agregarla como está
                    if (!columnaReemplazada)
                    {
                        sCamposSelect += ", " + sTabla + "." + sNombreColumna;
                        dicColumnasRegistradas[sNombreColumna] = 1;
                    }
                }

                // Crear el comando SQL para seleccionar los campos
                string sSql = "SELECT " + sCamposSelect + " FROM " + sTabla;

                // Agregar los LEFT JOIN para cada relación foránea
                foreach (var relacion in relacionesForaneas)
                {
                    string sTablaRelacionada = relacion.Item1;
                    string sColumnaForanea = relacion.Item3;
                    string sColumnaPrimariaRelacionada = relacion.Item4;

                    // Añadir el LEFT JOIN con la tabla relacionada
                    sSql += " LEFT JOIN " + sTablaRelacionada + " ON " + sTabla + "." + sColumnaForanea + " = " + sTablaRelacionada + "." + sColumnaPrimariaRelacionada;
                }

                // Filtrar por estado (activo o inactivo)
                sSql += " WHERE " + sTabla + ".estado = 0 OR " + sTabla + ".estado = 1";

                // Ordenar por la columna principal en orden descendente
                sSql += " ORDER BY " + sCamposDesc[0] + " DESC;";

                Console.WriteLine(sSql); // Imprimir la consulta SQL generada para debugging

                // Crear un adaptador de datos para ejecutar la consulta
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sSql, conn);

                return dataTable;
            }
            finally
            {
                // Cerrar la conexión después de ejecutar la consulta
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    Console.WriteLine("Conexión cerrada después de llenar la tabla");
                }
            }
        }
        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025

        //IMPLEMENTACION DE PARAMETROS JOEL LOPEZ 30/01/2025
        public string ObtenerValorClave(string sTabla, string sCampoClave, string sCampoDescriptivo, string valorDescriptivo)
        {
            string sQuery = $"SELECT {sCampoClave} FROM {sTabla} WHERE {sCampoDescriptivo} = ?"; // Uso de parámetro
            string resultado = null;

            using (OdbcConnection conn = cn.ProbarConexion()) // Uso de 'using' para gestionar la conexión
            {
                using (OdbcCommand command = new OdbcCommand(sQuery, conn))
                {
                    command.Parameters.AddWithValue("?", valorDescriptivo); // Se añade el parámetro de forma segura
                    resultado = command.ExecuteScalar()?.ToString();
                }
            }

            Console.WriteLine(sQuery); // OJO: Esto no imprimirá el valor real del parámetro
            return resultado;
        }







        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 


        //******************************************** CODIGO HECHO POR EMANUEL BARAHONA ***************************** 
        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        // Método que obtiene el último ID de una tabla
        public string ObtenerId(string sTabla)
        {
            string[] sCamposDesc = ObtenerCampos(sTabla);
            string sSql = "SELECT MAX(" + sCamposDesc[0] + ") FROM " + sTabla + ";";
            string sId = "";

            using (OdbcCommand command = new OdbcCommand(sSql, cn.ProbarConexion()))
            {
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            if (reader.GetValue(0).ToString() == null || reader.GetValue(0).ToString() == "")
                            {
                                sId = "1";
                            }
                            else
                            {
                                sId = reader.GetValue(0).ToString();
                            }
                        }
                    }
                    else
                    {
                        sId = "1";
                    }
                }
            }

            return sId;
        }

        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025

        //******************************************** CODIGO HECHO POR EMANUEL BARAHONA ***************************** 



        //******************************************** CODIGO HECHO POR ANIKA ESCOTO ***************************** 
        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        //IMPLEMENTACION DE PARAMETROS JOEL LOPEZ 30/01/2025
        // Método para obtener el ID de usuario basado en su nombre de usuario

        /*Ismar Cortez 6/2/25*/
        /*El error se estaba produciendo aqui, basicamente porque se le mandaba el parametro como @username y devolvia -1
         haciendo que nunca se diera la validación del usuario y por ende los permisos necesarios*/
        public string ObtenerIdUsuarioPorUsername(string sUsername)
        {
            string sSql = "SELECT Pk_id_usuario FROM tbl_usuarios WHERE username_usuario = ?"; // Parámetro explícito

            using (OdbcCommand command = new OdbcCommand(sSql, cn.ProbarConexion()))
            {
                command.Parameters.AddWithValue("@username", sUsername);

                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["Pk_id_usuario"].ToString();
                    }
                    else
                    {
                        return "-1";
                    }
                }
            }
        }


        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        // Método que cuenta los campos en una tabla
        public int ContarAlias(string sTabla)
        {
            int iCampos = 0;

            try
            {
                using (OdbcCommand command = new OdbcCommand("DESCRIBE " + sTabla + "", cn.ProbarConexion()))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            iCampos++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtenerTipo, revise los parámetros de la tabla  \n -" + sTabla.ToUpper() + "\n -");
            }
            return iCampos;
        }

        //******************************************** CODIGO HECHO POR ANIKA ESCOTO ***************************** 


        //******************************************** CODIGO HECHO POR JOEL LOPEZ ***************************** 
        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        //IMPLEMENTACION DE PARÁMETROS JOEL LOPEZ 30/01/2025
        // Método para contar registros en la tabla de ayuda
        public int ContarReg(string sIdIndice)
        {
            int iCampos = 0;
            try
            {
                using (OdbcCommand command = new OdbcCommand("SELECT * FROM ayuda WHERE id_ayuda = ?", cn.ProbarConexion()))
                {
                    // Agregar el parámetro correctamente
                    command.Parameters.AddWithValue("@id_ayuda", sIdIndice);

                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            iCampos++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nError en obtenerTipo, revise los parámetros de la tabla  \n -" + sIdIndice + "\n -");
            }
            return iCampos;
        }


        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        //iMPLEMENTACION DE PARÁMETROS JOEL LÓPEZ 30/01/2025
        public string ModRuta(string sIdAyuda)
        {
            string sRuta = "";
            string sQuery = "SELECT Ruta FROM ayuda WHERE Id_ayuda = ?"; // Parámetro seguro

            using (OdbcCommand command = new OdbcCommand(sQuery, cn.ProbarConexion()))
            {
                command.Parameters.AddWithValue("?", sIdAyuda); // Corregido: Odbc usa "?" sin nombres

                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        sRuta = reader.GetString(0); // Asignamos el valor de la columna Ruta
                    }
                }
            }

            return sRuta;
        }

        //******************************************** CODIGO HECHO POR JOEL LOPEZ ***************************** 


        //******************************************** CODIGO HECHO POR JORGE AVILA ***************************** 
        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        //IMPLEMENTACIÓN DE PARÁMETROS JOEL LÓPEZ 31/01/2025
        // Método que obtiene la ruta del reporte basada en el ID de la aplicación
        public string RutaReporte(string sIdIndice)
        {
            string sIndice2 = "";
            string sQuery = "SELECT ruta FROM tbl_aplicaciones WHERE Pk_id_aplicacion = ?"; // Uso de parámetro

            try
            {
                using (OdbcCommand command = new OdbcCommand(sQuery, cn.ProbarConexion()))
                {
                    command.Parameters.AddWithValue("?", sIdIndice); // Se usa "?" en Odbc

                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            sIndice2 = reader["ruta"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return sIndice2;
        }


        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        // Método para obtener un índice modificado basado en el ID de ayuda
        //IMPLEMENTACIÓN PARÁMETROS JOEL LÓPEZ 31/01/2025
        public string ModIndice(string sIdAyuda)
        {
            string sIndice = "";
            string sQuery = "SELECT indice FROM ayuda WHERE id_ayuda = ?"; // Uso de parámetro seguro

            using (OdbcCommand command = new OdbcCommand(sQuery, cn.ProbarConexion()))
            {
                command.Parameters.AddWithValue("?", sIdAyuda); // Corrección: solo se usa "?"

                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        sIndice = reader.GetString(0); // Asignamos el valor de la columna Indice
                    }
                }
            }

            return sIndice;
        }

        //******************************************** CODIGO HECHO POR JORGE AVILA ***************************** 


        //******************************************** CODIGO HECHO POR DIEGO MARROQUIN ***************************** 
        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        // Método para probar si una tabla existe en la base de datos
        public string ProbarTabla(string sTabla)
        {
            string sError = "";
            try
            {
                using (OdbcCommand command = new OdbcCommand("SELECT * FROM " + sTabla + ";", cn.ProbarConexion()))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                    }
                }
            }
            catch (Exception)
            {
                sError = "La tabla " + sTabla.ToUpper() + " no existe.";
            }
            return sError;
        }

        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        // Método para probar si una tabla tiene un campo de estado
        public string ProbarEstado(string sTabla)
        {
            string sError = "";
            try
            {
                using (OdbcCommand command = new OdbcCommand("SELECT estado FROM " + sTabla + ";", cn.ProbarConexion()))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                    }
                }
            }
            catch (Exception)
            {
                sError = "La tabla " + sTabla.ToUpper() + " no contiene el campo de ESTADO";
            }
            return sError;
        }

        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        //IMPLEMENTACIÓN PARÁMETROS JOEL LÓPEZ 31/01/2025
        // Método que cuenta los registros activos en una tabla
        public int ProbarRegistros(string sTabla)
        {
            int iRegistros = 0;

            // Validar el nombre de la tabla para prevenir inyección SQL
            if (!Regex.IsMatch(sTabla, @"^[a-zA-Z0-9_]+$"))
            {
                throw new ArgumentException("El nombre de la tabla contiene caracteres no permitidos.");
            }

            // Verificar si la tabla tiene el campo "estado"
            bool tieneEstado = false;
            using (OdbcCommand command = new OdbcCommand($"DESCRIBE {sTabla};", cn.ProbarConexion()))
            {
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader["Field"].ToString().Equals("estado", StringComparison.OrdinalIgnoreCase))
                        {
                            tieneEstado = true;
                            break;
                        }
                    }
                }
            }

            // Si la tabla no tiene "estado", devolvemos 0 registros
            if (!tieneEstado)
            {
                return 0;
            }

            // Contar registros donde estado = 1
            using (OdbcCommand command = new OdbcCommand($"SELECT COUNT(*) FROM {sTabla} WHERE estado = 1;", cn.ProbarConexion()))
            {
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    iRegistros = Convert.ToInt32(result);
                }
            }

            return iRegistros;
        }


        //******************************************** CODIGO HECHO POR DIEGO MARROQUIN ***************************** 


        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 
        // Método para obtener los nombres de los campos de una tabla
        public string[] ObtenerCampos(string sTabla)
        {
            string[] sCampos = new string[30];
            int iIndex = 0;
            OdbcConnection conn = null;

            try
            {
                conn = cn.ProbarConexion();
                OdbcCommand command = new OdbcCommand("DESCRIBE " + sTabla + "", conn);
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    sCampos[iIndex] = reader.GetValue(0).ToString();
                    iIndex++;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parámetros \n -" + sTabla);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    Console.WriteLine("Conexión cerrada después de obtener los campos");
                }
            }

            return sCampos;
        }
        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 


        //******************************************** CODIGO HECHO POR SEBASTIAN LETONA ***************************** 
        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        // Método para obtener las propiedades de las columnas de una tabla
        public List<(string nombreColumna, bool esAutoIncremental, bool esClaveForanea, bool esTinyInt)> ObtenerColumnasYPropiedades(string sNombreTabla)
        {
            List<(string, bool, bool, bool)> lColumnas = new List<(string, bool, bool, bool)>();

            try
            {
                string sQueryColumnas = $"SHOW COLUMNS FROM {sNombreTabla};";
                using (OdbcCommand comando = new OdbcCommand(sQueryColumnas, cn.ProbarConexion()))
                using (OdbcDataReader lector = comando.ExecuteReader())
                {
                    HashSet<string> clavesForaneas = new HashSet<string>();

                    string sQueryClavesForaneas = $@"
                SELECT COLUMN_NAME
                FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE
                WHERE TABLE_NAME = '{sNombreTabla}' AND REFERENCED_TABLE_NAME IS NOT NULL;";
                    using (OdbcCommand comandoClaves = new OdbcCommand(sQueryClavesForaneas, cn.ProbarConexion()))
                    using (OdbcDataReader lectorClaves = comandoClaves.ExecuteReader())
                    {
                        while (lectorClaves.Read())
                        {
                            string sNombreColumnaForanea = lectorClaves.GetString(0);
                            clavesForaneas.Add(sNombreColumnaForanea);
                        }
                    }

                    while (lector.Read())
                    {
                        string sNombreColumna = lector.GetString(0);
                        string sTipoColumna = lector.GetString(1);
                        string sColumnaExtra = lector.GetString(5);

                        bool bEsAutoIncremental = sColumnaExtra.Contains("auto_increment");
                        bool bEsClaveForanea = clavesForaneas.Contains(sNombreColumna);
                        bool bEsTinyInt = sTipoColumna.StartsWith("tinyint");

                        lColumnas.Add((sNombreColumna, bEsAutoIncremental, bEsClaveForanea, bEsTinyInt));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener columnas: " + ex.Message);
            }

            return lColumnas;
        }

        //******************************************** CODIGO HECHO POR SEBASTIAN LETONA ***************************** 


        //******************************************** CODIGO HECHO POR PABLO FLORES ***************************** 
        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        // Método para ejecutar una serie de consultas SQL dentro de una transacción
        public void EjecutarQueryConTransaccion(List<string> sQueries)
        {
            using (OdbcConnection connection = cn.ProbarConexion())
            using (OdbcTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    foreach (string sQuery in sQueries)
                    {
                        using (OdbcCommand command = new OdbcCommand(sQuery, connection, transaction))
                        {
                            command.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Error en la transacción: " + ex.Message);
                }
            }
        }

        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        // Método para obtener los tipos de datos de los campos en una tabla
        public string[] ObtenerTipo(string sTabla)
        {
            string[] sCampos = new string[30];
            int iIndex = 0;

            try
            {
                using (OdbcConnection conn = cn.ProbarConexion())
                using (OdbcCommand command = new OdbcCommand("DESCRIBE " + sTabla, conn))
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sCampos[iIndex] = LimpiarTipo(reader.GetValue(1).ToString());
                        iIndex++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtenerTipo, revise los parámetros de la tabla  \n -" + sTabla.ToUpper() + "\n -");
            }

            return sCampos;
        }

        //******************************************** CODIGO HECHO POR PABLO FLORES ***************************** 


        //******************************************** CODIGO HECHO POR JOSUE CACAO ***************************** 
        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        // Método para obtener las llaves de los campos en una tabla
        public string[] ObtenerLLave(string sTabla)
        {
            string[] sCampos = new string[30];
            int iIndex = 0;

            try
            {
                using (OdbcCommand command = new OdbcCommand("DESCRIBE " + sTabla, cn.ProbarConexion()))
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sCampos[iIndex] = reader.GetValue(3).ToString();
                        iIndex++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtenerTipo, revise los parametros de la tabla  \n -" + sTabla + "\n -");
            }

            return sCampos;
        }

        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        // Método para obtener los ítems de un ComboBox desde la base de datos
        public Dictionary<string, string> ObtenerItems(string sTabla, string sCampoClave, string sCampoDisplay)
        {
            Dictionary<string, string> dicItems = new Dictionary<string, string>();

            try
            {
                using (OdbcCommand command = new OdbcCommand($"SELECT {sCampoClave}, {sCampoDisplay} FROM {sTabla} WHERE estado = 1", cn.ProbarConexion()))
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dicItems.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nError en obtenerItems, revise los parámetros \n -" + sTabla + "\n -" + sCampoClave);
            }

            return dicItems;
        }

        //******************************************** CODIGO HECHO POR JOSUE CACAO ***************************** 


        //******************************************** CODIGO HECHO POR MATY MANCILLA ***************************** 
        // Método que limpia el tipo de dato de una cadena, eliminando la dimensión del campo
        string LimpiarTipo(string sCadena)
        {
            bool bDim = false;
            string sNuevaCadena = "";

            for (int iJIndex = 0; iJIndex < sCadena.Length; iJIndex++)
            {
                if (sCadena[iJIndex] == '(')
                {
                    bDim = true;
                    break;  // Salir del bucle tan pronto como encuentres el '('
                }
            }

            if (bDim)
            {
                int iIndex = 0;
                int iTam = sCadena.Length;

                // Continuar extrayendo la parte antes del '('
                while (iIndex < iTam && sCadena[iIndex] != '(')
                {
                    sNuevaCadena += sCadena[iIndex];
                    iIndex++;
                }
            }
            else
            {
                return sCadena;  // Si no tiene paréntesis, retorna la cadena original
            }

            return sNuevaCadena;
        }

        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        // Método para obtener la llave de un campo en la tabla
        public string LlaveCampo(string sTabla, string sCampo, string sValor)
        {
            string sLlave = "";
            using (OdbcCommand command = new OdbcCommand($"SELECT * FROM {sTabla} WHERE {sCampo} = ?", cn.ProbarConexion()))
            {
                command.Parameters.AddWithValue("?", sValor);

                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        sLlave = reader.GetValue(0).ToString();
                    }
                }
            }
            return sLlave;
        }

        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        //IMPLEMENTACION DE PARÁMETROS JOEL LÓPEZ 31/01/2025
        // Método para obtener la llave de un campo en reverso (no está claro para qué se usa)
        public string LlaveCampoReverso(string sTabla, string sCampo, string sValor)
        {
            string sLlave = "";
            string[] sCampos = ObtenerCampos(sTabla);

            // Validamos si la tabla y el campo son válidos
            if (IsValidTabla(sTabla) && IsValidCampo(sCampo) && sCampos.Length > 0)
            {
                // Usamos parámetros para la consulta
                string sQuery = $"SELECT {sCampo} FROM {sTabla} WHERE {sCampos[0]} = ?;";

                try
                {
                    using (OdbcCommand command = new OdbcCommand(sQuery, cn.ProbarConexion()))
                    {
                        // Añadimos el parámetro de manera segura
                        command.Parameters.AddWithValue("?", sValor);

                        using (OdbcDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                sLlave = reader.GetValue(0).ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Dio error: " + ex.ToString());
                }
            }
            else
            {
                Console.WriteLine("Tabla o campo no válidos.");
            }

            return sLlave;
        }

        // Métodos para validar el nombre de la tabla y el campo
        private bool IsValidTabla(string sTabla)
        {
            return Regex.IsMatch(sTabla, @"^[a-zA-Z0-9_]+$");
        }

        private bool IsValidCampo(string sCampo)
        {
            return Regex.IsMatch(sCampo, @"^[a-zA-Z0-9_]+$");
        }


        //******************************************** CODIGO HECHO POR MATY MANCILLA ***************************** 


        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 
        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        //IMPLEMENTACION PARÁMETROS JOEL LÓPEZ 31/01/2025
        // Método para obtener el ID del módulo basado en el ID de la aplicación
        public string IdModulo(string sAplicacion)
        {
            string sLlave = "";
            string sQuery = "SELECT * FROM tbl_aplicacion WHERE PK_id_aplicacion = ?";

            try
            {
                using (OdbcCommand command = new OdbcCommand(sQuery, cn.ProbarConexion()))
                {
                    // Usar parámetros para evitar inyección SQL
                    command.Parameters.AddWithValue("?", sAplicacion);

                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            sLlave = reader.GetValue(0).ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dio error: " + sQuery + ex.ToString());
            }

            return sLlave;
        }



        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        // Método para ejecutar una consulta SQL
        public void EjecutarQuery(string sQuery)
        {
            try
            {
                using (OdbcCommand consulta = new OdbcCommand(sQuery, cn.ProbarConexion()))
                {
                    consulta.ExecuteNonQuery();
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 


        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS ***************************** 
        // Método para obtener la clave primaria de una tabla
        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        public string ObtenerClavePrimaria(string sNombreTabla)
        {
            string sClavePrimaria = "";
            try
            {
                string sQuery = $"SHOW KEYS FROM {sNombreTabla} WHERE Key_name = 'PRIMARY';";

                using (OdbcCommand command = new OdbcCommand(sQuery, cn.ProbarConexion()))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            sClavePrimaria = reader["Column_name"].ToString();
                            Console.WriteLine($"Clave primaria de {sNombreTabla}: {sClavePrimaria}");
                        }
                        else
                        {
                            throw new Exception("No se encontró una clave primaria para la tabla: " + sNombreTabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la clave primaria de la tabla " + sNombreTabla + ": " + ex.ToString());
            }

            return sClavePrimaria;
        }


        // Método para obtener la clave foránea que referencia a otra tabla
        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        public string ObtenerClaveForanea(string sTablaOrigen, string sTablaReferencia)
        {
            string sClaveForanea = null;

            try
            {
                string sQuery = $@"
        SELECT COLUMN_NAME 
        FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE 
        WHERE TABLE_SCHEMA = DATABASE()
        AND TABLE_NAME = '{sTablaOrigen}' 
        AND REFERENCED_TABLE_NAME = '{sTablaReferencia}';";

                using (OdbcCommand command = new OdbcCommand(sQuery, cn.ProbarConexion()))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            sClaveForanea = reader.GetString(0);
                            Console.WriteLine($"Clave foránea de {sTablaOrigen} que referencia a {sTablaReferencia}: {sClaveForanea}");
                        }
                        else
                        {
                            Console.WriteLine($"No se encontró clave foránea en {sTablaOrigen} que referencia a {sTablaReferencia}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener clave foránea: " + ex.Message);
            }

            return sClaveForanea;
        }


        // Asumiendo que tienes una clase para la conexión

        // Método para obtener las relaciones de claves foráneas desde la base de datos
        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        public (string tablaRelacionada, string campoClave, string campoDisplay) ObtenerRelacionesForaneas(string sTablaOrigen, string sCampo)
            {
                string tablaRelacionada = null;
                string campoClave = null;

                try
                {
                    string sQuery = $@"
                SELECT REFERENCED_TABLE_NAME, REFERENCED_COLUMN_NAME 
                FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE 
                WHERE TABLE_SCHEMA = DATABASE()
                AND TABLE_NAME = '{sTablaOrigen}' 
                AND COLUMN_NAME = '{sCampo}';";

                    OdbcCommand command = new OdbcCommand(sQuery, cn.ProbarConexion());
                    OdbcDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        tablaRelacionada = reader.GetString(0);  // Obtiene la tabla relacionada
                        campoClave = reader.GetString(1);        // Obtiene la clave relacionada (ID)

                        Console.WriteLine($"Clave foránea de {sTablaOrigen} que referencia a {tablaRelacionada}: {campoClave}");

                        // El campo display ahora es siempre el campo clave (ID)
                        string campoDisplay = campoClave;

                        return (tablaRelacionada, campoClave, campoDisplay);
                    }
                    else
                    {
                        Console.WriteLine($"No se encontró clave foránea en {sTablaOrigen} para el campo {sCampo}");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener clave foránea: " + ex.Message);
                }

                return (tablaRelacionada, campoClave, campoClave); // Ambos campoClave y campoDisplay serán el ID
            }

        //IMPLEMENTACION DE USING POR JOSE DANIEL SIERRA 30/01/2025
        public OdbcDataAdapter llenarTblAyuda(string tabla)
        {
            string sql = "SELECT * FROM " + tabla + " ;";

            OdbcDataAdapter dataTable;
            using (OdbcConnection conn = cn.ProbarConexion())  
            {
                dataTable = new OdbcDataAdapter(sql, conn);
            }

            return dataTable;
        }


        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS ***************************** 
    }
}
