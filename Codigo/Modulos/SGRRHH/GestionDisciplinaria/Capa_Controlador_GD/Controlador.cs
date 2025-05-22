using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_GD;

namespace Capa_Controlador_GD
{
    public class Controlador
    {
        Sentencia Sn;
        public Controlador(string idUsuario)
        {
            Sn = new Sentencia(idUsuario);
        }

        //Codigo para formulario Evidencias

        public DataTable funconsultalogicafaltas()
        {
            try
            {
                OdbcDataAdapter dtFaltas = Sn.funconsultarfaltas();
                DataTable tableFaltas = new DataTable();
                dtFaltas.Fill(tableFaltas);
                return tableFaltas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public bool funInsertarEvidencia(int ifalta, string stipo, string sarchivo, int iestado)
        {
            return Sn.funInsertarEvidencia(ifalta, stipo, sarchivo, iestado);
        }

        public string funObtenerNombreEmpleado(int idFalta)
        {
            return Sn.funObtenerNombreEmpleado(idFalta);
        }

        public DataTable funObtenerEvidenciaPorId(int id)
        {
            return Sn.funObtenerEvidenciaPorId(id);
        }

        public int funObtenerUltimoIdEvidencia()
        {
            return Sn.ObtenerUltimoIdEvidencia();
        }

        public DataTable funObtenerTodasEvidencias()
        {
            return Sn.funObtenerTodasEvidencias();
        }

        public bool funEditarEvidencia(int id, int ifalta, string stipo, string sarchivo, int iestado)
        {
            return Sn.funEditarEvidencia(id, ifalta, stipo, sarchivo, iestado);
        }

        public bool funEliminarEvidencia(int id)
        {
            return Sn.funEliminarEvidencia(id);
        }

        public DataTable funObtenerEvidenciasEliminadas()
        {
            return Sn.funObtenerEvidenciasEliminadas();
        }

        //FIN Codigo para formulario Evidencias

        //Codigo para formulario Sanciones

        public DataTable ControladorObtenerOperadores()
        {
            return Sn.ObtenerOperadores();
        }

        public static bool funInsertarSancion(int idFalta, string tipoSancion, string descripcion, DateTime fecha, bool noSeAplica, int operador)
        {
            return Sentencia.funInsertarSancion(idFalta, tipoSancion, descripcion, fecha, noSeAplica , operador);
        }

        public static DataTable funObtenerUltimaSancion()
        {
            return Sentencia.funObtenerUltimaSancion();
        }
        public static DataTable funObtenerSancionesActivas()
        {
            return Sentencia.funObtenerSancionesActivas();
        }
        public DataTable funObtenerSancionesInactivas()
        {
            return Sn.consultarSancionesInactivas();
        }

        public bool funEditarSancion(int idSancion, int idFalta, string tipo, string descripcion, string fecha, int estado, int operador)
        {
            return Sn.funeditarSancion(idSancion, idFalta, tipo, descripcion, fecha, estado, operador);
        }

        public DataTable funObtenerSancionPorId(int id)
        {
            return Sn.funObtenerSancionPorId(id);
        }

        public bool funEliminarSanciones(int id)
        {
            return Sn.funEliminarSanciones(id);
        }

    }
}
