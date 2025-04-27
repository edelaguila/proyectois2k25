using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_GD
{
    public class Sentencia
    {
        Conexion cn = new Conexion();
        private string idUsuario;

        public Sentencia(string idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        //Consulta para rellenar el combobox de idFalta
        public OdbcDataAdapter funconsultarfaltas()
        {
            cn.conexion();
            string sqlFaltas = "SELECT pk_id_falta FROM tbl_faltas_disciplinarias WHERE estado = 1";
            OdbcDataAdapter dataFaltas = new OdbcDataAdapter(sqlFaltas, cn.conexion());
            //funInsertarBitacora(idUsuario, "Realizo una consulta a perfiles", "Tbl_perfiles", "1000");
            return dataFaltas;
        }

        //Consulta para insertar datos en la base de datos
        public bool funInsertarEvidencia(int idFalta, string stipo, string sarchivo, int iestado)
        {
            try
            {
                using (OdbcConnection conn = cn.conexion())
                {
                    string sql = "INSERT INTO tbl_evidencias (fk_id_falta, evidencia_tipo, evidencia_url, estado) VALUES (?, ?, ?, ?)";
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@idFalta", idFalta);
                        cmd.Parameters.AddWithValue("@tipoEvidencia", stipo);
                        cmd.Parameters.AddWithValue("@urlEvidencia", sarchivo);
                        cmd.Parameters.AddWithValue("@estado", iestado);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar evidencia: " + ex.Message);
                return false;
            }
        }
    }
}
