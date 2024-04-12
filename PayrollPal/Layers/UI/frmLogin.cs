using PayrollPal.Layers.Entities;
using PayrollPal.Layers.IBLL;
using PayrollPal.Layers.BLL;
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
using PayrollPal.Layers.Util;
using PayrollPal.UI;

namespace PayrollPal.Layers.UI
{
    public partial class frmLogin : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        IBLLUsuario bLLUsuario = new BLLUsuario();
        IBLLColaborador bLLColaborador = new BLLColaborador();
        Colaborador oColaborador = new Colaborador();
        Usuario oUsuario = new Usuario();

        public static Colaborador colaboradorLoggeado = new Colaborador();

        public event EventHandler LoginFormClosed;


        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                this.errProv1.SetError(c, String.Empty);
                this.errProv1.Clear();
            }

            this.txtUsuario.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    this.errProv1.SetError(c, String.Empty);
                    this.errProv1.Clear();
                }

                if (ValidarCampos() == true &&
                    VerificarLogin(this.txtUsuario.Text, this.txtPwd.Text))
                {
                    colaboradorLoggeado = oColaborador;

                    this.Close();
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

                // Validar Usuario
                if (!String.IsNullOrEmpty(this.txtUsuario.Text.Trim()))
                {
                    this.errProv1.SetError(this.txtUsuario, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.txtUsuario, "Campo usuario no es correcto");
                    correcto = false;
                }

                // Validar Contrasenna
                if (!String.IsNullOrEmpty(this.txtPwd.Text.Trim()))
                {
                    this.errProv1.SetError(this.txtPwd, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.txtPwd, "Campo contraseña no es correcto");
                    correcto = false;
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

        private bool VerificarLogin(string pUsuario, string pContrasenna)
        {
            bool loginCorrecto = true;
            int contCamposCorrectos = 0;

            try
            {
                foreach (Control c in this.Controls)
                {
                    this.errProv1.SetError(c, String.Empty);
                    this.errProv1.Clear();
                }

                if (bLLUsuario.SelectById(pUsuario) != null)
                {
                    oUsuario = bLLUsuario.SelectById(pUsuario);

                    foreach (var colab in bLLColaborador.SelectAll())
                    {
                        if (colab.IDUsuario.IDUsuario == oUsuario.IDUsuario)
                        {
                            oColaborador = colab;
                            break;
                        }
                    }

                    if (!(String.Equals(pContrasenna, Criptografia.DecrypthAES(oUsuario.Contrasenna))))
                    {
                        loginCorrecto = false;
                    }
                    else
                    {
                        contCamposCorrectos++;
                    }
                    contCamposCorrectos++;
                }
                else
                {
                    loginCorrecto = false;

                }

                if (contCamposCorrectos == 2)
                {
                    MessageBox.Show("¡Bienvenido(a) al sistema: " + oColaborador.Nombre + "! (usuario: !" + oColaborador.IDUsuario.IDUsuario + ")",
                        "BIENVENIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loginCorrecto = true;
                }
                else
                {
                    MessageBox.Show("¡Usuario o contraseña inválidos!",
                        "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginCorrecto = false;
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

            return loginCorrecto;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            // Activa el evento personalizado cuando el formulario hijo se cierra
            LoginFormClosed?.Invoke(this, EventArgs.Empty);
        }

    }
}
