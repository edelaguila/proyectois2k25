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
    public partial class Caja: Form
    {
        public Caja()
        {
            InitializeComponent();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de texto
            /* string id = Txt_Id1.Text;
             string vehiculo = Txt_Vehiculo.Text;
             string pesoTotalV = Txt_PesoTotalV.Text;

             string idProd = Txt_Id2.Text;
             string nombreProd = Txt_NombreProd.Text;
             string pesoProd = Txt_PesoProd.Text;

             try
             {
                 // Conexión a la base de datos
                 OdbcConnection connection = conn.Conexion();

                 // Guardar cambios en Tbl_vehiculos
                 string queryVehiculos = "UPDATE Tbl_vehiculos SET marca = ?, pesoTotal = ? WHERE Pk_id_vehiculo = ?";
                 using (OdbcCommand cmdVehiculo = new OdbcCommand(queryVehiculos, connection))
                 {
                     cmdVehiculo.Parameters.AddWithValue("@marca", vehiculo);
                     cmdVehiculo.Parameters.AddWithValue("@pesoTotal", pesoTotalV);
                     cmdVehiculo.Parameters.AddWithValue("@Pk_id_vehiculo", idVehiculo);

                     cmdVehiculo.ExecuteNonQuery();
                 }

                 // Guardar cambios en Tbl_Productos
                 string queryProductos = "UPDATE Tbl_Productos SET nombreProducto = ?, pesoProducto = ? WHERE Pk_id_Producto = ?";
                 using (OdbcCommand cmdProducto = new OdbcCommand(queryProductos, connection))
                 {
                     cmdProducto.Parameters.AddWithValue("@nombreProducto", nombreProd);
                     cmdProducto.Parameters.AddWithValue("@pesoProducto", pesoProd);
                     cmdProducto.Parameters.AddWithValue("@Pk_id_Producto", idProd);

                     cmdProducto.ExecuteNonQuery();
                 }

                 // Cerrar la conexión
                 conn.desconexion(connection);

                 MessageBox.Show("Cambios guardados exitosamente.");
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al guardar los cambios: " + ex.Message);
             }*/
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            // Bloquear los campos de texto para que no se puedan editar
            Txt_monto_deuda.ReadOnly = true;
            Txt_mora.ReadOnly = true;
            Txt_Saldo_restante.ReadOnly = true;

            // Alternativamente, puedes deshabilitar los campos para que no se puedan interactuar
            Txt_monto_deuda.Enabled = false;
            Txt_mora.Enabled = false;
            Txt_Saldo_restante.Enabled = false;

            // Cambiar el fondo a gris para indicar que los campos están bloqueados
            Txt_monto_deuda.BackColor = Color.LightGray;
            Txt_mora.BackColor = Color.LightGray;
            Txt_Saldo_restante.BackColor = Color.LightGray;


            // Llamar al método para limpiar los campos  
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            // Limpia el contenido de cada campo  
            Txt_id_CP.Clear();
            Txt_Nombre.Clear();
            Cbo_Id_factura.SelectedIndex = -1;
            Cbo_id_deuda.SelectedIndex = -1;
            Txt_monto_deuda.Clear();
            Txt_mora.Clear();
            Txt_monto_trans.Clear();
            Txt_Saldo_restante.Clear();
            // Dtp_fecha_reg.Clear();
            Txt_estado.Clear();

            Dtp_fecha_reg.Value = DateTime.Now;
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
