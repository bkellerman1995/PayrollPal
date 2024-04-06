using PayrollPal.Layers.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using PayrollPal.Layers.Entities;
using PayrollPal.Enumeraciones;

namespace PayrollPal.Layers.UI.Mantenimientos
{
    public partial class frmMantenimientoDeduccionesPercepcionesColaborador : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        List<Colaborador> listaAgregarDeduccionPercepcionColaborador = new List<Colaborador>();
        List<Colaborador> listaColaboradoresALL = BLLColaborador.SelectSoloSoloColaboradoresSinDedPerc();
        Colaborador oColaborador = new Colaborador();
        public frmMantenimientoDeduccionesPercepcionesColaborador()
        {
            InitializeComponent();
        }

        private void frmMantenimientoDeduccionesPercepcionesColaborador_Load(object sender, EventArgs e)
        {
            try
            {
                //Cargar el datagridview de deducciones/percepciones por colaborador con el SELECT_ALL 
                //del DALDeduccionPercepcionPorColaborador

                CargarListaColaboradoresyDataGridView();
                CargarCombos();
                RevisarCombosListasVacios();

                //Limpiar los controles del form 
                LimpiarControles();
            }
            catch (Exception msg)
            {
                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");
            }
        }

        /// <summary>
        /// Método que se encarga de cargar la lista 
        /// de supervisores desde la base de datos 
        /// y cargarlo al datagridview
        /// </summary>
        private void CargarListaColaboradoresyDataGridView()
        {
            try
            {
                
                RefrescarListaColaboradoresALL();
                RefrescarListaAgregarDeduccionPercepcionColaborador();

                this.dgvDedPercColab.DataSource = BLLDeducciones_Percepciones_Por_Colaborador.SelectAll();
                this.dgvDedPercColab.Columns["IdColaborador"].Visible = false;
                this.dgvDedPercColab.ClearSelection();


            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");

            }
        }

        /// <summary>
        /// Método que se encarga de cargar el  
        /// comboBox de Prioridad
        /// </summary>
        private void CargarCombos()
        {
            try
            {


                foreach (PrioridadDeduccionPercepcion tipo in Enum.GetValues(typeof(PrioridadDeduccionPercepcion)))
                {
                    this.cmbPrioridad.Items.Add(tipo);
                }

                foreach (var item in BLLDeduccionesPercepciones.SelectAll())
                {
                    this.cmbDedPercCol.Items.Add(item);
                }

            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");

            }
        }

        private void RevisarCombosListasVacios()
        {
            string camposVacios = "";
            bool vacio = false;

            if (BLLDeduccionesPercepciones.SelectAll().Count == 0)
            {
                camposVacios += "\n- Deducción / Percepción";
                vacio = true;
            }

            if (BLLColaborador.SelectSoloColaboradores().Count == 0)
            {
                camposVacios += "\n- Colaboradores";
                vacio = true;
            }

            if (vacio)
            {
                MessageBox.Show("Hay campos(s) vacío(s): " + camposVacios + "" +
            "\n\nEstos campos son necesarios para poder agregar deducciones/percepciones por colaborador." +
            "\n" +
            "\nNo puede agregar deducciones/percepciones por colaborador sin datos en los campos arriba mencionados." +
            "\n" +
            "\nDebe agregar los campos faltantes en el mantenimiento respectivo.",
            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();

            }
        }

        /// <summary>
        /// Evento del botón Agregar Colaborador 
        /// que se encarga de verificar si se puede 
        /// agregar un colaborador en la lista de 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarCol_Click(object sender, EventArgs e)
        {
            if (this.lstColaboradoresALL.SelectedItem != null)
            {
                oColaborador = this.lstColaboradoresALL.SelectedItem as Colaborador;
                listaAgregarDeduccionPercepcionColaborador.Add(oColaborador);
                listaColaboradoresALL.Remove(oColaborador);

                RefrescarListaAgregarDeduccionPercepcionColaborador();
                RefrescarListaColaboradoresALL();
            }
            else
            {
                this.errProv1.SetError(this.lstColaboradoresALL, "Debe seleccionar un colaborador de la lista" +
                    "para poder asignarle una deducción/percepción");
                this.lstColaboradoresALL.BackColor = Color.MistyRose;
            }

            if (this.lstColaboradoresALL.Items.Count == 0)
            {
                this.btnAgregarCol.Enabled = false;
            }

        }

        private void RefrescarListaAgregarDeduccionPercepcionColaborador()
        {
            this.lstDedPercPorColab.Items.Clear();
            foreach (var item in listaAgregarDeduccionPercepcionColaborador)
            {
                this.lstDedPercPorColab.Items.Add(item);
            }
            this.errProv1.SetError(this.lstDedPercPorColab, string.Empty);
        }

        private void RefrescarListaColaboradoresALL()
        {
            this.lstColaboradoresALL.Items.Clear();
            foreach (var item in listaColaboradoresALL)
            {
                this.lstColaboradoresALL.Items.Add(item);
            }

            this.errProv1.SetError(this.lstColaboradoresALL, string.Empty);
        }

        /// <summary>
        /// Evento del botón Quitar Colaborador 
        /// que se encarga de verificar si se puede 
        /// deasignar una Deducción/Percepción  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitarColab_Click(object sender, EventArgs e)
        {
            if (this.lstDedPercPorColab.SelectedItem != null)
            {
                oColaborador = this.lstDedPercPorColab.SelectedItem as Colaborador;
                listaColaboradoresALL.Add(oColaborador);
                listaAgregarDeduccionPercepcionColaborador.Remove(oColaborador);

                BLLDeducciones_Percepciones_Por_Colaborador.Delete(this.cmbDedPercCol.Text, oColaborador.IDColaborador);

                RefrescarListaAgregarDeduccionPercepcionColaborador();
                RefrescarListaColaboradoresALL();
            }
            else
            {
                this.errProv1.SetError(this.lstDedPercPorColab, "Debe seleccionar un colaborador de la lista" +
                    "para poder desasignarle una deducción/percepción");
            }

            if (this.lstDedPercPorColab.Items.Count == 0)
            {
                this.btnQuitarColab.Enabled = false;
            }

        }

        /// <summary>
        /// Evento que se encarga de seleccionar 
        /// el objeto usuario en el datagrid view 
        /// y cargarlo en los campos respectivos
        /// del form (para editar o borrar o simplemente ver)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDedPercColab_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Habilitar botones de Editar
                //Eliminar y Editar
                //tambien deshabilita el boton de Agregar

                this.btnAgregar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnEliminar.Enabled = true;
                this.btnLimpiar.Enabled = true;

                if (this.dgvDedPercColab.SelectedRows.Count == 1)
                {
                    //Crear instancia de Deducciones_Percepciones_Por_Colaborador
                    Deducciones_Percepciones_Por_Colaborador oDecPercCola = new Deducciones_Percepciones_Por_Colaborador();
                    //Asignar la fila seleccionada del datagridview al objeto oDecPercCola
                    oDecPercCola = this.dgvDedPercColab.SelectedRows[0].DataBoundItem as Deducciones_Percepciones_Por_Colaborador;
                    //Asignar a cada control los datos del supervisor

                    this.cmbDedPercCol.Enabled = true;
                    this.cmbDedPercCol.Items.Clear();
                    this.cmbDedPercCol.Items.Add(oDecPercCola.CodigoDeduccionPercepcion);
                    this.cmbDedPercCol.SelectedItem = oDecPercCola.CodigoDeduccionPercepcion;
                    this.cmbDedPercCol.Enabled = false;

                    this.cmbPrioridad.Text = oDecPercCola.Prioridad.ToString();

                    this.lstDedPercPorColab.Items.Clear();

                    foreach (var item in BLL.BLLColaborador.SELECTColaboradoresmismaDeduccionPercepcion())
                    {
                        listaAgregarDeduccionPercepcionColaborador.Add(item);
                    }
                    RefrescarListaAgregarDeduccionPercepcionColaborador();
                }
            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");

            }
        }

        /// <summary>
        /// Evento del botón confirmar para
        /// crear o actualizar una deducción/percepción
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Validar que todos los campos del form estén correctamente
            //agregados para poder crear o actualizar el supervisor
            if (!ValidarCampos())
            {
                return;
            }

            //Llamar al método que crea y actualiza los usuarios
            CrearActualizarDeduccionPercepcionPorColaborador();
            LimpiarControles();
        }

        /// <summary>
        /// Método para crear los supervisores y de igual manera actualizarlos
        /// </summary>
        private void CrearActualizarDeduccionPercepcionPorColaborador()
        {

            Deducciones_Percepciones_Por_Colaborador oDedPercCol;
            foreach (var item in lstDedPercPorColab.Items)
            {
                //Crear la instancia de Supervisor

                oDedPercCol = new Deducciones_Percepciones_Por_Colaborador();
                oDedPercCol.CodigoDeduccionPercepcion = this.cmbDedPercCol.SelectedItem as Deducciones_Percepciones;
                oDedPercCol.IdColaborador = item as Colaborador;
                oDedPercCol.Prioridad = (PrioridadDeduccionPercepcion)this.cmbPrioridad.SelectedItem;

                if (BLLDeducciones_Percepciones_Por_Colaborador.SelectById(oDedPercCol.CodigoDeduccionPercepcion.CodigoDeduccionPercepcion, oDedPercCol.IdColaborador.IDColaborador) != null)
                {

                    BLLDeducciones_Percepciones_Por_Colaborador.Update(oDedPercCol);
                }
                else
                {
                    BLLDeducciones_Percepciones_Por_Colaborador.Create(oDedPercCol);
                }

            }

            //Se llama al método Create del Supervisor 
            //que se encarga de revisar si el supervisor existe primero
            //antes de agregar al supervisor

            //Insertar el usuario a la base de datos
            //por medio del BLLSupervisor (método CREATE)

            //Refrescar las listas
            CargarListaColaboradoresyDataGridView();

            //Ocultar el boton de confirmar
            this.btnConfirmar.Visible = false;

            //Limpiar los controles
            LimpiarControles();

        }

        /// <summary>
        /// Método que se encarga de validar los campos 
        /// en los controles
        /// </summary>
        /// <returns></returns>
        private bool ValidarCampos()
        {
            bool correcto = false;
            try
            {
                correcto = true;
                foreach (Control c in this.Controls)
                {
                    this.errProv1.SetError(c, String.Empty);
                    this.errProv1.Clear();
                }
                //Validar Codigo deduccion/percepcion
                if (this.cmbDedPercCol.SelectedItem != null)
                {
                    this.errProv1.SetError(this.cmbDedPercCol, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbDedPercCol, "Campo Deducción/Percepción no es correcto");
                    return false;
                }

                // Validar Prioridad
                if (this.cmbPrioridad.SelectedItem != null)
                {
                    this.errProv1.SetError(this.cmbPrioridad, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbPrioridad, "Campo Prioridad no es correcto");
                    return false;
                }

                //Validar colaboradores en la lista 

                if (this.lstDedPercPorColab.Items.Count != 0)
                {
                    this.errProv1.SetError(this.cmbPrioridad, string.Empty);

                }
                else
                {
                    this.errProv1.SetError(this.lstDedPercPorColab, "¡No hay colaboradores para agregar. Debe agregarlos a la lista de la derecha.");
                    return false;
                }
            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");

            }
            return correcto;
        }

        /// <summary>
        /// Evento del botón Agregar para agregar al 
        /// usuario exitosamente a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    this.errProv1.SetError(c, String.Empty);
                    this.errProv1.Clear();
                }
                ResetearForm('C');

                //Habilitar el boton Confirmar

                this.btnConfirmar.Visible = true;
            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");
            }

        }

        /// <summary>
        /// Método para configurar el estado de los controles
        /// dependiendo del proceso CRUD a procesar
        /// </summary>
        /// <param name="opcion"></param>
        private void ResetearForm(char opcion)
        {
            try
            {

                //habilitar y deshabilitar los controles basado 
                //en el proceso del CRUD a ejecutar

                switch (opcion)
                {
                    case 'C':
                        //habiitar los botones de limpiar, 
                        //agregar y salir
                        this.btnAgregar.Enabled = true;
                        this.btnLimpiar.Enabled = true;
                        this.btnSalir.Enabled = true;

                        //habilitar los controles de texto (txtBox)
                        //y los botones para agregar y quitar en la lista

                        this.cmbDedPercCol.Enabled = true;
                        this.cmbPrioridad.Enabled = true;
                        this.btnQuitarColab.Enabled = true;
                        VerificarHayColaboradores();
                        this.lstColaboradoresALL.Enabled = true;
                        this.lstDedPercPorColab.Enabled = true;
                        break;

                    case 'U':
                        //habiitar los botones de limpiar, 
                        //y salir
                        this.btnSalir.Enabled = true;
                        this.btnLimpiar.Enabled = true;

                        //habilitar los controles de texto (txtBox)
                        //y los botones para agregar y quitar en la lista

                        this.cmbDedPercCol.Enabled = false;
                        this.cmbPrioridad.Enabled = true;
                        this.btnQuitarColab.Enabled = true;
                        VerificarHayColaboradores();
                        this.lstColaboradoresALL.Enabled = true;
                        this.lstDedPercPorColab.Enabled = true;
                        break;

                }
            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");

            }

        }
        /// <summary>
        /// Método para verificar si hay colaboradores disponibles en 
        /// la empresa para asignarles una deducción o percepción
        /// </summary>
        /// <returns></returns>
        private void VerificarHayColaboradores()
        {

            //Validar si la lista all colaboradores está vacía

            if (this.lstColaboradoresALL.Items.Count == 0)
            {
                this.errProv1.SetError(this.lstColaboradoresALL, "¡No hay colaboradores para agregar, debe agregarlos" +
                    " en mantenimiento de Colaboradores");
                this.btnAgregarCol.Enabled = false;
                this.btnQuitarColab.Enabled = false;
                return;
            }
            else
            {
                this.btnAgregarCol.Enabled = true;
                this.btnQuitarColab.Enabled = true;
                return;
            }
        }

        /// <summary>
        /// Evento del botón Editar para eliminar la deducción/percepción
        /// por colaborador exitosamente en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            ResetearForm('U');
            this.btnConfirmar.Visible = true;
        }

        /// <summary>
        /// Evento del botón Eliminar para eliminar al 
        /// supervisor exitosamente en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            string codigoDeduccionPercepcion = this.cmbDedPercCol.Text;
            DialogResult resultado = MessageBox.Show("¿Está seguro(a) que desea eliminar el supervisor?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                foreach (Colaborador item in lstDedPercPorColab.Items)
                {
                    //Crear la instancia de Supervisor

                    BLLDeducciones_Percepciones_Por_Colaborador.Delete(codigoDeduccionPercepcion, item.IDColaborador);

                }
                this.cmbDedPercCol.Text = "";
                CargarListaColaboradoresyDataGridView();
                LimpiarControles();
            }


        }

        /// <summary>
        /// Método para limpiar todos los controles 
        /// cuando se carga el form por primera vez (mediante el load)
        /// </summary>
        private void LimpiarControles()
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    this.errProv1.SetError(c, String.Empty);
                    this.errProv1.Clear();
                }

                this.cmbDedPercCol.SelectedIndex = -1;

                this.cmbPrioridad.SelectedIndex = -1;

                this.lstDedPercPorColab.Items.Clear();
                this.lstColaboradoresALL.BackColor = Color.White;

                InhabilitarControles();

            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");

            }
        }

        /// <summary>
        /// Método para inhabilitar los controles (botones y campos de texto)
        /// </summary>
        private void InhabilitarControles()
        {
            try
            {
                this.btnAgregar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnLimpiar.Enabled = false;
                this.btnConfirmar.Visible = false;
                this.btnAgregarCol.Enabled = false;
                this.btnQuitarColab.Enabled = false;
                this.lstColaboradoresALL.Enabled = false;
                this.lstDedPercPorColab.Enabled = false;

                this.cmbDedPercCol.Enabled = false;
                this.cmbPrioridad.Enabled = false;

            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");

            }

        }

        /// <summary>
        /// Evento para borrar el error provider en la lista 
        /// de deducción/percepción si se selecciona un objeto colaborador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstColaboradoresALL_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.lstColaboradoresALL.SelectedItem != null)
            {
                this.errProv1.SetError(this.lstColaboradoresALL, string.Empty);
                this.lstColaboradoresALL.BackColor = Color.White;
                this.btnAgregarCol.Enabled = true;
            }
        }

        /// <summary>
        /// Evento para borrar el error provider en la lista 
        /// de colaboradores por supervisor si se selecciona un objeto colaborador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstDedPercPorColab_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.lstDedPercPorColab.SelectedItem != null)
            {
                this.errProv1.SetError(this.lstDedPercPorColab, string.Empty);
                this.lstDedPercPorColab.BackColor = Color.White;
                this.btnQuitarColab.Enabled = true;
            }
        }

        /// <summary>
        /// Evento para cerrar el form de Mantenimiento de 
        /// Supervisores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento del botón Limpiar para limpiar los campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
    }
}
