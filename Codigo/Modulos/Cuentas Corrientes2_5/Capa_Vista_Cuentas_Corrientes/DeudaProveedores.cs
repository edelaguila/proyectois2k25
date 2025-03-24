using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Cuentas_Corrientes
{
    public partial class DeudaProveedores : Form
    {
        Capa_Controlador_Cuentas_Corrientes.Controlador controlador = new Capa_Controlador_Cuentas_Corrientes.Controlador();
        public DeudaProveedores()
        {
            InitializeComponent();
            actualizarVistaDeudas();
            cargarProveedor();
            cargarTipoTrans();
            cargarFactura();
            cargarEfecto();
            getIdD();
        }
        void getIdD()
        {
            Txt_id_deuda.Text = controlador.getNextIdDP();
        }
        private void actualizarVistaDeudas()
        {
            DataTable data = controlador.MostrarDeudasP();
            Dgv_deudas.DataSource = data;
            Dgv_deudas.Columns[0].HeaderText = "No. Deuda";
            Dgv_deudas.Columns[1].HeaderText = "No. Proveedor";
            Dgv_deudas.Columns[2].HeaderText = "Tipo_Transaccion";
            Dgv_deudas.Columns[3].HeaderText = "Efecto";
            Dgv_deudas.Columns[4].HeaderText = "Id_Factura";
            Dgv_deudas.Columns[5].HeaderText = "Monto Deuda";
            Dgv_deudas.Columns[6].HeaderText = "Fecha Inicio";
            Dgv_deudas.Columns[7].HeaderText = "Fecha Vencimiento";
            Dgv_deudas.Columns[8].HeaderText = "Descriptcion";
            Dgv_deudas.Columns[9].HeaderText = "Estado";
        }

        private void cargarEfecto()
        {
            List<string> limpiarTexbox = new List<string>();
            Cbo_efectoT.DataSource = limpiarTexbox;
            List<string> efectoCodes = controlador.listadoEfectoP();
            Cbo_efectoT.DataSource = efectoCodes;
        }
        private void cargarProveedor()
        {
            List<string> limpiarTexbox = new List<string>();
            Cbo_id_proveedor.DataSource = limpiarTexbox;
            List<string> clientesCodes = controlador.listadoProveedor();
            Cbo_id_proveedor.DataSource = clientesCodes;
        }
        private void cargarTipoTrans()
        {
            List<string> limpiarTexbox = new List<string>();
            Cbo_Tipotrans.DataSource = limpiarTexbox;
            List<string> cobradorCodes = controlador.listadoTipoTransP();
            Cbo_Tipotrans.DataSource = cobradorCodes;
        }

        private void cargarFactura()
        {
            List<string> limpiarTexbox = new List<string>();
            Cbo_idfactura.DataSource = limpiarTexbox;
            List<string> cobradorCodes = controlador.listadoFacturaP();
            Cbo_idfactura.DataSource = cobradorCodes;
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            
            controlador.guardarDeudasProv(Txt_id_deuda, Cbo_id_proveedor.Text, Cbo_Tipotrans.Text, Cbo_efectoT.Text, Cbo_idfactura.Text,
            Txt_montoDeuda.Text, Txt_fechaI.Text, Txt_fechaV.Text, Txt_Descipcion.Text, Cbo_estado.Text);
            actualizarVistaDeudas();
            getIdD();
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            actualizarVistaDeudas();
            getIdD();

            Btn_guardar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_eliminar.Enabled = true;
            Btn_Buscar.Enabled = true;
            Btn_Actualizar.Enabled = true;

            Txt_id_deuda.Text = "";
            Cbo_id_proveedor.SelectedIndex = 0;
            Cbo_Tipotrans.SelectedIndex = 0;
            Cbo_efectoT.SelectedIndex = 0;
            Cbo_idfactura.SelectedIndex = 0;
            Txt_montoDeuda.Text = "";
            Txt_fechaI.Text = "";
            Txt_fechaV.Text = "";
            Txt_Descipcion.Text = "";
            Cbo_estado.SelectedIndex = 0;
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (Dgv_deudas.SelectedRows.Count > 0)
            {

                Txt_id_deuda.Text = Dgv_deudas.CurrentRow.Cells["Pk_id_deuda"].Value.ToString();
                Cbo_id_proveedor.Text = Dgv_deudas.CurrentRow.Cells["Fk_id_proveedor"].Value.ToString();
                Cbo_Tipotrans.Text = Dgv_deudas.CurrentRow.Cells["transaccion_tipo"].Value.ToString();
                Cbo_efectoT.Text = Dgv_deudas.CurrentRow.Cells["Efecto_trans"].Value.ToString();
                Cbo_idfactura.Text = Dgv_deudas.CurrentRow.Cells["Fk_id_factura"].Value.ToString();
                Txt_montoDeuda.Text = Dgv_deudas.CurrentRow.Cells["deuda_monto"].Value.ToString();
                Txt_fechaI.Text = Dgv_deudas.CurrentRow.Cells["deuda_fecha_inicio"].Value.ToString();
                Txt_fechaV.Text = Dgv_deudas.CurrentRow.Cells["deuda_fecha_vencimiento"].Value.ToString();
                Txt_Descipcion.Text = Dgv_deudas.CurrentRow.Cells["deuda_descripcion"].Value.ToString();
                Cbo_estado.Text = Dgv_deudas.CurrentRow.Cells["deuda_estado"].Value.ToString();

                controlador.esEdicion = true;
                controlador.idDeudaPSeleccionada = Txt_id_deuda.Text;

            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            controlador.borrarDeudaP(Txt_id_deuda);
            actualizarVistaDeudas();
            getIdD();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            DataTable data = controlador.queryDeudaP(Txt_id_deuda);
            Dgv_deudas.DataSource = data;
        }

        private void DeudaProveedores_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Ayudas_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la ruta del directorio del ejecutable
                string sexecutablePath = AppDomain.CurrentDomain.BaseDirectory;

                // Retroceder a la carpeta del proyecto
                string sprojectPath = Path.GetFullPath(Path.Combine(sexecutablePath, @"..\..\"));
                //MessageBox.Show("1" + sprojectPath);


                string sayudaFolderPath = Path.Combine(sprojectPath, "AyudaCuentasCorrientes");


                // Busca el archivo .chm en la carpeta "Ayuda_Seguridad"
                string spathAyuda = FindFileInDirectory(sayudaFolderPath, "AyudaReportes.chm");

                // Verifica si el archivo existe antes de intentar abrirlo
                if (!string.IsNullOrEmpty(spathAyuda))
                {
                    // Abre el archivo de ayuda .chm en la sección especificada
                    Help.ShowHelp(null, spathAyuda, "AyudaRep.html");
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


        private void Btn_reportes_Click(object sender, EventArgs e)
        {
          ReporteDeudaP
           frm = new ReporteDeudaP();
           frm.Show();
        }
    }
}
