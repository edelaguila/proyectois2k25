using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Capacitacion;

namespace Capa_Vista_Capacitacion
{
    public partial class notas_capacitación : Form
    {
        controlador cn = new controlador();
        public notas_capacitación()
        {
            InitializeComponent();

           
        }

        private void tbPorcentaje_Scroll(object sender, EventArgs e)
        {
            lblMostrarporcentaje.Text = tbPorcentaje.Value.ToString() + "%";
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notas_capacitación_Load(object sender, EventArgs e)
        {
            CargarNotas();
            cbNivel.DataSource = cn.CargarNiveles();
            cbNivel.DisplayMember = "Value";
            cbNivel.ValueMember = "Key";


            // ComboBox Empleado
            cbEmpleado.DataSource = cn.CargarEmpleados();
            cbEmpleado.DisplayMember = "Value";
            cbEmpleado.ValueMember = "Key";

            // ComboBox Capacitación
            cbCapacitacion.DataSource = cn.CargarCapacitaciones();
            cbCapacitacion.DisplayMember = "Value";
            cbCapacitacion.ValueMember = "Key";
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {

            txtNota.Text = cn.obtenerSiguienteNota().ToString(); // Mostrar el próximo ID
            cbEmpleado.Text = "";
            cbCapacitacion.Text = "";
            cbNivel.Text = "";
            lblMostrarporcentaje.Text = "0%";


            CambiarEstadoControles();

            Btn_guardar.Enabled = true;
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            // Desenlazar el DataGridView
            dgvNotas.DataSource = null;

            // Obtener el ID correspondiente de cada ComboBox (ahora son int)
            int fkEmpleado = Convert.ToInt32(cbEmpleado.SelectedValue);
            int fkCapacitacion = Convert.ToInt32(cbCapacitacion.SelectedValue);
            int fknivel = Convert.ToInt32(cbNivel.SelectedValue);
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            decimal puntaje = tbPorcentaje.Value;

            // Insertar la nota
            int idGenerado = cn.insertarNota(fkEmpleado, fkCapacitacion, fknivel, puntaje, fecha);

            // Mostrar el ID generado en el TextBox
            txtNota.Text = idGenerado.ToString();

            // Recargar el DataGridView para mostrar la nueva nota
            CargarNotas();



            // Opcional: mostrar mensaje de éxito
            MessageBox.Show("Nota guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Btn_guardar.Enabled = false;

            BloquearEstadoControles();

        }


        private void CambiarEstadoControles()
        {
            cbEmpleado.Enabled = true;
            cbCapacitacion.Enabled = true;
            cbNivel.Enabled = true;
            tbPorcentaje.Enabled = true;
        }

        private void BloquearEstadoControles()
        {
            cbEmpleado.Enabled = false;
            cbCapacitacion.Enabled = false;
            cbNivel.Enabled = false;
            tbPorcentaje.Enabled = false;
        }

        private void CargarNotas()
        {
            // Aquí puedes cargar los datos desde la base de datos y asignarlos al DataGridView
            var datosNotas = cn.mostrarNotas(); // Método que obtiene las notas desde la base de datos
            dgvNotas.DataSource = datosNotas;
        }


        private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que no sea el encabezado
            {
                DataGridViewRow row = dgvNotas.Rows[e.RowIndex];

                // Mostrar ID en TextBox
                txtNota.Text = row.Cells["pk_id_nota"].Value.ToString();  // Aquí mantienes el ID de la nota

                // Seleccionar el Empleado en el ComboBox utilizando el nombre
                string empleado = row.Cells["Empleado"].Value.ToString();  // Accede al nombre del empleado
                cbEmpleado.Text = empleado;  // Asignamos el nombre al ComboBox (si es que quieres mostrarlo directamente)

                // Seleccionar la Capacitacion en el ComboBox utilizando el nombre
                string capacitacion = row.Cells["Capacitacion"].Value.ToString();  // Accede al nombre de la capacitación
                cbCapacitacion.Text = capacitacion;  // Asignamos el nombre al ComboBox

                // Seleccionar el Nivel en el ComboBox utilizando el nombre
                string nivel = row.Cells["Nivel"].Value.ToString();  // Accede al nivel (A, B, C o D)
                cbNivel.Text = nivel;  // Asignamos el nombre al ComboBox

                // Obtener el puntaje de la fila seleccionada como decimal
                var puntaje = row.Cells["notas_puntaje"].Value.ToString();

                // Usar decimal.TryParse para convertir el puntaje
                if (decimal.TryParse(puntaje, out decimal puntajeDecimal))
                {
                    // Redondear el valor decimal a un valor entero entre 0 y 100
                    int puntajeInt = (int)Math.Round(puntajeDecimal);

                    // Limitar el valor del TrackBar a su rango máximo (0 a 100)
                    if (puntajeInt >= tbPorcentaje.Minimum && puntajeInt <= tbPorcentaje.Maximum)
                    {
                        tbPorcentaje.Value = puntajeInt;  // Asignar al TrackBar
                        lblMostrarporcentaje.Text = puntajeInt + "%";  // Actualizar el Label
                    }
                    else
                    {
                        tbPorcentaje.Value = tbPorcentaje.Maximum;  // Asignar el valor máximo si el puntaje es mayor al máximo
                        lblMostrarporcentaje.Text = tbPorcentaje.Maximum + "%";
                    }
                }
                else
                {
                    // Si el puntaje no es válido, asignar un valor predeterminado (ej. 0)
                    tbPorcentaje.Value = 0;
                    lblMostrarporcentaje.Text = "0%";
                }

                // Asignar la Fecha al DateTimePicker
                DateTime fecha = Convert.ToDateTime(row.Cells["notas_fecha"].Value == DBNull.Value ? DateTime.Now : row.Cells["notas_fecha"].Value); // Verificar DBNull
                dtpFecha.Value = fecha;
            }
        }







        private void tbPorcentaje_ValueChanged(object sender, EventArgs e)
        {

            lblMostrarporcentaje.Text = tbPorcentaje.Value.ToString() + "%";
        }

        private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
