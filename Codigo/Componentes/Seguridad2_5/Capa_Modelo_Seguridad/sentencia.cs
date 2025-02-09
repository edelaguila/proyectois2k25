using System;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Net;
using System.Data;
using System.Collections.Generic;
using System.Text.RegularExpressions; // Para expresiones regulares

namespace Capa_Modelo_Seguridad
{
    public class sentencia
    {
        conexion cn = new conexion();
        private string idUsuario;

        public sentencia(string idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        public sentencia()
        {

        }




        //Kateryn De Leon
        //buscar usuarios
        public OdbcDataAdapter funUsuariosAplicaciones()
        {
            cn.conectar();
            string sUsuarios = "SELECT Pk_id_usuario as Usuario, nombre_usuario as Nombre, apellido_usuario as Apellido, username_usuario as Username, password_usuario as Password, email_usuario as Email, ultima_conexion_usuario as Ultima_Conexion, estado_usuario as Estado, pregunta as Pregunta, respuesta as Respuesta FROM tbl_usuarios";
            OdbcDataAdapter dataUsuarios = new OdbcDataAdapter(sUsuarios, cn.conectar());
            funInsertarBitacora(idUsuario, "Realizo una consulta a usuarios", "tbl_usuarios", "1000");
            return dataUsuarios;
        }

        public OdbcDataAdapter funUsuarios(string estado)
        {
            cn.conectar();
            string sUsuarios = "SELECT Pk_id_usuario as Usuario, " +
                "nombre_usuario as Nombre, " +
                "apellido_usuario as Apellido, " +
                "username_usuario as Username, " +
                "password_usuario as Password, " +
                "email_usuario as Email, " +
                "ultima_conexion_usuario as Ultima_Conexion, " +
                "estado_usuario as Estado, " +
                "pregunta as Pregunta, " +
                "respuesta as Respuesta " +
                "FROM tbl_usuarios";

            // Agregar filtro por estado si se especificó uno
            if (estado != "todos")
            {
                sUsuarios += " WHERE estado_usuario = " + estado;
            }

            OdbcDataAdapter dataUsuarios = new OdbcDataAdapter(sUsuarios, cn.conectar());
            funInsertarBitacora(idUsuario, "Realizo una consulta a usuarios", "tbl_usuarios", "1000");
            return dataUsuarios;
        }

        /**********Ismar Cortez*************************/
        /*********Mostrar modulo**********************/
        public OdbcDataAdapter funmodulos()
        {
            cn.conectar();
            string smodulos = "SELECT Pk_id_modulos as ID_Modulos, nombre_modulo as Modulo, descripcion_modulo as Descripcion, estado_modulo as Estado FROM Tbl_modulos";
            OdbcDataAdapter datamodulos = new OdbcDataAdapter(smodulos, cn.conectar());
            funInsertarBitacora(idUsuario, "Realizo una consulta a modulos", "tbl_modulos", "1000");
            MessageBox.Show("");
            return datamodulos;
        }
        /**************************************************/


        /*****************Ismar Cortez**************/
        /**************Mostrar perfiles*************/
        public OdbcDataAdapter funperfiles()
        {
            cn.conectar();
            string sperfiles = "SELECT Pk_id_perfil as ID_Perfiles, nombre_perfil as Perfil, descripcion_perfil as Descripcion, estado_perfil as Estado FROM Tbl_perfiles";
            OdbcDataAdapter dataperfiles = new OdbcDataAdapter(sperfiles, cn.conectar());
            funInsertarBitacora(idUsuario, "Realizo una consulta a perfiles", "tbl_perfiles", "1000");
            return dataperfiles;
        }
        /*********************************************/






        //****************************************Kevin López***************************************************
        public OdbcDataAdapter funconsultarmodulos()
        {
            cn.conectar();
            string sqlModulos = "SELECT nombre_modulo FROM Tbl_modulos WHERE estado_modulo = 1";
            OdbcDataAdapter dataModulos = new OdbcDataAdapter(sqlModulos, cn.conectar());
            funInsertarBitacora(idUsuario, "Realizo una consulta a modulos", "Tbl_modulos", "1000");
            return dataModulos;
        }
        //****************************************FIN Kevin López***************************************************

        //****************************************Kevin López***************************************************
        public OdbcDataAdapter funconsultarperfiles()
        {
            cn.conectar();
            string sqlPerfiles = "SELECT nombre_perfil FROM Tbl_perfiles WHERE estado_perfil = 1";
            OdbcDataAdapter dataPerfiles = new OdbcDataAdapter(sqlPerfiles, cn.conectar());
            funInsertarBitacora(idUsuario, "Realizo una consulta a perfiles", "Tbl_perfiles", "1000");
            return dataPerfiles;
        }
        //****************************************Kevin López***************************************************

        //#############INICIO ALYSON RODRIGUEZ 9959-21-829
        public OdbcDataAdapter funconsultarAplicaciones(string nombreModulo)
        {
            cn.conectar();

            try
            {
                string sqlAplicaciones = @"
        SELECT a.Pk_id_aplicacion, a.nombre_aplicacion 
        FROM tbl_aplicaciones a
        JOIN tbl_asignacion_modulo_aplicacion ama ON a.pk_id_aplicacion = ama.fk_id_aplicacion
        JOIN tbl_modulos m ON m.pk_id_modulos = ama.fk_id_modulos
        WHERE m.nombre_modulo = ?";

                OdbcDataAdapter dataAplicaciones = new OdbcDataAdapter(sqlAplicaciones, cn.conectar());
                dataAplicaciones.SelectCommand.Parameters.AddWithValue("?", nombreModulo);

                // Registro de la bitacora
                funInsertarBitacora(idUsuario, "Realizó una consulta a aplicaciones", "tbl_aplicacion", "1000");

                return dataAplicaciones;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //#############FINALIZA ALYSON RODRIGUEZ 9959-21-829


        //Trabajado María José Véliz
        public OdbcDataAdapter funInsertarPermisosUA(string sCodigoUsuario, string sNombreAplicacion, string sIngresar, string sConsulta, string sModificar, string sEliminar, string sImprimir)
        {
            string sCodigoAplicacion = " ";
            string sCodigoUsuarios = " ";

            try
            {
                // Obtén el código de la aplicación
                OdbcCommand sqlCodigoModulo = new OdbcCommand("SELECT Pk_id_aplicacion FROM Tbl_aplicaciones WHERE nombre_aplicacion = '" + sNombreAplicacion + "' ", cn.conectar());
                OdbcDataReader almacena = sqlCodigoModulo.ExecuteReader();

                while (almacena.Read() == true)
                {
                    sCodigoAplicacion = almacena.GetString(0);
                }


                // Obtén el código del usuario
                OdbcCommand sqlCodigoUsuario = new OdbcCommand("SELECT Pk_id_usuario FROM Tbl_usuarios WHERE nombre_usuario = '" + sCodigoUsuario + "' ", cn.conectar());
                OdbcDataReader almacenaUsuario = sqlCodigoUsuario.ExecuteReader();

                while (almacenaUsuario.Read() == true)
                {
                    sCodigoUsuarios = almacenaUsuario.GetString(0);
                }
                almacenaUsuario.Close();
                sqlCodigoUsuario.Connection.Close();
                //MessageBox.Show(sCodigoUsuario);
                // Inserta los permisos usando el código de la aplicación y el código del usuario
                string sqlInsertarPermisosUA = "INSERT INTO Tbl_permisos_aplicaciones_usuario(Fk_id_usuario, Fk_id_aplicacion, guardar_permiso, buscar_permiso, modificar_permiso, eliminar_permiso, imprimir_permiso) VALUES ('" + sCodigoUsuario + "','" + sCodigoAplicacion + "', '" + sIngresar + "', '" + sConsulta + "', '" + sModificar + "', '" + sEliminar + "', '" + sImprimir + "');";
                // MessageBox.Show(sqlInsertarPermisosUA);
                // Ejecuta el comando de inserción
                OdbcDataAdapter dataPermisosUA = new OdbcDataAdapter(sqlInsertarPermisosUA, cn.conectar());
                // Inserta en la bitácora
                funInsertarBitacora(idUsuario, "Asignó aplicación: " + sNombreAplicacion + " a usuario: " + sCodigoUsuario, "Tbl_permisos_aplicaciones_usuario", "1000");


                almacena.Close();
                sqlCodigoModulo.Connection.Close();

                return dataPermisosUA;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //Termina

        //Trabajado por ALyson Rodriguez 9959-21-829
        public OdbcDataAdapter funMostrarUsuariosYPermisos(string sTablaAplicacionUsuario)
        {
            try
            {
                // Consulta para obtener usuarios y permisos aplicaciones segun modulos
                string sql = @"
                        SELECT 
                            au.Fk_id_usuario AS ID_Usuario, 
                            u.nombre_usuario AS Nombre_Usuario,
                            a.nombre_aplicacion AS Aplicacion, 
                            au.guardar_permiso AS Guardar, 
                            au.buscar_permiso AS Buscar, 
                            au.modificar_permiso AS Modificar, 
                            au.eliminar_permiso AS Eliminar, 
                            au.imprimir_permiso AS Imprimir
                        FROM 
                            Tbl_permisos_aplicaciones_usuario au
                        JOIN 
                            Tbl_aplicaciones a ON au.Fk_id_aplicacion = a.Pk_id_aplicacion
                        JOIN 
                            Tbl_usuarios u ON au.Fk_id_usuario = u.Pk_id_usuario;
                ";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conectar());
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                return null;
            }
        }
        //Finaliza

        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        public OdbcDataAdapter funmostrarPerfilesDeUsuario()///
        {
            /*string sql = "SELECT * FROM " + TablaPerfilUsuario + ";";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conectar());
            return dataTable;*/

            cn.conectar();
            string sqlPerfilUsuario = @"
    SELECT 
        a.PK_id_Perfil_Usuario AS PerfilUsuarioID, 
        a.Fk_id_usuario AS UsuarioID, 
        m.nombre_usuario AS NombreUsuario, 
        a.Fk_id_perfil AS PerfilID, 
        ap.nombre_perfil AS NombrePerfil 
    FROM 
        Tbl_asignaciones_perfils_usuario a  
    JOIN 
        Tbl_usuarios m ON a.Fk_id_usuario = m.Pk_id_usuario 
    JOIN 
        Tbl_perfiles ap ON a.Fk_id_perfil = ap.Pk_id_perfil";

            OdbcDataAdapter dataPerfilUsuario = new OdbcDataAdapter(sqlPerfilUsuario, cn.conectar());
            funInsertarBitacora(idUsuario, "Realizó una consulta a Asignación de perfil a un usuario", "Tbl_asignaciones_perfils_usuario", "1000");
            return dataPerfilUsuario;
        }

        public OdbcDataAdapter funConsultarAsignaciones(string sID_apUsu)
        {
            cn.conectar();
            // Modificar la consulta SQL para la tabla tbl_asignaciones_perfils_usuario
            string ssqlAsignaciones = "SELECT PK_id_Perfil_Usuario, Fk_id_usuario, Fk_id_perfil FROM tbl_asignaciones_perfils_usuario WHERE Fk_id_usuario = " + sID_apUsu;

            // Insertar en la bitácora
            funInsertarBitacora(idUsuario, "Realizó una consulta a asignaciones de perfil", "tbl_asignaciones_perfils_usuario", "1000");

            // Crear y devolver el DataAdapter
            OdbcDataAdapter dataTable = new OdbcDataAdapter(ssqlAsignaciones, cn.conectar());
            return dataTable;
        }


        public bool funeliminarPerfilUsuario(string sId_Perfil_Usuario)
        {

            try
            {

                cn.conectar();
                string ssqlEliminarPerfilUsuario = "DELETE FROM Tbl_asignaciones_perfils_usuario WHERE PK_id_Perfil_Usuario = ?";
                using (OdbcCommand cmd = new OdbcCommand(ssqlEliminarPerfilUsuario, cn.conectar()))
                {

                    cmd.Parameters.AddWithValue("@Id_Perfil_Usuario", sId_Perfil_Usuario);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        funInsertarBitacora(idUsuario, "Eliminó un perfil: " + sId_Perfil_Usuario, "Tbl_asignaciones_perfils_usuario", "1000");
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }


        }

        public void proinsertarPerfilUsuario(string scodigoUsuario, string scodigoPerfil)
        {
            //MessageBox.Show(scodigoUsuario + " " + scodigoPerfil);

            try
            {
                using (OdbcConnection connection = cn.conectar())

                {
                    //
                    string query = "INSERT INTO Tbl_asignaciones_perfils_usuario(" +
                                                     "Fk_id_usuario," +
                                                     "Fk_id_perfil)" +
                                                     "VALUES (?, ?) ";

                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        // Agregar los parámetros al comando
                        cmd.Parameters.AddWithValue("@Fk_id_usuario", scodigoUsuario);
                        cmd.Parameters.AddWithValue("@Fk_id_perfil", scodigoPerfil);
                        //MessageBox.Show(cmd.ToString());
                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();
                        funInsertarBitacora(idUsuario, "Inserto un nuevo modulo: " + scodigoUsuario + " - " + scodigoPerfil, "Tbl_asignaciones_perfils_usuario", "1000");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la asignacion: " + ex.Message);
            }
        }

        public OdbcDataAdapter funactualizarPerfilUsuario(string scodigo, string nuevoUsuarioID, string nuevoPerfilID)
        {
            try
            {
                // Conectar a la base de datos
                cn.conectar();

                // Construir la sentencia SQL de actualización
                string ssqlactualizar = "UPDATE tbl_asignaciones_perfils_usuario " +
                                        "SET Fk_id_usuario = '" + nuevoUsuarioID + "', " +
                                        "Fk_id_perfil = '" + nuevoPerfilID + "' " +
                                        "WHERE PK_id_Perfil_Usuario = '" + scodigo + "'";

                // Mostrar la sentencia en consola (opcional para depuración)
                Console.WriteLine("SQL Ejecutada: " + ssqlactualizar);

                // Ejecutar la consulta usando un OdbcDataAdapter
                OdbcDataAdapter dataAdapter = new OdbcDataAdapter(ssqlactualizar, cn.conectar());

                // Insertar en la bitácora
                funInsertarBitacora(idUsuario,
                    "Actualizó una asignación: " + scodigo + " - Usuario: " + nuevoUsuarioID + " - Perfil: " + nuevoPerfilID,
                    "tbl_asignaciones_perfils_usuario",
                    "1001");

                // Devolver el adaptador de datos
                return dataAdapter;
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine("Error al actualizar la asignación: " + ex.Message);
                return null;
            }
        }



        public OdbcDataAdapter funvalidarIDAplicacion()
        {
            try
            {

                string sqlIDAplicacion = "SELECT MAX(Pk_id_aplicacion)+1 FROM tbl_aplicaciones";
                OdbcDataAdapter dataIDAplicacion = new OdbcDataAdapter(sqlIDAplicacion, cn.conectar());
                funInsertarBitacora(idUsuario, "Se selecciono una aplicación", "tbl_aplicaciones", "1000");
                return dataIDAplicacion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        public OdbcDataAdapter proconsultaraplicaciones(string saplicacion)
        {
            cn.conectar();
            string ssqlAplicaciones = "SELECT * FROM tbl_aplicaciones WHERE Pk_id_aplicacion = " + saplicacion;
            funInsertarBitacora(idUsuario, "Realizo una consulta a aplicaciones", "tbl_aplicaciones", "1000");
            OdbcDataAdapter dataTable = new OdbcDataAdapter(ssqlAplicaciones, cn.conectar());
            return dataTable;
        }
        /*******************IsmarCortez******************************************/
        public OdbcDataAdapter funmostraraplicaciones()
        {
            cn.conectar();
            string saplicaciones = "SELECT Pk_id_aplicacion as ID_Aplicacion, nombre_aplicacion as Aplicacion, descripcion_aplicacion as Descripcion, estado_aplicacion as Estado FROM Tbl_aplicaciones";
            OdbcDataAdapter dataaplicaciones = new OdbcDataAdapter(saplicaciones, cn.conectar());
            funInsertarBitacora(idUsuario, "Realizo una consulta a aplicaciones", "tbl_aplicaciones", "1000");
            return dataaplicaciones;
        }
        /***********************************************************************/
        public void proinsertaraplicacion(string scodigo, string snombre, string sdescripcion, string sestado)
        {
            try
            {
                // Crear la conexión y el comando
                using (OdbcConnection connection = cn.conectar())
                {
                    string query = "INSERT INTO tbl_aplicaciones (" +
                                   "Pk_id_aplicacion, " +
                                   "nombre_aplicacion, " +
                                   "descripcion_aplicacion, " +
                                   "estado_aplicacion) " +
                                   "VALUES (?, ?, ?, ?)";

                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        // Agregar los parámetros al comando
                        cmd.Parameters.AddWithValue("@Pk_id_modulo", scodigo);
                        cmd.Parameters.AddWithValue("@nombre_modulo", snombre);
                        cmd.Parameters.AddWithValue("@descripcion_modulo", sdescripcion);
                        cmd.Parameters.AddWithValue("@estado_modulo", sestado);

                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();

                        funInsertarBitacora(idUsuario, "Inserto un nuevo modulo: " + scodigo + " - " + snombre, "tbl_aplicaciones", "1000");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la aplicación: " + ex.Message);
            }
        }

        public OdbcDataAdapter funConsultaraplicaciones(string saplicacion)
        {
            cn.conectar();
            string ssqlAplicaciones = "SELECT * FROM Tbl_aplicaciones WHERE Pk_id_aplicacion = " + saplicacion;
            funInsertarBitacora(idUsuario, "Realizo una consulta a aplicaciones", "Tbl_aplicaciones", "1000");
            OdbcDataAdapter dataTable = new OdbcDataAdapter(ssqlAplicaciones, cn.conectar());
            return dataTable;
        }


        public bool funeliminaraplicacion(string scodigo)
        {
            try
            {

                cn.conectar();


                string ssqlEliminarAplicacion = "DELETE FROM tbl_aplicaciones WHERE Pk_id_aplicacion = ?";

                using (OdbcCommand cmd = new OdbcCommand(ssqlEliminarAplicacion, cn.conectar()))
                {

                    cmd.Parameters.AddWithValue("@codigo", scodigo);


                    int rowsAffected = cmd.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {
                        funInsertarBitacora(idUsuario, "Eliminó una aplicacion: " + scodigo, "tbl_aplicaciones", "1000");
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }

        }

        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################

        //---------------------------------------------------- Inicio: GABRIELA SUC ---------------------------------------------------
        public bool funModificarUsuario(string sId_Usuario, string sNombre, string sApellido, string sCorreo, int sEstado_usuario, string sPregunta, string sRespuesta)
        {
            try
            {
                // Comenzar a construir la consulta SQL
                string squery = "UPDATE Tbl_usuarios SET ";

                // Lista de parámetros a incluir en la consulta
                List<OdbcParameter> parameters = new List<OdbcParameter>();

                // Agregar solo los campos que no estén vacíos
                if (!string.IsNullOrEmpty(sNombre))
                {
                    squery += "nombre_usuario = ?, ";
                    parameters.Add(new OdbcParameter("nombre_usuario", sNombre));
                }
                if (!string.IsNullOrEmpty(sApellido))
                {
                    squery += "apellido_usuario = ?, ";
                    parameters.Add(new OdbcParameter("apellido_usuario", sApellido));
                }
                if (!string.IsNullOrEmpty(sCorreo))
                {
                    squery += "email_usuario = ?, ";
                    parameters.Add(new OdbcParameter("email_usuario", sCorreo));
                }
                if (!string.IsNullOrEmpty(sRespuesta))
                {
                    squery += "respuesta = ?, ";
                    parameters.Add(new OdbcParameter("respuesta", sRespuesta));
                }

                // Asegurarse de agregar la pregunta seleccionada
                if (!string.IsNullOrEmpty(sPregunta))
                {
                    squery += "pregunta = ?, "; // Asegúrate de que el campo en la BD sea correcto
                    parameters.Add(new OdbcParameter("pregunta", sPregunta));
                }

                // El estado siempre se modifica (0 o 1)
                squery += "estado_usuario = ? ";
                parameters.Add(new OdbcParameter("estado_usuario", sEstado_usuario));

                // Completar la consulta SQL con la condición WHERE
                squery += "WHERE Pk_id_usuario = ?;";
                parameters.Add(new OdbcParameter("id_usuario", sId_Usuario));

                // Ejecutar la consulta SQL
                using (OdbcCommand command = new OdbcCommand(squery, cn.conectar()))
                {
                    // Agregar los parámetros al comando
                    foreach (var param in parameters)
                    {
                        command.Parameters.Add(param);
                    }
                    funInsertarBitacora(idUsuario, "Se modificó el usuario: " + sId_Usuario, "Tbl_usuarios", "1000");

                    // Ejecutar la consulta
                    int result = command.ExecuteNonQuery();

                    // Verificar si se modificó algún registro
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al intentar modificar el registro: " + ex.Message);
                funInsertarBitacora(idUsuario, "Ocurrio un error al modificar el usuario: " + sId_Usuario, "Tbl_usuarios", "1000");
                return false;
            }
        }


        //---------------------------------------------------- Fin: GABRIELA SUC ----------------------------------------------------

        /* Creado por Emerzon Garcia */

        public bool funEliminarPerfil1(string sID_perfil)
        {
            try
            {
                // Conectar a la base de datos
                cn.conectar();

                // Crear la consulta SQL para eliminar
                string sEliminarPerfil = "DELETE FROM Tbl_perfiles WHERE PK_id_perfil = ?";

                // Usar OdbcCommand para ejecutar el DELETE
                using (OdbcCommand cmd = new OdbcCommand(sEliminarPerfil, cn.conectar()))
                {
                    // Agregar parámetro para evitar inyecciones SQL
                    cmd.Parameters.AddWithValue("@ID_perfil", sID_perfil);

                    // Ejecutar la consulta
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Insertar en bitácora si la eliminación fue exitosa
                    if (rowsAffected > 0)
                    {
                        funInsertarBitacora(idUsuario, "Eliminó un perfil: " + sID_perfil, "tbl_perfil", "1000");
                        return true; // Indica que la eliminación fue exitosa
                    }
                    else
                    {
                        return false; // No se afectó ninguna fila
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/



        //AGREGAR
        //KATERYN DE LEON

        //--------------------------------------------------------------- Inicio: Marco Monroy ---------------------------------------------------------------
        public OdbcDataAdapter funInsertarusuario(string sNombre, string sApellido, string sId, string sClave, string sCorreo, string sFecha, string sEstadousuario, string sPregunta, string sRespuesta)
        {
            // Consulta SQL con concatenación de valores (esto es menos seguro, pero funciona en tu caso)
            string ssqlusuarios = "INSERT INTO tbl_usuarios (nombre_usuario, apellido_usuario, username_usuario, password_usuario, email_usuario, ultima_conexion_usuario, estado_usuario, pregunta, respuesta) " +
                                 "VALUES ('" + sNombre + "', '" + sApellido + "', '" + sId + "', '" + sClave + "', '" + sCorreo + "', '" + sFecha + "', '" + sEstadousuario + "', '" + sPregunta + "', '" + sRespuesta + "')";

            // Crear el comando y asignar la conexión
            OdbcDataAdapter datausuarios = new OdbcDataAdapter(ssqlusuarios, cn.conectar());

            try
            {
                funInsertarBitacora(idUsuario, "Se inserto el usuario con nombre: " + sId, "tbl_usuarios", "1101");
                return datausuarios; // Retorna si la inserción fue exitosa
            }
            catch (Exception ex)
            {
                // Capturar cualquier excepción y manejarla
                Console.WriteLine("Error al insertar el usuario: " + ex.Message);

                // Retornar null o manejar de acuerdo a tus necesidades
                return null;
            }
        }


        //--------------------------------------------------------------- Fin: Marco Monroy ---------------------------------------------------------------


        public OdbcDataAdapter insertarclaves(string id, string nombre, string apellido, string clave)
        {
            cn.conectar();
            MessageBox.Show("Contraseña Actualizada");
            string sqlconsulta = "UPDATE tbl_usuarios set PK_id_usuario='" + id + "',nombre_usuario='" + apellido + "',apellido_usuarios='" + nombre + "',password_usuario='" + clave + "',estado_usuario='1' where PK_id_usuario='" + id + "'";
            OdbcDataAdapter dataconsulta = new OdbcDataAdapter(sqlconsulta, cn.conectar());
            funInsertarBitacora(idUsuario, "Se inserto el usuario con id: " + id, "tbl_usuarios", "1201");
            return dataconsulta;
        }

        public OdbcDataAdapter update(string usuario)
        {
            cn.conectar();
            string sqlconsulta = "select PK_id_perfil FROM tbl_usuario_perfil where PK_id_usuario = '" + usuario + "'";
            OdbcDataAdapter dataconsulta = new OdbcDataAdapter(sqlconsulta, cn.conectar());
            return dataconsulta;

        }


        public OdbcDataAdapter clienteupdate(string clave, string usuario)
        {
            cn.conectar();
            MessageBox.Show("Contraseña Actualizada");
            string sqlconsulta = "UPDATE tbl_usuario set password_usuario='" + clave + "' where PK_id_usuario='" + usuario + "'";
            OdbcDataAdapter dataconsulta = new OdbcDataAdapter(sqlconsulta, cn.conectar());
            return dataconsulta;
        }


        //---------------------------------------------------- Inicio: GABRIELA SUC ----------------------------------------------------

        // Método para cambiar el estado del usuario en la base de datos
        public bool funCambiarEstadoUsuario(string sLlaveUsuario, int sNuevoEstado)
        {
            try
            {
                // Consulta SQL para actualizar el estado del usuario
                string squery = "UPDATE Tbl_usuarios SET estado_usuario = ? WHERE Pk_id_usuario = ?";

                using (OdbcCommand command = new OdbcCommand(squery, cn.conectar()))
                {
                    command.Parameters.AddWithValue("estado_usuario", sNuevoEstado);
                    command.Parameters.AddWithValue("id_usuario", sLlaveUsuario);

                    funInsertarBitacora(idUsuario, "Se desactivo el usuario: " + sLlaveUsuario, "tbl_usuarios", "1000");
                    int iResult = command.ExecuteNonQuery();

                    // Verifica si se actualizó algún registro
                    return iResult > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar el estado del usuario: " + ex.Message);
                funInsertarBitacora(idUsuario, "Ocurrio un error al desactivar el usuario: " + sLlaveUsuario, "tbl_usuarios", "1000");
                return false;
            }
        }

        //---------------------------------------------------- Fin: GABRIELA SUC ----------------------------------------------------


        // Esta parte fue echa por Carlos Hernandez
        public OdbcDataAdapter funactualizaraplicacion(string scodigo, string snombre, string sdescripcion, string sestado)
        {
            Console.WriteLine("ESTO SE INGRESA EN LA SENTENCIA: " + scodigo + ", " + snombre + ", " + sdescripcion + ", " + sestado);
            try
            {
                cn.conectar();
                string ssqlactualizaraplicacion = "UPDATE tbl_aplicaciones SET nombre_aplicacion = '" + snombre + "', descripcion_aplicacion = '" + sdescripcion + "', estado_aplicacion = '" + sestado + "' WHERE Pk_id_aplicacion ='" + scodigo + "'";
                OdbcDataAdapter dataTable = new OdbcDataAdapter(ssqlactualizaraplicacion, cn.conectar());
                funInsertarBitacora(idUsuario, "Actualizo una aplicacion: " + scodigo + " - " + snombre, "tbl_aplicaciones", "1000");
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }
        //termina lo que hizo carlos hernandez 


        //Kateryn De León
        //MOSTRAR PARA  EL BOTON BUSCAR 
        public OdbcDataAdapter funMostrar(string sId)
        {
            OdbcConnection connection = cn.conectar();

            string ssqlusuarios = "SELECT Pk_id_usuario as Usuario, nombre_usuario as Nombre, apellido_usuario as Apellido, username_usuario as Username, password_usuario as Password, email_usuario as Email, ultima_conexion_usuario as Ultima_Conexion, estado_usuario as Estado, pregunta as Pregunta, respuesta as Respuesta FROM tbl_usuarios where pk_id_usuario = '" + sId + "'";

            OdbcCommand command = new OdbcCommand(ssqlusuarios, connection);

            try
            {
                // Ejecutar la consulta de inserción
                command.ExecuteNonQuery();
                funInsertarBitacora(idUsuario, "Se buscaron los datos del usuario con id: " + sId, "tbl_usuarios", "1000");
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al insertar usuario: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                connection.Close();
            }

            OdbcDataAdapter datausuarios = new OdbcDataAdapter(ssqlusuarios, cn.conectar());

            if (datausuarios == null)
            {
                return null;
            }
            else
                return datausuarios;
        }
        public OdbcDataAdapter funMostraraplicacion(string sId)
        {

            cn.conectar();
            string ssqlusuarios = "SELECT PK_id_aplicacion,PK_id_modulo,nombre_aplicacion,descripcion_aplicacion from tbl_aplicacion WHERE PK_id_aplicacion ='" + sId + "'";
            OdbcDataAdapter datausuarios = new OdbcDataAdapter(ssqlusuarios, cn.conectar());

            if (datausuarios == null)
            {
                return null;
            }
            else
                return datausuarios;
        }

        /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/


        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        public OdbcDataAdapter funvalidaridmodulos()
        {
            try
            {

                string sqlIDmodulo = "SELECT MAX(Pk_id_modulo)+1 FROM tbl_modulos";
                OdbcDataAdapter dataIDmodulo = new OdbcDataAdapter(sqlIDmodulo, cn.conectar());
                funInsertarBitacora(idUsuario, "Se mostraron los modulos", "tbl_modulos", "1000");
                return dataIDmodulo;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        // termina
        public OdbcDataAdapter funagregarperfil()
        {
            try
            {

                string sqlIDperfil = "SELECT MAX(Pk_id_perfil)+1 FROM Tbl_perfiles";
                OdbcDataAdapter dataIDperfil = new OdbcDataAdapter(sqlIDperfil, cn.conectar());
                return dataIDperfil;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }




        public OdbcDataAdapter proinsertarperfil(string scodigo, string snombre, string sdescripcion, string sestado)
        {
            cn.conectar();
            try
            {
                string sqlPerfil = "INSERT INTO Tbl_perfiles (Pk_id_Perfil, nombre_perfil, descripcion_perfil, estado_perfil) VALUES ('" + scodigo + "','" + snombre + "', '" + sdescripcion + "', " + sestado + ");";
                OdbcDataAdapter datainsertarperfil = new OdbcDataAdapter(sqlPerfil, cn.conectar());
                funInsertarBitacora(idUsuario, "Inserto un nuevo perfil: " + scodigo + " - " + snombre, "Tbl_perfiles", "1000");
                return datainsertarperfil;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //*****************ACA TERMINA LA PRIMERA PARTE ACTUALIZADA POR JOSUÉ DAVID PAZ GÓMEZ*************************

        //*****************KEVIN LOPEZ*************************
        public OdbcDataAdapter proconsultar(string sperfil)
        {
            cn.conectar();
            string sqlPerfil = "SELECT * FROM Tbl_perfiles WHERE nombre_perfil = '" + sperfil + "'"; ;
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sqlPerfil, cn.conectar());
            funInsertarBitacora(idUsuario, "Realizo una consulta a perfiles ", "Tbl_perfiles", "1000");

            return dataTable;
        }
        //*****************FIN KEVIN LOPEZ*************************

        public OdbcDataAdapter funactualizarperfil(string sID_perfil, string snombre, string sdescripcion, string sestado)
        {
            try
            {
                cn.conectar();
                string sqlactualizarperfil = "UPDATE Tbl_perfiles SET nombre_perfil = '" + snombre + "', descripcion_perfil = '" + sdescripcion + "', estado_perfil = '" + sestado + "' WHERE Pk_id_perfil ='" + sID_perfil + "'";
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sqlactualizarperfil, cn.conectar());
                funInsertarBitacora(idUsuario, "Actualizo un perfil: " + sID_perfil + " - " + snombre, "Tbl_perfiles", "1000");

                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        //Trabajado por María José Véliz Ochoa 9959-21-5909
        //se optó por usar OdbcCommand en lugar de OdbcDataAdapter, cambió estructura
        public void proinsertarmodulo(string sCodigo, string sNombre, string sDescripcion, string sEstado)
        {
            try
            {
                // Crear la conexión y el comando
                using (OdbcConnection connection = cn.conectar())
                {
                    string query = "INSERT INTO tbl_modulos (" +
                                   "Pk_id_modulos, " +
                                   "nombre_modulo, " +
                                   "descripcion_modulo, " +
                                   "estado_modulo) " +
                                   "VALUES (?, ?, ?, ?)";

                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        // Agregar los parámetros al comando
                        cmd.Parameters.AddWithValue("@Pk_id_modulo", sCodigo);
                        cmd.Parameters.AddWithValue("@nombre_modulo", sNombre);
                        cmd.Parameters.AddWithValue("@descripcion_modulo", sDescripcion);
                        cmd.Parameters.AddWithValue("@estado_modulo", sEstado);

                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();

                        funInsertarBitacora(idUsuario, "Inserto un nuevo modulo: " + sCodigo + " - " + sNombre, "tbl_modulos", "1000");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar módulo: " + ex.Message);
            }
        }
        // termina
        //------------

        //****************************************************MODIFICADO POR JOSUE PAZ***********************************************
        public OdbcDataAdapter proinsertarpermisosperfil(string scodigoperfil, string snombreaplicacion, string singresar, string smodificar, string seliminar, string sconsulta, string simprimir)
        {
            string sCodigoAplicacion = " ";
            string sCodigoPerfil = "";

            try
            {
                OdbcCommand sqlCodigoModulo = new OdbcCommand("SELECT Pk_id_aplicacion FROM Tbl_aplicaciones WHERE nombre_aplicacion = '" + snombreaplicacion + "' ", cn.conectar());
                OdbcDataReader almacena = sqlCodigoModulo.ExecuteReader();

                while (almacena.Read() == true)
                {
                    sCodigoAplicacion = almacena.GetString(0);
                }

                OdbcCommand sqlCodigoPerfil = new OdbcCommand("SELECT Pk_id_perfil FROM Tbl_perfiles WHERE nombre_perfil = '" + scodigoperfil + "' ", cn.conectar());
                OdbcDataReader almacenaPerfil = sqlCodigoPerfil.ExecuteReader();

                while (almacenaPerfil.Read() == true)
                {
                    sCodigoPerfil = almacenaPerfil.GetString(0);
                }

                string sqlInsertarPermisosPerfilApp = "INSERT INTO Tbl_permisos_aplicacion_perfil(Fk_id_perfil, Fk_id_aplicacion, guardar_permiso, modificar_permiso, eliminar_permiso, buscar_permiso, imprimir_permiso) VALUES ('" + sCodigoPerfil + "', '" + sCodigoAplicacion + "', '" + singresar + "', '" + smodificar + "', '" + seliminar + "', '" + sconsulta + "', '" + simprimir + "');";
                OdbcDataAdapter dataPermisosPerfilAplicacion = new OdbcDataAdapter(sqlInsertarPermisosPerfilApp, cn.conectar());
                funInsertarBitacora(idUsuario, "Asigno permiso: " + snombreaplicacion + " a perfil: " + scodigoperfil, "Tbl_permisos_aplicacion_perfil", "1000");


                almacena.Close();
                sqlCodigoModulo.Connection.Close();

                return dataPermisosPerfilAplicacion;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }

        //****************************ACA TERMINA******************************************************************


        //--------------------------------- Emerzon Garcia -----------------------------------------------------------

        public OdbcDataAdapter funmostrarperfilesypermisos(string sTablaPerfilUsuario)
        {
            try
            {
                // Consulta para obtener perfiles y permisos junto con el nombre de la aplicación
                string sql = @"
            SELECT p.Fk_id_perfil, a.nombre_aplicacion, 
                   p.guardar_permiso, p.buscar_permiso, p.modificar_permiso, 
                   p.eliminar_permiso, p.imprimir_permiso
            FROM Tbl_permisos_aplicacion_perfil p
            JOIN Tbl_aplicaciones a ON p.Fk_id_aplicacion = a.Pk_id_aplicacion
            JOIN Tbl_perfiles pf ON p.Fk_id_perfil = pf.Pk_id_perfil;
        ";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conectar());
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                return null;
            }
        }

        //---------------------------------------------------------------------------------------------------------------



        //------------Para formulario Mantenimiento Modulos---------

        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        public OdbcDataAdapter proconsultarmodulos(string sModulo)
        {
            cn.conectar();
            string sqlModulos = "SELECT * FROM tbl_modulos WHERE Pk_id_modulos = " + sModulo;
            funInsertarBitacora(idUsuario, "Realizo una consulta a modulos", "tbl_modulos", "1000");
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sqlModulos, cn.conectar());
            return dataTable;
        } //termina


        //Actualizar Permisos ua
        //María José Véliz Ochoa, 9959-21-5909
        public OdbcDataAdapter proactualizarpermisosUA(string sCodigoUsuario, string sNombreAplicacion, string sIngresar, string sConsulta, string sModificar, string sEliminar, string sImprimir)
        {
            try
            {
                // Obtener el ID de la aplicación basado en su nombre
                string sqlObtenerIdAplicacion = "SELECT Pk_id_aplicacion FROM Tbl_aplicaciones WHERE nombre_aplicacion = '" + sNombreAplicacion + "'";
                OdbcCommand command = new OdbcCommand(sqlObtenerIdAplicacion, cn.conectar());
                object idAplicacion = command.ExecuteScalar();

                if (idAplicacion == null)
                {
                    MessageBox.Show("No se encontró la aplicación con el nombre: " + sNombreAplicacion);
                    return null;
                }

                // Generar la consulta SQL para actualizar los permisos en la base de datos
                string sqlActualizarPermisos = "UPDATE tbl_permisos_aplicaciones_usuario SET " +
                                               "guardar_permiso = '" + sIngresar + "', " +
                                               "buscar_permiso= '" + sConsulta + "', " +
                                               "modificar_permiso = '" + sModificar + "', " +
                                               "eliminar_permiso = '" + sEliminar + "', " +
                                               "imprimir_permiso = '" + sImprimir + "' " +
                                               "WHERE Fk_id_usuario = '" + sCodigoUsuario + "' AND Fk_id_aplicacion = '" + idAplicacion + "'";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sqlActualizarPermisos, cn.conectar());
                funInsertarBitacora(idUsuario, $"Actualizó permisos para usuario: {sCodigoUsuario} en aplicación: {sNombreAplicacion}", "tbl_permisos_aplicaciones_usuario", "1000");
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }



        //María José Véliz Ochoa, 9959-21-5909
        public OdbcDataAdapter proEliminarRegistroUA(string sCodigoUsuario, string sNombreAplicacion)
        {
            try
            {
                // Obtener el ID de la aplicación basado en su nombre
                string sqlObtenerIdAplicacion = "SELECT Pk_id_aplicacion FROM Tbl_aplicaciones WHERE nombre_aplicacion = ?";

                using (OdbcCommand command = new OdbcCommand(sqlObtenerIdAplicacion, cn.conectar()))
                {
                    command.Parameters.AddWithValue("?", sNombreAplicacion);
                    object idAplicacion = command.ExecuteScalar();

                    if (idAplicacion == null)
                    {
                        MessageBox.Show("No se encontró la aplicación con el nombre: " + sNombreAplicacion);
                        return null;
                    }

                    // Generar la consulta SQL para eliminar registro en la base de datos
                    string sqlEliminarPermisos = "DELETE FROM tbl_permisos_aplicaciones_usuario " +
                                                  "WHERE Fk_id_usuario = ? AND Fk_id_aplicacion = ?";

                    using (OdbcCommand deleteCommand = new OdbcCommand(sqlEliminarPermisos, cn.conectar()))
                    {
                        deleteCommand.Parameters.AddWithValue("?", sCodigoUsuario);
                        deleteCommand.Parameters.AddWithValue("?", idAplicacion);

                        // Ejecutar el comando
                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        // Si se eliminó al menos un registro, registrar en la bitácora
                        if (rowsAffected > 0)
                        {
                            funInsertarBitacora(idUsuario, $"Eliminó el registro para usuario: {sCodigoUsuario} en aplicación: {sNombreAplicacion}", "tbl_permisos_aplicaciones_usuario", "1000");
                            MessageBox.Show("Registro eliminado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron registros para eliminar.");
                        }

                        return new OdbcDataAdapter(); // Retorna un objeto vacío, ya que no hay datos que cargar
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar permisos: {ex.Message}");
                return null;
            }
        }
        //termina

        //###############ALYSON RODRIGUEZ BOTON ACTUALIZAR 
        public OdbcDataAdapter proactualizarmodulo(string sIdModulo, string sNombre, string sDescripcion, string sEstado)
        {
            Console.WriteLine("ESTO SE INGRESA EN LA SENTENCIA: " + sIdModulo + ", " + sNombre + ", " + sDescripcion + ", " + sEstado);
            try
            {
                cn.conectar();
                string sqlactualizarmodulo = "UPDATE tbl_modulos SET nombre_modulo = '" + sNombre + "', descripcion_modulo = '" + sDescripcion + "', estado_modulo = '" + sEstado + "' WHERE PK_id_modulos ='" + sIdModulo + "'";
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sqlactualizarmodulo, cn.conectar());
                funInsertarBitacora(idUsuario, "Actualizo un modulo: " + sIdModulo + " - " + sNombre, "tbl_modulos", "1000");
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        // ########### FIN  ##########################################


        // Inicio Fernando Garcia - Brandon Boch

        public DataSet funConsultarBitacora()
        {
            OdbcDataAdapter dat = null;
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT PK_id_bitacora as Id, FK_id_usuario as Usuario, Fk_id_aplicacion as Aplicacion, fecha_bitacora as Fecha, hora_bitacora as Hora, host_bitacora as Host, ip_bitacora as IP, accion_bitacora as Accion, tabla as Tabla from tbl_bitacora"
                , cn.conectar());
                dat.Fill(ds);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        // Nuevo método para búsqueda filtrada
        public DataSet funConsultarBitacoraFiltrada(string sCampo, string sValor)
        {
            OdbcDataAdapter dat = null;
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                string query = $"SELECT PK_id_bitacora as Id, FK_id_usuario as Usuario, Fk_id_aplicacion as Aplicacion, fecha_bitacora as Fecha, hora_bitacora as Hora, host_bitacora as Host, ip_bitacora as IP, accion_bitacora as Accion, tabla  as Tabla FROM tbl_bitacora WHERE {sCampo} LIKE ?";

                using (OdbcConnection conexion = cn.conectar())
                {
                    dat = new OdbcDataAdapter(query, conexion);
                    dat.SelectCommand.Parameters.AddWithValue("?", $"%{sValor}%");
                    dat.Fill(ds);
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public void funInsertarBitacora(string idUsuario, string sAccion, string sTabla, string sIdAplicacion)
        {
            try
            {
                string sipLocal = funObtenerDireccionIPLocal();
                string snombreHost = Dns.GetHostName();

                using (OdbcConnection conexion = cn.conectar())
                {
                    string obtenerIdUsuarioQuery = "SELECT Pk_id_usuario FROM Tbl_usuarios WHERE username_usuario = ?";
                    OdbcCommand obtenerIdUsuarioCmd = new OdbcCommand(obtenerIdUsuarioQuery, conexion);
                    obtenerIdUsuarioCmd.Parameters.AddWithValue("?", idUsuario);



                    object resultado = obtenerIdUsuarioCmd.ExecuteScalar();
                    if (resultado != null)
                    {
                        string susuario = resultado.ToString();

                        string sconsulta = @"INSERT INTO tbl_bitacora 
                                (Fk_id_usuario, Fk_id_aplicacion, fecha_bitacora, hora_bitacora, host_bitacora, ip_bitacora, accion_bitacora, tabla) 
                                VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

                        using (OdbcCommand cmd = new OdbcCommand(sconsulta, conexion))
                        {
                            cmd.Parameters.AddWithValue("?", susuario);
                            cmd.Parameters.AddWithValue("?", sIdAplicacion);
                            cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("HH:mm:ss"));
                            cmd.Parameters.AddWithValue("?", snombreHost);
                            cmd.Parameters.AddWithValue("?", sipLocal);
                            cmd.Parameters.AddWithValue("?", sAccion);
                            cmd.Parameters.AddWithValue("?", sTabla);


                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Registrar la excepción o manejarla apropiadamente
                MessageBox.Show("Error al insertar en la bitácora: " + ex.Message);
            }
        }
        private string funObtenerDireccionIPLocal()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "No se pudo determinar la dirección IP local";
        }

        //Fin #########################3

        /************************Ismar Leonel Cortez Sanchez*********************************************************************/
        /*Funcion de ConsultarPermisos()*****************************************************************************************/
        public bool funConsultarPermisos(string sidUsuario, string sIdAplicacion, int iTipoPermiso)
        {
            try
            {
                switch (iTipoPermiso)
                {
                    case 1:
                        OdbcCommand sql = new OdbcCommand("Select guardar_permiso from Tbl_permisos_aplicaciones_usuario WHERE Fk_id_usuario= '" + sidUsuario + "' AND Fk_id_aplicacion ='" + sIdAplicacion + "'", cn.conectar());
                        OdbcDataReader almacena = sql.ExecuteReader();

                        if (almacena.Read() == true)
                        {
                            if (almacena.GetString(0) == "1")
                            {
                                almacena.Close();
                                sql.Connection.Close();

                                return true;

                            }
                        }

                        sql = new OdbcCommand("Select Tbl_permisos_aplicacion_perfil.guardar_permiso from Tbl_permisos_aplicacion_perfil " +
                            "INNER JOIN Tbl_asignaciones_perfils_usuario ON Tbl_permisos_aplicacion_perfil.Fk_id_perfil = Tbl_asignaciones_perfils_usuario.Fk_id_perfil" +
                            " WHERE Tbl_asignaciones_perfils_usuario.Fk_id_usuario= '" + sidUsuario + "' AND Tbl_permisos_aplicacion_perfil.Fk_id_aplicacion ='" + sIdAplicacion + "'", cn.conectar());
                        almacena = sql.ExecuteReader();

                        if (almacena.Read() == true)
                        {
                            if (almacena.GetString(0) == "1")
                            {
                                almacena.Close();
                                sql.Connection.Close();

                                return true;
                            }
                        }

                        break;

                    case 2:
                        sql = new OdbcCommand("Select buscar_permiso from Tbl_permisos_aplicaciones_usuario WHERE Fk_id_usuario= '" + sidUsuario + "' AND Fk_id_aplicacion ='" + sIdAplicacion + "'", cn.conectar());
                        almacena = sql.ExecuteReader();

                        if (almacena.Read() == true)
                        {
                            if (almacena.GetString(0) == "1")
                            {
                                almacena.Close();
                                sql.Connection.Close();
                                return true;
                            }
                        }

                        sql = new OdbcCommand("Select Tbl_permisos_aplicacion_perfil.buscar_permiso from Tbl_permisos_aplicacion_perfil " +
                            "INNER JOIN Tbl_asignaciones_perfils_usuario ON Tbl_permisos_aplicacion_perfil.Fk_id_perfil = Tbl_asignaciones_perfils_usuario.Fk_id_perfil" +
                            " WHERE Tbl_asignaciones_perfils_usuario.Fk_id_usuario= '" + sidUsuario + "' AND Tbl_permisos_aplicacion_perfil.Fk_id_aplicacion ='" + sIdAplicacion + "'", cn.conectar());
                        almacena = sql.ExecuteReader();

                        if (almacena.Read() == true)
                        {
                            if (almacena.GetString(0) == "1")
                            {
                                almacena.Close();
                                sql.Connection.Close();
                                return true;
                            }
                        }

                        break;

                    case 3:
                        sql = new OdbcCommand("Select modificar_permiso from Tbl_permisos_aplicaciones_usuario WHERE Fk_id_usuario= '" + sidUsuario + "' AND Fk_id_aplicacion ='" + sIdAplicacion + "'", cn.conectar());
                        almacena = sql.ExecuteReader();

                        if (almacena.Read() == true)
                        {
                            if (almacena.GetString(0) == "1")
                            {
                                almacena.Close();
                                sql.Connection.Close();
                                return true;
                            }
                        }

                        sql = new OdbcCommand("Select Tbl_permisos_aplicacion_perfil.modificar_permiso from Tbl_permisos_aplicacion_perfil " +
                            "INNER JOIN Tbl_asignaciones_perfils_usuario ON Tbl_permisos_aplicacion_perfil.Fk_id_perfil = Tbl_asignaciones_perfils_usuario.Fk_id_perfil" +
                            " WHERE Tbl_asignaciones_perfils_usuario.Fk_id_usuario= '" + sidUsuario + "' AND Tbl_permisos_aplicacion_perfil.Fk_id_aplicacion ='" + sIdAplicacion + "'", cn.conectar());
                        almacena = sql.ExecuteReader();

                        if (almacena.Read() == true)
                        {
                            if (almacena.GetString(0) == "1")
                            {
                                almacena.Close();
                                sql.Connection.Close();
                                return true;
                            }
                        }

                        break;

                    case 4:
                        sql = new OdbcCommand("Select eliminar_permiso from Tbl_permisos_aplicaciones_usuario WHERE Fk_id_usuario= '" + sidUsuario + "' AND Fk_id_aplicacion ='" + sIdAplicacion + "'", cn.conectar());
                        almacena = sql.ExecuteReader();

                        if (almacena.Read() == true)
                        {
                            if (almacena.GetString(0) == "1")
                            {
                                almacena.Close();
                                sql.Connection.Close();
                                return true;
                            }
                        }

                        sql = new OdbcCommand("Select Tbl_permisos_aplicacion_perfil.eliminar_permiso from Tbl_permisos_aplicacion_perfil " +
                            "INNER JOIN Tbl_asignaciones_perfils_usuario ON Tbl_permisos_aplicacion_perfil.Fk_id_perfil = Tbl_asignaciones_perfils_usuario.Fk_id_perfil" +
                            " WHERE Tbl_asignaciones_perfils_usuario.Fk_id_usuario= '" + sidUsuario + "' AND Tbl_permisos_aplicacion_perfil.Fk_id_aplicacion ='" + sIdAplicacion + "'", cn.conectar());
                        almacena = sql.ExecuteReader();

                        if (almacena.Read() == true)
                        {
                            if (almacena.GetString(0) == "1")
                            {
                                almacena.Close();
                                sql.Connection.Close();
                                return true;
                            }
                        }

                        break;

                    case 5:
                        sql = new OdbcCommand("Select imprimir_permiso from Tbl_permisos_aplicaciones_usuario WHERE Fk_id_usuario= '" + sidUsuario + "' AND Fk_id_aplicacion ='" + sIdAplicacion + "'", cn.conectar());
                        almacena = sql.ExecuteReader();

                        if (almacena.Read() == true)
                        {
                            if (almacena.GetString(0) == "1")
                            {
                                almacena.Close();
                                sql.Connection.Close();
                                return true;
                            }
                        }

                        sql = new OdbcCommand("Select Tbl_permisos_aplicacion_perfil.imprimir_permiso from Tbl_permisos_aplicacion_perfil " +
                            "INNER JOIN Tbl_asignaciones_perfils_usuario ON Tbl_permisos_aplicacion_perfil.Fk_id_perfil = Tbl_asignaciones_perfils_usuario.Fk_id_perfil" +
                            " WHERE Tbl_asignaciones_perfils_usuario.Fk_id_usuario= '" + sidUsuario + "' AND Tbl_permisos_aplicacion_perfil.Fk_id_aplicacion ='" + sIdAplicacion + "'", cn.conectar());
                        almacena = sql.ExecuteReader();

                        if (almacena.Read() == true)
                        {
                            if (almacena.GetString(0) == "1")
                            {
                                almacena.Close();
                                sql.Connection.Close();
                                return true;
                            }
                        }

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return false;
        }

        /*Se tendrian que recorrer un par de iteraciones el consultarpermisos() en donde ahi se ver que permisos como tal tiene el usuario e ir habilitando los botones como tal
         
          
         for each(hasta 5){
        int tipoPermiso=1;
         consultarPermisos(string idUsuario, string idAplicacion, int tipoPermiso)
        tipoPermiso=+1;
        
        } 

        /*************************************************************************************************************************************************************/

        //###############INICIA CÓDIGO PARA BOTON ELIMINAR ALYSON RODRÍGUEZ 
        public OdbcDataAdapter proeliminarmodulo(string sIdModulo, string sNombre, string sDescripcion, string sEstado)
        {
            Console.WriteLine("ESTO SE INGRESA EN LA SENTENCIA: " + sIdModulo + ", " + sNombre + ", " + sDescripcion + ", " + sEstado);
            try
            {
                using (OdbcConnection connection = cn.conectar())
                {
                    string sqlBorrarModulo = "UPDATE tbl_modulos SET nombre_modulo = ?, descripcion_modulo = ?, estado_modulo = '0' WHERE PK_id_modulos = ?";

                    using (OdbcCommand command = new OdbcCommand(sqlBorrarModulo, connection))
                    {
                        // Agregar parámetros al comando
                        command.Parameters.AddWithValue("?", sNombre);
                        command.Parameters.AddWithValue("?", sDescripcion);
                        command.Parameters.AddWithValue("?", sIdModulo);

                        // Crear un OdbcDataAdapter para ejecutar el comando de actualización
                        OdbcDataAdapter adapter = new OdbcDataAdapter();
                        adapter.UpdateCommand = command;

                        // Ejecutar el comando de actualización
                        adapter.UpdateCommand.ExecuteNonQuery();

                        // Registrar la acción en la bitácora
                        funInsertarBitacora(idUsuario, "Eliminó un módulo: " + sIdModulo + " - " + sNombre, "tbl_modulos", "1000");

                        return adapter; // Aunque no se usa típicamente así, se retorna el adaptador
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al realizar el borrado lógico del módulo: " + ex.Message);
                return null;
            }
        }
        //########################FINALIZA CÓDIGO BOTÓN ELIMINAR ALYSON RODRIGUEZ


        /*******************Ismar Leonel Cortez Sanchez  -0901-21-560*******************************************************/
        /****************************Combo box inteligente******************************************************************/


        public string[] funLlenarCmb(string sTabla, string sCampo1, string sCampo2)
        {
            conexion cn = new conexion();
            string[] sCampos = new string[300];
            int iI = 0;

            string sql = "SELECT DISTINCT " + sCampo1 + "," + sCampo2 + " FROM " + sTabla;

            /* La sentencia consulta el modelo de la base de datos con cada campo */
            try
            {
                // Muestra la consulta SQL antes de ejecutarla
                Console.Write(sql);
                MessageBox.Show(sql);

                OdbcCommand command = new OdbcCommand(sql, cn.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sCampos[iI] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    iI++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError en asignarCombo, revise los parámetros \n -" + sTabla + "\n -" + sCampo1);
            }

            return sCampos;
        }


        public DataTable Obtener(string sTabla, string sCampo1, string sCampo2)
        {
            conexion cn = new conexion();
            string sql = "SELECT DISTINCT " + sCampo1 + "," + sCampo2 + " FROM " + sTabla;

            OdbcCommand command = new OdbcCommand(sql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }
        /****************************************************************************************************************/

        /*******************Ismar Leonel Cortez Sanchez  -0901-21-560*******************************************************/
        /****************************Combo box inteligente 2******************************************************************/


        public string[] funLlenarCmb2(string sTabla, string sCampo1, string sCampo2)
        {
            conexion cn = new conexion();
            string[] sCampos = new string[300];
            int iI = 0;

            string sql = "SELECT DISTINCT " + sCampo1 + "," + sCampo2 + " FROM " + sTabla;

            /* La sentencia consulta el modelo de la base de datos con cada campo */
            try
            {
                // Muestra la consulta SQL antes de ejecutarla
                Console.Write(sql);
                MessageBox.Show(sql);

                OdbcCommand command = new OdbcCommand(sql, cn.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sCampos[iI] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    iI++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError en asignarCombo, revise los parámetros \n -" + sTabla + "\n -" + sCampo1);
            }

            return sCampos;
        }


        public DataTable obtener2(string sTabla, string sCampo1, string sCampo2)
        {
            conexion cn = new conexion();
            string sql = "SELECT DISTINCT " + sCampo1 + "," + sCampo2 + " FROM " + sTabla;

            OdbcCommand command = new OdbcCommand(sql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }
        /****************************************************************************************************************/
        //******************************************KATERYN DE LEON***************************
        //BUSCAR
        public OdbcDataAdapter funConsultarAsignacion_moduloAplicaciones()
        {
            cn.conectar();
            string ssqlUsuarios = " SELECT  a.Fk_id_modulos AS ModuloID,   m.nombre_modulo AS NombreModulo, a.Fk_id_aplicacion AS AplicacionID,  ap.nombre_aplicacion AS NombreAplicacion  FROM Tbl_asignacion_modulo_aplicacion a  JOIN Tbl_modulos m ON a.Fk_id_modulos = m.Pk_id_modulos JOIN Tbl_aplicaciones ap ON a.Fk_id_aplicacion = ap.Pk_id_aplicacion";
            OdbcDataAdapter dataUsuarios = new OdbcDataAdapter(ssqlUsuarios, cn.conectar());
            funInsertarBitacora(idUsuario, "Realizo una consulta  a Asignacion modulo aplicaciones", "tbl_asignacion_modulo_aplicacion", "1101");
            return dataUsuarios;

        }

        //*************************************KATERYN DE LEON*********************************************************
        // AGREGAR
        public int funObtenerIdModulo(string sNombreModulo)
        {
            using (OdbcConnection connection = cn.conectar())
            {
                if (connection == null) return -1;

                try
                {
                    string query = "SELECT Pk_id_modulos FROM Tbl_modulos WHERE nombre_modulo = ?";
                    using (OdbcCommand command = new OdbcCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre_modulo", sNombreModulo);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            // Si no existe, inserta el módulo
                            string insertQuery = "INSERT INTO Tbl_modulos (nombre_modulo, descripcion_modulo) VALUES (?, ?)";
                            using (OdbcCommand insertCommand = new OdbcCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@nombre_modulo", sNombreModulo);
                                insertCommand.Parameters.AddWithValue("@descripcion_modulo", "Descripción del módulo"); // Ajusta según sea necesario
                                insertCommand.ExecuteNonQuery();
                            }

                            // Obtener el ID del nuevo módulo
                            string idQuery = "SELECT LAST_INSERT_ID()";
                            using (OdbcCommand idCommand = new OdbcCommand(idQuery, connection))
                            {
                                return Convert.ToInt32(idCommand.ExecuteScalar());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener o insertar módulo: " + ex.Message);
                    return -1;
                }
            }
        }
        //********************************************KATERYN DE LEON*********************************************************
        // AGREGAR
        public int funObtenerIdAplicacion(string sNombreAplicacion)
        {
            using (OdbcConnection connection = cn.conectar())
            {
                if (connection == null) return -1;

                try
                {
                    string query = "SELECT Pk_id_aplicacion FROM Tbl_aplicaciones WHERE nombre_aplicacion = ?";
                    using (OdbcCommand command = new OdbcCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre_aplicacion", sNombreAplicacion);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            // Si no existe, inserta la aplicación
                            string insertQuery = "INSERT INTO Tbl_aplicaciones (nombre_aplicacion, descripcion_aplicacion) VALUES (?, ?)";
                            using (OdbcCommand insertCommand = new OdbcCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@nombre_aplicacion", sNombreAplicacion);
                                insertCommand.Parameters.AddWithValue("@descripcion_aplicacion", "Descripción de la aplicación"); // Ajusta según sea necesario
                                insertCommand.ExecuteNonQuery();
                            }

                            // Obtener el ID de la nueva aplicación
                            string idQuery = "SELECT LAST_INSERT_ID()";
                            using (OdbcCommand idCommand = new OdbcCommand(idQuery, connection))
                            {
                                return Convert.ToInt32(idCommand.ExecuteScalar());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener o insertar aplicación: " + ex.Message);
                    return -1;
                }
            }
        }
        //*************************************************KATERYN DE LEON*********************************************************
        // AGREGAR
        public bool funInsertarAsignacionModuloAplicacion(int sIdModulo, int sIdAplicacion)
        {
            using (OdbcConnection connection = cn.conectar())
            {
                if (connection == null) return false;

                try
                {
                    string query = "INSERT INTO Tbl_asignacion_modulo_aplicacion (Fk_id_modulos, Fk_id_aplicacion) VALUES (?, ?)";
                    using (OdbcCommand command = new OdbcCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Fk_id_modulos", sIdModulo);
                        command.Parameters.AddWithValue("@Fk_id_aplicacion", sIdAplicacion);

                        int resultado = command.ExecuteNonQuery();
                        funInsertarBitacora(idUsuario, "Realizo un ingreso a aplicacion-modulos", "tbl_asignacion_modulo_aplicacion", "1101");
                        return resultado > 0; // Devuelve true si la inserción fue exitosa


                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar asignación: " + ex.Message);
                    return false;
                }
            }
        }
        //***************************************************************************************************/

        //###################  empieza lo que hizo Karla  Sofia Gómez Tobar #######################
        // combo usuario y perfil

        public string[] funllenarCmbUsuario(string stabla, string scampo1, string scampo2)
        {
            conexion cn = new conexion();
            string[] sCampos = new string[300];
            int i = 0;

            string ssql = "SELECT DISTINCT " + scampo1 + "," + scampo2 + " FROM " + stabla;

            /* La sentencia consulta el modelo de la base de datos con cada campo */
            try
            {
                // Muestra la consulta SQL antes de ejecutarla
                Console.Write(ssql);
                MessageBox.Show(ssql);

                OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sCampos[i] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError en asignarCombo, revise los parámetros \n -" + stabla + "\n -" + scampo1);
            }

            return sCampos;
        }


        public DataTable funobtenerUsuario(string stabla, string scampo1, string scampo2)
        {
            conexion cn = new conexion();
            string ssql = "SELECT DISTINCT " + scampo1 + "," + scampo2 + " FROM " + stabla;

            OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }
        /****************************************************************************************************************/

        public string[] funllenarCmbPerfiles(string stabla, string scampo1, string scampo2)
        {
            conexion cn = new conexion();
            string[] sCampos = new string[300];
            int i = 0;

            string ssql = "SELECT DISTINCT " + scampo1 + "," + scampo2 + " FROM " + stabla;


            try
            {

                Console.Write(ssql);
                MessageBox.Show(ssql);

                OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sCampos[i] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError en asignarCombo, revise los parámetros \n -" + stabla + "\n -" + scampo1);
            }

            return sCampos;
        }


        public DataTable funobtenerPerfiles(string stabla, string scampo1, string scampo2)
        {
            conexion cn = new conexion();
            string sql = "SELECT DISTINCT " + scampo1 + "," + scampo2 + " FROM " + stabla;

            OdbcCommand command = new OdbcCommand(sql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }

        // ////////////////////////////////////////////////////////////////


        public string[] funllenarCboAsigUP(string stabla, string scampo1)
        {
            conexion cn = new conexion();
            string[] sCampos = new string[300];
            int i = 0;

            string ssql = "SELECT DISTINCT " + scampo1 + " FROM " + stabla;


            try
            {

                Console.Write(ssql);
                MessageBox.Show(ssql);

                OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sCampos[i] = reader.GetValue(0).ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError en asignarCombo, revise los parámetros \n -" + stabla + "\n -" + scampo1);
            }

            return sCampos;
        }


        public DataTable funobtenerAsigUP(string stabla, string scampo1)
        {
            conexion cn = new conexion();
            string ssql = "SELECT DISTINCT " + scampo1 + " FROM " + stabla;

            OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }
        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################

        //*********************************KEVIN LOPEZ*********************************************
        public OdbcDataAdapter funconsultaraplicacionesP(string snombreModulo)
        {
            cn.conectar();

            try
            {
                string sqlAplicaciones = @"
        SELECT a.Pk_id_aplicacion, a.nombre_aplicacion 
        FROM tbl_aplicaciones a
        JOIN tbl_asignacion_modulo_aplicacion ama ON a.pk_id_aplicacion = ama.fk_id_aplicacion
        JOIN tbl_modulos m ON m.pk_id_modulos = ama.fk_id_modulos
        WHERE m.nombre_modulo = ?";

                OdbcDataAdapter dataAplicaciones = new OdbcDataAdapter(sqlAplicaciones, cn.conectar());
                dataAplicaciones.SelectCommand.Parameters.AddWithValue("?", snombreModulo);

                // Registro de la bitacora
                funInsertarBitacora(idUsuario, "Realizó una consulta a aplicaciones", "tbl_aplicacion", "1000");

                return dataAplicaciones;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public OdbcDataAdapter proconsultarPerfiles()
        {
            cn.conectar();
            string sqlPerfiles = "SELECT nombre_perfil FROM Tbl_perfiles";
            funInsertarBitacora(idUsuario, "Realizo una consulta a perfiles", "Tbl_perfiles", "1000");
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sqlPerfiles, cn.conectar());
            return dataTable;
        }

        //*********************************FIN KEVIN LOPEZ*********************************************
        //---------------------------------Emerzon Garcia --------------------------------------------------
        public string obtenerNombrePerfil(string idPerfil)
        {
            try
            {
                string nombrePerfil = "";
                string consulta = "SELECT nombre_perfil FROM Tbl_perfiles WHERE Pk_id_perfil = '" + idPerfil + "'";
                OdbcCommand comando = new OdbcCommand(consulta, cn.conectar());
                OdbcDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    nombrePerfil = reader.GetString(0);
                }

                reader.Close();
                comando.Connection.Close();

                return nombrePerfil;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public OdbcDataAdapter proModificarPermisosPerfil(string scodigoperfil, string snombreaplicacion, string singresar, string smodificar, string seliminar, string sconsulta, string simprimir)
        {
            string sCodigoAplicacion = " ";
            string sCodigoPerfil = "";
            try
            {
                OdbcCommand sqlCodigoModulo = new OdbcCommand("SELECT Pk_id_aplicacion FROM Tbl_aplicaciones WHERE nombre_aplicacion = '" + snombreaplicacion + "' ", cn.conectar());
                OdbcDataReader almacena = sqlCodigoModulo.ExecuteReader();

                if (almacena.Read())
                {
                    sCodigoAplicacion = almacena.GetString(0);
                }

                OdbcCommand sqlCodigoPerfil = new OdbcCommand("SELECT Pk_id_perfil FROM Tbl_perfiles WHERE nombre_perfil = '" + scodigoperfil + "' ", cn.conectar());
                OdbcDataReader almacenaPerfil = sqlCodigoPerfil.ExecuteReader();
                // Para Pk_id_perfil
                if (almacenaPerfil.Read())
                {
                    sCodigoPerfil = almacenaPerfil.GetString(0);
                }

                string sqlModificarPermisosPerfilApp = "UPDATE Tbl_permisos_aplicacion_perfil SET guardar_permiso = '" + singresar + "', modificar_permiso = '" + smodificar +
                                                   "', eliminar_permiso = '" + seliminar + "', buscar_permiso = '" + sconsulta + "', imprimir_permiso = '" +
                                                   simprimir + "' WHERE Fk_id_perfil = '" + sCodigoPerfil + "' AND Fk_id_aplicacion = '" + sCodigoAplicacion + "';";

                OdbcDataAdapter dataPermisosPerfilAplicacion = new OdbcDataAdapter(sqlModificarPermisosPerfilApp, cn.conectar());

                funInsertarBitacora(idUsuario, "Modificó permiso: " + snombreaplicacion + " para perfil: " + scodigoperfil, "Tbl_permisos_aplicacion_perfil", "1000");

                almacena.Close();
                sqlCodigoModulo.Connection.Close();

                return dataPermisosPerfilAplicacion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public bool proEliminarPermisosPerfil(string sIdPerfil, string snombreaplicacion)
        {
            string sCodigoAplicacion = "";
            try
            {
                // Obtener ID de la aplicación basado en el nombre de la aplicación
                string sqlObtenerIdAplicacion = "SELECT Pk_id_aplicacion FROM Tbl_aplicaciones WHERE nombre_aplicacion = ?";
                using (OdbcCommand command = new OdbcCommand(sqlObtenerIdAplicacion, cn.conectar()))
                {
                    command.Parameters.AddWithValue("?", snombreaplicacion);
                    object idAplicacion = command.ExecuteScalar();
                    if (idAplicacion == null)
                    {
                        MessageBox.Show("No se encontró la aplicación con el nombre: " + snombreaplicacion);
                        return false;
                    }

                    // Generar la consulta SQL para eliminar registro en la base de datos
                    string sqlEliminarPermisos = "DELETE FROM Tbl_permisos_aplicacion_perfil WHERE Fk_id_perfil = ? AND Fk_id_aplicacion = ?";
                    using (OdbcCommand deleteCommand = new OdbcCommand(sqlEliminarPermisos, cn.conectar()))
                    {
                        deleteCommand.Parameters.AddWithValue("?", sIdPerfil);
                        deleteCommand.Parameters.AddWithValue("?", idAplicacion);

                        // Ejecutar el comando
                        int rowsAffected = deleteCommand.ExecuteNonQuery();
                        // Si se eliminó al menos un registro, registrar en la bitácora
                        if (rowsAffected > 0)
                        {
                            funInsertarBitacora(idUsuario, $"Eliminó el registro para perfil: {sIdPerfil} en aplicación: {snombreaplicacion}", "Tbl_permisos_aplicacion_perfil", "1000");
                            return true; // Indica que la eliminación fue exitosa
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron registros para eliminar.");
                            return false; // No se afectó ninguna fila
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar permisos: {ex.Message}");
                return false;
            }
        }

        //---------------------------------Emerzon Garcia Termina------------------------------------------------------------------------------------------
    }
}