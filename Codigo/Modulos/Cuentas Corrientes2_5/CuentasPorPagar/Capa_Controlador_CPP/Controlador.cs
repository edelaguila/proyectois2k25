using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Controlador_CPP
{
    public class Controlador
    {
        Capa_Modelo_CPP.Sentencias sentencias = new Capa_Modelo_CPP.Sentencias();

        // Variables para manejar modo edición
        //public bool esEdicion = false;
        //public string idTransaccionSeleccionada;

        //// Método para guardar o actualizar una transacción
        //public int GuardarTransaccion(TextBox idTransaccion, TextBox idProveedor, TextBox idPais,
        //                              string sfecha_transaccion, string sCuenta, string sCuota,
        //                              string sMonto, TextBox idPago, string sMoneda,
        //                              string sSerie, string sEstado)
        //{
        //    if (string.IsNullOrEmpty(idProveedor.Text) || string.IsNullOrEmpty(idPais.Text) ||
        //        string.IsNullOrEmpty(sfecha_transaccion) || string.IsNullOrEmpty(sCuenta) ||
        //        string.IsNullOrEmpty(sCuota) || string.IsNullOrEmpty(sMonto) ||
        //        string.IsNullOrEmpty(idPago.Text) || string.IsNullOrEmpty(sMoneda) ||
        //        string.IsNullOrEmpty(sSerie) || string.IsNullOrEmpty(sEstado))
        //    {
        //        MessageBox.Show("Existen campos vacíos, revise y vuelva a intentarlo", "Error",
        //                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return 0;
        //    }
        //    else
        //    {
        //        if (esEdicion)
        //        {
        //            // Actualizar transacción existente
        //            sentencias.ActualizarTransaccion(idTransaccionSeleccionada, idProveedor.Text, idPais.Text,
        //                                             sfecha_transaccion, sCuenta, sCuota, sMonto,
        //                                             idPago.Text, sMoneda, sSerie, sEstado);
        //            MessageBox.Show("Registro actualizado correctamente", "Éxito",
        //                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            esEdicion = false; // Resetear modo edición
        //        }
        //        else
        //        {
        //            // Guardar nueva transacción
        //            sentencias.registrarTransaccion(idTransaccion.Text, idProveedor.Text, idPais.Text,
        //                                            sfecha_transaccion, sCuenta, sCuota, sMonto,
        //                                            idPago.Text, sMoneda, sSerie, sEstado);
        //            MessageBox.Show("Registro guardado correctamente", "Éxito",
        //                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        return 1;
        //    }
        //}


        //public void eliminarTransaccion(string idTransaccion)
        //{
        //    //if (!string.IsNullOrEmpty(idTransaccion))
        //    //{
        //    //    sentencias.eliminarTransaccion(idTransaccion);
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show("No se pudo eliminar el registro. El ID es nulo o vacío.",
        //    //                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //}
        //}

        //public OdbcDataAdapter buscarTransaccionPorCampo(string campo, string valor)
        //{
        //    //if (!string.IsNullOrEmpty(valor))
        //    //{
        //    //    return sentencias.buscarTransaccion(campo, valor);
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show("El campo de búsqueda está vacío.",
        //    //                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    //    return null;
        //    //}
        //}


        // Método para mostrar datos en el DataGridView
        //public OdbcDataAdapter DisplayTransaccion()
        //{
        //    //return sentencias.DisplayTransaccion();
        //}
        // -----------------------------------------------------------------------------------------------------------------------------------



        //public string idDeudaSeleccionada;

        // Método para guardar o actualizar una deuda
        //public int GuardarDeuda(TextBox Txt_deuda, TextBox Txt_proveedor, TextBox Txt_pago,
        //                        string monto, string Txt_fecha_ini, string Txt_fecha_venci,
        //                        string descripcion, string estado)
        //{
        //    //if (string.IsNullOrEmpty(Txt_proveedor.Text) || string.IsNullOrEmpty(monto) ||
        //    //    string.IsNullOrEmpty(Txt_fecha_ini) ||
        //    //    string.IsNullOrEmpty(Txt_fecha_venci) ||
        //    //    string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(estado))
        //    //{
        //    //    MessageBox.Show("Existen campos vacíos, revise y vuelva a intentarlo", "Error",
        //    //                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //    return 0;
        //    //}
        //    //else
        //    //{
        //    //    if (esEdicion)
        //    //    {
        //    //        // Actualizar deuda existente
        //    //        sentencias.ActualizarDeuda(idDeudaSeleccionada, Txt_proveedor.Text,
        //    //                                    Txt_pago.Text, monto, Txt_fecha_ini,
        //    //                                    Txt_fecha_venci, descripcion, estado);
        //    //        MessageBox.Show("Registro actualizado correctamente", "Éxito",
        //    //                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //        esEdicion = false; // Resetear modo edición
        //    //    }
        //    //    else
        //    //    {
        //    //        // Guardar nueva deuda
        //    //        sentencias.RegistrarDeuda(Txt_deuda.Text, Txt_proveedor.Text,
        //    //                                   Txt_pago.Text, monto, Txt_fecha_ini,
        //    //                                   Txt_fecha_venci, descripcion, estado);
        //    //        MessageBox.Show("Registro guardado correctamente", "Éxito",
        //    //                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //    }
        //    //    return 1;
        //    //}
        //}

        //public void EliminarDeuda(string idDeuda)
        //{
        //    if (!string.IsNullOrEmpty(idDeuda))
        //    {
        //        sentencias.EliminarDeuda(idDeuda);
        //    }
        //    else
        //    {
        //        MessageBox.Show("No se pudo eliminar el registro. El ID es nulo o vacío.",
        //                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //public OdbcDataAdapter BuscarDeudaPorCampo(string campo, string valor)
        //{
        //    if (!string.IsNullOrEmpty(valor))
        //    {
        //        return sentencias.BuscarDeuda(campo, valor);
        //    }
        //    else
        //    {
        //        MessageBox.Show("El campo de búsqueda está vacío.",
        //                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return null;
        //    }
        //}

        //// Método para mostrar datos en el DataGridView
        //public OdbcDataAdapter DisplayDeudas()
        //{
        //    return sentencias.DisplayDeudas();
        //}
    }
}
