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

namespace Capa_Vista_Carrera
{
    public partial class frm_Promociones : Form
    {
        Controlador logica2;
        public frm_Promociones(String idUsuario)
        {
            InitializeComponent();
            logica2 = new Controlador(idUsuario);
            //idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();
            ///*********Prueba con la tabla inicial*********/
            //string[] alias = { "Id_Promocion", "fk_clave_empleado", "fecha", "Puesto Actual", "Salario Actual","Puesto Nuevo", "Salario Nuevo","Motivo","estado" };
            //navegador1.AsignarAlias(alias);
            //navegador1.AsignarSalida(this);
            //navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#ffd96b"));
            //navegador1.AsignarColorFuente(Color.Black);
            //navegador1.ObtenerIdAplicacion("1000");
            //navegador1.AsignarAyuda("1");
            //navegador1.ObtenerIdUsuario(idUsuario);
            //navegador1.AsignarTabla("tbl_promociones");
            //navegador1.AsignarNombreForm("Promociones");

            /////********Valores foraneos en Combobox************************/

            //navegador1.AsignarComboConTabla("tbl_empleados", "pk_clave", "empleados_nombre", 1);

            /////**************************************************/

            ///////************Se muestre en el dgv los nombres y no los numeros*******/

            ////navegador1.AsignarForaneas("Tbl_usuario", "DPI_usuario", "Fk_id_usuario", "Pk_id_usuario");
            ////navegador1.AsignarForaneas("Tbl_oficina", "nombre_oficina", "Fk_id_oficina", "Pk_id_oficina");
            ////navegador1.AsignarForaneas("Tbl_empleado", "nombre_empleado", "Fk_id_empleado", "Pk_id_empleado");


            string tabla = "tbl_empleados";
            string campo1 = "pk_clave";
            string campo2 = "empleados_nombre";


            // Llama al método para llenar el ComboBox
            llenarseModulos(tabla, campo1, campo2);
            //llenarseApli(tablaApli, campo1Apli, campo2Apli);

            // Asocia el evento SelectedIndexChanged después de poblar el ComboBox
            cmb_empleado.SelectedIndexChanged += new EventHandler(cmb_modulo_SelectedIndexChanged);
            //Cmb_aplicacion.SelectedIndexChanged += new EventHandler(cmb_apli_SelectedIndexChanged2);


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
        /***************************************************************************************************/


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void frm_Promociones_Load(object sender, EventArgs e)
        {
           cmb_empleado.DropDownStyle = ComboBoxStyle.DropDownList;
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
                string valorSeleccionado = selectedItem.Value;

                // Obtener datos del empleado
                DataRow datos = logica2.ObtenerPuestoYSalario(valorSeleccionado);
                if (datos != null)
                {
                    txt_PuestoActual.Text = datos["puesto"].ToString();
                    txt_SalarioActual.Text = datos["salario"].ToString();
                }
                else
                {
                    txt_PuestoActual.Text = "No encontrado";
                    txt_SalarioActual.Text = "No encontrado";
                }
            }




        }
    }
}
