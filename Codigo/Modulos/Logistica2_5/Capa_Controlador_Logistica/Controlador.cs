using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc; // Para OdbcDataReader
using Capa_Modelo_Logistica; // Para Sentencias
using System.Windows.Forms;
using System.Data;

namespace Capa_Controlador_Logistica
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        // ---------------------------------- COMBO BOX CUENTAS ----------------------------------
        public string[] itemsCuenta(string stabla, string scampo1, string scampo2)
        {
            string[] Items = sn.llenarCmbCuentas(stabla, scampo1, scampo2);
            return Items;
        }

        public DataTable enviarCuentas(string stabla, string scampo1, string scampo2)
        {
            var dt1 = sn.obtenerCuentas(stabla, scampo1, scampo2);
            return dt1;
        }

        // ---------------------------------- COMBO BOX TIPO POLIZA ----------------------------------

        public string[] itemsTP(string stabla, string scampo1, string scampo2)
        {
            string[] Items = sn.llenarCmbTP(stabla, scampo1, scampo2);
            return Items;
        }

        public DataTable enviarTP(string stabla, string scampo1, string scampo2)
        {
            var dt1 = sn.obtenerTP(stabla, scampo1, scampo2);
            return dt1;
        }

        // ---------------------------------- COMBO BOX OPERACION ----------------------------------

        public string[] itemsOP(string stabla, string scampo1, string scampo2)
        {
            string[] Items = sn.llenarCmbTP(stabla, scampo1, scampo2);
            return Items;
        }

        public DataTable enviarOP(string stabla, string scampo1, string scampo2)
        {
            var dt1 = sn.obtenerTP(stabla, scampo1, scampo2);
            return dt1;
        }

        // ---------------------------------- Funcion para actualizar la tabla cuentas ----------------------------------

        public void ActualizarTblCuentas(int iidCuenta, string stipoOperacion, decimal devalor)
        {
            Sentencias sn = new Sentencias();

            sn.ActulizarCuentas(iidCuenta, stipoOperacion, devalor);
            return;
        }

        // ---------------------------------- Insertar en polizas ----------------------------------
        public void LlenarEncabezado(string sfechaSeleccionada, string sconcepto, int itipoPoli)
        {
            Sentencias sn = new Sentencias();
            sn.LlenarEncabezado(sfechaSeleccionada, sconcepto, itipoPoli);
            return;
        }

        public void LlenarDetalle(string sfechaSeleccionada, string sconcepto, List<object[]> ldetalles)
        {
            Sentencias sn = new Sentencias();
            sn.LlenarDetalle(sfechaSeleccionada, sconcepto, ldetalles);
            return;
        }

        //----------------------------------- Ayuda ------------------------------------------------
        public string ModRuta(string sRuta1)
        {
            string sRuta = sn.ModRuta(sRuta1);
            return sRuta;
        }

        public string ModIndice(string sIndice1)

        {
            string sIndice = sn.ModIndice(sIndice1);
            return sIndice;
        }

        public string TestTabla(string sTabla)
        {
            return sn.ProbarTabla(sTabla);
        }

        public int ContarRegAyuda(string sTabla)
        {
            return sn.ContarReg(sTabla);
        }

    }
}

