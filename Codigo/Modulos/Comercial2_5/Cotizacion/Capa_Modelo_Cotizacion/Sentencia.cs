using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Net;
using System.Data;


namespace Capa_Modelo_Cotizacion
{
    public class Sentencia
    {
        Conexion cn = new Conexion();

        public string sIdUsuario { get; set; }


        // combo de 2

        public string[] funllenarCmb(string stabla, string scampo1, string scampo2)
        {
            Conexion cn = new Conexion();
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


        public DataTable funobtener(string stabla, string scampo1, string scampo2)
        {
            Conexion cn = new Conexion();
            string ssql = "SELECT DISTINCT " + scampo1 + "," + scampo2 + " FROM " + stabla;

            OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }


        // productos


        public string[] funllenarCmbP(string stabla)
        {
            Conexion cn = new Conexion();
            string[] sCampos = new string[300];
            int i = 0;

            // Consulta para obtener el ID del producto y su nombre
            string ssql = @"
        SELECT DISTINCT 
            ld.Fk_id_Producto, 
            p.Producto_nombre 
        FROM 
            " + stabla + @" ld
        JOIN 
            Tbl_Productos p ON ld.Fk_id_Producto = p.Pk_id_Producto";

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
                    sCampos[i] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString(); // ID-Nombre
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError en asignarCombo, revise los parámetros \n -" + stabla);
            }

            return sCampos;
        }


        public DataTable funobtenerP(string stabla)
        {
            Conexion cn = new Conexion();
            string ssql = @"
        SELECT DISTINCT 
            ld.Fk_id_Producto, 
            p.Producto_nombre 
        FROM 
            " + stabla + @" ld
        JOIN 
            Tbl_Productos p ON ld.Fk_id_Producto = p.Pk_id_Producto";

            OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();

            try
            {
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }

            return dt;
        }


        public OdbcDataAdapter prollenadoProducto1(string idcliente, string idProducto)
        {
            /*cn.conectar();
            string ssqlPrecioProducto = "SELECT ListDetalle_preVenta FROM Tbl_lista_detalle WHERE Fk_id_Producto = " + idProducto;
            //funInsertarBitacora(idUsuario, "Realizo una consulta a aplicaciones", "tbl_aplicaciones", "1000");
            OdbcDataAdapter dataTable = new OdbcDataAdapter(ssqlPrecioProducto, cn.conectar());
            return dataTable;*/

            string ssqlPrecioProducto = "SELECT p.Pk_id_Producto, p.nombreProducto, COALESCE(ld.ListDetalle_preVenta, p.precioUnitario) AS precio " +
                            "FROM Tbl_Productos p " +
                            "LEFT JOIN Tbl_lista_detalle ld ON p.Pk_id_Producto = ld.Fk_id_Producto " +
                            "LEFT JOIN Tbl_clientes c ON c.FK_id_lista_Encabezado = ld.Fk_id_lista_Encabezado " +
                            "WHERE c.Pk_id_cliente = " + idcliente + " " +
                            "AND p.Pk_id_Producto = " + idProducto;

            // funInsertarBitacora(idUsuario, "Realizó una consulta a aplicaciones", "tbl_aplicaciones", "1000");
            OdbcDataAdapter dataTable = new OdbcDataAdapter(ssqlPrecioProducto, cn.conectar());
            return dataTable;
        }

        public OdbcDataAdapter prollenadoProducto2(string idProducto)
        {

            string ssqlPrecioProducto = "SELECT precioUnitario FROM Tbl_Productos WHERE Pk_id_Producto = " + idProducto;
            //funInsertarBitacora(idUsuario, "Realizo una consulta a aplicaciones", "tbl_aplicaciones", "1000");
            OdbcDataAdapter dataTable = new OdbcDataAdapter(ssqlPrecioProducto, cn.conectar());
            return dataTable;
        }

        public OdbcDataAdapter prollenadoCliente(string idcliente)
        {
            cn.conectar();
            string ssqlPrecioProducto = "SELECT Cliente_Tipo FROM Tbl_clientes WHERE Pk_id_cliente = " + idcliente;
            //funInsertarBitacora(idUsuario, "Realizo una consulta a aplicaciones", "tbl_aplicaciones", "1000");
            OdbcDataAdapter dataTable = new OdbcDataAdapter(ssqlPrecioProducto, cn.conectar());
            return dataTable;
        }



        public void funInsertarCotizacionE(string Idcotizacion, string IdVendedor, string IdClientes, DateTime FechaVen, string TotalC)
        {
            try
            {
                string query = "INSERT INTO Tbl_cotizacion_encabezado (Pk_id_cotizacionEnc, Fk_id_vendedor, Fk_id_cliente, CotizacionEnc_fechaVenc, CotizacionEnc_total) VALUES (?, ?, ?, ?, ?)";
                using (OdbcCommand command = new OdbcCommand(query, cn.conectar()))
                {
                    command.Parameters.AddWithValue("@Pk_id_cotizacionEnc", Idcotizacion);
                    command.Parameters.AddWithValue("@Fk_id_vendedor", IdVendedor);
                    command.Parameters.AddWithValue("@Fk_id_cliente", IdClientes);
                    command.Parameters.AddWithValue("@CotizacionEnc_fechaVenc", FechaVen);
                    command.Parameters.AddWithValue("@CotizacionEnc_total", TotalC);
                    command.ExecuteNonQuery();
                }
                // Crear instancia de la clase Sentencia en Capa_modelo_seguridad
                 var bitacora = new Capa_Modelo_Seguridad.sentencia();

                 // Llama a la función de bitácora
                 bitacora.funInsertarBitacora(sIdUsuario, "Realizó una insercion a la tabla de cotizacion encabezado", "Tbl_cotizacion_encabezado", "3000");
             
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar en la tabla encabezado: " + ex.Message);
            }
        }

        // Método para insertar un detalle de comisión
        public void funInsertarCotizacionD(int Idcotizacion, int IdProducto, int Cantidad, decimal Precio, decimal Subtotal)
        {
            try
            {
                string query = "INSERT INTO Tbl_cotizacion_detalle (Fk_id_cotizacionEnc, Fk_id_producto, CotizacionDet_cantidad, CotizacionDet_precio, CotizacionDet_subtotal) VALUES (?, ?, ?, ?, ?)";
                using (OdbcCommand command = new OdbcCommand(query, cn.conectar()))
                {
                    command.Parameters.AddWithValue("@Fk_id_cotizacionEnc", Idcotizacion);
                    command.Parameters.AddWithValue("@Fk_id_producto", IdProducto);
                    command.Parameters.AddWithValue("@CotizacionDet_cantidad", Cantidad);
                    command.Parameters.AddWithValue("@CotizacionDet_precio", Precio);
                    command.Parameters.AddWithValue("@CotizacionDet_subtotal", Subtotal);
                    command.ExecuteNonQuery();
                }

                 // Crear instancia de la clase Sentencia en Capa_modelo_seguridad
                 var bitacora = new Capa_Modelo_Seguridad.sentencia();

                 //Llama a la función de bitácora
                 bitacora.funInsertarBitacora(sIdUsuario, "Realizó una insercion a la tabla de Detalle cotizacion", "Tbl_cotizacion_detalle", "3000");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar en la tabla detalle comisiones: " + ex.Message);
            }
        }


    }

}
