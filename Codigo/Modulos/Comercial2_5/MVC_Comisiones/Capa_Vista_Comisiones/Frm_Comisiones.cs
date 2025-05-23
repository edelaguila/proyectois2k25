using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador;
using System.Globalization;
using System.IO;

namespace Capa_Vista_Comisiones
{
    public partial class Frm_Comisiones : Form
    {

        Logica logica = new Logica();


        // Variable para almacenar el porcentaje de comisión
        private decimal dePorcentajeComision;

        // Variables de clase para guardar el filtro y valor de filtro actual
        private string filtroActual = "";
        private string valorFiltroActual = "";


        public Frm_Comisiones()
        {
            InitializeComponent();
            funCargarVendedores();
            Cbo_filtro.Enabled = false;
            Cbo_vendedor.SelectedIndex = -1;
            Lbl_filtro.Text = "";
        }
        private void funCargarVendedores()
        {
            try
            {
                DataTable dtVendedores = logica.funObtenerVendedores();

                // Crear una nueva fila para "Todos los vendedores"
                DataRow row = dtVendedores.NewRow();
                row["Pk_id_vendedor"] = 0;
                row["NombreCompleto"] = "Todos los vendedores";
                dtVendedores.Rows.InsertAt(row, 0);

                Cbo_vendedor.DataSource = dtVendedores;
                Cbo_vendedor.DisplayMember = "NombreCompleto";
                Cbo_vendedor.ValueMember = "Pk_id_vendedor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar vendedores: " + ex.Message);
            }
        }
        private void funCalcularTotalVentas()
        {
            decimal deTotalVentas = 0;
            foreach (DataGridViewRow row in Dgv_ventas.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    deTotalVentas += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }
            Txt_venta.Text = deTotalVentas.ToString("C", new CultureInfo("es-GT")); // Muestra el total en formato de moneda Q
        }

        private void Lbl_vendedor_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Comisiones_Load(object sender, EventArgs e)
        {

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_vendedor.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un vendedor.");
                    return;
                }

                int iIdVendedor = (int)Cbo_vendedor.SelectedValue;
                string sFiltro = ""; // Inicializamos el filtro como una cadena vacía
                DateTime dFechaInicio = Dtp_fecha_inicio.Value;
                DateTime dFechaFin = Dtp_fecha_fin.Value;
                string sValorFiltro = Cbo_filtro.SelectedValue?.ToString(); // Valor de marca o línea

                // Asignar el filtro según el RadioButton seleccionado
                if (Rdb_inventario.Checked)
                {
                    sFiltro = "Inventario";
                }
                else if (Rdb_marcas.Checked && !string.IsNullOrEmpty(sValorFiltro))
                {
                    sFiltro = "Marcas";
                }
                else if (Rdb_lineas.Checked && !string.IsNullOrEmpty(sValorFiltro))
                {
                    sFiltro = "Lineas";
                }
                else if (Rdb_costo.Checked)
                {
                    sFiltro = "Costo";
                }
                else
                {
                    MessageBox.Show("Seleccione un filtro(Inventario, Marcas, etc.) y periodo de fechas a buscar.");
                    return;
                }

                // Llamar al método de lógica para obtener las ventas filtradas
                DataTable dtVentas = logica.funObtenerVentasFiltradas(iIdVendedor, sFiltro, dFechaInicio, dFechaFin, sValorFiltro);
                Dgv_ventas.DataSource = dtVentas;

                // Calcular el total de ventas y la comisión total sumando cada fila
                decimal deTotalVentas = 0;
                decimal deTotalComision = 0;
                decimal dePorcentajePromedio = 0;

                if (dtVentas.Rows.Count > 0)
                {
                    foreach (DataRow row in dtVentas.Rows)
                    {
                        decimal totalVenta = row["Total"] != DBNull.Value ? Convert.ToDecimal(row["Total"]) : 0;
                        decimal porcentaje = row["Comision"] != DBNull.Value ? Convert.ToDecimal(row["Comision"]) : 0;

                        deTotalVentas += totalVenta;
                        deTotalComision += totalVenta * porcentaje;
                        dePorcentajePromedio += porcentaje;
                    }

                    // Calcular el porcentaje promedio
                    dePorcentajePromedio = dePorcentajePromedio / dtVentas.Rows.Count;

                    // Mostrar el porcentaje promedio redondeado en el textbox
                    Txt_porcentaje.Text = $"{Math.Round(dePorcentajePromedio * 100, 0)}%";
                }
                else
                {
                    Txt_porcentaje.Text = "";
                }

                Txt_venta.Text = deTotalVentas.ToString("C", new System.Globalization.CultureInfo("es-GT"));
                Txt_comision.Text = deTotalComision.ToString("C", new System.Globalization.CultureInfo("es-GT"));

                Rdb_inventario.Enabled = false;
                Rdb_marcas.Enabled = false;
                Rdb_lineas.Enabled = false;
                Rdb_costo.Enabled = false;
                Cbo_vendedor.Enabled = false;

                filtroActual = sFiltro;
                valorFiltroActual = sValorFiltro;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar ventas: " + ex.Message);
            }
        }

        private List<int> funObtenerVentasSeleccionadas()
        {
            List<int> iVentasSeleccionadas = new List<int>();
            foreach (DataGridViewRow row in Dgv_ventas.Rows)
            {
                if (row.Cells["IdVenta"].Value != null) // "IdVenta" es el nombre de la columna que contiene el ID de la venta
                {
                    iVentasSeleccionadas.Add(Convert.ToInt32(row.Cells["IdVenta"].Value));
                }
            }
            return iVentasSeleccionadas;
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los TextBox
            Txt_porcentaje.Clear();
            Txt_venta.Clear();
            Txt_comision.Clear();
            Txt_nombre.Clear();
            Lbl_filtro.Text = "";

            // Desmarcar los RadioButton
            Rdb_inventario.Checked = false;
            Rdb_marcas.Checked = false;
            Rdb_lineas.Checked = false;
            Rdb_costo.Checked = false;

            //Habilitar los radioButton
            Rdb_inventario.Enabled = true;
            Rdb_marcas.Enabled = true;
            Rdb_lineas.Enabled = true;
            Rdb_costo.Enabled = true;

            // Restablecer el ComboBox al valor predeterminado
            Cbo_vendedor.SelectedIndex = -1;
            Cbo_filtro.SelectedIndex = -1;

            //Habilitar combobox
            Cbo_vendedor.Enabled = true;

            // Limpiar el DataGridView
            Dgv_ventas.DataSource = null;

            // Restablecer los DateTimePicker a sus valores predeterminados
            Dtp_fecha_inicio.Value = DateTime.Now;
            Dtp_fecha_fin.Value = DateTime.Now;
        }



        private void Btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que haya un total válido en Txt_venta
                if (decimal.TryParse(Txt_venta.Text, NumberStyles.Currency, new CultureInfo("es-GT"), out decimal deTotalVentas))
                {
                    // Leer el porcentaje de comisión desde Txt_porcentaje
                    if (decimal.TryParse(Txt_porcentaje.Text.Replace("%", ""), out decimal dePorcentajeComision))
                    {
                        // Convertir el porcentaje a decimal (por ejemplo, 20% -> 0.20)
                        dePorcentajeComision /= 100;

                        // Calcular la comisión total multiplicando el total de ventas por el porcentaje de comisión
                        decimal deTotalComision = deTotalVentas * dePorcentajeComision;
                        Txt_comision.Text = deTotalComision.ToString("C", new CultureInfo("es-GT"));

                        // Obtener el ID del vendedor
                        int iIdVendedor = (int)Cbo_vendedor.SelectedValue;

                        // Si se seleccionó "Todos los vendedores" (ID = 0)
                        if (iIdVendedor == 0)
                        {
                            // Obtener todos los vendedores excepto la opción "Todos los vendedores"
                            DataTable dtVendedores = logica.funObtenerVendedores();
                            bool bAlgunGuardado = false;

                            foreach (DataRow row in dtVendedores.Rows)
                            {
                                int iIdVendedorActual = Convert.ToInt32(row["Pk_id_vendedor"]);

                                // Obtener las ventas específicas para este vendedor
                                DataTable dtVentasVendedor = logica.funObtenerVentasFiltradas(
                                    iIdVendedorActual,
                                    filtroActual,
                                    Dtp_fecha_inicio.Value,
                                    Dtp_fecha_fin.Value,
                                    valorFiltroActual
                                );

                                if (dtVentasVendedor.Rows.Count > 0)
                                {
                                    // Calcular totales para este vendedor
                                    decimal deTotalVentasVendedor = 0;
                                    decimal deTotalComisionVendedor = 0;
                                    List<int> iVentasVendedor = new List<int>();

                                    foreach (DataRow ventaRow in dtVentasVendedor.Rows)
                                    {
                                        decimal deMontoVenta = Convert.ToDecimal(ventaRow["Total"]);
                                        decimal dePorcentajeVenta = Convert.ToDecimal(ventaRow["Comision"]);
                                        deTotalVentasVendedor += deMontoVenta;
                                        deTotalComisionVendedor += deMontoVenta * dePorcentajeVenta;
                                        iVentasVendedor.Add(Convert.ToInt32(ventaRow["IdVenta"]));
                                    }

                                    // Guardar la comisión para este vendedor
                                    bool bGuardado = logica.funGuardarComision(
                                        iIdVendedorActual,
                                        DateTime.Now,
                                        deTotalVentasVendedor,
                                        deTotalComisionVendedor,
                                        dePorcentajeComision,
                                        iVentasVendedor,
                                        filtroActual,
                                        valorFiltroActual
                                    );

                                    if (bGuardado)
                                    {
                                        bAlgunGuardado = true;
                                    }
                                }
                            }

                            if (bAlgunGuardado)
                            {
                                MessageBox.Show("Comisiones guardadas exitosamente para todos los vendedores.");
                            }
                            else
                            {
                                MessageBox.Show("No se pudieron guardar las comisiones para ningún vendedor.");
                            }
                        }
                        else
                        {
                            // Guardar comisión para un vendedor específico
                            bool bGuardado = logica.funGuardarComision(
                                iIdVendedor,
                                DateTime.Now,
                                deTotalVentas,
                                deTotalComision,
                                dePorcentajeComision,
                                funObtenerVentasSeleccionadas(),
                                filtroActual,
                                valorFiltroActual
                            );

                            if (bGuardado)
                            {
                                MessageBox.Show("Comisión guardada exitosamente.");
                            }
                            else
                            {
                                MessageBox.Show("Ocurrió un error al guardar la comisión.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, introduces un porcentaje de comisión válido en el formato correcto.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, asegúrate de haber seleccionado un vendedor y los filtros de ventas necesarios.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al calcular la comisión: " + ex.Message);
            }
        }


        private void Btn_reporte_Click(object sender, EventArgs e)
        {

        }

        public decimal deVenta
        {
            get { return decimal.Parse(Txt_venta.Text); }
            set { Txt_venta.Text = value.ToString(); }
        }

        public void funEstablecerPorcentajeComision(decimal dePorcentaje)
        {
            dePorcentajeComision = dePorcentaje;
        }

        private decimal _deComisionCalculada;

        public decimal deComisionCalculada
        {
            get { return _deComisionCalculada; }
            private set { _deComisionCalculada = value; }
        }

        public void funCalcularComision()
        {
            deComisionCalculada = deVenta * dePorcentajeComision; // Calcula y asigna la comisión
            Txt_comision.Text = deComisionCalculada.ToString("C", new CultureInfo("es-GT")); // Actualiza el TextBox con formato
        }

        private void Rdb_marcas_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_marcas.Checked)
            {
                Lbl_filtro.Text = "Elegir marca";
                funCargarFiltro("Marca");
                Cbo_filtro.Enabled = true;
                Txt_venta.Text = "";
                Txt_comision.Text = "";
            }
        }

        private void Rdb_lineas_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_lineas.Checked)
            {
                Lbl_filtro.Text = "Elegir línea";
                funCargarFiltro("Línea");
                Cbo_filtro.Enabled = true;
                Txt_venta.Text = "";
                Txt_comision.Text = "";
            }
        }

        private void funCargarFiltro(string tipoFiltro)
        {
            try
            {
                DataTable dtFiltro;
                if (tipoFiltro == "Marca")
                {
                    // Limpiar DataSource anterior
                    Cbo_filtro.DataSource = null;

                    dtFiltro = logica.funObtenerMarcas();

                    // Agregar opción "Todas las marcas"
                    DataRow row = dtFiltro.NewRow();
                    row["Pk_id_Marca"] = 0;
                    row["nombre_Marca"] = "Todas las marcas";
                    dtFiltro.Rows.InsertAt(row, 0);

                    Cbo_filtro.DisplayMember = "nombre_Marca";
                    Cbo_filtro.ValueMember = "Pk_id_Marca";
                }
                else // Línea
                {
                    // Limpiar DataSource anterior
                    Cbo_filtro.DataSource = null;

                    dtFiltro = logica.funObtenerLineas();

                    // Agregar opción "Todas las líneas"
                    DataRow row = dtFiltro.NewRow();
                    row["Pk_id_linea"] = 0;
                    row["nombre_linea"] = "Todas las líneas";
                    dtFiltro.Rows.InsertAt(row, 0);

                    Cbo_filtro.DisplayMember = "nombre_linea";
                    Cbo_filtro.ValueMember = "Pk_id_linea";
                }

                Cbo_filtro.DataSource = dtFiltro;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar el filtro: " + ex.Message);
            }
        }

        private void Rdb_inventario_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_inventario.Checked)
            {
                Lbl_filtro.Text = "";
                Cbo_filtro.SelectedIndex = -1;
                Cbo_filtro.Enabled = false;
                Txt_venta.Text = "";
                Txt_comision.Text = "";
            }
        }
        private void Rdb_costo_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_costo.Checked)
            {
                Lbl_filtro.Text = "";
                Cbo_filtro.SelectedIndex = -1;
                Cbo_filtro.Enabled = false;
                Txt_venta.Text = "";
                Txt_comision.Text = "";
            }
        }

        private void Cbo_vendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificamos que haya un valor seleccionado en el ComboBox
            if (Cbo_vendedor.SelectedItem != null)
            {
                // Convierte el elemento seleccionado en un DataRowView para acceder a sus campos
                var selectedItem = (DataRowView)Cbo_vendedor.SelectedItem;

                // Obtenemos el nombre o cualquier otro campo que desees mostrar en el TextBox
                Txt_nombre.Text = selectedItem["NombreCompleto"].ToString();
            }
        }
    
    
    }



}
