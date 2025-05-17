using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Capacitacion;
using Capa_Controlador_Seguridad;

namespace Capa_Vista_Capacitacion
{
    public partial class parámetros_capacitación : Form
    {
        private ToolTip toolTipAyuda = new ToolTip();

        public string sIdUsuario { get; set; }
        logica LogicaSeg = new logica();

        controlador cn = new controlador();
        public parámetros_capacitación()
        {
            InitializeComponent();
        }


        private void parámetros_capacitación_Load(object sender, EventArgs e)
        {
            var parametros = cn.ObtenerParametros();
            if (parametros != null)
            {
                nudAumento.Value = parametros.LimiteVerde;
                nudNeutro.Value = parametros.LimiteAmarillo;
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            toolTipAyuda.SetToolTip(Btn_guardar, "Botón para guardar los nuevos parámetros");

            decimal valorVerde = nudAumento.Value;
            decimal valorAmarillo = nudNeutro.Value;

            var parametros = cn.ObtenerParametros();

            bool exito;

            if (parametros == null)
            {
                // No hay parámetros, insertamos
                exito = cn.InsertarParametros(valorVerde, valorAmarillo);
            }
            else
            {
                // Ya existen, los actualizamos
                exito = cn.ActualizarParametros(valorVerde, valorAmarillo);
            }

            if (exito)
            {
                MessageBox.Show("Parámetros guardados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al guardar los parámetros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LogicaSeg.funinsertarabitacora(sIdUsuario, $"Se guardaron nuevos parámetros", "parámetros_capacitación", "14000");

        }
    }
}
