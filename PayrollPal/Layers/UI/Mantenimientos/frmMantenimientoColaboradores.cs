using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using PayrollPal.Entities;
using PayrollPal.Layers;
using PayrollPal.Layers.BLL;
using PayrollPal.Layers.Entities;
using PayrollPal.Layers.IBLL;
using PayrollPal.Layers.UI;
using PayrollPal.Layers.Util;

namespace PayrollPal.UI.Mantenimientos
{
    public partial class frmMantenimientoColaboradores : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        IBLLDepartamento bLLDepartamento = new BLLDepartamento();
        IBLLUsuario bLLUsuario = new BLLUsuario();
        IBLLPuesto bLLPuesto = new BLLPuesto();
        IBLLRol bLLRol = new BLLRol();
        IBLLColaborador bLLColaborador = new BLLColaborador();
        IBLLSupervisor bLLSupervisor = new BLLSupervisor();
        IBLLSolicitudVacaciones bLLSolicitudVacaciones = new BLLSolicitudVacaciones();
        IBLLDeducciones_Percepciones_Por_Colaborador bLLDeducciones_Percepciones_Por_Colaborador = new BLLDeducciones_Percepciones_Por_Colaborador();
        IBLLControlDeMarcas bLLControlDeMarcas = new BLLControlDeMarcas();
        IBLLPlanilla_Detalle bLLPlanilla_Detalle = new BLLPlanilla_Detalle();
        public frmMantenimientoColaboradores()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para cerrar el form de Mantenimiento de 
        /// Colaboradores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Método load del form 
        /// de mantenimiento de colaboradores 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frmMantenimientoColaboradores_Load(object sender, EventArgs e)
        {
            try
            {
                this.tslblUsuarioConectado.Text = "Usuario Conectado: " + frmLogin.colaboradorLoggeado.IDUsuario.IDUsuario +
    " Rol: " + frmLogin.colaboradorLoggeado.IDRol.Descripcion;
                //Cargar el datagridview de usuarios con el SELECT_ALL 
                //del DALColaborador

                this.cmbIDSup.Visible = false;
                this.lblIDSupervisor.Visible = false;
                CargarLista();
                CargarCombos();

                //Limpiar los controles del form 
                LimpiarControles();
                RevisarCombosVacios();
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

        private void RevisarCombosVacios()
        {

            if (bLLDepartamento.SelectAll().Count != 0)
            {
                this.errProv1.SetError(this.cmbDepartamento, string.Empty);
            }
            else
            {
                this.errProv1.SetError(this.cmbDepartamento, "No puede agregar colaboradores sin departamento");

            }

            if (bLLUsuario.SelectAllNoAsignado().Count != 0)
            {
                this.errProv1.SetError(this.cmbUsuario, string.Empty);
            }
            else
            {
                this.errProv1.SetError(this.cmbUsuario, "No puede agregar colaboradores sin usuario");

            }

            if (bLLPuesto.SelectAll().Where(puesto => puesto.Estado == true).ToList().Count != 0)
            {
                this.errProv1.SetError(this.cmbPuestos, string.Empty);
            }
            else
            {
                this.errProv1.SetError(this.cmbPuestos, "No puede agregar colaboradores sin puesto");

            }

            if (bLLRol.SelectAll().Count != 0)
            {
                this.errProv1.SetError(this.cmbRol, string.Empty);
            }
            else
            {
                this.errProv1.SetError(this.cmbRol, "No puede agregar colaboradores sin rol");

            }

            if (frmLogin.colaboradorLoggeado.IDRol.IDRol == 2)
            {
                if (bLLSupervisor.SelectAllNoAsignado().Count != 0)
                {
                    this.errProv1.SetError(this.cmbUsuario, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbUsuario, "No puede agregar un colaboradr como supervisorBuscar sin supervisorBuscar");

                }
            }
        }

        /// <summary>
        /// Método que se encarga de cargar la lista 
        /// de colaboradores desde la base de datos 
        /// y cargarlo al datagridview
        /// </summary>
        private void CargarLista()
        {
            try
            {

                this.dgvColaboradores.DataSource = bLLColaborador.SelectAll();
                this.dgvColaboradores.ClearSelection();
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
        /// Método que se encarga de cargar los combos de Puesto, Rol y Supervisor
        /// </summary>
        private void CargarCombos()
        {

            this.cmbDepartamento.DataSource = bLLDepartamento.SelectAll();

            List<Usuario> listaUsuariosNoAsignados = bLLUsuario.SelectAllNoAsignado();

            foreach (var item in listaUsuariosNoAsignados)
            {
                this.cmbUsuario.Items.Add(item);
            }

            foreach (var item in bLLSupervisor.SelectAllNoAsignado())
            {
                this.cmbIDSup.Items.Add(item.IDSupervisor);
            }

            foreach (var item in bLLSupervisor.SelectAll())
            {
                this.cmbSupervisor.Items.Add(item);
            }

            foreach (var item in bLLPuesto.SelectAll().Where(pto => pto.Estado == true).ToList())
            {
                this.cmbPuestos.Items.Add(item);
            }

            foreach (var item in bLLRol.SelectAll())
            {
                this.cmbRol.Items.Add(item);
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

                if (this.dgvColaboradores.SelectedRows.Count == 1)
                {
                    Colaborador oColaborador = new Colaborador();
                    oColaborador = this.dgvColaboradores.SelectedRows[0].DataBoundItem as Colaborador;

                    foreach (var sup in this.cmbIDSup.Items)
                    {
                        if (sup.ToString() == oColaborador.supID)
                        {
                            this.cmbIDSup.Items.Remove(sup);
                            break;
                        }
                    }
                }



                this.txtID.Text = "col";
                this.txtID.BackColor = Color.White;

                this.txtNombre.Clear();
                this.txtNombre.BackColor = Color.White;

                this.txtApellido1.Clear();
                this.txtApellido1.BackColor = Color.White;

                this.txtApellido2.Clear();
                this.txtApellido2.BackColor = Color.White;

                //Método para configurar los valores de los datetimepicker
                ConfigurarDateTimePickerFechaNacimiento();
                ConfigurarDateTimePickerFechaIngreso();

                this.txtDireccion.Clear();
                this.txtDireccion.BackColor = Color.White;


                this.mktSalarioHora.Clear();
                this.mktSalarioHora.BackColor = Color.White;

                this.txtCorreoElectronico.Clear();
                this.txtCorreoElectronico.BackColor = Color.White;

                this.cmbDepartamento.SelectedIndex = -1;
                this.cmbUsuario.SelectedIndex = -1;
                this.cmbPuestos.SelectedIndex = -1;
                this.cmbRol.SelectedIndex = -1;




                this.lblSupervisor.Visible = false;
                this.cmbSupervisor.Visible = false;

                this.mktCuentaIBAN.Clear();
                this.mktCuentaIBAN.BackColor = Color.White;

                this.pctFoto.Image = PayrollPal.Properties.Resources.Colaborador_Generico;

                this.rdbActivo.Checked = true;

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
                this.btnCargarFoto.Enabled = false;

                this.txtID.Enabled = false;
                this.txtNombre.Enabled = false;
                this.txtApellido1.Enabled = false;
                this.txtApellido2.Enabled = false;
                this.txtDireccion.Enabled = false;
                this.mktSalarioHora.Enabled = false;
                this.txtCorreoElectronico.Enabled = false;
                this.mktCuentaIBAN.Enabled = false;

                this.dtpFechaNacimiento.Enabled = false;
                this.dtpFechaIngreso.Enabled = false;

                this.cmbDepartamento.Enabled = false;
                this.cmbUsuario.Enabled = false;
                this.cmbPuestos.Enabled = false;
                this.cmbRol.Enabled = false;
                this.cmbSupervisor.Enabled = false;
                this.cmbIDSup.Enabled = false;


                this.pctFoto.Enabled = false;

                this.rdbActivo.Enabled = false;
                this.rdbInactivo.Enabled = false;
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
        /// Método para configurar el datetimepicker de fecha de nacimiento
        /// para que la fecha mínima de nacimiento
        /// sea 18 años y la máxima 65
        /// </summary>
        private void ConfigurarDateTimePickerFechaNacimiento()
        {
            this.dtpFechaNacimiento.MinDate = DateTime.Today.AddYears(-65);
            this.dtpFechaNacimiento.MaxDate = DateTime.Today.AddYears(-18);
            this.dtpFechaNacimiento.Value = this.dtpFechaNacimiento.MinDate;
            this.dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
        }

        /// <summary>
        /// Método para configurar el datetimepicker de fecha de ingreso
        /// para que la fecha mínima de ingreso
        /// sea 10 años y la máxima hoy
        /// </summary>
        private void ConfigurarDateTimePickerFechaIngreso()
        {
            this.dtpFechaIngreso.MinDate = DateTime.Today.AddYears(-10);
            this.dtpFechaIngreso.MaxDate = DateTime.Today;
            this.dtpFechaIngreso.Value = DateTime.Today;
            this.dtpFechaIngreso.CustomFormat = "dd/MM/yyyy";

        }

        /// <summary>
        /// Evento del botón Agregar para agregar al 
        /// colaborador exitosamente a la base de datos
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
                this.btnCargarFoto.Enabled = true;
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
                        this.btnAgregar.Enabled = false;
                        this.btnLimpiar.Enabled = true;
                        this.btnSalir.Enabled = true;
                        this.txtID.Text = this.txtID.Text + bLLColaborador.SecuenciadorColaborador();

                        //habilitar los controles de texto, comboboxes
                        //pictureBox 

                        this.txtID.Enabled = true;
                        this.txtNombre.Enabled = true;
                        this.txtApellido1.Enabled = true;
                        this.txtApellido2.Enabled = true;
                        ConfigurarDateTimePickerFechaIngreso();
                        ConfigurarDateTimePickerFechaNacimiento();
                        this.txtDireccion.Enabled = true;
                        this.dtpFechaIngreso.Enabled = true;
                        this.cmbDepartamento.Enabled = true;
                        this.mktSalarioHora.Enabled = true;
                        this.txtCorreoElectronico.Enabled = true;
                        this.mktCuentaIBAN.Enabled = true;
                        this.cmbUsuario.Enabled = true;
                        this.cmbPuestos.Enabled = true;
                        this.cmbRol.Enabled = true;
                        this.cmbSupervisor.Enabled = true;
                        this.cmbIDSup.Enabled = true;
                        this.pctFoto.Enabled = true;
                        this.btnCargarFoto.Enabled = true;
                        this.rdbActivo.Enabled = true;
                        this.rdbInactivo.Enabled = true;


                        break;

                    case 'U':

                        //habilitar los controles de texto, comboboxes
                        //pictureBox 

                        this.txtID.ReadOnly = true;
                        this.txtNombre.Enabled = true;
                        this.txtApellido1.Enabled = true;
                        this.txtApellido2.Enabled = true;
                        this.dtpFechaNacimiento.Enabled = true;
                        ConfigurarDateTimePickerFechaIngreso();
                        ConfigurarDateTimePickerFechaNacimiento();
                        this.txtDireccion.Enabled = true;
                        this.dtpFechaIngreso.Enabled = true;
                        this.cmbDepartamento.Enabled = true;
                        this.mktSalarioHora.Enabled = true;
                        this.txtCorreoElectronico.Enabled = true;
                        this.mktCuentaIBAN.Enabled = true;
                        this.cmbUsuario.Enabled = true;
                        this.cmbPuestos.Enabled = true;
                        this.cmbRol.Enabled = true;
                        this.cmbSupervisor.Enabled = true;
                        this.cmbIDSup.Enabled = true;
                        this.pctFoto.Enabled = true;
                        this.btnCargarFoto.Enabled = true;
                        this.rdbActivo.Enabled = true;
                        this.rdbInactivo.Enabled = true;
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
        /// Evento del botón confirmar para
        /// crear o actualizar un colaborador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Validar que todos los campos del form estén correctamente llenados 
            //para agregar o actualizar el colaborador correctamente
            if (!ValidarCampos())
            {
                return;
            }

            //Llamar al método que crea y actualiza los usuarios
            CrearActualizarColaborador();
            LimpiarControles();
        }

        /// <summary>
        /// Método que se encarga de validar los campos 
        /// en los controles
        /// </summary>
        /// <returns></returns>
        private bool ValidarCampos()
        {
            Colaborador oColaborador = new Colaborador();
            oColaborador = this.dgvColaboradores.SelectedRows[0].DataBoundItem as Colaborador;
            bool correcto = false;
            try
            {
                correcto = true;
                foreach (Control c in this.Controls)
                {
                    this.errProv1.SetError(c, String.Empty);
                    this.errProv1.Clear();
                }


                // Validar Nombre
                if (!String.IsNullOrEmpty(this.txtNombre.Text.Trim()))
                {
                    this.errProv1.SetError(this.txtNombre, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.txtNombre, "Campo Nombre de Colaborador no es correcto");
                    return false;
                }

                // Validar Apellido1
                if (!String.IsNullOrEmpty(this.txtApellido1.Text.Trim()))
                {
                    this.errProv1.SetError(this.txtApellido1, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.txtApellido1, "Campo Apellido 1 no es correcto");
                    return false;
                }


                // Validar Apellido2
                if (!String.IsNullOrEmpty(this.txtApellido2.Text.Trim()))
                {
                    this.errProv1.SetError(this.txtApellido2, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.txtApellido2, "Campo Apellido 2 no es correcto");
                    return false;
                }

                //Validar direccion

                if (!String.IsNullOrEmpty(this.txtDireccion.Text.Trim()))
                {
                    this.errProv1.SetError(this.txtDireccion, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.txtDireccion, "Campo Dirección no es correcto");
                    return false;
                }


                //Validar combo Departamento

                if (this.cmbDepartamento.SelectedItem != null)
                {
                    this.errProv1.SetError(this.cmbDepartamento, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbDepartamento, "Campo departamento no es correcto");
                    return false;
                }

                //Validar salario / hora

                if (this.mktSalarioHora.MaskCompleted)
                {
                    this.errProv1.SetError(this.mktSalarioHora, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.mktSalarioHora, "Campo Salario/Hora no es correcto");
                    return false;
                }

                //Validar correo

                if (!String.IsNullOrEmpty(this.txtCorreoElectronico.Text.Trim()))
                {
                    this.errProv1.SetError(this.txtCorreoElectronico, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.txtCorreoElectronico, "Campo correo electrónico no es correcto");
                    return false;
                }

                //Validar cuenta IBAN

                if (!String.IsNullOrEmpty(this.mktCuentaIBAN.Text.Trim()))
                {
                    this.errProv1.SetError(this.mktCuentaIBAN, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.mktCuentaIBAN, "Campo Cuenta IBAN no es correcto");
                    return false;
                }

                //Validar combo Usuario

                if (this.cmbUsuario.SelectedItem != null)
                {
                    this.errProv1.SetError(this.cmbUsuario, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbUsuario, "Campo usuario no es correcto");
                    return false;
                }

                //Validar combo Puesto

                if (this.cmbPuestos.SelectedItem != null)
                {
                    this.errProv1.SetError(this.cmbPuestos, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbPuestos, "Campo puesto no es correcto");
                    return false;
                }

                //Validar combo Rol

                if (this.cmbRol.SelectedItem != null)
                {
                    this.errProv1.SetError(this.cmbRol, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbRol, "Campo rol no es correcto");
                    return false;
                }

                //Validar combo Supervisor

                if (this.cmbSupervisor.SelectedItem != null ||
                    !this.cmbSupervisor.Visible)
                {
                    this.errProv1.SetError(this.cmbSupervisor, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbSupervisor, "Campo supervisorBuscar no es correcto");
                    return false;
                }


                //Validar combo IDSupervisor

                if (oColaborador.IDRol.IDRol == 2)
                {
                    if (this.cmbIDSup.SelectedItem != null && this.cmbIDSup.Visible)
                    {
                        this.errProv1.SetError(this.cmbIDSup, string.Empty);
                    }
                    else
                    {
                        this.errProv1.SetError(this.cmbIDSup, "Campo ID supervisorBuscar no es correcto");
                        return false;
                    }
                }


                //Validar pictureBox de Foto

                if (this.pctFoto.Tag == null)
                {
                    MessageBox.Show("¡La fotografía es requerida!", "Error", MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
                    btnCargarFoto_Click(this, EventArgs.Empty);
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
        /// Método para crear los colaboradores y de igual manera actualizarlos
        /// </summary>
        private void CrearActualizarColaborador()
        {
            //Crear la instancia de Colaborador
            Colaborador oColaborador = new Colaborador();
            char[] reemplazarCaracteresSalario = new char[] { ',', '.' };
            Supervisor supervisorBuscar = new Supervisor();
            Supervisor supervisorDefault = new Supervisor();
            string idColaborador = "";
            Usuario oUsuarioADeshabilitar = new Usuario();
            Supervisor oSupDeshabilitar = new Supervisor();

            oColaborador.IDColaborador = this.txtID.Text;
            idColaborador = oColaborador.IDColaborador;
            oColaborador.Nombre = this.txtNombre.Text;
            oColaborador.Apellido1 = this.txtApellido1.Text;
            oColaborador.Apellido2 = this.txtApellido2.Text;
            oColaborador.Apellido2 = this.txtApellido2.Text;
            oColaborador.FechaNacimiento = this.dtpFechaNacimiento.Value;
            oColaborador.Direccion = this.txtDireccion.Text;
            oColaborador.FechaIngreso = this.dtpFechaIngreso.Value;
            oColaborador.IDDepartamento = (Departamento)this.cmbDepartamento.SelectedItem;
            oColaborador.SalarioHora = decimal.Parse(this.mktSalarioHora.Text);
            oColaborador.CorreoElectronico = this.txtCorreoElectronico.Text;
            oColaborador.CuentaIBAN = this.lblCR.Text + this.mktCuentaIBAN.Text;
            oColaborador.IDUsuario = (Usuario)this.cmbUsuario.SelectedItem;
            oColaborador.Foto = (byte[])pctFoto.Tag;
            if (bLLColaborador.SelectById(idColaborador) != null)
            {
                if (oColaborador.IDUsuario.ToString() == bLLColaborador.SelectById(idColaborador).IDUsuario.ToString())
                {
                    oColaborador.IDUsuario.Contrasenna = Criptografia.DecrypthAES(oColaborador.IDUsuario.Contrasenna);
                }
            }


            oColaborador.IDUsuario.Asignado = true;
            bLLUsuario.Update(oColaborador.IDUsuario);

            oColaborador.CodigoPuesto = (Puesto)this.cmbPuestos.SelectedItem;
            oColaborador.IDRol = (Rol)this.cmbRol.SelectedItem;

            if (this.rdbActivo.Checked)
                oColaborador.Estado = true;
            if (this.rdbInactivo.Checked)
                oColaborador.Estado = false;

            switch (oColaborador.IDRol.IDRol)
            {
                case 1:
                    oColaborador.IDSupervisor = supervisorDefault;
                    oColaborador.supID = "0";
                    break;
                case 2:
                    supervisorBuscar.IDRol = (Rol)this.cmbRol.SelectedItem;
                    oColaborador.supID = this.cmbIDSup.SelectedItem.ToString();
                    supervisorBuscar = bLLSupervisor.SelectById(oColaborador.supID);
                    supervisorBuscar.Asignado = true;
                    bLLSupervisor.Update(supervisorBuscar);
                    oColaborador.IDSupervisor = supervisorDefault;

                    if (oColaborador.Estado == false)
                    {
                        foreach (Colaborador colab in bLLColaborador.SelectAll().Where(
                            col => col.IDSupervisor.IDSupervisor == oColaborador.supID).ToList())
                        {
                            colab.IDSupervisor = supervisorBuscar;
                            bLLColaborador.Update(colab);
                        }
                    }


                    //Si el sypervisor va a cambiarse
                    //debe cambiarse el estado del supervisorBuscar 
                    //que estaba anteriormente asignado 

                    if (oColaborador.supID.ToString() != bLLColaborador.SelectById(idColaborador).supID.ToString())
                    {
                        oSupDeshabilitar = bLLColaborador.SelectById(idColaborador).IDSupervisor;
                        oSupDeshabilitar.Asignado = false;

                        bLLSupervisor.Update(oSupDeshabilitar);
                    }
                    bLLColaborador.Update(oColaborador);

                    break;
                case 3:
                    oColaborador.IDSupervisor = (Supervisor)this.cmbSupervisor.SelectedItem;
                    oColaborador.supID = "0";
                    break;
            }




            //Se llama al método Create del Colaborador 
            //que se encarga de revisar si el colaborador existe primero
            //antes de agregar al colaborador
            if (bLLColaborador.SelectById(idColaborador) != null)
            {
                //Si el usuario va a cambiarse
                //debe cambiarse el estado del usuario 
                //que estaba anteriormente asignado
                if (oColaborador.IDUsuario.ToString() != bLLColaborador.SelectById(idColaborador).IDUsuario.ToString())
                {
                    oUsuarioADeshabilitar = bLLColaborador.SelectById(idColaborador).IDUsuario;
                    oUsuarioADeshabilitar.Asignado = false;
                    oUsuarioADeshabilitar.Contrasenna = Criptografia.DecrypthAES(oUsuarioADeshabilitar.Contrasenna);

                    bLLUsuario.Update(oUsuarioADeshabilitar);
                }
                bLLColaborador.Update(oColaborador);



            }
            else
            {
                bLLColaborador.Create(oColaborador);
            }



            //Insertar el colaborador a la base de datos
            //por medio del BLLColaborador (método CREATE)

            //Refrescar la lista
            CargarLista();

            //Ocultar el boton de confirmar
            this.btnConfirmar.Visible = false;

            //Limpiar los controles
            LimpiarControles();

        }

        /// <summary>
        /// Evento para cargar la foto en el control
        /// Picture Box a través de un OpenFileDialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostrar el Diálogo de archivos
                OpenFileDialog ofd = new OpenFileDialog();
                // Parámetros del dialogo
                ofd.Title = "Seleccione la imagen";
                ofd.SupportMultiDottedExtensions = true;
                ofd.DefaultExt = "*.jpg";
                ofd.Filter = "Archivos de Imagenes (*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ofd.FileName = "";

                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        this.pctFoto.ImageLocation = ofd.FileName;
                        this.pctFoto.SizeMode = PictureBoxSizeMode.StretchImage;

                        byte[] cadenaBytes = File.ReadAllBytes(ofd.FileName);

                        this.pctFoto.Tag = (byte[])cadenaBytes;
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
        /// Evento para revisar si el campo del
        /// nombre es correcto mientras se va escribiendo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtNombre.Text.Trim()))
            {
                this.errProv1.SetError(this.txtNombre, string.Empty);
                this.txtNombre.BackColor = Color.Honeydew;
            }
            else
            {
                this.errProv1.SetError(this.txtNombre, "Campo Nombre de colaborador no es correcto");
                this.txtNombre.BackColor = Color.MistyRose;
            }
        }

        /// <summary>
        /// Evento para revisar si el campo del
        /// apellido1 es correcto mientras se va escribiendo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtApellido1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtApellido1.Text.Trim()))
            {
                this.errProv1.SetError(this.txtApellido1, string.Empty);
                this.txtApellido1.BackColor = Color.Honeydew;
            }
            else
            {
                this.errProv1.SetError(this.txtApellido1, "Campo Apellido1 de colaborador no es correcto");
                this.txtApellido1.BackColor = Color.MistyRose;
            }
        }

        /// <summary>
        /// Evento para revisar si el campo del
        /// apellido2 es correcto mientras se va escribiendo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtApellido2_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtApellido2.Text.Trim()))
            {
                this.errProv1.SetError(this.txtApellido2, string.Empty);
                this.txtApellido2.BackColor = Color.Honeydew;
            }
            else
            {
                this.errProv1.SetError(this.txtApellido2, "Campo Apellido2 de colaborador no es correcto");
                this.txtApellido2.BackColor = Color.MistyRose;
            }
        }

        /// <summary>
        /// Evento para revisar si el campo de
        /// dirección es correcto mientras se va escribiendo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDireccion_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtDireccion.Text.Trim()))
            {
                this.errProv1.SetError(this.txtDireccion, string.Empty);
                this.txtDireccion.BackColor = Color.Honeydew;
            }
            else
            {
                this.errProv1.SetError(this.txtDireccion, "Campo Dirección de colaborador no es correcto");
                this.txtDireccion.BackColor = Color.MistyRose;
            }
        }

        /// <summary>
        /// Evento para revisar si el campo de
        /// salario/hora es correcto mientras se va escribiendo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mktSalarioHora_KeyUp(object sender, KeyEventArgs e)
        {
            if ((this.mktSalarioHora.MaskCompleted))
            {
                this.errProv1.SetError(this.mktSalarioHora, string.Empty);
                this.mktSalarioHora.BackColor = Color.Honeydew;
            }
            else
            {
                this.errProv1.SetError(this.mktSalarioHora, "Campo salario/hora de colaborador no es correcto");
                this.mktSalarioHora.BackColor = Color.MistyRose;
            }
        }

        /// <summary>
        /// Evento para revisar si el campo de
        /// correo electrónico es correcto mientras se va escribiendo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCorreoElectronico_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtCorreoElectronico.Text.Trim()) &&
                LeerDatos.Es_Email(this.txtCorreoElectronico))
            {
                this.errProv1.SetError(this.txtCorreoElectronico, string.Empty);
                this.txtCorreoElectronico.BackColor = Color.Honeydew;
            }
            else
            {
                this.errProv1.SetError(this.txtCorreoElectronico, "Campo Correo electrónico de colaborador no es correcto");
                this.txtCorreoElectronico.BackColor = Color.MistyRose;
            }
        }

        /// <summary>
        /// Evento para revisar si el campo de
        /// cuenta IBAN es correcto mientras se va escribiendo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mktCuentaIBAN_KeyUp(object sender, KeyEventArgs e)
        {
            if ((this.mktCuentaIBAN.MaskCompleted))
            {
                this.errProv1.SetError(this.mktCuentaIBAN, string.Empty);
                this.mktCuentaIBAN.BackColor = Color.Honeydew;
            }
            else
            {
                this.errProv1.SetError(this.mktCuentaIBAN, "Campo cuenta IBAN de colaborador no es correcto");
                this.mktCuentaIBAN.BackColor = Color.MistyRose;
            }
        }

        /// <summary>
        /// Método para habilitar el comboBox de Supervisor y el 
        /// label si el objeto seleccionado en el comboBox de Rol
        /// es colaborador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbRol_SelectedValueChanged(object sender, EventArgs e)
        {
            Rol rol = new Rol();
            if (this.cmbRol.SelectedIndex > 0
                && bLLRol.EsColaborador((Rol)this.cmbRol.SelectedItem))
            {

                this.cmbSupervisor.Visible = true;
                this.lblSupervisor.Visible = true;

                if (bLLSupervisor.SelectAll().Count != 0)
                {
                    this.errProv1.SetError(this.cmbSupervisor, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbSupervisor, "No puede agregar colaboradores sin supervisorBuscar");

                }

            }
            else
            {
                this.cmbSupervisor.Visible = false;
                this.lblSupervisor.Visible = false;
            }
            rol = (Rol)this.cmbRol.SelectedItem;
            if (this.cmbRol.SelectedIndex > 0
                && rol.IDRol == 2)
            {
                this.cmbIDSup.Visible = true;
                this.lblIDSupervisor.Visible = true;
            }
            else
            {
                this.cmbIDSup.Visible = false;
                this.lblIDSupervisor.Visible = false;
            }
        }

        /// <summary>
        /// Metodo que se encarga de formatear la columna que contiene el valor de estado
        /// del colaborador y lo reemplaza a texto amigable
        /// para el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvColaboradores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == 16 && e.Value != null)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "Activa";
                if (e.Value.ToString() == "False")
                    e.Value = "Inactiva";
            }

            if (e.ColumnIndex == 15 && e.Value != null)
            {
                if (e.Value.ToString().Contains("Nulo"))
                    e.Value = "Sin supervisorBuscar";
            }


        }

        /// <summary>
        /// Evento que se encarga de seleccionar 
        /// el objeto colaborador en el datagrid view 
        /// y cargarlo en los campos respectivos
        /// del form (para editar o borrar o simplemente ver)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvColaboradores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Habilitar botones de Editar
                //Eliminar y Editar
                //tambien deshabilita el boton de Agregar

                foreach (Control c in this.Controls)
                {
                    this.errProv1.SetError(c, String.Empty);
                    this.errProv1.Clear();
                }

                this.btnAgregar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnEliminar.Enabled = true;
                this.btnLimpiar.Enabled = true;

                if (this.dgvColaboradores.SelectedRows.Count == 1)
                {
                    //Creamos instancia de colaborador
                    Colaborador oColaborador = new Colaborador();
                    oColaborador = this.dgvColaboradores.SelectedRows[0].DataBoundItem as Colaborador;  //Asignamos el valor seleccionado
                    //Asignamos los valores a cada control
                    this.txtID.Text = oColaborador.IDColaborador.ToString();
                    this.txtNombre.Text = oColaborador.Nombre.ToString();
                    this.txtApellido1.Text = oColaborador.Apellido1.ToString();
                    this.txtApellido2.Text = oColaborador.Apellido2.ToString();
                    this.dtpFechaNacimiento.MinDate = oColaborador.FechaNacimiento;
                    this.dtpFechaNacimiento.Value = oColaborador.FechaNacimiento;
                    this.txtDireccion.Text = oColaborador.Direccion.ToString();
                    this.dtpFechaIngreso.MinDate = oColaborador.FechaIngreso;
                    this.dtpFechaIngreso.Value = oColaborador.FechaIngreso;
                    this.cmbDepartamento.Text = oColaborador.IDDepartamento.ToString();
                    this.mktSalarioHora.Text = oColaborador.SalarioHora.ToString();
                    this.txtCorreoElectronico.Text = oColaborador.CorreoElectronico.ToString();
                    this.mktCuentaIBAN.Text = oColaborador.CuentaIBAN.ToString();
                    refrescarComboUsuario();
                    this.cmbUsuario.Items.Add(oColaborador.IDUsuario);
                    this.cmbUsuario.SelectedItem = (Usuario)oColaborador.IDUsuario;
                    this.cmbPuestos.Text = oColaborador.CodigoPuesto.ToString();
                    this.cmbRol.Text = oColaborador.IDRol.ToString();
                    this.cmbSupervisor.Text = oColaborador.IDSupervisor.ToString();

                    if (oColaborador.Estado == true)
                        this.rdbActivo.Checked = true;
                    if (oColaborador.Estado == false)
                        this.rdbInactivo.Checked = true;

                    if (oColaborador.Foto != null)
                    {
                        this.pctFoto.Image = new Bitmap(new MemoryStream(oColaborador.Foto));
                        this.pctFoto.Tag = oColaborador.Foto;
                        this.pctFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                    if (oColaborador.IDRol.IDRol == 2)
                    {
                        this.cmbIDSup.Items.Add(oColaborador.supID);
                        this.cmbIDSup.Text = oColaborador.supID;

                    }
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

        private void refrescarComboUsuario()
        {
            this.cmbUsuario.Items.Clear();
            List<Usuario> listaUsuariosNoAsignados = bLLUsuario.SelectAllNoAsignado();
            foreach (var item in listaUsuariosNoAsignados)
            {
                this.cmbUsuario.Items.Add(item);
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
        /// colaborador exitosamente en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Supervisor supervisor = new Supervisor();
            string idColaborador = this.txtID.Text;
            DialogResult resultado = MessageBox.Show("¿Está seguro(a) que desea eliminar el colaborador?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {

                bLLSupervisor.Update(bLLSupervisor.SelectById(bLLColaborador.SelectById(idColaborador).supID));
                bLLColaborador.SelectById(idColaborador).supID = null;

                Usuario oUsuario = bLLColaborador.SelectById(idColaborador).IDUsuario;

                oUsuario.Contrasenna = Criptografia.DecrypthAES(oUsuario.Contrasenna);
                oUsuario.Asignado = false;
                bLLUsuario.Update(oUsuario);

                if (frmLogin.colaboradorLoggeado.IDRol.IDRol == 2)
                {
                    bLLSupervisor.SelectById(bLLColaborador.SelectById(idColaborador).supID).Asignado = false;
                    bLLSupervisor.Update(bLLColaborador.SelectById(idColaborador).IDSupervisor);

                    foreach (Colaborador colaborador in bLLColaborador.SelectAll().Where(
                        col => col.IDSupervisor.IDSupervisor == bLLColaborador.SelectById(idColaborador).supID).ToList())
                    {
                        colaborador.IDSupervisor = supervisor;
                    }
                    bLLColaborador.SelectById(idColaborador).supID = "";

                }
                bool existeSolicitud = false;


                foreach (var sol in bLLSolicitudVacaciones.SelectAll())
                {
                    if ((String.Equals(sol.IDColaborador.IDColaborador,idColaborador, StringComparison.CurrentCultureIgnoreCase))){
                        existeSolicitud = true;
                        break;
                    }
                }


                if (existeSolicitud == true)
                {
                    DialogResult pregunta = MessageBox.Show("Existen solicitudes de vacaciones para el colaborador con ID: " + idColaborador +
                        "\n¿Desea eliminar las solicitudes de vacaciones?",
                        "Aviso",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (pregunta == DialogResult.Yes)
                    {
                        List<SolicitudVacaciones> listaSolicitudesBorrar = bLLSolicitudVacaciones.SelectAll().Where(
                            sol => (String.Equals(sol.IDColaborador.IDColaborador, idColaborador, StringComparison.CurrentCultureIgnoreCase))).ToList();

                        foreach (SolicitudVacaciones sol in listaSolicitudesBorrar)
                        {
                            bLLSolicitudVacaciones.Delete(sol.IDSolicitudVacas);
                        }

                    }
                    else
                    {
                        return;
                    }
                }

                bool existeDedPercAsignada = false;

                foreach (var dedPerc in bLLDeducciones_Percepciones_Por_Colaborador.SelectAll())
                {
                    if ((String.Equals(dedPerc.IdColaborador.IDColaborador, idColaborador, StringComparison.CurrentCultureIgnoreCase)))
                    {
                        existeDedPercAsignada = true;
                        break;
                    }
                }


                if (existeDedPercAsignada == true)
                {
                    DialogResult pregunta = MessageBox.Show("Existen deducciones/percepciones para el colaborador con ID: " + idColaborador +
                        "\n¿Desea eliminar las deducciones/percepciones del colaborador?",
                        "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (pregunta == DialogResult.Yes)
                    {
                        List<Deducciones_Percepciones_Por_Colaborador> listaDedPerColabBorrar = bLLDeducciones_Percepciones_Por_Colaborador.SelectAll().Where(
                            dedPerc => (String.Equals(dedPerc.IdColaborador.IDColaborador, idColaborador, StringComparison.CurrentCultureIgnoreCase))).ToList();

                        foreach (Deducciones_Percepciones_Por_Colaborador dedPerc in listaDedPerColabBorrar)
                        {
                            bLLDeducciones_Percepciones_Por_Colaborador.Delete(dedPerc.CodigoDeduccionPercepcion.CodigoDeduccionPercepcion, idColaborador);
                        }

                    }
                    else
                    {
                        return;
                    }
                }


                bool existeControlDeMarca = false;

                foreach (var controlMarca in bLLControlDeMarcas.SelectAll())
                {
                    if ((String.Equals(controlMarca.IdColaborador, idColaborador, StringComparison.CurrentCultureIgnoreCase)))
                    {
                        existeControlDeMarca = true;
                        break;
                    }
                }


                if (existeControlDeMarca == true)
                {
                    DialogResult pregunta = MessageBox.Show("Existen controles de marca para el colaborador con ID: " + idColaborador +
                        "\n¿Desea eliminar las marcas del colaborador?",
                        "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (pregunta == DialogResult.Yes)
                    {
                        List<ControlDeMarcas> listaMarcasBorrar = bLLControlDeMarcas.SelectAll().Where(
                            marca => (String.Equals(marca.IdColaborador, idColaborador, StringComparison.CurrentCultureIgnoreCase))).ToList();

                        foreach (ControlDeMarcas marca in listaMarcasBorrar)
                        {
                            bLLControlDeMarcas.DELETEBYID(marca.idMarca);
                        }

                    }
                    else
                    {
                        return;
                    }
                }

                bool existePlanillaDetalle = false;


                foreach (var planDet in bLLPlanilla_Detalle.SelectAll())
                {
                    if ((String.Equals(planDet.IdColaborador.IDColaborador, idColaborador, StringComparison.CurrentCultureIgnoreCase)))
                    {
                        existePlanillaDetalle = true;
                        break;
                    }
                }


                if (existePlanillaDetalle == true)
                {
                    DialogResult pregunta = MessageBox.Show("Existen planillas generadas para el colaborador con ID: " + idColaborador +
                        "\n¿Desea eliminar las planillas?",
                        "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (pregunta == DialogResult.Yes)
                    {
                        List<Planilla_Detalle> listaPlanDetBorrar = bLLPlanilla_Detalle.SelectAll().Where(
                            planDet => (String.Equals(planDet.IdColaborador.IDColaborador, idColaborador, StringComparison.CurrentCultureIgnoreCase))).ToList();

                        foreach (Planilla_Detalle planDet in listaPlanDetBorrar)
                        {
                            bLLPlanilla_Detalle.Delete(planDet.IdDetalle);
                        }

                    }
                    else
                    {
                        return;
                    }
                }

                bLLColaborador.Delete(idColaborador);
                CargarLista();
                LimpiarControles();
            }


        }
    }
}
