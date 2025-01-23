using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Presupuesto;
using System.Windows.Forms;

namespace Capa_Controlador_Presupuesto
{
    public class Controlador
    {
        Sentencia sn = new Sentencia();

        public DataTable ObtenerCuentasNuevo()
        {
            OdbcDataAdapter dt = sn.ObtenerCuentas();
            DataTable dTabla = new DataTable();
            dt.Fill(dTabla);
            return dTabla;
        }

        public int CrearPresupuesto(string sNombre , int iEjercicio)
        {
            return sn.CrearPresupuesto(sNombre, iEjercicio);
        }

        public void GuardarPresupuesto(int iFkPresupuesto, DataGridView Dgv_datagrid)
        {
            foreach (DataGridViewRow Dgvr_fila in Dgv_datagrid.Rows)
            {
                if (!Dgvr_fila.IsNewRow) // Ignorar la fila vacía al final del DataGridView
                {
                    int iFkcuenta = Convert.ToInt32(Dgvr_fila.Cells["Column1"].Value); // ID de la cuenta

                    decimal[] deMeses = new decimal[12];
                    for (int i = 0; i < 12; i++)
                    {
                        deMeses[i] = Convert.ToDecimal(Dgvr_fila.Cells[i + 2].Value); // Columnas de enero a diciembre
                    }

                    decimal deTotalCuenta = Convert.ToDecimal(Dgvr_fila.Cells["Column15"].Value); // Total de la cuenta

                    // Llamada al modelo para insertar en la BD
                    sn.InsertarDetalle(iFkPresupuesto, iFkcuenta, deMeses, deTotalCuenta);
                }
            }
        }
        public void ActualizarTblPresupuesto(int iPkPresupuesto)
        {
            sn.UpdateTblPresupuesto(iPkPresupuesto);
        }

        public void CargarPresupuestosActivos(ComboBox CbComboBox)
        {
            var vPresupuestos = sn.ObtenerPresupuestosActivos();

            foreach (var vPresupuesto in vPresupuestos)
            {
                // presupuesto[0] = ID, presupuesto[1] = Nombre
                CbComboBox.Items.Add(new KeyValuePair<string, string>(vPresupuesto[0], vPresupuesto[1]));
            }

            CbComboBox.DisplayMember = "Value";  // Mostrar el nombre del presupuesto
            CbComboBox.ValueMember = "Key";
        }

        public void CargarPresupuestosGeneral(ComboBox CbComboBox)
        {
            var vPresupuestos = sn.ObtenerPresupuestosGeneral();

            foreach (var vPresupuesto in vPresupuestos)
            {
                // presupuesto[0] = ID, presupuesto[1] = Nombre
                CbComboBox.Items.Add(new KeyValuePair<string, string>(vPresupuesto[0], vPresupuesto[1]));
            }

            CbComboBox.DisplayMember = "Value";  // Mostrar el nombre del presupuesto
            CbComboBox.ValueMember = "Key";
        }

        public DataTable CargarDetallesPresupuesto(int iIdPresupuesto)
        {
            return sn.ObtenerDetallesPresupuesto(iIdPresupuesto);
        }

        public void ActualizarPresupuesto(int iFkPresupuesto, DataGridView Dgv_datagrid)
        {
            foreach (DataGridViewRow Dgvr_fila in Dgv_datagrid.Rows)
            {
                if (!Dgvr_fila.IsNewRow) // Ignorar la fila vacía
                {
                    int iFkCuenta = Convert.ToInt32(Dgvr_fila.Cells["Column1"].Value); // ID de la cuenta

                    decimal[] deMeses = new decimal[12];
                    for (int i = 0; i < 12; i++)
                    {
                        deMeses[i] = Convert.ToDecimal(Dgvr_fila.Cells[i + 2].Value); // Columnas de enero a diciembre
                    }

                    decimal deTotalCuenta = Convert.ToDecimal(Dgvr_fila.Cells["Column15"].Value); // Total de la cuenta

                    sn.ActualizarDetalle(iFkPresupuesto, iFkCuenta, deMeses, deTotalCuenta);
                }
            }
        }

        public void EliminarPresupuesto(int iIdPresupuesto)
        {
            // Eliminar primero los detalles del presupuesto
            sn.EliminarDetallePresupuesto(iIdPresupuesto);
            // Luego eliminar el presupuesto
            sn.EliminarPresupuesto(iIdPresupuesto);
        }

        public bool PuedeCrearPresupuesto()
        {
            return sn.VerificarCuentas();
        }
        public bool PuedeCrearPresupuestoForaneo()
        {
            return sn.VerificarForaneas();
        }
        public void ActualizarEstadosPresupuesto()
        {
            sn.ActualizarEstadosPresupuestos();
        }

        public int ObtenerEjercicioPresupuesto(int iIdPresupuesto)
        {
            return sn.ObtenerEjercicioPresupuesto(iIdPresupuesto);
        }
    }
}

