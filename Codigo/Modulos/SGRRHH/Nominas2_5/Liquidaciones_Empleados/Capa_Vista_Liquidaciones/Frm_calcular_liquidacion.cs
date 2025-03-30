using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Liquidaciones;
//using Capa_Vista_Polizas;
using Capa_Controlador_Seguridad;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Capa_Vista_Liquidaciones
{
    public partial class Frm_calcular_liquidacion : Form
    {
        /* ------------------------------------------- Código por Gabriela Suc ------------------------------------------- */

        Controlador cn = new Controlador();

        logica logicaSeg = new logica();

        public string sIdUsuario { get; set; }

        public Frm_calcular_liquidacion()
        {
            InitializeComponent();
            ConfigurarTooltips();
            meCargarEmpleados();
            meLimpiarControles();

            // Vincular el evento
            Cbo_empleado_liquidacion.SelectedIndexChanged += Cbo_empleado_liquidacion_SelectedIndexChanged;
        }


        private void Btn_calculo_liquidaciones_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado un empleado
                if (Cbo_empleado_liquidacion.SelectedValue != null)
                {
                    // Obtener el ID del empleado seleccionado
                    DataRowView selectedRow = (DataRowView)Cbo_empleado_liquidacion.SelectedItem;
                    int iEmpleadoId = Convert.ToInt32(selectedRow["pk_clave"]);

                    // Verificar si ya existe un registro para este empleado en las tablas de liquidación
                    //bool bExisteLiquidacion = cn.meVerificarExistenciaLiquidacion(iEmpleadoId);

                    //if (bExisteLiquidacion)
                    //{
                    //    // Si ya existe un registro, mostrar un mensaje y no proceder con el cálculo
                    //    MessageBox.Show("Ya existe una liquidación registrada para este empleado.");
                    //    return;
                    //}

                    
                    DialogResult result = MessageBox.Show("¿Desea guardar la liquidación calculada?",
                                                          "Confirmación",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

                    
                    if (result == DialogResult.Yes)
                    {
                        logicaSeg.funinsertarabitacora(sIdUsuario, "Se guardó liquidación", "tbl_liquidacion_trabajadores, tbl_dedu_perp_emp", "6107");

                        // Obtener los días laborados del empleado
                        int iDiasLaborados = Convert.ToInt32(Txt_dias_laborados.Text);

                        // Calcular el aguinaldo
                        decimal deAguinaldo = cn.meCalcularAguinaldo(iEmpleadoId, iDiasLaborados);

                        // Almacenar el aguinaldo en la tabla tbl_dedu_perp_emp
                        cn.meGuardarAguinaldoDeduPerpEmp(iEmpleadoId, deAguinaldo);

                        // Calcular las Vacaciones
                        decimal deVacaciones = cn.meCalcularVacaciones(iEmpleadoId, iDiasLaborados);
                        Txt_vacaciones_liquidacion.Text = deVacaciones.ToString("F2");

                        // Guardar las vacaciones en la tabla tbl_dedu_perp_emp
                        cn.meInsertarVacacionesDeduPerpEmp(iEmpleadoId, deVacaciones);

                        // Calcular el Bono 14
                        decimal deBono14 = cn.meCalcularBono14(iEmpleadoId);

                        // Almacenar el Bono 14 en la tabla tbl_dedu_perp_emp
                        cn.meInsertarBono14DeduPerpEmp(iEmpleadoId, deBono14);

                        // Almacenar la liquidación completa en la tabla tbl_liquidacion_trabajadores
                        cn.meGuardarAguinaldoLiquidacionTrabajadores(iEmpleadoId, deAguinaldo, iDiasLaborados, deVacaciones, deBono14);

                        // Actualizar el DataGridView para mostrar los nuevos registros
                        meCargarLiquidaciones();

                        
                        MessageBox.Show("Liquidación calculada y guardada con éxito.");
                    }
                    else
                    {
                        
                        MessageBox.Show("La liquidación no ha sido guardada.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un empleado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular y guardar la liquidación: " + ex.Message);
            }
        }

        // Cargar nombres de empleados en el Combobox
        private void meCargarEmpleados()
        {
            try
            {
                DataTable empleados = cn.meObtenerEmpleados();
                Cbo_empleado_liquidacion.DataSource = empleados;
                Cbo_empleado_liquidacion.DisplayMember = "empleados_nombre";
                Cbo_empleado_liquidacion.ValueMember = "pk_clave";
                Cbo_empleado_liquidacion.SelectedIndex = -1;
            }

            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar empleados: "+ ex.Message);

            }
        }

        // Método para manejar el cambio de selección en el ComboBox
        private void Cbo_empleado_liquidacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_empleado_liquidacion.SelectedValue != null)
            {
                DataRowView selectedRow = (DataRowView)Cbo_empleado_liquidacion.SelectedItem; // Acceso al DataRowView
                int iEmpleadoId = Convert.ToInt32(selectedRow["pk_clave"]);
                             
                // Obtener el salario
                decimal deSalario = cn.meObtenerSalario(iEmpleadoId);
                Txt_salario.Text = deSalario.ToString("F2"); // Formatear a dos decimales

                // Obtener la fecha de alta
                DateTime? fechaAlta = cn.meObtenerFechaAlta(iEmpleadoId);
                if (fechaAlta.HasValue)
                {
                    Txt_fecha_alta.Text = fechaAlta.Value.ToString("dd-MM-yyyy");
                }
                else
                {
                    Txt_fecha_alta.Clear(); // Limpia si no hay fecha
                }

                // Obtener la fecha de baja
                DateTime? fechaBaja = cn.meObtenerFechaBaja(iEmpleadoId);
                if (fechaBaja.HasValue)
                {
                    Txt_fecha_baja.Text = fechaBaja.Value.ToString("dd-MM-yyyy");
                }
                else
                {
                    Txt_fecha_baja.Clear();
                }

                // Calcular días laborados
                int iDiasLaborados = cn.meCalcularDiasLaborados(iEmpleadoId);
                Txt_dias_laborados.Text = iDiasLaborados.ToString();

                // Calcular el aguinaldo
                decimal deAguinaldo = cn.meCalcularAguinaldo(iEmpleadoId, iDiasLaborados);
                Txt_aguinaldo_liquidacion.Text = deAguinaldo.ToString("F2");

                // Calcular las Vacaciones
                decimal deVacaciones = cn.meCalcularVacaciones(iEmpleadoId, iDiasLaborados);
                Txt_vacaciones_liquidacion.Text = deVacaciones.ToString("F2");

                // Calcular el Bono 14
                decimal deBono14 = cn.meCalcularBono14(iEmpleadoId);
                Txt_bono14_liquidacion.Text = deBono14.ToString("F2");


            }
        }

        private void meLimpiarControles()
        {
            Cbo_empleado_liquidacion.SelectedIndex = -1; // Limpia el ComboBox
            Txt_dias_laborados.Clear();
            Txt_fecha_alta.Clear();
            Txt_fecha_baja.Clear();
            Txt_salario.Clear();
            Txt_vacaciones_liquidacion.Clear();
            Txt_aguinaldo_liquidacion.Clear();
            Txt_bono14_liquidacion.Clear();
        }

        private void Frm_calcular_liquidacion_Load(object sender, EventArgs e)
        {
            meLimpiarControles();
            meCargarLiquidaciones();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea borrar todos los campos?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                meLimpiarControles();
            }
        }

        private void Btn_enlace_contabilidad_Click(object sender, EventArgs e)
        {
            //frmPolizas polizas = new frmPolizas();
            //polizas.Show();
        }

        private void meCargarLiquidaciones()
        {
            try
            {
                // Obtener las liquidaciones de los trabajadores
                DataTable liquidaciones = cn.meObtenerLiquidacionesTrabajadores();

                // Asignar los datos al DataGridView
                Dgv_liquidaciones.DataSource = liquidaciones;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las liquidaciones: " + ex.Message);
            }
        }

        public void meAbrirFormulario<T>() where T : Form, new()
        {
            Form formulario = new T();
            formulario.Show();
        }

        private void Btn_reporte_liquidaciones_Click(object sender, EventArgs e)
        {

            meAbrirFormulario<Frm_visualizar_reporte>();
        }

        private string meFindFileInDirectory(string sDirectory, string sFileName)
        {
            try
            {
                // Verifica si la carpeta existe
                if (Directory.Exists(sDirectory))
                {
                    // Busca el archivo .chm en la carpeta
                    string[] sFiles = Directory.GetFiles(sDirectory, "*.chm", SearchOption.TopDirectoryOnly);

                    // Si encuentra el archivo, verifica si coincide con el archivo que se busca y retornamos su ruta
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
                {   
                    MessageBox.Show("No se encontró la carpeta: " + sDirectory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el archivo: " + ex.Message);
            }

            // Retorna null si no se encontró el archivo
            return null;
        }

        private void Btn_ayuda_liquidaciones_Click(object sender, EventArgs e)
        {

            // Obtener la ruta del directorio del ejecutable
            string sExecutablePath = AppDomain.CurrentDomain.BaseDirectory;

            // Retroceder a la carpeta del proyecto
            string sProjectPath = Path.GetFullPath(Path.Combine(sExecutablePath, @"..\..\..\..\..\..\Ayuda\Modulos\Nominas\"));

            string sAyudaFolderPath = Path.Combine(sProjectPath, "AyudaLiquidaciones");

            string sPathAyuda = meFindFileInDirectory(sAyudaFolderPath, "AyudaLiquidaciones2.chm");

            // Verifica si el archivo existe antes de intentar abrirlo
            if (!string.IsNullOrEmpty(sPathAyuda))
            {
                // Abre el archivo de ayuda .chm en la sección especificada
                Help.ShowHelp(null, sPathAyuda, "Ayuda_Frm_Liquidaciones_2024.html");
            }
            else
            {
                MessageBox.Show("El archivo de ayuda no se encontró.");
            }

        }

        private void ConfigurarTooltips()
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(Btn_calculo_liquidaciones, "Insertar una nueva liquidación");
            toolTip.SetToolTip(Btn_reporte_liquidaciones, "Visualizar reporte");
            toolTip.SetToolTip(Btn_enlace_contabilidad, "Enlace a Contabilidad");
            toolTip.SetToolTip(Btn_ayuda_liquidaciones, "Ayuda");
            toolTip.SetToolTip(Btn_cancelar, "Limpiar los campos");
            toolTip.SetToolTip(Btn_salir, "Salir del formulario");
        }


    }
}
