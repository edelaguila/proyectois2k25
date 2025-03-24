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
            Dgv_deudas.Columns[9].HeaderText = "mora";

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

            controlador.guardarDeudas(Txt_id_deuda, Cbo_id_clientes.Text, Cbo_id_cobrador.Text,  Cbo_idfactura.Text,
                Txt_montoDeuda.Text, Txt_FechaI.Text, Txt_FechaV.Text, Txt_Descipcion.Text, Cbo_estado.Text, Txt_mora.Text);
            actualizarVistaDeudas();
            getIdD();
            CalcularMora();
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
            Txt_FechaI.Text = "";
            Txt_FechaV.Text = "";
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
               // Cbo_tipoT.Text = Dgv_deudas.CurrentRow.Cells[3].Value.ToString();
               // Cbo_Efecto.Text = Dgv_deudas.CurrentRow.Cells[4].Value.ToString();
                Cbo_idfactura.Text = Dgv_deudas.CurrentRow.Cells[3].Value.ToString();
                Txt_montoDeuda.Text = Dgv_deudas.CurrentRow.Cells[4].Value.ToString();
                Txt_FechaI.Text = Dgv_deudas.CurrentRow.Cells[5].Value.ToString();
                Txt_FechaV.Text = Dgv_deudas.CurrentRow.Cells[6].Value.ToString();
                Txt_Descipcion.Text = Dgv_deudas.CurrentRow.Cells[7].Value.ToString();
                Cbo_estado.Text = Dgv_deudas.CurrentRow.Cells[8].Value.ToString();
                Txt_mora.Text = Dgv_deudas.CurrentRow.Cells[9].Value.ToString();
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
                string fechaI = Txt_FechaI.Text.Trim();
                string fechaV = Txt_FechaV.Text.Trim();
                string descripcion = Txt_Descipcion.Text.Trim();
                string mora = Txt_mora.Text.Trim();

                // Modificar la transacción con monto como string
                bool resultado = controlador.ModificarTransaccion(
                    idDeuda, idCliente, idCobrador, idFactura, monto, fechaI, fechaV, descripcion, estado, mora
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
            //Txt_tipoTrans.Enabled = false;
            

        }

        private void Lbl_monto_dueda_Click(object sender, EventArgs e)
        {

        }

        private void Btn_reportes_Click(object sender, EventArgs e)
        {
            ReporteDeudaC
           frm = new ReporteDeudaC();
            frm.Show();
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

            CalcularMora();

        }
        private void CalcularMora()
        {
            try
            {
                decimal montoDeuda = Convert.ToDecimal(Txt_montoDeuda.Text);
                DateTime fechaVencimiento = Convert.ToDateTime(Txt_FechaV.Text);
                DateTime fechaActual = DateTime.Today;
                decimal tasaInteresMoratorio = 0.45m;

             
                int diasAtraso = (fechaActual - fechaVencimiento).Days;

                if (diasAtraso > 0) 
                {
                    decimal mora = ((tasaInteresMoratorio * montoDeuda) / 360) * diasAtraso;

                    // Mostrar resultado en el formulario
                    Txt_mora.Text = mora.ToString("F2"); 
                }
                else
                {
                    Txt_mora.Text = "0.00"; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el cálculo: " + ex.Message);
            }
        }

    }
}
// Formulario Shelly