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
using PayrollPal.Layers.BLL;
using PayrollPal.Layers.Entities;

namespace PayrollPal.UI.Mantenimientos
{
    public partial class frmMantenimientoPuestos : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        public frmMantenimientoPuestos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento para cerrar el form de Mantenimiento de 
        /// puestos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Método load del form 
        /// de mantenimiento de puestos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMantenimientoPuestos_Load(object sender, EventArgs e)
        {
            try
            {
                //Cargar el datagridview de puestos con el SELECT_ALL 
                //del DALPuesto

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
        /// de puestos desde la base de datos 
        /// y cargarlo al datagridview
        /// </summary>
        private void CargarLista()
        {
            try
            {

                this.dgvPuestos.DataSource = BLLPuesto.SelectAll();
                this.dgvPuestos.ClearSelection();
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
                        //y los radio button (activo e inactivo)

                        this.mktCodigo.Enabled = true;
                        this.txtNombre.Enabled = true;
                        this.rdbActivo.Enabled = true;
                        this.rdbActivo.Checked = true;
                        this.rdbInactivo.Enabled = true;
                        break;

                    case 'U':
                        //habiitar los botones de limpiar, 
                        //y salir
                        this.btnSalir.Enabled = true;


                        //habilitar los controles de texto (txtBox)
                        //y los radiobuttons

                        this.mktCodigo.ReadOnly = true;
                        this.txtNombre.Enabled = true;
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

                this.mktCodigo.Enabled = false;
                this.txtNombre.Enabled = false;
                this.rdbActivo.Enabled = false;
                this.rdbActivo.Checked = false;
                this.rdbInactivo.Enabled = false;
                this.rdbInactivo.Checked = false;

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
                this.mktCodigo.Clear();
                this.mktCodigo.BackColor = Color.White;

                this.txtNombre.Clear();
                this.txtNombre.BackColor = Color.White;

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
        /// el objeto puesto en el datagrid view 
        /// y cargarlo en los campos respectivos
        /// del form (para editar o borrar o simplemente ver)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPuestos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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

                if (this.dgvPuestos.SelectedRows.Count == 1)
                {
                    //Crear instancia de puesto
                    Puesto oPuesto = new Puesto();
                    //Asignar la fila seleccionada del datagridview al objeto puesto
                    oPuesto = this.dgvPuestos.SelectedRows[0].DataBoundItem as Puesto;
                    //Asignar a cada control los datos del puesto
                    this.mktCodigo.Text = oPuesto.CodigoPuesto.ToString();
                    this.txtNombre.Text = oPuesto.Nombre.ToString();

                    if (oPuesto.Estado)
                    {
                        this.rdbActivo.Checked = true;
                    }
                    else
                    {
                        this.rdbInactivo.Checked = true;
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
        /// Evento del botón Agregar para agregar al 
        /// puesto exitosamente a la base de datos
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
                if (this.mktCodigo.MaskCompleted)
                {
                    this.errProv1.SetError(this.mktCodigo, string.Empty);

                }
                else
                {
                    this.errProv1.SetError(this.mktCodigo, "Campo Código de puesto no es correcto");
                    return false;
                }

                // Validar Nombre
                if (!String.IsNullOrEmpty(this.txtNombre.Text.Trim()))
                {
                    this.errProv1.SetError(this.txtNombre, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.txtNombre, "Campo Nombre de puesto no es correcto");
                    return false;
                }

                //Validar Estado

                if (this.rdbActivo.Checked || this.rdbInactivo.Checked)
                {
                    this.errProv1.SetError(this.rdbActivo, string.Empty);
                    this.errProv1.SetError(this.rdbInactivo, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.rdbActivo, "Debe seleccionar un estado");
                    this.errProv1.SetError(this.rdbInactivo, "Debe seleccionar un estado");
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
        /// Método para crear los puestos y de igual manera actualizarlos
        /// </summary>
        private void CrearActualizarUsuario()
        {
            //Crear la instancia de Puesto
            Puesto oPuesto = new Puesto();


            oPuesto.CodigoPuesto = int.Parse(this.mktCodigo.Text);
            oPuesto.Nombre = this.txtNombre.Text;

            if (this.rdbActivo.Checked)
                oPuesto.Estado = true;

            if (this.rdbInactivo.Checked)
                oPuesto.Estado = false;

            //Se llama al método Create del Puesto 
            //que se encarga de revisar si el puesto existe primero
            //antes de agregar al puesto

            if (BLLPuesto.SelectById(int.Parse(this.mktCodigo.Text)) != null)
            {

                BLLPuesto.Update(oPuesto);
            }
            else
            {
                BLLPuesto.Create(oPuesto);
            }

            //Insertar el puesto a la base de datos
            //por medio del BLLPuesto (método CREATE)



            //Refrescar la lista
            CargarLista();

            //Ocultar el boton de confirmar
            this.btnConfirmar.Visible = false;

            //Limpiar los controles
            LimpiarControles();

        }

        /// <summary>
        /// Evento del botón Editar para editar al 
        /// puesto exitosamente en la base de datos
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
        /// puesto exitosamente en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idUsuario = int.Parse(this.mktCodigo.Text);
            DialogResult resultado = MessageBox.Show("¿Está seguro(a) que desea eliminar el puesto?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                BLLPuesto.Delete(idUsuario);
                CargarLista();
                LimpiarControles();
            }


        }

        /// <summary>
        /// Evento para revisar si el campo del
        /// Código es correcto mientras se va escribiendo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mktCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.mktCodigo.MaskCompleted)
            {
                this.errProv1.SetError(this.mktCodigo, string.Empty);
                this.mktCodigo.BackColor = Color.Honeydew;
            }
            else
            {
                this.errProv1.SetError(this.mktCodigo, "Campo Código de puesto no es correcto");
                this.mktCodigo.BackColor = Color.MistyRose;
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
                this.errProv1.SetError(this.txtNombre, "Campo Nombre de puesto no es correcto");
                this.txtNombre.BackColor = Color.MistyRose;
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
        /// crear o actualizar un puesto
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
        /// Evento para darle formato al campo de 
        /// Estado del puesto (true = activo y false = inactivo)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPuestos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "Activa";
                if (e.Value.ToString() == "False")
                    e.Value = "Inactiva";
            }

        }
    }
}
