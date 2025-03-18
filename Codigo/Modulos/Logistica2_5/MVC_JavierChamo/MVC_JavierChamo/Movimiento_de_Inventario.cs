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
                Convert.ToInt32(Cbo_estado.Text),
                Convert.ToInt32(Cbo_idProducto.SelectedValue),  // Asegúrate de usar SelectedValue
                Convert.ToInt32(Cbo_idStock.SelectedValue),     // Cambia esto
                Convert.ToInt32(Cbo_Local.SelectedValue)              // Cambia esto
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
                    Cbo_idProducto.DataSource = productos;
                    Cbo_idProducto.DisplayMember = "Pk_id_Producto"; // Mostrar el ID
                    Cbo_idProducto.ValueMember = "Pk_id_Producto";
                    Cbo_idProducto.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No se encontraron productos para mostrar.");
                }

                // Llenar ComboBox para Stock
                DataTable stocks = capa_Controlador_Logistica.Fun_ObtenerStocks();
                if (stocks.Columns.Contains("Pk_id_TrasladoProductos") && stocks.Rows.Count > 0)
                {
                    Cbo_idStock.DataSource = stocks;
                    Cbo_idStock.DisplayMember = "Pk_id_TrasladoProductos"; // Mostrar el ID
                    Cbo_idStock.ValueMember = "Pk_id_TrasladoProductos";
                    Cbo_idStock.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No se encontraron stocks para mostrar.");
                }

                // Llenar ComboBox para Locales
                DataTable locales = capa_Controlador_Logistica.Fun_ObtenerLocales();
                if (locales.Columns.Contains("Pk_ID_LOCAL") && locales.Rows.Count > 0)
                {
                    Cbo_Local.DataSource = locales;
                    Cbo_Local.DisplayMember = "Pk_ID_LOCAL"; // Mostrar el ID
                    Cbo_Local.ValueMember = "Pk_ID_LOCAL";
                    Cbo_Local.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No se encontraron locales para mostrar.");
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
                Cbo_estado.Text = row.Cells["estado"].Value.ToString();
                Cbo_idProducto.Text = row.Cells["Fk_id_producto"].Value.ToString();
                Cbo_idStock.Text = row.Cells["Fk_id_stock"].Value.ToString();
                Cbo_Local.Text = row.Cells["Fk_ID_LOCALES"].Value.ToString();
                

                int numMovimiento = Convert.ToInt32(row.Cells["Pk_id_movimiento"].Value);
                txt_numMovimiento.Text = numMovimiento.ToString();
            }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            CargarSolicitudesenDatagriedView();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            capa_Controlador_Logistica.Pro_ModificarMovimientoInventario(Convert.ToInt32(txt_numMovimiento.Text), Convert.ToInt32(Cbo_estado.Text), Convert.ToInt32(Cbo_idProducto.Text), Convert.ToInt32(Cbo_idStock.Text), Convert.ToInt32(Cbo_Local.Text));
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            capa_Controlador_Logistica.Pro_EliminarMovimiento(Convert.ToInt32(txt_numMovimiento.Text));
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

