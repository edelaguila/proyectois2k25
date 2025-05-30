using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using Capa_Modelo_Seguridad;

namespace Capa_Modelo
{
    public class Sentencia
    {
        private Conexion cn = new Conexion();

        public string sIdUsuario { get; set; }


        // Método para obtener el listado de vendedores
        public OdbcDataAdapter funObtenerVendedores()
        {
            try
            {
                string sQuery = "SELECT Pk_id_vendedor, CONCAT(vendedores_nombre, ' ', vendedores_apellido) AS NombreCompleto FROM Tbl_vendedores";
                OdbcDataAdapter vendedoresAdapter = new OdbcDataAdapter(sQuery, cn.conectar());

                return vendedoresAdapter;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los vendedores: " + ex.Message);
                return null;
            }
        }

        // Método para obtener ventas de un vendedor según filtros
        public OdbcDataAdapter FunObtenerVentasPorVendedor(int iIdVendedor, string sFiltro, DateTime dFechaInicio, DateTime dFechaFin, string sValorFiltro)
        {
            try
            {
                string query = $"SELECT Tbl_factura.Pk_id_factura AS IdVenta, " +
                   $"Tbl_factura.factura_fecha AS FechaVenta, " +
                   $"Tbl_Productos.nombreProducto AS Producto, " +
                   $"Tbl_Marca.nombre_Marca AS Marca, " +
                   $"Tbl_Linea.nombre_linea AS Linea, " +
                   $"Tbl_pedido_detalle.PedidoDet_cantidad AS CantidadVendida, " +
                   $"Tbl_factura.factura_total AS Total, ";

                // Agrega el campo de comisión según el filtro seleccionado
                if (sFiltro == "Inventario")
                {
                    query += $"Tbl_Productos.comisionInventario AS Comision ";
                }
                else if (sFiltro == "Marcas")
                {
                    query += $"Tbl_Marca.comision AS Comision ";
                }
                else if (sFiltro == "Lineas")
                {
                    query += $"Tbl_Linea.comision AS Comision ";
                }
                else if (sFiltro == "Costo")
                {
                    query += $"Tbl_Productos.comisionCosto AS Comision ";
                }

                query += "FROM Tbl_factura " +
                         "JOIN Tbl_pedido_encabezado ON Tbl_factura.Fk_id_pedidoEnc = Tbl_pedido_encabezado.Pk_id_PedidoEnc " +
                         "JOIN Tbl_pedido_detalle ON Tbl_pedido_encabezado.Pk_id_PedidoEnc = Tbl_pedido_detalle.Fk_id_pedidoEnc " +
                         "JOIN Tbl_Productos ON Tbl_pedido_detalle.Fk_id_producto = Tbl_Productos.Pk_id_Producto " +
                         "JOIN Tbl_Marca ON Tbl_Productos.fk_id_marca = Tbl_Marca.Pk_id_Marca " +
                         "JOIN Tbl_Linea ON Tbl_Productos.fk_id_linea = Tbl_Linea.Pk_id_linea " +
                         "WHERE Tbl_factura.factura_fecha BETWEEN ? AND ?";

                // Agregar condición de vendedor solo si no es "Todos los vendedores"
                if (iIdVendedor > 0)
                {
                    query += " AND Tbl_pedido_encabezado.Fk_id_vendedor = ?";
                }

                // Condiciones adicionales para filtrar por marca o línea si corresponde
                if (sFiltro == "Marcas" && !string.IsNullOrEmpty(sValorFiltro) && sValorFiltro != "0")
                {
                    query += " AND Tbl_Marca.Pk_id_Marca = ?";
                }
                else if (sFiltro == "Lineas" && !string.IsNullOrEmpty(sValorFiltro) && sValorFiltro != "0")
                {
                    query += " AND Tbl_Linea.Pk_id_linea = ?";
                }

                // Mensaje de depuración: mostrar la consulta y los parámetros
                Console.WriteLine($"Consulta SQL generada:\n{query}\n\nParámetros:\nVendedor: {iIdVendedor}\nFechaInicio: {dFechaInicio}\nFechaFin: {dFechaFin}\nValorFiltro: {sValorFiltro}");

                OdbcCommand command = new OdbcCommand(query, cn.conectar());

                // Agregar parámetros en el orden correcto
                command.Parameters.AddWithValue("?", dFechaInicio);
                command.Parameters.AddWithValue("?", dFechaFin);

                if (iIdVendedor > 0)
                {
                    command.Parameters.AddWithValue("?", iIdVendedor);
                }

                if ((sFiltro == "Marcas" || sFiltro == "Lineas") && !string.IsNullOrEmpty(sValorFiltro) && sValorFiltro != "0")
                {
                    command.Parameters.AddWithValue("?", sValorFiltro);
                }

                OdbcDataAdapter ventasAdapter = new OdbcDataAdapter(command);
                // Intentar llenar un DataTable para ver cuántas filas devuelve
                DataTable dtTest = new DataTable();
                ventasAdapter.Fill(dtTest);
                Console.WriteLine($"Filas devueltas por la consulta: {dtTest.Rows.Count}");
                return new OdbcDataAdapter(command); // Retornar el adapter original
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener las ventas filtradas: " + ex.Message);
                return null;
            }
        }


        // Método para insertar un encabezado de comisión
        public void funInsertarComisionEncabezado(int iIdVendedor, decimal deTotalVenta, decimal deTotalComision)
        {
            try
            {
                string query = "INSERT INTO Tbl_comisiones_encabezado (Fk_id_vendedor, Comisiones_fecha_, Comisiones_total_venta, Comisiones_total_comision) VALUES (?, ?, ?, ?)";
                using (OdbcCommand command = new OdbcCommand(query, cn.conectar()))
                {
                    command.Parameters.AddWithValue("@Fk_id_vendedor", iIdVendedor);
                    command.Parameters.AddWithValue("@Comisiones_fecha_", DateTime.Now);
                    command.Parameters.AddWithValue("@Comisiones_total_venta", deTotalVenta);
                    command.Parameters.AddWithValue("@Comisiones_total_comision", deTotalComision);
                    command.ExecuteNonQuery();
                }
                // Crear instancia de la clase Sentencia en Capa_modelo_seguridad
                var bitacora = new Capa_Modelo_Seguridad.sentencia();

                // Llama a la función de bitácora
                bitacora.funInsertarBitacora(sIdUsuario, "Realizó una insercion a la tabla de Comisiones encabezado", "Tbl_comisiones_encabezado", "3000");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar en la tabla Comisiones encabezado: " + ex.Message);
            }
        }

        // Método para insertar un detalle de comisión
        public void funInsertarComisionDetalle(int iIdComisionEnc, int iIdFactura, decimal dePorcentaje, decimal deMontoVenta, decimal deMontoComision)
        {
            try
            {
                string query = "INSERT INTO Tbl_detalle_comisiones (Fk_id_comisionEnc, Fk_id_factura, Comisiones_porcentaje, Comisiones_monto_venta, Comisiones_monto_comision) VALUES (?, ?, ?, ?, ?)";
                using (OdbcCommand command = new OdbcCommand(query, cn.conectar()))
                {
                    command.Parameters.AddWithValue("@Fk_id_comisionEnc", iIdComisionEnc);
                    command.Parameters.AddWithValue("@Fk_id_factura", iIdFactura);
                    command.Parameters.AddWithValue("@Comisiones_porcentaje", dePorcentaje);
                    command.Parameters.AddWithValue("@Comisiones_monto_venta", deMontoVenta);
                    command.Parameters.AddWithValue("@Comisiones_monto_comision", deMontoComision);
                    command.ExecuteNonQuery();
                }

                // Crear instancia de la clase Sentencia en Capa_modelo_seguridad
                var bitacora = new Capa_Modelo_Seguridad.sentencia();

                // Llama a la función de bitácora
                bitacora.funInsertarBitacora(sIdUsuario, "Realizó una insercion a la tabla de Detalle Comisiones", "Tbl_comisiones_encabezado", "3000");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar en la tabla detalle comisiones: " + ex.Message);
            }
        }

        // Método para insertar en Tbl_comisiones_encabezado
        public int funInsertarComisionEncabezado(int iIdVendedor, DateTime dFecha, decimal deTotalVenta, decimal deTotalComision)
        {
            try
            {
                int iNuevoId = funObtenerSiguienteIdComisionEncabezado();

                string queryInsert = "INSERT INTO Tbl_comisiones_encabezado (Pk_id_comisionEnc, Fk_id_vendedor, Comisiones_fecha_, Comisiones_total_venta, Comisiones_total_comision) " +
                                     "VALUES (?, ?, ?, ?, ?);";
                using (OdbcCommand command = new OdbcCommand(queryInsert, cn.conectar()))
                {
                    command.Parameters.AddWithValue("@Pk_id_comisionEnc", iNuevoId);
                    command.Parameters.AddWithValue("@Fk_id_vendedor", iIdVendedor);
                    command.Parameters.AddWithValue("@Comisiones_fecha_", dFecha);
                    command.Parameters.AddWithValue("@Comisiones_total_venta", deTotalVenta);
                    command.Parameters.AddWithValue("@Comisiones_total_comision", deTotalComision);
                    command.ExecuteNonQuery();
                }

                // Crear instancia de la clase Sentencia en Capa_modelo_seguridad
                var bitacora = new Capa_Modelo_Seguridad.sentencia();

                // Llama a la función de bitácora
                bitacora.funInsertarBitacora(sIdUsuario, "Realizó una insercion a la tabla de Comisiones encabezado", "Tbl_comisiones_encabezado", "3000");

                return iNuevoId;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar en la tabla Comisiones encabezado: " + ex.Message);
                return 0;
            }

        }

        // Método para insertar en Tbl_detalle_comisiones
        public void funInsertarDetalleComision(int iIdComisionEnc, int iIdFactura, decimal dePorcentaje, decimal deMontoVenta, decimal deMontoComision)
        {
            try
            {
                int nuevoId = funObtenerProximoIdDetalleComision(); // Obtener el nuevo ID para Pk_id_detalle_comision
                string query = "INSERT INTO Tbl_detalle_comisiones (Pk_id_detalle_comision, Fk_id_comisionEnc, Fk_id_factura, Comisiones_porcentaje, Comisiones_monto_venta, Comisiones_monto_comision) " +
                               "VALUES (?, ?, ?, ?, ?, ?)";
                using (OdbcCommand command = new OdbcCommand(query, cn.conectar()))
                {
                    command.Parameters.AddWithValue("@Pk_id_detalle_comision", nuevoId);
                    command.Parameters.AddWithValue("@Fk_id_comisionEnc", iIdComisionEnc);
                    command.Parameters.AddWithValue("@Fk_id_factura", iIdFactura);
                    command.Parameters.AddWithValue("@Comisiones_porcentaje", dePorcentaje);
                    command.Parameters.AddWithValue("@Comisiones_monto_venta", deMontoVenta);
                    command.Parameters.AddWithValue("@Comisiones_monto_comision", deMontoComision);
                    command.ExecuteNonQuery();
                }

                // Crear instancia de la clase Sentencia en Capa_modelo_seguridad
                var bitacora = new Capa_Modelo_Seguridad.sentencia();

                // Llama a la función de bitácora
                bitacora.funInsertarBitacora(sIdUsuario, "Realizó una insercion a la tabla de detalle comisiones", "Tbl_detalle_comisiones", "3000");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar en la tabla detalle comision: " + ex.Message);
            }


        }

        // Método para obtener el siguiente Pk_id_comisionEnc
        public int funObtenerSiguienteIdComisionEncabezado()
        {
            try
            {
                int iSiguienteId = 1;
                string sQuery = "SELECT MAX(Pk_id_comisionEnc) FROM Tbl_comisiones_encabezado";

                using (OdbcCommand command = new OdbcCommand(sQuery, cn.conectar()))
                {
                    var resultado = command.ExecuteScalar();
                    if (resultado != DBNull.Value)
                    {
                        iSiguienteId = Convert.ToInt32(resultado) + 1;
                    }
                }
                return iSiguienteId;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los vendedores: " + ex.Message);
                return 0;
            }
        }

        public int funObtenerProximoIdDetalleComision()
        {
            try
            {
                int iNuevoId = 1; // Comenzar con 1 como valor inicial
                string query = "SELECT MAX(Pk_id_detalle_comision) FROM Tbl_detalle_comisiones";

                using (OdbcConnection connection = cn.conectar())
                {
                    using (OdbcCommand command = new OdbcCommand(query, connection))
                    {
                        var resultado = command.ExecuteScalar();
                        if (resultado != DBNull.Value)
                        {
                            iNuevoId = Convert.ToInt32(resultado) + 1; // Incrementar en 1 el valor máximo actual
                        }
                    }
                }
                return iNuevoId;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los vendedores: " + ex.Message);
                return 0;
            }
        }

        public DataTable funObtenerMarcas()
        {
            DataTable dtMarcas = new DataTable();
            string query = "SELECT Pk_id_Marca, nombre_Marca FROM Tbl_Marca WHERE estado = 1";

            try
            {
                using (OdbcConnection connection = cn.conectar())
                {
                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        using (OdbcDataAdapter adapter = new OdbcDataAdapter(cmd))
                        {
                            adapter.Fill(dtMarcas);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener marcas: " + ex.Message);
            }

            return dtMarcas;
        }

        public DataTable funObtenerLineas()
        {
            DataTable dtLineas = new DataTable();
            string query = "SELECT Pk_id_linea, nombre_linea FROM Tbl_Linea WHERE estado = 1";

            try
            {
                using (OdbcConnection connection = cn.conectar())
                {
                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        using (OdbcDataAdapter adapter = new OdbcDataAdapter(cmd))
                        {
                            adapter.Fill(dtLineas);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener líneas: " + ex.Message);
            }

            return dtLineas;
        }

    }
}


