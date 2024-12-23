﻿using System;
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
using PayrollPal.Layers.IBLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PayrollPal.Layers.UI.Mantenimientos
{
    public partial class frmMantenimientoSupervisores : Form
    {
        Rol rol;
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        IBLLColaborador bLLColaborador = new BLLColaborador();
        IBLLSupervisor bLLSupervisor = new BLLSupervisor();

        List<Colaborador> listaColaboradoresSupervisor = new List<Colaborador>();
        List<Colaborador> listaColaboradoresALL = new List<Colaborador>();

        public frmMantenimientoSupervisores()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Método load del form 
        /// de mantenimiento de supervisores 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMantenimientoSupervisores_Load(object sender, EventArgs e)
        {
            try
            {
                this.tslblUsuarioConectado.Text = "Usuario Conectado: " + frmLogin.colaboradorLoggeado.IDUsuario.IDUsuario +
                    " Rol: " + frmLogin.colaboradorLoggeado.IDRol.Descripcion;
                frmLogin frm = new frmLogin();
                //Cargar el datagridview de supervisores con el SELECT_ALL 
                //del DALSupervisor

                CargarListasColaboradoresALLySupervisores();

                //Programar el textBox de ROL con el ROL 2 (Supervisor) 
                //automáticamente

                rol = new Rol
                {
                    IDRol = 2,
                    Descripcion = "Supervisor"
                };

                this.txtRol.Text = rol.ToString();

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
        private void CargarListasColaboradoresALLySupervisores()
        {
            try
            {
                this.lstColaboradoresALL.Items.Clear();
                this.lstColaboradoresSup.Items.Clear();
                listaColaboradoresALL = bLLColaborador.SelectSoloColaboradores();

                foreach (var item in listaColaboradoresALL)
                {
                    this.lstColaboradoresALL.Items.Add(item);
                }

                this.lstColaboradoresALL.ClearSelected();

                this.dgvSupervisores.DataSource = bLLSupervisor.SelectAll();
                this.dgvSupervisores.ClearSelection();


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
                foreach (Control c in this.Controls)
                {
                    this.errProv1.SetError(c, String.Empty);
                    this.errProv1.Clear();
                }

                this.txtID.Text = "sup";
                this.txtID.BackColor = Color.White;

                this.txtDescripcion.Clear();
                this.txtDescripcion.BackColor = Color.White;

                this.lstColaboradoresSup.Items.Clear();
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
                this.lstColaboradoresSup.Enabled = false;

                this.txtID.Enabled = false;
                this.txtRol.Enabled = false;
                this.txtDescripcion.Enabled = false;
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
                        this.txtID.Text = this.txtID.Text + bLLSupervisor.SecuenciadorPuesto();

                        //habilitar los controles de texto (txtBox)
                        //y los botones para agregar y quitar en la lista

                        this.txtID.Enabled = true;
                        this.txtRol.Enabled = true;
                        this.txtDescripcion.Enabled = true;
                        this.btnQuitarColab.Enabled = true;
                        VerificarHayColaboradores();
                        this.lstColaboradoresALL.Enabled = true;
                        this.lstColaboradoresSup.Enabled = true;
                        break;

                    case 'U':
                        //habiitar los botones de limpiar, 
                        //y salir
                        this.btnSalir.Enabled = true;
                        this.btnLimpiar.Enabled = true;

                        //habilitar los controles de texto (txtBox)
                        //y los botones para agregar y quitar en la lista

                        this.txtID.ReadOnly = true;
                        this.txtRol.Enabled = true;
                        this.txtDescripcion.Enabled = true;
                        this.btnAgregarCol.Enabled = true;
                        this.btnQuitarColab.Enabled = true;
                        VerificarHayColaboradores();
                        this.lstColaboradoresALL.Enabled = true;
                        this.lstColaboradoresSup.Enabled = true;
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
        /// Evento para revisar si el campo del
        /// rol es correcto mientras se va escribiendo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDescripcion_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtDescripcion.Text.Trim()))
            {
                this.errProv1.SetError(this.txtDescripcion, string.Empty);
                this.txtDescripcion.BackColor = Color.Honeydew;
            }
            else
            {
                this.errProv1.SetError(this.txtDescripcion, "Campo Descripción de supervisor no es correcto");
                this.txtDescripcion.BackColor = Color.MistyRose;
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
                Colaborador oColaborador = this.lstColaboradoresALL.SelectedItem as Colaborador;
                listaColaboradoresSupervisor.Add(oColaborador);
                listaColaboradoresALL.Remove(oColaborador);

                RefrescarListaColaboradoresPorSup();
                RefrescarListaColaboradoresALL();
            }
            else
            {
                this.errProv1.SetError(this.lstColaboradoresALL, "Debe seleccionar un colaborador de la lista" +
                    "para poder agregarlo como colaborador del supervisor");
                this.lstColaboradoresALL.BackColor = Color.MistyRose;
            }

            if (this.lstColaboradoresALL.Items.Count == 0)
            {
                this.btnAgregarCol.Enabled = false;
            }

        }

        /// <summary>
        /// Evento del botón Agregar Colaborador 
        /// que se encarga de verificar si se puede 
        /// agregar un colaborador en la lista de 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitarColab_Click(object sender, EventArgs e)
        {
            Supervisor oSupervisor = new Supervisor();
            if (this.lstColaboradoresSup.SelectedItem != null)
            {
                Colaborador oColaborador = this.lstColaboradoresSup.SelectedItem as Colaborador;
                listaColaboradoresALL.Add(oColaborador);
                listaColaboradoresSupervisor.Remove(oColaborador);
                oColaborador.IDSupervisor = oSupervisor;
                bLLColaborador.Update(oColaborador);

                RefrescarListaColaboradoresPorSup();
                RefrescarListaColaboradoresALL();
            }
            else
            {
                this.errProv1.SetError(this.lstColaboradoresSup, "Debe seleccionar un colaborador de la lista" +
                    "para poder quitarlo como colaborador del supervisor");
                this.lstColaboradoresSup.BackColor = Color.MistyRose;
            }

            if (this.lstColaboradoresSup.Items.Count == 0)
            {
                this.btnQuitarColab.Enabled = false;
            }

        }

        private void RefrescarListaColaboradoresPorSup()
        {
            this.lstColaboradoresSup.Items.Clear();

            foreach (var item in listaColaboradoresSupervisor)
            {
                this.lstColaboradoresSup.Items.Add(item);
            }
            this.errProv1.SetError(this.lstColaboradoresSup, string.Empty);
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
        /// Método para verificar si hay colaboradores disponibles en 
        /// la empresa para añadirlos como colaboradores 
        /// de un supervisor
        /// </summary>
        /// <returns></returns>
        private void VerificarHayColaboradores()
        {

            //Validar los listbox de lista de supervisores y lista all colaboradores

            if (this.lstColaboradoresALL.Items.Count == 0)
            {
                this.errProv1.SetError(this.lstColaboradoresALL, "¡No hay colaboradores para agregar, debe agregarlos" +
                    " en mantenimiento de Colaboradores");
                this.btnAgregarCol.Enabled = false;
                this.btnQuitarColab.Enabled = false;
            }
            else
            {
                this.btnAgregarCol.Enabled = true;
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
            CargarListasColaboradoresALLySupervisores();
        }

        /// <summary>
        /// Evento del botón confirmar para
        /// crear o actualizar un supervisor
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
            CrearActualizarSupervisor();
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


                // Validar Descripcion
                if (!String.IsNullOrEmpty(this.txtDescripcion.Text.Trim()))
                {
                    this.errProv1.SetError(this.txtDescripcion, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.txtDescripcion, "Campo Descripción de Supervisor no es correcto");
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
        /// Método para crear los supervisores y de igual manera actualizarlos
        /// </summary>
        private void CrearActualizarSupervisor()
        {
            //Crear la instancia de Supervisor
            Supervisor oSupervisor = new Supervisor();


            oSupervisor.IDSupervisor = this.txtID.Text;

            oSupervisor.IDRol = rol;
            oSupervisor.Descripcion = this.txtDescripcion.Text;

            if (listaColaboradoresSupervisor.Count > 0)
            {
                foreach (var item in listaColaboradoresSupervisor)
                {
                    item.IDSupervisor = oSupervisor;
                    bLLColaborador.Update(item);
                }
            }
 


            //Se llama al método Create del Supervisor 
            //que se encarga de revisar si el supervisor existe primero
            //antes de agregar al supervisor

            if (bLLSupervisor.SelectById(this.txtID.Text) != null)
            {

                bLLSupervisor.Update(oSupervisor);
            }
            else
            {
                bLLSupervisor.Create(oSupervisor);
            }

            //Insertar el usuario a la base de datos
            //por medio del BLLSupervisor (método CREATE)



            //Refrescar las listas
            CargarListasColaboradoresALLySupervisores();

            //Ocultar el boton de confirmar
            this.btnConfirmar.Visible = false;

            //Limpiar los controles
            LimpiarControles();

        }

        /// <summary>
        /// Evento que se encarga de seleccionar 
        /// el objeto usuario en el datagrid view 
        /// y cargarlo en los campos respectivos
        /// del form (para editar o borrar o simplemente ver)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSupervisores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                listaColaboradoresSupervisor.Clear();

                //Habilitar botones de Editar
                //Eliminar y Editar
                //tambien deshabilita el boton de Agregar

                this.btnAgregar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnEliminar.Enabled = true;
                this.btnLimpiar.Enabled = true;

                if (this.dgvSupervisores.SelectedRows.Count == 1)
                {
                    //Crear instancia de Supervisor
                    Supervisor oSupervisor = new Supervisor();
                    //Asignar la fila seleccionada del datagridview al objeto supervisor
                    oSupervisor = this.dgvSupervisores.SelectedRows[0].DataBoundItem as Supervisor;
                    //Asignar a cada control los datos del supervisor
                    this.txtID.Text = oSupervisor.IDSupervisor.ToString();
                    this.txtDescripcion.Text = oSupervisor.Descripcion.ToString();

                    this.lstColaboradoresSup.Items.Clear();

                    foreach (var item in bLLColaborador.SelectColaboradorIdSupervisor(oSupervisor.IDSupervisor))
                    {
                        listaColaboradoresSupervisor.Add(item);
                    }

                    RefrescarListaColaboradoresPorSup();

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
        /// Evento del botón Editar para editar al 
        /// supervisor exitosamente en la base de datos
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
            Colaborador oColaborador = new Colaborador();
            Supervisor supervisor = new Supervisor();
            string idSupervisor = this.txtID.Text;
            DialogResult resultado = MessageBox.Show("¿Está seguro(a) que desea eliminar el supervisor?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                foreach (Colaborador colab in this.lstColaboradoresSup.Items)
                {
                    colab.IDSupervisor = supervisor;
                    bLLColaborador.Update(colab);
                }

                foreach (Colaborador colab in bLLColaborador.SelectAll())
                {
                    if (colab.IDRol.IDRol ==2 && colab.supID == bLLSupervisor.SelectById(idSupervisor).IDSupervisor)
                    {
                        colab.supID = "0";
                        bLLColaborador.Update(colab);
                        break;
                    }
                }

                bLLSupervisor.Delete(idSupervisor);
                CargarListasColaboradoresALLySupervisores();
                LimpiarControles();
            }


        }

        /// <summary>
        /// Evento para borrar el error provider en la lista 
        /// de colaboradores ALL si se selecciona un objeto colaborador
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
        private void lstColaboradoresSup_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.lstColaboradoresSup.SelectedItem != null)
            {
                this.errProv1.SetError(this.lstColaboradoresSup, string.Empty);
                this.lstColaboradoresSup.BackColor = Color.White;
                this.btnQuitarColab.Enabled = true;
            }
        }

        private void dgvSupervisores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
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
