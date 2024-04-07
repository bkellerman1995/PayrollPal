using PayrollPal.Layers;
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

namespace PayrollPal.UI.Mantenimientos
{
    public partial class frmMantenimientoSolicitudVacaciones : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        public frmMantenimientoSolicitudVacaciones()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método load del form 
        /// de mantenimiento de solicitudes 
        /// de vacaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMantenimientoSolicitudVacaciones_Load(object sender, EventArgs e)
        {
            try
            {
                //Cargar el datagridview de usuarios con el SELECT_ALL 
                //del DALUsuario

                CargarListas();
                CargarCombos();

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
        /// de solicitudes de vacaciones desde la base de datos 
        /// y cargarlo al datagridview
        /// </summary>
        private void CargarListas()
        {
            try
            {
                this.dgvSolicitud.DataSource = BLLSolicitudVacaciones.SelectAll();
                this.dgvSolicitud.ClearSelection();

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

        private void CargarCombos()
        {
            List<Colaborador> listaColab = BLLColaborador.SelectSoloColaboradores();
            foreach (var colab in listaColab)
            {
                this.cmbColaborador.Items.Add(colab);
            }

            foreach (ObservacionSolicVacaciones obs in Enum.GetValues(typeof(ObservacionSolicVacaciones)))
            {
                this.cmbObservacionesFinales.Items.Add(obs);
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
                this.mktID.Clear();
                this.mktID.BackColor = Color.White;

                this.cmbColaborador.SelectedIndex = -1;

                //Método para configurar los valores de los datetimepicker
                ConfigurarDateTimePickerFechaSolicitud();
                ConfigurarDateTimePickerFechaDesde();
                ConfigurarDateTimePickerFechaHasta();

                this.txtCantDias.Text = "";

                this.txtObservaciones.Text = "";

                this.cmbObservacionesFinales.SelectedIndex = -1;

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

                this.mktID.Enabled = false;
                this.cmbColaborador.Enabled = false;
                this.dtpFechaSolicitud.Enabled = false;
                this.dtpFechaDesde.Enabled = false;
                this.dtpFechaHasta.Enabled = false;
                this.txtCantDias.Enabled = false;
                this.txtObservaciones.Enabled = false;
                this.cmbObservacionesFinales.Enabled = false;

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
        /// Método para configurar el datetimepicker de "fecha desde" 
        /// para que la fecha mínima sea hoy al igual que la fecha máxima
        /// </summary>
        private void ConfigurarDateTimePickerFechaSolicitud()
        {
            this.dtpFechaSolicitud.MinDate = DateTime.Today;
            this.dtpFechaSolicitud.MaxDate = this.dtpFechaSolicitud.MinDate;
            this.dtpFechaHasta.Value = this.dtpFechaSolicitud.MinDate;
            this.dtpFechaSolicitud.CustomFormat = "dd/MM/yyyy";

        }

        /// <summary>
        /// Método para configurar el datetimepicker de "fecha desde" 
        /// para que la fecha mínima sea el día siguiente
        /// </summary>
        private void ConfigurarDateTimePickerFechaDesde()
        {

            this.dtpFechaDesde.MinDate = DateTime.Today.AddDays(1);
            this.dtpFechaHasta.Value = DateTime.Today;
            this.dtpFechaDesde.CustomFormat = "dd/MM/yyyy";

        }

        /// <summary>
        /// Método para configurar el datetimepicker de "fecha hasta" 
        /// para que la fecha mínima sea el día siguiente (+ 23h:59m:59s)
        /// </summary>
        private void ConfigurarDateTimePickerFechaHasta()
        {

            this.dtpFechaHasta.MinDate = DateTime.Today.AddDays(1).AddHours(23).AddMinutes(59).AddSeconds(59);
            this.dtpFechaHasta.Value = this.dtpFechaHasta.MinDate;
            this.dtpFechaHasta.CustomFormat = "dd/MM/yyyy";

        }


        private void dtpFechaSolicitud_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = this.dtpFechaSolicitud.Value;
            this.dtpFechaSolicitud.MaxDate = EliminarSabadoDomingo(fechaSeleccionada);
            this.dtpFechaSolicitud.MinDate = EliminarSabadoDomingo(fechaSeleccionada);
            this.dtpFechaSolicitud.Value = EliminarSabadoDomingo(fechaSeleccionada);

        }


        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = this.dtpFechaDesde.Value;
            this.dtpFechaDesde.MaxDate = EliminarSabadoDomingo(fechaSeleccionada);
            this.dtpFechaDesde.MinDate = EliminarSabadoDomingo(fechaSeleccionada);
            this.dtpFechaDesde.Value = EliminarSabadoDomingo(fechaSeleccionada);

        }


        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = this.dtpFechaHasta.Value;
            this.dtpFechaHasta.MaxDate = EliminarSabadoDomingo(fechaSeleccionada);
            this.dtpFechaHasta.MinDate = EliminarSabadoDomingo(fechaSeleccionada);
            this.dtpFechaHasta.Value = EliminarSabadoDomingo(fechaSeleccionada);

        }


        private DateTime EliminarSabadoDomingo(DateTime finDeSemana)
        {
            // Si la fecha seleccionada es Sábado, devuelve el lunes hábil 
            if (finDeSemana.DayOfWeek == DayOfWeek.Saturday)
            {
                return finDeSemana.AddDays(2); // 2 días hábil después (Lunes)
            }

            // Si la fecha seleccionada es Domingo, devuelve el lunes hábil 
            else if (finDeSemana.DayOfWeek == DayOfWeek.Sunday)
            {
                return finDeSemana.AddDays(1); // 1 día hábil después (Lunes)
            }
            // Para otros días, devolver la misma fecha
            else
            {
                return finDeSemana;
            }
        }

        private void CalcularCantidadDeDias()
        {
            int cantDias = 0;

            if (this.dtpFechaDesde.Value.Day == this.dtpFechaHasta.Value.Day)
            {
                cantDias = 1;
            }
            else
            {
                cantDias = this.dtpFechaHasta.Value.Day - this.dtpFechaDesde.Value.Day;
            }

            this.txtCantDias.Text = cantDias.ToString();
        }

        /// <summary>
        /// Evento que se encarga de seleccionar 
        /// el objeto usuario en el datagrid view 
        /// y cargarlo en los campos respectivos
        /// del form (para editar o borrar o simplemente ver)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSolicitud_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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

                if (this.dgvSolicitud.SelectedRows.Count == 1)
                {
                    //Crear instancia de solicitud de Vacaciones
                    SolicitudVacaciones oSolicitud = new SolicitudVacaciones();
                    //Asignar la fila seleccionada del datagridview al objeto solicitudVacaciones
                    oSolicitud = this.dgvSolicitud.SelectedRows[0].DataBoundItem as SolicitudVacaciones;
                    //Asignar a cada control los datos de la solicitudDeVacaciones
                    this.mktID.Text = oSolicitud.IDSolicitudVacas.ToString();
                    this.cmbColaborador.Text = oSolicitud.IDColaborador.ToString();
                    this.dtpFechaSolicitud.Value = oSolicitud.FechaSolicitud;
                    this.dtpFechaDesde.Value = oSolicitud.FechaSolicitarDesde;
                    this.dtpFechaHasta.Value = oSolicitud.FechaSolicitarHasta;
                    this.txtCantDias.Text = oSolicitud.CantidadDias.ToString();
                    this.txtObservaciones.Text = oSolicitud.Observaciones.ToString();

                    if (oSolicitud.Estado == true)
                        this.rdbActiva.Checked = true;
                    if (oSolicitud.Estado == false)
                        this.rdbInactiva.Checked = true;

                    this.cmbObservacionesFinales.Text = oSolicitud.Observaciones_Final.ToString();
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
        /// crear o actualizar una solicitudVacaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Validar que todos los campos del form (ID, usuario, contraseña y
            //su comprobación se agreguen correctamente
            if (!ValidarCampos())
            {
                return;
            }
            CalcularCantidadDeDias();
            //Llamar al método que crea y actualiza los usuarios
            CrearActualizarSolicitudVacaciones();
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

                //ValidarID de la solicitud Vacaciones
                if (this.mktID.MaskCompleted)
                {
                    this.errProv1.SetError(this.mktID, string.Empty);

                }
                else
                {
                    this.errProv1.SetError(this.mktID, "Campo ID de solicitud de vacaciones no es correcto");
                    return false;
                }

                // Validar Colaborador

                if (this.cmbColaborador.SelectedIndex >= 0)
                {
                    this.errProv1.SetError(this.cmbColaborador, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbColaborador, "Debe seleccionar un Colaborador");
                    return false;
                }

                //Validar Observaciones

                if (!String.IsNullOrEmpty(this.txtObservaciones.Text.Trim()))
                {
                    this.errProv1.SetError(this.txtObservaciones, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.txtObservaciones, "Campo observaciones de vacaciones no es correcto");
                    return false;
                }

                // Validar estado Final

                if (this.cmbObservacionesFinales.SelectedIndex >= 0)
                {
                    this.errProv1.SetError(this.cmbObservacionesFinales, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbObservacionesFinales, "Debe seleccionar un estado final de la solicitud");
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
        /// Método para crear los usuarios y de igual manera actualizarlos
        /// </summary>
        private void CrearActualizarSolicitudVacaciones()
        {
            //Crear la instancia de SolicitudVacaciones
            SolicitudVacaciones oSolicitud = new SolicitudVacaciones();


            oSolicitud.IDSolicitudVacas = this.mktID.Text;
            oSolicitud.IDColaborador = this.cmbColaborador.SelectedItem as Colaborador;
            oSolicitud.FechaSolicitud = this.dtpFechaSolicitud.Value;
            oSolicitud.FechaSolicitarDesde = this.dtpFechaDesde.Value;
            oSolicitud.FechaSolicitarHasta = this.dtpFechaHasta.Value;
            oSolicitud.CantidadDias = int.Parse(this.txtCantDias.Text);
            oSolicitud.Observaciones = this.txtObservaciones.Text;

            if (this.rdbActiva.Checked)
                oSolicitud.Estado = true;
            if (this.rdbInactiva.Checked)
                oSolicitud.Estado = false;

            oSolicitud.Observaciones_Final = (ObservacionSolicVacaciones)this.cmbObservacionesFinales.SelectedItem;

            //Se llama al método Create del Usuario 
            //que se encarga de revisar si el usuario existe primero
            //antes de agregar al usuario

            if (BLLSolicitudVacaciones.SelectById(this.mktID.Text) != null)
            {

                BLLSolicitudVacaciones.Update(oSolicitud);
            }
            else
            {
                BLLSolicitudVacaciones.Create(oSolicitud);
            }

            //Insertar el usuario a la base de datos
            //por medio del BLLUsuario (método CREATE)

            //Refrescar la lista
            CargarListas();

            //Ocultar el boton de confirmar
            this.btnConfirmar.Visible = false;

            //Limpiar los controles
            LimpiarControles();

        }

        /// <summary>
        /// Evento para revisar si el campo del
        /// ID es correcto mientras se va escribiendo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mktID_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.mktID.MaskCompleted)
            {
                this.errProv1.SetError(this.mktID, string.Empty);
                this.mktID.BackColor = Color.Honeydew;
            }
            else
            {
                this.errProv1.SetError(this.mktID, "Campo ID de solicitud no es correcto");
                this.mktID.BackColor = Color.MistyRose;
            }
        }

        /// <summary>
        /// Evento para revisar si el campo del
        /// ID es correcto mientras se va escribiendo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtObservaciones_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtObservaciones.Text.Trim()))
            {
                this.errProv1.SetError(this.txtObservaciones, string.Empty);
                this.txtObservaciones.BackColor = Color.Honeydew;
            }
            else
            {
                this.errProv1.SetError(this.mktID, "Campo observaciones de solicitud no es correcto");
                this.txtObservaciones.BackColor = Color.MistyRose;
            }
        }

        /// <summary>
        /// Evento para ocultar la contraseña del usuario en el datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSolicitud_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == 7 && e.Value != null)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "Activa";
                if (e.Value.ToString() == "False")
                    e.Value = "Inactiva";
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

                        this.mktID.Enabled = true;
                        this.cmbColaborador.Enabled = true;
                        this.dtpFechaSolicitud.Enabled = true;
                        this.dtpFechaDesde.Enabled = true;
                        this.dtpFechaHasta.Enabled = true;
                        this.txtCantDias.Enabled = true;
                        this.txtObservaciones.Enabled = true;
                        this.cmbObservacionesFinales.Enabled = true;
                        this.rdbActiva.Enabled = true;
                        this.rdbInactiva.Enabled = true;
                        break;

                    case 'U':
                        //habiitar los botones de limpiar, 
                        //y salir
                        this.btnLimpiar.Enabled = true;
                        this.btnSalir.Enabled = true;

                        //habilitar los controles de texto (txtBox)

                        this.mktID.ReadOnly = true;
                        this.cmbColaborador.Enabled = true;
                        this.dtpFechaSolicitud.Enabled = true;
                        this.dtpFechaDesde.Enabled = true;
                        this.dtpFechaHasta.Enabled = true;
                        this.txtCantDias.Enabled = true;
                        this.txtObservaciones.Enabled = true;
                        this.cmbObservacionesFinales.Enabled = true;
                        this.rdbActiva.Enabled = true;
                        this.rdbInactiva.Enabled = true;
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
        /// Evento del botón Editar para editar al 
        /// usuario exitosamente en la base de datos
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
        /// usuario exitosamente en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idSolicitud = this.mktID.Text;
            DialogResult resultado = MessageBox.Show("¿Está seguro(a) que desea eliminar la solicitud de Vacaciones?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                BLLUsuario.Delete(idSolicitud);
                CargarListas();
                LimpiarControles();
            }


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

        /// <summary>
        /// Evento para cerrar el form de Mantenimiento de 
        /// Usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
