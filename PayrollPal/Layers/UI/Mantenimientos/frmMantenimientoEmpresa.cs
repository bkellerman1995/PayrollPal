using PayrollPal.Layers.BLL;
using PayrollPal.Layers.Interfaces;
using PayrollPal.Enumeraciones;
using PayrollPal.Layers.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using System.Reflection;
using PayrollPal.Layers.Entities;
using System.IO;

namespace PayrollPal.UI.Mantenimientos
{
    public partial class frmMantenimientoEmpresa : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                                log4net.LogManager.GetLogger("MyControlEventos");

        IBLLEmpresa bLLEmpresa = new BLLEmpresa();
        public static int contEmpresa = 0;
        public static Empresa empresaUnica = new Empresa();

        public event EventHandler MantEmpFormClosed;
        public frmMantenimientoEmpresa()
        {
            InitializeComponent();
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void pctLogo_Click(object sender, EventArgs e)
        {

        }

        private async void frmMantenimientoEmpresa_Load(object sender, EventArgs e)
        {
            try
            {
                contEmpresa = 0;
                this.tslblUsuarioConectado.Text = "Usuario Conectado: " + frmLogin.colaboradorLoggeado.IDUsuario.IDUsuario +
    " Rol: " + frmLogin.colaboradorLoggeado.IDRol.Descripcion;
                //Cargar el datagridview de empresa con el SELECT_ALL 
                //del DALEmpresa

                List<Empresa> lista = await bLLEmpresa.SelectAll();

                if (lista.Count > 0)
                    contEmpresa++;

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

        private async void CargarLista()
        {
            try
            {
                Task<List<Empresa>> taskListaEmpresa = bLLEmpresa.SelectAll();
                List<Empresa> listaEmpresa = await taskListaEmpresa;
                this.dgvEmpresa.DataSource = listaEmpresa;
                this.dgvEmpresa.ClearSelection();
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
            this.cmbTipoID.Items.Add(" ==== SELECCIONE ==== ");
            this.cmbTipoID.Items.Add(TipoCedulaEmpresa.Fisica);
            this.cmbTipoID.Items.Add(TipoCedulaEmpresa.Juridica);
        }

        private void LimpiarControles()
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    this.errProv1.SetError(c, String.Empty);
                    this.errProv1.Clear();
                }

                this.mktID.Text = "";
                this.mktID.BackColor = Color.White;

                this.cmbTipoID.SelectedIndex = 0;

                this.txtNombre.Clear();
                this.txtNombre.BackColor = Color.White;

                this.mktTelefono.Clear();
                this.mktTelefono.BackColor = Color.White;

                this.txtDireccion.Clear();
                this.txtDireccion.BackColor = Color.White;


                this.rdbActiva.Checked = true;

                this.pctLogo.Image = PayrollPal.Properties.Resources.building;

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

        private void InhabilitarControles()
        {
            try
            {
                if (contEmpresa > 0)
                {
                    this.btnAgregar.Enabled = false;
                }
                else
                {
                    this.btnAgregar.Enabled = true;
                }

                this.btnEditar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnLimpiar.Enabled = false;
                this.btnConfirmar.Visible = false;
                this.btnCargarLogo.Enabled = false;

                this.mktID.Enabled = false;
                this.txtNombre.Enabled = false;
                this.mktTelefono.Enabled = false;
                this.txtDireccion.Enabled = false;

                this.cmbTipoID.Enabled = false;

                this.pctLogo.Enabled = false;

                this.rdbActiva.Enabled = false;
                this.rdbInactiva.Enabled = false;
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
                this.btnCargarLogo.Enabled = true;
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

                        //habilitar los controles de texto, comboboxes
                        //pictureBox 

                        this.mktID.Enabled = true;
                        this.txtNombre.Enabled = true;
                        this.mktTelefono.Enabled = true;
                        this.txtDireccion.Enabled = true;
                        this.cmbTipoID.Enabled = true;
                        this.pctLogo.Enabled = true;
                        this.btnCargarLogo.Enabled = true;
                        this.rdbActiva.Enabled = true;
                        this.rdbInactiva.Enabled = true;


                        break;

                    case 'U':

                        this.btnLimpiar.Enabled = true;
                        this.btnSalir.Enabled = true;

                        //habilitar los controles de texto, comboboxes
                        //pictureBox 

                        this.mktID.ReadOnly = true;
                        this.txtNombre.Enabled = true;
                        this.mktTelefono.Enabled = true;
                        this.txtDireccion.Enabled = true;
                        this.cmbTipoID.Enabled = true;
                        this.pctLogo.Enabled = true;
                        this.btnCargarLogo.Enabled = true;
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

        private void cmbTipoID_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbTipoID.SelectedIndex != 0)
            {
                if ((TipoCedulaEmpresa)this.cmbTipoID.SelectedItem == TipoCedulaEmpresa.Fisica)
                {
                    mktID.Mask = "0-0000-0000";
                }
                else
                {
                    mktID.Mask = "0-000-000000";
                }

            }
        }

        private void mktID_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.mktID.MaskCompleted)
            {
                this.errProv1.SetError(this.mktID, string.Empty);
                this.mktID.BackColor = Color.Honeydew;
            }
            else
            {
                this.errProv1.SetError(this.mktID, "Campo ID de empresa no es correcto");
                this.mktID.BackColor = Color.MistyRose;
            }
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtNombre.Text.Trim()))
            {
                this.errProv1.SetError(this.txtNombre, string.Empty);
                this.txtNombre.BackColor = Color.Honeydew;
            }
            else
            {
                this.errProv1.SetError(this.txtNombre, "Campo Nombre de empresa no es correcto");
                this.txtNombre.BackColor = Color.MistyRose;
            }
        }

        private void mktTelefono_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.mktTelefono.MaskCompleted)
            {
                this.errProv1.SetError(this.mktTelefono, string.Empty);
                this.mktTelefono.BackColor = Color.Honeydew;
            }
            else
            {
                this.errProv1.SetError(this.mktTelefono, "Campo Teléfono de empresa no es correcto");
                this.mktTelefono.BackColor = Color.MistyRose;
            }
        }

        private void txtDireccion_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtDireccion.Text.Trim()))
            {
                this.errProv1.SetError(this.txtDireccion, string.Empty);
                this.txtDireccion.BackColor = Color.Honeydew;
            }
            else
            {
                this.errProv1.SetError(this.txtDireccion, "Campo Dirección de empresa no es correcto");
                this.txtDireccion.BackColor = Color.MistyRose;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Validar que todos los campos del form estén correctamente llenados 
            //para agregar o actualizar la empresa correctamente
            if (!ValidarCampos())
            {
                return;
            }

            //Llamar al método que crea y actualiza la empresa
            CrearActualizarEmpresa();
            LimpiarControles();
        }

        private void CrearActualizarEmpresa()
        {
            //Crear la instancia de Empresa
            Empresa oEmpresa = new Empresa();

            oEmpresa.TipoIdentificacion = (TipoCedulaEmpresa)this.cmbTipoID.SelectedItem;
            oEmpresa.IDEmpresa = this.mktID.Text.Replace("-", "");
            oEmpresa.Nombre = this.txtNombre.Text;
            oEmpresa.Telefono = this.mktTelefono.Text.Replace("-","");
            oEmpresa.Direccion = this.txtDireccion.Text;
            if (this.rdbActiva.Checked)
                oEmpresa.Estado = true;
            if (this.rdbInactiva.Checked)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro(a) que desea configurar la empresa como inactiva?" +
                    "\n" +
                    "\nEsta acción deshabilitará las funciones de mantenimiento (excepto empresa)" +
                    "\nprocesos (calcular planilla), consultas y reportes de la aplicación.", "Aviso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    oEmpresa.Estado = false;
                }

            }
            oEmpresa.Logo = (byte[])pctLogo.Tag;

            //Se llama al método Create de la empresa 
            //que se encarga de revisar si la empresa existe primero
            //antes de agregarla

            if (bLLEmpresa.SelectById(this.mktID.Text.Replace("-","")) != null)
            {

                bLLEmpresa.Update(oEmpresa);
            }
            else
            {
                bLLEmpresa.Create(oEmpresa);
            }

            empresaUnica = oEmpresa;

            //Refrescar la lista
            CargarLista();

            //Ocultar el boton de confirmar
            this.btnConfirmar.Visible = false;

            //Limpiar los controles
            LimpiarControles();

        }

        private bool ValidarCampos()
        {
            Empresa oEmpresa = new Empresa();
            bool correcto = false;
            try
            {
                correcto = true;
                foreach (Control c in this.Controls)
                {
                    this.errProv1.SetError(c, String.Empty);
                    this.errProv1.Clear();
                }

                //Validar combo TipoID

                if (this.cmbTipoID.SelectedItem != null && this.cmbTipoID.SelectedIndex != 0)
                {
                    this.errProv1.SetError(this.cmbTipoID, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbTipoID, "Campo tipo de identificación no es correcto");
                    return false;
                }

                //Validar IdEmpresa

                if (this.mktID.MaskCompleted)
                {
                    this.errProv1.SetError(this.mktID, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.mktID, "Campo ID de Empresa no es correcto");
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

                //Validar telefono

                if (this.mktTelefono.MaskCompleted)
                {
                    this.errProv1.SetError(this.mktTelefono, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.mktTelefono, "Campo Teléfono no es correcto");
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




                //Validar pictureBox de Foto

                if (this.pctLogo.Tag == null)
                {
                    MessageBox.Show("¡El logo es requerido!", "Error", MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
                    btnCargarLogo_Click(this, EventArgs.Empty);
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

        private void btnCargarLogo_Click(object sender, EventArgs e)
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
                        this.pctLogo.ImageLocation = ofd.FileName;
                        this.pctLogo.SizeMode = PictureBoxSizeMode.StretchImage;

                        byte[] cadenaBytes = File.ReadAllBytes(ofd.FileName);

                        this.pctLogo.Tag = (byte[])cadenaBytes;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ResetearForm('U');
            this.btnConfirmar.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string idEmpresa = this.mktID.Text.Replace("-","");
                DialogResult resultado = MessageBox.Show("¿Está seguro(a) que desea eliminar la empresa? +" +
                    "\n" +
                    "\nEsta acción deshabilitará las funciones de mantenimiento (excepto empresa)" +
                    "\nprocesos (calcular planilla), consultas y reportes de la aplicación.", "Aviso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    bLLEmpresa.Delete(idEmpresa);
                    contEmpresa--;
                    empresaUnica = new Empresa();
                    CargarLista();
                    LimpiarControles();

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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEmpresa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.Value != null)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "Activa";
                if (e.Value.ToString() == "False")
                    e.Value = "Inactiva";
            }
        }

        private void dgvEmpresa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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

                if (this.dgvEmpresa.SelectedRows.Count == 1)
                {
                    //Crear instancia de empresa
                    Empresa oEmpresa = new Empresa();
                    //Asignar la fila seleccionada del datagridview al objeto empresa
                    oEmpresa = this.dgvEmpresa.SelectedRows[0].DataBoundItem as Empresa;
                    //Asignar a cada control los datos del usuario
                    this.cmbTipoID.Text = oEmpresa.TipoIdentificacion.ToString();
                    this.mktID.Text = oEmpresa.IDEmpresa.ToString();
                    this.txtNombre.Text = oEmpresa.Nombre.ToString();
                    this.mktTelefono.Text = oEmpresa.Telefono.ToString();
                    this.txtDireccion.Text = oEmpresa.Direccion.ToString();

                    if (oEmpresa.Estado == true)
                        this.rdbActiva.Checked = true;
                    if (oEmpresa.Estado == false)
                        this.rdbInactiva.Checked = true;

                    if (oEmpresa.Logo != null)
                    {
                        this.pctLogo.Image = new Bitmap(new MemoryStream(oEmpresa.Logo));
                        this.pctLogo.Tag = oEmpresa.Logo;
                        this.pctLogo.SizeMode = PictureBoxSizeMode.StretchImage;
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

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            // Activa el evento personalizado cuando el formulario hijo se cierra
            MantEmpFormClosed?.Invoke(this, EventArgs.Empty);
        }
    }
}
