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
using Capa_Controlador_Cuentas_Corrientes;

namespace Capa_Vista_Cuentas_Corrientes
{
    public partial class frmPolizas : Form
    {
        private string idcuenta;
        private string idoperacion;
        private string idtp;
        List<object[]> detalles = new List<object[]>();

        public frmPolizas()
        {
            InitializeComponent();
            llenarseCuentas("tbl_cuentas", "Pk_id_cuenta", "nombre_cuenta");
            llenarseTP("tbl_tipopoliza", "Pk_id_tipopoliza", "tipo");
            llenarseOP("tbl_tipooperacion", "Pk_id_tipooperacion", "nombre");

            //Botones y demas 
            cbCuenta.Enabled = false;
            cboperacion.Enabled = false;
            cbtipopoliza.Enabled = false;
            txtConcepto.Enabled = false;
            txtValor.Enabled = false;
            dtpfecha.Enabled = false;
            btnQuitar.Enabled = false;
            btn_aceptar.Enabled = false;
        }

        // ---------------------------------- COMBO BOX CUENTAS ----------------------------------

        public void llenarseCuentas(string tabla, string campo1, string campo2)
        {
            Controlador ctr = new Controlador(); // Instancia controlador

            string tbl = tabla;
            string cmp1 = campo1;
            string cmp2 = campo2;

            cbCuenta.ValueMember = cmp1;
            cbCuenta.DisplayMember = cmp2;

            string[] items = ctr.itemsCuenta(tabla, campo1, campo2);

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        cbCuenta.Items.Add(items[i]);
                    }
                }
            }

            var dt2 = ctr.enviarCuentas(tabla, campo1, campo2);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo2]));
            }

            cbCuenta.DataSource = dt2;
            cbCuenta.ValueMember = campo1;
            cbCuenta.DisplayMember = campo2;

            cbCuenta.AutoCompleteCustomSource = coleccion;
            cbCuenta.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbCuenta.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // ---------------------------------- COMBO BOX TIPO CUENTA ----------------------------------

        public void llenarseTP(string tabla, string campo1, string campo2)
        {
            Controlador ctr = new Controlador(); // Instancia controlador

            string tbl = tabla;
            string cmp1 = campo1;
            string cmp2 = campo2;

            cbtipopoliza.ValueMember = campo1;
            cbtipopoliza.DisplayMember = campo2;

            string[] items = ctr.itemsTP(tabla, campo1, campo2);

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        cbtipopoliza.Items.Add(items[i]);
                    }
                }
            }

            var dt2 = ctr.enviarTP(tabla, campo1, campo2);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
                coleccion.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));
            }

            cbtipopoliza.DataSource = dt2;
            cbtipopoliza.ValueMember = campo1;
            cbtipopoliza.DisplayMember = campo2;

            cbtipopoliza.AutoCompleteCustomSource = coleccion;
            cbtipopoliza.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbtipopoliza.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // ---------------------------------- COMBO BOX OPERACION ----------------------------------

        public void llenarseOP(string tabla, string campo1, string campo2)
        {
            Controlador ctr = new Controlador(); // Instancia controlador

            string tbl = tabla;
            string cmp1 = campo1;
            string cmp2 = campo2;

            cboperacion.ValueMember = campo1;
            cboperacion.DisplayMember = campo2;

            string[] items = ctr.itemsOP(tabla, campo1, campo2);

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        cboperacion.Items.Add(items[i]);
                    }
                }
            }

            var dt2 = ctr.enviarOP(tabla, campo1, campo2);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo2]));
            }

            cboperacion.DataSource = dt2;
            cboperacion.ValueMember = campo1;
            cboperacion.DisplayMember = campo2;

            cboperacion.AutoCompleteCustomSource = coleccion;
            cboperacion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboperacion.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void cbtipopoliza_SelectedIndexChanged(object sender, EventArgs e)
        {
            idtp = cbtipopoliza.SelectedValue.ToString();
        }

        private void cboperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            idoperacion = cboperacion.SelectedValue.ToString();
        }

        private void cbCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            idcuenta = cbCuenta.SelectedValue.ToString();
        }
        private void btn_nueva_poliza_Click(object sender, EventArgs e)
        {
            cbCuenta.Enabled = true;
            cboperacion.Enabled = true;
            cbtipopoliza.Enabled = true;
            txtConcepto.Enabled = true;
            txtValor.Enabled = true;
            dtpfecha.Enabled = true;
            btn_aceptar.Enabled = true;
            btnQuitar.Enabled = true;

            //Bandera de prueba
            MessageBox.Show("Empieza el ingreso de una poliza");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Restablecer los ComboBox a su estado inicial (sin selección)
            cbCuenta.SelectedIndex = 0;
            cboperacion.SelectedIndex = 0;
            cbtipopoliza.SelectedIndex = 0;

            // Limpiar los TextBox
            txtConcepto.Clear();
            txtValor.Clear();

            // Restablecer la fecha en el DateTimePicker a la fecha actual (o a cualquier valor que desees)
            dtpfecha.Value = DateTime.Now;

            // Opcional: Desactivar los controles si es parte del proceso
            cbCuenta.Enabled = false;
            cboperacion.Enabled = false;
            cbtipopoliza.Enabled = false;
            txtConcepto.Enabled = false;
            txtValor.Enabled = false;
            dtpfecha.Enabled = false;
            btn_aceptar.Enabled = false;
            btnQuitar.Enabled = false;

            //Vaciar labels
            lblAbono.Text = "00.00";
            lblCargo.Text = "00.00";

            //Vaciar el DataGridView
            dgvPolizas.Rows.Clear();

            // Mostrar un mensaje de confirmación (opcional)
            MessageBox.Show("Se ha cancelado la creación de la póliza");

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //Se obtiene los valores de los txtbox
            string concepto = txtConcepto.Text;
            string valor = txtValor.Text;

            if (string.IsNullOrEmpty(valor))
            {
                MessageBox.Show("Por favor, ingrese un valor.");
                return;
            }

            // Obtener el valor del DateTimePicker
            DateTime fechaSeleccionada = dtpfecha.Value;

            // Obtener el ID y nombre de la cuenta seleccionada
            string cuentaSeleccionada = cbCuenta.Text;
            string idcuenta = cbCuenta.SelectedValue?.ToString();

            // Verificar si la cuenta es válida
            if (string.IsNullOrEmpty(idcuenta))
            {
                MessageBox.Show("Por favor, seleccione una cuenta válida.");
                return;
            }

            // Obtener el ID y nombre de la operación seleccionada
            string operacionSeleccionada = cboperacion.Text;
            string idoperacion = cboperacion.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(idoperacion))
            {
                MessageBox.Show("Por favor, seleccione una operación válida.");
                return;
            }

            // Verificar si es Cargo o Abono
            string cargo = "";
            string abono = "";

            //Ver si es cargo o abono
            if (operacionSeleccionada.Equals("Cargo", StringComparison.OrdinalIgnoreCase))
            {
                cargo = valor;
                abono = "";
            }
            else if (operacionSeleccionada.Equals("Abono", StringComparison.OrdinalIgnoreCase))
            {
                abono = valor;
                cargo = "";
            }
            else
            {
                MessageBox.Show("Seleccione una operación válida (Cargo o Abono).");
                return;
            }

            // Agregar una nueva fila al DataGridView con los valores correctos
            dgvPolizas.Rows.Add(idcuenta, cuentaSeleccionada, cargo, abono);

            //Probando el jalar valores
            MessageBox.Show($"Concepto: {concepto}\nFecha: {fechaSeleccionada.ToShortDateString()}\nValor: {valor}\nCuenta: {cuentaSeleccionada} (ID: {idcuenta})\nOperación: {operacionSeleccionada} (ID: {idoperacion})\nCargo: {cargo}\nAbono: {abono} \n Tipo: {idtp}");

            // Limpiar los campos después de agregar (opcional)
            SumarColumnas();
            LimpiarCamposDetelle();
        }

        private void LimpiarCamposDetelle()
        {
            txtValor.Clear();
            cbCuenta.SelectedIndex = 0;
            cboperacion.SelectedIndex = 0;
        }

        private void LimpiarCamposEnc()
        {
            cbtipopoliza.SelectedIndex = 0;
            txtConcepto.Text = "";
            lblAbono.Text = "00.00";
            lblCargo.Text = "00.00";
        }

        private void dgvPolizas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPolizas.Rows[e.RowIndex];

                // Aquí puedes acceder a los valores de la fila seleccionada
                string cuenta = row.Cells["Cuenta"].Value.ToString();
                string cargo = row.Cells["Cargo"].Value.ToString();

                // Mostrar información o hacer algo con los valores seleccionados
                MessageBox.Show($"Cuenta: {cuenta}, Cargo: {cargo}");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            // Verifica que haya al menos una fila seleccionada
            if (dgvPolizas.SelectedRows.Count > 0)
            {
                // Confirmar eliminación si quieres (opcional)
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas quitar esta fila?", "Confirmación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Elimina la fila seleccionada
                    foreach (DataGridViewRow row in dgvPolizas.SelectedRows)
                    {
                        dgvPolizas.Rows.RemoveAt(row.Index);
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

        private void SumarColumnas()
        {
            // Variables para almacenar las sumas
            decimal sumaCargo = 0;
            decimal sumaAbono = 0;

            // Recorrer todas las filas del DataGridView
            foreach (DataGridViewRow row in dgvPolizas.Rows)
            {
                // Asegurarse de que la fila no esté vacía
                if (row.Cells["Cargo"].Value != null && row.Cells["Abono"].Value != null)
                {
                    // Sumar la columna Cargo
                    decimal cargo;
                    if (decimal.TryParse(row.Cells["Cargo"].Value.ToString(), out cargo))
                    {
                        sumaCargo += cargo;
                    }

                    // Sumar la columna Abono
                    decimal abono;
                    if (decimal.TryParse(row.Cells["Abono"].Value.ToString(), out abono))
                    {
                        sumaAbono += abono;
                    }
                }
            }

            // Mostrar las sumas en los TextBox correspondientes
            lblCargo.Text = sumaCargo.ToString("N2"); // Formato numérico con 2 decimales
            lblAbono.Text = sumaAbono.ToString("N2"); // Formato numérico con 2 decimales
        }

        private void btn_registar_poliza_Click(object sender, EventArgs e)
        {
            // Inicializar el controlador
            Controlador ctr = new Controlador();

            string fechaSeleccionada = dtpfecha.Text;
            string concepto = txtConcepto.Text;

            errorProvider1.SetError(txtConcepto, "");

            // Verificar si el TextBox está vacío
            if (string.IsNullOrWhiteSpace(txtConcepto.Text))
            {
                errorProvider1.SetError(txtConcepto, "Este campo es obligatorio."); // Mostrar mensaje de error
                txtConcepto.Focus(); // Enfocar el TextBox
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Seguro que desea crear la póliza?", "Confirmación", MessageBoxButtons.YesNo);

                // No hacer nada en caso de que el usuario seleccione "Sí" o "No"
                if (result == DialogResult.Yes)
                {
                    if (result == DialogResult.Yes)
                    {
                        // Verificar que los ComboBox tengan valores seleccionados
                        if (cbtipopoliza.SelectedValue == null || cboperacion.SelectedValue == null || cbCuenta.SelectedValue == null)
                        {
                            MessageBox.Show("Por favor, seleccione todos los campos requeridos.");
                            return; // Salir si no se selecciona algo
                        }


                        // Obtener el ID de la cuenta seleccionada directamente como número

                        int idTipoPoliza = int.Parse(idtp);
                        MessageBox.Show($"ID Tipo Póliza: {idTipoPoliza}",
                            "Detalles de Selección",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // Limpiar la lista antes de agregar detalles
                        detalles.Clear();

                        // Recorrer filas del DGV
                        foreach (DataGridViewRow row in dgvPolizas.Rows)
                        {
                            int idop = 0;

                            if (row.IsNewRow) continue; // Ignorar la última fila (nueva)

                            // ID de la cuenta (columna 'Codigo')
                            int idCuenta = Convert.ToInt32(row.Cells["Codigo"].Value);

                            // Determinar si es Cargo o Abono
                            string tipoOperacion = "";
                            decimal valor = 0;

                            if (row.Cells[2].Value != DBNull.Value && row.Cells[2].Value.ToString() != "")
                            {
                                tipoOperacion = "Cargo";
                                idop = 1;
                                valor = Convert.ToDecimal(row.Cells[2].Value);
                            }
                            else if (row.Cells[3].Value != DBNull.Value && row.Cells[3].Value.ToString() != "")
                            {
                                tipoOperacion = "Abono";
                                idop = 2;
                                valor = Convert.ToDecimal(row.Cells[3].Value);
                            }

                            // Crea un arreglo con los valores de la fila
                            object[] detalle = new object[3];
                            detalle[0] = idCuenta; // ID de cuenta seleccionada
                            detalle[1] = idop; // ID de operación
                            detalle[2] = valor; // Valor correspondiente a Cargo o Abono

                            // Agrega el arreglo a la lista
                            detalles.Add(detalle);

                            // Función que cambia la tabla cuentas
                            ctr.ActualizarTblCuentas(idCuenta, tipoOperacion, valor);

                            MessageBox.Show($"ID Tipo Póliza: {idTipoPoliza}\nID Operación: {idop}\nID Cuenta Seleccionada: {idCuenta}\nID Valor: {valor}",
                            "Detalles de Selección",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        }

                        // Funciones para insertar en las tablas de encabezado póliza y detalle póliza
                        ctr.LlenarEncabezado(fechaSeleccionada, concepto, idTipoPoliza);
                        ctr.LlenarDetalle(fechaSeleccionada, concepto, detalles);

                        // Mensaje de confirmación
                        LimpiarCamposDetelle();
                        LimpiarCamposEnc();
                        dgvPolizas.Rows.Clear();
                        MessageBox.Show("Se registró correctamente");
                    }
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Se canceló el proceso", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void Polizas_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 192, 128);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; 
            }
        }

        private void dtpfecha_ValueChanged(object sender, EventArgs e)
        {
            if (dtpfecha.Value.Date != DateTime.Today)
            {
                dtpfecha.Value = DateTime.Today;
            }
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la ruta del directorio del ejecutable
                string sexecutablePath = AppDomain.CurrentDomain.BaseDirectory;

                // Retroceder a la carpeta del proyecto
                string sprojectPath = Path.GetFullPath(Path.Combine(sexecutablePath, @"..\..\"));
                //MessageBox.Show("1" + sprojectPath);


                string sayudaFolderPath = Path.Combine(sprojectPath, "AyudaEnlaceCC");


                // Busca el archivo .chm en la carpeta "Ayuda_Seguridad"
                string spathAyuda = FindFileInDirectory(sayudaFolderPath, "AyudaPolizas.chm");

                // Verifica si el archivo existe antes de intentar abrirlo
                if (!string.IsNullOrEmpty(spathAyuda))
                {
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

        public string FindFileInDirectory(string sdirectory, string sfileName)
        {
            try
            {
                // Verificamos si la carpeta existe
                if (Directory.Exists(sdirectory))
                {
                    // Buscamos el archivo .chm en la carpeta
                    string[] files = Directory.GetFiles(sdirectory, "*.chm", SearchOption.TopDirectoryOnly);

                    // Si encontramos el archivo, verificamos si coincide con el archivo que se busca y retornamos su ruta
                    foreach (var file in files)
                    {
                        if (Path.GetFileName(file).Equals(sfileName, StringComparison.OrdinalIgnoreCase))
                        {
                            //MessageBox.Show("Archivo encontrado: " + file);
                            return file;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la carpeta: " + sdirectory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar ayuda: " + ex.Message);
            }

            // Retorna null si no se encontró el archivo
            return null;
        }
    }
}



