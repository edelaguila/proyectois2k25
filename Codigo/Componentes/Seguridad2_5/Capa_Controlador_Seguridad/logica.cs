using System;
using System.Data;
using Capa_Modelo_Seguridad;
using System.Data.Odbc;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Capa_Controlador_Seguridad
{
    public class logica
    {

        sentencia sn;

        public logica(string idUsuario)
        {
            sn = new sentencia(idUsuario);
        }

        public logica() { }

        public DataTable funconsultaLogicaUsuariosAplicaciones()
        {

            try
            {
                OdbcDataAdapter dtUsuario = sn.funUsuariosAplicaciones();
                DataTable tableUsuario = new DataTable();
                dtUsuario.Fill(tableUsuario);
                return tableUsuario;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }

        public DataTable funconsultaLogicaUsuarios(string estado = "todos")
        {
            try
            {
                OdbcDataAdapter dtUsuario = sn.funUsuarios(estado);
                DataTable tableUsuario = new DataTable();
                dtUsuario.Fill(tableUsuario);
                return tableUsuario;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable Funmostraraplicaciones()
        {
            try
            {
                OdbcDataAdapter dtaplicaciones = sn.funmostraraplicaciones();
                DataTable tableaplicaciones = new DataTable();
                dtaplicaciones.Fill(tableaplicaciones);
                return tableaplicaciones;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }

        /*********Ismar Cortez***********************/
        /*********Mostrar modulos*******************/
        public DataTable Funmostrarmodulos()
        {
            try
            {
                OdbcDataAdapter dtmodulos = sn.funmodulos();
                DataTable tablemodulos = new DataTable();
                dtmodulos.Fill(tablemodulos);
                return tablemodulos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }
        /**********************************************/

        /***************Ismar Cortez************/
        /*************Mostrar perfiles***********/
        public DataTable Funmostrarperfiles()
        {
            try
            {
                OdbcDataAdapter dtaplicaciones = sn.funperfiles();
                DataTable tableaplicaciones = new DataTable();
                dtaplicaciones.Fill(tableaplicaciones);
                return tableaplicaciones;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }
        /**********************************************/

        /***************Ismar Cortez************/
        // Método que controla la lógica de consultar permisos
        public bool ConsultarPermisos(string idUsuario, string idAplicacion, int tipoPermiso)
        {
            sentencia sn = new sentencia();
            // Llamar a la función de la capa de datos y retornar el resultado
            bool tienePermiso = sn.funConsultarPermisos(idUsuario, idAplicacion, tipoPermiso);
            return tienePermiso;
        }

        /**********************************************/



        public DataTable funconsultalogicamodulos()
        {
            try
            {
                OdbcDataAdapter dtModulos = sn.funconsultarmodulos();
                DataTable tableModulos = new DataTable();
                dtModulos.Fill(tableModulos);
                return tableModulos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable funconsultalogicaperfiles()
        {
            try
            {
                OdbcDataAdapter dtPerfiles = sn.funconsultarperfiles();
                DataTable tablePerfiles = new DataTable();
                dtPerfiles.Fill(tablePerfiles);
                return tablePerfiles;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        public DataTable funconsultaLogicaAplicaciones(string sID_aplicacion)
        {
            try
            {
                using (OdbcDataAdapter cmpsAplicaciones = sn.proconsultaraplicaciones(sID_aplicacion)) //Cambio de referencia para fuuncionamiento de APlicaciones Usuarios
                {
                    DataTable tableAplicaciones = new DataTable();
                    cmpsAplicaciones.Fill(tableAplicaciones);
                    return tableAplicaciones;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;

            }

        }


        public DataTable funConsultaLogicaAplicaciones(string sID_aplicacion)
        {
            try
            {
                using (OdbcDataAdapter cmpsAplicaciones = sn.funconsultarAplicaciones(sID_aplicacion)) //Cambio de referencia para fuuncionamiento de APlicaciones Usuarios
                {
                    DataTable tableAplicaciones = new DataTable();
                    cmpsAplicaciones.Fill(tableAplicaciones);
                    return tableAplicaciones;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;

            }

        }

        public DataTable funconsultaLogicaPerfilesUsuarios()
        {
            try
            {
                OdbcDataAdapter dt = sn.funmostrarPerfilesDeUsuario();
                DataTable table = new DataTable();
                dt.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable funconsultaPerfilesUsuarios(string sID_apUsu)
        {
            try
            {
                OdbcDataAdapter dt = sn.funConsultarAsignaciones(sID_apUsu);
                DataTable table = new DataTable();
                dt.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public bool funconsultaLogicaInsertarPerfilUsuario(string scodigoUsuario, string scodigoPerfil)
        {
            try
            {
                sn.proinsertarPerfilUsuario(scodigoUsuario, scodigoPerfil);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el asignacion: " + ex.Message);
                return false;
            }
        }

        public bool funconsultaLogicaAtualizarPerfilUsuario(string scodigo, string nuevoUsuarioID, string nuevoPerfilID)
        {
            try
            {
                // Llamar al método de actualización en la capa de servicio o datos
                sn.funactualizarPerfilUsuario(scodigo, nuevoUsuarioID, nuevoPerfilID);
                return true;
            }
            catch (Exception ex)
            {
                // Manejar errores y registrar en la consola
                Console.WriteLine("Error al actualizar la asignación: " + ex.Message);
                return false;
            }
        }

        public bool funeliminarPerfilUsuario(string scodigo)
        {
            try
            {
                bool result = sn.funeliminarPerfilUsuario(scodigo);
                if (result)
                {
                    MessageBox.Show("asignacion eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la asignacion.");
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }



        public DataTable funvalidarIDAplicacion()
        {
            try
            {
                OdbcDataAdapter dtValidarIDAplicacion = sn.funvalidarIDAplicacion();
                DataTable tableValidacionIdAplicacion = new DataTable();
                dtValidarIDAplicacion.Fill(tableValidacionIdAplicacion);
                return tableValidacionIdAplicacion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public bool funinsertaraplicaciones(string scodigo, string snombre, string sdescripcion, string sestado)
        {
            try
            {

                sn.proinsertaraplicacion(scodigo, snombre, sdescripcion, sestado);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el aplicacion: " + ex.Message);
                return false;
            }
        }

        public bool funeliminaraplicaciones(string scodigo)
        {
            try
            {
                bool result = sn.funeliminaraplicacion(scodigo);
                if (result)
                {
                    MessageBox.Show("Perfil eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el perfil.");
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################

        //Trabajado María José Véliz
        //Se cambiaron de lugar los parámetros por la base de datos
        public DataTable funConsultaLogicaPermisosUsuarioAplicacion(string sCodigoUsuario, string sNombreAplicacion, string sIngresar, string sConsulta, string sModificar, string sEliminar, string sImprimir)
        {
            try
            {
                OdbcDataAdapter dtPermisosUA = sn.funInsertarPermisosUA(sCodigoUsuario, sNombreAplicacion, sIngresar, sConsulta, sModificar, sEliminar, sImprimir);
                DataTable tablePermisosUA = new DataTable();
                dtPermisosUA.Fill(tablePermisosUA);
                return tablePermisosUA;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //termina

        //Trabajado por ALyson Rodriguez 9959-21-829

        public DataTable funConsultaLogicaUsuarios(string sAplicacionUsuario)
        {

            // Llamar al método que retorna un DataTable
            DataTable table = new DataTable();
            OdbcDataAdapter dt = sn.funMostrarUsuariosYPermisos(sAplicacionUsuario); // Cambio en el nombre del método para reflejar permisos
            dt.Fill(table);
            return table;
        }
        //Finaliza


        //---------------------------------------------------- Inicio: GABRIELA SUC ---------------------------------------------------- 

        public bool ModificarUsuario(string Id_Usuario, string nombre, string apellido, string correo, int estado_usuario, string pregunta, string respuesta)
        {
            return sn.funModificarUsuario(Id_Usuario, nombre, apellido, correo, estado_usuario, pregunta, respuesta);
        }

        //---------------------------------------------------- Fin: GABRIELA SUC ---------------------------------------------------- 
        /* creado por Emerzon Garcia  0901-21-9182 ...... */

        public bool funeliminarperfil(string sID_perfil)
        {
            try
            {
                bool result = sn.funEliminarPerfil1(sID_perfil);
                if (result)
                {
                    MessageBox.Show("Perfil eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el perfil.");
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        /*----------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        // cambiado ingresar datos
        //Kateryn de leon
        public DataTable usuarios(string nombre, string apellido, string id, string clave, string correo, string fecha, string estadousuario, string pregunta, string respuesta)//int boton
        {
            try
            {
                OdbcDataAdapter dtusuario = sn.funInsertarusuario(nombre, apellido, id, clave, correo, fecha, estadousuario, pregunta, respuesta);//boton
                DataTable tableusuarios = new DataTable();
                dtusuario.Fill(tableusuarios);
                return tableusuarios;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //ACA 

        public DataTable clave(string id, string nombre, string apellido, string clave)
        {
            try
            {
                OdbcDataAdapter dtusuario = sn.insertarclaves(id, nombre, apellido, clave);
                DataTable tableusuarios = new DataTable();
                dtusuario.Fill(tableusuarios);
                return tableusuarios;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable updateclave(string usuario)
        {
            try
            {
                OdbcDataAdapter dtusuario = sn.update(usuario);
                DataTable tableusuarios = new DataTable();
                dtusuario.Fill(tableusuarios);
                return tableusuarios;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable updatecliente(string clave, string usuario)
        {
            try
            {
                OdbcDataAdapter dtusuario = sn.clienteupdate(clave, usuario);
                DataTable tableusuarios = new DataTable();
                dtusuario.Fill(tableusuarios);
                return tableusuarios;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }



        //---------------------------------------------------- Inicio: GABRIELA SUC ---------------------------------------------------- 

        // Método para eliminar (inactivar) un usuario
        public bool EliminarUsuario(string LlaveUsuario)
        {
            // Llama al método de la capa de datos para actualizar el estado
            return sn.funCambiarEstadoUsuario(LlaveUsuario, 0);
        }

        //---------------------------------------------------- Fin: GABRIELA SUC ---------------------------------------------------- 

        //Esta parte fue echa por Carlos Hernandez
        public DataTable funactualizaraplicaciones(string scodigo, string snombre, string sdescripcion, string sestado)
        {
            try
            {
                OdbcDataAdapter dtModificar = sn.funactualizaraplicacion(scodigo, snombre, sdescripcion, sestado);
                DataTable tableAplicacion = new DataTable();
                dtModificar.Fill(tableAplicacion);
                return tableAplicacion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //termina lo que hizo carlos hernandez 



        //BUSCARRRRRR
        //kateryn de leon
        public DataTable buscar(string id)
        {
            try
            {

                OdbcDataAdapter dtusuario = sn.funMostrar(id);
                DataTable tableusuarios = new DataTable();
                dtusuario.Fill(tableusuarios);
                if (tableusuarios == null)
                    return null;
                else
                    return tableusuarios;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable buscaraplicacion(string id)
        {
            try
            {

                OdbcDataAdapter dtusuario = sn.funMostraraplicacion(id);
                DataTable tableusuarios = new DataTable();
                dtusuario.Fill(tableusuarios);
                if (tableusuarios == null)
                    return null;
                else
                    return tableusuarios;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        public DataTable funvalidaridmodulos()
        {
            try
            {
                OdbcDataAdapter dtValidarIDModulo = sn.funvalidaridmodulos();
                DataTable tableValidacionIdModulo = new DataTable();
                dtValidarIDModulo.Fill(tableValidacionIdModulo);
                return tableValidacionIdModulo;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        // termina


        //--------mantenimiento perfiles

        //+1
        public DataTable funagregar()
        {
            try
            {
                OdbcDataAdapter dtValidarIDAplicacion = sn.funagregarperfil();
                DataTable tableValidacionIdAplicacion = new DataTable();
                dtValidarIDAplicacion.Fill(tableValidacionIdAplicacion);
                return tableValidacionIdAplicacion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public DataTable funingresarperfiles(string scodigo, string snombre, string sdescripcion, string sestado)
        {
            try
            {
                OdbcDataAdapter ingresoperfil = sn.proinsertarperfil(scodigo, snombre, sdescripcion, sestado);
                DataTable tableperfiles = new DataTable();
                ingresoperfil.Fill(tableperfiles);
                return tableperfiles;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable funconsultarperfil(string sID_perfil)
        {
            try
            {
                OdbcDataAdapter cmpsperfiles = sn.proconsultar(sID_perfil);
                DataTable tablaperfiles = new DataTable();
                cmpsperfiles.Fill(tablaperfiles);
                return tablaperfiles;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public DataTable funactualizar(string sID_perfil, string snombre, string sdescripcion, string sestado)
        {
            try
            {
                OdbcDataAdapter dtperfil = sn.funactualizarperfil(sID_perfil, snombre, sdescripcion, sestado);
                DataTable tablaperfiles = new DataTable();
                dtperfil.Fill(tablaperfiles);
                return tablaperfiles;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }


        }


        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        public bool funingresarmodulo(string sCodigo, string sNombre, string sDescripcion, string sEstado)
        {
            try
            {
                // Ejecutar la inserción
                sn.proinsertarmodulo(sCodigo, sNombre, sDescripcion, sEstado);
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al insertar el módulo: " + ex.Message);
                return false;
            }
        } // termina



        //*****************************MODIFICADO POR JOSUÉ PAZ*******************************************************
        public DataTable funguardarpermisosperfil(string scodigoPerfil, string snombreAplicacion, string singresar, string smodificar, string seliminar, string sconsulta, string simprimir)
        {
            try
            {
                OdbcDataAdapter dtPermisosPerfilA = sn.proinsertarpermisosperfil(scodigoPerfil, snombreAplicacion, singresar, smodificar, seliminar, sconsulta, simprimir);
                DataTable tablePermisosPerfilA = new DataTable();
                dtPermisosPerfilA.Fill(tablePermisosPerfilA);
                return tablePermisosPerfilA;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //*****************************ACA TERMINA********************************************************************


        //-----------------------Emerzon Garcia --------------------------------------------------
        public DataTable funconsultarPerfiles(string sTablaPerfilUsuario)
        {
            DataTable table = new DataTable();
            OdbcDataAdapter dt = sn.funmostrarperfilesypermisos(sTablaPerfilUsuario);
            dt.Fill(table);

            // Convertir los valores booleanos a string "0" o "1"
            foreach (DataRow row in table.Rows)
            {
                row["guardar_permiso"] = (Convert.ToBoolean(row["guardar_permiso"]) ? "1" : "0");
                row["buscar_permiso"] = (Convert.ToBoolean(row["buscar_permiso"]) ? "1" : "0");
                row["modificar_permiso"] = (Convert.ToBoolean(row["modificar_permiso"]) ? "1" : "0");
                row["eliminar_permiso"] = (Convert.ToBoolean(row["eliminar_permiso"]) ? "1" : "0");
                row["imprimir_permiso"] = (Convert.ToBoolean(row["imprimir_permiso"]) ? "1" : "0");
            }

            return table;
        }

        //----------------------------------------------------------------------------------------

        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        public DataTable funconsultalogicamodulo(string sIdModulo)
        {
            try
            {
                using (OdbcDataAdapter cmpsModulos = sn.proconsultarmodulos(sIdModulo))
                {
                    DataTable tablaModulos = new DataTable();
                    cmpsModulos.Fill(tablaModulos);
                    return tablaModulos;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return null;
            }
        }
        // termina

        //María José Véliz Ochoa, 9959-21-5909
        //ACTUALIZAR PERMISOS USUARIOS
        public DataTable funactualizarpermisos(string sCodigoUsuario, string sNombreAplicacion, string sIngresar, string sConsulta, string sModificar, string sEliminar, string sImprimir)
        {
            try
            {
                OdbcDataAdapter dtPermisosUA = sn.proactualizarpermisosUA(sCodigoUsuario, sNombreAplicacion, sIngresar, sConsulta, sModificar, sEliminar, sImprimir);
                DataTable tablePermisosUA = new DataTable();
                dtPermisosUA.Fill(tablePermisosUA);
                return tablePermisosUA;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        //María José Véliz Ochoa, 9959-21-5909

        public DataTable funEliminarRegistroUA(string sCodigoUsuario, string sNombreAplicacion)
        {
            try
            {
                OdbcDataAdapter dtPermisosUA = sn.proEliminarRegistroUA(sCodigoUsuario, sNombreAplicacion);
                DataTable tablePermisosUA = new DataTable();
                dtPermisosUA.Fill(tablePermisosUA);
                return tablePermisosUA;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }//termina





        // Alyson Rodríguez 9959-21-829
        public DataTable funactualizarmodulo(string sIdModulo, string sNombre, string sDescripcion, string sEstado)
        {
            try
            {
                OdbcDataAdapter dtmodulo = sn.proactualizarmodulo(sIdModulo, sNombre, sDescripcion, sEstado);
                DataTable tablamodulos = new DataTable();
                dtmodulo.Fill(tablamodulos);
                return tablamodulos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        // Fernando García - 0901-21-581 
        public DataSet consultaLogicaBitacora()
        {
            return sn.funConsultarBitacora();
        }

        // Nuevo método para la búsqueda filtrada de bitácora
        public DataSet consultaLogicaBitacoraFiltrada(string campo, string valor)
        {
            return sn.funConsultarBitacoraFiltrada(campo, valor);
        }
        //FIN ###########

        //ELIMINAR MODULO ALYSON ##########################################
        public DataTable funeliminarmodulo(string sIdModulo, string sNombre, string sDescripcion, string sEstado)
        {
            try
            {
                OdbcDataAdapter dtmodulo = sn.proeliminarmodulo(sIdModulo, sNombre, sDescripcion, sEstado);
                DataTable tablamodulos = new DataTable();
                dtmodulo.Fill(tablamodulos);
                return tablamodulos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //FIN ####################################################################


        /*********************Ismar Leonel Cortez Sanchez -0901-21-560************/
        /***********************Combo box inteligente*****************************/

        public string[] items(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.funLlenarCmb(tabla, campo1, campo2);
            /*Este arreglo lo obtiene y retorna de la clase senencias del modelo*/
            return Items;

            /*Aqui viene a parar lo de sentencias*/


        }

        public DataTable enviar(string tabla, string campo1, string campo2)
        {



            var dt1 = sn.obtener2(tabla, campo1, campo2);

            return dt1;
        }
        /**************************************************************************/

        /*********************Ismar Leonel Cortez Sanchez -0901-21-560************/
        /***********************Combo box inteligente 2*****************************/

        public string[] items2(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.funLlenarCmb2(tabla, campo1, campo2);
            /*Este arreglo lo obtiene y retorna de la clase senencias del modelo*/
            return Items;

            /*Aqui viene a parar lo de sentencias*/


        }

        public DataTable enviar2(string tabla, string campo1, string campo2)
        {


            /**/
            var dt1 = sn.obtener2(tabla, campo1, campo2);

            return dt1;
        }
        /**************************************************************************/

        /**************************************************************************/

        //*************KaterynDeLeon*************************
        //buscar
        public DataTable consultaLogicaAsigncacionModuloAplicaciones()
        {
            try
            {
                OdbcDataAdapter dtModulos = sn.funConsultarAsignacion_moduloAplicaciones();
                DataTable tableModulosApli = new DataTable();
                dtModulos.Fill(tableModulosApli);
                return tableModulosApli;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //*************************************************************************************/
        //*************KaterynDeLeon************************
        // Inicio ( crear)

        public int ObtenerOInsertarModulo(string nombreModulo)
        {
            return sn.funObtenerIdModulo(nombreModulo);
        }

        public int ObtenerOInsertarAplicacion(string nombreAplicacion)
        {
            return sn.funObtenerIdAplicacion(nombreAplicacion);
        }

        public bool InsertarLogicaAsignacionModuloAplicacion(int idModulo, int idAplicacion)
        {
            return sn.funInsertarAsignacionModuloAplicacion(idModulo, idAplicacion);
        }

        //*****************Fin********************************************************************



        //###################  empieza lo que hizo Karla  Sofia Gómez Tobar #######################
        // combo usuario y perfil 
        public string[] funitemsUsuario(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.funllenarCmbUsuario(tabla, campo1, campo2);

            return Items;




        }

        public DataTable funenviarUsuario(string tabla, string campo1, string campo2)
        {

            var dt1 = sn.funobtenerUsuario(tabla, campo1, campo2);

            return dt1;
        }

        public string[] funitemsPerfiles(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.funllenarCmbPerfiles(tabla, campo1, campo2);

            return Items;




        }

        public DataTable funenviarPerfiles(string tabla, string campo1, string campo2)
        {



            var dt1 = sn.funobtenerPerfiles(tabla, campo1, campo2);

            return dt1;
        }


        public string[] funitemsAsigUP(string tabla, string campo1)
        {
            string[] Items = sn.funllenarCboAsigUP(tabla, campo1);

            return Items;




        }

        public DataTable funenviarAsigUP(string tabla, string campo1)
        {


            /**/
            var dt1 = sn.funobtenerAsigUP(tabla, campo1);

            return dt1;
        }
        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################

        //********************************KEVIN LOPEZ*************************************************
        public DataTable funconsultaLogicaaplicacionesP(string snombreModulo)
        {
            try
            {
                using (OdbcDataAdapter cmpsAplicaciones = sn.funconsultaraplicacionesP(snombreModulo)) //Cambio de referencia para fuuncionamiento de APlicaciones Usuarios
                {
                    DataTable tableAplicaciones = new DataTable();
                    cmpsAplicaciones.Fill(tableAplicaciones);
                    return tableAplicaciones;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;

            }
        }
        //********************************FIN KEVIN LOPEZ*************************************************


        public bool funinsertarabitacora(string idUsuario, string sAccion, string sTabla, string sIdAplicacion)
        {
            try
            {
                sentencia sn = new sentencia();
                sn.funInsertarBitacora(idUsuario, sAccion, sTabla, sIdAplicacion);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el aplicacion: " + ex.Message);
                return false;
            }
        }

        //********************************KEVIN LOPEZ*************************************************
        public DataTable funconsultaLogPerfiles()
        {
            try
            {
                OdbcDataAdapter dtPerfiles = sn.proconsultarPerfiles();
                DataTable tablePerfiles = new DataTable();
                dtPerfiles.Fill(tablePerfiles);
                return tablePerfiles;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }

        //********************************FIN KEVIN LOPEZ*************************************************

        //-----------------------Emerzon Garcia --------------------------------------------------
        public string obtenerNombrePerfil(string idPerfil)
        {
            try
            {
                return sn.obtenerNombrePerfil(idPerfil); // Llamada al método en la capa de sentencias
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable funModificarPermisosPerfil(string scodigoPerfil, string snombreAplicacion, string singresar, string smodificar, string seliminar, string sconsulta, string simprimir)
        {
            try
            {
                OdbcDataAdapter dtPermisosPerfilM = sn.proModificarPermisosPerfil(scodigoPerfil, snombreAplicacion, singresar, smodificar, seliminar, sconsulta, simprimir);
                DataTable tablePermisosPerfilM = new DataTable();
                dtPermisosPerfilM.Fill(tablePermisosPerfilM);
                return tablePermisosPerfilM;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public bool funEliminarPermisosPerfil(string sIdPerfil, string snombreAplicacion)
        {
            try
            {
                bool result = sn.proEliminarPermisosPerfil(sIdPerfil, snombreAplicacion);
                if (result)
                {
                    MessageBox.Show("Registro(s) eliminado(s) correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro.");
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }


    }
}