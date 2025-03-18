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
using Capa_Controlador_AmmyCatun;

namespace Capa_Vista_AmmyCatun
{
    public partial class Transporte : Form
    {
        Capa_Controlador_AmmyCatun.ControladorVehiculo controlador = new Capa_Controlador_AmmyCatun.ControladorVehiculo();
        public Transporte()
        {
            InitializeComponent();
            getId();
            CargarDatosGrid(); // Load data into the DataGridView
        }
        void getId()
        {
            Txt_ID.Text = controlador.getNextId().ToString();
        }

        private void CargarDatosGrid()
        {

            DataTable dt = controlador.CargarVehiculos(); // Método que debes crear en Controlador
            Dgv_Vehiculo.DataSource = dt;
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {

            CargarDatosGrid(); // Reload data in the DataGridView
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            ControladorVehiculo controladorVehiculo = new ControladorVehiculo();

            // Recopila los datos ingresados en los controles del formulario
            string sNumeroPlaca = Txt_Placa.Text;
            string sMarca = Txt_Marca.Text;
            string sColor = Txt_Color.Text;
            string sDescripcion = Txt_Desc.Text;
            string sHoraLlegada = Txt_HLL.Text; // Asumiendo formato "HH:mm"
            string sHoraSalida = Txt_HS.Text; // Asumiendo formato "HH:mm"
            double doPesoTotal;
            int iIdChofer;
            int iIdVehiculo;

            // Validación de los datos ingresados
            if (!double.TryParse(Txt_Total.Text, out doPesoTotal) || doPesoTotal <= 0)
            {
                MessageBox.Show("Por favor, ingresa un peso total válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(Txt_ID.Text, out iIdChofer) || iIdChofer <= 0)
            {
                MessageBox.Show("Por favor, ingresa un ID de chofer válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(Txt_IDVeh.Text, out iIdVehiculo) || iIdChofer <= 0)
            {
                MessageBox.Show("Por favor, ingresa un ID de vehículo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación del formato de hora
            if (!TimeSpan.TryParse(sHoraLlegada, out _) || !TimeSpan.TryParse(sHoraSalida, out _))
            {
                MessageBox.Show("Por favor, ingresa un formato de hora válido (HH:mm).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show("¿Está seguro de que desea modificar al vehículo con ID " + iIdChofer + "?",
                                                     "Confirmar modificación",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                // Llama al método para guardar el vehículo
                controladorVehiculo.modificarVehiculo(iIdVehiculo, sNumeroPlaca, sMarca, sColor, sDescripcion,
                                                                     sHoraLlegada, sHoraSalida, doPesoTotal, iIdChofer);
            }
        }
        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {

            ControladorVehiculo controladorVehiculo = new ControladorVehiculo();

            // Recopila los datos ingresados en los controles del formulario
            string sNumeroPlaca = Txt_Placa.Text;
            string sMarca = Txt_Marca.Text;
            string sColor = Txt_Color.Text;
            string sDescripcion = Txt_Desc.Text;
            string sHoraLlegada = Txt_HLL.Text; // Asumiendo formato "HH:mm"
            string sHoraSalida = Txt_HS.Text; // Asumiendo formato "HH:mm"
            double doPesoTotal;
            int iIdChofer;

            // Validación de los datos ingresados
            if (!double.TryParse(Txt_Total.Text, out doPesoTotal) || doPesoTotal <= 0)
            {
                MessageBox.Show("Por favor, ingresa un peso total válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(Txt_ID.Text, out iIdChofer) || iIdChofer <= 0)
            {
                MessageBox.Show("Por favor, ingresa un ID de chofer válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación del formato de hora
            if (!TimeSpan.TryParse(sHoraLlegada, out _) || !TimeSpan.TryParse(sHoraSalida, out _))
            {
                MessageBox.Show("Por favor, ingresa un formato de hora válido (HH:mm).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llama al método para guardar el vehículo
            controladorVehiculo.guardarVehiculo(sNumeroPlaca, sMarca, sColor, sDescripcion,
                                                                 sHoraLlegada, sHoraSalida, doPesoTotal, iIdChofer);



        }


        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            {
                string sIdVehiculo = Txt_IDVeh.Text;

                if (string.IsNullOrWhiteSpace(sIdVehiculo))
                {
                    MessageBox.Show("Por favor, ingrese un ID de vehículo para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar al vehículo con ID " + sIdVehiculo + "?",
                                                     "Confirmar eliminación",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    controlador.eliminarVehiculo(sIdVehiculo);
                    getId(); // Actualiza el ID después de eliminar
                }
            }
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            //Abrir Formulario

            /*nombre del formulario*/
            Reporte_Transporte reporte = new Reporte_Transporte();
            reporte.Show();
        }
    
        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            string idayuda = "2";
            string Ruta = controlador.MRuta(idayuda);
            string sRutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\"));
            string AsRuta = Path.Combine(sRutaProyecto, "Ayuda", "AyudaTransporte", Ruta);
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

        private void Txt_HS_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Peso_Click(object sender, EventArgs e)
        {

        }
    }
}

      