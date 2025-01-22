using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_CierreContable;
using System.IO;
using Capa_Controlador_Seguridad;

namespace Capa_Vista_CierreContable
{
    public partial class ConsultasCierre : Form
    {

        public string sIdUsuario { get; set; }
        logica LogicaSeg = new logica();
        public string sRutaProyectoAyuda { get; private set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\"));
        Controlador cn = new Controlador();



        public ConsultasCierre()
        {
            InitializeComponent();
            LlenarCboAnio();
        }

        private void btn_mensual_Click_1(object sender, EventArgs e)
        {
            string sMes = Cbo_mes.Text;
            string sAnio = Cbo_consultaAño.Text; // Año de interés
            int iPeriodo = 0; // Variable para el periodo
            string sCuenta = Cbo_cuenta.Text;

            if (string.IsNullOrEmpty(sMes))
            {
                string sMensaje = "Error, debe seleccionar un mes para poder realizar la consulta. Intente de nuevo";
                MessageBox.Show(sMensaje);
            }
            else if (string.IsNullOrEmpty(sAnio))
            {
                string sMensaje2 = "Error, debe seleccionar un año para poder realizar la consulta. Intente de nuevo";
                MessageBox.Show(sMensaje2);
            }
            else
            {
                // Mapear el mes a su correspondiente periodo
                iPeriodo = cn.ObtenerPeriodoPorMes(sMes);

                // Verifica si se seleccionó "Todas las sCuentas" y ajusta la consulta
                if (sCuenta == "Todas las cuentas")
                {
                    // Llama a la consulta sin aplicar filtro de sCuenta
                    ConsultarCierreG(iPeriodo, sAnio, null, Dgv_cargos, Dgv_abonos);
                }
                else
                {
                    // Llama a la consulta con el filtro de sCuenta
                    ConsultarCierreG(iPeriodo, sAnio, sCuenta, Dgv_cargos, Dgv_abonos);
                }

                // Calcular totales
                Totales(Dgv_cargos, Dgv_abonos, Txt_saldoD, Txt_saldoH);
            }

            // Actualizar los saldos
            cn.ActualizarSumasSaldos(Txt_saldoant, Txt_saldofinal, iPeriodo, sCuenta == "Todas las cuentas" ? null : sCuenta);
            LogicaSeg.funinsertarabitacora(sIdUsuario, $"Se consultó un Cierre", "ConsultasCierre", "8000");

        }



        public void Totales(DataGridView dgv_DebeCG, DataGridView dgv_HaberCG, TextBox txt_boxtotD, TextBox txt_boxtotH)
        {
            float fSuma1 = 0;
            float fSuma2 = 0;

            // Para el total de debe
            foreach (DataGridViewRow row in dgv_DebeCG.Rows)
            {
                // Verificar que la fila tiene al menos 5 celdas y que la celda no es nula
                if (row.Cells.Count > 4 && row.Cells[4].Value != null && float.TryParse(row.Cells[4].Value.ToString(), out float valorDebe))
                {
                    fSuma1 += valorDebe;
                }
            }
            txt_boxtotD.Text = fSuma1.ToString("F2");

            // Para el total de haber
            foreach (DataGridViewRow row in dgv_HaberCG.Rows)
            {
                // Verificar que la fila tiene al menos 5 celdas y que la celda no es nula
                if (row.Cells.Count > 4 && row.Cells[4].Value != null && float.TryParse(row.Cells[4].Value.ToString(), out float fValorhaber))
                {
                    fSuma2 += fValorhaber;
                }
            }
            txt_boxtotH.Text = fSuma2.ToString("F2");
        }




        public void ConsultarCierreG(int iPeriodo, string sAnio, string sCuenta, DataGridView dgv_DebeCG, DataGridView dgv_HaberCG)
        {
            try
            {
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();

                // If "Todas las cuentas" is selected, set sCuenta to null
                if (sCuenta == "Todas las cuentas")
                {
                    sCuenta = null;
                }

                // Call the ConsultaCG method to populate dt1 and dt2
                cn.ConsultaCG(iPeriodo, sAnio, sCuenta, dt1, dt2);

                // Check if both tables are empty
                if (dt1.Rows.Count == 0 && dt2.Rows.Count == 0)
                {
                    // Clear the DataGridView if no results are found
                    dgv_DebeCG.DataSource = null;
                    dgv_DebeCG.Columns.Clear();
                    dgv_HaberCG.DataSource = null;
                    dgv_HaberCG.Columns.Clear();
                    MessageBox.Show("Ningún cierre fue creado...");
                }
                else
                {
                    // Assign the data to the DataGridView if results are available
                    dgv_DebeCG.DataSource = dt1;
                    dgv_HaberCG.DataSource = dt2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar cierre: {ex.Message}");
            }
        }





        public void LlenarCuentas()
        {

            DataTable sCuentas = cn.ObtenerCuentas();

            // Limpiar y agregar "Todas las sCuentas" al ComboBox
            Cbo_cuenta.Items.Clear();
            Cbo_cuenta.Items.Add("Todas las cuentas");

            foreach (DataRow row in sCuentas.Rows)
            {
                Cbo_cuenta.Items.Add(row["nombre_cuenta"]); // Ajustar según el nombre de la columna en tu DataTable
            }

            Cbo_cuenta.SelectedIndex = 0; // Seleccionar "Todas las sCuentas" como predeterminada
        }

        public void LlenarCboAnio()
        {
            // Obtener el año actual
            int iAnioactual = DateTime.Now.Year;

            // Limpiar el ComboBox
            Cbo_consultaAño.Items.Clear();

            // Llenar el ComboBox con los próximos 10 años desde el año actual
            for (int i = 0; i <= 10; i++)
            {
                int iAnio = iAnioactual + i;
                Cbo_consultaAño.Items.Add(iAnio.ToString());
            }

            // Seleccionar el año actual como predeterminado
            Cbo_consultaAño.SelectedIndex = 0;
        }

        private void PartidaCierre_Load(object sender, EventArgs e)
        {
            LlenarCuentas();

            // Configuración del ToolTip
            ToolTip toolTip = new ToolTip
            {
                IsBalloon = true // Hacer que el tooltip tenga forma de globo
            };

            // Asignar texto a los botones
            toolTip.SetToolTip(Btn_consultar, "Muestra los cargos, abonos y el saldo de cada consulta.");
            toolTip.SetToolTip(Btn_actualizar, "Limpia los DataGridView y los Textbox de las sumas.");
            toolTip.SetToolTip(Btn_ayuda1, "Muestra la Ayuda del formulario actual."); 
            toolTip.SetToolTip(Btn_reporte, "Imprime el Reporte General de los Cierres.");

        }


        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            ReiniciarFormulario();
            LogicaSeg.funinsertarabitacora(sIdUsuario, $"Se actualizó el formulario", "ConsultasCierre", "8000");

        }

        private void ReiniciarFormulario()
        {
            // Limpiar los TextBoxes
            Txt_saldoant.Text = string.Empty;
            Txt_saldofinal.Text = string.Empty;
            Txt_saldoD.Text = string.Empty;
            Txt_saldoH.Text = string.Empty;


            // Limpiar los DataGridViews
            Dgv_cargos.DataSource = null; // Limpiar el DataSource
            Dgv_abonos.DataSource = null; // Limpiar el DataSource

            // Volver a llenar el ComboBox de años
            LlenarCboAnio();

            // También puedes reiniciar otras variables o controles según lo necesites
            // Por ejemplo, restablecer estados de otros controles o variables
        }

        private void btn_Ayuda1_Click(object sender, EventArgs e)
        {
            try
            {
                //Ruta para que se ejecute desde la ejecucion de Interfac3
                string sAyudaPath = Path.Combine(sRutaProyectoAyuda, "Ayuda", "Modulos", "Contabilidad", "AyudaCierreContable", "AyudaCierreI.chm");
                //string sIndiceAyuda = Path.Combine(sRutaProyecto, "EstadosFinancieros", "ReportesEstados", "Htmlayuda.hmtl");
                //MessageBox.Show("Ruta del reporte: " + sAyudaPath, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Help.ShowHelp(this, sAyudaPath, "AyudaCierre.html");

                //Bitacora--------------!!!
                LogicaSeg.funinsertarabitacora(sIdUsuario, $"Se presiono Ayuda", "ConsultasCierre", "8000");
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de una excepción
                MessageBox.Show("Ocurrió un error al abrir la ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al abrir la ayuda: " + ex.ToString());
            }
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            LogicaSeg.funinsertarabitacora(sIdUsuario, $"se mostró reporte de los cierres ya existentes", "Cierre Contable", "8000");

            ReporteCierre frm = new ReporteCierre();
            frm.Show();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {

        }
    }
}

