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
using Newtonsoft.Json.Linq;
using PayrollPal.Enumeraciones;
using PayrollPal.Layers;
using PayrollPal.Layers.BLL;
using PayrollPal.Layers.Entities;
using PayrollPal.Layers.IBLL;
using PayrollPal.Layers.UI;

namespace PayrollPal.UI.Mantenimientos
{
    public partial class frmMantenimientoDeduccionesPercepciones : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        IBLLDeduccionesPercepciones bLLDeduccionesPercepciones = new BLLDeduccionesPercepciones();
        public frmMantenimientoDeduccionesPercepciones()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Método load del form 
        /// de mantenimiento de deduccionesPercepciones 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMantenimientoDeduccionesPercepciones_Load(object sender, EventArgs e)
        {
            try
            {
                this.tslblUsuarioConectado.Text = "Usuario Conectado: " + frmLogin.colaboradorLoggeado.IDUsuario.IDUsuario +
    " Rol: " + frmLogin.colaboradorLoggeado.IDRol.Descripcion;
                //Cargar el datagridview de deduccionesPercepciones con el SELECT_ALL 
                //del DALDeduccionesPercepciones

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
        /// de deduccionesPercepciones desde la base de datos 
        /// y cargarlo al datagridview
        /// </summary>
        private void CargarLista()
        {
            try
            {

                this.dgvDeduccionesPercepciones.DataSource = bLLDeduccionesPercepciones.SelectAll();
                this.dgvDeduccionesPercepciones.ClearSelection();
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
        /// Método que se encarga de cargar los comboBoxes
        /// de Tipo (deduccion/percepción) y de Tipo Valor (Porcentaje/Absoluto)
        /// </summary>
        private void CargarCombos()
        {
            try
            {
                foreach (TipoPercepcionDeduccion tipo in Enum.GetValues(typeof(TipoPercepcionDeduccion)))
                {
                    this.cmbTipo.Items.Add(tipo);
                }

                foreach (TipoPorcAbs tipo in Enum.GetValues(typeof(TipoPorcAbs)))
                {
                    this.cmbTipoValor.Items.Add(tipo);
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
        /// Método para limpiar todos los controles 
        /// cuando se carga el form por primera vez (mediante el load)
        /// </summary>
        private void LimpiarControles()
        {
            try
            {
                this.txtCod.Text = "dedPerc";
                this.txtCod.BackColor = Color.White;

                this.txtNombre.Clear();
                this.txtNombre.BackColor = Color.White;

                this.cmbTipo.SelectedIndex = -1;

                this.mktValor.Clear();
                this.mktValor.BackColor = Color.White;

                this.cmbTipoValor.SelectedIndex = -1;

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

                this.txtCod.Enabled = false;
                this.txtNombre.Enabled = false;
                this.cmbTipo.Enabled = false;
                this.mktValor.Enabled = false;
                this.cmbTipoValor.Enabled = false;
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
        private void dgvDeduccionesPercepcione_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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

                if (this.dgvDeduccionesPercepciones.SelectedRows.Count == 1)
                {
                    //Crear instancia de deducciones y percepciones
                    Deducciones_Percepciones odeduccionesPercepciones = new Deducciones_Percepciones();
                    //Asignar la fila seleccionada del datagridview al objeto deduccionesPercepciones
                    odeduccionesPercepciones = this.dgvDeduccionesPercepciones.SelectedRows[0].DataBoundItem as Deducciones_Percepciones;
                    //Asignar a cada control los datos de deduccion/percepcion
                    this.txtCod.Text = odeduccionesPercepciones.CodigoDeduccionPercepcion.ToString();
                    this.txtNombre.Text = odeduccionesPercepciones.Nombre.ToString();
                    this.cmbTipo.Text = odeduccionesPercepciones.Tipo.ToString();
                    this.mktValor.Text = odeduccionesPercepciones.Valor.ToString();
                    this.cmbTipoValor.Text = odeduccionesPercepciones.TipoValor.ToString();
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
        /// Evento del botón Agregar para agregar a la 
        /// deducción/percepción exitosamente a la base de datos
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
        /// Evento del botón Editar para editar a la 
        /// deducción/percepción exitosamente en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            ResetearForm('U');
            this.btnConfirmar.Visible = true;
        }

        /// <summary>
        /// Evento del botón Eliminar para eliminar a la 
        /// deducción/percepción exitosamente en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigoDeduccionPercepcion = this.txtCod.Text;
            DialogResult resultado = MessageBox.Show("¿Está seguro(a) que desea eliminar la " +
                "deducción/percepción?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                bLLDeduccionesPercepciones.Delete(codigoDeduccionPercepcion);
                CargarLista();
                LimpiarControles();
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
                        this.txtCod.Text = this.txtCod.Text + bLLDeduccionesPercepciones.SecuenciadorDeduccionesPercepciones();

                        //habilitar los controles de texto (txtBox)

                        this.txtCod.Enabled = true;
                        this.txtNombre.Enabled = true;
                        this.cmbTipo.Enabled = true;
                        this.mktValor.Enabled = true;
                        this.cmbTipoValor.Enabled = true;
                        break;

                    case 'U':
                        //habiitar los botones de limpiar, 
                        //y salir
                        this.btnSalir.Enabled = true;

                        //habilitar los controles de texto (txtBox)

                        this.txtCod.ReadOnly = true;
                        this.txtNombre.Enabled = true;
                        this.cmbTipo.Enabled = true;
                        this.mktValor.Enabled = true;
                        this.cmbTipoValor.Enabled = true;
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
        /// Deducciones y Percepciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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


                // Validar Nombre
                if (!String.IsNullOrEmpty(this.txtNombre.Text.Trim()))
                {
                    this.errProv1.SetError(this.txtNombre, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.txtNombre, "Campo Nombre de deducción/percepción no es correcto");
                    return false;
                }

                //Validar Campo Tipo 

                if (this.cmbTipo.SelectedIndex >=0 )
                {
                    this.errProv1.SetError(this.cmbTipo, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbTipo, "Debe seleccionar un Tipo");
                    return false;
                }

                //Validar Campo Valor

                if (!String.IsNullOrEmpty(this.mktValor.Text.Trim()))
                {
                    this.errProv1.SetError(this.mktValor, string.Empty);

                }
                else
                {
                    this.errProv1.SetError(this.mktValor, "Campo valor de deducción/percepción no es correcto");
                    return false;
                }

                //Validar Campo TipoValor 

                if (this.cmbTipoValor.SelectedIndex >= 0)
                {
                    this.errProv1.SetError(this.cmbTipoValor, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbTipoValor, "Debe seleccionar un Tipo de Valor: " +
                        "Porcentaje o Absoluto");
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
            CrearActualizarDeduccionesPercepciones();
            LimpiarControles();
        }

        /// <summary>
        /// Método para crear las deducciones/percepciones y de igual manera actualizarlas
        /// </summary>
        private void CrearActualizarDeduccionesPercepciones()
        {
            //Crear la instancia de deducciones/percepciones
            Deducciones_Percepciones oDeduccionesPercepciones = new Deducciones_Percepciones();


            oDeduccionesPercepciones.CodigoDeduccionPercepcion = this.txtCod.Text;
            oDeduccionesPercepciones.Nombre = this.txtNombre.Text;
            oDeduccionesPercepciones.Tipo = (TipoPercepcionDeduccion)this.cmbTipo.SelectedItem;
            oDeduccionesPercepciones.Valor = double.Parse(this.mktValor.Text);
            oDeduccionesPercepciones.TipoValor = (TipoPorcAbs)this.cmbTipoValor.SelectedItem;

            //Se llama al método Create de deducciones/percepciones 
            //que se encarga de revisar si la deducción/percepción existe primero
            //antes de agregar la deducción/percepción

            if (bLLDeduccionesPercepciones.SelectById(this.txtCod.Text) != null)
            {

                bLLDeduccionesPercepciones.Update(oDeduccionesPercepciones);
            }
            else
            {
                bLLDeduccionesPercepciones.Create(oDeduccionesPercepciones);
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
                this.errProv1.SetError(this.txtNombre, "Campo Nombre de deducción/percepción no es correcto");
                this.txtNombre.BackColor = Color.MistyRose;
            }
        }

        /// <summary>
        /// Evento para revisar si el campo del
        /// código es correcto mientras se va escribiendo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mktValor_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.mktValor.Text.Trim()))
            {
                this.errProv1.SetError(this.mktValor, string.Empty);
                this.mktValor.BackColor = Color.Honeydew;
            }

            else
            {
                this.errProv1.SetError(this.mktValor, "Campo valor de deducción/percepción no es correcto");
                this.mktValor.BackColor = Color.MistyRose;
            }
        }

        private void cmbTipoValor_SelectedValueChanged(object sender, EventArgs e)
        {

            if (this.cmbTipoValor.SelectedIndex == -1)
            {
                return;
            }

            if ((TipoPorcAbs)this.cmbTipoValor.SelectedItem == TipoPorcAbs.Porcentaje)
            {
                this.mktValor.Mask = "000.00";
                this.lblPorc.Visible = true;
            }

            if ((TipoPorcAbs)this.cmbTipoValor.SelectedItem == TipoPorcAbs.Absoluto)
            {
                this.mktValor.Mask = "000000";
                this.lblPorc.Visible = false;
            }


        }

        private void dgvDeduccionesPercepciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == 4 && e.Value != null)
            {
                if (e.Value.ToString() == "Porcentaje")
                    e.Value += " (%)";
            }
        }
    }
}
