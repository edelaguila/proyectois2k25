using System;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Seguridad;


namespace Capa_Controlador_Seguridad
{
    public class ProcedimientoLogin
    {
        sentencia sn;
        //Fernando García - 0901-21-581
        public bool llamarProcedimiento(string usuario, string clave)
        {
            try
            {
                conexion con = new conexion();
                using (OdbcCommand cmd = new OdbcCommand("CALL procedimientoLogin(?, ?)", con.conectar()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@usuario", OdbcType.VarChar).Value = usuario;
                    cmd.Parameters.Add("@clave", OdbcType.VarChar).Value = clave;

                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string resultado = reader.GetString(0);
                            return resultado == "Inicio de sesión exitoso";
                        }
                    }
                }

                return false;
            }
            catch (OdbcException ex)
            {

                Console.WriteLine(ex);
                return false;

            }

        }/////////////////////////////////////////////////////////////////////////////////////////////////////

        // Procedimientos siguientes por Brandon Boch 0901-21-13093------------------------------------
        public bool cambioContrasenia(string usuario)
        {
            try
            {
                conexion con = new conexion();
                using (OdbcCommand cmd = new OdbcCommand("CALL cambioContrasenia(?)", con.conectar()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@usuario", OdbcType.VarChar).Value = usuario;

                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string resu = reader.GetString(0);
                            return resu == "Usuario encontrado";
                        }
                    }
                }
                sn.funInsertarBitacora(usuario, "Se cambio contraseña ", "tbl_usuarios", "1201");

                return false;
            }
            catch (OdbcException ex)
            {

                Console.WriteLine(ex);
                return false;

            }

        }

        public bool cambiarContrasenia(string usuario, string nuevaContrasenia, string respuestaSeguridad)
        {
            try
            {
                conexion con = new conexion();
                bool contraseniaActualizada = false;
                string resultado = "";

                using (OdbcCommand cmd = new OdbcCommand("CALL cambiarContrasenia(?, ?, ?)", con.conectar()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Los parámetros se agregan en el mismo orden que en el SP
                    cmd.Parameters.Add(new OdbcParameter("@usuario", OdbcType.VarChar)).Value = usuario;
                    cmd.Parameters.Add(new OdbcParameter("@nuevaContrasenia", OdbcType.VarChar)).Value = nuevaContrasenia;
                    cmd.Parameters.Add(new OdbcParameter("@respuestaSeguridad", OdbcType.VarChar)).Value = respuestaSeguridad;

                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            resultado = reader.GetString(0);
                            contraseniaActualizada = (resultado == "Contraseña actualizada con éxito");
                        }
                    }
                }

                if (contraseniaActualizada)
                {
                    // Inicializamos sn aquí si no se ha hecho en el constructor
                    if (sn == null)
                    {
                        sn = new sentencia();
                    }

                    // Insertamos en la bitácora solo si la contraseña fue actualizada
                    sn.funInsertarBitacora(usuario, "Se cambió contraseña la contraseña de: " + usuario, "tbl_usuarios", "1201");
                }

                return contraseniaActualizada;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en cambiarContrasenia: {ex.Message}");
                return false;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////

        public bool cambiarContraModulo(int usuario, string nuevaContrasenia)
        {
            try
            {
                conexion con = new conexion();
                using (OdbcCommand cmd = new OdbcCommand("CALL cambiarContraModulo(?, ?)", con.conectar()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Los parámetros se agregan en el mismo orden en que aparecen en el SP
                    cmd.Parameters.Add(new OdbcParameter("@usuario", OdbcType.Int)).Value = usuario;
                    cmd.Parameters.Add(new OdbcParameter("@nuevaContrasenia", OdbcType.VarChar)).Value = nuevaContrasenia;

                    Console.WriteLine($"ID Usuario: {usuario}, Nueva Contraseña: {nuevaContrasenia}");

                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string resultado = reader.GetString(0);
                            // Depuración: Verificar el resultado devuelto por el SP
                            Console.WriteLine($"Resultado del SP: {resultado}");

                            // Comparar el resultado con el mensaje del SP
                            return resultado == "Contraseña actualizada con éxito";
                        }
                    }
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine(ex);
                return false;
            }

            return false;
        }
        //////////////////////////// Fin de código por Brandon Boch 0901-21-13093 //////////////////////
    }
        
}