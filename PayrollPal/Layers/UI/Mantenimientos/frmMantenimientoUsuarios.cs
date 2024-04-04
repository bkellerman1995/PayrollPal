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
using PayrollPal.Layers.Entities;
using System.IO;
using UTNLeccion8B;
using PayrollPal.Layers.Util;
using System.Diagnostics.Eventing.Reader;


namespace PayrollPal.UI.Mantenimientos
{
    public partial class frmMantenimientoUsuarios : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                                     log4net.LogManager.GetLogger("MyControlEventos");

        public frmMantenimientoUsuarios()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para cerrar el form de Mantenimiento de 
        /// Usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Método load del form 
        /// de mantenimiento de usuarios 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                //Cargar el datagridview de usuarios con el SELECT_ALL 
                //del DALUsuario

                CargarLista();

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
        /// de usuarios desde la base de datos 
        /// y cargarlo al datagridview
        /// </summary>
        private void CargarLista()
        {
            try
            {

                this.dgvUsuarios.DataSource = BLLUsuario.SelectAll();
                this.dgvUsuarios.ClearSelection();
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

                        this.mktID.Enabled = true;
                        this.txtNombre.Enabled = true;
                        this.txtContrasenna.Enabled = true;
                        this.txtConfirmarContrasenna.Enabled = true;
                        break;

                    case 'U':
                        //habiitar los botones de limpiar, 
                        //y salir
                        this.btnSalir.Enabled = true;

                        //habilitar los controles de texto (txtBox)

                        this.mktID.ReadOnly = true;
                        this.txtNombre.Enabled = true;
                        this.txtContrasenna.Enabled = true;
                        this.txtConfirmarContrasenna.Enabled = true;
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
                this.txtNombre.Enabled = false;
                this.txtContrasenna.Enabled = false;
                this.txtConfirmarContrasenna.Enabled = false;
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

                this.txtContrasenna.Clear();
                this.txtContrasenna.BackColor = Color.White;

                this.txtConfirmarContrasenna.Clear();
                this.txtConfirmarContrasenna.BackColor = Color.White;

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
        /// Evento que se encarga de seleccionar 
        /// el objeto usuario en el datagrid view 
        /// y cargarlo en los campos respectivos
        /// del form (para editar o borrar o simplemente ver)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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

                if (this.dgvUsuarios.SelectedRows.Count == 1)
                {
                    //Crear instancia de usuario
                    Usuario oUsuario = new Usuario();
                    //Asignar la fila seleccionada del datagridview al objeto usuario
                    oUsuario = this.dgvUsuarios.SelectedRows[0].DataBoundItem as Usuario;
                    //Asignar a cada control los datos del usuario
                    this.mktID.Text = oUsuario.IDUsuario.ToString();
                    this.txtNombre.Text = oUsuario.NombreUsuario.ToString();
                    this.txtContrasenna.Text = oUsuario.Contrasenna.ToString();
                    this.txtConfirmarContrasenna.Text = oUsuario.Contrasenna.ToString();
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

                //ValidarID del usuario
                if (this.mktID.MaskCompleted)
                {
                    this.errProv1.SetError(this.mktID, string.Empty);

                }
                else
                {
                    this.errProv1.SetError(this.mktID, "Campo ID de usuario no es correcto");
                    return false;
                }

                // Validar Nombre
                if (!String.IsNullOrEmpty(this.txtNombre.Text.Trim()))
                {
                    this.errProv1.SetError(this.txtNombre, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.txtNombre, "Campo Nombre de Usuario no es correcto");
                    return false;
                }

                //Validar Campos contrasenna

                if (PayrollPal.Layers.Util.Contrasenna.ContrasennaFuerte(this.txtContrasenna.Text))
                {
                    this.errProv1.SetError(this.txtContrasenna, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.txtContrasenna, "La contraseña debe cumplir con los siguientes requisitos: " +
                        "\n- Longitud entre 8 y 16 caracteres" +
                        "\n- Debe incluir al menos una letra" +
                        "\n- Debe incluir al menos un dígito" +
                        "\n- Debe incluir al menos un caracter especial (@ ; / .)");
                    return false;
                }

                //Validar contrasennas coinciden

                if (!String.IsNullOrEmpty(this.txtConfirmarContrasenna.Text.Trim())
                    && (this.txtContrasenna.Text.Equals(this.txtConfirmarContrasenna.Text)))
                {
                    this.errProv1.SetError(this.txtConfirmarContrasenna, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.txtConfirmarContrasenna, "Los campos de contraseña no coinciden");
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
        private void CrearActualizarUsuario()
        {
            //Crear la instancia de Usuario
            Usuario oUsuario = new Usuario();


            oUsuario.IDUsuario = this.mktID.Text;
            oUsuario.NombreUsuario = this.txtNombre.Text;
            oUsuario.Contrasenna = this.txtContrasenna.Text;
            oUsuario.Asignado = false;

            //Se llama al método Create del Usuario 
            //que se encarga de revisar si el usuario existe primero
            //antes de agregar al usuario

            if (BLLUsuario.SelectById(this.mktID.Text)!=null)
            {

                BLLUsuario.Update(oUsuario);
            }
            else
            {
                BLLUsuario.Create(oUsuario);
            }

            //Insertar el usuario a la base de datos
            //por medio del BLLUsuario (método CREATE)



            //Refrescar la lista
            CargarLista();

            //Ocultar el boton de confirmar
            this.btnConfirmar.Visible = false;

            //Limpiar los controles
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
        /// usuario exitosamente en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idUsuario = this.mktID.Text;
            DialogResult resultado = MessageBox.Show("¿Está seguro(a) que desea eliminar el usuario?","Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                BLLUsuario.Delete(idUsuario);
                CargarLista();
                LimpiarControles();
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
                this.errProv1.SetError(this.txtNombre, "Campo Nombre de usuario no es correcto");
                this.txtNombre.BackColor = Color.MistyRose;
            }
        }

        /// <summary>
        /// Evento para revisar si el campo de la 
        /// contraseña es correcto mientras se va escribiendo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtContrasenna_KeyUp(object sender, KeyEventArgs e)
        {
            if (PayrollPal.Layers.Util.Contrasenna.ContrasennaFuerte(this.txtContrasenna.Text))
            {
                this.errProv1.SetError(this.txtContrasenna, string.Empty);
                this.txtContrasenna.BackColor = Color.Honeydew;
            }
            else
            {
                this.errProv1.SetError(this.txtContrasenna, "La contraseña debe cumplir con los siguientes requisitos: " +
                    "\n- Longitud entre 8 y 16 caracteres" +
                    "\n- Debe incluir al menos una letra" +
                    "\n- Debe incluir al menos un dígito" +
                    "\n- Debe incluir al menos un caracter especial (@ ; / .)");
                this.txtContrasenna.BackColor = Color.MistyRose;
            }
        }

        /// <summary>
        /// Evento para revisar si el campo de confirmar contraseña
        /// y el campo de contraseña coinciden (se colore el campo respectivamente)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtConfirmarContrasenna_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtConfirmarContrasenna.Text.Trim())
                && (this.txtContrasenna.Text.Equals(this.txtConfirmarContrasenna.Text)))
            {
                this.errProv1.SetError(this.txtConfirmarContrasenna, string.Empty);
                this.txtConfirmarContrasenna.BackColor = Color.Honeydew;
            }
            else
            {
                this.errProv1.SetError(this.txtConfirmarContrasenna, "Los campos de contraseña no coinciden");
                this.txtConfirmarContrasenna.BackColor = Color.MistyRose;
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
        /// Evento del botón confirmar para
        /// crear o actualizar un usario
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

            //Llamar al método que crea y actualiza los usuarios
            CrearActualizarUsuario();
            LimpiarControles();
        }

        /// <summary>
        /// Evento para ocultar la contraseña del usuario en el datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
                e.Value = new String('*', e.Value.ToString().Length);

            if (e.ColumnIndex == 3 && e.Value != null)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "Sí";
                if (e.Value.ToString() == "False")
                    e.Value = "No";
            }
        }
    }
}
