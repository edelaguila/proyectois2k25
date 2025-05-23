using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Odbc;
using Capa_Controlador_JDSC; // Para Controlador
using System.IO;

namespace Capa_Vista_JDSC
{
    public partial class MonitoreoAlmacen : Form
    {
        private string idBodega; // Campo para almacenar el ID de la bodega
        Controlador controlador = new Controlador(); // Instancia del controlador

        // Constructor que recibe el ID de la bodega
        public MonitoreoAlmacen()
        {
            InitializeComponent();
            this.idBodega = "1";

            // Cargar información de la bodega
            CargarInformacionBodega(idBodega);

            // Cargar bodegas y productos
            cargarBodegas(); // Cargar primero las bodegas
            cargarProductos(); // Luego cargar los productos

            // Cargar bodegas y productos en auditoría
            cargarBodegasAuditoria();
            cargarProductosAuditoria();
        }

        private void CargarInformacionBodega(string idBodega)
        {
            

            OdbcDataReader dr = controlador.ObtenerExistenciasBodega(idBodega);

            // Verificar si dr es null
            if (dr == null)
            {
                MessageBox.Show("No se pudieron obtener existencias para la bodega seleccionada.");
                return; // Salir del método si no hay datos
            }

            try
            {
                DataTable dtExistencias = new DataTable();
                dtExistencias.Load(dr);
                dgvExistencias.DataSource = dtExistencias;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las existencias: " + ex.Message);
            }
            finally
            {
                // Asegurarse de cerrar el DataReader
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
            }
        }




        // Método para cargar las bodegas en el ComboBox
        private void cargarBodegas()
        {
            List<KeyValuePair<int, string>> bodegas = controlador.listadoBodegas();
            cmbBodega.DataSource = bodegas;
            cmbBodega.DisplayMember = "Value"; // Mostrar el nombre de la bodega
            cmbBodega.ValueMember = "Key"; // Usar el ID de la bodega como valor
        }

        private void cargarBodegasAuditoria()
        {
            List<KeyValuePair<int, string>> bodegas = controlador.listadoBodegas();

            // Depuración
            Console.WriteLine($"Bodegas encontradas: {bodegas.Count}");

            if (bodegas.Count > 0)
            {
                cmbBodegaAuditoria.DataSource = bodegas; // Asigna la lista al ComboBox
                cmbBodegaAuditoria.DisplayMember = "key"; // Mostrar nombre de la bodega
                cmbBodegaAuditoria.ValueMember = "Key"; // Usar el ID de la bodega como valor
            }
            else
            {
                MessageBox.Show("No se encontraron bodegas.");
            }
        }

        private void cargarProductosAuditoria()
        {
            List<KeyValuePair<int, string>> productos = controlador.listadoProductos(); 

            // Depuración
            Console.WriteLine($"Productos encontrados: {productos.Count}");

            if (productos.Count > 0)
            {
                cmbProductoAuditoria.DataSource = productos; // Asigna la lista al ComboBox
                cmbProductoAuditoria.DisplayMember = "key"; // Mostrar nombre del producto
                cmbProductoAuditoria.ValueMember = "Key"; // Usar el ID del producto como valor
            }
            else
            {
                MessageBox.Show("No se encontraron productos.");
            }
        }

        

        private void cargarProductos()
        {
            List<KeyValuePair<int, string>> productos = controlador.listadoProductos(); // Obtén los productos con ID

            // Depuración
            Console.WriteLine($"Productos encontrados: {productos.Count}");

            if (productos.Count > 0)
            {
                cmbProducto.DataSource = productos; // Asigna la lista al ComboBox
                cmbProducto.DisplayMember = "Value"; // Mostrar nombre del producto
                cmbProducto.ValueMember = "Key"; // Usar el ID del producto como valor
            }
            else
            {
                MessageBox.Show("No se encontraron productos."); // Mensaje si no hay productos
            }
        }

        private void btnCargarExistencias_Click(object sender, EventArgs e)
        {
            if (cmbBodega.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una bodega antes de cargar las existencias.");
                return; // Salir del método si no hay selección
            }

            var selectedBodega = (KeyValuePair<int, string>)cmbBodega.SelectedItem; // Obtener el KeyValuePair
            int idBodega = selectedBodega.Key; // Usar la clave como ID de bodega

            DataTable dtExistencias = new DataTable(); // Crear un DataTable para recibir los datos
            try
            {
                controlador.CargarExistencias(idBodega.ToString(), dtExistencias); // Cargar las existencias en el DataTable
                dgvExistencias.DataSource = dtExistencias; // Asignar el DataTable al DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Mostrar cualquier error que ocurra
            }
        }

        private void btnRealizarAuditoria_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que los ComboBoxes tengan un valor seleccionado
                if (cmbBodegaAuditoria.SelectedItem == null || cmbProductoAuditoria.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una bodega y un producto.");
                    return;
                }

                // Obtener valores de los controles con validaciones adecuadas
                int idBodega = Convert.ToInt32(cmbBodegaAuditoria.SelectedValue);
                int idProducto = Convert.ToInt32(cmbProductoAuditoria.SelectedValue);
                DateTime fechaAuditoria = dtpFechaAuditoria.Value;
                string observaciones = txtObservaciones.Text;

                // Validación y conversión de la cantidad registrada
                if (!int.TryParse(txtCantidadRegistrada.Text, out int cantidadRegistrada))
                {
                    MessageBox.Show("La cantidad registrada debe ser un número entero.");
                    return;
                }

                // Validación y conversión de la cantidad física
                if (!int.TryParse(txtCantidadFisica.Text, out int cantidadFisica))
                {
                    MessageBox.Show("La cantidad física debe ser un número entero.");
                    return;
                }

                // Obtener valor del CheckBox como booleano
                bool discrepancia = chkDiscrepanciaDetectada.Checked;

                // Realizar la auditoría a través del controlador
                controlador.RealizarAuditoria(idBodega, idProducto, fechaAuditoria, observaciones, cantidadRegistrada, cantidadFisica, discrepancia, dgvAuditorias);

                // Mostrar mensaje de éxito
                MessageBox.Show("Auditoría realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cargar auditorías en el DataGridView
                controlador.CargarAuditorias(dgvAuditorias);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en el formato de entrada: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar auditoría: " + ex.Message);
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            Reporte_Auditoria reporte = new Reporte_Auditoria();
            reporte.Show();


        }

        private void Btn_ayudaAlmacen_Click(object sender, EventArgs e)
        {

            string idayuda = "8";
            string Ruta = controlador.MRuta(idayuda);
            string sRutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\"));
            string AsRuta = Path.Combine(sRutaProyecto, "Ayuda", "Modulos", "Logistica", "Ayudas_MonitoreoAlmacen", Ruta);
            string AsIndice = controlador.MIndice(idayuda);

            // Validar que la ruta y el índice no estén vacíos
            if (!string.IsNullOrEmpty(AsRuta) && !string.IsNullOrEmpty(AsIndice))
            {
                // Mostrar la ayuda automáticamente cuando se llama a asignarAyuda
                Help.ShowHelp(this, AsRuta, AsIndice);
            }
            else
            {
                MessageBox.Show("La Ruta o el índice de la ayuda están vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
