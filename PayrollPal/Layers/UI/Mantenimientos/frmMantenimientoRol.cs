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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PayrollPal.Layers.UI.Mantenimientos
{
    public partial class frmMantenimientoRol : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        public frmMantenimientoRol()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para cerrar el form de Mantenimiento de 
        /// Roles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Método load del form 
        /// de mantenimiento de roles 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMantenimientoRol_Load(object sender, EventArgs e)
        {
            try
            {
                //Cargar el datagridview de roles con el SELECT_ALL 
                //del DALRol

                CargarLista();
                CargarCombo();

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
        /// de roles desde la base de datos 
        /// y cargarlo al datagridview
        /// </summary>
        private void CargarLista()
        {
            try
            {
                this.dgvRoles.DataSource = BLLRol.SelectAll();
                this.dgvRoles.ClearSelection();
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
        /// Método que se encarga de cargar el comboBox 
        /// de roles desde el enum
        /// </summary>
        private void CargarCombo()
        {

            foreach (var item in BLLRol.IDRolesCombo())
            {
                switch (item)
                {
                    case 1:
                        this.cmbIdRol.Items.Add((int)Enumeraciones.Rol.Administrador);
                        break;
                    case 2:
                        this.cmbIdRol.Items.Add((int)Enumeraciones.Rol.Supervisor);
                        break;
                    case 3:
                        this.cmbIdRol.Items.Add((int)Enumeraciones.Rol.Colaborador);
                        break;
                }
            }

            if(this.cmbIdRol.Items.Count == 0)
            {
                this.cmbIdRol.Enabled = false;
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

                        //habilitar los controles

                        this.cmbIdRol.Enabled = true;
                        this.cmbIdRol.Items.Clear();
                        CargarCombo();
                        break;

                    //chequear que el comboBox de ID Rol se llene
                    //conrespecto a los IDs que hagan falta de agregar.

                    case 'U':
                        //habiitar el boton de salir, 
                        this.btnSalir.Enabled = true;

                        //habilitar los controles 

                        this.cmbIdRol.Enabled = true;

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
                this.btnEliminar.Enabled = false;
                this.btnLimpiar.Enabled = false;
                this.btnConfirmar.Visible = false;

                this.cmbIdRol.Enabled = false;
                this.txtNombre.ReadOnly = true;
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
                this.cmbIdRol.SelectedIndex = -1;

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
        /// el objeto rol en el datagrid view 
        /// y cargarlo en los campos respectivos
        /// del form (para editar o borrar o simplemente ver)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRoles_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Habilitar botones de Editar
                //Eliminar y Editar
                //tambien deshabilita el boton de Agregar

                this.btnAgregar.Enabled = false;
                this.btnEliminar.Enabled = true;
                this.btnLimpiar.Enabled = true;
                this.cmbIdRol.Items.Clear();


                if (this.dgvRoles.SelectedRows.Count == 1)
                {
                    //Crear instancia de rol
                    Rol oRol = new Rol();
                    //Asignar la fila seleccionada del datagridview al objeto rol
                    oRol = this.dgvRoles.SelectedRows[0].DataBoundItem as Rol;
                    //Asignar a cada control los datos del rol

                    switch (oRol.IDRol)
                    {
                        case 1:
                            this.cmbIdRol.Items.Add((int)Enumeraciones.Rol.Administrador);
                            this.cmbIdRol.SelectedIndex = 0;
                            break;
                        case 2:
                            this.cmbIdRol.Items.Add((int)Enumeraciones.Rol.Supervisor);
                            this.cmbIdRol.SelectedIndex = 0;
                            break;
                        case 3:
                            this.cmbIdRol.Items.Add((int)Enumeraciones.Rol.Colaborador);
                            this.cmbIdRol.SelectedIndex = 0;
                            break;
                    }

                    this.txtNombre.Text = oRol.Descripcion.ToString(); 
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
        /// rol exitosamente a la base de datos
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

                //ValidarID del rol
                if (this.cmbIdRol.SelectedIndex >= 0)
                {
                    this.errProv1.SetError(this.cmbIdRol, string.Empty);

                }
                else
                {
                    this.errProv1.SetError(this.cmbIdRol, "El ID de rol no es correcto");
                    return false;
                }

                // Validar Nombre/Descripcion

                if (!String.IsNullOrEmpty(this.txtNombre.Text.Trim()))
                {
                    this.errProv1.SetError(this.txtNombre, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.txtNombre, "Campo Nombre de rol no es correcto");
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
        /// Método para crear los roles y de igual manera actualizarlos
        /// </summary>
        private void CrearActualizarRoles()
        {
            //Crear la instancia de Rol
            Rol oRol = new Rol();
            oRol.IDRol = (int)this.cmbIdRol.SelectedItem;
            oRol.Descripcion = this.txtNombre.Text;

            //Se llama al método Create del Rol 
            //que se encarga de revisar si el rol existe primero
            //antes de agregar al rol

            BLLRol.Create(oRol);

            //Insertar el rol a la base de datos
            //por medio del BLLRol (método CREATE)



            //Refrescar la lista
            CargarLista();

            //Ocultar el boton de confirmar
            this.btnConfirmar.Visible = false;

            //Limpiar los controles
            LimpiarControles();

        }

        /// <summary>
        /// Evento del botón Editar para editar al 
        /// rol exitosamente en la base de datos
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
        /// rol exitosamente en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idRol = (int)this.cmbIdRol.SelectedItem;

            DialogResult resultado = MessageBox.Show("¿Está seguro(a) que desea eliminar el rol?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                BLLRol.Delete(idRol);
                CargarLista();
                LimpiarControles();
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
                this.errProv1.SetError(this.txtNombre, "Campo Nombre/Descripción de rol no es correcto");
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
        /// crear o actualizar un usario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Validar que todos los campos del form (IDRol y descripción) y 
            //su comprobación se agreguen correctamente
            if (!ValidarCampos())
            {
                return;
            }

            //Llamar al método que crea y actualiza los roles
            CrearActualizarRoles();
            LimpiarControles();
        }

        /// <summary>
        /// Método para cambiar el nombre del textbox con el 
        /// nombre del rol dependiendo del rol que 
        /// se elija del combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbIdRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtNombre.Text.Trim()) || this.cmbIdRol.Enabled == false)
            {
                return;
            }
            else
            {
                this.txtNombre.Text = ((Enumeraciones.Rol)this.cmbIdRol.SelectedItem).ToString();
            }

        }

        /// <summary>
        /// Evento para ocultar la contraseña del usuario en el datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void dgvRoles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (e.ColumnIndex == 2 && e.Value != null)
        //        e.Value = new String('*', e.Value.ToString().Length);

        //}
    }
}
