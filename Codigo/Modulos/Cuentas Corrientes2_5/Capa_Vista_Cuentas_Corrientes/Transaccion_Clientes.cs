using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.ComponentModel;
using System.Windows.Forms;

namespace Capa_Vista_Cuentas_Corrientes
{
    public partial class Transaccion_Clientes : Form
    {
        Capa_Controlador_Cuentas_Corrientes.Controlador controlador = new Capa_Controlador_Cuentas_Corrientes.Controlador();
        //Boolean bConfirmRuta = true;
        public Transaccion_Clientes()
        {
            InitializeComponent();
            actualizarVistaTransacciones();
            cargarClientes();
            cargarDeudas();
            cargarPagos();
            cargarPais();
            getId();
        }
        void getId()
        {
            Txt_id_transaccion.Text = controlador.getNextId();
        }
        private void actualizarVistaTransacciones()
        {
            DataTable data = controlador.MostrarTransacciones();
            Dgv_transacciones.DataSource = data;
            Dgv_transacciones.Columns[0].HeaderText = "Pk_id_transaccion";
            Dgv_transacciones.Columns[1].HeaderText = "Fk_id_clientes";
            Dgv_transacciones.Columns[2].HeaderText = "Fk_id_pais";
            Dgv_transacciones.Columns[3].HeaderText = "fecha_transaccion";
            Dgv_transacciones.Columns[4].HeaderText = "cuenta_transaccion";
            Dgv_transacciones.Columns[5].HeaderText = "cuotas_transaccion";
            Dgv_transacciones.Columns[6].HeaderText = "Fk_id_deuda";
            Dgv_transacciones.Columns[7].HeaderText = "monto_deuda";
            Dgv_transacciones.Columns[8].HeaderText = "monto_transaccion";
            Dgv_transacciones.Columns[9].HeaderText = "saldo_pendiente";
            Dgv_transacciones.Columns[10].HeaderText = "Fk_id_pago";
            Dgv_transacciones.Columns[11].HeaderText = "tipo_moneda";
            Dgv_transacciones.Columns[12].HeaderText = "serie_transaccion";
            Dgv_transacciones.Columns[13].HeaderText = "estado_transaccion"; 
        }
        private void Lbl_id_deuda_Click(object sender, EventArgs e)
        {

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            controlador.guardarTransaccion(Txt_id_transaccion, Cbo_id_clientes.Text, Cbo_id_pais.Text, Dtp_fecha.Text, Cbo_NoDeudas.Text, 
                Cbo_NoPago.Text, Txt_cuentaTransaccion.Text, Txt_monto_deuda.Text, Txt_monto_trans.Text, Txt_SaldoPendiente.Text, 
                Txt_cuota.Text, Txt_tipoMoneda.Text, Txt_Serie.Text, Txt_estadoT.Text);
            actualizarVistaTransacciones();
            getId();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_transacciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dgv_transacciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dgv_transacciones_DoubleClick(object sender, EventArgs e)
        {
            //se habilita la función de modificar y eliminar para el reporte seleccionado 
           /* if (Dgv_transacciones.CurrentRow.Index != -1)
            {
                Btn_Guardar.Enabled = false;
                Btn_Modificar.Enabled = true;
                Btn_Eliminar.Enabled = true;

                Txt_IDReporte.Text = Dgv_Regreporteria.CurrentRow.Cells[0].Value.ToString();
                Txt_Ruta.Text = Dgv_Regreporteria.CurrentRow.Cells[1].Value.ToString();
                Txt_NombreA.Text = Dgv_Regreporteria.CurrentRow.Cells[2].Value.ToString();
                Cbo_Aplicacion.Text = Dgv_Regreporteria.CurrentRow.Cells[3].Value.ToString();
                Cbo_Estado.Text = Dgv_Regreporteria.CurrentRow.Cells[4].Value.ToString();
            }*/
        }

        private void cargarDeudas()
        {
            List<string> limpiarTexbox = new List<string>();
            Cbo_NoDeudas.DataSource = limpiarTexbox;
            List<string> deudasCodes = controlador.listadoDeuda();
            Cbo_NoDeudas.DataSource = deudasCodes;
        }
        private void cargarPagos()
        {
            List<string> limpiarTexbox = new List<string>();
            Cbo_NoPago.DataSource = limpiarTexbox;
            List<string> pagosCodes = controlador.listadoPagos();
            Cbo_NoPago.DataSource = pagosCodes;
        }
        private void cargarClientes()
        {
            List<string> limpiarTexbox = new List<string>();
            Cbo_id_clientes.DataSource = limpiarTexbox;
            List<string> clientesCodes = controlador.listadoClientes();
            Cbo_id_clientes.DataSource = clientesCodes;
        }
        private void cargarPais()
        {
            List<string> limpiarTexbox = new List<string>();
            Cbo_id_pais.DataSource = limpiarTexbox;
            List<string> paisCodes = controlador.listadoPais();
            Cbo_id_pais.DataSource = paisCodes;
        }
    }
}
