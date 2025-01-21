using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Consulta;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Capa_Controlador_Consulta
{
    public class consultaControlador
    {
        /*
         
         CREADO POR CARLOS GONZÁLEZ 9959-20-6164

         */

        consultaSentencias csSentencias = new consultaSentencias();

        public string GenerarQuerySimple(string[] datos)
        {
            string tblConsultada = datos[2];
            string query = datos[4];
            string datoQueryGenerado = "SELECT ";
            string fragmentoActual = "";
            bool esCampo = true;

            foreach (char c in query)
            {
                if (c == '+')
                {
                    fragmentoActual = fragmentoActual.Trim();

                    if (!string.IsNullOrEmpty(fragmentoActual))
                    {
                        if (esCampo)
                        {
                            datoQueryGenerado += $"{fragmentoActual}";
                            esCampo = false;
                        } else {
                            datoQueryGenerado += $" AS {fragmentoActual}, ";
                            esCampo = true;
                        }
                        fragmentoActual = "";
                    }
                } else {
                    fragmentoActual += c;
                }
            }
            // Procesar el último fragmento si no se ha procesado
            if (!string.IsNullOrEmpty(fragmentoActual.Trim()))
            {
                if (esCampo)
                {
                    datoQueryGenerado += fragmentoActual;
                } else {
                    datoQueryGenerado += $" AS {fragmentoActual}";
                }
            }
            // Remover la última coma y agregar el FROM
            datoQueryGenerado = datoQueryGenerado.TrimEnd(',', ' ') + $" FROM {tblConsultada};";
            datos[4] = datoQueryGenerado;
            // Mostrar el query generado en consola (opcional)
            Console.WriteLine($"Query generado: {datoQueryGenerado}");
            return datoQueryGenerado;
        }
        public string GenerarQueryComplejo(string[] datosComplejos, string[] datos)
        {
            string operador = datosComplejos[0];
            string campo = datosComplejos[1];
            string valor = datosComplejos[2];
            string querySimple = datos[4];
            // Remover el punto y coma al final si existe
            querySimple = querySimple.TrimEnd(';');
            // Paso 1: Identificar el tipo de operador
            if (operador.Equals("AND", StringComparison.OrdinalIgnoreCase) ||
                operador.Equals("OR", StringComparison.OrdinalIgnoreCase))
            {
                // Operador lógico: Agregar al WHERE existente o iniciar WHERE si no existe
                if (!querySimple.ToUpper().Contains("WHERE"))
                {
                    querySimple += $" WHERE {campo} = {valor}";
                } else {
                    querySimple += $" {operador} {campo} = {valor}";
                }
            }
            else if (operador.Equals("NOT", StringComparison.OrdinalIgnoreCase))
            {
                // Operador NOT: Debe aplicarse antes de una condición
                if (!querySimple.ToUpper().Contains("WHERE"))
                {
                    querySimple += $" WHERE NOT ({campo} = {valor})";
                } else {
                    querySimple += $" AND NOT ({campo} = {valor})";  // NOT se añade con AND por defecto
                }
            }
            else if (operador.Equals("WHERE", StringComparison.OrdinalIgnoreCase))
            {
                // Operador de comparación: Solo se permite un WHERE
                if (!querySimple.ToUpper().Contains("WHERE"))
                {
                    querySimple += $" WHERE {campo} = {valor}";
                } else {
                    // Si ya hay un WHERE, combinarlo con AND por defecto
                    querySimple += $" AND {campo} = {valor}";
                }
            }
            else if (operador.Equals("ORDER BY", StringComparison.OrdinalIgnoreCase))
            {
                // Operador de Ordenación: Valor debe ser ASC o DESC
                querySimple += $" ORDER BY {campo} {valor}";
            }
            else if (operador.Equals("GROUP BY", StringComparison.OrdinalIgnoreCase))
            {
                // Operador de Agrupación: No necesita un valor en el tercer espacio
                querySimple += $" GROUP BY {campo}";
            }
            // Agregar el punto y coma al final
            querySimple += ";";
            // Paso 2: Mostrar el query generado en consola (opcional)
            Console.WriteLine($"Query complejo generado: {querySimple}");
            datos[4] = querySimple;
            return querySimple;
        }
        public DataTable GenerarQuery(string[] datos, string nombreTabla)
        {
            string campo = datos[0];
            string operador = datos[1];
            string valor = datos[2];

            string[] operadoresValidos = { "=", "<", "<=", ">", ">=", "LIKE", "NOT LIKE" };
            if (!operadoresValidos.Contains(operador.ToUpper()))
            {
                throw new ArgumentException("Operador no válido");
            }
            string valorQuery;
            if (operador.ToUpper().Contains("LIKE"))
            {
                valorQuery = $"'%{valor}%'";
            }
            else
            {
                valorQuery = $"'{valor}'";
            }
            string query = $"SELECT * FROM {nombreTabla} WHERE {campo} {operador} {valorQuery};";
            Console.WriteLine($"Query generado: {query}");
            OdbcDataAdapter adapter = csSentencias.EjecutarQuery(query);
            DataTable tablaResultados = new DataTable();
            adapter.Fill(tablaResultados);
            return tablaResultados;
        }

public void InsertarDatos(string[] tipos, string[] datos, string tabla)
{
    try
    {
        // Verificación de que el array datos no es null y tiene al menos 6 elementos
        if (datos == null || datos.Length < 6)
        {
            MessageBox.Show("Los datos proporcionados son inválidos o incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return; // Salir de la función si el array no está correctamente inicializado
        }

        // Verificación de que los datos no sean nulos o estén vacíos
        if (string.IsNullOrEmpty(datos[0]))
        {
            MessageBox.Show("El nombre de la consulta no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (string.IsNullOrEmpty(datos[1]))
        {
            MessageBox.Show("El tipo de consulta no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (string.IsNullOrEmpty(datos[4]))
        {
            MessageBox.Show("El query generado no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (string.IsNullOrEmpty(datos[5]))
        {
            MessageBox.Show("El estado de la consulta no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Si todo está bien, proceder con la inserción
        string queryGenerado = datos[4]; // Asumimos que el query ya fue generado
        string nombreConsulta = datos[0];
        string tipoConsulta = datos[1];
        string status = datos[5];

        // Construir el tipo para el método de inserción
        string tipo = string.Join(",", tipos);

        // Construir el dato para el método de inserción
        string dato = $"'{nombreConsulta}','{tipoConsulta}','{queryGenerado}','{status}'";

        // Llamar a la capa de modelo para insertar la consulta
        csSentencias.insertar(dato, tipo, tabla);

        MessageBox.Show("Datos guardados correctamente");
    }
    catch (Exception ex)
    {
        // Manejar posibles errores de manera más específica
        Console.WriteLine($"Error al insertar los datos: {ex.Message}");
        MessageBox.Show("Error al insertar, revisar Consola...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}


        public void obtenerColumbasPorTabla(ComboBox comboBoxCampos, string tabla)
        {
            // Recibimos la lista de columnas desde el modelo
            List<string> columnas = csSentencias.ObtenerColumnas(tabla);
            // Limpiamos el comboBox antes de añadir nuevas columnas
            comboBoxCampos.Items.Clear();
            // Añadimos cada columna al ComboBox
            foreach (string columna in columnas)
            {
                comboBoxCampos.Items.Add(columna);
            }
        }

        public void CargarTablas(ComboBox comboBox1, string BD)
        {
            OdbcDataAdapter dt = csSentencias.buscartbl(BD);
            DataTable table = new DataTable();
            dt.Fill(table);
            int contador = 0;
            comboBox1.Items.Clear();
            foreach (DataRow Row in table.Rows)
            {
                comboBox1.Items.Add(table.Rows[contador][0].ToString());
                contador++;
            }
        }
        public void ingresar(string[] tipos, string[] datos, string tabla)
        {
            try
            {
                // Asegúrate de construir el query solo a partir de `datos` si `tipos` no es necesario
                string dato = "";
                foreach (string datoItem in datos)
                {
                    dato += "'" + datoItem + "',";
                }
                // Limpia la última coma
                dato = dato.TrimEnd(',');
                // Aquí podrías hacer lo que necesites con el dato y tipo (si se usa)
                Console.WriteLine("Dato agregado correctamente");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al agregar los datos: " + e.Message);
            }
        }

        // Fin de la participación de Carlos González


        //////////////////// // SALVADOR MARTÍNEZ // PESTAÑA EDITAR ////////////////////

        public void obtenerNombresConsultas(ComboBox comboBoxConsultas)
        {
            // Recibimos la lista de nombres de consultas desde el modelo
            List<string> nombresConsultas = csSentencias.ObtenerNombresConsultas();
            // Limpiamos el ComboBox antes de añadir nuevos nombres
            comboBoxConsultas.Items.Clear();
            // Añadimos cada nombre de consulta al ComboBox
            foreach (string nombreConsulta in nombresConsultas)
            {
                comboBoxConsultas.Items.Add(nombreConsulta);
            }
        }

        public void ActualizarDatos(string[] tipos, string[] datos, string tabla)
        {
            try
            {
                string queryGenerado = datos[4]; // Asumimos que el query ya fue generado
                string nombreConsulta = datos[0];
                string tipoConsulta = datos[1];
                string status = datos[5];
                // Construir la cláusula SET para el método de actualización
                // NOTA: Asegúrate de que los nombres de las columnas coincidan con los de tu base de datos.
                string setClause = $"consultaInteligente_nombre_consulta = '{nombreConsulta}', consultaInteligente_tipo_consulta = '{tipoConsulta}', consultaInteligente_consulta_SQLE = '{queryGenerado}', consultaInteligente_consulta_estatus = '{status}'";
                // Construir la condición WHERE para la actualización
                string condicion = $"consultaInteligente_nombre_consulta = '{nombreConsulta}'";
                // Llamar al método actualizar con la cláusula SET y la condición WHERE
                csSentencias.actualizar(setClause, tabla, condicion);
                MessageBox.Show("Datos actualizados correctamente");
            }
            catch (Exception ex)
            {
                // Manejar posibles errores
                Console.WriteLine($"Error al actualizar los datos: {ex.Message}");
                MessageBox.Show("Error al actualizar, revisar Consola...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Creado por Sebastian Luna



        public void obtenerNombresConsultas1(ComboBox comboBoxConsultas)
        {
            // Recibimos la lista de nombres de consultas desde el modelo
            List<string> nombresConsultas = csSentencias.ObtenerNombresConsultas();
            // Limpiamos el ComboBox antes de añadir nuevos nombres
            comboBoxConsultas.Items.Clear();
            // Añadimos cada nombre de consulta al ComboBox
            foreach (string nombreConsulta in nombresConsultas)
            {
                comboBoxConsultas.Items.Add(nombreConsulta);

            }
        }

        public void BuscarQuerySeleccionado(string querySeleccionado, DataGridView dgvConsultas, TextBox txtQuery1)
        {
            consultaSentencias csSentencias = new consultaSentencias();
            try
            {
                // 1. Obtener la cadena SQL del query seleccionado
                string query = csSentencias.ObtenerQueryPorNombre(querySeleccionado);
                // 2. Mostrar la cadena SQL en el TextBox
                txtQuery1.Text = query;
                // 3. Ejecutar el query y llenar el DataGridView con los resultados
                OdbcDataAdapter adapter = csSentencias.EjecutarQuery(query);
                DataTable tablaResultados = new DataTable();
                adapter.Fill(tablaResultados);
                // 4. Mostrar los resultados en el DataGridView
                dgvConsultas.DataSource = tablaResultados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el query: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarQueryEnTextBox(ComboBox cboQuery1, TextBox txtQuery1)
        {
            // Verificar si hay un query seleccionado en el ComboBox
            if (cboQuery1.SelectedItem != null)
            {
                // Mostrar la cadena generada del query seleccionado en el TextBox
                string querySeleccionado = cboQuery1.SelectedItem.ToString();
                string query = csSentencias.ObtenerQueryPorNombre(querySeleccionado);
                txtQuery1.Text = query;
            }
        }

        public void EliminarConsulta(string nombreConsulta)
        {
            // Llamar al método de la capa de modelo para actualizar el estado de la consulta
            csSentencias.EliminarConsulta(nombreConsulta);
        }
        //Fin participacion Sebastian Luna

        // ayudas
        public string MIndice(string Indice1)
        {
            string indice = csSentencias.modIndice(Indice1);

            return indice;
        }

        public string MRuta(string Ruta1)
        {
            string ruta = csSentencias.modRuta(Ruta1);

            return ruta;
        }
    }
}   