using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_PercepcionesDeducciones;


namespace Capa_Controlador_PercepcionesDeducciones
{
    public class Controlador
    {
        Sentencias sn = new Sentencias(); //Conexion con capa modelo
        public DataTable ObtenerPercepciones()
        {
            OdbcDataAdapter adapter = sn.ObtenerPercepciones();
            DataTable tablaDeducciones = new DataTable();

            if (adapter != null)
            {
                adapter.Fill(tablaDeducciones); // Llenar el DataTable con el resultado del OdbcDataAdapter
            }
            return tablaDeducciones;
        }

        public DataTable ObtenerDeducciones()
        {
            OdbcDataAdapter adapter = sn.ObtenerDeducciones();
            DataTable tablaDeducciones = new DataTable();

            if (adapter != null)
            {
                adapter.Fill(tablaDeducciones); // Llenar el DataTable con el resultado del OdbcDataAdapter
            }
            return tablaDeducciones;
        }

        public DataTable ObtenerDepartamentos()
        {
            OdbcDataAdapter adapter = sn.ObtenerDepartamentos();
            DataTable tablaDepartamentos = new DataTable();
            if (adapter != null)
            {
                adapter.Fill(tablaDepartamentos); // Llenar el DataTable con el resultado del OdbcDataAdapter
            }
            return tablaDepartamentos;
        }



    }
}
