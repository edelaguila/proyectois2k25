using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MVC_JavierChamo
{
    public partial class Movimiento_de_Inventario : Form
    {
        Capa_Controlador.Cls_Controlador capa_Controlador_Logistica = new Capa_Controlador.Cls_Controlador();
        
        public Movimiento_de_Inventario()
        {
            InitializeComponent();
            llenarComboBox();
            CargarSolicitudesenDatagriedView();
        }

        public void btn_Guardar_Click(object sender, EventArgs e)
        {
            capa_Controlador_Logistica.Pro_RealizarMovimientoInventario(
                Convert.ToInt32(Cbo_idprod.SelectedValue), // Asegúrate de usar SelectedValue
                Convert.ToInt32(Txt_cantstock.Value),
                Convert.ToInt32(Cbo_idtraslado.SelectedValue),     // Cambia esto
                Convert.ToInt32(Cbo_almacen.SelectedValue),              // Cambia esto
                Convert.ToInt32(Txt_almastock.Value),
                Convert.ToInt32(Cbo_idcompra.SelectedValue),
                Convert.ToString(Cbo_tipomovimiento.SelectedItem.ToString())
            );
            CargarSolicitudesenDatagriedView();
        }
        private void llenarComboBox()
        {
            try
            {
                // Llenar ComboBox para Productos
                DataTable productos = capa_Controlador_Logistica.Fun_ObtenerProductos();
                if (productos.Columns.Contains("Pk_id_Producto") && productos.Rows.Count > 0)
                {
                    Cbo_idprod.DataSource = productos;
                    Cbo_idprod.DisplayMember = "Pk_id_Producto"; // Mostrar el ID
                    Cbo_idprod.ValueMember = "Pk_id_Producto";
                    Cbo_idprod.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No se encontraron productos para mostrar.");
                }

                // Llenar ComboBox para Stock
                DataTable stocks = capa_Controlador_Logistica.Fun_ObtenerTraslados();
                if (stocks.Columns.Contains("Pk_id_TrasladoProductos") && stocks.Rows.Count > 0)
                {
                    Cbo_idtraslado.DataSource = stocks;
                    Cbo_idtraslado.DisplayMember = "Pk_id_TrasladoProductos"; // Mostrar el ID
                    Cbo_idtraslado.ValueMember = "Pk_id_TrasladoProductos";
                    Cbo_idtraslado.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No se encontraron traslados para mostrar.");
                }

                // Llenar ComboBox para Almacenes
                DataTable almacen = capa_Controlador_Logistica.Fun_ObtenerAlmacenes();
                if (almacen.Columns.Contains("Pk_ID_BODEGA") && almacen.Rows.Count > 0)
                {
                    Cbo_almacen.DataSource = almacen;
                    Cbo_almacen.DisplayMember = "Pk_ID_BODEGA"; // Mostrar el ID
                    Cbo_almacen.ValueMember = "Pk_ID_BODEGA";
                    Cbo_almacen.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No se encontraron almacenes para mostrar.");
                }

                // Llenar ComboBox para Locales
                DataTable compras = capa_Controlador_Logistica.Fun_ObtenerCompras();
                if (compras.Columns.Contains("Pk_id_compra") && compras.Rows.Count > 0)
                {
                    Cbo_idcompra.DataSource = compras;
                    Cbo_idcompra.DisplayMember = "Pk_id_compra"; // Mostrar el ID
                    Cbo_idcompra.ValueMember = "Pk_id_compra";
                    Cbo_idcompra.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No se encontraron compras para mostrar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al llenar los ComboBox: " + ex.Message);
            }
        }
        public void CargarSolicitudesenDatagriedView()
        {
            try
            {
                DataTable tablaMovimiento = capa_Controlador_Logistica.Fun_MostrarMovimientosInventario();
                Dgv_Inventario.DataSource = tablaMovimiento;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar datos en el DataGridView: " + ex.Message);
            }
        }
        

        private void dgbMovimientoInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Dgv_Inventario.Rows[e.RowIndex];
                Cbo_idprod.Text = row.Cells["Fk_id_producto"].Value.ToString();
                Cbo_idtraslado.SelectedValue = row.Cells["Fk_id_traslado"].Value.ToString();
                Cbo_almacen.Text = row.Cells["Fk_ID_BODEGA"].Value.ToString();
                Cbo_idcompra.SelectedValue = row.Cells["Fk_id_compra"].Value.ToString();
                Cbo_tipomovimiento.SelectedItem = row.Cells["tipo_movimiento"].Value.ToString();


                int numMovimiento = Convert.ToInt32(row.Cells["Pk_id_movimiento"].Value);
                txt_numMovimiento.Text = numMovimiento.ToString();
                int cantStock = Convert.ToInt32(row.Cells["stock"].Value);
                Txt_cantstock.Text = cantStock.ToString();
                int almaStock = Convert.ToInt32(row.Cells["Cantidad_almacen"].Value);
                Txt_almastock.Text = almaStock.ToString();
            }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            CargarSolicitudesenDatagriedView();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            capa_Controlador_Logistica.Pro_ModificarMovimientoInventario(
                Convert.ToInt32(txt_numMovimiento.Text),
                Convert.ToInt32(Cbo_idprod.SelectedValue), // Asegúrate de usar SelectedValue
                Convert.ToInt32(Txt_cantstock.Value),
                Convert.ToInt32(Cbo_idtraslado.SelectedValue),     // Cambia esto
                Convert.ToInt32(Cbo_almacen.SelectedValue),              // Cambia esto
                Convert.ToInt32(Txt_almastock.Value),
                Convert.ToInt32(Cbo_idcompra.SelectedValue),
                Convert.ToString(Cbo_tipomovimiento.SelectedItem.ToString())
            );
            CargarSolicitudesenDatagriedView();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            capa_Controlador_Logistica.Pro_EliminarMovimiento(Convert.ToInt32(txt_numMovimiento.Text));
            CargarSolicitudesenDatagriedView();
        }

        private void btn_GenerarPDF_Click(object sender, EventArgs e)
        {
            GenerarPDF_MovimientoInventario generarPDF_MovimientoInventario = new GenerarPDF_MovimientoInventario();
            generarPDF_MovimientoInventario.Show();
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            ReporteMovimientoInventario frm = new ReporteMovimientoInventario();
            frm.Show();
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la ruta del directorio del ejecutable
                string sexecutablePath = AppDomain.CurrentDomain.BaseDirectory;

                // Retroceder a la carpeta del proyecto
                string sprojectPath = Path.GetFullPath(Path.Combine(sexecutablePath, @"..\..\"));
                //MessageBox.Show("1" + projectPath);


                string sayudaFolderPath = Path.Combine(sprojectPath, "AyudaMantenimientoVehiculo");


                // Busca el archivo .chm en la carpeta "Ayuda_Seguridad"
                string spathAyuda = FindFileInDirectory(sayudaFolderPath, "AyudaMantenimientoVehiculo.chm");

                // Verifica si el archivo existe antes de intentar abrirlo
                if (!string.IsNullOrEmpty(spathAyuda))
                {
                    // Abre el archivo de ayuda .chm en la sección especificada
                    Help.ShowHelp(null, spathAyuda, "AyudaMantenimientoVehiculo.html");
                }
                else
                {
                    // Si el archivo no existe, muestra un mensaje de error
                    MessageBox.Show("El archivo de ayuda no se encontró.");
                }
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de una excepción
                MessageBox.Show("Ocurrió un error al abrir la ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al abrir la ayuda: " + ex.ToString());
            }
        }
        public string FindFileInDirectory(string sdirectory, string sfileName)
        {
            try
            {
                // Verificamos si la carpeta existe
                if (Directory.Exists(sdirectory))
                {
                    // Buscamos el archivo .chm en la carpeta
                    string[] files = Directory.GetFiles(sdirectory, "*.chm", SearchOption.TopDirectoryOnly);

                    // Si encontramos el archivo, verificamos si coincide con el archivo que se busca y retornamos su ruta
                    foreach (var file in files)
                    {
                        if (Path.GetFileName(file).Equals(sfileName, StringComparison.OrdinalIgnoreCase))
                        {
                            //MessageBox.Show("Archivo encontrado: " + file);
                            return file;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la carpeta: " + sdirectory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar ayuda: " + ex.Message);
            }

            // Retorna null si no se encontró el archivo
            return null;
        }
    }
}

