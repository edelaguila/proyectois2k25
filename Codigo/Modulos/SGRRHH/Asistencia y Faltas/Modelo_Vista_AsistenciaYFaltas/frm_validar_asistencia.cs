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
using Capa_Controlador_Seguridad;


namespace Modelo_Vista_AsistenciaYFaltas
{
    public partial class frm_validar_asistencia : Form
    {
        private Controlador controlador = new Controlador();
        private List<EmpleadoAsistencia> listaAsistencias = new List<EmpleadoAsistencia>();
        private List<AsistenciaProcesada> asistenciasProcesadas = new List<AsistenciaProcesada>();
        private int mes, anio;

        logica logicaSeg = new logica();




        public string idUsuario { get; set; }
        public frm_validar_asistencia()
        {
            InitializeComponent();
        }
     

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
           
            // 1) Leemos los objetos AsistenciaInfo desde staging (ya parseados)
            var crudas = controlador.ObtenerAsistenciasPreeliminarInfo();
            //MessageBox.Show($"DEBUG: Asistencias preliminares cargadas: {crudas.Count}", "DEBUG");

            // 2) Validamos mes/año
            if (!int.TryParse(cboMes.Text, out mes) ||
                !int.TryParse(cboAnio.Text, out anio))
            {
                MessageBox.Show("Seleccione mes y año válidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3) Limpiamos pantallas y lista
            dgvValidacion.Rows.Clear();
            asistenciasProcesadas.Clear();

            if (crudas.Count == 0)
            {
                MessageBox.Show("No hay asistencias preeliminares por procesar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 4) Filtramos por mes/año y construimos la lista procesada
            foreach (var a in crudas)
            {
                //MessageBox.Show($"DEBUG: Registro → Emp={a.IdEmpleado}, Fecha={a.Fecha:dd-MM-yyyy}, Estado={a.Estado}", "DEBUG");

                //if (a.Fecha.Month != mes || a.Fecha.Year != anio)
                //{
                //    MessageBox.Show($"DEBUG: Saltado {a.Fecha:dd-MM-yyyy} (no en {mes}/{anio})", "DEBUG");
                //    continue;
                //}

                // Estado ya viene en a.Estado ("Presente" o "Falta")
                asistenciasProcesadas.Add(new AsistenciaProcesada
                {
                    IdEmpleado = a.IdEmpleado,
                    Fecha = a.Fecha,
                    HoraEntrada = a.HoraEntrada,
                    HoraSalida = a.HoraSalida,
                    Estado = a.Estado
                });
            }

            // 5) Agrupamos y contamos días “Presente”
            var resumen = asistenciasProcesadas
                .GroupBy(x => x.IdEmpleado)
                .Select(g => new
                {
                    IdEmpleado = g.Key,
                    DiasTrabajados = g
                        .Where(x => x.Estado == "Presente")
                        .Select(x => x.Fecha.Date)
                        .Distinct()
                        .Count()
                })
                .ToList();

            // 6) Pintamos el Grid
            foreach (var eEmp in resumen)
            {
                //MessageBox.Show($"DEBUG: Empleado {eEmp.IdEmpleado} → Días Trabajados = {eEmp.DiasTrabajados}", "DEBUG");
                dgvValidacion.Rows.Add(eEmp.IdEmpleado, eEmp.DiasTrabajados);
            }

            MessageBox.Show($"Procesadas {asistenciasProcesadas.Count} asistencias correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private EmpleadoAsistencia ProcesarLineaAsistencia(string linea)
        {
            var partes = linea.Split(']');
            if (partes.Length < 2) throw new Exception("Formato incorrecto.");

            string fechaTexto = partes[0].Trim('[', ']');
            string[] horarioEmpleado = partes[1].Split(',');
            string[] horas = horarioEmpleado[0].Split('-');
            string idEmpleado = horarioEmpleado[1].Trim('.');

            DateTime fecha = DateTime.ParseExact(fechaTexto, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            TimeSpan horaEntrada = TimeSpan.Parse(horas[0]);
            TimeSpan horaSalida = TimeSpan.Parse(horas[1]);

            return new EmpleadoAsistencia
            {
                Fecha = fecha,
                HoraEntrada = horaEntrada,
                HoraSalida = horaSalida,
                IdEmpleado = int.Parse(idEmpleado),
                Estado = (horaEntrada == TimeSpan.Zero && horaSalida == TimeSpan.Zero) ? "Falta" : "Presente"
            };
        }


        public class EmpleadoAsistencia
    {
        public int IdEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public string Estado { get; set; }
    }

    private void btnNoDescontarSeptimo_Click(object sender, EventArgs e)
        {
            if (dgvValidacion.CurrentRow == null)
                return;

            int idEmp = Convert.ToInt32(dgvValidacion.CurrentRow.Cells["ID"].Value);
            controlador.AgregarExcepcionSeptimo(idEmp, mes, anio);
            MessageBox.Show($"Exención de séptimo día registrada para empleado {idEmp}.", "Exención registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (asistenciasProcesadas.Count == 0)
            {
                MessageBox.Show("No hay asistencias procesadas para insertar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear una instancia de NominaService
            var nominaService = new NominaService();
            nominaService.GenerarNomina(mes, anio);

            MessageBox.Show("Nómina generada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            logicaSeg.funinsertarabitacora(idUsuario, "se calculo la asistencia del mes", "tbl_salarios_mensuales", "16002");
        }

        private class AsistenciaProcesada
        {
            public int IdEmpleado { get; set; }
            public DateTime Fecha { get; set; }
            public TimeSpan HoraEntrada { get; set; }
            public TimeSpan HoraSalida { get; set; }
            public string Estado { get; set; }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (dgvValidacion.CurrentRow == null) return;

            int idEmp = Convert.ToInt32(dgvValidacion.CurrentRow.Cells["ID"].Value);

            using (var frm = new frm_detalle_asistencia(idEmp, mes, anio))
            {
                frm.ShowDialog();
            }
        }

        private void frm_validar_asistencia_Load_1(object sender, EventArgs e)
        {
            cboMes.Items.AddRange(Enumerable.Range(1, 12).Cast<object>().ToArray());
            cboAnio.Items.AddRange(Enumerable.Range(DateTime.Now.Year - 2, 3).Cast<object>().ToArray());

            // Configurar columnas
            dgvValidacion.Columns.Clear();
            dgvValidacion.Columns.Add("ID", "ID Empleado");
            dgvValidacion.Columns.Add("DiasTrabajados", "Días Trabajados");
            dgvValidacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        
    }
}
