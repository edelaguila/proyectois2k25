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
using System.Globalization;


namespace Modelo_Vista_AsistenciaYFaltas
{
    public partial class frm_validar_asistencia : Form
    {
        private Controlador controlador = new Controlador();
        private int mes, anio;
        public frm_validar_asistencia()
        {
            InitializeComponent();
        }
        private void frm_validar_asistencia_Load(object sender, EventArgs e)
        {
            cboMes.Items.AddRange(Enumerable.Range(1, 12).Cast<object>().ToArray());
            cboAnio.Items.AddRange(Enumerable.Range(DateTime.Now.Year - 2, 3).Cast<object>().ToArray());

            // Configurar las columnas del DataGridView
            dgvValidacion.Columns.Clear();
            dgvValidacion.Columns.Add("ID", "ID Empleado");
            dgvValidacion.Columns.Add("DiasTrabajados", "Días Trabajados");
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNoDescontar7mo_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(cboMes.Text, out mes) ||
                            !int.TryParse(cboAnio.Text, out anio))
            {
                MessageBox.Show("Seleccione mes y año válidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Asegurar columnas antes de añadir filas
            if (dgvValidacion.Columns.Count == 0)
            {
                dgvValidacion.Columns.Add("ID", "ID Empleado");
                dgvValidacion.Columns.Add("DiasTrabajados", "Días Trabajados");
            }

            dgvValidacion.Rows.Clear();
            var empleados = controlador.ObtenerEmpleados();

            foreach (var emp in empleados)
            {
                var asistencias = controlador.ObtenerAsistenciasEmpleado(emp.Id, mes, anio);
                var permisos = controlador.ObtenerPermisosEmpleado(emp.Id, mes, anio);

                int diasTrabajados = asistencias
                    .Where(a =>
                        a.Estado == "Presente"
                     || (a.Estado == "Permiso"
                         && permisos.Any(p => p.ConGoce
                                           && a.Fecha >= p.Inicio
                                           && a.Fecha <= p.Fin)))
                    .Select(a => a.Fecha.Date)
                    .Distinct()
                    .Count();

                dgvValidacion.Rows.Add(emp.Id, diasTrabajados);
            }
        }

        private void btnNoDescontarSeptimo_Click(object sender, EventArgs e)
        {
            if(dgvValidacion.CurrentRow == null) return;

            int idEmp = Convert.ToInt32(dgvValidacion.CurrentRow.Cells["ID"].Value);

            var faltas = controlador.ObtenerAsistenciasEmpleado(idEmp, mes, anio)
                .Where(a => a.Estado == "Falta")
                .Select(a => a.Fecha.Date)
                .Distinct()
                .ToList();

            int semana = faltas.Any()
                ? CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                      faltas.First(),
                      CalendarWeekRule.FirstDay,
                      DayOfWeek.Monday)
                : 1;

            controlador.AgregarExcepcionSeptimo(idEmp, semana, anio);

            MessageBox.Show(
                $"Exención de séptimo día registrada para empleado {idEmp}, semana {semana}.",
                "Exención",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    

    private void btnInsertar_Click(object sender, EventArgs e)
        {
            var nominaSvc = new NominaService();
            nominaSvc.GenerarNomina(mes, anio);

            MessageBox.Show(
                "Datos de nómina insertados correctamente.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }
    


        private void frm_validar_asistencia_Load_1(object sender, EventArgs e)
        {
            cboMes.Items.AddRange(Enumerable.Range(1, 12).Cast<object>().ToArray());
            cboAnio.Items.AddRange(Enumerable.Range(DateTime.Now.Year - 2, 3).Cast<object>().ToArray());
        }

        private void btnInsertarDatos_Click(object sender, EventArgs e)
        {
            
        }
    }
}
