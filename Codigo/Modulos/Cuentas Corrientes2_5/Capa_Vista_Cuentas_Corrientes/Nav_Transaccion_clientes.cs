using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Cuentas_Corrientes
{
    public partial class Nav_Transaccion_clientes : Form
    {
        public Nav_Transaccion_clientes(string idUsuario)
        {
            InitializeComponent();
            string[] alias = { "id_transaccion", "id_clientes", "id_pais", "id_paifecha_transaccion",
            "cuenta", "cuotas", "id_deuda", "deuda", "transaccion",
            "saldo_pendiente", "id_pago", "tipo_moneda", "serie", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.CadetBlue);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("Tbl_Transaccion_cliente");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Transaccion de Clientes");

            // Configurar el DataGridView para que responda a clics en las celdas
            navegador1.Dgv_Informacion.CellClick += Dgv_Transacciones_CellClick; // Asegúrate de que DgvAlmacenes esté definido
        }

        // Evento que se dispara al hacer clic en una celda del DataGridView
        private void Dgv_Transacciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la fila seleccionada es válida
            if (e.RowIndex >= 0)
            {
                // Obtener datos de la fila seleccionada, por ejemplo, el ID de la bodega
                DataGridViewRow row = navegador1.Dgv_Informacion.Rows[e.RowIndex];
                string idTransaccion = row.Cells["Pk_id_transaccion"].Value.ToString();  // Asegúrate de que el nombre del campo sea correcto

                Transaccion_Clientes transaccion = new Transaccion_Clientes();// agregar string idTransaccion
                transaccion.Show();
            }
        }

    }
}
