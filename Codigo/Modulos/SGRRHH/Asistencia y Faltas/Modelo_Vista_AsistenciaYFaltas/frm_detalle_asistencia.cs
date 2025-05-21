using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_AsistenciaYFaltas;
using Capa_Modelo_AsistenciaYFaltas;

namespace Modelo_Vista_AsistenciaYFaltas
{
    public partial class frm_detalle_asistencia : Form
    {
        private readonly Controlador _ctrl = new Controlador();
        private readonly int _idEmpleado;
        private readonly int _mes, _anio;
        public frm_detalle_asistencia()
        {
            InitializeComponent();
        }
        public frm_detalle_asistencia(int idEmpleado, int mes, int anio)
        {
            InitializeComponent();
            _idEmpleado = idEmpleado;
            _mes = mes;
            _anio = anio;
        }

        private void frm_detalle_asistencia_Load(object sender, EventArgs e)
        {
            // Limpiar cualquier configuración previa
            dgvDetalle.Rows.Clear();
            dgvDetalle.Columns.Clear();

            // Definir columnas
            dgvDetalle.Columns.Add("Tipo", "Tipo");
            dgvDetalle.Columns.Add("FechaOCant", "Fecha / Horas");
            dgvDetalle.Columns.Add("Justificacion", "Justificación");
            dgvDetalle.Columns.Add("MesTexto", "Mes");
            dgvDetalle.Columns.Add("Estado", "Estado");

            // 1) Traer faltas
            var faltas = _ctrl.ObtenerFaltasPorEmpleado(_idEmpleado, _mes, _anio)
                              .Select(f => new {
                                  Tipo = "Falta",
                                  FechaOCant = f.Fecha.ToString("dd-MM-yyyy"),
                                  Justificacion = f.Justificacion,
                                  MesTexto = f.MesTexto,
                                  Estado = f.Estado
                              });

            // 2) Traer horas extra
            var horas = _ctrl.ObtenerHorasExtraPorEmpleado(_idEmpleado, _mes, _anio)
                             .Select(h => new {
                                 Tipo = "Hora extra",
                                 FechaOCant = h.CantidadHoras.ToString(),
                                 Justificacion = "",           // no aplica
                                 MesTexto = h.MesTexto,
                                 Estado = h.Estado
                             });

            // 3) Mezclar ambos
            var detalle = faltas
                .Cast<dynamic>()
                .Concat(horas)
                .ToList();

            // 4) Pueblar el grid
            foreach (var r in detalle)
            {
                dgvDetalle.Rows.Add(
                    r.Tipo,
                    r.FechaOCant,
                    r.Justificacion,
                    r.MesTexto,
                    r.Estado
                );
            }
        }

    

}
}
