using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_CierreContable;
using System.IO;
using Capa_Controlador_Seguridad;

namespace Capa_Vista_CierreContable
{
    public partial class CierreMensual : Form
    {
        // Variable global para el año
        private int gAnioseleccionado = 2024;

        public string sIdUsuario { get; set; }
        logica LogicaSeg = new logica();
        public string sRutaProyectoAyuda { get; private set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\"));

        Controlador cn = new Controlador();
        public CierreMensual()
        {
            InitializeComponent();
        }

        private void ConsultasCierre_Load(object sender, EventArgs e)
        {
            
            
            LlenarCboAnio();
            LlenarCuentas();
            LlenarCboMes();

            // Configuración del ToolTip
            ToolTip toolTip = new ToolTip
            {
                IsBalloon = true // Hacer que el tooltip tenga forma de globo
            };
            toolTip.SetToolTip(Btn_guardarcierre, "Guarda el cierre contable, no se podrá modificar nada luego de esto.");
            toolTip.SetToolTip(Btn_cancelar, "Cancela el guardado del cierre actual");
            toolTip.SetToolTip(Btn_nuevocierre, "Genera el cierre del mes actual");
            toolTip.SetToolTip(Btn_actualizar, "Limpia los DataGridView y los Textbox de las sumas.");
            toolTip.SetToolTip(Btn_ayuda2, "Muestra la Ayuda del formulario actual.");
            toolTip.SetToolTip(Btn_reporte, "Muestra el Reporte del los datos del Mes Actual.");
        }

        public void LlenarCboAnio()
        {
            // Limpiar el ComboBox de año
            Cbo_año.Items.Clear();

            // Rango de años a verificar (2024 a 2034)
            int iAnioInicial = 2024;
            int iAnioFinal = 2034;

            // Variable para saber si se encontró un año con meses incompletos
            bool bAnioEncontrado = false;

            // Iterar sobre los años en el rango
            for (int iAnio = iAnioInicial; iAnio <= iAnioFinal; iAnio++)
            {
                // Usar un switch para verificar si el año tiene todos los meses con datos
                int iMesesConDatos = 0;

                for (int iMes = 1; iMes <= 12; iMes++)
                {
                    // Verificar si el mes tiene datos en tbl_historico_cuentas
                    bool tieneDatos = cn.VerificarMesConDatos(iAnio, iMes);
                    if (tieneDatos)
                    {
                        iMesesConDatos++;
                    }
                }

                switch (iMesesConDatos)
                {
                    case 12:
                        // Si todos los meses (12) tienen datos, continuar al siguiente año
                        continue;

                    default:
                        // Si el año no tiene todos los meses con datos, agregarlo al ComboBox
                        Cbo_año.Items.Add(iAnio.ToString());
                        Cbo_año.SelectedIndex = 0;  // Seleccionar el primer año sin datos completos
                        bAnioEncontrado = true;
                        break;
                }

                // Salir del bucle si se encontró un año incompleto
                if (bAnioEncontrado)
                    break;
            }

            // Si no se encontró ningún año incompleto dentro del rango, mostrar mensaje o manejar el caso
            if (!bAnioEncontrado)
            {
                MessageBox.Show("Todos los años entre 2024 y 2034 están completos.");
            }
        }




        public void LlenarCuentas()
        {
            DataTable cuentas = cn.ObtenerCuentas();

            // Limpiar y agregar "Todas las cuentas" al ComboBox
            Cbo_cuenta.Items.Clear();
            Cbo_cuenta.Items.Add("Todas las cuentas");

            foreach (DataRow row in cuentas.Rows)
            {
                Cbo_cuenta.Items.Add(row["nombre_cuenta"]); // Ajustar según el nombre de la columna en tu DataTable
            }

            Cbo_cuenta.SelectedIndex = 0; // Seleccionar "Todas las cuentas" como predeterminada
        }




        public void LlenarCboMes()
        {
            // Verificar si hay un año seleccionado
            if (int.TryParse(Cbo_año.Text, out int gAnioseleccionado))
            {
                // Limpiar el ComboBox
                Cbo_mes.Items.Clear();

                // Variable para saber si se encontró un mes sin datos
                bool mesEncontrado = false;

                // Recorrer los meses del año seleccionado
                for (int mes = 1; mes <= 12; mes++)
                {
                    // Verificar si el mes tiene datos en tbl_historico_cuentas
                    bool tieneDatos = cn.VerificarMesConDatos(gAnioseleccionado, mes);

                    // Si el mes no tiene datos, agregarlo al ComboBox y marcarlo como encontrado
                    if (!tieneDatos)
                    {
                        Cbo_mes.Items.Add(new DateTime(gAnioseleccionado, mes, 1).ToString("MMMM", new System.Globalization.CultureInfo("es-ES")));
                        Cbo_mes.SelectedIndex = 0;  // Seleccionar el primer mes sin datos
                        mesEncontrado = true;
                        break;  // Solo agregar el primer mes sin datos
                    }
                }

                // Si no se encontró un mes sin datos en el año actual, buscar en el siguiente año
                if (!mesEncontrado)
                {
                    gAnioseleccionado++;  // Incrementar el año
                    for (int mes = 1; mes <= 12; mes++)
                    {
                        // Verificar si el mes del siguiente año tiene datos
                        bool tieneDatos = cn.VerificarMesConDatos(gAnioseleccionado, mes);

                        if (!tieneDatos)
                        {
                            // Si el mes no tiene datos, agregarlo al ComboBox
                            Cbo_mes.Items.Add(new DateTime(gAnioseleccionado, mes, 1).ToString("MMMM", new System.Globalization.CultureInfo("es-ES")));
                            Cbo_mes.SelectedIndex = 0;  // Seleccionar el primer mes sin datos
                            break;  // Salir después de encontrar el primer mes sin datos
                        }
                    }
                }

                // Si no hay meses disponibles, se puede mostrar un mensaje o reiniciar el formulario
                if (Cbo_mes.Items.Count == 0)
                {
                    ReiniciarFormulario();
                }
            }
        }

        // Método auxiliar para verificar si hay datos para un mes específico









        private void LlenarCierre(string sCuentaseleccionada)
        {
            DataTable datosCierre;

            // Verificar si se seleccionó "Todas las cuentas"
            if (sCuentaseleccionada == "Todas las cuentas")
            {
                datosCierre = cn.ObtenerDatosCierre(null); // Pasar null o un valor que indique que se deben obtener todas las cuentas
            }
            else
            {
                datosCierre = cn.ObtenerDatosCierre(sCuentaseleccionada);
            }

            // Verificar si se obtuvieron datos
            if (datosCierre != null && datosCierre.Rows.Count > 0)
            {
                Dgv_cierre.DataSource = datosCierre; // Asignar el DataTable al DataGridView
            }
            else
            {
                MessageBox.Show("No se encontraron datos para la cuenta seleccionada.");
                Dgv_cierre.DataSource = null; // Limpiar el DataGridView si no hay datos
            }
        }




        private void btn_nuevocierre_Click(object sender, EventArgs e)
        {
            string sMes = Cbo_mes.Text; // Obtener el mes desde el ComboBox
            string sAnio = Cbo_año.Text; // Año de interés
            string sCuentaSeleccionada = Cbo_cuenta.Text;
            int iPeriodo = 0;
            int iAniov = 0;

            // Intenta convertir el texto a un entero
            if (!int.TryParse(sAnio, out iAniov))
            {
                // La conversión falló, maneja el error aquí
                MessageBox.Show("Error: el año seleccionado no es válido.");
                return; // Salir del método si el año no es válido
            }

            // Verificar si se seleccionó un mes
            if (string.IsNullOrEmpty(sMes))
            {
                string sMensaje = "Error, debe seleccionar un mes para poder realizar la consulta. Intente de nuevo";
                MessageBox.Show(sMensaje);
                return; // Salir del método si el mes no es válido
            }

            // Mapear el mes a su correspondiente periodo
            iPeriodo = cn.ObtenerPeriodoPorMes(sMes);

            LlenarCierre(sCuentaSeleccionada);

            MessageBox.Show($"Mes: {sMes}, Año: {iAniov}.");

            // cn.ConsultarCierreG(cuentaSeleccionada, txt_cargomes, txt_abonomes, txt_saldoantmes, txt_saldoactmes);
            if (sCuentaSeleccionada == "Todas las cuentas")
            {
                // Llama a la consulta sin aplicar filtro de cuenta
                cn.ConsultarCierreG(null, Txt_cargomes, Txt_abonomes, Txt_saldoantmes, Txt_saldoactmes);
            }
            else
            {
                // Llama a la consulta con el filtro de cuenta
                cn.ConsultarCierreG(sCuentaSeleccionada, Txt_cargomes, Txt_abonomes, Txt_saldoantmes, Txt_saldoactmes);
            }

            // Aquí puedes continuar con cualquier lógica que necesites, 
            // como habilitar otros controles o realizar otras acciones.

            Btn_nuevocierre.Enabled = false;
            Btn_cancelar.Enabled = true;
            Btn_guardarcierre.Enabled = true;
            LogicaSeg.funinsertarabitacora(sIdUsuario, $"Se consultó las polizas del mes actual", "Cierre Contable", "8000");

        }

        // Evento de clic para btn_cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            // Limpiar el DataGridView
            Dgv_cierre.DataSource = null; // O puedes usar dgv_cierre.Rows.Clear(); para eliminar filas
            Dgv_cierre.Columns.Clear(); // Opcional: si deseas eliminar también las columnas

            // Activa el botón Nuevocierre y desactiva el botón Cancelar
            Btn_nuevocierre.Enabled = true;
            Btn_cancelar.Enabled = false;
            Btn_guardarcierre.Enabled = false;
            LogicaSeg.funinsertarabitacora(sIdUsuario, $"Se canceló la operación de cierre", "Cierre Mensual", "8000");

        }

        // Método para incrementar el año si el año actual tiene cierres completos
        public void IncrementarAnioSiEsNecesario(int iAnio)
        {
            if (cn.VerificarCierresCompletos(iAnio))
            {
                // Incrementar el año
                gAnioseleccionado = iAnio + 1;

                // Limpiar el ComboBox y agregar el nuevo año
                Cbo_año.Items.Clear();
                Cbo_año.Items.Add(gAnioseleccionado.ToString());
                Cbo_año.SelectedIndex = 0;

                MessageBox.Show("Se ha completado el año. Ahora se procederá al año " + gAnioseleccionado);

                // Actualizar el año en la base de datos (si es necesario)
                cn.ActualizarAnioHistorico(iAnio, gAnioseleccionado);
            }
        }



        private void btn_GuardarCierre_Click(object sender, EventArgs e)
        {
            // Obtener el año del ComboBox
            int iAnio = int.Parse(Cbo_año.Text);

            // Verificar si hay un mes seleccionado
            if (Cbo_mes.Items.Count > 0 && Cbo_mes.SelectedIndex != -1)
            {
                // Obtener el mes como texto y convertir a mayúsculas para otros usos
                string sMes = Cbo_mes.Text.ToUpper();

                // Obtener el índice seleccionado y calcular el mes
                int iMesi = Cbo_mes.SelectedIndex + 1; // El índice se traduce correctamente al mes

                int iPeriodo = cn.ObtenerPeriodoPorMes(sMes); // Obtener periodo a partir del mes en mayúsculas

                // Confirmar la operación
                var confirmacion = MessageBox.Show("¿Estás seguro de realizar esta operación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    if (iPeriodo == 0)
                    {
                        MessageBox.Show("Error: el mes seleccionado no es válido.");
                        return; // Salir si el mes no es válido
                    }

                    // Lógica para guardar los datos usando el periodo y año
                    cn.GenerarNuevoCierre(iPeriodo, iAnio); // Usar el periodo obtenido

                    // Verifica y actualiza el año completo
                    cn.VerificarYActualizarAnoCompleto(iAnio);

                    // Llama a IncrementarAnioSiEsNecesario para incrementar el año si es necesario
                    IncrementarAnioSiEsNecesario(iAnio);

                    // Limpiar el DataGridView y restaurar botones a su estado inicial
                    Dgv_cierre.DataSource = null;  // Desvincular el DataGridView de su fuente de datos
                    Dgv_cierre.Rows.Clear();       // Limpiar las filas

                    Btn_nuevocierre.Enabled = true;
                    Btn_guardarcierre.Enabled = false;
                    LlenarCboMes();

                    // Actualizar ComboBox de meses
                    cn.ActualizarComboBoxMeses();
                    Txt_cargomes.Clear();
                    Txt_abonomes.Clear();
                    Txt_saldoactmes.Clear();
                    Txt_saldoantmes.Clear();
                    Btn_cancelar.Enabled = false;

                    // Si es diciembre (mes 12), incrementa el año y restablece los meses a enero
                    if (iMesi == 12)
                    {
                        // Incrementar año
                        int iNuevoanio = iAnio + 1;
                        Cbo_año.Items.Clear();
                        Cbo_año.Items.Add(iNuevoanio.ToString());
                        Cbo_año.SelectedIndex = 0;  // Seleccionar el nuevo año

                        // Restablecer ComboBox de meses a enero
                        Cbo_mes.SelectedIndex = -1; // Seleccionar ningún mes (esto hará que se muestre "enero" cuando el ComboBox se actualice)
                    }
                }
                else
                {
                    ReiniciarFormulario();
                }
            }
            else
            {
                MessageBox.Show("No se puede ingresar datos. No hay meses disponibles.");
            }
            LogicaSeg.funinsertarabitacora(sIdUsuario, $"Se guardó un nuevo Cierre Mensual", "Cierre Contable", "8000");
        }


        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            ReiniciarFormulario();
            LogicaSeg.funinsertarabitacora(sIdUsuario, $"Se actualizó el Formulario", "Cierre Contable", "8000");

        }

        private void ReiniciarFormulario()
        {
            // Limpiar los TextBoxes
            Txt_abonomes.Text = string.Empty;
            Txt_cargomes.Text = string.Empty;
            Txt_saldoactmes.Text = string.Empty;
            Txt_saldoantmes.Text = string.Empty;
            Btn_cancelar.Enabled = false;
            Btn_nuevocierre.Enabled = true;
            Btn_guardarcierre.Enabled = false;


            // Limpiar los DataGridViews
            Dgv_cierre.DataSource = null; // Limpiar el DataSource

            // Volver a llenar el ComboBox de años
            LlenarCboAnio();

            // También puedes reiniciar otras variables o controles según lo necesites
            // Por ejemplo, restablecer estados de otros controles o variables
        }

        private void btn_Ayuda2_Click(object sender, EventArgs e)
        {
            try
            {
                //Ruta para que se ejecute desde la ejecucion de Interfac3
                string sAyudaPath = Path.Combine(sRutaProyectoAyuda, "Ayuda", "Modulos", "Contabilidad", "AyudaCierreContable", "AyudaCierreI.chm");
                //string sIndiceAyuda = Path.Combine(sRutaProyecto, "EstadosFinancieros", "ReportesEstados", "Htmlayuda.hmtl");
                //MessageBox.Show("Ruta del reporte: " + sAyudaPath, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Help.ShowHelp(this, sAyudaPath, "AyudaCierre2.html");

                //Bitacora--------------!!!
                LogicaSeg.funinsertarabitacora(sIdUsuario, $"Se presiono Ayuda", "Cierre Contable", "8000");
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

        }

        private void btn_Reporte_Click_1(object sender, EventArgs e)
        {
            LogicaSeg.funinsertarabitacora(sIdUsuario, $"Se mostró reporte del Cierre mensual", "Cierre Contable", "8000");

            ReporteMes frm = new ReporteMes();
            frm.Show();
        }

        public void Btn_salir_Click(object sender, EventArgs e)
        {

        }
    }
}
