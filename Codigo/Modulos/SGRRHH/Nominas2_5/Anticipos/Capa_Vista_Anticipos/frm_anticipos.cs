using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Anticipos;
using Capa_Modelo_Seguridad;
using System.IO;
using Capa_Controlador_Seguridad;

namespace Capa_Vista_Anticipos
{
    public partial class frm_anticipos : Form
    {
        Controlador controlador= new Controlador();
        logica logicaSeg = new logica();
        public string idUsuario { get; set; }

        public string sRutaProyectoAyuda { get; private set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\"));




        public frm_anticipos()
        {
            InitializeComponent();
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(Btn_reporte_anticipo, "Generar Reporte");
            toolTip.SetToolTip(Btn_ayuda, "Ayuda");
        }

        private void Btn_anticipo_nominas_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_meses_anticipos.SelectedItem != null)
                {
                    string mesSeleccionado = cmb_meses_anticipos.SelectedItem.ToString(); // Obtener el mes seleccionado
                    controlador.Pro_CalcularAnticipo(mesSeleccionado); // Llamar al método del controlador
                    MessageBox.Show("Cálculo de anticipos realizado con éxito."); // Mensaje de éxito
                    logicaSeg.funinsertarabitacora(idUsuario, "se calculo anticipos", "tbl_dedu_perp_emp", "6008");
                    
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un mes."); // Mensaje de advertencia
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // Manejo de errores
            }
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                //Ruta para que se ejecute desde la ejecucion de Interfac3
                string sAyudaPath = Path.Combine(sRutaProyectoAyuda, "Ayuda", "Modulos", "Nominas",  "AyudaAnticipo.chm");
                //string sIndiceAyuda = Path.Combine(sRutaProyecto, "EstadosFinancieros", "ReportesEstados", "Htmlayuda.hmtl");
                //MessageBox.Show("Ruta del reporte: " + sAyudaPath, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Help.ShowHelp(this, sAyudaPath, "Anticipos.html");

                //Bitacora--------------!!!
                logicaSeg.funinsertarabitacora(idUsuario, "Se presiono Ayuda", "tbl_control_anticipo", "6000");
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de una excepción
                MessageBox.Show("Ocurrió un error al abrir la ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al abrir la ayuda: " + ex.ToString());
            }
        }
        private ToolTip toolTipreportes = new ToolTip();

        public void funAbrirFormulario<T>() where T : Form, new()
        {
            Form formulario = new T();
            formulario.Show();
        }

        private void Btn_reporte_anticipo_Click(object sender, EventArgs e)
        {
            toolTipreportes.SetToolTip(Btn_reporte_anticipo, "Documento de Reportes");
            logicaSeg.funinsertarabitacora(idUsuario, "Se generó reporte", "tbl_control_anticipo", "6000");

            funAbrirFormulario<Capa_Vista_Anticipos.frm_reporte_anticipos>();
        }
    }
}

