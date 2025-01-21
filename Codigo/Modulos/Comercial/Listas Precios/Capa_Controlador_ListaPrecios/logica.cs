using System;
using System.Data;
using Capa_Modelo_ListaPrecios;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Capa_Controlador_ListaPrecios
{
    public class logica
    {
        sentencia sn;

        public logica(string idUsuario)
        {
            sn = new sentencia(idUsuario);
        }

        public logica() { }


        public DataTable funconsultalogicaproductos(string clasificacion)
        {
            try
            {
                OdbcDataAdapter dtProducto = sn.funconsultarproductos(clasificacion);
                DataTable tableProducto = new DataTable();
                dtProducto.Fill(tableProducto);
                return tableProducto;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funconsultalogicaproductos: " + ex.Message);
                return null;
            }
        }

        //Función para obtener clasificaciones
        public DataTable funconsultarlogicaClasificaciones()
        {
            try
            {
                OdbcDataAdapter dtClasificacion = sn.funconsultarClasificaciones(); // Asegúrate de implementar este método
                DataTable tableClasificacion = new DataTable();
                dtClasificacion.Fill(tableClasificacion);
                return tableClasificacion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funconsultarClasificaciones: " + ex.Message);
                return null;
            }
        }

        //Función para obtener clasificación del producto
        public DataTable CargarClasificacionesEspecificas(string tipoClasificacion)
        {
            try
            {
                DataTable dtClasificacionesEspecificas = sn.ObtenerClasificacionesEspecificas(tipoClasificacion);
                return dtClasificacionesEspecificas;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en CargarClasificacionesEspecificas: " + ex.Message);
                return null; // Retorna null en caso de error
            }
        }

        //carga los productos en la datagrid dependiendo de la clasificacion general y especifica seleccionada
        public DataTable CargarProductos(string clasificacion)
        {
            try
            {
                DataTable dtClasificacionesEspecificas = sn.funcargarProductosPorClasificacion(clasificacion);
                return dtClasificacionesEspecificas;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en CargarClasificacionesEspecificas: " + ex.Message);
                return null; // Retorna null en caso de error
            }
        }

        //carga los productos al ser buscados por codigo o por nombre sin especificar alguna clasificacion general o especifica
        public DataTable funCargarProductos(string sbuqueda)
        {
            try
            {
                DataTable dtClasificacionesEspecificas = sn.funcargarProductosPorCodigoONombre(sbuqueda);
                return dtClasificacionesEspecificas;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en CargarClasificacionesEspecificas: " + ex.Message);
                return null; // Retorna null en caso de error
            }
        }


        //cargar texbox para busqueda por inventario = producto específico
        public AutoCompleteStringCollection funconsultalogicaProductosPorInventario()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            DataTable datos = sn.funconsultarProductosPorInventario();

            if (datos.Rows.Count == 0)
            {
                Console.WriteLine("No se encontraron productos.");
                return lista; // Retorna una lista vacía si no hay productos
            }

            foreach (DataRow row in datos.Rows)
            {
                // Agregar tanto el nombre como el código a la colección
                string codigoProducto = row["codigoProducto"].ToString();
                string nombreProducto = row["nombreProducto"].ToString();
                // Agregar solo el código
                lista.Add(codigoProducto);

                // Agregar solo el nombre
                lista.Add(nombreProducto);
            }

            return lista;
        }

        //obtencion del tipo de lista
        public DataTable funconsultaLogicaClasificaciones()
        {

            try
            {
                OdbcDataAdapter dtClasificacion = sn.funClasificacionLista();
                DataTable tableClasificacion = new DataTable();
                dtClasificacion.Fill(tableClasificacion);
                return tableClasificacion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public bool funinsertarListaEncabezado(int iCodigoEncabezado, int iClasificacion, DateTime sFecha, string sEstado)
        {
            try
            {
                // Ejecutar la inserción
                sn.proinsertarlistaEncabezado(iCodigoEncabezado, iClasificacion, sFecha, sEstado);
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al insertar la lista: " + ex.Message);
                return false;
            }
        } // termina

        //insercion en tercera datagrid para almacenamiento en bd
        public bool funinsertarListaDetalle(int iCodigoEncabezado, int iCodigoProducto, decimal dPrecioLista)
        {
            try
            {
                // Ejecutar la inserción
                sn.proinsertarlistaDetalle(iCodigoEncabezado, iCodigoProducto, dPrecioLista);
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al insertar la lista: " + ex.Message);
                return false;
            }
        } // termina

        //obtener todos los encabezados de las listas para mostrarlos en el incio
        public DataTable funcargarEncabezados()
        {
            try
            {
                DataTable tableencabezados = sn.funmostarEncabezados(); 
                return tableencabezados; 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        //busqueda filtrada de las listas (encabezado)
        public DataTable funcargarEncabezadosPorTipoL(string stipoLista)
        {
            try
            {
                OdbcDataAdapter dtencabezados = sn.funmostarEncabezadosPorTipo(stipoLista);
                DataTable tableencabezados = new DataTable();
                dtencabezados.Fill(tableencabezados);
                return tableencabezados;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable funcargarEncabezadosPorTipoE(string sestado)
        {
            try
            {
                OdbcDataAdapter dtencabezadosE = sn.funmostarEncabezadosPorEstado(sestado);
                DataTable tableencabezadosE = new DataTable();
                dtencabezadosE.Fill(tableencabezadosE);
                return tableencabezadosE;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable funcargarEncabezadosPorTipo()
        {
            try
            {
                OdbcDataAdapter dttipo = sn.funObtenerTiposDeLista();
                DataTable tableencabezados = new DataTable();
                dttipo.Fill(tableencabezados);
                return tableencabezados;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        //eliminar lista
        public void funeliminarlista(int idEncabezado)
        {
            try
            {
                // Llama al método que elimina encabezados y detalles
                sn.proeliminarlista(idEncabezado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar la lista: " + ex.Message);
            }
        }

        //editar lista (detalle)
        public DataTable funobtenerDetalle(int idEncabezado)
        {
            try
            {
                DataTable tabledetalle = sn.funobtenerdetalleEncabezado(idEncabezado);
                return tabledetalle;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        //actualizar cambios editados
        public DataTable funlogicaactualizarEncabezado(int codigoEncabezado, int tipoLista, DateTime fechaCreacion, string estado)
        {
            try
            {
                // Llamar al método que actualiza el encabezado
                OdbcDataAdapter dataAdapter = sn.proactualizarListaEncabezado(codigoEncabezado, tipoLista, fechaCreacion, estado);

                // Si la actualización fue exitosa, llenar el DataTable con el resultado
                if (dataAdapter != null)
                {
                    DataTable tabledetalle = new DataTable();
                    dataAdapter.Fill(tabledetalle);  // Llenar el DataTable con los datos actualizados
                    return tabledetalle;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar encabezado: " + ex.Message);
                return null;
            }
        }

        /*public DataTable funlogicaactualizarTabla()
        {
            try
            {
                OdbcDataAdapter dataTable = sn.funobtenerEncabezadoYDetalle();
                DataTable tabledetalle = new DataTable();
                dataTable.Fill(tabledetalle);
                return tabledetalle;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar detalle: " + ex.Message);
                return null;
            }
        }*/
    }
}
