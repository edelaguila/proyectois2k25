using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Carrera;
using static Capa_Vista_Carrera.frm_Promociones;

namespace Capa_Vista_Carrera
{
    public partial class frm_Carrera : Form
    {
        Controlador logica2;
        private int idSeleccionado = 0;
        private int excepcionActiva = 1;
        private int estadoActivo = 1;
        string valorSeleccionado;
        string valorSeleccionado2;
        public frm_Carrera(String idUsuario)
        {
            InitializeComponent();
            logica2 = new Controlador(idUsuario);
            string tabla = "tbl_empleados";
            string campo1 = "pk_clave";
            string campo2 = "empleados_nombre";

            // Llama al método para llenar el ComboBox
            llenarseModulos(tabla, campo1, campo2);
        }

        /*********************************Ismar Leonel Cortez Sanchez -0901-21-560*****************************************/
        /**************************************Combo box inteligente 1*****************************************************/

        public void llenarseModulos(string tabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt2 = logica2.enviar(tabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            cmb_empleado.Items.Clear();

            foreach (DataRow row in dt2.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                cmb_empleado.Items.Add(new ComboBoxItem
                {
                    Value = row[campo1].ToString(),
                    Display = row[campo2].ToString()
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
                coleccion.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));
            }

            cmb_empleado.AutoCompleteCustomSource = coleccion;
            cmb_empleado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_empleado.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Clase auxiliar para almacenar Value y Display
        public class ComboBoxItem
        {
            public string Value { get; set; }
            public string Display { get; set; }

            // Sobrescribir el método ToString para mostrar "ID-Nombre" en el ComboBox
            public override string ToString()
            {
                return $"{Value}-{Display}"; // Formato "ID-Nombre"
            }
        }

        private void cmb_modulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_empleado.SelectedItem != null)
            {
                // Obtener el valor del ValueMember seleccionado
                var selectedItem = (ComboBoxItem)cmb_empleado.SelectedItem;
                string valorSeleccionado = selectedItem.Value;
                // Mostrar el valor en un MessageBox
                MessageBox.Show($"Valor seleccionado: {valorSeleccionado}", "Valor Seleccionado");
            }
        }

        private void cmb_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmb_empleado.SelectedItem != null)
            //{
            //    // Obtener el valor del ValueMember seleccionado
            //    var selectedItem = (ComboBoxItem)cmb_empleado.SelectedItem;
            //    string valorSeleccionado = selectedItem.Value;
            //    // Mostrar el valor en un MessageBox
            //    MessageBox.Show($"Valor seleccionado: {valorSeleccionado}", "Valor Seleccionado");
            //}

            if (cmb_empleado.SelectedItem != null)
            {
                var selectedItem = (ComboBoxItem)cmb_empleado.SelectedItem;
                valorSeleccionado = selectedItem.Value;
                // MessageBox.Show($"Valor seleccionado: {valorSeleccionado}", "Valor Seleccionado");
                // Obtener datos del empleado
                DataRow datos = logica2.ObtenerPuestoYSalario(valorSeleccionado);
                //if (datos != null)
                //{
                //    txt_PuestoActual.Text = datos["puesto"].ToString();
                //    txt_SalarioActual.Text = datos["salario"].ToString();
                //}
                //else
                //{
                //    txt_PuestoActual.Text = "No encontrado";
                //    txt_SalarioActual.Text = "No encontrado";
                //}
            }




        }

        /***************************************************************************************************/

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_empleado.SelectedItem != null)
            {
                var selectedItem = (ComboBoxItem)cmb_empleado.SelectedItem;
                valorSeleccionado = selectedItem.Value;
                 MessageBox.Show($"Valor seleccionado: {valorSeleccionado}", "Valor Seleccionado");
                // Obtener datos del empleado
               
                DataRow datos = logica2.ObtenerPuestoYSalario(valorSeleccionado);
                //if (datos != null)
                //{
                //    txt_PuestoActual.Text = datos["puesto"].ToString();
                //    txt_SalarioActual.Text = datos["salario"].ToString();
                //}
                //else
                //{
                //    txt_PuestoActual.Text = "No encontrado";
                //    txt_SalarioActual.Text = "No encontrado";
                //}
            }
        }
    }
}