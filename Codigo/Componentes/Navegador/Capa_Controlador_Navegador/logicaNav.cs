using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Navegador;

namespace Capa_Controlador_Navegador
{
    //******************************************** CODIGO HECHO POR TODOS SEGUN LO NECESITABAN ***************************** 
    public class logicaNav
    {
        // Instancia de la clase sentencias para ejecutar operaciones con la base de datos
        sentencias sn = new sentencias();

        // Obtiene el último ID insertado en la tabla especificada
        public string UltimoID(string sTabla)
        {
            string sUltimoID = sn.ObtenerId(sTabla);
            Console.WriteLine(sUltimoID);
            return sUltimoID;
        }

        // Realiza una consulta lógica sobre la tabla y la tabla relacionada, devolviendo un DataTable con los resultados
        public DataTable ConsultaLogica(string sTabla, List<Tuple<string, string, string, string>> relacionesForaneas)
        {
            // Asegurarse de que la lista no sea nula
            if (relacionesForaneas == null)
            {
                relacionesForaneas = new List<Tuple<string, string, string, string>>();
            }

            // Asegurarse de que 'sn' esté inicializado
            if (sn == null)
            {
                throw new InvalidOperationException("El objeto 'sn' no ha sido inicializado.");
            }

            OdbcDataAdapter dt = sn.LlenaTbl(sTabla, relacionesForaneas);  // Pasar la lista de relaciones a la capa de datos

            DataTable dtTabla = new DataTable();
            dt.Fill(dtTabla);
            return dtTabla;
        }

    


    // Modifica el índice proporcionado a través de la lógica interna
    public string ModIndice(string sIndice1)

        {
            string sIndice = sn.ModIndice(sIndice1);
            return sIndice;
        }

        // Modifica la ruta proporcionada a través de la lógica interna
        public string ModRuta(string sRuta1)
        {
            string sRuta = sn.ModRuta(sRuta1);
            return sRuta;
        }

        // Prueba si la tabla existe en la base de datos
        public string TestTabla(string sTabla)
        {
            return sn.ProbarTabla(sTabla);
        }

        // Obtiene una lista de columnas y sus propiedades (si son autoincrementales, claves foráneas, etc.) para la tabla dada
        public List<(string nombreColumna, bool esAutoIncremental, bool esClaveForanea, bool esTinyInt)> ObtenerColumnasYPropiedadesLogica(string sNombreTabla)
        {
            return sn.ObtenerColumnasYPropiedades(sNombreTabla);
        }

        // Prueba el estado de la tabla en la base de datos
        public string TestEstado(string sTabla)
        {
            return sn.ProbarEstado(sTabla);
        }

        // Devuelve el número de registros en la tabla
        public int TestRegistros(string sTabla)
        {
            return sn.ProbarRegistros(sTabla);
        }

        // Cuenta los campos (columnas) en la tabla especificada
        public int ContarCampos(string sTabla)
        {
            return sn.ContarAlias(sTabla);
        }

        // Cuenta los registros de ayuda en la tabla especificada
        public int ContarRegAyuda(string sTabla)
        {
            return sn.ContarReg(sTabla);
        }

        // Devuelve un array con los nombres de los campos de la tabla especificada
        public string[] Campos(string sTabla)
        {
            string[] sCampos = sn.ObtenerCampos(sTabla);
            return sCampos;
        }

        // Devuelve un array con los tipos de datos de los campos de la tabla especificada
        public string[] Tipos(string sTabla)
        {
            string[] sTipos = sn.ObtenerTipo(sTabla);
            return sTipos;
        }

        // Devuelve un array con las llaves primarias de la tabla especificada
        public string[] Llaves(string sTabla)
        {
            string[] sLlaves = sn.ObtenerLLave(sTabla);
            return sLlaves;
        }

        // Obtiene los elementos para un ComboBox basado en la tabla y campos especificados
        public Dictionary<string, string> Items(string sTabla, string sCampoClave, string sCampoDisplay)
        {
            return sn.ObtenerItems(sTabla, sCampoClave, sCampoDisplay);
        }

        // Devuelve la clave primaria correspondiente a un valor específico en un campo específico de la tabla
        public string LlaveCampolo(string sTabla, string sCampo, string sValor)
        {
            string sLlave = sn.LlaveCampo(sTabla, sCampo, sValor);
            return sLlave;
        }

        // Devuelve la clave primaria en reverso para un valor específico en un campo específico de la tabla
        public string LlaveCampoRev(string sTabla, string sCampo, string sValor)
        {
            string sLlave = sn.LlaveCampoReverso(sTabla, sCampo, sValor);
            return sLlave;
        }

        // Obtiene el ID de un reporte basado en su nombre
        public string ObtenerIdReporte(string sId)
        {
            string sLlave = sn.RutaReporte(sId);
            return sLlave;
        }

        // Ejecuta una nueva consulta en la base de datos
        public void NuevoQuery(string sQuery)
        {
            sn.EjecutarQuery(sQuery);
        }

        // Obtiene el ID de un usuario basado en su nombre de usuario
        public string ObtenerIdUsuario(string sUsername)
        {
            return sn.ObtenerIdUsuarioPorUsername(sUsername);
        }

        // Inserta datos en múltiples tablas en una transacción
        public void InsertarDatosEnMultiplesTablas(List<string> lsQueries)
        {
            sentencias sn = new sentencias();
            sn.EjecutarQueryConTransaccion(lsQueries);
        }
        public string ObtenerValorClaveDesdeLogica(string sTabla, string sCampoClave, string sCampoDescriptivo, string valorDescriptivo)
        {
            return sn.ObtenerValorClave(sTabla, sCampoClave, sCampoDescriptivo, valorDescriptivo);
        }

        public string DetectarTablaRelacionada(string tabla, string campo)
        {
            var relaciones = sn.ObtenerRelacionesForaneas(tabla, campo);
            return relaciones.tablaRelacionada;
        }

        // Método para detectar el campo clave relacionado
        public string DetectarClaveRelacionada(string tabla, string campo)
        {
            var relaciones = sn.ObtenerRelacionesForaneas(tabla, campo);
            return relaciones.campoClave;
        }

        // Método para detectar el campo a mostrar relacionado (por ejemplo, nombre o descripción)
        public string DetectarCampoDisplayRelacionada(string tabla, string campo)
        {
            var relaciones = sn.ObtenerRelacionesForaneas(tabla, campo);
            return relaciones.campoDisplay;
        }



        // Obtiene la clave primaria de una tabla específica
        public string ObtenerClavePrimaria(string sNombreTabla)
        {
            return sn.ObtenerClavePrimaria(sNombreTabla);
        }

        // Obtiene la clave foránea de una tabla referenciada
        public string ObtenerClaveForanea(string sNombreTabla, string sTablaReferencia)
        {
            return sn.ObtenerClaveForanea(sNombreTabla, sTablaReferencia);
        }



        public DataTable LlenarTblAyuda(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTblAyuda(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
    }
}
