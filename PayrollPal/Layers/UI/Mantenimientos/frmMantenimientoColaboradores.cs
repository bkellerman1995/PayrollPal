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
using PayrollPal.Layers.BLL;
using PayrollPal.Layers.Entities;
using PayrollPal.Layers.Util;

namespace PayrollPal.UI.Mantenimientos
{
    public partial class frmMantenimientoColaboradores : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

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
                //Método para configurar los valores de los datetimepicker
                ConfigurarDateTimePickerFechaNacimiento();
                ConfigurarDateTimePickerFechaIngreso();

                //Cargar el datagridview de usuarios con el SELECT_ALL 
                //del DALColaborador

                CargarLista();
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
        /// de colaboradores desde la base de datos 
        /// y cargarlo al datagridview
        /// </summary>
        private void CargarLista()
        {
            try
            {

                this.dgvColaboradores.DataSource = BLLColaborador.SelectAll();
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
            this.cmbDepartamento.DataSource = BLLDepartamento.SelectAll();
            this.cmbUsuario.DataSource = BLLUsuario.SelectAll();
            this.cmbPuesto.DataSource = BLLPuesto.SelectAll();
            this.cmbRol.DataSource = BLLRol.SelectAll();
            this.cmbSupervisor.DataSource = BLLSupervisor.SelectAll();
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

                this.txtNombre.Clear();
                this.txtNombre.BackColor = Color.White;

                this.txtApellido1.Clear();
                this.txtApellido1.BackColor = Color.White;
                
                this.txtApellido2.Clear();
                this.txtApellido2.BackColor = Color.White;

                this.dtpFechaNacimiento.Value = this.dtpFechaNacimiento.MinDate;

                this.txtDireccion.Clear();
                this.txtDireccion.BackColor = Color.White;

                this.dtpFechaIngreso.Value = DateTime.Today;

                this.mktSalarioHora.Clear();
                this.mktSalarioHora.BackColor = Color.White;

                this.txtCorreoElectronico.Clear();
                this.txtCorreoElectronico.BackColor = Color.White;

                this.cmbDepartamento.SelectedIndex = -1;
                this.cmbUsuario.SelectedIndex = -1;
                this.cmbPuesto.SelectedIndex = -1;
                this.cmbRol.SelectedIndex = -1;
                this.lblSupervisor.Visible = false;
                this.cmbSupervisor.Visible = false;

                this.mktCuentaIBAN.Clear();
                this.mktCuentaIBAN.BackColor = Color.White;

                this.pctFoto.Image = PayrollPal.Properties.Resources.Colaborador_Generico;

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

                this.mktID.Enabled = false;
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
                this.cmbPuesto.Enabled = false;
                this.cmbRol.Enabled = false;



                this.pctFoto.Enabled = false;
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
                        this.btnAgregar.Enabled = true;
                        this.btnLimpiar.Enabled = true;
                        this.btnSalir.Enabled = true;

                        //habilitar los controles de texto, comboboxes
                        //pictureBox 

                        this.mktID.Enabled = true;
                        this.txtNombre.Enabled = true;
                        this.txtApellido1.Enabled = true;
                        this.txtApellido2.Enabled = true;
                        this.dtpFechaNacimiento.Enabled = true;
                        this.dtpFechaNacimiento.Value = this.dtpFechaNacimiento.MinDate;
                        this.txtDireccion.Enabled = true;
                        this.dtpFechaIngreso.Enabled = true;
                        this.dtpFechaIngreso.Value = DateTime.Today;
                        this.cmbDepartamento.Enabled = true;
                        this.mktSalarioHora.Enabled = true;
                        this.txtCorreoElectronico.Enabled = true;
                        this.mktCuentaIBAN.Enabled = true;
                        this.cmbUsuario.Enabled = true;
                        this.cmbPuesto.Enabled = true;
                        this.cmbRol.Enabled = true;
                        this.cmbSupervisor.Enabled = true;
                        this.pctFoto.Enabled = true;

                       
                        break;

                    case 'U':
                        //habiitar los botones de limpiar, 
                        //y salir
                        this.btnSalir.Enabled = true;

                        //habilitar los controles de texto (txtBox)

                        this.mktID.ReadOnly = true;
                        this.txtNombre.Enabled = true;
                        //this.txtContrasenna.Enabled = true;
                        //this.txtConfirmarContrasenna.Enabled = true;
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
            bool correcto = false;
            try
            {
                correcto = true;
                foreach (Control c in this.Controls)
                {
                    this.errProv1.SetError(c, String.Empty);
                    this.errProv1.Clear();
                }

                //ValidarID del colaborador
                if (this.mktID.MaskCompleted)
                {
                    this.errProv1.SetError(this.mktID, string.Empty);

                }
                else
                {
                    this.errProv1.SetError(this.mktID, "Campo ID de colaborador no es correcto");
                    return false;
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

                if (this.cmbPuesto.SelectedItem != null)
                {
                    this.errProv1.SetError(this.cmbPuesto, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbPuesto, "Campo puesto no es correcto");
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
                    this.errProv1.SetError(this.cmbSupervisor, "Campo supervisor no es correcto");
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
            char[] reemplazarCaracteresSalario = new char []{ ',', '.' };
            decimal Salario = 0;
            Supervisor supervisor = new Supervisor();

            oColaborador.IDColaborador = this.mktID.Text;
            oColaborador.Nombre = this.txtNombre.Text;
            oColaborador.Apellido1 = this.txtApellido1.Text;
            oColaborador.Apellido2 = this.txtApellido2.Text;
            oColaborador.Apellido2 = this.txtApellido2.Text;
            oColaborador.FechaNacimiento = this.dtpFechaNacimiento.Value;
            oColaborador.Direccion = this.txtDireccion.Text;
            oColaborador.FechaIngreso = this.dtpFechaNacimiento.Value;
            oColaborador.IDDepartamento = (Departamento)this.cmbDepartamento.SelectedItem;
            foreach (char c in reemplazarCaracteresSalario)
            {
                Salario = decimal.Parse(this.mktSalarioHora.Text.Replace(c.ToString(), ""));
            }
            oColaborador.SalarioHora = Salario;
            oColaborador.CorreoElectronico = this.txtCorreoElectronico.Text;
            oColaborador.CuentaIBAN = this.lblCR + this.mktCuentaIBAN.Text;
            oColaborador.IDUsuario = (Usuario)this.cmbUsuario.SelectedItem;
            oColaborador.CodigoPuesto = (Puesto)this.cmbPuesto.SelectedItem;
            oColaborador.IDRol = (Rol)this.cmbRol.SelectedItem;

            switch (oColaborador.IDRol.IDRol)
            {
                case 1:
                case 2:
                    oColaborador.IDSupervisor = supervisor;
                    break;
                case 3:
                    oColaborador.IDSupervisor = (Supervisor)this.cmbSupervisor.SelectedItem;
                    break;
            }
            oColaborador.Foto = (byte[])pctFoto.Tag;

            //Se llama al método Create del Colaborador 
            //que se encarga de revisar si el colaborador existe primero
            //antes de agregar al colaborador

            string idColaborador = this.mktID.Text.Replace("-", "");
            if (BLLColaborador.SelectById(idColaborador) != null)
            {

                BLLColaborador.Update(oColaborador);
            }
            else
            {
                BLLColaborador.Create(oColaborador);
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
                ofd.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";
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
                this.errProv1.SetError(this.mktID, "Campo ID de usuario no es correcto");
                this.mktID.BackColor = Color.MistyRose;
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
            if ((this.mktID.MaskCompleted))
            {
                this.errProv1.SetError(this.mktSalarioHora, string.Empty);
                this.mktSalarioHora.BackColor = Color.Honeydew;
            }
            else
            {
                this.errProv1.SetError(this.txtDireccion, "Campo salario/hora de colaborador no es correcto");
                this.txtDireccion.BackColor = Color.MistyRose;
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
            if (BLLRol.EsColaborador((Rol)this.cmbRol.SelectedItem))
            {
                this.cmbSupervisor.Visible = true;
                this.lblSupervisor.Visible = true;
            }
            else
            {
                this.cmbSupervisor.Visible = false;
                this.lblSupervisor.Visible = false;
            }
        }
    }
}
