using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Evaluacion;

namespace Capa_Vista_Evaluacion
{
    public partial class Frm_Reporte_Evaluacion_Desempenio : Form
    {
        private Controlador controlador; // Instancia del controlador
        public Frm_Reporte_Evaluacion_Desempenio()
        {
            InitializeComponent();
            controlador = new Controlador(); // Inicializar controlador
            this.Load += Frm_Reporte_Evaluacion_Desempenio_Load;
        }

        private void Frm_Reporte_Evaluacion_Desempenio_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }


        private void CargarEmpleados()
        {
            DataTable empleados = controlador.ObtenerEmpleados();
            Cmb_Empleados.DataSource = empleados;
            Cmb_Empleados.DisplayMember = "NombreEmpleado";  // Mostrar nombre completo
            Cmb_Empleados.ValueMember = "IdEmpleado";        // Usar ID como valor
        }

        private void button4_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (Cmb_Empleados.SelectedValue != null)
            {
                int idEmpleado = Convert.ToInt32(Cmb_Empleados.SelectedValue);
                DataTable evaluaciones = controlador.ObtenerEvaluacionesPorEmpleado(idEmpleado);

                // Verifica si se obtuvieron resultados
                if (evaluaciones.Rows.Count > 0)
                {
                    Dgv_Reporte.DataSource = evaluaciones;  // Asignamos el DataTable al DataGridView
                }
                else
                {
                    MessageBox.Show("No se encontraron evaluaciones para el empleado seleccionado.", "Resultado de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado para realizar la búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte frm = new Reporte();
            frm.Show();
        }
    }
}
