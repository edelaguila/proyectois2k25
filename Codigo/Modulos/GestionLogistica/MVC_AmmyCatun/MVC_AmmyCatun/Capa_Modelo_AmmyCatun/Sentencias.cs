using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;
using Capa_Modelo_AmmyCatun;
using CrystalDecisions.CrystalReports.ViewerObjectModel;

namespace Capa_Modelo_AmmyCatun
{

    public class Sentencias
    {
        private string sTabla_datos_pedido = "Tbl_datos_pedido";
        private string sTabla_Vehiculos = "Tbl_vehiculos";
        private Conexion cn = new Conexion();

        // Método para Registrar-Ingresar Pedidos Realizado por Ammy Patricia Catun Lopez 0901-21-4857
        public void registrarPedido(DateTime dFechaEmision, DateTime dFechaTraslado, string sDireccionPartida, string sDireccionLlegada, string sNumeroOrdenRecojo, string sFormaPago, string sDestino, int iIdRemitente, int iIdDestinatario, int iIdvehiculo)
        {
            try
            {
                string sSql = "INSERT INTO " + sTabla_datos_pedido + " (fechaEmision, fechaTraslado, direccionPartida, direccionLlegada, numeroOrdenRecojo, formaPago, destino, fk_id_Remitente, fk_id_Destinatario, fk_id_vehiculo) " +
                              "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?);";

                using (OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion()))
                {
                    cmd.Parameters.AddWithValue("@fechaEmision", dFechaEmision);
                    cmd.Parameters.AddWithValue("@fechaTraslado", dFechaTraslado);
                    cmd.Parameters.AddWithValue("@direccionPartida", sDireccionPartida);
                    cmd.Parameters.AddWithValue("@direccionLlegada", sDireccionLlegada);
                    cmd.Parameters.AddWithValue("@numeroOrdenRecojo", sNumeroOrdenRecojo);
                    cmd.Parameters.AddWithValue("@formaPago", sFormaPago);
                    cmd.Parameters.AddWithValue("@destino", sDestino);
                    cmd.Parameters.AddWithValue("@fk_id_Remitente", iIdRemitente);
                    cmd.Parameters.AddWithValue("@fk_id_Destinatario", iIdDestinatario);
                    cmd.Parameters.AddWithValue("@fk_id_vehiculo", iIdvehiculo);

                    int iIngreso = cmd.ExecuteNonQuery();
                    MessageBox.Show(iIngreso > 0 ? "Pedido registrado correctamente." : "No se pudo registrar el pedido.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nNo se pudo guardar el registro en la tabla Tbl_datos_pedido.");
            }
        }

        public int getMaxIdPedido()
        {
            int iIdRegistro = 0;
            string sSql = "SELECT max(Pk_id_guia) FROM Tbl_datos_pedido ;";
            try
            {
                using (OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion()))
                {
                    iIdRegistro = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nNo se pudo obtener el id del registro en la tabla Tbl_pedidos.");
            }
            return iIdRegistro;
        }
        public DataTable cargarPedidos()
        {
            DataTable dtPedidos = new DataTable();
            string sSql = "SELECT * FROM Tbl_datos_pedido";

            try
            {
                using (OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion()))
                {
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(dtPedidos);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nNo se pudo obtener los datos de la tabla Tbl_datos_pedido.");
            }

            return dtPedidos;
        }

        // Método para Modifcar Pedidos Realizado por Ammy Patricia Catun Lopez 0901-21-4857
        public void modificarPedido(int iIdGuia, DateTime dFechaEmision, DateTime dFechaTraslado, string sDireccionPartida, string sDireccionLlegada, string sNumeroOrdenRecojo, string sFormaPago, string sDestino, int iIdRemitente, int iIdDestinatario, int iIdVehiculo)
        {
            try
            {
                string sSql = "UPDATE Tbl_datos_pedido SET fechaEmision = ?, fechaTraslado = ?, direccionPartida = ?, direccionLlegada = ?, numeroOrdenRecojo = ?, formaPago = ?, destino = ?, Fk_id_remitente = ?, Fk_id_destinatario = ?, Fk_id_vehiculo = ? WHERE Pk_id_guia = ?;";

                using (OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion()))
                {
                    cmd.Parameters.AddWithValue("@fechaEmision", dFechaEmision.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@fechaTraslado", dFechaTraslado.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@direccionPartida", sDireccionPartida);
                    cmd.Parameters.AddWithValue("@direccionLlegada", sDireccionLlegada);
                    cmd.Parameters.AddWithValue("@numeroOrdenRecojo", sNumeroOrdenRecojo);
                    cmd.Parameters.AddWithValue("@formaPago", sFormaPago);
                    cmd.Parameters.AddWithValue("@destino", sDestino);
                    cmd.Parameters.AddWithValue("@Fk_id_remitente", iIdRemitente);
                    cmd.Parameters.AddWithValue("@Fk_id_destinatario", iIdDestinatario);
                    cmd.Parameters.AddWithValue("@Fk_id_vehiculo", iIdVehiculo);
                    cmd.Parameters.AddWithValue("@Pk_id_guia", iIdGuia);

                    int iresultado = cmd.ExecuteNonQuery();
                    MessageBox.Show(iresultado > 0 ? "Pedido modificado correctamente." : "No se encontró el pedido para modificar.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nNo se pudo modificar el registro en la tabla Tbl_datos_pedido.");
            }

        }
        // Método para Registrar-Ingresar Vehiculos Realizado por Ammy Patricia Catun Lopez 0901-21-4857
        public void registrarVehiculo(string sNumeroPlaca, string sMarca, string sColor, string sDescripcion, string sHoraLlegada, string sHoraSalida, double doPesoTotal, int iIdChofer)
        {
            try
            {
                string sSql = "INSERT INTO " + sTabla_Vehiculos + "(numeroPlaca, marca, color, descripcion, horaLlegada, horaSalida, pesoTotal, Fk_id_chofer)" +
                              "VALUES (?, ?, ?, ?, ?, ?, ?, ?);";

                using (OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion()))
                {
                    cmd.Parameters.AddWithValue("@numeroPlaca", sNumeroPlaca);
                    cmd.Parameters.AddWithValue("@marca", sMarca);
                    cmd.Parameters.AddWithValue("@color", sColor);
                    cmd.Parameters.AddWithValue("@descripcion", sDescripcion);
                    cmd.Parameters.AddWithValue("@horaLlegada", sHoraLlegada);
                    cmd.Parameters.AddWithValue("@horaSalida", sHoraSalida);
                    cmd.Parameters.AddWithValue("@pesoTotal", doPesoTotal);
                    cmd.Parameters.AddWithValue("@Fk_id_chofer", iIdChofer);


                    int iIngreso = cmd.ExecuteNonQuery();
                    MessageBox.Show(iIngreso > 0 ? "Vehículo registrado correctamente." : "No se pudo registrar el vehículo.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nNo se pudo guardar el registro en la tabla Tbl_vehiculos.");
            }
        }
        public int getMaxIdVehiculo()
        {
            int iIdRegistro = 0;
            string sSql = "SELECT max(Pk_id_vehiculo) FROM " + sTabla_Vehiculos + ";";
            try
            {
                using (OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion()))
                {
                    iIdRegistro = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nNo se pudo obtener el id del registro en la tabla " + sTabla_Vehiculos);
            }
            return iIdRegistro;
        }


        public DataTable cargarVehiculos()
        {
            DataTable dtVehiculos = new DataTable();
            string sSql = "SELECT * FROM Tbl_vehiculos";

            try
            {
                using (OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion()))
                {
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(dtVehiculos);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nNo se pudo obtener los datos de la tabla Tbl_vehiculos.");
            }

            return dtVehiculos;
        }
        // Método para Modificar Vehiculos Realizado por Ammy Patricia Catun Lopez 0901-21-4857
        public void modificarVehiculo(int iIdVehiculo, string sNumeroPlaca, string sMarca, string sColor, string sDescripcion, string sHoraLlegada, string sHoraSalida, double doPesoTotal, int iIdChofer)
        {
            try
            {
                string sSql = "UPDATE Tbl_vehiculos SET numeroPlaca = ?, marca = ?, color = ?, descripcion = ?, horaLlegada = ?, horaSalida = ?, pesoTotal = ?, Fk_id_chofer = ? WHERE Pk_id_vehiculo = ?;";

                using (OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion()))
                {
                    cmd.Parameters.AddWithValue("@numeroPlaca", sNumeroPlaca);
                    cmd.Parameters.AddWithValue("@marca", sMarca);
                    cmd.Parameters.AddWithValue("@color", sColor);
                    cmd.Parameters.AddWithValue("@descripcion", sDescripcion);
                    cmd.Parameters.AddWithValue("@horaLlegada", sHoraLlegada);
                    cmd.Parameters.AddWithValue("@horaSalida", sHoraSalida);
                    cmd.Parameters.AddWithValue("@pesoTotal", doPesoTotal);
                    cmd.Parameters.AddWithValue("@Fk_id_chofer", iIdChofer);
                    cmd.Parameters.AddWithValue("@Fk_id_vehiculo", iIdVehiculo);


                    int iIngreso = cmd.ExecuteNonQuery();
                    MessageBox.Show(iIngreso > 0 ? "Vehículo modificado correctamente." : "No se encontró el vehículo para modificar.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nNo se pudo modificar el registro en la tabla Tbl_vehiculos.");
            }
        }

        // Método para Eliminar Vehiculo Realizado por Ammy Patricia Catun Lopez 0901-21-4857
        public void eliminarVehiculo(string iIdVehiculo)
        {
            try
            {
                string sSql = "DELETE FROM " + sTabla_Vehiculos + " WHERE Pk_id_vehiculo = ?;";
                using (OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion()))
                {
                    cmd.Parameters.AddWithValue("@idVehiculo", iIdVehiculo);
                    int resultado = cmd.ExecuteNonQuery();
                    MessageBox.Show(resultado > 0 ? "Vehículo eliminado correctamente." : "No se encontró el vehículo para eliminar.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nNo se pudo eliminar el registro en la tabla Vehiculos.");
            }
        }
        // Método para Eliminar Pedido Realizado por Ammy Patricia Catun Lopez 0901-21-4857
        public void eliminarPedido(string iIdGuia)
        {
            try
            {
                string sSql = "DELETE FROM " + sTabla_datos_pedido + " WHERE Pk_id_guia= ?;";
                using (OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion()))
                {
                    cmd.Parameters.AddWithValue("@idGuia",iIdGuia);
                    int resultado = cmd.ExecuteNonQuery();
                    MessageBox.Show(resultado > 0 ? "Pedido eliminado correctamente." : "No se encontró el pedido para eliminar.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nNo se pudo eliminar el registro en la tabla pedido.");
            }
        }
        // Método para modificar Pedido Realizado por Ammy Patricia Catun Lopez 0901-21-4857
        public void modificarPedido(DateTime dFechaEmision, DateTime dFechaTraslado, string sDireccionPartida, string sDireccionLlegada, string sNumeroOrdenRecojo, string sFormaPago, string sDestino, int iIdRemitente, int iIdDestinatario, int iIdvehiculo, int iIdGuia)
        {
            try
            {
                string sSql = "UPDATE Tbl_datos_pedido SET fechaEmision = ?, fechaTraslado = ?, direccionPartida = ?, direccionLlegada = ?, numeroOrdenRecojo = ?, formaPago = ?, destino = ?,  fk_id_Remitente = ?, fk_id_Destinatario = ?, fk_id_vehiculo = ? WHERE Pk_id_guia;"; 
                              

                using (OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion()))
                {
                    cmd.Parameters.AddWithValue("@fechaEmision", dFechaEmision);
                    cmd.Parameters.AddWithValue("@fechaTraslado", dFechaTraslado);
                    cmd.Parameters.AddWithValue("@direccionPartida", sDireccionPartida);
                    cmd.Parameters.AddWithValue("@direccionLlegada", sDireccionLlegada);
                    cmd.Parameters.AddWithValue("@numeroOrdenRecojo", sNumeroOrdenRecojo);
                    cmd.Parameters.AddWithValue("@formaPago", sFormaPago);
                    cmd.Parameters.AddWithValue("@destino", sDestino);
                    cmd.Parameters.AddWithValue("@fk_id_Remitente", iIdRemitente);
                    cmd.Parameters.AddWithValue("@fk_id_Destinatario", iIdDestinatario);
                    cmd.Parameters.AddWithValue("@fk_id_vehiculo", iIdvehiculo);
                    cmd.Parameters.AddWithValue("@Pk_id_guia", iIdGuia);

                    int iIngreso = cmd.ExecuteNonQuery();
                    MessageBox.Show(iIngreso > 0 ? "Pedido registrado correctamente." : "No se pudo registrar el pedido.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nNo se pudo guardar el registro en la tabla Tbl_datos_pedido.");
            }
        }
        // Método para agregar el boton de ayuda realizado por Ammy Patricia Catun Lopez 0901-21-4857
        public string ModRuta(string iIdAyuda)
        {
            string sRuta = "";
            string sSql = "SELECT Ruta FROM ayuda WHERE Id_ayuda = ?"; // Parámetro seguro

            using (OdbcCommand command = new OdbcCommand(sSql, cn.conexion()))
            {
                command.Parameters.AddWithValue("id_ayuda", iIdAyuda);
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

        public string ModIndice(string iIdAyuda)
        {
            string sIndice = "";
            string sSql = "SELECT indice FROM ayuda WHERE id_ayuda = ?"; // Parámetro seguro

            using (OdbcCommand command = new OdbcCommand(sSql, cn.conexion()))
            {
                command.Parameters.AddWithValue("Id_ayuda", iIdAyuda);
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

    }
}

 











