using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//Para Ayudas
using Capa_Controlador_Presupuesto;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

//Seguridad-->Bitacora---------------------!!!
using Capa_Controlador_Seguridad;

namespace Capa_Vista_Presupuesto
{
    public partial class Presupuesto : Form
    {
        Controlador control = new Controlador();
        Incremento frmIncremento = new Incremento(null); //Cambio
        public string sOperacionP;
        public int iIdPresupuestoP;
        public string sNombreP;
        public string sLlenadoP;
        public int iIdPrepLlenadoP;
        public int iEjercicio;

        public string sIdUsuario { get; set; } //Para Bitacora-------------!!!
        ToolTip toolTip = new ToolTip();
        logica logicaSeg = new logica();

        //Ruta para que se ejecute desde la ejecucion de Interfac3
        public string sRutaProyectoReportes { get; private set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\"));

        //Ruta para que se ejecute desde la ejecucion de Interfac3
        public string sRutaProyectoAyuda { get; private set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\"));

        public Presupuesto()
        {
            InitializeComponent();
            ConfigurarColumnas();
            toolTip.SetToolTip(Btn_modificar, "Haz click para guardar el presupuesto");
            toolTip.SetToolTip(Btn_opciones, "Haz click para configurar");
            toolTip.SetToolTip(Btn_eliminar, "Haz click para eliminar el presupuesto");
            toolTip.SetToolTip(Btn_Informe, "Haz click para ver el informe de presupuesto");
            toolTip.SetToolTip(Btn_incremento, "Haz click para incrementar");
            toolTip.SetToolTip(Btn_ajustar, "Haz click para ajustar el presupuesto");
            toolTip.SetToolTip(Btn_Salir, "Haz click para salir");
            toolTip.SetToolTip(Btn_ayuda, "Haz click para ver ayuda");

        }
        private void Presupuesto_Load(object sender, EventArgs e)
        {
            
            BloquearTextBox();
            BloquearBotones();
            Txt_anualB.Enabled = false;
            Btn_ayuda.Enabled = true;
            control.ActualizarEstadosPresupuesto();
        }

        //Se ejecuta al presionar el boton de opciones
        private void CargarDatos()
        {
            Txt_nombrePresupuesto.Text = sNombreP; //Cambiar
            //MessageBox.Show(Convert.ToString(iIdPresupuestoP)); //Bandera
            //Operacion
            switch (sOperacionP)
            {
                case "crear":
                    CargarCuentasNuevas();
                    control.GuardarPresupuesto(iIdPresupuestoP, Dgv_presupuesto);
                    control.ActualizarTblPresupuesto(iIdPresupuestoP);
                    //MessageBox.Show("Crear");//Bandera
                    Btn_modificar.Enabled = true;
                    Btn_eliminar.Enabled = true;
                    Btn_Informe.Enabled = true;
                    Btn_incremento.Enabled = true;
                    Btn_ayuda.Enabled = true;
                    break;

                case "modificar":
                    CargarDetalles(iIdPresupuestoP);
                    Btn_modificar.Enabled = true;
                    Btn_eliminar.Enabled = true;
                    Btn_Informe.Enabled = true;
                    Btn_incremento.Enabled = true;
                    Btn_ayuda.Enabled = true;
                    //MessageBox.Show("Modificar");//Bandera
                    break;

                case "ver":
                    CargarDetalles(iIdPresupuestoP);
                    BloquearTextBox();
                    BloquearBotones();
                    Txt_anualB.Enabled = false;
                    Btn_Informe.Enabled = true;
                    break;

                case "crearPlantilla":
                    CargarDetalles(iIdPrepLlenadoP);
                    control.GuardarPresupuesto(iIdPresupuestoP, Dgv_presupuesto);
                    control.ActualizarTblPresupuesto(iIdPresupuestoP);
                    Btn_modificar.Enabled = true;
                    Btn_eliminar.Enabled = true;
                    Btn_incremento.Enabled = true;
                    Btn_incremento.Enabled = true;
                    Btn_Informe.Enabled = true;
                    Btn_ayuda.Enabled = true;
                    break;
            }
            //Llenado
            if (sOperacionP == "crearPlantilla" || sOperacionP=="crear" || sOperacionP == "modificar") { 
                switch (sLlenadoP)
                {
                    case "Mensual":
                        LiberarTextBox();
                        Txt_anualB.Enabled = false;
                        frmIncremento.sLlenado = this.sLlenadoP;
                        Btn_ajustar.Enabled = false;
                        break;
                    case "Anual":
                        BloquearTextBox();
                        frmIncremento.sLlenado = this.sLlenadoP;
                        Btn_ajustar.Visible = true; //Cambiar O nome
                        Btn_ajustar.Enabled = true;
                        Txt_anualB.Enabled = true;
                        break;
                }
            }

            //Todo
            try
            {
                // Reemplaza con la columna y label 
                SumarColumna("Column3", Txt_totalEnero);
                SumarColumna("Column4", Txt_totalFebrero);
                SumarColumna("Column5", Txt_totalMarzo);
                SumarColumna("Column6", Txt_totalAbril);
                SumarColumna("Column7", Txt_totalMayo);
                SumarColumna("Column8", Txt_totalJunio);
                SumarColumna("Column9", Txt_totalJulio);
                SumarColumna("Column10", Txt_totalAgosto);
                SumarColumna("Column11", Txt_totalSeptiembre);
                SumarColumna("Column12", Txt_totalOctubre);
                SumarColumna("Column13", Txt_totalNoviembre);
                SumarColumna("Column14", Txt_totalDiciembre);
                SumarColumna("Column15", Txt_totalAnual);
            }
            catch (Exception ex) { MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            try {
                if (Dgv_presupuesto.Rows.Count > 0)
                {
                    CargarFila(0);
                }
            }
            catch (Exception ex) { MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            Txt_ejercicioPres.Text = Convert.ToString(iEjercicio);
        }


        private void LiberarTextBox()
        {
            Txt_eneroB.Enabled = true;
            Txt_febreroB.Enabled = true;
            Txt_marzoB.Enabled = true;
            Txt_abrilB.Enabled = true;
            Txt_mayoB.Enabled = true;
            Txt_junioB.Enabled = true;
            Txt_julioB.Enabled = true;
            Txt_agostoB.Enabled = true;
            Txt_septiembreB.Enabled = true;
            Txt_octubreB.Enabled = true;
            Txt_noviembreB.Enabled = true;
            Txt_diciembreB.Enabled = true;
        }

        private void BloquearBotones()
        {
            Btn_ajustar.Enabled = false;
            Btn_eliminar.Enabled = false;
            Btn_incremento.Enabled = false;
            Btn_Informe.Enabled = false; //Cambio 
            Btn_modificar.Enabled = false;
        }

        private void BloquearTextBox()
        {
            Txt_eneroB.Enabled = false;
            Txt_febreroB.Enabled = false;
            Txt_marzoB.Enabled = false;
            Txt_abrilB.Enabled = false;
            Txt_mayoB.Enabled = false;
            Txt_junioB.Enabled = false;
            Txt_julioB.Enabled = false;
            Txt_agostoB.Enabled = false;
            Txt_septiembreB.Enabled = false;
            Txt_octubreB.Enabled = false;
            Txt_noviembreB.Enabled = false;
            Txt_diciembreB.Enabled = false;
        }

        private void CargarDetalles(int iIdPresupuesto)
        {
            foreach (DataRow drFila in control.CargarDetallesPresupuesto(iIdPresupuesto).Rows)
            {
                Dgv_presupuesto.Rows.Add(
                    drFila["Fk_id_cuenta"],
                    drFila["nombre_cuenta"],
                    drFila["mes_enero"],
                    drFila["mes_febrero"],
                    drFila["mes_marzo"],
                    drFila["mes_abril"],
                    drFila["mes_mayo"],
                    drFila["mes_junio"],
                    drFila["mes_julio"],
                    drFila["mes_agosto"],
                    drFila["mes_septiembre"],
                    drFila["mes_octubre"],
                    drFila["mes_noviembre"],
                    drFila["mes_diciembre"],
                    drFila["total_cuenta"]
                    );
            }
        }
        private void CargarCuentasNuevas()
        {
            // Agregar cada dato a la columna 'Column1'
            foreach (DataRow drFila in control.ObtenerCuentasNuevo().Rows)
            {
                // Creamos un array de objetos para la nueva fila
                object[] oNuevaFila = new object[15]; // 1 para ID, 1 para nombre, y 13 para 0.00

                oNuevaFila[0] = drFila["Pk_id_cuenta"]; // Columna 1: ID
                oNuevaFila[1] = drFila["nombre_cuenta"]; // Columna 2: Nombre

                for (int i = 2; i < oNuevaFila.Length; i++)
                {
                    oNuevaFila[i] = 0.00m; // Valor para las columnas restantes
                }
                // Agregamos la fila al DataGridView
                Dgv_presupuesto.Rows.Add(oNuevaFila);
            }
        }

        private void ConfigurarColumnas()
        {
            Dgv_presupuesto.Columns["Column1"].ReadOnly = true;
            Dgv_presupuesto.Columns["Column2"].ReadOnly = true;
            Dgv_presupuesto.Columns["Column3"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column4"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column5"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column6"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column7"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column8"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column9"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column10"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column11"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column12"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column13"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column14"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column15"].ValueType = typeof(decimal);

            for (int i = 2; i < Dgv_presupuesto.Columns.Count; i++)
            {
                Dgv_presupuesto.Columns[i].DefaultCellStyle.Format = "F2"; // Formato a dos decimales
            }
            Dgv_presupuesto.Columns["Column15"].DefaultCellStyle.BackColor = Color.LightBlue;
        }

        private void Dgv_presupuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Dgv_presupuesto.CurrentRow == null)
                {
                    //MessageBox.Show("No hay ninguna fila seleccionada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow DgvrFilaSeleccionada = Dgv_presupuesto.CurrentRow;

                // Asignación de valores a los TextBox
                Txt_cuentaB.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column1"].Value ?? string.Empty);
                Txt_descripcionB.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column2"].Value ?? string.Empty);
                Txt_eneroB.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column3"].Value ?? "0.00");
                Txt_febreroB.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column4"].Value ?? "0.00");
                Txt_marzoB.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column5"].Value ?? "0.00");
                Txt_abrilB.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column6"].Value ?? "0.00");
                Txt_mayoB.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column7"].Value ?? "0.00");
                Txt_junioB.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column8"].Value ?? "0.00");
                Txt_julioB.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column9"].Value ?? "0.00");
                Txt_agostoB.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column10"].Value ?? "0.00");
                Txt_septiembreB.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column11"].Value ?? "0.00");
                Txt_octubreB.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column12"].Value ?? "0.00");
                Txt_noviembreB.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column13"].Value ?? "0.00");
                Txt_diciembreB.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column14"].Value ?? "0.00");
                Txt_anualB.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column15"].Value ?? "0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SumaDeValores()
        {
            decimal deSuma = 0;

            try
            {
                deSuma += Convert.ToDecimal(Txt_eneroB.Text);
                deSuma += Convert.ToDecimal(Txt_febreroB.Text);
                deSuma += Convert.ToDecimal(Txt_marzoB.Text);
                deSuma += Convert.ToDecimal(Txt_abrilB.Text);
                deSuma += Convert.ToDecimal(Txt_mayoB.Text);
                deSuma += Convert.ToDecimal(Txt_junioB.Text);
                deSuma += Convert.ToDecimal(Txt_julioB.Text);
                deSuma += Convert.ToDecimal(Txt_agostoB.Text);
                deSuma += Convert.ToDecimal(Txt_septiembreB.Text);
                deSuma += Convert.ToDecimal(Txt_octubreB.Text);
                deSuma += Convert.ToDecimal(Txt_noviembreB.Text);
                deSuma += Convert.ToDecimal(Txt_diciembreB.Text);

                deSuma = Math.Round(deSuma, 2);

                Txt_anualB.Text = deSuma.ToString("F2");
            }
            catch (FormatException)
            {
                //MessageBox.Show("Asegúrate de ingresar solo valores numéricos.", "Error de Formato"); //Revisar
            }

        }
        private void CambioDinamico(string sColumna, TextBox tbTextxbox)
        {
            try
            {
                DataGridViewRow DgvrFilaSeleccionada = Dgv_presupuesto.CurrentRow;

                try
                {
                    DgvrFilaSeleccionada.Cells[sColumna].Value = Math.Round(Convert.ToDecimal(tbTextxbox.Text), 2);
                }
                catch (FormatException) { }
            }
            catch (Exception ex) { MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

        private void Txtbx_enero_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column3", Txt_eneroB);
            //VerificacionVacio(Txtbx_enero);
            SumaDeValores();
        }
        private void Txtbx_febrero_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column4", Txt_febreroB);
            //VerificacionVacio(Txtbx_febrero);
            SumaDeValores();
        }
        private void Txtbx_marzo_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column5", Txt_marzoB);
            //VerificacionVacio(Txtbx_marzo);
            SumaDeValores();
        }

        private void Txtbx_mayo_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column7", Txt_mayoB);
            //VerificacionVacio(Txtbx_mayo);
            SumaDeValores();
        }

        private void Txtbx_junio_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column8", Txt_junioB);
            //VerificacionVacio(Txtbx_junio);
            SumaDeValores();
        }

        private void Txtbx_julio_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column9", Txt_julioB);
            //VerificacionVacio(Txtbx_julio);
            SumaDeValores();
        }

        private void Txtbx_agosto_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column10", Txt_agostoB);
            //VerificacionVacio(Txtbx_agosto);
            SumaDeValores();
        }

        private void Txtbx_septiembre_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column11", Txt_septiembreB);
            //VerificacionVacio(Txtbx_septiembre);
            SumaDeValores();
        }

        private void Txtbx_octubre_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column12", Txt_octubreB);
            SumaDeValores();
        }

        private void Txtbx_noviembre_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column13", Txt_noviembreB);
            //VerificacionVacio(Txtbx_noviembre);
            SumaDeValores();
        }

        private void Txtbx_diciembre_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column14", Txt_diciembreB);
            //VerificacionVacio(Txtbx_diciembre);
            SumaDeValores();
        }

        private void Txtbx_anual_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column15", Txt_anualB);
            //VerificacionVacio(Txtbx_anual);
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            control.ActualizarPresupuesto(iIdPresupuestoP, Dgv_presupuesto);

            control.ActualizarTblPresupuesto(iIdPresupuestoP);
            MessageBox.Show("Datos actualizados exitosamente.", "Éxito");

            //Guardar Bitacora--Seguridad------------!!!
            logicaSeg.funinsertarabitacora(sIdUsuario,$"Se guardo/Actualizo IdPres:{iIdPresupuestoP}","tbl_detalle_presupuesto","8000");

        }

        private void SumarColumna(string sNombreColumna, Label lbResultado)
        {
            decimal deSuma = 0;

            foreach (DataGridViewRow DgvrFila in Dgv_presupuesto.Rows)
            {
                if (DgvrFila.Cells[sNombreColumna].Value != null &&
                    decimal.TryParse(DgvrFila.Cells[sNombreColumna].Value.ToString(), out decimal deValor))
                {
                    deSuma += deValor;
                }
            }
            lbResultado.Text = $"{deSuma}";
        }

        private void Dgv_presupuesto_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Reemplaza con la columna y label 
                SumarColumna("Column3", Txt_totalEnero);
                SumarColumna("Column4", Txt_totalFebrero);
                SumarColumna("Column5", Txt_totalMarzo);
                SumarColumna("Column6", Txt_totalAbril);
                SumarColumna("Column7", Txt_totalMayo);
                SumarColumna("Column8", Txt_totalJunio);
                SumarColumna("Column9", Txt_totalJulio);
                SumarColumna("Column10", Txt_totalAgosto);
                SumarColumna("Column11", Txt_totalSeptiembre);
                SumarColumna("Column12", Txt_totalOctubre);
                SumarColumna("Column13", Txt_totalNoviembre);
                SumarColumna("Column14", Txt_totalDiciembre);
                SumarColumna("Column15", Txt_totalAnual);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Obtener el valor del presupuesto anual y convertirlo a decimal
            AjustaValores();
        }

        private void AjustaValores()
        {
            decimal dePresupuestoAnual;

            if (decimal.TryParse(Txt_anualB.Text, out dePresupuestoAnual))
            {
                try { 
                // Dividir el presupuesto anual entre 12
                decimal deMontoMensual = dePresupuestoAnual / 12;

                // Asignar el monto mensual a los 12 TextBox
                Txt_eneroB.Text = deMontoMensual.ToString("F2");
                Txt_febreroB.Text = deMontoMensual.ToString("F2");
                Txt_marzoB.Text = deMontoMensual.ToString("F2");
                Txt_abrilB.Text = deMontoMensual.ToString("F2");
                Txt_mayoB.Text = deMontoMensual.ToString("F2");
                Txt_junioB.Text = deMontoMensual.ToString("F2");
                Txt_julioB.Text = deMontoMensual.ToString("F2");
                Txt_agostoB.Text = deMontoMensual.ToString("F2");
                Txt_septiembreB.Text = deMontoMensual.ToString("F2");
                Txt_octubreB.Text = deMontoMensual.ToString("F2");
                Txt_noviembreB.Text = deMontoMensual.ToString("F2");
                Txt_diciembreB.Text = deMontoMensual.ToString("F2");

                //Bitacora-------------!!!
                logicaSeg.funinsertarabitacora(sIdUsuario, $"Se ajusto el IdPres: {iIdPresupuestoP}", "Presupuesto", "8000");
                }catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto válido en el presupuesto anual.");
            }
        }

        private void Btn_incremento_Click(object sender, EventArgs e)
        {
            Incremento frmIncremento = new Incremento(sLlenadoP); // asume que Incremento tiene un constructor que recibe sLlenadoP
            frmIncremento.sLlenado = sLlenadoP;

            var vResultado = frmIncremento.ShowDialog();
            if (vResultado == DialogResult.OK)
            {
                decimal dePorcentaje = Convert.ToDecimal(frmIncremento.iDato);
                //Bitacora -----------------!!!
                logicaSeg.funinsertarabitacora(sIdUsuario, $"Se abrio form incremento", "Incremento", "8000");

                if (frmIncremento.bIncrementar)
                {
                    IncrementarTodosLosMeses(dePorcentaje);
                }
                else if (frmIncremento.bAnual)
                {
                    IncrementarAnual(dePorcentaje);
                }
                else
                {
                    //MessageBox.Show($"Mes seleccionado: {frmIncremento.sMesSelec}");
                    //MessageBox.Show(Convert.ToString(ObtenerTextBoxPorNombre(frmIncremento.sMesSelec)));
                    IncrementarMesEspecifico(dePorcentaje, frmIncremento.sMesSelec);
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada.");
            }
        }

        //Incremento de Meses IDK
        private void IncrementarAnual(decimal dePorcentaje)
        {
            decimal deValorAnual = Convert.ToDecimal(Txt_anualB.Text);
            // Calcular el incremento
            decimal deIncremento = deValorAnual * (dePorcentaje / 100);
            Txt_anualB.Text = (deValorAnual + deIncremento).ToString("F2");
            AjustaValores(); 
            MessageBox.Show("Se ajustaron los valores automaticamente","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Incremento de todos los meses
        public void IncrementarTodosLosMeses(decimal dePorcentaje)
        {
            foreach (var vMes in ObtenerTextBoxesDeMeses())
            {
                decimal deValorActual = Convert.ToDecimal(vMes.Text);
                decimal deIncremento = deValorActual * (dePorcentaje / 100);
                vMes.Text = (deValorActual + deIncremento).ToString("F2");
            }
        }

        //Incremento un mes especifico de una cuenta seleccionada.
        private void IncrementarMesEspecifico(decimal dePorcentaje, string sNombreMes)
        {
            TextBox txtMesSeleccionado = ObtenerTextBoxPorNombre(sNombreMes);

            if (txtMesSeleccionado != null)
            {
                decimal deValorActual = Convert.ToDecimal(txtMesSeleccionado.Text);
                decimal deIncremento = deValorActual * (dePorcentaje / 100);
                txtMesSeleccionado.Text = (deValorActual + deIncremento).ToString("F2");
            }
        }

        private List<TextBox> ObtenerTextBoxesDeMeses()
        {
            return new List<TextBox>
            {
                Txt_eneroB, Txt_febreroB, Txt_marzoB, Txt_abrilB ,Txt_mayoB, Txt_junioB, Txt_julioB, Txt_agostoB,Txt_septiembreB, Txt_octubreB, Txt_noviembreB, Txt_diciembreB
            };
        }

        private TextBox ObtenerTextBoxPorNombre(string sNombreMes)
        {
            string sNombreTextBox = $"Txt_{sNombreMes.ToLower()}B";
            //MessageBox.Show($"Buscando TextBox con nombre: {sNombreTextBox}"); //Comando
            return ObtenerTextBoxesDeMeses().FirstOrDefault(txt => txt.Name == sNombreTextBox);
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult diaResultado = MessageBox.Show("¿Está seguro de que desea eliminar este presupuesto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (diaResultado == DialogResult.Yes)
            {
                //Bitacora--------------------!!!
                logicaSeg.funinsertarabitacora(sIdUsuario, $"Se elimino el IdPres:{iIdPresupuestoP}", "tbl_detalle_presupuesto", "8000");

                // Llama al método del controlador para eliminar el presupuesto
                control.EliminarPresupuesto(iIdPresupuestoP);
                // Notificar al usuario que la eliminación fue exitosa
                MessageBox.Show("Presupuesto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Cambios Lunes
                LimpiarGrid();
                BloquearBotones();
                BloquearTextBox();
                Txt_anualB.Enabled = false;

                //Cerramos
                //this.Close();
            }
            else
            {
                // El usuario decidió no eliminar
                MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarFila(int iFila)
        {
                if (iFila >= 0 && iFila < Dgv_presupuesto.Rows.Count)
                    {
                        Txt_cuentaB.Text = Dgv_presupuesto.Rows[iFila].Cells["Column1"].Value.ToString();
                        Txt_descripcionB.Text = Dgv_presupuesto.Rows[iFila].Cells["Column2"].Value.ToString();
                        Txt_eneroB.Text = Dgv_presupuesto.Rows[iFila].Cells["Column3"].Value.ToString();
                        Txt_febreroB.Text = Dgv_presupuesto.Rows[iFila].Cells["Column4"].Value.ToString();
                        Txt_marzoB.Text = Dgv_presupuesto.Rows[iFila].Cells["Column5"].Value.ToString();
                        Txt_abrilB.Text = Dgv_presupuesto.Rows[iFila].Cells["Column6"].Value.ToString(); //Mod
                        Txt_mayoB.Text = Dgv_presupuesto.Rows[iFila].Cells["Column7"].Value.ToString();
                        Txt_junioB.Text = Dgv_presupuesto.Rows[iFila].Cells["Column8"].Value.ToString();
                        Txt_julioB.Text = Dgv_presupuesto.Rows[iFila].Cells["Column9"].Value.ToString();
                        Txt_agostoB.Text = Dgv_presupuesto.Rows[iFila].Cells["Column10"].Value.ToString();
                        Txt_septiembreB.Text = Dgv_presupuesto.Rows[iFila].Cells["Column11"].Value.ToString();
                        Txt_octubreB.Text = Dgv_presupuesto.Rows[iFila].Cells["Column12"].Value.ToString();
                        Txt_noviembreB.Text = Dgv_presupuesto.Rows[iFila].Cells["Column13"].Value.ToString();
                        Txt_diciembreB.Text = Dgv_presupuesto.Rows[iFila].Cells["Column14"].Value.ToString();
                        Txt_anualB.Text = Dgv_presupuesto.Rows[iFila].Cells["Column15"].Value.ToString();
                    }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            logicaSeg.funinsertarabitacora(sIdUsuario, $"Se cerro presupuesto", "Presupuesto", "8000");
            this.Close();
        }

        private void VerificacionText(KeyPressEventArgs e, TextBox tbTexto)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Cancela el evento si la entrada no es válida
            }

            if (e.KeyChar == '.' && tbTexto.Text.Contains("."))
            {
                e.Handled = true; // Cancelar si ya hay un punto
            }

            // Limitar a 2 decimales si ya hay un punto decimal
            if (tbTexto.Text.Contains("."))
            {
                int indexOfDecimal = tbTexto.Text.IndexOf('.');

                // Si el cursor está después del punto decimal y ya hay 2 dígitos, cancelar la entrada
                if (tbTexto.SelectionStart > indexOfDecimal && tbTexto.Text.Length - indexOfDecimal > 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void VerificacionVacio(TextBox tbTexto)
        {
            if (string.IsNullOrWhiteSpace(tbTexto.Text))
            {
                tbTexto.Text = "0.00"; // Asignar 0 si está vacío
                tbTexto.SelectionStart = 0;
                tbTexto.SelectionLength = tbTexto.Text.Length;// Coloca el cursor al final

            }

        }

        private void Txtbx_enero_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e,Txt_eneroB);
        }

        private void Txtbx_febrero_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txt_febreroB);
        }

        private void Txtbx_marzo_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txt_marzoB);
        }

        private void Txtbx_mayo_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txt_mayoB);
        }

        private void Txtbx_junio_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txt_junioB);
        }

        private void Txtbx_julio_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txt_julioB);
        }

        private void Txtbx_agosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txt_agostoB);
        }

        private void Txtbx_septiembre_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txt_septiembreB);
        }

        private void Txtbx_octubre_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txt_octubreB);
        }

        private void Txtbx_noviembre_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txt_noviembreB);
        }

        private void Txtbx_diciembre_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txt_diciembreB);
        }

        private void Txtbx_anual_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txt_anualB);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Opciones OpcionesForm = new Opciones();

            // Muestra el formulario Opciones
            if (OpcionesForm.ShowDialog() == DialogResult.OK)
            {
                // Cuando se cierra Opciones con OK, se pasan los valores
                sOperacionP = OpcionesForm.sOperacion;
                iIdPresupuestoP = OpcionesForm.iIdPresupuesto;
                sNombreP = OpcionesForm.sNombre;
                sLlenadoP = OpcionesForm.sLlenado;
                iIdPrepLlenadoP = OpcionesForm.sPrellenado;
                iEjercicio = OpcionesForm.iEjercicio;

                //Bitacora--------------------!!!
                logicaSeg.funinsertarabitacora(sIdUsuario, $"Se abrio Opciones", "Presupuesto", "8000");

                // Limpiamos el DataGrid
                LimpiarGrid();
                // Llama a la función para cargar datos
                CargarDatos();
            }
        }
        private void LimpiarGrid()
        {
            Dgv_presupuesto.Rows.Clear();
        }

        private void Btn_Informe_Click(object sender, EventArgs e)
        {
            ReportesPresupuesto reportes = new ReportesPresupuesto(iIdPresupuestoP);
            logicaSeg.funinsertarabitacora(sIdUsuario, $"Se abrio Reportes", "Reprotes Presupuesto", "8000");
            reportes.Show();
        }


        

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {

            try
            {
                // Buscar la carpeta raíz del proyecto (donde está la carpeta "Codigo")
                string executablePath = AppDomain.CurrentDomain.BaseDirectory;
                string projectRoot = executablePath;

                // Buscar hacia arriba hasta encontrar la carpeta "Codigo"
                while (!Directory.Exists(Path.Combine(projectRoot, "Codigo")) &&
                       Directory.GetParent(projectRoot) != null)
                {
                    projectRoot = Directory.GetParent(projectRoot).FullName;
                }

                // Construir la ruta a la carpeta de ayuda
                string ayudaFolderPath = Path.Combine(projectRoot, "Ayuda", "Modulos", "Contabilidad", "AyudaPresupuesto");

                //MessageBox.Show("Ruta de búsqueda: " + ayudaFolderPath);

                // Busca el archivo .chm en la carpeta especificada
                string pathAyuda = FindFileInDirectory(ayudaFolderPath, "AyudaModPresupuesto.chm");

                if (!string.IsNullOrEmpty(pathAyuda))
                {
                    Help.ShowHelp(null, pathAyuda, "AyudaPresupuesto.html");
                }
                else
                {
                    MessageBox.Show("El archivo de ayuda no se encontró.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el archivo de ayuda: " + ex.Message);
            }

        }

        //AyudasV2
        private string FindFileInDirectory(string directory, string fileName)
        {
            try
            {
                // Verificamos si la carpeta existe
                if (Directory.Exists(directory))
                {
                    // Buscamos el archivo .chm en la carpeta
                    string[] files = Directory.GetFiles(directory, "*.chm", SearchOption.TopDirectoryOnly);
                    // Si encontramos el archivo, verificamos si coincide con el archivo que se busca y retornamos su ruta
                    foreach (var file in files)
                    {
                        if (Path.GetFileName(file).Equals(fileName, StringComparison.OrdinalIgnoreCase))
                        {
                            //MessageBox.Show("Archivo encontrado: " + file);
                            return file;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la carpeta: " + directory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el archivo: " + ex.Message);
            }
            // Retorna null si no se encontró el archivo
            return null;
        }

        private void Txtbx_enero_Leave(object sender, EventArgs e)
        {
            VerificacionVacio(Txt_eneroB);
        }

        private void Txtbx_febrero_Leave(object sender, EventArgs e)
        {
            VerificacionVacio(Txt_febreroB);
        }

        private void Txtbx_marzo_Leave(object sender, EventArgs e)
        {
            VerificacionVacio(Txt_marzoB);
        }

        private void Txtbx_mayo_Leave(object sender, EventArgs e)
        {
            VerificacionVacio(Txt_mayoB);
        }

        private void Txtbx_junio_Leave(object sender, EventArgs e)
        {
            VerificacionVacio(Txt_junioB);
        }

        private void Txtbx_julio_Leave(object sender, EventArgs e)
        {
            VerificacionVacio(Txt_julioB);
        }

        private void Txtbx_agosto_Leave(object sender, EventArgs e)
        {
            VerificacionVacio(Txt_agostoB);
        }

        private void Txtbx_septiembre_Leave(object sender, EventArgs e)
        {
            VerificacionVacio(Txt_septiembreB);
        }

        private void Txtbx_octubre_Leave(object sender, EventArgs e)
        {
            VerificacionVacio(Txt_octubreB);
        }

        private void Txtbx_noviembre_Leave(object sender, EventArgs e)
        {
            VerificacionVacio(Txt_noviembreB);
        }

        private void Txtbx_diciembre_Leave(object sender, EventArgs e)
        {
            VerificacionVacio(Txt_diciembreB);
        }

        private void Txtbx_anual_Leave(object sender, EventArgs e)
        {
            VerificacionVacio(Txt_febreroB);
        }

        private void Txt_abrilB_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column6", Txt_abrilB);
            //VerificacionVacio(Txtbx_abril);
            SumaDeValores();
        }

        private void Txt_abrilB_Leave(object sender, EventArgs e)
        {
            VerificacionVacio(Txt_abrilB);
        }

        private void Txt_abrilB_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txt_abrilB);
        }
    }
}
