using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO; // Necesario para Directory, File, Path y SearchOption
using Capa_Controlador_HorasExtras;
using Capa_Vista_Nominas;


namespace Capa_Vista_HorasExtras
{
    public partial class frm_horasextra : Form

    {

        //*******************************Kateryn De Leon************************************************
        private readonly Controlador controlador = new Controlador();
        

        public frm_horasextra()  {

            InitializeComponent();
            proCargarMeses();
            Cbo_mes.SelectedIndex = -1;  // Inicia sin ninguna selección para evitar disparos innecesarios
            proCargarEmpleados();
            Cbo_empleado.SelectedIndexChanged += proCbo_empleado_SelectedIndexChanged;

         }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // Método para llenar el ComboBox con los meses del año
        private void proCargarMeses()
        {
            // Lista de meses 
            string[] sMeses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            // Agregar los meses al ComboBox
            Cbo_mes.Items.AddRange(sMeses);

            // Seleccionar el primer mes como predeterminado
            Cbo_mes.SelectedIndex = 0;
        }

        private void proCargarEmpleados()
        {
            List<string> empleados = controlador.funObtenerEmpleados();

            Cbo_empleado.Items.Clear();
            Cbo_empleado.Items.AddRange(empleados.ToArray());
            Cbo_empleado.SelectedIndex = -1; // Dejar sin seleccionar al inicio
        }



        // Declarar el ToolTip en la clase
        private ToolTip toolTipmes = new ToolTip();

        // Declarar el ToolTip en la clase
        private ToolTip toolTiphoras = new ToolTip();
        private void proCbo_mes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_mes.SelectedIndex != -1 && Cbo_empleado.SelectedIndex != -1)
            {
                string sMesSeleccionado = Cbo_mes.SelectedItem.ToString();
                string sEmpleadoSeleccionado = Cbo_empleado.SelectedItem.ToString();
                decimal deTotalHorasExtras = controlador.funObtenerHorasExtras(sEmpleadoSeleccionado, sMesSeleccionado);

                // Establece el formato en quetzales "Q"
                CultureInfo Quetzal = new CultureInfo("es-GT");


                Txt_calculohoras.Text = deTotalHorasExtras.ToString("C2", Quetzal); // Formato de moneda Quetzal

              
                // Mostrar el ToolTip con el mes seleccionado
                toolTipmes.SetToolTip(Cbo_mes, "Mes seleccionado: " + sMesSeleccionado);

                // Mostrar el ToolTip con el calculo de horas extras
                toolTiphoras.SetToolTip(Txt_calculohoras, "Calculo de Horas Extras ");
            }
         }
        //************************************************************************************


        // Declarar el ToolTip en la clase
        private ToolTip toolTipEmpleado = new ToolTip();

        private void proCbo_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_empleado.SelectedIndex != -1)
            {
                string sEmpleadoSeleccionado = Cbo_empleado.SelectedItem.ToString();

                // Mostrar el ToolTip con el nombre del empleado seleccionado
                toolTipEmpleado.SetToolTip(Cbo_empleado, "Empleado seleccionado: " + sEmpleadoSeleccionado);


                // Llamar al método que carga los meses del empleado
                proCargarMesesEmpleado(sEmpleadoSeleccionado);
               
            }
        }


        private void proCargarMesesEmpleado(string sEmpleado)
        {
            Cbo_mes.Items.Clear();
            List<string> sMeses = controlador.funObtenerMesesPorEmpleado(sEmpleado);
            Cbo_mes.Items.AddRange(sMeses.ToArray());
            Cbo_mes.SelectedIndex = -1; // Inicia sin selección
        }


        // Declarar el ToolTip en el boton Ayuda
        private ToolTip toolTipAyuda = new ToolTip();

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            // Mostrar el ToolTip en el boton ayuda
            toolTipAyuda.SetToolTip(Btn_ayuda, " Documento de ayuda " );

            // Obtener la ruta del directorio del ejecutable
            string sExecutablePath = AppDomain.CurrentDomain.BaseDirectory;

            // Retroceder a la carpeta del proyecto
            string sProjectPath = Path.GetFullPath(Path.Combine(sExecutablePath, @"..\..\..\..\..\..\Ayuda\Modulos\Nominas\"));
          //  MessageBox.Show("1" + sProjectPath);


            string sAyudaFolderPath = Path.Combine(sProjectPath, "AyudaHorasExtras");

            string sPathAyuda = funFindFileInDirectory(sAyudaFolderPath, "AyudaHoras.chm");

            // Verifica si el archivo existe antes de intentar abrirlo
            if (!string.IsNullOrEmpty(sPathAyuda))
            {
               // MessageBox.Show("El archivo sí está.");
                // Abre el archivo de ayuda .chm en la sección especificada
                Help.ShowHelp(null, sPathAyuda, "HorasExtras.html");
            }
            else
            {
                // Si el archivo no existe, muestra un mensaje de error
                MessageBox.Show("El archivo de ayuda no se encontró.");
            }

        }

        private string funFindFileInDirectory(string sDirectory, string sFileName)
        {
            try
            {
                // Verificamos si la carpeta existe
                if (Directory.Exists(sDirectory))
                {
                    // Buscamos el archivo .chm en la carpeta
                    string[] sFiles = Directory.GetFiles(sDirectory, "*.chm", SearchOption.TopDirectoryOnly);

                    // Si encontramos el archivo, verificamos si coincide con el archivo que se busca y retornamos su ruta
                    foreach (var file in sFiles)
                    {
                        if (Path.GetFileName(file).Equals(sFileName, StringComparison.OrdinalIgnoreCase))
                        {
                           // MessageBox.Show("Archivo encontrado: " + file);
                            return file;
                        }
                    }
                }
                else
                {   //Mensaje de No se encontro la carpeta
                   // MessageBox.Show("No se encontró la carpeta: " + sDirectory);
                }
            }
            catch (Exception ex)
            {       //Mensaje de error al buscar el archivo
                MessageBox.Show("Error al buscar el archivo: " + ex.Message);
            }

            // Retorna null si no se encontró el archivo
            return null;
        }

        // Declarar el ToolTip en el boton Reportes
        private ToolTip toolTipreportes = new ToolTip();

        public void funAbrirFormulario<T>() where T : Form, new()
        {
            Form formulario = new T();
            formulario.Show();
        }

        private void Btn_reportes_Click(object sender, EventArgs e)
        {
            // Mostrar el ToolTip en el boton reportes
            toolTipreportes.SetToolTip(Btn_reportes, "Documento de Reportes");

           //   ReporteH frm = new ReporteH();
           //   frm.Show();

           // Llamar a AbrirFormulario para abrir el formulario de ReporteH
           funAbrirFormulario<Capa_Vista_HorasExtras.ReporteH>();

        }

        // Declarar el ToolTip en el boton Reportes
        private ToolTip toolTiLimpiar = new ToolTip();

        private void Btn_limpiar_Click_1(object sender, EventArgs e)
        {
            // Mostrar el ToolTip en el boton reportes
            toolTiLimpiar.SetToolTip(Btn_limpiar, "Boton de limpiar ");


            // Limpia el ComboBox de empleados
            Cbo_empleado.SelectedIndex = -1; // O también puedes usar Cbo_empleado.ResetText();

            // Limpia el ComboBox de meses
            Cbo_mes.SelectedIndex = -1; // O también puedes usar Cbo_mes.ResetText();

            // Limpia el TextBox de cálculo de horas
            Txt_calculohoras.Clear();
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
          
        }
        private void Btn_generacionhorasextras_Click(object sender, EventArgs e)
        {

        }

        private void Txt_calculohoras_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_horasextra_Load(object sender, EventArgs e)
        {



        }

    }
}
