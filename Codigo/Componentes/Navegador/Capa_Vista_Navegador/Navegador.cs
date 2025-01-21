using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Navegador;
using Capa_Controlador_Reporteria;
using Capa_Vista_Reporteria;
using Capa_Vista_Consulta;
using Capa_Controlador_Seguridad;
using System.IO;

namespace Capa_Vista_Navegador
{
    public partial class Navegador : UserControl
    {
        Validaciones v = new Validaciones(); // Instancia para validaciones
        logicaNav logic = new logicaNav(); // Lógica del navegador
        Form frmCerrar; // Formulario de cierre
        int iCorrecto = 0; // Variable de control para verificar si todo está correcto
        string sTablaPrincipal = "def"; // Nombre de la sTablaPrincipal principal
                                        // Nombre de una sTablaPrincipal secundaria
        List<string> lstTablasAdicionales = new List<string>(); // Lista de tablas adicionales
        Dictionary<string, string> dicItems;
        string sNombreFormulario; // Nombre del formulario
        int iPosicionInicial = 8; // Posición inicial de componentes
        string sIdReporte = ""; // ID del reporte

        int[] arrModoCampoCombo = new int[40]; // Modo de los campos de combo
        int iNumeroCampos = 1; // Contador de campos
        int iPosicionX = 30; // Posición X inicial para componentes
        int iPosicionY = 30; // Posición Y inicial para componentes
        int iActivar = 0; // Variable para reconocer la función del botón de guardar (1. Ingresar, 2. Modificar, 3. Eliminar)
        string[] arrAliasCampos = new string[40]; // Alias para los campos
        string[] arrTipoCampos = new string[30]; // Tipo de los campos
        string[] arrTablaCombo = new string[30]; // Nombre de las tablas de combo
        string[] arrCampoCombo = new string[30]; // Campos de combo
        string[] arrListaItems = new string[30]; // Lista de items
        string[] arrCampoDisplayCombo = new string[30]; // Campos display del combo

        //string sTablaRelacionada = ""; // Tabla relacionada
        //string sCampoDescriptivo = ""; // Campo descriptivo
        //string sColumnaPrimariaRelacionada = ""; // Columna primaria relacionada
        //string sColumnaForanea = ""; // Columna foránea

        int iPosicionCombo = 10; // Posición del combo
        int iNumeroCombos = 0; // Número de combos
        int iNumeroCombosAux = 0; // Número auxiliar de combos
        int iEstadoFormulario = 1; // Estado del formulario (1. Activado, 0. Desactivado)
        Color cColorFuente = Color.White; // Color de la fuente
        Color cNuevoColorFondo = Color.White; // Nuevo color de fondo
        //bool bPresionado = false; // Verifica si se ha presionado un botón
        logica lg = new logica(); // Objeto para obtener métodos de bitácora
        string sIdUsuario = ""; // ID del usuario
        string sIdAplicacion = ""; // ID de la aplicación
        string sUsuarioActivo = ""; // Usuario activo
        string sAplicacionActiva = ""; // Aplicación activa
        string sIdAyuda; // ID de la ayuda
        string sRutaAyuda; // Ruta de la ayuda
        string sIndiceAyuda; // Índice de la ayuda
        string sEstadoAyuda = ""; // Estado de la ayuda
        Font fFuenteLabels = new Font("Century Gothic", 13.0f, FontStyle.Regular, GraphicsUnit.Pixel); // Fuente para labels
        ToolTip tpAyuda = new ToolTip(); // ToolTip para mostrar ayudas en la interfaz
        private List<Tuple<string, string, string, string>> relacionesForaneas = new List<Tuple<string, string, string, string>>();
        List<Tuple<string, string, string>> comboData = new List<Tuple<string, string, string>>();
        Dictionary<string, string[]> aliasPorTabla = new Dictionary<string, string[]>();



        public Navegador()
        {
            InitializeComponent();
            LimpiarListaItems(); // Limpia la lista de items
                                 // this.AutoScaleMode = AutoScaleMode.Dpi; // Escala automática
            this.Dock = DockStyle.Fill;
            sUsuarioActivo = sIdUsuario; // Actualizado: nombre de la variable para el usuario activo
            sAplicacionActiva = sIdAplicacion; // Actualizado: nombre de la variable para la aplicación activa
                                               // Configuración del ToolTip
            tpAyuda.IsBalloon = true; // Actualizado: nombre de la variable para el ToolTip
            tpAyuda.AutoPopDelay = 5000; // Mantener el ToolTip visible por 5 segundos
            tpAyuda.InitialDelay = 1000; // Retraso de 1 segundo antes de que aparezca el ToolTip
            tpAyuda.ReshowDelay = 500;   // Retraso de medio segundo antes de reaparecer
            tpAyuda.ShowAlways = true;   // Mostrar el ToolTip siempre, incluso cuando el control no tiene el foco
                                         // Asignación de ToolTips a botones
            tpAyuda.SetToolTip(Btn_Ingresar, "Agregar un nuevo registro al sistema.");
            tpAyuda.SetToolTip(Btn_Modificar, "Modificar el registro seleccionado.");
            tpAyuda.SetToolTip(Btn_Guardar, "Guardar los cambios realizados.");
            tpAyuda.SetToolTip(Btn_Cancelar, "Cancelar la operación actual.");
            tpAyuda.SetToolTip(Btn_Eliminar, "Eliminar el registro seleccionado.");
            tpAyuda.SetToolTip(Btn_Consultar, "Acceder a las consultas avanzadas.");
            tpAyuda.SetToolTip(Btn_Refrescar, "Actualizar los datos de la sTablaPrincipal.");
            tpAyuda.SetToolTip(Btn_FlechaInicio, "Ir al primer registro.");
            tpAyuda.SetToolTip(Btn_Anterior, "Mover al registro anterior.");
            tpAyuda.SetToolTip(Btn_Siguiente, "Mover al siguiente registro.");
            tpAyuda.SetToolTip(Btn_FlechaFin, "Ir al último registro.");
            tpAyuda.SetToolTip(Btn_Ayuda, "Ver la ayuda del formulario.");
            tpAyuda.SetToolTip(Btn_Salir, "Cerrar el formulario actual.");
            tpAyuda.SetToolTip(Btn_Imprimir, "Mostrar un Reporte");

        }


        // Método para manejar la carga del navegador
        private void Navegador_Load(object sender, EventArgs e)
        {
            colorDialog1.Color = cNuevoColorFondo; // Asigna el color de fondo seleccionado
            this.BackColor = colorDialog1.Color; // Aplica el color de fondo al formulario
            BotonesYPermisosSinMensaje(); // Asigna los permisos a los botones según el usuario
            foreach (Control ctrl in Tlp_Panel2.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Paint += button_Paint;
                }
            }
            if (sTablaPrincipal != "def") // Verifica si la sTablaPrincipal no es "def" (valor por defecto)
            {
                string sTablaOK = logic.TestTabla(sTablaPrincipal); // Verifica la existencia de la sTablaPrincipal
                if (sTablaOK == "" && iCorrecto == 0) // Si la sTablaPrincipal existe y no hay errores previos
                {
                    string sEstadoOK = logic.TestEstado(sTablaPrincipal); // Verifica el estado de la sTablaPrincipal
                    if (sEstadoOK == "" && iCorrecto == 0) // Si el estado de la sTablaPrincipal es correcto
                    {
                        if (sEstadoAyuda == "0") // Verifica si hay registros en la sTablaPrincipal Ayuda
                        {
                            MessageBox.Show("No se encontró ningún registro en la sTablaPrincipal Ayuda");
                            Application.Exit(); // Sale de la aplicación si no se encuentra ayuda
                        }
                        else
                        {
                            if (NumeroAlias() == logic.ContarCampos(sTablaPrincipal)) // Verifica si el número de alias coincide con el número de campos de la sTablaPrincipal
                            {
                                int iIndex = 0;
                                DataTable dt = logic.ConsultaLogica(sTablaPrincipal, relacionesForaneas); // Realiza la consulta lógica de la sTablaPrincipal
                                Dgv_Informacion.DataSource = dt; // Asigna el resultado de la consulta al DataGridView

                                // Asigna los alias como encabezados de las columnas
                                int iHead = 0;
                                while (iHead < logic.ContarCampos(sTablaPrincipal))
                                {
                                    Dgv_Informacion.Columns[iHead].HeaderText = arrAliasCampos[iHead];
                                    iHead++;
                                }

                                CreaComponentes(); // Crea los componentes del formulario
                                                   // Ocupa todo el espacio del contenedor, con margen si está configurado

                                ColorTitulo(); // Cambia el color del título
                                Txt_Tabla.ForeColor = cColorFuente; // Asigna el color de la fuente al label de la sTablaPrincipal
                                Deshabilitarcampos_y_botones(); // Deshabilita los campos y botones inicialmente

                                // Verifica si hay registros en la sTablaPrincipal y habilita/deshabilita controles según corresponda
                                if (logic.TestRegistros(sTablaPrincipal) > 0)
                                {
                                    int iNumCombo = 0;
                                    foreach (Control componente in Controls)
                                    {
                                        if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                                        {
                                            if (componente is ComboBox)
                                            {
                                                // Asigna valores a los ComboBox según la lógica de la aplicación
                                                if (arrModoCampoCombo[iNumCombo] == 1)
                                                {
                                                    componente.Text = logic.LlaveCampoRev(arrTablaCombo[iNumCombo], arrCampoCombo[iNumCombo], Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString());
                                                }
                                                else
                                                {
                                                    componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                                                }

                                                iNumCombo++;
                                            }
                                            else
                                            {
                                                componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                                            }

                                            iIndex++;
                                        }
                                        if (componente is Button)
                                        {
                                            // Configura los botones según el estado del registro
                                            string sVar1 = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                                            if (sVar1 == "0")
                                            {
                                                componente.Text = "Desactivado";
                                                componente.BackColor = Color.Red;
                                            }
                                            if (sVar1 == "1")
                                            {
                                                componente.Text = "Activado";
                                                componente.BackColor = Color.Green;
                                            }
                                            componente.Enabled = false; // Deshabilita el botón
                                        }
                                    }
                                }
                                else // Si no hay registros, deshabilita los botones de navegación y edición
                                {
                                    Btn_Anterior.Enabled = false;
                                    Btn_Siguiente.Enabled = false;
                                    Btn_FlechaInicio.Enabled = false;
                                    Btn_FlechaFin.Enabled = false;
                                    Btn_Modificar.Enabled = false;
                                    Btn_Eliminar.Enabled = false;
                                }
                            }
                            else
                            {
                                // Si el número de alias no coincide con el número de campos, muestra un mensaje de error y sale de la aplicación
                                if (NumeroAlias() < logic.ContarCampos(sTablaPrincipal))
                                {
                                    DialogResult drValidacion = MessageBox.Show(sEstadoOK + "El número de Alias asignados es menor que el requerido \n Solucione este error para continuar...", "Verificación de requisitos", MessageBoxButtons.OK);
                                    if (drValidacion == DialogResult.OK)
                                    {
                                        Application.Exit();
                                    }
                                }
                                else
                                {
                                    if (NumeroAlias() > logic.ContarCampos(sTablaPrincipal))
                                    {
                                        DialogResult drValidacion = MessageBox.Show(sEstadoOK + "El número de Alias asignados es mayor que el requerido \n Solucione este error para continuar...", "Verificación de requisitos", MessageBoxButtons.OK);
                                        if (drValidacion == DialogResult.OK)
                                        {
                                            Application.Exit();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        // Muestra un mensaje de error si el estado de la sTablaPrincipal no es correcto y sale de la aplicación
                        DialogResult drValidacion = MessageBox.Show(sEstadoOK + "\n Solucione este error para continuar...", "Verificación de requisitos", MessageBoxButtons.OK);
                        if (drValidacion == DialogResult.OK)
                        {
                            Application.Exit();
                        }
                    }
                }
                else
                {
                    // Muestra un mensaje de error si la sTablaPrincipal no existe y sale de la aplicación
                    DialogResult drValidacion = MessageBox.Show(sTablaOK + "\n Solucione este error para continuar...", "Verificación de requisitos", MessageBoxButtons.OK);
                    if (drValidacion == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                // Si la sTablaPrincipal es "def", no realiza ninguna acción
            }
        }


        //-----------------------------------------------Funciones-----------------------------------------------//

        //******************************************** CODIGO HECHO POR DIEGO MARROQUIN ***************************** 

        void ColorTitulo()
        {
            foreach (Control componente in Controls)
            {
                if (componente is Label)
                {
                    componente.ForeColor = cColorFuente; // Cambia el color de la fuente de los labels
                }
            }
        }

        public void ObtenerIdUsuario(string sIdUsuario)
        {
            this.sIdUsuario = sIdUsuario; // Asigna el ID del usuario
        }

        // Lista para almacenar múltiples relaciones foráneas como tuplas

        // Lista para almacenar múltiples relaciones foráneas
        
        public void AsignarForaneas(string sTablaRela, string sCampoDescri, string sColumnaFora, string sColumnaPrimariaRelaciona)
        {
            // Añadir la relación foránea a la lista
            relacionesForaneas.Add(new Tuple<string, string, string, string>(sTablaRela, sCampoDescri, sColumnaFora, sColumnaPrimariaRelaciona));
        }


        //******************************************** CODIGO HECHO POR DIEGO MARROQUIN ***************************** 

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 
        public void ObtenerIdAplicacion(string sIdAplicacion)
        {
            this.sIdAplicacion = sIdAplicacion; // Asigna el ID de la aplicación
        }


        private int NumeroAlias()
        {
            int iIndex = 0;
            foreach (string sCad in arrAliasCampos)
            {
                if (sCad != null && sCad != "")
                {
                    iIndex++;
                }
            }
            return iIndex; // Devuelve el número de alias asignados
        }

        public string ObtenerDatoTabla(int iPos)
        {
            iPos = iPos - 1;
            return Dgv_Informacion.CurrentRow.Cells[iPos].Value.ToString(); // Devuelve un dato específico de la sTablaPrincipal según la posición
        }

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 

        public string ObtenerDatoCampos(int iPos)
        {
            int iIndex = 0;
            iPos = iPos - 1;  // Ajuste del índice, ya que 'pos' es 1-based, pero los arrays son 0-based
            string sDato = "";

            // Recorre los controles relevantes: TextBox, DateTimePicker, ComboBox
            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    if (iIndex == iPos)  // Verifica si el índice coincide con el solicitado
                    {
                        // Obtiene el valor del control según su tipo
                        if (componente is TextBox || componente is ComboBox)
                        {
                            sDato = componente.Text;  // Para TextBox y ComboBox, toma el texto
                        }
                        else if (componente is DateTimePicker dateTimePicker)
                        {
                            sDato = dateTimePicker.Value.ToString("yyyy-MM-dd");  // Formato de fecha
                        }
                        break;  // Una vez encontrado el campo, termina el ciclo
                    }
                    iIndex++;  // Incrementa el índice solo si es un control relevante
                }
            }

            return sDato; // Devuelve el valor del campo encontrado
        }

        public void AsignarAlias(string[] arrAlias)
        {
            arrAlias.CopyTo(arrAliasCampos, 0); // Cambiado aliasC a arrAliasCampos
        }

        //******************************************** CODIGO HECHO POR PABLO FLORES ***************************** 

        public void AsignarAyuda(string sAyudar)
        {
            string sAyudaOK = logic.TestTabla("ayuda");
            if (sAyudaOK == "")
            {
                if (logic.ContarRegAyuda(sAyudar) > 0)
                {
                    sIdAyuda = sAyudar; 
                    sRutaAyuda = logic.ModRuta(sIdAyuda);
                    sIndiceAyuda = logic.ModIndice(sIdAyuda); 
                    if (sRutaAyuda == "" || sIndiceAyuda == "" || sRutaAyuda == null || sIndiceAyuda == null)
                    {
                        DialogResult drValidacion = MessageBox.Show("La Ruta o índice de la ayuda está vacía", "Verificación de requisitos", MessageBoxButtons.OK);
                        if (drValidacion == DialogResult.OK)
                        {
                            iCorrecto = 1; 
                        }
                    }
                }
                else
                {
                    DialogResult drValidacion = MessageBox.Show("Por favor verifique el id de Ayuda asignado al form", "Verificación de requisitos", MessageBoxButtons.OK);
                    if (drValidacion == DialogResult.OK)
                    {
                        iCorrecto = 1;
                    }
                }

            }
            else
            {
                DialogResult drValidacion = MessageBox.Show(sAyudaOK + ", Por favor incluirla", "Verificación de requisitos", MessageBoxButtons.OK);
                if (drValidacion == DialogResult.OK)
                {
                    iCorrecto = 1; 
                }
            }
        }

        public void AsignarReporte(string sRepo)
        {
            sIdReporte = sRepo; 
        }

        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS ***************************** 

        public void AsignarSalida(Form frmSalida)
        {
            frmCerrar = frmSalida; 
        }

        public void AsignarColorFuente(Color colFuenteC)
        {
            cColorFuente = colFuenteC; 
        }

        public void AsignarTabla(string sTabla)
        {
            sTablaPrincipal = sTabla; 
        }

        public void AsignarTablas(List<string> lstTablas)
        {
            lstTablasAdicionales = lstTablas; 
        }

        public void AsignarNombreForm(string sNom)
        {
            sNombreFormulario = sNom; 
            Txt_Tabla.Text = sNombreFormulario; 
        }

        //******************************************** CODIGO HECHO POR JOSUE CACAO ***************************** 

       public void AsignarComboConTabla(string sTablaPrincipal, string sCampoClave, string sCampoDisplay, int iModo)
        {
            // Verifica si la sTablaPrincipal existe
            string sTablaOK = logic.TestTabla(sTablaPrincipal);
            if (sTablaOK == "")
            {
                // Asigna los valores para el combo
                arrModoCampoCombo[iNumeroCombos] = iModo; 
                arrTablaCombo[iNumeroCombos] = sTablaPrincipal;
                arrCampoCombo[iNumeroCombos] = sCampoClave;
                arrCampoDisplayCombo[iNumeroCombos] = sCampoDisplay;
                comboData.Add(new Tuple<string, string, string>(sTablaPrincipal, sCampoClave, sCampoDisplay));
                iNumeroCombos++;
               
            }
            else
            {
                // Muestra error si la sTablaPrincipal o campo son incorrectos
                DialogResult drValidacion = MessageBox.Show(sTablaOK + ", o el campo seleccionado\n para el ComboBox es incorrecto", "Verificación de requisitos", MessageBoxButtons.OK);
                if (drValidacion == DialogResult.OK)
                {
                    iCorrecto = 1; // Cambiado correcto a iCorrecto
                }
            }
        }


        //******************************************** CODIGO HECHO POR ANIKA ESCOTO ***************************** 

        public void AsignarColorFondo(Color colNuevo)
        {
            cNuevoColorFondo = colNuevo; 
        }

        public void AsignarComboConLista(int iPos, string sLista)
        {
            iPosicionCombo = iPos - 1; 
            LimpiarLista(sLista);
            arrModoCampoCombo[iNumeroCombos] = 0; 
            iNumeroCombos++;
        }

        void LimpiarLista(string sCadena)
        {
            LimpiarListaItems();
            int iContadorCadena = 0;
            int iContadorArray = 0;
            string sPalabra = "";
            while (iContadorCadena < sCadena.Length)
            {
                if (sCadena[iContadorCadena] != '|')
                {
                    sPalabra += sCadena[iContadorCadena];
                    iContadorCadena++;
                }
                else
                {
                    arrListaItems[iContadorArray] = sPalabra; 
                    sPalabra = "";
                    iContadorArray++;
                    iContadorCadena++;
                }
            }
        }


        void LimpiarListaItems()
        {
            for (int iIndex = 0; iIndex < arrListaItems.Length; iIndex++) 
            {
                arrListaItems[iIndex] = ""; 
            }
        }
        //******************************************** CODIGO HECHO POR SEBASTIAN LETONA ***************************** 

        //******************************************** CODIGO HECHO POR JORGE AVILA***************************** 
        void CreaComponentes()
        {
            // Obtiene los campos, tipos de datos y llaves de la sTablaPrincipal
            string[] sCampos = logic.Campos(sTablaPrincipal);
            string[] sTipos = logic.Tipos(sTablaPrincipal);
            string[] sLlaves = logic.Llaves(sTablaPrincipal);
            int iIndex = 0;
            int iFin = sCampos.Length;
            int iNumeroCampos = 1; // Contador de campos

            // Variables para gestionar la posición
            int columnaActual = 0; // Contador de columna
            int maxFilasPorColumna = 3; // Número máximo de filas antes de cambiar de columna
            int posX = 50; // Posición inicial en X
            int posY = 150; // Posición inicial en Y
            int desplazamientoY = 60; // Espacio vertical entre controles

            while (iIndex < iFin)
            {
                // Calcular la posición en la que se colocará el Label y el control asociado
                int currentPosY = posY + ((iNumeroCampos - 1) % maxFilasPorColumna) * desplazamientoY;

                // Si alcanzamos el máximo de filas por columna, movemos a la siguiente columna
                if (iNumeroCampos > 1 && (iNumeroCampos - 1) % maxFilasPorColumna == 0)
                {
                    columnaActual++;
                    posX += 200; // Desplazamiento horizontal para la siguiente columna
                }

                // Crea un Label para cada campo
                Label lb = new Label();
                lb.Text = arrAliasCampos[iIndex];
                lb.Location = new Point(posX, currentPosY);
                lb.Name = "lb_" + sCampos[iIndex];
                lb.Font = new Font(fFuenteLabels.FontFamily, fFuenteLabels.Size * 1.3f, FontStyle.Bold | fFuenteLabels.Style);
                lb.ForeColor = cColorFuente;
                lb.AutoSize = true;
                this.Controls.Add(lb);

                // Dependiendo del tipo de campo, crea el componente adecuado
                string nombreComponente = sCampos[iIndex];
                Point controlPosition = new Point(posX, currentPosY + lb.Height + 5); // Posición del control debajo del Label

                switch (sTipos[iIndex])
                {
                    case "int":
                        arrTipoCampos[iIndex] = "Num";
                        if (sLlaves[iIndex] != "MUL")
                        {
                            CrearTextBoxNumerico(nombreComponente, controlPosition);
                        }
                        else
                        {
                            string tablaRelacionada = logic.DetectarTablaRelacionada(sTablaPrincipal, sCampos[iIndex]);
                            string campoClave = logic.DetectarClaveRelacionada(sTablaPrincipal, sCampos[iIndex]);

                            dicItems = logic.Items(tablaRelacionada, campoClave, campoClave);

                            CrearComboBox(nombreComponente, controlPosition);
                        }
                        break;

                    case "varchar":
                    case "text":
                        arrTipoCampos[iIndex] = "Text";
                        if (sLlaves[iIndex] != "MUL")
                        {
                            CrearTextBoxVarchar(nombreComponente, controlPosition);
                        }
                        else
                        {
                            string tablaRelacionada = logic.DetectarTablaRelacionada(sTablaPrincipal, sCampos[iIndex]);
                            string campoClave = logic.DetectarClaveRelacionada(sTablaPrincipal, sCampos[iIndex]);

                            dicItems = logic.Items(tablaRelacionada, campoClave, campoClave);

                            CrearComboBox(nombreComponente, controlPosition);
                        }
                        break;

                    case "date":
                    case "datetime":
                        arrTipoCampos[iIndex] = "Date";
                        if (sLlaves[iIndex] != "MUL")
                        {
                            CrearDateTimePicker(nombreComponente, controlPosition);
                        }
                        else
                        {
                            string tablaRelacionada = logic.DetectarTablaRelacionada(sTablaPrincipal, sCampos[iIndex]);
                            string campoClave = logic.DetectarClaveRelacionada(sTablaPrincipal, sCampos[iIndex]);

                            dicItems = logic.Items(tablaRelacionada, campoClave, campoClave);

                            CrearComboBox(nombreComponente, controlPosition);
                        }
                        break;

                    case "time":
                        arrTipoCampos[iIndex] = "Time";
                        CrearCampoHora(nombreComponente, controlPosition);
                        break;

                    case "float":
                    case "decimal":
                    case "double":
                        arrTipoCampos[iIndex] = "Decimal";
                        CrearCampoDecimales(nombreComponente, controlPosition);
                        break;

                    case "tinyint":
                        arrTipoCampos[iIndex] = "Bool";
                        if (sLlaves[iIndex] != "MUL")
                        {
                            CrearBotonEstado(nombreComponente, controlPosition);
                        }
                        else
                        {
                            // Si es clave foránea, podrías manejarlo aquí si es necesario
                        }
                        break;

                    default:
                        if (!string.IsNullOrEmpty(sTipos[iIndex]))
                        {
                            MessageBox.Show($"La tabla {sTablaPrincipal} posee un campo {sTipos[iIndex]}, este tipo de dato no es reconocido por el navegador.", "Verificación de requisitos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                }

                iNumeroCampos++;
                iIndex++;
            }
        }


        void CrearTextBoxVarchar(String sNom, Point location)
        {
            TextBox tb = new TextBox();
            tb.Width = (int)(tb.Width * 1.2);
            tb.Height = (int)(tb.Height * 1.2);
            tb.Location = location;
            tb.Name = sNom;
            this.Controls.Add(tb);
            tb.KeyPress += ParaValidarVarchar_KeyPress; // Función para validar entrada de texto
        }
        void CrearComboBox(String sNom, Point location)
        {
            // Se obtienen los elementos para el ComboBox
            if (arrTablaCombo[iNumeroCombosAux] != null)
            {
                dicItems = logic.Items(arrTablaCombo[iNumeroCombosAux], arrCampoCombo[iNumeroCombosAux], arrCampoDisplayCombo[iNumeroCombosAux]);
            }
            if (iNumeroCombos > iNumeroCombosAux) { iNumeroCombosAux++; }

            ComboBox cb = new ComboBox(); // Crea un nuevo ComboBox
            cb.Width = (int)(cb.Width * 1.2);
            cb.Height = (int)(cb.Height * 1.2);
            cb.Location = location; // Establece la ubicación del ComboBox
            cb.Name = sNom; // Establece el nombre del ComboBox

            // Enlaza los datos al ComboBox
            BindingSource bs = new BindingSource();
            bs.DataSource = dicItems;
            cb.DataSource = bs;
            cb.DisplayMember = "Value"; // Muestra el valor en el ComboBox
            cb.ValueMember = "Key";     // Almacena la clave seleccionada

            this.Controls.Add(cb); // Añade el ComboBox al formulario
                                   // iPosicionInicial++; // Ya no es necesario incrementar iPosicionInicial aquí
        }

        //******************************************** CODIGO HECHO POR JORGE AVILA***************************** 

        //******************************************** CODIGO HECHO POR DIEGO MARROQUIN*****************************

        // Función que maneja el evento click de los botones, cambiando su estado entre "Activado" y "Desactivado"
        void Func_click(object sender, EventArgs e)
        {
            // Convertir el sender a un Button
            Button btn = sender as Button;

            // Verifica si la conversión fue exitosa
            if (btn != null)
            {
                // Cambia el estado del botón en función de su estado actual
                if (btn.Text == "Activado")
                {
                    btn.Text = "Desactivado";
                    btn.BackColor = Color.Red;
                    iEstadoFormulario = 0;
                }
                else
                {
                    btn.Text = "Activado";
                    btn.BackColor = Color.Green;
                    iEstadoFormulario = 1;
                }
            }
        }
        //******************************************** CODIGO HECHO POR DIEGO MARROQUIN*****************************

        //******************************************** CODIGO HECHO POR PABLO FLORES*****************************

        // Función que crea un botón con un estado inicial de "Activado" y lo añade al formulario
        void CrearBotonEstado(String sNom, Point location)
        {
            Button btn = new Button(); // Crea un nuevo botón
            btn.Width = (int)(btn.Width * 1.2);
            btn.Height = (int)(btn.Height * 1.2);
            btn.Location = location; // Establece la ubicación del botón
            btn.Text = "Activado"; // Establece el texto inicial del botón
            btn.BackColor = Color.Green; // Establece el color de fondo inicial
            btn.Click += new EventHandler(Func_click); // Asigna la función de clic al botón
            btn.Name = sNom; // Establece el nombre del botón
            btn.Enabled = false; // Deshabilita el botón inicialmente
            btn.AutoSize = true;
            this.Controls.Add(btn); // Añade el botón al formulario
                                    // iPosicionInicial++; // Ya no es necesario incrementar iPosicionInicial aquí
        }
        // Función que crea un TextBox para números y lo añade al formulario
        void CrearTextBoxNumerico(String sNom)
        {
            TextBox tb = new TextBox();
            tb.Width = (int)(tb.Width * 1.2);
            tb.Height = (int)(tb.Height * 1.2); // Crea un nuevo TextBox
            Point p = new Point(iPosicionX + 125 + iPosicionInicial, iPosicionY * iPosicionInicial);
            tb.Location = p;
            tb.Name = sNom; // Establece el nombre del TextBox
            this.Controls.Add(tb); // Añade el TextBox al formulario
            tb.KeyPress += ParaValidarNumeros_KeyPress; // Asigna la función de validación de números al evento KeyPress
            this.KeyPress += ParaValidarNumeros_KeyPress; // Asegura que el evento KeyPress valide solo números
            iPosicionInicial++;
        }
        //******************************************** CODIGO HECHO POR PABLO FLORES*****************************

        //******************************************** CODIGO HECHO POR EMANUEL BARAHONA*****************************

        // Función que crea un TextBox para texto de tipo varchar y lo añade al formulario
        void CrearTextBoxVarchar(String sNom)
        {
            TextBox tb = new TextBox(); // Crea un nuevo TextBox
            tb.Width = (int)(tb.Width * 1.2);
            tb.Height = (int)(tb.Height * 1.2);
            Point p = new Point(iPosicionX + 125 + iPosicionInicial, iPosicionY * iPosicionInicial);
            tb.Location = p;
            tb.Name = sNom; // Establece el nombre del TextBox
            this.Controls.Add(tb); // Añade el TextBox al formulario
            tb.KeyPress += ParaValidarVarchar_KeyPress; // Asigna la función de validación varchar al evento KeyPress
            this.KeyPress += ParaValidarVarchar_KeyPress; // Asegura que el evento KeyPress valide solo varchar
            iPosicionInicial++;
        }


        // Función que crea un TextBox para la hora y lo añade al formulario
        void CrearCampoHora(String sNom, Point location)
        {
            TextBox tb = new TextBox(); // Crea un nuevo TextBox
            tb.Width = (int)(tb.Width * 1.2);
            tb.Height = (int)(tb.Height * 1.2);
            tb.Location = location; // Establece la ubicación del TextBox
            tb.Name = sNom; // Establece el nombre del TextBox
            this.Controls.Add(tb); // Añade el TextBox al formulario
            tb.KeyPress += ParaValidarHora_KeyPress; // Asigna la función de validación de hora al evento KeyPress
                                                     // iPosicionInicial++; // Ya no es necesario incrementar iPosicionInicial aquí
        }

        // Función que crea un TextBox para decimales y lo añade al formulario
        void CrearCampoDecimales(String sNom, Point location)
        {
            TextBox tb = new TextBox(); // Crea un nuevo TextBox
            tb.Width = (int)(tb.Width * 1.2);
            tb.Height = (int)(tb.Height * 1.2);
            tb.Location = location; // Establece la ubicación del TextBox
            tb.Name = sNom; // Establece el nombre del TextBox
            this.Controls.Add(tb); // Añade el TextBox al formulario
            tb.KeyPress += ParaValidarDecimales_KeyPress; // Asigna la función de validación de decimales al evento KeyPress
                                                          // iPosicionInicial++; // Ya no es necesario incrementar iPosicionInicial aquí
        }
        //******************************************** CODIGO HECHO POR EMANUEL BARAHONA*****************************

        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS*****************************

        // Estos métodos manejan eventos KeyPress para validar diferentes tipos de entradas en los controles.

        private void ParaValidarDecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida que el input sea un número decimal.
            v.Camposdecimales(e);
        }

        private void ParaValidarNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida que el input sea un número entero.
            v.CamposNumericos(e);
        }

        private void ParaValidarHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida que el input siga el formato de hora.
            v.CamposHora(e);
        }

        private void ParaValidarVarchar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida que el input sea un texto tipo varchar.
            v.CamposVchar(e);
        }

        private void ParaValidarTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida que el input contenga solo letras.
            v.CamposLetras(e);
        }

        private void ParaValidarCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Maneja la validación del input en un ComboBox.
            v.Combobox(e);
        }

        // Este método crea y configura un ComboBox dinámicamente basado en los parámetros y la lógica del sistema.
        void CrearComboBox(String sNom)
        {
            // Se obtienen los elementos para el ComboBox, que son una lista de pares clave-valor.
            // Si hay una sTablaPrincipal y campo específicos para el ComboBox, se utilizan.
            if (arrTablaCombo[iNumeroCombosAux] != null)
            {
                dicItems = logic.Items(arrTablaCombo[iNumeroCombosAux], arrCampoCombo[iNumeroCombosAux], arrCampoDisplayCombo[iNumeroCombosAux]);
            }
            if (iNumeroCombos > iNumeroCombosAux) { iNumeroCombosAux++; }

            // Se crea un nuevo ComboBox.
            ComboBox cb = new ComboBox();
            cb.Width = (int)(cb.Width * 1.2);
            cb.Height = (int)(cb.Height * 1.2);
            // Se define la ubicación del ComboBox en el formulario.
            Point p = new Point(iPosicionX + 125 + iPosicionInicial, iPosicionY * iPosicionInicial); 
            cb.Location = p;
            cb.Name = sNom;  // Se asigna el nombre al ComboBox.

            // Se utiliza un BindingSource para enlazar los elementos al ComboBox.
            BindingSource bs = new BindingSource();
            bs.DataSource = dicItems;

            // Se asigna el DataSource al ComboBox, mostrando el nombre y guardando la clave.
            cb.DataSource = bs;
            cb.DisplayMember = "Value";  // Muestra el nombre en el ComboBox.
            cb.ValueMember = "Key";      // Almacena el ID seleccionado.

            // Se añade el ComboBox al formulario.
            this.Controls.Add(cb);
            iPosicionInicial++; 
        }

        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS*****************************

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ***************************** 
        void CrearDateTimePicker(String sNom, Point location)
        {
            DateTimePicker dtp = new DateTimePicker(); // Crea un nuevo DateTimePicker
            dtp.Width = (int)(dtp.Width * 1.2);
            dtp.Height = (int)(dtp.Height * 1.2);
            dtp.Location = location; // Establece la ubicación del DateTimePicker
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "yyyy-MM-dd";
            dtp.Width = 100;
            dtp.Name = sNom; // Establece el nombre del DateTimePicker
            this.Controls.Add(dtp); // Añade el DateTimePicker al formulario
                                    // iPosicionInicial++; // Ya no es necesario incrementar iPosicionInicial aquí
        }

        public void Deshabilitarcampos_y_botones()
        {
            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox || componente is Button)
                {
                    componente.Enabled = false; // De esta manera bloqueamos todos los TextBox, DateTimePicker y ComboBox
                }
            }
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Btn_Guardar.Enabled = false;
            Btn_Cancelar.Enabled = false;
        }

        public void HabilitarCampos_y_Botones()
        {
            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox || componente is Button)
                {
                    componente.Enabled = true; // Habilita todos los TextBox, DateTimePicker y ComboBox para edición
                }
            }
            // Btn_Modificar.Enabled = true;
           Btn_Eliminar.Enabled = true;
           Btn_Guardar.Enabled = true;
           Btn_Cancelar.Enabled = true;
        }

        public void ActualizarDataGridView()
        {
            // Pasar todas las relaciones foráneas a la capa lógica
            DataTable dt = logic.ConsultaLogica(sTablaPrincipal, relacionesForaneas);
            Dgv_Informacion.DataSource = dt;

            // Asignar los alias como encabezados de las columnas
            int iHead = 0;
            while (iHead < logic.ContarCampos(sTablaPrincipal))
            {
                Dgv_Informacion.Columns[iHead].HeaderText = arrAliasCampos[iHead];
                iHead++;
            }
        }

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ***************************** 


        //******************************************** CODIGO HECHO POR MATY MANCILLA*****************************

        // Este método genera una consulta SQL para "eliminar" un registro de la base de datos.
        // En lugar de eliminar físicamente el registro, se actualiza el campo 'estado' a 0, lo que indica que está inactivo.
        string CrearDelete(string sNombreTabla, bool esTablaAdicional)
        {
            // Inicia la construcción de la consulta SQL con la instrucción UPDATE para la tabla especificada.
            string sQuery = "UPDATE " + sNombreTabla + " SET estado=0";

            // Esta variable construye la cláusula WHERE de la consulta SQL.
            string sWhereQuery = " WHERE ";
            bool claveAsignada = false;

            // Verifica si es la tabla principal (no es una tabla adicional)
            if (!esTablaAdicional)
            {
                foreach (Control componente in Controls)
                {
                    // Considera TextBox, DateTimePicker y ComboBox
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        // Si el componente tiene un nombre que sugiere que es la clave primaria
                        if (componente.Name.Contains("Pk") && !string.IsNullOrEmpty(componente.Text))
                        {
                            // Construye la cláusula WHERE usando el nombre del componente como campo y su valor como condición
                            sWhereQuery += componente.Name + " = '" + componente.Text + "' ";
                            claveAsignada = true;
                            Console.WriteLine($"Clave primaria detectada: {componente.Name} = {componente.Text}");
                            break; // Ya que solo necesitamos una clave primaria, salimos del bucle
                        }
                    }
                }
            }

            // Si no se asignó ninguna clave, evita crear la consulta
            if (!claveAsignada)
            {
                Console.WriteLine($"Advertencia: No se pudo asignar una clave principal para la tabla {sNombreTabla}.");
                return null;
            }

            // Elimina posibles espacios y comas al final de las cadenas.
            sWhereQuery = sWhereQuery.TrimEnd(' ');

            // Completar la construcción de la consulta SQL uniendo la cláusula WHERE.
            sQuery += sWhereQuery + ";";

            // Imprimir la consulta en la consola para depuración.
            Console.WriteLine($"Consulta generada para la tabla principal {sNombreTabla}: {sQuery}");

            // Retornar la consulta construida.
            return sQuery;
        }

        string CrearDeleteExtras(string sNombreTabla)
        {
            // Inicia la construcción de la consulta SQL con la instrucción UPDATE para la tabla especificada.
            string sQuery = "UPDATE " + sNombreTabla + " SET estado=0";

            // Esta variable construye la cláusula WHERE de la consulta SQL.
            string sWhereQuery = " WHERE ";
            bool claveAsignada = false;

            // Verificar si hay alias definidos para esta tabla
            if (aliasPorTabla.ContainsKey(sNombreTabla))
            {
                string[] alias = aliasPorTabla[sNombreTabla];

                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        string nombreCampo = componente.Name.Replace("extra_", "");

                        // Depuración para ver si estamos encontrando el campo
                        Console.WriteLine($"Buscando campo: {nombreCampo}");

                        if (alias.Contains(nombreCampo))
                        {
                            Console.WriteLine($"Campo encontrado: {nombreCampo}, valor: {componente.Text}");

                            // Añadir la condición al WHERE con un AND si ya hay otras condiciones
                            if (claveAsignada)
                            {
                                sWhereQuery += " AND ";
                            }
                            sWhereQuery += nombreCampo + " = '" + componente.Text + "' ";
                            claveAsignada = true;
                        }
                    }
                }
            }

            // Si no se asignó ninguna clave, evitar crear la consulta
            if (!claveAsignada)
            {
                Console.WriteLine($"Advertencia: No se pudo asignar una clave principal o clave foránea para la tabla {sNombreTabla}.");
                return null;
            }

            // Completar la construcción de la consulta SQL uniendo la cláusula WHERE.
            sQuery += sWhereQuery + ";";

            // Imprimir la consulta en la consola para depuración.
            Console.WriteLine($"Consulta generada para tabla adicional {sNombreTabla}: {sQuery}");

            // Retornar la consulta construida.
            return sQuery;
        }

        //******************************************** CODIGO HECHO POR MATY MANCILLA*****************************

        //******************************************** CODIGO HECHO POR JOEL LOPEZ***************************** 
        string CrearInsert(string sNombreTabla)
        {
            // Inicializa las cadenas para la consulta INSERT y los valores a insertar
            string sQuery = "INSERT INTO " + sNombreTabla + " (";
            string sValores = "VALUES (";

            string sCampos = "";
            string sValoresCampos = "";

            // Obtén la lista de campos de la tabla desde la lógica
            string[] arrCamposTabla = logic.Campos(sNombreTabla);
            int iPosicionCampo = 0;

            // Recorre todos los controles del formulario
            foreach (Control componente in Controls)
            {
                // Ignora los componentes que tienen el prefijo "extra_"
                if (componente.Name.StartsWith("extra_"))
                {
                    continue; // Saltar al siguiente control
                }

                // Solo procesar si es un componente relevante: TextBox, DateTimePicker, ComboBox o Button
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox || componente is Button)
                {
                    // Obtén el nombre del campo que se supone que coincide con la tabla
                    if (iPosicionCampo < arrCamposTabla.Length)
                    {
                        string sNombreCampo = arrCamposTabla[iPosicionCampo];
                        string sValorCampo = string.Empty;

                        // Si el control es un ComboBox, obtiene el valor seleccionado (ID)
                        if (componente is ComboBox cb)
                        {
                            sValorCampo = cb.SelectedValue?.ToString() ?? ""; // Asegúrate de que no sea nulo
                        }
                        else if (componente is Button btn)
                        {
                            // Si el botón define el estado, asigna '0' o '1' según el texto del botón
                            sValorCampo = (btn.Text == "Activado") ? "1" : "0";
                        }
                        else if (componente is DateTimePicker dtp)
                        {
                            sValorCampo = dtp.Value.ToString("yyyy-MM-dd");
                        }
                        else if (componente is TextBox)
                        {
                            sValorCampo = componente.Text;
                        }

                        // Solo agrega el campo y el valor si no está vacío
                        if (!string.IsNullOrEmpty(sValorCampo))
                        {
                            sCampos += sNombreCampo + ", ";
                            sValoresCampos += "'" + sValorCampo + "', ";
                        }

                        iPosicionCampo++;
                    }
                }
            }
            sCampos = sCampos.TrimEnd(' ', ',');
            sValoresCampos = sValoresCampos.TrimEnd(' ', ',');

            // Verifica si el número de columnas y valores coinciden antes de construir la consulta
            if (sCampos.Split(',').Length != sValoresCampos.Split(',').Length)
            {
                Console.WriteLine("Error: El número de columnas no coincide con el número de valores.");
                return null; // Retorna nulo para indicar que hay un error en la construcción
            }

            sQuery += sCampos + ") " + sValores + sValoresCampos + ");";

            return sQuery;
        }
        //******************************************** CODIGO HECHO POR JOEL LOPEZ***************************** 

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ***************************** 
        private IEnumerable<Control> GetAllControls(Control container)
        {
            // Función recursiva para obtener todos los controles, incluyendo los anidados
            foreach (Control control in container.Controls)
            {
                foreach (Control child in GetAllControls(control))
                {
                    yield return child;
                }
                yield return control;
            }
        }


        string CrearUpdate(string sTablaPrincipal, string sNombreClavePrimaria)
        {
            string[] arrColumnasTabla = logic.Campos(sTablaPrincipal);
            string sQuery = "UPDATE " + sTablaPrincipal + " SET ";
            string sWhereQuery = " WHERE ";
            string sCampos = "";
            int valor = 0;

            // Utiliza la nueva función para obtener solo los controles relevantes
            foreach (Control componente in GetRelevantControls(this))
            {
                if (componente.Name.StartsWith("extra_"))
                {
                    continue; // Ignora los componentes que tienen el prefijo "extra_"
                }

                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox || componente is Button)
                {
                    string sNombreCampo = componente.Name;
                    if (arrColumnasTabla.Contains(sNombreCampo) && sNombreCampo != sNombreClavePrimaria)
                    {
                        string sValorCampo = ObtenerValorDelComponente(componente, ref valor);
                        if (!string.IsNullOrEmpty(sValorCampo))
                        {
                            sCampos += $"{sNombreCampo} = '{sValorCampo}', ";
                        }
                    }
                }
            }

            if (string.IsNullOrEmpty(sCampos))
            {
                Console.WriteLine($"No hay campos para actualizar en la tabla {sTablaPrincipal}");
                return null;
            }

            sCampos = sCampos.TrimEnd(' ', ',');
            string sValorClave = Dgv_Informacion.CurrentRow.Cells[0].Value.ToString();
            sWhereQuery += $"{sNombreClavePrimaria} = '{sValorClave}'";
            sQuery += sCampos + sWhereQuery + ";";
            Console.WriteLine("Consulta generada para el UPDATE: " + sQuery);

            return sQuery;
        }

        private string ObtenerValorDelComponente(Control componente, ref int valor)
        {
            string sValorCampo = "";
            if (componente is ComboBox cb)
            {
                Console.WriteLine($"Procesando ComboBox: {componente.Name}, Valor actual: {valor}, Tamaño de comboData: {comboData.Count}");
                if (valor < comboData.Count) // Verificar que el índice esté dentro del rango
                {
                    var comboInfo = comboData[valor];
                    string sTabla = comboInfo.Item1;
                    string sCampoClave = comboInfo.Item2;
                    string sCampoDisplay = comboInfo.Item3;
                    sValorCampo = logic.ObtenerValorClaveDesdeLogica(sTabla, sCampoClave, sCampoDisplay, cb.Text);
                    valor++;
                }
                else
                {
                    Console.WriteLine($"Índice fuera de rango: {valor} en comboData para la tabla relacionada.");
                }
            }
            else if (componente is DateTimePicker dtp)
            {
                sValorCampo = dtp.Value.ToString("yyyy-MM-dd");
            }
            else if (componente is TextBox)
            {
                sValorCampo = componente.Text;
            }
            else if (componente is Button btn)
            {
                sValorCampo = (btn.Text == "Activado") ? "1" : "0";
            }

            return sValorCampo;
        }


        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ***************************** 

        //******************************************** CODIGO HECHO POR PABLO FLORES***************************** 
        public void GuardadoForsozo()
        {
            // Ejecuta la consulta de inserción generada y limpia los campos del formulario
            logic.NuevoQuery(CrearInsert(sTablaPrincipal)); 
            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    componente.Enabled = true;
                    componente.Text = "";
                }
            }
            ActualizarDataGridView();
        }

        public void HabilitarTodosBotones() // Habilita todos los botones
        {
            Btn_Guardar.Enabled = true;
            Btn_Ingresar.Enabled = true;
            Btn_Modificar.Enabled = true;
            Btn_Cancelar.Enabled = false;
            Btn_Eliminar.Enabled = true;
        }

        private IEnumerable<Control> GetRelevantControls(Control container)
        {
            // Función recursiva para obtener solo los controles relevantes (TextBox, ComboBox, DateTimePicker, y Button) que estén relacionados con las tablas.
            foreach (Control control in container.Controls)
            {
                // Filtra solo los controles relevantes que utilizas en tus formularios
                if (control is TextBox || control is ComboBox || control is DateTimePicker || control is Button)
                {
                    // Verifica que el control tenga un prefijo relevante (por ejemplo, 'extra_' para tablas adicionales o sin prefijo para la tabla principal)
                    if (control.Name.StartsWith("extra_") || IsControlForPrincipalTable(control))
                    {
                        yield return control;
                    }
                }

                // Llamada recursiva para los controles hijos
                foreach (Control child in GetRelevantControls(control))
                {
                    yield return child;
                }
            }
        }

        private bool IsControlForPrincipalTable(Control control)
        {
            return !control.Name.StartsWith("extra_");
        }
        //******************************************** CODIGO HECHO POR PABLO FLORES***************************** 

        //-----------------------------------------------Funcionalidad de Botones-----------------------------------------------//

        //******************************************** CODIGO HECHO POR DIEGO MARROQUIN***************************** 
        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            string[] arrTipos = logic.Tipos(sTablaPrincipal);
            string[] arrLlaves = logic.Llaves(sTablaPrincipal); // Llaves de la tabla principal
            bool bTipoInt = false;
            string sAuxId = "";
            int iAuxLastId = 0;

            // Verifica si el primer campo de la tabla principal es de tipo entero y autoincremental
            if (arrTipos[0] == "int" && arrLlaves[0] == "PRI")
            {
                bTipoInt = true;
                sAuxId = logic.UltimoID(sTablaPrincipal);
                iAuxLastId = !string.IsNullOrEmpty(sAuxId) ? Int32.Parse(sAuxId) : 0;
            }

            iActivar = 2; // Define que se realizará una inserción
            HabilitarCampos_y_Botones();

            foreach (Control componente in Controls)
            {
                string nombreComponente = componente.Name.Replace("extra_", ""); // Elimina el prefijo "extra_" si existe

                // Verifica si es el campo autoincremental en la tabla principal
                if (componente is TextBox && bTipoInt && nombreComponente == arrLlaves[0])
                {
                    iAuxLastId += 1;
                    componente.Text = iAuxLastId.ToString();
                    componente.Enabled = false; // Bloquea el campo autoincremental
                }

                else if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    componente.Enabled = true;
                    componente.Text = "";
                }
            }

            Btn_Ingresar.Enabled = false;
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Btn_Cancelar.Enabled = true;

           // BotonesYPermisosSinMensaje(); // Actualiza los permisos de los botones
        }

        //******************************************** CODIGO HECHO POR DIEGO MARROQUIN***************************** 

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Muestra un mensaje de confirmación antes de proceder con la modificación
                DialogResult drResult = MessageBox.Show(
                    "Está a punto de modificar un registro existente.\n\n" +
                    "Asegúrese de que todos los datos sean correctos antes de continuar.\n\n" +
                    "¿Desea proceder con la modificación de este registro?",
                    "Confirmación de Modificación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2
                );

                // Si el usuario selecciona "No", se cancela la operación
                if (drResult == DialogResult.No)
                {
                    return;
                }

                // Habilita campos para edición
                HabilitarCampos_y_Botones();
                Btn_Modificar.Enabled = false;
                iActivar = 1; // Define que se realizará una modificación
                int iIndice = 0;

                string[] arrTipos = logic.Tipos(sTablaPrincipal);
                int iNumCombo = 0;

                // Verifica que la fila seleccionada en el DataGridView no sea null
                if (Dgv_Informacion.CurrentRow == null)
                {
                    MessageBox.Show("No hay ninguna fila seleccionada en el DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Recorre los controles para habilitar la edición
                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        // Verifica que iIndice esté dentro del rango antes de acceder a la celda
                        if (iIndice < Dgv_Informacion.CurrentRow.Cells.Count)
                        {
                            // Deshabilita el campo del ID si es entero (autoincremental)
                            if (iIndice == 0 && arrTipos[0] == "int")
                            {
                                componente.Enabled = false;
                            }
                            else
                            {
                                if (componente is ComboBox comboBox)
                                {
                                    if (arrModoCampoCombo[iNumCombo] == 1)
                                    {
                                        string valorLlave = logic.LlaveCampoRev(arrTablaCombo[iNumCombo], arrCampoCombo[iNumCombo], Dgv_Informacion.CurrentRow.Cells[iIndice].Value.ToString());

                                        // Verifica que el valor asignado no sea vacío o nulo
                                        if (!string.IsNullOrEmpty(valorLlave))
                                        {
                                            comboBox.Text = valorLlave;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Valor vacío o nulo en la celda {iIndice} para el ComboBox.");
                                        }
                                    }
                                    else
                                    {
                                        // Asigna el valor directamente si no requiere revisión con `LlaveCampoRev`
                                        comboBox.Text = Dgv_Informacion.CurrentRow.Cells[iIndice].Value.ToString();
                                    }

                                    iNumCombo++; // Incrementa el contador de ComboBox
                                }
                                else
                                {
                                    // Asigna el texto para los demás controles (TextBox, DateTimePicker, etc.)
                                    componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndice].Value.ToString();
                                }
                            }

                            iIndice++; // Incrementa el índice solo si se ha accedido a una celda válida
                        }
                        else
                        {
                            Console.WriteLine($"El índice {iIndice} está fuera del rango de las celdas disponibles en el DataGridView.");
                            break; // Sale del bucle si el índice está fuera de rango
                        }
                    }

                    if (componente is Button)
                    {
                        // No incrementar iIndice para los botones, ya que no están vinculados a una celda
                        if (iIndice < Dgv_Informacion.CurrentRow.Cells.Count)
                        {
                            string sEstadoRegistro = Dgv_Informacion.CurrentRow.Cells[iIndice].Value.ToString();

                            if (sEstadoRegistro == "0")
                            {
                                componente.Text = "Desactivado";
                                componente.BackColor = Color.Red;
                                iEstadoFormulario = 0;
                            }
                            else if (sEstadoRegistro == "1")
                            {
                                componente.Text = "Activado";
                                componente.BackColor = Color.Green;
                                iEstadoFormulario = 1;
                            }

                            componente.Enabled = true;

                            // Solo incrementar el índice si el botón está vinculado a una celda (en caso de que esté)
                            iIndice++;
                        }
                        else
                        {
                            Console.WriteLine($"El índice {iIndice} está fuera del rango al configurar el botón.");
                            break; // Sale del bucle si el índice está fuera de rango
                        }
                    }
                }

                // Habilita y deshabilita botones según el usuario
               BotonesYPermisosSinMensaje();

                Btn_Ingresar.Enabled = false;
                Btn_Eliminar.Enabled = false;
                Btn_Cancelar.Enabled = true;
            }
            catch (Exception ex)
            {
                // Manejo de errores y muestra un mensaje más profesional
                MessageBox.Show(
                    "Ocurrió un error durante la modificación del registro.\n\n" +
                    "Detalles del error: " + ex.Message + "\n\n" +
                    "Por favor, intente nuevamente o contacte al administrador del sistema.",
                    "Error en la Modificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }


        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ*****************************


        //******************************************** CODIGO HECHO POR JORGE AVILA***************************** 
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                lg.funinsertarabitacora(sIdUsuario, "Se presionó el botón cancelar en " + sTablaPrincipal, sTablaPrincipal, sIdAplicacion); 
                                                                                                                                        
                DialogResult drResult = MessageBox.Show(
                    "Está a punto de cancelar los cambios no guardados.\n\n" +
                    "Cualquier dato ingresado se perderá.\n\n" +
                    "¿Desea realmente cancelar la operación?",
                    "Confirmación de Cancelación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, // Icono de advertencia
                    MessageBoxDefaultButton.Button2 // Opción "No" predeterminada
                );

                // Si el usuario selecciona "No", se cancela la operación de cancelación
                if (drResult == DialogResult.No)
                {
                    return;
                }

                // Reestablecer botones y deshabilitar el que no se necesita
                //Btn_Modificar.Enabled = true;
                Btn_Guardar.Enabled = false;
                Btn_Cancelar.Enabled = false;
                Btn_Ingresar.Enabled = true;
                Btn_Eliminar.Enabled = true;
                Btn_Refrescar.Enabled = true;
                Deshabilitarcampos_y_botones();
                // Actualizar el DataGridView y los controles a su estado original
                ActualizarDataGridView();
                if (logic.TestRegistros(sTablaPrincipal) > 0) 
                {
                    int iIndice = 0; 
                    int iNumCombo = 0; 
                    foreach (Control componente in Controls)
                    {
                        if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                        {
                            if (componente is ComboBox)
                            {
                                if (arrModoCampoCombo[iNumCombo] == 1)
                                {
                                    componente.Text = logic.LlaveCampoRev(arrTablaCombo[iNumCombo], arrCampoCombo[iNumCombo], Dgv_Informacion.CurrentRow.Cells[iIndice].Value.ToString()); 
                                }
                                else
                                {
                                    componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndice].Value.ToString(); 
                                }
                                iNumCombo++;
                            }
                            else
                            {
                                componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndice].Value.ToString(); 
                            }
                            componente.Enabled = false;
                            iIndice++;
                        }
                        if (componente is Button)
                        {
                            string sEstadoRegistro = Dgv_Informacion.CurrentRow.Cells[iIndice].Value.ToString(); 
                            if (sEstadoRegistro == "0") 
                            {
                                componente.Text = "Desactivado";
                                componente.BackColor = Color.Red;
                            }
                            if (sEstadoRegistro == "1") 
                            {
                                componente.Text = "Activado";
                                componente.BackColor = Color.Green;
                            }
                            componente.Enabled = false;
                        }
                    }
                }

                // Habilitar/deshabilitar según los permisos del usuario
                
            }
            catch (Exception ex)
            {
                // Manejo de errores con un mensaje más profesional
                MessageBox.Show(
                    "Ocurrió un error durante el proceso de cancelación.\n\n" +
                    "Detalles del error: " + ex.Message + "\n\n" +
                    "Por favor, intente nuevamente o contacte al administrador del sistema.",
                    "Error en Cancelación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error // Icono de error
                );
            }
        }
        //******************************************** CODIGO HECHO POR JORGE AVILA ***************************** 

        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS***************************** 
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostrar un mensaje de confirmación antes de proceder con la eliminación
                DialogResult drRespuestaEliminar = MessageBox.Show(
                    "Está a punto de eliminar (desactivar) este registro y sus datos relacionados en todas las tablas.\n\n" +
                    "¿Está seguro de que desea continuar?",
                    "Confirmación de Eliminación - " + sNombreFormulario,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2 // Opción "No" predeterminada
                );

                if (drRespuestaEliminar == DialogResult.Yes)
                {
                    // Eliminar el registro en la tabla principal
                    string sQueryPrincipal = CrearDelete(sTablaPrincipal, false);
                    logic.NuevoQuery(sQueryPrincipal);
                    string sLlavePrimaria = logic.ObtenerClavePrimaria(sTablaPrincipal);
                    // Iterar sobre las tablas adicionales y cambiar el estado en cada una
                  

                    // Actualizar el DataGridView y mostrar un mensaje de éxito
                    ActualizarDataGridView();
                    MessageBox.Show(
                        "El registro y sus datos relacionados han sido eliminados correctamente en todas las tablas.",
                        "Eliminación Exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // Restablecer el estado de los botones
                    Deshabilitarcampos_y_botones();
                    lg.funinsertarabitacora(sIdUsuario, "Se actualizó el estado en " + sTablaPrincipal, sTablaPrincipal, sIdAplicacion);
                }
                else if (drRespuestaEliminar == DialogResult.No)
                {
                    // Si el usuario cancela la operación de eliminación
                    MessageBox.Show(
                        "La eliminación ha sido cancelada.",
                        "Operación Cancelada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // Mantener el estado de los botones
                    Deshabilitarcampos_y_botones();
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores con un mensaje más profesional
                MessageBox.Show(
                    "Ocurrió un error durante el proceso de eliminación del registro.\n\n" +
                    "Detalles del error: " + ex.Message + "\n\n" +
                    "Por favor, intente nuevamente o contacte al administrador del sistema.",
                    "Error en la Eliminación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS***************************** 


        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS***************************** 
        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {
            try
            {
                // Refrescar la DataGridView y actualizar los controles
                ActualizarDataGridView();

                // Iterar sobre los controles y actualizar sus valores con los datos del DataGridView
                int iIndex = 0;
                int iNumCombo = 0;
                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        if (componente is ComboBox)
                        {
                            if (arrModoCampoCombo[iNumCombo] == 1) // Cambiado numCombo a iNumCombo
                            {
                                componente.Text = logic.LlaveCampoRev(arrTablaCombo[iNumCombo], arrCampoCombo[iNumCombo], Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString());
                            }
                            else
                            {
                                componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                            }
                            iNumCombo++; 
                        }
                        else
                        {
                            componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                        }

                        iIndex++;
                    }
                    if (componente is Button)
                    {
                        string sVarEstado = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString(); 
                        if (sVarEstado == "0")
                        {
                            componente.Text = "Desactivado";
                            componente.BackColor = Color.Red;
                        }
                        if (sVarEstado == "1")
                        {
                            componente.Text = "Activado";
                            componente.BackColor = Color.Green;
                        }
                        componente.Enabled = false;
                    }
                }

                // Habilitar y deshabilitar botones según permisos del usuario
                BotonesYPermisosSinMensaje();

                // Mostrar mensaje de éxito al refrescar los datos
                MessageBox.Show(
                    "Los datos han sido actualizados correctamente.",
                    "Refrescado Exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                // Manejo de errores y mostrar un mensaje más profesional
                MessageBox.Show(
                    "Ocurrió un error al refrescar los datos.\n\n" +
                    "Detalles del error: " + ex.Message + "\n\n" +
                    "Por favor, intente nuevamente o contacte al administrador del sistema.",
                    "Error al Refrescar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Este método maneja el evento de clic en el botón "Anterior".
        private void Btn_Anterior_Click(object sender, EventArgs e)
        {
            int iIndex = 0;
            string[] arrCampos = logic.Campos(sTablaPrincipal); 

            int iFila = Dgv_Informacion.SelectedRows[0].Index; 

            if (iFila > 0)
            {
                Dgv_Informacion.Rows[iFila - 1].Selected = true; 
                Dgv_Informacion.CurrentCell = Dgv_Informacion.Rows[iFila - 1].Cells[0];

                int iNumCombo = 0;
                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        if (componente is ComboBox)
                        {
                            if (arrModoCampoCombo[iNumCombo] == 1) 
                            {
                                componente.Text = logic.LlaveCampoRev(arrTablaCombo[iNumCombo], arrCampoCombo[iNumCombo], Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString());
                            }
                            else
                            {
                                componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                            }
                            iNumCombo++; 
                        }
                        else
                        {
                            componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                        }
                        iIndex++;
                    }
                    if (componente is Button)
                    {
                        string sVarEstado = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString(); 
                        if (sVarEstado == "0")
                        {
                            componente.Text = "Desactivado";
                            componente.BackColor = Color.Red;
                        }
                        if (sVarEstado == "1")
                        {
                            componente.Text = "Activado";
                            componente.BackColor = Color.Green;
                        }
                        componente.Enabled = false;
                    }
                }
            }
        }

        // Este método maneja el evento de clic en el botón "Siguiente".
        private void Btn_Siguiente_Click(object sender, EventArgs e)
        {
            int iIndex = 0;
            string[] arrCampos = logic.Campos(sTablaPrincipal); 

            int iFila = Dgv_Informacion.SelectedRows[0].Index; 

            if (iFila < Dgv_Informacion.Rows.Count - 1)
            {
                Dgv_Informacion.Rows[iFila + 1].Selected = true; 
                Dgv_Informacion.CurrentCell = Dgv_Informacion.Rows[iFila + 1].Cells[0]; 

                int iNumCombo = 0; 
                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        if (componente is ComboBox)
                        {
                            if (arrModoCampoCombo[iNumCombo] == 1) 
                            {
                                componente.Text = logic.LlaveCampoRev(arrTablaCombo[iNumCombo], arrCampoCombo[iNumCombo], Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString());
                            }
                            else
                            {
                                componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                            }
                            iNumCombo++;
                        }
                        else
                        {
                            componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                        }
                        iIndex++;
                    }
                    if (componente is Button)
                    {
                        string sVarEstado = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                        if (sVarEstado == "0")
                        {
                            componente.Text = "Desactivado";
                            componente.BackColor = Color.Red;
                        }
                        if (sVarEstado == "1")
                        {
                            componente.Text = "Activado";
                            componente.BackColor = Color.Green;
                        }
                        componente.Enabled = false;
                    }
                }
            }
        }


        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ*****************************




        //******************************************** CODIGO HECHO POR JOEL LOPEZ***************************** 

        // Este método maneja el evento de clic del botón "Flecha Fin" para moverse al último registro visible en el DataGridView.
        private void Btn_FlechaFin_Click(object sender, EventArgs e)
        {
            // Selecciona la penúltima fila (contando desde cero) en el DataGridView y la establece como la fila actual.
            Dgv_Informacion.Rows[Dgv_Informacion.Rows.Count - 2].Selected = true;
            Dgv_Informacion.CurrentCell = Dgv_Informacion.Rows[Dgv_Informacion.Rows.Count - 2].Cells[0];

            int iIndex = 0;
            // Obtiene los nombres de las columnas de la sTablaPrincipal en la base de datos.
            string[] arrCampos = logic.Campos(sTablaPrincipal); 

            // Obtiene el índice de la fila actualmente seleccionada en el DataGridView.
            int iFila = Dgv_Informacion.SelectedRows[0].Index; 
            if (iFila < Dgv_Informacion.Rows.Count - 1)
            {
                // Vuelve a seleccionar la penúltima fila para asegurarse de que es la fila correcta.
                Dgv_Informacion.Rows[Dgv_Informacion.Rows.Count - 2].Selected = true;
                Dgv_Informacion.CurrentCell = Dgv_Informacion.Rows[Dgv_Informacion.Rows.Count - 2].Cells[0];

                int iNumCombo = 0; 
                 // Itera sobre todos los controles en el formulario.
                foreach (Control componente in Controls)
                {
                    // Si el control es un TextBox, DateTimePicker o ComboBox, actualiza su valor con el valor correspondiente de la celda seleccionada en el DataGridView.
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        if (componente is ComboBox)
                        {
                            // Para los ComboBox, se verifica si el campo es clave externa (arrModoCampoCombo) y se obtiene el valor adecuado.
                            if (arrModoCampoCombo[iNumCombo] == 1) 
                            {
                                componente.Text = logic.LlaveCampoRev(arrTablaCombo[iNumCombo], arrCampoCombo[iNumCombo], Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString());
                            }
                            else
                            {
                                componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                            }
                            iNumCombo++; // Cambiado numCombo a iNumCombo
                        }
                        else
                        {
                            componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                        }
                        iIndex++;
                    }
                    // Si el control es un botón, se actualiza su estado dependiendo del valor de la celda en la fila seleccionada.
                    if (componente is Button)
                    {
                        string sVarEstado = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString(); // Cambiado var1 a sVarEstado
                        if (sVarEstado == "0")
                        {
                            componente.Text = "Desactivado";
                            componente.BackColor = Color.Red;
                        }
                        if (sVarEstado == "1")
                        {
                            componente.Text = "Activado";
                            componente.BackColor = Color.Green;
                        }
                        componente.Enabled = false;
                    }
                }
            }
        }


        void CrearTextBoxNumerico(String sNom, Point location)
        {
            TextBox tb = new TextBox(); // Crea un nuevo TextBox
            tb.Width = (int)(tb.Width * 1.2);
            tb.Height = (int)(tb.Height * 1.2);
            tb.Location = location; // Establece la ubicación del TextBox
            tb.Name = sNom; // Establece el nombre del TextBox
            this.Controls.Add(tb); // Añade el TextBox al formulario
            tb.KeyPress += ParaValidarNumeros_KeyPress; // Asigna la función de validación de números al evento KeyPress
                                                        // iPosicionInicial++; // Ya no es necesario incrementar iPosicionInicial aquí
        }
        // Este método maneja el evento de clic del botón "Flecha Inicio" para moverse al primer registro en el DataGridView.
        private void Btn_FlechaInicio_Click(object sender, EventArgs e)
        {
            // Selecciona la primera fila en el DataGridView y la establece como la fila actual.
            Dgv_Informacion.Rows[0].Selected = true;
            Dgv_Informacion.CurrentCell = Dgv_Informacion.Rows[0].Cells[0];

            int iIndex = 0;
            // Obtiene los nombres de las columnas de la sTablaPrincipal en la base de datos.
            string[] arrCampos = logic.Campos(sTablaPrincipal);

            int iFila = Dgv_Informacion.SelectedRows[0].Index;
            if (iFila < Dgv_Informacion.Rows.Count - 1)
            {
                // Vuelve a seleccionar la primera fila para asegurarse de que es la fila correcta.
                Dgv_Informacion.Rows[0].Selected = true;
                Dgv_Informacion.CurrentCell = Dgv_Informacion.Rows[0].Cells[0];

                int iNumCombo = 0;
                                   // Itera sobre todos los controles en el formulario.
                foreach (Control componente in Controls)
                {
                    // Si el control es un TextBox, DateTimePicker o ComboBox, actualiza su valor con el valor correspondiente de la celda seleccionada en el DataGridView.
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        if (componente is ComboBox)
                        {
                            // Para los ComboBox, se verifica si el campo es clave externa (arrModoCampoCombo) y se obtiene el valor adecuado.
                            if (arrModoCampoCombo[iNumCombo] == 1) 
                            {
                                componente.Text = logic.LlaveCampoRev(arrTablaCombo[iNumCombo], arrCampoCombo[iNumCombo], Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString());
                            }
                            else
                            {
                                componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                            }
                            iNumCombo++;
                        }
                        else
                        {
                            componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                        }
                        iIndex++;
                    }
                    // Si el control es un botón, se actualiza su estado dependiendo del valor de la celda en la fila seleccionada.
                    if (componente is Button)
                    {
                        string sVarEstado = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                        if (sVarEstado == "0")
                        {
                            componente.Text = "Desactivado";
                            componente.BackColor = Color.Red;
                        }
                        if (sVarEstado == "1")
                        {
                            componente.Text = "Activado";
                            componente.BackColor = Color.Green;
                        }
                        componente.Enabled = false;
                    }
                }
            }
        }

        //******************************************** CODIGO HECHO POR ANIKA ESCOTO *****************************

        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS *****************************

        // Este método configura los botones del formulario en función de los permisos del usuario, sin mostrar mensajes.
        public void BotonesYPermisosSinMensaje()
        {
            try
            {
                // Lista de nombres de permisos que corresponden a las acciones posibles.
                string[] arrPermisosText = { "INGRESAR", "BUSCAR", "MODIFICAR", "ELIMINAR", "IMPRIMIR" };
                // Lista de botones en el formulario que se habilitarán o deshabilitarán según los permisos del usuario.
                Button[] arrBotones = { Btn_Ingresar, Btn_Consultar, Btn_Modificar, Btn_Eliminar, Btn_Imprimir };

                for (int iIndex = 0; iIndex < arrPermisosText.Length; iIndex++)
                {
                    // Consulta el ID del usuario actual.
                    string sIdUsuario1 = logic.ObtenerIdUsuario(sIdUsuario);
                    
                    // Verifica si el usuario tiene permiso para la acción correspondiente.
                    bool bTienePermiso = lg.ConsultarPermisos(sIdUsuario1, sIdAplicacion, iIndex + 1);

                    // Si el botón existe (no es nulo), se habilita o deshabilita según los permisos del usuario.
                    if (arrBotones[iIndex] != null)
                    {
                        arrBotones[iIndex].Enabled = bTienePermiso;
                    }
                }
            }
            catch (Exception ex)
            {
                // En caso de error, se muestra un mensaje en la consola con los detalles del error.
                Console.WriteLine("Error al configurar los botones y permisos: " + ex.Message);
                // Opcionalmente, se podría registrar el error en un archivo de log.
            }
        }


        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS *****************************


        //******************************************** CODIGO HECHO POR JOSUE CACAO *****************************

        // Este método configura los botones del formulario basándose en los permisos del usuario y muestra un mensaje con los botones habilitados y deshabilitados.
        public void BotonesYPermisos()
        {
            try
            {
                // Definición de los nombres de los permisos y sus correspondientes botones en el formulario.
                string[] arrPermisosText = { "INGRESAR", "BUSCAR", "MODIFICAR", "ELIMINAR", "IMPRIMIR" };
                Button[] arrBotones = { Btn_Ingresar, Btn_Consultar, Btn_Modificar, Btn_Eliminar, Btn_Imprimir };

                string sBotonesPermitidos = "";   // Variable para almacenar los botones que el usuario tiene permiso de usar.
                string sBotonesNoPermitidos = ""; // Variable para almacenar los botones que el usuario no tiene permiso de usar.

                for (int iIndex = 0; iIndex < arrPermisosText.Length; iIndex++)
                {
                    // Obtiene el ID del usuario actual.
                    string sIdUsuario1 = logic.ObtenerIdUsuario(sIdUsuario);
                    
                    // Consulta si el usuario tiene el permiso correspondiente.
                    bool bTienePermiso = lg.ConsultarPermisos(sIdUsuario1, sIdAplicacion, iIndex + 1);

                    if (arrBotones[iIndex] != null)
                    {
                        arrBotones[iIndex].Enabled = bTienePermiso; // Habilita o deshabilita el botón según el permiso.

                        if (arrBotones[iIndex].Enabled)
                        {
                            // Si el botón está habilitado, se agrega a la lista de botones permitidos.
                            sBotonesPermitidos += arrPermisosText[iIndex] + ", ";
                        }
                        else
                        {
                            // Si el botón está deshabilitado, se agrega a la lista de botones no permitidos.
                            sBotonesNoPermitidos += arrPermisosText[iIndex] + ", ";
                        }
                    }
                    else
                    {
                        // Si el botón no se encuentra, se agrega a la lista de botones no permitidos.
                        sBotonesNoPermitidos += arrPermisosText[iIndex] + ", ";
                    }
                }

                // Formateo del mensaje final que se mostrará al usuario.
                string sMensaje = "";

                if (!string.IsNullOrEmpty(sBotonesPermitidos))
                {
                    sMensaje += "Botones permitidos: " + sBotonesPermitidos.TrimEnd(',', ' ') + ".\n";
                }

                if (!string.IsNullOrEmpty(sBotonesNoPermitidos))
                {
                    sMensaje += "Botones no permitidos: " + sBotonesNoPermitidos.TrimEnd(',', ' ') + ".";
                }

                if (!string.IsNullOrEmpty(sMensaje))
                {
                    // Muestra un único MessageBox con el resumen de los botones permitidos y no permitidos.
                    MessageBox.Show(sMensaje);
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores, mostrando un mensaje en caso de que algo salga mal al configurar los botones.
                MessageBox.Show("Error al configurar los botones y permisos: " + ex.Message);
            }
        }


        //******************************************** CODIGO HECHO POR JOSUE CACAO *****************************

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ *****************************

        // Este método maneja el evento de clic del botón "Guardar", asegurando que los datos sean válidos y guardándolos en la base de datos.
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Muestra un mensaje de confirmación antes de proceder con el guardado.
                DialogResult drResult = MessageBox.Show(
                    "Está a punto de guardar un nuevo registro en el sistema.\n\n" +
                    "Asegúrese de que toda la información ingresada sea correcta.\n\n" +
                    "¿Desea continuar con el guardado?",
                    "Confirmación de Guardado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (drResult == DialogResult.No)
                {
                    return;
                }

                // Verifica si todos los campos están llenos antes de proceder.
                bool bLleno = true;
                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        if (string.IsNullOrEmpty(componente.Text))
                        {
                            bLleno = false;
                            break; // Si encuentra un campo vacío, sale del bucle.
                        }
                    }
                }

                if (!bLleno)
                {
                    MessageBox.Show(
                        "Por favor, complete todos los campos antes de guardar.\n\n" +
                        "El registro no se puede guardar mientras existan campos vacíos.",
                        "Campos Vacíos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }




                // Lista para almacenar las consultas SQL que se ejecutarán.
                List<string> lstQueries = new List<string>();

                // Dependiendo del valor de "iActivar", se realiza una actualización o inserción.
                switch (iActivar)
                {
                    case 1: // Actualizar
                        try
                        {
                            // Obtener la clave primaria de la tabla principal
                            string sClavePrimariaPrincipal = logic.ObtenerClavePrimaria(sTablaPrincipal);
                            string sQueryPrincipal = CrearUpdate(sTablaPrincipal, sClavePrimariaPrincipal);

                            // Verificar que la consulta de la tabla principal no sea nula antes de agregarla
                            if (!string.IsNullOrEmpty(sQueryPrincipal))
                            {
                                lstQueries.Add(sQueryPrincipal); // Añade la consulta principal a la lista.
                            }

                            // Itera sobre las tablas adicionales para actualizar registros relacionados.


                            // Ejecuta las consultas para actualizar datos en múltiples tablas.
                            logic.InsertarDatosEnMultiplesTablas(lstQueries);
                            MessageBox.Show("El registro ha sido actualizado correctamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Inserta en la bitácora
                            lg.funinsertarabitacora(sIdUsuario, "Actualizó registro", sTablaPrincipal, sIdAplicacion);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ocurrió un error al actualizar los registros: {ex.Message}", "Error de Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    case 2: // Insertar
                        try
                        {
                            // Inserta el registro en la tabla principal
                            string sQueryPrimeraTabla = CrearInsert(sTablaPrincipal);
                            Console.WriteLine("Consulta generada para la tabla principal: " + sQueryPrimeraTabla);

                            if (string.IsNullOrEmpty(sQueryPrimeraTabla))
                            {
                                Console.WriteLine("Error: La consulta generada para la tabla principal es nula o vacía.");
                                return;
                            }

                            // Insertar en la tabla principal
                            logic.NuevoQuery(sQueryPrimeraTabla);
                            Console.WriteLine("Registro insertado en la tabla principal exitosamente.");

                            lg.funinsertarabitacora(sIdUsuario, "Se insertó en " + sTablaPrincipal, sTablaPrincipal, sIdAplicacion);

                            // Obtiene el último ID insertado en la tabla principal
                            string sUltimoIdPrimeraTabla = logic.UltimoID(sTablaPrincipal);
                            if (string.IsNullOrEmpty(sUltimoIdPrimeraTabla))
                            {
                                Console.WriteLine("Error: El último ID obtenido de la tabla principal es nulo o vacío.");
                                return;
                            }


                            // Insertar en las tablas asociativas
                            // **Insertar en las tablas asociativas**
                            // **Insertar en las tablas asociativas**

                            // Ejecutar todas las consultas
                            logic.InsertarDatosEnMultiplesTablas(lstQueries);
                            MessageBox.Show("El registro ha sido guardado correctamente.", "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error al guardar los registros: " + ex.Message);
                            MessageBox.Show($"Ocurrió un error al guardar los registros: {ex.Message}", "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    default:
                        MessageBox.Show("Opción no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                // Actualiza la vista de datos y deshabilita los campos después de la operación.
                ActualizarDataGridView();
                Deshabilitarcampos_y_botones();
                BotonesYPermisosSinMensaje();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error durante el guardado del registro.\n\n" +
                    "Detalles del error: " + ex.Message + "\n\n" +
                    "Por favor, intente nuevamente o contacte al administrador del sistema.",
                    "Error en el Guardado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ *****************************




        //******************************************** CODIGO HECHO POR MATY MANCILLA *****************************

        // Este método maneja el evento de clic en una celda del DataGridView.
        // Cuando se hace clic en una celda, se actualizan los controles del formulario (TextBox, DateTimePicker, ComboBox, Button)
        // con los valores correspondientes de la fila seleccionada en el DataGridView.
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iIndex = 0;
            string primaryKeyValue = null;

            Console.WriteLine("Comenzando la asignación de componentes de la tabla principal...");

            // Asignar valores a los componentes de la tabla principal
            foreach (Control componente in Controls)
            {
                if (iIndex >= Dgv_Informacion.CurrentRow.Cells.Count)
                    break;

                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    Console.WriteLine($"Asignando valor al componente: {componente.Name}");
                    componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                    Console.WriteLine($"Valor asignado: {Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString()}");

                    // Guardar la clave primaria si el nombre del componente la contiene
                    if (componente.Name.Contains("Pk"))
                    {
                        primaryKeyValue = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                        Console.WriteLine($"Clave primaria detectada: {primaryKeyValue}");
                    }

                    iIndex++;
                }
                else if (componente is Button) // Verificamos si el componente es un botón
                {
                    Console.WriteLine($"Asignando valor al botón: {componente.Name}");

                    string valorCelda = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                    Console.WriteLine($"Valor asignado al botón: {valorCelda}");

                    // Verificar si el valor es 0 o 1 para cambiar el estado del botón
                    if (valorCelda == "1")
                    {
                        componente.Text = "Activado";
                        componente.BackColor = Color.Green;
                        Console.WriteLine($"Botón {componente.Name} activado (verde).");
                    }
                    else if (valorCelda == "0")
                    {
                        componente.Text = "Desactivado";
                        componente.BackColor = Color.Red;
                        Console.WriteLine($"Botón {componente.Name} desactivado (rojo).");
                    }

                    iIndex++;
                }

            }



            BotonesYPermisosSinMensaje();
        }

        // Método de placeholder, sin implementación.
        private void Contenido_Click(object sender, EventArgs e)
        {
            // Código a implementar
        }

        // Maneja el evento de clic en el botón de ayuda.
        private void Btn_Ayuda_Click_1(object sender, EventArgs e)
        {
            // Construye la ruta completa del archivo de ayuda
            string sRutaArchivoAyuda = AppDomain.CurrentDomain.BaseDirectory + @"..\..\AyudaHTML\AyudaNavegador.chm";

            // Normaliza la ruta para obtenerla de forma absoluta
            sRutaArchivoAyuda = System.IO.Path.GetFullPath(sRutaArchivoAyuda);

            // Verifica si el archivo de ayuda existe antes de intentar abrirlo
            if (System.IO.File.Exists(sRutaArchivoAyuda))
            {
                Help.ShowHelp(this, sRutaArchivoAyuda, "AyudaNav.html");
            }
            else
            {
                // Muestra un mensaje de error si el archivo de ayuda no se encuentra
                MessageBox.Show("No se encontró el archivo de ayuda: " + sRutaArchivoAyuda, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Maneja el evento de clic en un botón para obtener más ayuda.
        private void Btn_MasAyuda_Click(object sender, EventArgs e)
        {
            // Verifica la existencia de la tabla de ayuda
            string sAyudaOK = logic.TestTabla("ayuda");
            if (sAyudaOK == "")
            {
                // Si la tabla existe sin problemas, abre el formulario de ayuda
                Ayudas nuevo = new Ayudas();
                nuevo.Show();
            }
            else
            {
                // Si hay un problema con la tabla, muestra un mensaje de advertencia
                DialogResult drValidacion = MessageBox.Show(sAyudaOK + " \n Solucione este error para continuar...", "Verificación de requisitos", MessageBoxButtons.OK);
                if (drValidacion == DialogResult.OK)
                {
                    // Acción adicional si el usuario presiona OK (actualmente no implementada)
                }
            }
        }

        // Método de placeholder, sin implementación.
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Código a implementar
        }

        // Método de placeholder, sin implementación.
        private void LblTabla_Click(object sender, EventArgs e)
        {
            // Código a implementar
        }

        // Maneja el evento de clic en un botón (button7) y oculta el formulario actual.
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual.
        }

        // Maneja el evento de clic en el botón de imprimir.
        private void Btn_Imprimir_Click_1(object sender, EventArgs e)
        {
            // Se crea una instancia del controlador de reportería.
            Capa_Controlador_Reporteria.Controlador controlador = new Capa_Controlador_Reporteria.Controlador();

            // Se obtiene el ID de la aplicación.
            ObtenerIdAplicacion(sIdAplicacion);

            // Se consulta la ruta del reporte usando el ID de la aplicación.
            string sRuta = controlador.queryRuta(sIdAplicacion);

            // Si la ruta es válida, se abre el visor de reportes con la ruta obtenida.
            if (!string.IsNullOrEmpty(sIdAplicacion))
            {
                Capa_Vista_Reporteria.visualizar visualizar = new Capa_Vista_Reporteria.visualizar(sRuta);
                visualizar.ShowDialog(); // Muestra el reporte en un diálogo modal.
                lg.funinsertarabitacora(sIdUsuario, "Vio un reporte", sTablaPrincipal, sIdAplicacion);
            }
        }

        // Maneja el evento de clic en el botón principal de reportes.
        private void Btn_Reportes_Principal_Click(object sender, EventArgs e)
        {
            menu_reporteria reportes = new menu_reporteria();
            reportes.Show(); // Muestra el formulario del menú de reportes.
        }

        // Maneja el evento de clic en el botón de consulta.
        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            // Se obtiene el ID del usuario.
            string sIdUsuario1 = logic.ObtenerIdUsuario(sIdUsuario);

           
            ConsultaSimple nueva = new ConsultaSimple(sTablaPrincipal);
            nueva.Show();
            lg.funinsertarabitacora(sIdUsuario, "Entro a consultas", "consultas", sIdAplicacion);
            BotonesYPermisosSinMensaje();
        }


        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ *****************************


        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS *****************************

        // Este método maneja el evento de clic en el botón principal de reportes.
        // Abre el menú de reportería.
        private void Btn_Reportes_Principal_Click_1(object sender, EventArgs e)
        {
            // Se crea una instancia del formulario de menú de reportería.
            menu_reporteria reportes = new menu_reporteria();

            // Muestra el formulario del menú de reportería.
            reportes.Show();
            lg.funinsertarabitacora(sIdUsuario, "Abrio un reporte", sTablaPrincipal, sIdAplicacion);
        }

        // Este método maneja el evento de clic en el botón de ayuda (button1).
        // Abre el formulario de ayudas.
        private void Button1_Click(object sender, EventArgs e)
        {
            // Se crea una instancia del formulario de ayudas.
            Ayudas ayudas = new Ayudas();

            // Muestra el formulario de ayudas.
            ayudas.Show();
            lg.funinsertarabitacora(sIdUsuario, "Entro a los registros de ayuda", sTablaPrincipal, sIdAplicacion);
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // Verifica si se está en medio de una operación de guardado y se quiere salir sin finalizar.
                    if (Btn_Guardar.Enabled == true && Btn_Cancelar.Enabled == true && Btn_Eliminar.Enabled == false && Btn_Modificar.Enabled == false && Btn_Ingresar.Enabled == false)
                    {
                        foreach (Control componente in Controls)
                        {
                            // Si hay un TextBox con datos, pregunta al usuario si desea guardar antes de salir.
                            if (componente.Text != "" && componente is TextBox)
                            {
                                DialogResult drRespuestaGuardar = MessageBox.Show(
                                    "Se ha detectado una operación de guardado en curso.\n\n" +
                                    "¿Desea guardar los cambios antes de salir?",
                                    "Confirmación de Salida - " + sNombreFormulario,
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Warning
                                );

                                // Si el usuario elige "Yes", se guarda y luego se cierra el formulario.
                                if (drRespuestaGuardar == DialogResult.Yes)
                                {
                                    GuardadoForsozo();
                                    frmCerrar.Visible = false;
                                    lg.funinsertarabitacora(sIdUsuario, "Salio del Navegador", sTablaPrincipal, sIdAplicacion);
                                }
                                // Si el usuario elige "No", se cierra el formulario sin guardar.
                                else if (drRespuestaGuardar == DialogResult.No)
                                {
                                    frmCerrar.Visible = false;
                                }
                                // Si el usuario elige "Cancel", se cancela la salida y permanece en el formulario.
                                else if (drRespuestaGuardar == DialogResult.Cancel)
                                {
                                    return;
                                }
                            }
                        }
                    }

                    // Verifica si se está en medio de una operación de modificación y se quiere salir sin finalizar.
                    if (Btn_Modificar.Enabled == true && Btn_Guardar.Enabled == true && Btn_Cancelar.Enabled == true && Btn_Ingresar.Enabled == false)
                    {
                        foreach (Control componente in Controls)
                        {
                            // Si hay un TextBox con datos, pregunta al usuario si desea regresar y finalizar la operación antes de salir.
                            if (componente.Text != "" && componente is TextBox)
                            {
                                DialogResult drRespuestaModificar = MessageBox.Show(
                                    "Se ha detectado una operación de modificación en curso.\n\n" +
                                    "¿Desea regresar y finalizar la operación antes de salir?",
                                    "Confirmación de Salida - " + sNombreFormulario,
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Warning
                                );

                                // Si el usuario elige "Yes", se cancela la salida y permanece en el formulario.
                                if (drRespuestaModificar == DialogResult.Yes)
                                {
                                    return;
                                }
                                // Si el usuario elige "No", se cierra el formulario sin finalizar la modificación.
                                else if (drRespuestaModificar == DialogResult.No)
                                {
                                    frmCerrar.Visible = false;
                                }
                                // Si el usuario elige "Cancel", se cancela la salida y permanece en el formulario.
                                else if (drRespuestaModificar == DialogResult.Cancel)
                                {
                                    return;
                                }
                            }
                        }
                    }

                    // Verifica si se está en medio de una operación de eliminación y se quiere salir sin finalizar.
                    if (Btn_Eliminar.Enabled == true && Btn_Cancelar.Enabled == true && Btn_Modificar.Enabled == false && Btn_Guardar.Enabled == false && Btn_Ingresar.Enabled == false)
                    {
                        foreach (Control componente in Controls)
                        {
                            // Si hay un TextBox con datos, pregunta al usuario si desea regresar y finalizar la operación antes de salir.
                            if (componente.Text != "" && componente is TextBox)
                            {
                                DialogResult drRespuestaEliminar = MessageBox.Show(
                                    "Se ha detectado una operación de eliminación en curso.\n\n" +
                                    "¿Desea regresar y finalizar la operación antes de salir?",
                                    "Confirmación de Salida - " + sNombreFormulario,
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Warning
                                );

                                // Si el usuario elige "Yes", se cancela la salida y permanece en el formulario.
                                if (drRespuestaEliminar == DialogResult.Yes)
                                {
                                    return;
                                }
                                // Si el usuario elige "No", se cierra el formulario sin finalizar la eliminación.
                                else if (drRespuestaEliminar == DialogResult.No)
                                {
                                    frmCerrar.Visible = false;
                                }
                                // Si el usuario elige "Cancel", se cancela la salida y permanece en el formulario.
                                else if (drRespuestaEliminar == DialogResult.Cancel)
                                {
                                    return;
                                }
                            }
                        }
                    }

                    // Confirma finalmente si el usuario desea salir del formulario si no hay operaciones pendientes.
                    DialogResult drConfirmacionFinal = MessageBox.Show(
                        "¿Está seguro de que desea salir del formulario?",
                        "Confirmación de Salida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Si el usuario confirma, cierra el formulario.
                    if (drConfirmacionFinal == DialogResult.Yes)
                    {
                        frmCerrar.Visible = false;
                    }
                    else
                    {
                        return; // Si el usuario decide quedarse, se cancela la salida.
                    }
                }
                catch (Exception ex)
                {
                    // En caso de error, muestra un mensaje al usuario con los detalles del error.
                    MessageBox.Show(
                        "Ocurrió un error al intentar salir del formulario.\n\n" +
                        "Detalles del error: " + ex.Message + "\n\n" +
                        "Por favor, intente nuevamente o contacte al administrador del sistema.",
                        "Error al Salir",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el directorio raíz del proyecto subiendo suficientes niveles
                string sProjectRootPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\.."));

                // Combinar la ruta base con la carpeta "Ayuda\AyudaHTML"
                string sAyudaPath = Path.Combine(sProjectRootPath, "Ayuda", "Ayuda_Navegador", sRutaAyuda);

                // Mostrar la ruta en un MessageBox antes de proceder
                //MessageBox.Show("Buscando archivo de ayuda en la ruta: " + ayudaPath, "Ruta de Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Verificar que el archivo de ayuda exista antes de intentar abrirlo
                if (File.Exists(sAyudaPath))
                {
                    // Mostrar la ayuda utilizando la ruta completa y el índice
                    Help.ShowHelp(this, sAyudaPath, sIndiceAyuda);
                    lg.funinsertarabitacora(sIdUsuario, "Vio un documento de ayuda", sTablaPrincipal, sIdAplicacion);
                }
                else
                {
                    // Mostrar un mensaje de error si el archivo de ayuda no se encuentra
                    MessageBox.Show("No se encontró el archivo de ayuda en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de una excepción
                MessageBox.Show("Ocurrió un error al abrir la ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al abrir la ayuda: " + ex.ToString());
            }

            BotonesYPermisosSinMensaje();
        }
        private void button_Paint(object sender, PaintEventArgs e)
        {
            BiselUtil.AplicarBisel(sender as Button, e);
        }

        private void Btn_Ingresar_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Tlp_Panel2_Paint(object sender, PaintEventArgs e)
        {
            Panel pnl = sender as Panel;

            // Color de la sombra (ajusta al color que prefieras)
            Color sombraColor = Color.Gray;

            // Dibujar sombra (parte inferior y derecha)
            int sombraTamaño = 5; // Tamaño de la sombra
            Rectangle shadowRect = new Rectangle(pnl.ClientRectangle.X + sombraTamaño,
                                                 pnl.ClientRectangle.Y + sombraTamaño,
                                                 pnl.ClientRectangle.Width,
                                                 pnl.ClientRectangle.Height);
            using (Brush shadowBrush = new SolidBrush(sombraColor))
            {
                e.Graphics.FillRectangle(shadowBrush, shadowRect);
            }

            // Dibujar bisel alrededor del panel
            ControlPaint.DrawBorder(e.Graphics, pnl.ClientRectangle,
                                    SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,  // Arriba
                                    SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,  // Izquierda
                                    SystemColors.ControlDark, 3, ButtonBorderStyle.Inset,          // Derecha
                                    SystemColors.ControlDark, 3, ButtonBorderStyle.Inset);
        }

        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS *****************************
    }
}