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
        private bool modoEdicion = false; // False = Nuevo, True = Editar

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
            txtBuscar.Visible = false;

            DialogResult resultado = MessageBox.Show(
           "¿Seguro que desea salir?",
             "Salir del formulario",
          MessageBoxButtons.YesNo,
           MessageBoxIcon.Question
                    );

            // Si el usuario confirma (presiona Sí)
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void notas_capacitación_Load(object sender, EventArgs e)
        {
            CargarNotas();
            dtpFecha.Value = DateTime.Today;
            dtpFecha.MaxDate = DateTime.Today;
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
            txtBuscar.Visible = false;

            dgvNotas.Enabled = false;
            LimpiarControles();


            CambiarEstadoControles();

            Btn_guardar.Enabled = true;
            Btn_cancelar.Enabled = true;
            Btn_editar.Enabled = false;
            Btn_eliminar.Enabled = false;

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            txtBuscar.Visible = false;

            // Validar que todos los campos estén llenos
            if (cbEmpleado.SelectedIndex == -1 || cbCapacitacion.SelectedIndex == -1 || cbNivel.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Desenlazar el DataGridView
            dgvNotas.DataSource = null;

            // Obtener datos
            int fkEmpleado = Convert.ToInt32(cbEmpleado.SelectedValue);
            int fkCapacitacion = Convert.ToInt32(cbCapacitacion.SelectedValue);
            int fknivel = Convert.ToInt32(cbNivel.SelectedValue);
            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
            decimal puntaje = tbPorcentaje.Value;

            if (modoEdicion)
            {
                // Modo Edición
                int idNota = int.Parse(txtNota.Text);

                bool actualizado = cn.editarNota(idNota, fkEmpleado, fkCapacitacion, fknivel, puntaje, fecha);

                if (actualizado)
                {
                    MessageBox.Show("Nota actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la nota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Modo Nuevo
                int idGenerado = cn.insertarNota(fkEmpleado, fkCapacitacion, fknivel, puntaje, fecha);

                txtNota.Text = idGenerado.ToString();

                MessageBox.Show("Nota guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Recargar DGV
            CargarNotas();

            // Limpiar y bloquear
            BloquearEstadoControles();
            LimpiarControles();
            Btn_guardar.Enabled = false;
            Btn_cancelar.Enabled = false;
            dgvNotas.Enabled = true;
            modoEdicion = false; // Volver al modo normal
        }



        private void CambiarEstadoControles()
        {
            cbEmpleado.Enabled = true;
            cbCapacitacion.Enabled = true;
            cbNivel.Enabled = true;
            tbPorcentaje.Enabled = true;
            dtpFecha.Enabled = true;
        }

        private void BloquearEstadoControles()
        {
            cbEmpleado.Enabled = false;
            cbCapacitacion.Enabled = false;
            cbNivel.Enabled = false;
            tbPorcentaje.Enabled = false;
            dtpFecha.Enabled = false;
        }

        private void CargarNotas()
        {
            // Aquí puedes cargar los datos desde la base de datos y asignarlos al DataGridView
            var datosNotas = cn.mostrarNotas(); // Método que obtiene las notas desde la base de datos
            dgvNotas.DataSource = datosNotas;
        }


        private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Btn_editar.Enabled = true;
            Btn_eliminar.Enabled = true;

            if (e.RowIndex >= 0) // Asegúrate de que no sea el encabezado
            {
                DataGridViewRow row = dgvNotas.Rows[e.RowIndex];

                // Verificar que la fila no sea nueva (fila del asterisco)
                if (row.IsNewRow) return;

                // Mostrar ID en TextBox
                txtNota.Text = row.Cells["pk_id_nota"].Value?.ToString();

                // Empleado
                cbEmpleado.Text = row.Cells["Empleado"].Value?.ToString();

                // Capacitacion
                cbCapacitacion.Text = row.Cells["Capacitacion"].Value?.ToString();

                // Nivel
                cbNivel.Text = row.Cells["Nivel"].Value?.ToString();

                // Puntaje
                var puntaje = row.Cells["notas_puntaje"].Value?.ToString();
                if (decimal.TryParse(puntaje, out decimal puntajeDecimal))
                {
                    int puntajeInt = (int)Math.Round(puntajeDecimal);
                    tbPorcentaje.Value = Math.Max(tbPorcentaje.Minimum, Math.Min(puntajeInt, tbPorcentaje.Maximum));
                    lblMostrarporcentaje.Text = tbPorcentaje.Value + "%";
                }
                else
                {
                    tbPorcentaje.Value = 0;
                    lblMostrarporcentaje.Text = "0%";
                }

                // Fecha con validación robusta
                object celdaFecha = row.Cells["notas_fecha"].Value;

                if (celdaFecha != null && celdaFecha != DBNull.Value)
                {
                    if (DateTime.TryParse(celdaFecha.ToString(), out DateTime fecha))
                    {
                        if (fecha >= dtpFecha.MinDate && fecha <= dtpFecha.MaxDate)
                            dtpFecha.Value = fecha;
                        else
                            dtpFecha.Value = DateTime.Now;
                    }
                    else
                    {
                        dtpFecha.Value = DateTime.Now;
                    }
                }
                else
                {
                    dtpFecha.Value = DateTime.Now;
                }
            }
        }







        private void tbPorcentaje_ValueChanged(object sender, EventArgs e)
        {

            lblMostrarporcentaje.Text = tbPorcentaje.Value.ToString() + "%";
        }

        private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            txtBuscar.Visible = false;

            DialogResult resultado = MessageBox.Show(
            "¿Quiere cancelar la operación en curso?",
              "Confirmar cancelación",
           MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
                     );

            // Si el usuario confirma (presiona Sí)
            if (resultado == DialogResult.Yes)
            {
                if (txtBuscar.Visible == true)
                {
                    txtBuscar.Visible = false;
                    CargarNotas();
                    Btn_editar.Enabled = true;
                    Btn_eliminar.Enabled = true;
                    Btn_guardar.Enabled = true;
                    

                }
                if (txtBuscar.Visible == false){
                    BloquearEstadoControles();

                    LimpiarControles();
                    Btn_guardar.Enabled = false;
                    Btn_cancelar.Enabled = false;
                    Btn_editar.Enabled = false;
                    Btn_eliminar.Enabled = false;

                    CargarNotas();
                    dgvNotas.Enabled = true;
                }
                
                
            }


        }

        private void LimpiarControles()
        {
            txtNota.Text = cn.obtenerSiguienteNota().ToString(); // Mostrar el próximo ID
            cbEmpleado.SelectedIndex = -1;
            cbCapacitacion.SelectedIndex = -1;
            cbNivel.SelectedIndex = -1;
            tbPorcentaje.Value = 0;
            lblMostrarporcentaje.Text = "0%";
            dtpFecha.MaxDate = DateTime.Today;

        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            txtBuscar.Visible = false;

            Btn_nuevo.Enabled = false;
            Btn_eliminar.Enabled = false;
            if (string.IsNullOrEmpty(txtNota.Text))
            {
                MessageBox.Show("Seleccione una nota para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            modoEdicion = true; // Ahora estamos editando

            // Habilitar los controles para editar
            CambiarEstadoControles();

            // Activar botón Guardar
            Btn_guardar.Enabled = true;
            Btn_cancelar.Enabled = true;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            txtBuscar.Visible = false;
            if (dgvNotas.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar esta nota?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    // Obtener el ID de la fila seleccionada
                    int idNota = Convert.ToInt32(dgvNotas.SelectedRows[0].Cells["pk_id_nota"].Value);

                    // Llamar al controlador
                    bool eliminado = cn.EliminarNota(idNota);

                    if (eliminado)
                    {
                        MessageBox.Show("Nota eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarNotas(); // Recargar el DataGridView
                        LimpiarControles(); // Limpiar campos si lo deseas
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar la nota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Visible = true;
            Btn_cancelar.Enabled = true;
            Btn_editar.Enabled = false;
            Btn_eliminar.Enabled = false;
            Btn_guardar.Enabled = false;


        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            txtBuscar.Visible = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(texto))
            {
                CargarNotas(); // muestra todos si no hay texto
            }
            else
            {
                dgvNotas.DataSource = cn.buscarNotas(texto); // cn = tu instancia del controlador
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
