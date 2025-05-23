using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Controlador_Cuentas_Corrientes
{
    public class Controlador
    {
        Capa_Modelo_Cuentas_Corrientes.Sentencias sentencias = new Capa_Modelo_Cuentas_Corrientes.Sentencias();

        public bool esEdicion = false;
        public string idDeudaSeleccionada;
        public string idDeudaPSeleccionada;
        //DEUDAS CLIENTES
        public DataTable MostrarDeudas()
        {
            OdbcDataAdapter data = sentencias.DisplayDeudas();
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public String getNextIdD()
        {
            int nextId = sentencias.getMaxIdDeudas();
            nextId = nextId + 1;
            return nextId.ToString();
        }

        /*public List<string> listadoEfecto()
        {
            List<string> efectoCodes = sentencias.getEfecto();
            return efectoCodes;
        }*/
        public List<string> listadoClientesd()
        {
            List<string> clientesCodes = sentencias.getClientesd();
            return clientesCodes;
        }

        public List<string> listadoCobradord()
        {
            List<string> cobradorCodes = sentencias.getCobrador();
            return cobradorCodes;
        }

       /* public List<string> listadoTrans()
        {
            List<string> transaccionCodes = sentencias.getTransaccion();
            return transaccionCodes;
        }
        public List<string> listadoTipoTrans()
        {
            List<string> tipoTCodes = sentencias.getTipoTrans();
            return tipoTCodes;
        }*/
        //
        public List<string> listadoFactura()
        {
            List<string> transaccionCodes = sentencias.getFactura();
            return transaccionCodes;
        }

        public int guardarDeudas(string Pk_id_deuda, string sFk_id_cliente, string sFk_id_cobrador, string sFk_idfactura,
             string smonto_deuda, DateTime sfecha_inicio_deuda, DateTime sfecha_vencimiento_deuda, string sdescripcion_deuda, string sestado_deuda)
        {
            
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(Pk_id_deuda) || string.IsNullOrEmpty(sFk_id_cliente) || string.IsNullOrEmpty(sFk_id_cobrador)  || string.IsNullOrEmpty(sFk_idfactura) ||
                string.IsNullOrEmpty(smonto_deuda) || string.IsNullOrEmpty(sdescripcion_deuda) || string.IsNullOrEmpty(sestado_deuda))
            {
                MessageBox.Show("Existen campos vacios o datos incorrectos, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                try
                {
                    if (esEdicion)
                    {
                        // Actualizar transacción existente
                        sentencias.ActualizarDeuda(idDeudaSeleccionada, sFk_id_cliente, sFk_id_cobrador, sFk_idfactura,
                        smonto_deuda, sfecha_inicio_deuda, sfecha_vencimiento_deuda, sdescripcion_deuda, sestado_deuda);
                        MessageBox.Show("Registro actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        esEdicion = false; // Resetear modo edición
                    }
                    else
                    {
                        // Guardar nueva transacción
                        sentencias.registrarDeuda(Pk_id_deuda, sFk_id_cliente, sFk_id_cobrador, sFk_idfactura,
                    smonto_deuda, sfecha_inicio_deuda, sfecha_vencimiento_deuda, sdescripcion_deuda, sestado_deuda);
                        MessageBox.Show("Registro guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar o actualizar la Deuda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                

            }
            
        }
    
   


        public bool ModificarTransaccion(int idDeuda, int idCliente, int idCobrador, int idFactura, string monto, DateTime fechaI,
            DateTime fechaV, string descripcion, int estado)
        {
            

            return sentencias.ModificarTransaccion(idDeuda, idCliente, idCobrador, idFactura, monto, fechaI, fechaV, descripcion, estado);
        }
            
        public DataTable queryDeuda(TextBox query)
        {
            OdbcDataAdapter data2 = sentencias.queryDeuda(query.Text);
            DataTable tabla2 = new DataTable();
            data2.Fill(tabla2);
            return tabla2;
        }


        public int borrarDeuda(TextBox Pk_id_deuda)
        {

            if (string.IsNullOrEmpty(Pk_id_deuda.Text))
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {

                DialogResult result = MessageBox.Show("¿Desea eliminar la deuda #" + Pk_id_deuda.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se borró el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                {
                    sentencias.eliminarDeuda(Pk_id_deuda.Text);
                    return 1;
                }
            }
        }


        //DEUDAS PROVEEDORES
        public DataTable MostrarDeudasP()
        {
            OdbcDataAdapter data = sentencias.DisplayDeudasP();
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public String getNextIdDP()
        {
            int nextId = sentencias.getMaxIdDeudasP();
            nextId = nextId + 1;
            return nextId.ToString();
        }
        public List<string> listadoEfectoP()
        {
            List<string> efectoCodes = sentencias.getEfectoP();
            return efectoCodes;
        }
        public List<string> listadoProveedor()
        {
            List<string> clientesCodes = sentencias.getProveedor();
            return clientesCodes;
        }

        public List<string> listadoTipoTransP()
        {
            List<string> tipoTCodes = sentencias.getTipoTransP();
            return tipoTCodes;
        }
     
        public List<string> listadoFacturaP()
        {
            List<string> transaccionCodes = sentencias.getFacturaP();
            return transaccionCodes;
        }

        public int guardarDeudasProv(TextBox Pk_id_deuda, string sFk_id_proveedor, string sTipo_trans, string sEfecto, string sFk_idfactura,
             string smonto_deuda, string sfecha_inicio, string sfecha_vencimiento, string sdescripcion_deuda, string sestado_deuda)
        {

            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(Pk_id_deuda.Text) || string.IsNullOrEmpty(sFk_id_proveedor) || string.IsNullOrEmpty(sTipo_trans) || string.IsNullOrEmpty(sEfecto) ||
                string.IsNullOrEmpty(sFk_idfactura) || string.IsNullOrEmpty(smonto_deuda) || string.IsNullOrEmpty(sfecha_inicio) ||
                string.IsNullOrEmpty(sfecha_vencimiento) || string.IsNullOrEmpty(sdescripcion_deuda) || string.IsNullOrEmpty(sestado_deuda))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                try
                {
                    if (esEdicion)
                    {
                        // Actualizar transacción existente
                        sentencias.ActualizarDeudaP(idDeudaPSeleccionada, sFk_id_proveedor, sTipo_trans, sEfecto, sFk_idfactura,
                    smonto_deuda, sfecha_inicio, sfecha_vencimiento, sdescripcion_deuda, sestado_deuda);
                        MessageBox.Show("Registro actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        esEdicion = false; // Resetear modo edición
                    }
                    else
                    {
                        // Guardar nueva transacción
                        sentencias.registrarDeudaProveedor(Pk_id_deuda.Text, sFk_id_proveedor, sTipo_trans, sEfecto, sFk_idfactura,
                    smonto_deuda, sfecha_inicio, sfecha_vencimiento, sdescripcion_deuda, sestado_deuda);
                        MessageBox.Show("Registro guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar o actualizar la Deuda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
        }

        public DataTable queryDeudaP(TextBox query)
        {
            OdbcDataAdapter data2 = sentencias.queryProv(query.Text);
            DataTable tabla2 = new DataTable();
            data2.Fill(tabla2);
            return tabla2;
        }


        public int borrarDeudaP (TextBox Pk_id_deuda)
        {

            if (string.IsNullOrEmpty(Pk_id_deuda.Text))
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {

                DialogResult result = MessageBox.Show("¿Desea eliminar la deuda #" + Pk_id_deuda.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se borró el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                {
                    sentencias.eliminarProv(Pk_id_deuda.Text);
                    return 1;
                }
            }
        }
       
        ////////////////////////////////////////////////////////////////////////
        //polizas
        // ---------------------------------- COMBO BOX CUENTAS ----------------------------------
        public string[] itemsCuenta(string tabla, string campo1, string campo2)
        {
            string[] Items = sentencias.llenarCmbCuentas(tabla, campo1, campo2);
            return Items;
        }

        public DataTable enviarCuentas(string tabla, string campo1, string campo2)
        {
            var dt1 = sentencias.obtenerCuentas(tabla, campo1, campo2);
            return dt1;
        }

        // ---------------------------------- COMBO BOX TIPO POLIZA ----------------------------------

        public string[] itemsTP(string tabla, string campo1, string campo2)
        {
            string[] Items = sentencias.llenarCmbTP(tabla, campo1, campo2);
            return Items;
        }

        public DataTable enviarTP(string tabla, string campo1, string campo2)
        {
            var dt1 = sentencias.obtenerTP(tabla, campo1, campo2);
            return dt1;
        }

        // ---------------------------------- COMBO BOX OPERACION ----------------------------------

        public string[] itemsOP(string tabla, string campo1, string campo2)
        {
            string[] Items = sentencias.llenarCmbTP(tabla, campo1, campo2);
            return Items;
        }

        public DataTable enviarOP(string tabla, string campo1, string campo2)
        {
            var dt1 = sentencias.obtenerTP(tabla, campo1, campo2);
            return dt1;
        }

        // ---------------------------------- Funcion para actualizar la tabla cuentas ----------------------------------

        public void ActualizarTblCuentas(int idCuenta, string tipoOperacion, decimal valor)
        {
            sentencias.ActulizarCuentas(idCuenta, tipoOperacion, valor);
            return;
        }

        // ---------------------------------- Insertar en polizas ----------------------------------
        public void LlenarEncabezado(string fechaSeleccionada, string concepto, int tipoPoli)
        {
            sentencias.LlenarEncabezado(fechaSeleccionada, concepto, tipoPoli);
            return;
        }

        public void LlenarDetalle(string fechaSeleccionada, string concepto, List<object[]> detalles)
        {
            sentencias.LlenarDetalle(fechaSeleccionada, concepto, detalles);
            return;
        }
    }
   
}
