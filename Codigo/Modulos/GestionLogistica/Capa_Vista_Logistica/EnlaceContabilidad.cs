using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Capa_Controlador_Seguridad;
using Capa_Controlador_Logistica;
#pragma warning disable CS0414

namespace Capa_Vista_Logistica
{
    public partial class Frm_Polizas : Form
    {
        private string sidcuenta;
        private string sidoperacion;
        private string sidtp;
        List<object[]> ldetalles = new List<object[]>();
        int iCorrecto = 0;

        //Seguridad y usuario
        private string sidUsuario;

        public void SetParametro(string svalor)
        {
            sidUsuario = svalor;
        }

        public Frm_Polizas()
        {
            InitializeComponent();

            llenarseCuentas("tbl_cuentas", "Pk_id_cuenta", "nombre_cuenta");
            llenarseTP("tbl_tipopoliza", "Pk_id_tipopoliza", "tipo");
            llenarseOP("tbl_tipooperacion", "Pk_id_tipooperacion", "nombre");

            //Botones y demas 
            Cbo_Cuenta.Enabled = false;
            Cbo_operacion.Enabled = false;
            Cbo_tipopoliza.Enabled = false;
            Txt_concepto.Enabled = false;
            Txt_valor.Enabled = false;
            Dpt_fecha.Enabled = false;
            Btn_quitar.Enabled = false;
            Btn_aceptar.Enabled = false;
            Btn_registrar_poliza.Enabled = false;
            Btn_Cancelar.Enabled = false;
        }

        // ---------------------------------- COMBO BOX CUENTAS ----------------------------------

        public void llenarseCuentas(string stabla, string scampo1, string scampo2)
        {
            Controlador ctr = new Controlador(); // Instancia controlador

            string stbl = stabla;
            string scmp1 = scampo1;
            string scmp2 = scampo2;

            Cbo_Cuenta.ValueMember = scmp1;
            Cbo_Cuenta.DisplayMember = scmp2;

            string[] items = ctr.itemsCuenta(stabla, scampo1, scampo2);

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        Cbo_Cuenta.Items.Add(items[i]);
                    }
                }
            }

            var dt2 = ctr.enviarCuentas(stabla, scampo1, scampo2);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[scampo2]));
            }

            Cbo_Cuenta.DataSource = dt2;
            Cbo_Cuenta.ValueMember = scampo1;
            Cbo_Cuenta.DisplayMember = scampo2;

            Cbo_Cuenta.AutoCompleteCustomSource = coleccion;
            Cbo_Cuenta.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_Cuenta.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // ---------------------------------- COMBO BOX TIPO POLIZA ----------------------------------

        public void llenarseTP(string stabla, string scampo1, string scampo2)
        {
            Controlador ctr = new Controlador(); // Instancia controlador

            string tbl = stabla;
            string cmp1 = scampo1;
            string cmp2 = scampo2;

            Cbo_tipopoliza.ValueMember = scampo1;
            Cbo_tipopoliza.DisplayMember = scampo2;

            string[] items = ctr.itemsTP(stabla, scampo1, scampo2);

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        Cbo_tipopoliza.Items.Add(items[i]);
                    }
                }
            }

            var dt2 = ctr.enviarTP(stabla, scampo1, scampo2);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[scampo1]) + "-" + Convert.ToString(row[scampo2]));
                coleccion.Add(Convert.ToString(row[scampo2]) + "-" + Convert.ToString(row[scampo1]));
            }

            Cbo_tipopoliza.DataSource = dt2;
            Cbo_tipopoliza.ValueMember = scampo1;
            Cbo_tipopoliza.DisplayMember = scampo2;

            Cbo_tipopoliza.AutoCompleteCustomSource = coleccion;
            Cbo_tipopoliza.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_tipopoliza.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // ---------------------------------- COMBO BOX OPERACION ----------------------------------

        public void llenarseOP(string stabla, string scampo1, string scampo2)
        {
            Controlador ctr = new Controlador(); // Instancia controlador

            string tbl = stabla;
            string cmp1 = scampo1;
            string cmp2 = scampo2;

            Cbo_operacion.ValueMember = scampo1;
            Cbo_operacion.DisplayMember = scampo2;

            string[] items = ctr.itemsOP(stabla, scampo1, scampo2);

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        Cbo_operacion.Items.Add(items[i]);
                    }
                }
            }

            var dt2 = ctr.enviarOP(stabla, scampo1, scampo2);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[scampo2]));
            }

            Cbo_operacion.DataSource = dt2;
            Cbo_operacion.ValueMember = scampo1;
            Cbo_operacion.DisplayMember = scampo2;

            Cbo_operacion.AutoCompleteCustomSource = coleccion;
            Cbo_operacion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_operacion.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void cbtipopoliza_SelectedIndexChanged(object sender, EventArgs e)
        {
            sidtp = Cbo_tipopoliza.SelectedValue.ToString();
        }

        private void cboperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            sidoperacion = Cbo_operacion.SelectedValue.ToString();
        }

        private void cbCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            sidcuenta = Cbo_Cuenta.SelectedValue.ToString();
        }
        private void btn_nueva_poliza_Click(object sender, EventArgs e)
        {
            Cbo_Cuenta.Enabled = true;
            Cbo_operacion.Enabled = true;
            Cbo_tipopoliza.Enabled = true;
            Txt_concepto.Enabled = true;
            Txt_valor.Enabled = true;
            Dpt_fecha.Enabled = true;
            Btn_aceptar.Enabled = true;
            Btn_quitar.Enabled = true;
            Btn_registrar_poliza.Enabled = true;
            Btn_Cancelar.Enabled = true;

            //Bandera de prueba
            MessageBox.Show("Empieza el ingreso de una poliza");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Restablecer los ComboBox a su estado inicial (sin selección)
            Cbo_Cuenta.SelectedIndex = 0;
            Cbo_operacion.SelectedIndex = 0;
            Cbo_tipopoliza.SelectedIndex = 0;

            // Limpiar los TextBox
            Txt_concepto.Clear();
            Txt_valor.Clear();

            // Restablecer la fecha en el DateTimePicker a la fecha actual (o a cualquier valor que desees)
            Dpt_fecha.Value = DateTime.Now;

            // Opcional: Desactivar los controles si es parte del proceso
            Cbo_Cuenta.Enabled = false;
            Cbo_operacion.Enabled = false;
            Cbo_tipopoliza.Enabled = false;
            Txt_concepto.Enabled = false;
            Txt_valor.Enabled = false;
            Dpt_fecha.Enabled = false;
            Btn_aceptar.Enabled = false;
            Btn_quitar.Enabled = false;
            Btn_registrar_poliza.Enabled = false;
            Btn_Cancelar.Enabled = false;

            //Vaciar labels
            Txt_AbonoTot.Text = "00.00";
            Txt_CargoTot.Text = "00.00";

            //Vaciar el DataGridView
            Dgv_Polizas.Rows.Clear();

            // Para eliminar el error asociado a un control, como textBox1
            errorProvider1.SetError(Txt_concepto, "");


            // Mostrar un mensaje de confirmación (opcional)
            MessageBox.Show("Se ha cancelado la creación de la póliza");

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //Se obtiene los valores de los txtbox
            string sconcepto = Txt_concepto.Text;
            string svalor = Txt_valor.Text;

            if (string.IsNullOrEmpty(svalor))
            {
                MessageBox.Show("Por favor, ingrese un valor.");
                return;
            }

            // Obtener el valor del DateTimePicker
            DateTime dtfechaSeleccionada = Dpt_fecha.Value;

            // Obtener el ID y nombre de la cuenta seleccionada
            string scuentaSeleccionada = Cbo_Cuenta.Text;
            string sidcuenta = Cbo_Cuenta.SelectedValue?.ToString();

            // Verificar si la cuenta es válida
            if (string.IsNullOrEmpty(sidcuenta))
            {
                MessageBox.Show("Por favor, seleccione una cuenta válida.");
                return;
            }

            // Obtener el ID y nombre de la operación seleccionada
            string soperacionSeleccionada = Cbo_operacion.Text;
            string sidoperacion = Cbo_operacion.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(sidoperacion))
            {
                MessageBox.Show("Por favor, seleccione una operación válida.");
                return;
            }

            // Verificar si es Cargo o Abono
            string scargo = "";
            string sabono = "";

            //Ver si es cargo o abono
            if (soperacionSeleccionada.Equals("Cargo", StringComparison.OrdinalIgnoreCase))
            {
                scargo = svalor;
                sabono = "";
            }
            else if (soperacionSeleccionada.Equals("Abono", StringComparison.OrdinalIgnoreCase))
            {
                sabono = svalor;
                scargo = "";
            }
            else
            {
                MessageBox.Show("Seleccione una operación válida (Cargo o Abono).");
                return;
            }

            // Agregar una nueva fila al DataGridView con los valores correctos
            Dgv_Polizas.Rows.Add(sidcuenta, scuentaSeleccionada, scargo, sabono);

            //Probando el jalar valores
            //MessageBox.Show($"Concepto: {concepto}\nFecha: {fechaSeleccionada.ToShortDateString()}\nValor: {valor}\nCuenta: {cuentaSeleccionada} (ID: {idcuenta})\nOperación: {operacionSeleccionada} (ID: {idoperacion})\nCargo: {cargo}\nAbono: {abono} \n Tipo: {idtp}");

            // Limpiar los campos después de agregar (opcional)
            SumarColumnas();
            LimpiarCamposDetelle();
        }

        public void LimpiarCamposDetelle()
        {
            Txt_valor.Clear();
            Cbo_Cuenta.SelectedIndex = 0;
            Cbo_operacion.SelectedIndex = 0;
        }

        public void LimpiarCamposEnc()
        {
            Cbo_tipopoliza.SelectedIndex = 0;
            Txt_concepto.Text = "";
            Txt_AbonoTot.Text = "00.00";
            Txt_CargoTot.Text = "00.00";
        }

        private void dgvPolizas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Dgv_Polizas.Rows[e.RowIndex];

                // Aquí puedes acceder a los valores de la fila seleccionada
                string scuenta = row.Cells["Cuenta"].Value.ToString();
                string scargo = row.Cells["Cargo"].Value.ToString();

                // Mostrar información o hacer algo con los valores seleccionados
                MessageBox.Show($"Cuenta: {scuenta}, Cargo: {scargo}");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            // Verifica que haya al menos una fila seleccionada
            if (Dgv_Polizas.SelectedRows.Count > 0)
            {
                // Confirmar eliminación si quieres (opcional)
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas quitar esta fila?", "Confirmación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Elimina la fila seleccionada
                    foreach (DataGridViewRow row in Dgv_Polizas.SelectedRows)
                    {
                        Dgv_Polizas.Rows.RemoveAt(row.Index);
                        MessageBox.Show("Se quitó la cuenta", "Aviso");
                    }
                }
            }
            else
            {
                // Si no hay fila seleccionada, mostrar un mensaje
                MessageBox.Show("Por favor selecciona una fila para quitar.", "Aviso");
            }

            SumarColumnas();
        }

        public void SumarColumnas()
        {
            // Variables para almacenar las sumas
            decimal desumaCargo = 0;
            decimal desumaAbono = 0;

            // Recorrer todas las filas del DataGridView
            foreach (DataGridViewRow row in Dgv_Polizas.Rows)
            {
                // Asegurarse de que la fila no esté vacía
                if (row.Cells["Cargo"].Value != null && row.Cells["Abono"].Value != null)
                {
                    // Sumar la columna Cargo
                    decimal decargo;
                    if (decimal.TryParse(row.Cells["Cargo"].Value.ToString(), out decargo))
                    {
                        desumaCargo += decargo;
                    }

                    // Sumar la columna Abono
                    decimal deabono;
                    if (decimal.TryParse(row.Cells["Abono"].Value.ToString(), out deabono))
                    {
                        desumaAbono += deabono;
                    }
                }
            }

            // Mostrar las sumas en los TextBox correspondientes
            Txt_CargoTot.Text = desumaCargo.ToString("N2"); // Formato numérico con 2 decimales
            Txt_AbonoTot.Text = desumaAbono.ToString("N2"); // Formato numérico con 2 decimales
        }

        private void btn_registar_poliza_Click(object sender, EventArgs e)
        {
            //Capa_controlador_Seguridad
            logica lg = new logica();

            //Variable usuario
            string sIdUsuario = sidUsuario;

            if (Txt_CargoTot.Text != Txt_AbonoTot.Text)
            {
                MessageBox.Show("Los totales del cargo y abono no son iguales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (Dgv_Polizas.Rows.Count == 0 || Dgv_Polizas.Rows.Cast<DataGridViewRow>().All(row => row.IsNewRow))
                {
                    MessageBox.Show("El detalle de la póliza está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Controlador ctr = new Controlador();
                    string sfechaSeleccionada = Dpt_fecha.Text;
                    string sconcepto = Txt_concepto.Text;

                    errorProvider1.SetError(Txt_concepto, "");

                    // Verificar si el TextBox está vacío
                    if (string.IsNullOrWhiteSpace(Txt_concepto.Text))
                    {
                        errorProvider1.SetError(Txt_concepto, "Este campo es obligatorio.");
                        Txt_concepto.Focus();
                        MessageBox.Show("El campo es obligatorio. Por favor, ingrese un valor.", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Seguro que desea crear la póliza?", "Confirmación", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            if (Cbo_tipopoliza.SelectedValue == null || Cbo_operacion.SelectedValue == null || Cbo_Cuenta.SelectedValue == null)
                            {
                                MessageBox.Show("Por favor, seleccione todos los campos requeridos.");
                                return;
                            }

                            int iidTipoPoliza = int.Parse(sidtp);
                            ldetalles.Clear();

                            foreach (DataGridViewRow row in Dgv_Polizas.Rows)
                            {
                                int iidop = 0;
                                if (row.IsNewRow) continue;

                                int iidCuenta = Convert.ToInt32(row.Cells["Codigo"].Value);
                                string stipoOperacion = "";
                                decimal devalor = 0;

                                if (row.Cells[2].Value != DBNull.Value && row.Cells[2].Value.ToString() != "")
                                {
                                    stipoOperacion = "Cargo";
                                    iidop = 1;
                                    devalor = Convert.ToDecimal(row.Cells[2].Value);
                                }
                                else if (row.Cells[3].Value != DBNull.Value && row.Cells[3].Value.ToString() != "")
                                {
                                    stipoOperacion = "Abono";
                                    iidop = 2;
                                    devalor = Convert.ToDecimal(row.Cells[3].Value);
                                }

                                object[] ldetalle = new object[3] { iidCuenta, iidop, devalor };
                                ldetalles.Add(ldetalle);

                                ctr.ActualizarTblCuentas(iidCuenta, stipoOperacion, devalor);
                            }

                            ctr.LlenarEncabezado(sfechaSeleccionada, sconcepto, iidTipoPoliza);
                            ctr.LlenarDetalle(sfechaSeleccionada, sconcepto, ldetalles);

                            LimpiarCamposDetelle();
                            LimpiarCamposEnc();
                            Dgv_Polizas.Rows.Clear();

                            MessageBox.Show("Se registró correctamente");
                        }
                        else
                        {
                            MessageBox.Show("Se canceló el proceso", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            //Bitacora
            lg.funinsertarabitacora(sIdUsuario, "Se creó una póliza", "tbl_polizaencabezado", "8000");
            lg.funinsertarabitacora(sIdUsuario, "Se creó un detalle de póliza", "tbl_polizadetalle", "8000");
            lg.funinsertarabitacora(sIdUsuario, "Se actualizaron cuentas", "tbl_cuentas", "8000");
            lg.funinsertarabitacora(sIdUsuario, "Se actualizaron cuentas", "tbl_historico_cuentas", "8000");
        }

        private void Polizas_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(218, 247, 245);

            // Crear una instancia de ToolTip
            ToolTip ttCrear = new ToolTip();
            ToolTip ttGuardar = new ToolTip();
            ToolTip ttCancelar = new ToolTip();
            ToolTip ttAyuda = new ToolTip();
            ToolTip ttSalir = new ToolTip();
            ToolTip ttCheck = new ToolTip();
            ToolTip ttQuitar = new ToolTip();
            ToolTip ttAviso = new ToolTip();

            // Configurar el ToolTip
            ttCrear.AutoPopDelay = 5000;
            ttCrear.InitialDelay = 1000;
            ttCrear.ReshowDelay = 500;
            ttCrear.ShowAlways = true;

            ttGuardar.AutoPopDelay = 5000;
            ttGuardar.InitialDelay = 1000;
            ttGuardar.ReshowDelay = 500;
            ttGuardar.ShowAlways = true;

            ttCancelar.AutoPopDelay = 5000;
            ttCancelar.InitialDelay = 1000;
            ttCancelar.ReshowDelay = 500;
            ttCancelar.ShowAlways = true;

            ttAyuda.AutoPopDelay = 5000;
            ttAyuda.InitialDelay = 1000;
            ttAyuda.ReshowDelay = 500;
            ttAyuda.ShowAlways = true;

            ttSalir.AutoPopDelay = 5000;
            ttSalir.InitialDelay = 1000;
            ttSalir.ReshowDelay = 500;
            ttSalir.ShowAlways = true;

            ttCheck.AutoPopDelay = 5000;
            ttCheck.InitialDelay = 1000;
            ttCheck.ReshowDelay = 500;
            ttCheck.ShowAlways = true;

            ttQuitar.AutoPopDelay = 5000;
            ttQuitar.InitialDelay = 1000;
            ttQuitar.ReshowDelay = 500;
            ttQuitar.ShowAlways = true;

            ttAviso.AutoPopDelay = 5000;
            ttAviso.InitialDelay = 1000;
            ttAviso.ReshowDelay = 500;
            ttAviso.ShowAlways = true;

            // Asignar el ToolTip a un control (ejemplo: botón)
            ttCrear.SetToolTip(this.Btn_nueva_poliza, "Crear nueva póliza");
            ttGuardar.SetToolTip(this.Btn_registrar_poliza, "Registrar póliza");
            ttCancelar.SetToolTip(this.Btn_Cancelar, "Cancelar creación de póliza");
            ttAyuda.SetToolTip(this.Btn_ayuda, "Mostrar ayuda");
            ttSalir.SetToolTip(this.Btn_salir, "Salir");
            ttCheck.SetToolTip(this.Btn_aceptar, "Aceptar cuenta");
            ttQuitar.SetToolTip(this.Btn_quitar, "Quitar cuenta");
            ttAviso.SetToolTip(this.Txt_concepto, "Agregar concepto");

            if (Dgv_Polizas.Rows.Count == 1 && Dgv_Polizas.Rows[0].IsNewRow)
            {
                Btn_quitar.Enabled = false; // Deshabilitar el botón si solo hay la fila en blanco
            }
            else
            {
                Btn_quitar.Enabled = true; // Habilitar el botón si hay otras filas
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            var vtextBox = sender as TextBox;

            // Permitir solo dígitos, un punto decimal y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Evitar la entrada
                return;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && vtextBox.Text.IndexOf('.') > -1)
            {
                e.Handled = true; // Evitar la entrada
                return;
            }

            // Limitar a dos decimales
            if (vtextBox.Text.IndexOf('.') > -1)
            {
                // Contar la cantidad de decimales actuales
                int decimalPlaces = vtextBox.Text.Substring(vtextBox.Text.IndexOf('.') + 1).Length;
                if (decimalPlaces >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; // Evitar la entrada si ya hay 2 decimales
                }
            }
        }

        private void dtpfecha_ValueChanged(object sender, EventArgs e)
        {
            if (Dpt_fecha.Value.Date != DateTime.Today)
            {
                Dpt_fecha.Value = DateTime.Today;
            }
        }

        /*public void AsignarAyuda(string sAyudar)
        {
            controladorPolizas ctr = new controladorPolizas();

            string sAyudaOK = ctr.TestTabla("ayuda");

            if (sAyudaOK == "")
            {
                if (ctr.ContarRegAyuda(sAyudar) > 0)
                {
                    sIdAyuda = sAyudar;
                    RutaAyuda = ctr.ModRuta(sIdAyuda);
                    IndiceAyuda = ctr.ModIndice(sIdAyuda);
                    if (RutaAyuda == "" || IndiceAyuda == "" || RutaAyuda == null || IndiceAyuda == null)
                    {
                        DialogResult drValidacion = MessageBox.Show("La Ruta o índice de la ayuda está vacía", "Verificación de requisitos", MessageBoxButtons.OK);
                        if (drValidacion == DialogResult.OK)
                        {
                            iCorrecto = 1;
                        }
                    }
                }
                else
                {
                    DialogResult drValidacion = MessageBox.Show("Por favor verifique el id de Ayuda asignado al form", "Verificación de requisitos", MessageBoxButtons.OK);
                    if (drValidacion == DialogResult.OK)
                    {
                        iCorrecto = 1;
                    }
                }

            }
            else
            {
                DialogResult drValidacion = MessageBox.Show(sAyudaOK + ", Por favor incluirla", "Verificación de requisitos", MessageBoxButtons.OK);
                if (drValidacion == DialogResult.OK)
                {
                    iCorrecto = 1;
                }
            }
        }*/

        private void txtValor_Leave(object sender, EventArgs e)
        {
            var vtextBox = sender as TextBox;
            // Intenta convertir el texto a decimal
            if (decimal.TryParse(vtextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal result))
            {
                // Redondear a 2 decimales y convertir a string con 2 decimales
                vtextBox.Text = Math.Round(result, 2).ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Ingrese un número válido con hasta dos decimales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                vtextBox.Focus();
            }
        }

        public string FindFileInDirectory(string directory, string fileName)
        {
            try
            {
                // Verificamos si la carpeta existe
                if (Directory.Exists(directory))
                {
                    // Buscamos el archivo .chm en la carpeta
                    string[] sfiles = Directory.GetFiles(directory, "*.chm", SearchOption.TopDirectoryOnly);

                    // Si encontramos el archivo, verificamos si coincide con el archivo que se busca y retornamos su ruta
                    foreach (var file in sfiles)
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
                MessageBox.Show("Error al buscar ayuda: " + ex.Message);
            }

            // Retorna null si no se encontró el archivo
            return null;
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la ruta del directorio del ejecutable
                string sexecutablePath = AppDomain.CurrentDomain.BaseDirectory;

                // Retroceder a la carpeta del proyecto
                string sprojectPath = Path.GetFullPath(Path.Combine(sexecutablePath, @"..\..\"));
                //MessageBox.Show("1" + projectPath);

                // Combinar con la ruta fija de "asis22k24proy2\Codigo\Componentes\Seguridad"
                string sbasePath = Path.Combine(sprojectPath, @"asis22k24proy2\Codigo\Modulos\Menus\ModernGUI_V3\AyudaEnlace");
                //MessageBox.Show("2" + basePath);


                string sayudaFolderPath = Path.Combine(sprojectPath, "AyudaEnlace");

                // Imprimir la ruta de ayuda para verificar
                //MessageBox.Show("3: " + ayudaFolderPath);

                // Busca el archivo .chm en la carpeta "Ayuda_Seguridad"
                string spathAyuda = FindFileInDirectory(sayudaFolderPath, "AyudaPolizas.chm");

                // Verifica si el archivo existe antes de intentar abrirlo
                if (!string.IsNullOrEmpty(spathAyuda))
                {
                    //MessageBox.Show("El archivo sí está.");
                    // Abre el archivo de ayuda .chm en la sección especificada
                    Help.ShowHelp(null, spathAyuda, "AyudaEnlace.html");
                }
                else
                {
                    // Si el archivo no existe, muestra un mensaje de error
                    MessageBox.Show("El archivo de ayuda no se encontró.");
                }
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de una excepción
                MessageBox.Show("Ocurrió un error al abrir la ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al abrir la ayuda: " + ex.ToString());
            }
        }
    }
}



