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
    public partial class Deuda_Clts : Form
    {
        Capa_Controlador_Cuentas_Corrientes.Controlador controlador = new Capa_Controlador_Cuentas_Corrientes.Controlador();
        public Deuda_Clts()
        {
            InitializeComponent();
            actualizarVistaDeudas();
            cargarClientes();
            cargarCobrador();
           // cargarEfecto();
           // cargarTipoTrans();
            cargarFactura();
            getIdD();
        }
        void getIdD()
        {
            Txt_id_deuda.Text = controlador.getNextIdD();
        }
        private void actualizarVistaDeudas()
        {
            DataTable data = controlador.MostrarDeudas();
            Dgv_deudas.DataSource = data;
            Dgv_deudas.Columns[0].HeaderText = "Pk_id_deuda";
            Dgv_deudas.Columns[1].HeaderText = "Pk_id_clientes";
            Dgv_deudas.Columns[2].HeaderText = "Fk_id_cobrador";
            //Dgv_deudas.Columns[3].HeaderText = "transaccion_tipo";
            //Dgv_deudas.Columns[4].HeaderText = "Efecto";
            Dgv_deudas.Columns[3].HeaderText = "Fk_id_factura";
            Dgv_deudas.Columns[4].HeaderText = "monto_deuda";
            Dgv_deudas.Columns[5].HeaderText = "fecha_inicio_deuda";
            Dgv_deudas.Columns[6].HeaderText = "fecha_vencimiento_deuda";
            Dgv_deudas.Columns[7].HeaderText = "descriptcion_deuda";
            Dgv_deudas.Columns[8].HeaderText = "estado_deuda";

        }
        /*private void cargarEfecto()
        {
            List<string> limpiarTexbox = new List<string>();
            Cbo_Efecto.DataSource = limpiarTexbox;
            List<string> efectoCodes = controlador.listadoEfecto();
            Cbo_Efecto.DataSource = efectoCodes;
        }*/


        private void cargarClientes()
        {
            List<string> limpiarTexbox = new List<string>();
            Cbo_id_clientes.DataSource = limpiarTexbox;
            List<string> clientesCodes = controlador.listadoClientesd();
            Cbo_id_clientes.DataSource = clientesCodes;
        }
        private void cargarCobrador()
        {
            List<string> limpiarTexbox = new List<string>();
            Cbo_id_cobrador.DataSource = limpiarTexbox;
            List<string> cobradorCodes = controlador.listadoCobradord();
            Cbo_id_cobrador.DataSource = cobradorCodes;
        }

      /*  private void cargarTipoTrans()
        {
            List<string> limpiarTexbox = new List<string>();
            Cbo_tipoT.DataSource = limpiarTexbox;
            List<string> cobradorCodes = controlador.listadoTipoTrans();
            Cbo_tipoT.DataSource = cobradorCodes;
        }*/

        private void cargarFactura()
        {
            List<string> limpiarTexbox = new List<string>();
            Cbo_idfactura.DataSource = limpiarTexbox;
            List<string> cobradorCodes = controlador.listadoFactura();
            Cbo_idfactura.DataSource = cobradorCodes;
        }


        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            string idDeuda = Txt_id_deuda.Text.Trim();
            string idFactura = Cbo_idfactura.Text.Trim();
            string idCliente = Cbo_id_clientes.Text.Trim();
            string idCobrador = Cbo_id_cobrador.Text.Trim();
            string monto = Txt_montoDeuda.Text.Trim();
            DateTime fechaI = Dtp_FechaI.Value;
            DateTime fechaV = Dtp_FechaV.Value;
            string descripcion = Txt_Descipcion.Text.Trim();
            string estado = Cbo_estado.Text.Trim();

            controlador.guardarDeudas(idDeuda, idCliente, idCobrador, idFactura, monto, fechaI, fechaV, descripcion, estado);
            actualizarVistaDeudas();
            getIdD();


        }


        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            DataTable data = controlador.queryDeuda(Txt_id_deuda);
            Dgv_deudas.DataSource = data;
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
            Cbo_id_clientes.SelectedIndex = 0;
            Cbo_id_cobrador.SelectedIndex = 0;
            //Cbo_tipoT.SelectedIndex = 0;
            //Cbo_Efecto.SelectedIndex = 0;
            Cbo_idfactura.SelectedIndex = 0;
            Txt_montoDeuda.Text = "";
            //Dtp_FechaV.Text = "";
            //Dtp_FechaV.Text = "";
            Txt_Descipcion.Text = "";
            Cbo_estado.SelectedIndex = 0;

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            controlador.borrarDeuda(Txt_id_deuda);
            actualizarVistaDeudas();
            getIdD();
        }

        private void Dgv_deudas_DoubleClick(object sender, EventArgs e)
        {
            if (Dgv_deudas.CurrentRow.Index != -1)
            {
                Btn_guardar.Enabled = true;
                Btn_editar.Enabled = true;
                Btn_eliminar.Enabled = true;
                Btn_Buscar.Enabled = true;
                Btn_Actualizar.Enabled = true;

                Txt_id_deuda.Text = Dgv_deudas.CurrentRow.Cells[0].Value.ToString();
                Cbo_id_clientes.Text = Dgv_deudas.CurrentRow.Cells[1].Value.ToString();
                Cbo_id_cobrador.Text = Dgv_deudas.CurrentRow.Cells[2].Value.ToString();
                Cbo_idfactura.Text = Dgv_deudas.CurrentRow.Cells[3].Value.ToString();
                Txt_montoDeuda.Text = Dgv_deudas.CurrentRow.Cells[4].Value.ToString();
                Dtp_FechaI.Value = Convert.ToDateTime(Dgv_deudas.CurrentRow.Cells[5].Value);
                Dtp_FechaV.Value = Convert.ToDateTime(Dgv_deudas.CurrentRow.Cells[6].Value);
                Txt_Descipcion.Text = Dgv_deudas.CurrentRow.Cells[7].Value.ToString();
                Cbo_estado.Text = Dgv_deudas.CurrentRow.Cells[8].Value.ToString();
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                int estado = Convert.ToInt32(Cbo_estado.Text.Trim());
                int idFactura = Convert.ToInt32(Cbo_idfactura.Text.Trim());
                int idCliente = Convert.ToInt32(Cbo_id_clientes.Text.Trim());
                int idCobrador = Convert.ToInt32(Cbo_id_cobrador.Text.Trim());
                int idDeuda = Convert.ToInt32(Txt_id_deuda.Text.Trim());
                string monto = Txt_montoDeuda.Text.Trim();
                DateTime fechaI = Dtp_FechaI.Value;
                DateTime fechaV = Dtp_FechaV.Value;
                string descripcion = Txt_Descipcion.Text.Trim();

                // Modificar la transacción con monto como string
                bool resultado = controlador.ModificarTransaccion(
                    idDeuda, idCliente, idCobrador, idFactura, monto, fechaI, fechaV, descripcion, estado
                );

                if (resultado)
                {
                    MessageBox.Show("Transacción modificada exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarVistaDeudas();
                    getIdD();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar la transacción", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        
     
        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Deuda_Clts_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(218, 247, 245);


        }

        private void Lbl_monto_dueda_Click(object sender, EventArgs e)
        {

        }

        private void Btn_reportes_Click(object sender, EventArgs e)
        {
            //ReporteDeudaC
           //frm = new ReporteDeudaC();
           // frm.Show();
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

        private void Cbo_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_mora_TextChanged(object sender, EventArgs e)
        {



        }

        private void Txt_montoDeuda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                if (!string.IsNullOrEmpty(Txt_montoDeuda.Text)) // Evita mostrar el mensaje varias veces
                {
                    MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                e.Handled = true;
            }

            // Solo un punto decimal permitido
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
// Formulario Shelly