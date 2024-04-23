using System;
using System.Globalization;
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
using PayrollPal.Layers.Util;
using System.IO;
using PayrollPal.Enumeraciones;
using PayrollPal.Layers.IBLL;
using PayrollPal.Layers.UI;
using PayrollPal.UI.Consultas;
using PayrollPal.Layers;
using Microsoft.Reporting.WinForms;
using System.Drawing.Imaging;

namespace PayrollPal
{
    public partial class frmMantenimientoPlanillas : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        IBLLPlanillaPago bLLPlanillaPago = new BLLPlanillaPago();
        IBLLPlanilla_Detalle bllPlanillaDetalle = new BLLPlanilla_Detalle();
        IBLLPlanilla_Encabezado bllPlanillaEncabezado = new BLLPlanilla_Encabezado();
        IBLLColaborador bLLColaborador = new BLLColaborador();
        IBLLSolicitudVacaciones bLLSolicitudVacaciones = new BLLSolicitudVacaciones();
        IBLLDeducciones_Percepciones_Por_Colaborador bLLDeducciones_Percepciones_Por_Colaborador = new BLLDeducciones_Percepciones_Por_Colaborador();

        Planilla_Encabezado planEnc = new Planilla_Encabezado();
        Planilla_Detalle planDet = new Planilla_Detalle();

        DSPlanillaEnviar dSPlanillaEnviar = new DSPlanillaEnviar();


        DSPlanillaEnviarTableAdapters.DataTable2TableAdapter tableAdapter = new DSPlanillaEnviarTableAdapters.DataTable2TableAdapter();
        public frmMantenimientoPlanillas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método load del form 
        /// de mantenimiento de planillas 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMantenimientoPlanillas_Load(object sender, EventArgs e)
        {
            try
            {
                this.tslblUsuarioConectado.Text = "Usuario Conectado: " + frmLogin.colaboradorLoggeado.IDUsuario.IDUsuario +
    " Rol: " + frmLogin.colaboradorLoggeado.IDRol.Descripcion;
                //Método para configurar los valores de los datetimepicker
                ConfigurarDateTimePickerFechaDesde();
                ConfigurarDateTimePickerFechaHasta();
                ConfigurarDateTimePickerFechaPago();

                this.lblEstado2.Text = "";
                this.btnEnviar.Visible = false;

                //Cargar el datagridview de usuarios con el SELECT_ALL 
                //del DALPlanillaPago

                CargarLista();

                ////Limpiar los controles del form 
                LimpiarControles();

                ReportDataSource reportDataSource = new ReportDataSource("DataSetPlanillaEnviar", dSPlanillaEnviar.Tables["DataTable2"]);
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                this.reportViewer1.LocalReport.EnableExternalImages = true;
                ReportParameter param = new ReportParameter("quickResponse", "Cargar Código");
                this.reportViewer1.LocalReport.SetParameters(param);
                this.reportViewer1.RefreshReport();
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
            this.reportViewer1.RefreshReport();
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

                this.txtCod.Text = "pl";
                this.txtCod.BackColor = Color.White;

                this.txtNombre.Clear();
                this.txtNombre.BackColor = Color.White;

                this.lblEstado2.Text = "";


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
                this.btnEnviar.Visible = false;

                this.txtCod.Enabled = false;
                this.txtNombre.Enabled = false;

                this.dtpFechaDesde.Enabled = false;
                this.dtpFechaHasta.Enabled = false;
                this.dtpFechaPago.Enabled = false;



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
        /// de planillas de pago desde la base de datos 
        /// y cargarlo al datagridview
        /// </summary>
        private void CargarLista()
        {
            try
            {

                CambiarEstadoPlanillaInactiva();
                this.dgvPlanillas.DataSource = bLLPlanillaPago.SelectAll();
                this.dgvPlanillas.ClearSelection();
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

        private void CambiarEstadoPlanillaInactiva()
        {
            foreach (var planilla in bLLPlanillaPago.SelectAll())
            {
                if (planilla.Estado == PlanillaEstado.Activa &&
                    planilla.FechaPago < DateTime.Today)
                {
                    planilla.Estado = PlanillaEstado.Inactiva;
                }

            }
        }

        private void ConfigurarDateTimePickerFechaDesde()
        {
            //Asignar variables de tipo Datetime para realizar las comparaciones necesarias

            //1 - Si la fecha de hoy está entre el día 28 del mes anterior y el 13 del mes actual
            //El valor minimo se configura como el día 28 del mes anterior

            //2 - Si la fecha de hoy está entre el día 13 del mes actual y el 28 del mes acual
            //El valor mínimo se configura como el día 13 del mes actual 

            int anno = DateTime.Now.Year;
            int mes = DateTime.Now.Month;
            int dia28 = 28;
            int dia13 = 13;

            DateTime fechaActual = DateTime.Today;
            DateTime fechaMinima;

            DateTime mesAnterior = DateTime.Today.AddMonths(-1);
            DateTime fecha28MesAnterior = new DateTime(mesAnterior.Year, mesAnterior.Month, dia28);
            DateTime fecha13MesActual = new DateTime(anno, mes, dia13);

            if (fechaActual >= fecha28MesAnterior && fechaActual <= fecha13MesActual)
            {
                if (mesAnterior.Year < anno)
                {
                    fechaMinima = new DateTime(anno - 1, mes - 1, dia28);
                }
                else
                {
                    fechaMinima = new DateTime(anno, mes - 1, dia28);
                }

                this.dtpFechaDesde.MinDate = fechaMinima;
                this.dtpFechaDesde.MaxDate = fechaMinima;
            }

            else
            {
                fechaMinima = new DateTime(anno, mes, dia13);
                this.dtpFechaDesde.MinDate = fechaMinima;
                this.dtpFechaDesde.MaxDate = fechaMinima;
            }

        }

        private void ConfigurarDateTimePickerFechaHasta()
        {
            //La fecha hasta se calcula sumando 14 dias desde la fecha minima (configurada 
            //en el datetimepickerFechaDesde

            this.dtpFechaHasta.MinDate = this.dtpFechaDesde.Value.AddDays(14);
            this.dtpFechaHasta.MaxDate = this.dtpFechaDesde.Value.AddDays(14);


        }

        private void ConfigurarDateTimePickerFechaPago()
        {
            //La fecha de pago se calcula 14 días después de la
            //fecha "desde" pero se debe considerar si el dia 30 o 15
            //del mes es fin de semana
            // ** FEBRERO PAGA EL 28 (29 para AÑO BISIESTO) **

            DateTime fechaDesde = this.dtpFechaDesde.Value;
            DateTime fechaPago;
            int anno = DateTime.Now.Year;
            int febrero = 2;

            //Verificar si la fecha "desde" es entre el 13 y el 28 de febrero
            if (fechaDesde.Month == febrero && fechaDesde.Day >= 13)
            {
                if (DateTime.IsLeapYear(fechaDesde.Year))
                {
                    fechaPago = new DateTime(anno, febrero, 29);

                }
                else
                {
                    fechaPago = new DateTime(anno, febrero, 28);
                }
                if (fechaPago.DayOfWeek == DayOfWeek.Saturday)
                {
                    this.dtpFechaPago.MinDate = new DateTime(anno, febrero + 1, 2);
                    this.dtpFechaPago.MaxDate = new DateTime(anno, febrero + 1, 2);
                }
                if (fechaPago.DayOfWeek == DayOfWeek.Sunday)
                {
                    this.dtpFechaPago.MinDate = new DateTime(anno, febrero + 1, 1);
                    this.dtpFechaPago.MaxDate = new DateTime(anno, febrero + 1, 1);
                }
            }

            //Configurar la fecha de pago en el datetimepicker
            //15 si fecha desde es 28 
            //30 si fecha desde es 13

            if (this.dtpFechaDesde.Value.Day == 13)
            {
                this.dtpFechaPago.MinDate = new DateTime(anno, this.dtpFechaDesde.Value.Month, 30);
                this.dtpFechaPago.MaxDate = new DateTime(anno, this.dtpFechaDesde.Value.Month, 30);
            }

            if (this.dtpFechaDesde.Value.Day == 28)
            {
                this.dtpFechaPago.MinDate = new DateTime(anno, this.dtpFechaDesde.Value.Month + 1, 15);
                this.dtpFechaPago.MaxDate = new DateTime(anno, this.dtpFechaDesde.Value.Month + 1, 15);
            }

            //Verificar si la fecha de pago es sábado o domingo (se paga el lunes)
            if (this.dtpFechaPago.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                this.dtpFechaPago.MinDate = this.dtpFechaPago.Value.AddDays(2);
                this.dtpFechaPago.MinDate = this.dtpFechaPago.Value.AddDays(2);
            }

            if (this.dtpFechaDesde.Value.AddDays(14).DayOfWeek == DayOfWeek.Sunday)
            {
                this.dtpFechaPago.MinDate = this.dtpFechaPago.Value.AddDays(1);
                this.dtpFechaPago.MaxDate = this.dtpFechaPago.Value.AddDays(1);
            }


        }

        /// <summary>
        /// Evento del botón Agregar para agregar a la 
        /// planilla de pago exitosamente a la base de datos
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
                        this.txtCod.Text = this.txtCod.Text + bLLPlanillaPago.SecuenciadorPlanillasPago();

                        //habilitar los controles de texto, datetimepickers
                        //y radiobuttons

                        this.txtCod.Enabled = true;
                        this.txtCod.ReadOnly = false;
                        this.txtNombre.Enabled = true;
                        this.dtpFechaDesde.Enabled = true;
                        this.dtpFechaHasta.Enabled = true;
                        this.dtpFechaPago.Enabled = true;


                        break;

                    case 'U':

                        //habilitar los controles de texto, datetimepickers
                        //y radiobuttons

                        this.txtCod.ReadOnly = true;
                        this.txtNombre.Enabled = true;

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
        /// crear o actualizar una planilla de pago
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
            CrearActualizarPlanillaPago();
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


                // Validar Nombre
                if (!String.IsNullOrEmpty(this.txtNombre.Text.Trim()))
                {
                    this.errProv1.SetError(this.txtNombre, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.txtNombre, "Campo Nombre de planilla de pago no es correcto");
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
        /// Método que se encarga de validar si hay 
        /// al menos una planilla activa
        /// en los controles
        /// </summary>
        /// <returns></returns>
        private bool VerificarSiHayPlanillasActivas()
        {
            bool hayPlanillas = false;
            try
            {
                foreach (var planilla in bLLPlanillaPago.SelectAll())
                {
                    if (planilla.Estado == Enumeraciones.PlanillaEstado.Activa)
                    {
                        hayPlanillas = true;
                        break;
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
            return hayPlanillas;
        }

        /// <summary>
        /// Método para crear las planillas de pago y de igual manera actualizarlos
        /// </summary>
        private void CrearActualizarPlanillaPago()
        {
            //Crear la instancia de planilla de pago
            PlanillaPago oPlanillaPago = new PlanillaPago();

            oPlanillaPago.Codigo = this.txtCod.Text;
            oPlanillaPago.Nombre = this.txtNombre.Text;
            oPlanillaPago.Estado = Enumeraciones.PlanillaEstado.Activa;

            oPlanillaPago.FechaDesde = this.dtpFechaDesde.Value;
            oPlanillaPago.FechaHasta = this.dtpFechaHasta.Value;
            oPlanillaPago.FechaPago = this.dtpFechaPago.Value;

            //Insertar la planilla de pago a la base de datos
            //por medio del BLLPlanillaPago (método CREATE)

            if (bLLPlanillaPago.SelectById(this.txtCod.Text) != null)
            {

                bLLPlanillaPago.Update(oPlanillaPago);
            }
            else
            {
                if (VerificarSiHayPlanillasActivas())
                {
                    MessageBox.Show("No se puede agregar otra planilla como activa" +
                        " debido a que existe una planilla activa", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    bLLPlanillaPago.Create(oPlanillaPago);
                }

            }

            //Refrescar la lista
            CargarLista();

            //Ocultar el boton de confirmar
            this.btnConfirmar.Visible = false;

            //Limpiar los controles
            LimpiarControles();

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
        /// Evento del botón Eliminar para eliminar a la planilla 
        /// de pago exitosamente en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigoPlanilla = this.txtCod.Text;
            DialogResult resultado = MessageBox.Show("¿Está seguro(a) que desea eliminar la planilla de pago?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (bLLPlanillaPago.SelectById(codigoPlanilla).Estado ==
                PlanillaEstado.PorEnviar)
                {
                    Planilla_Detalle planDet = new Planilla_Detalle();
                    Planilla_Encabezado planEnc = new Planilla_Encabezado();

                    foreach (Planilla_Detalle planillaDet in bllPlanillaDetalle.SelectAll())
                    {
                        if (planillaDet.IdEncabezado.Codigo.Codigo == codigoPlanilla)
                        {
                            bllPlanillaDetalle.Delete(planillaDet.IdDetalle);
                            bllPlanillaEncabezado.Delete(planillaDet.IdEncabezado.IdEncabezado);
                        }
                    }
                    bLLPlanillaPago.Delete(codigoPlanilla);
                    CargarLista();
                    LimpiarControles();

                    MessageBox.Show("Ha eliminado un cálculo de planilla" +
                        "\nDeberá volver a cargar lar marcas." +
                        "\n" +
                        "\nRevise bien las marcas antes de cargarlas de nuevo al sistema",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmProcesoCargaDeMarcas frm = new frmProcesoCargaDeMarcas();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No puede eliminar planillas cuyo estado sea diferente a POR ENVIAR", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }

        /// <summary>
        /// Evento del botón Editar para editar a la planilla 
        /// de pago exitosamente en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            ResetearForm('U');
            this.btnConfirmar.Visible = true;
        }

        /// <summary>
        /// Evento para cerrar el form de Mantenimiento de 
        /// Planillas de Pago
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                this.errProv1.SetError(this.txtNombre, "Campo Nombre de planilla no es correcto");
                this.txtNombre.BackColor = Color.MistyRose;
            }
        }

        /// <summary>
        /// Evento que se encarga de seleccionar 
        /// el objeto planilla de pago en el datagrid view 
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

                this.btnAgregar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnEliminar.Enabled = true;
                this.btnLimpiar.Enabled = true;

                if (this.dgvPlanillas.SelectedRows.Count == 1)
                {
                    //Creamos instancia de planilla d epago
                    PlanillaPago oPlanillaPago = new PlanillaPago();
                    oPlanillaPago = this.dgvPlanillas.SelectedRows[0].DataBoundItem as PlanillaPago;  //Asignamos el valor seleccionado
                    //Asignamos los valores a cada control
                    this.txtCod.Text = oPlanillaPago.Codigo.ToString();
                    this.txtNombre.Text = oPlanillaPago.Nombre.ToString();
                    this.dtpFechaDesde.Text = oPlanillaPago.FechaDesde.ToString();
                    this.dtpFechaHasta.Text = oPlanillaPago.FechaHasta.ToString();
                    this.dtpFechaPago.Text = oPlanillaPago.FechaPago.ToString();

                    if (oPlanillaPago.Estado == Enumeraciones.PlanillaEstado.Activa)
                        this.lblEstado2.Text = "Activa";

                    if (oPlanillaPago.Estado == Enumeraciones.PlanillaEstado.Inactiva)
                        this.lblEstado2.Text = "Inactiva";

                    if (oPlanillaPago.Estado == Enumeraciones.PlanillaEstado.PorEnviar)
                    {
                        this.lblEstado2.Text = "Por Enviar";
                        CrearActualizarPlanEncyDetalle();
                    }

                    if (oPlanillaPago.Estado == Enumeraciones.PlanillaEstado.Enviada)
                    {
                        this.lblEstado2.Text = "Enviada";
                        CrearActualizarPlanEncyDetalle();
                    }


                    if (oPlanillaPago.Estado == Enumeraciones.PlanillaEstado.PorEnviar)
                    {
                        this.btnEnviar.Visible = true;
                    }
                    else
                    {
                        this.btnEnviar.Visible = false;
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


        private void CrearActualizarPlanEncyDetalle()
        {
            try
            {
                Colaborador oColaborador = new Colaborador();
                //Crear la instancia de Planillaencabezado


                //planEnc = this.dgvPlanillas.SelectedRows[0].DataBoundItem as Planilla_Encabezado;
                PlanillaPago planPago = this.dgvPlanillas.SelectedRows[0].DataBoundItem as PlanillaPago;

                foreach (Planilla_Encabezado enc in bllPlanillaEncabezado.SelectAll())
                {
                    if (bllPlanillaEncabezado.SelectById(enc.IdEncabezado).Codigo.Codigo == planPago.Codigo)
                    {
                        planEnc = enc;
                        break;
                    }
                }

                //Crear la instancia de PlanillaDetalle

                var obtenerPlanDet = bllPlanillaDetalle.SelectAll().Where(det => det.IdEncabezado.IdEncabezado == planEnc.IdEncabezado).ToList();

                foreach (var item in obtenerPlanDet)
                {
                    planDet = item;
                    oColaborador = bllPlanillaDetalle.SelectById(item.IdDetalle).IdColaborador;
                    break;
                }

                planDet.deducciones_Percepciones_Por_Colaborador = bLLDeducciones_Percepciones_Por_Colaborador.SelectTodo().Where(dedPerc
                    => dedPerc.Estado = true && dedPerc.IdColaborador.IDColaborador == oColaborador.IDColaborador).ToList();

                List<SolicitudVacaciones> solicitudVacaciones = bLLSolicitudVacaciones.SelectAll().Where(sol => sol.FechaSolicitarDesde
                >= planEnc.Codigo.FechaDesde && sol.FechaSolicitarHasta <= planEnc.Codigo.FechaHasta && sol.IDColaborador.IDColaborador == planDet.IdColaborador.IDColaborador
                && sol.Observaciones_Final == ObservacionSolicVacaciones.Aprobada && sol.Estado == true).ToList();

                decimal dolar = (decimal)(planEnc.TipoCambio);

                #region Creacion Código QR
                //Se consulta si el directorio temp existe caso contrario lo crea
                if (!Directory.Exists(@"C:\temp"))
                    Directory.CreateDirectory(@"C:\temp");
                // Convertir imagen a QR, se envía por parámetro lo que se requiere 

                string nombreCompletoColaborador = planDet.IdColaborador.Nombre + " " + planDet.IdColaborador.Apellido1 +
                    " " + planDet.IdColaborador.Apellido2;
                string montoAPagarCol = planEnc.TotalPagar.ToString();
                double dolares = (double)bllPlanillaDetalle.CalcularSalarioDolares(planDet, dolar);
                string montoAPagarDol = dolares.ToString();

                Image imagen = QuickResponse.QuickResponseGenerador(planDet.IdColaborador.IDColaborador, nombreCompletoColaborador, montoAPagarCol, montoAPagarDol, 53);
                // Salvar imagen en la carpeta temp
                imagen.Save(@"c:\temp\qr.png", ImageFormat.Png);
                // Config imagen del QR (Para poder pasar una imagen por parámetro se 
                //debe realizar con la siguiente linea
                string ruta = @"file:///" + @"C:/temp/qr.png";
                #endregion

                #region Creacion Reporte
                //Llamado e invocación del Reporte (si el fill del reporte tiene 
                //parametros)
                //Se deberá indicar los valores en el mismo orden como los recibe el
                //fill



                tableAdapter.Fill(dSPlanillaEnviar.DataTable2, planEnc.IdEncabezado);

                // Pasar parámetro siempre deberá llevar el mismo nombre del parametro 
                //creado y el valor

                ReportParameter param = new ReportParameter("quickResponse", ruta);

                reportViewer1.ProcessingMode = ProcessingMode.Local;

                //Pasamos el array de los parámetros al ReportViewer
                this.reportViewer1.LocalReport.SetParameters(param);
                //Se recarga el Reporte
                this.reportViewer1.RefreshReport();
                #endregion

                this.btnEnviar.Enabled = true;
            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");
                return;
            }
        }

        /// <summary>
        /// Método para enviar correo con la planilla 
        /// que está en estado por enviar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    this.errProv1.SetError(c, String.Empty);
                    this.errProv1.Clear();
                }

                DialogResult resultado = MessageBox.Show("¿Desea enviarla la planilla de pago con ID: " +
                   planEnc.IdEncabezado + " al correo: " + planDet.IdColaborador.CorreoElectronico + "?",
                   "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string rutaPDF = @"C:\temp\" + "Planilla-" + planEnc.IdEncabezado + "-Envío.pdf";
                    GenerarPDF(this.reportViewer1, false, rutaPDF);
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

        private void GenerarPDF(ReportViewer reportViewer, Boolean pTipoVertical, string rutaDestino)
        {
            try
            {
                if (!Directory.Exists(@"C:\temp"))
                    Directory.CreateDirectory(@"C:\temp");

                string deviceInfo =
                    "<DeviceInfo>" +
                        "  <OutputFormat>PDF</OutputFormat>";
                if (pTipoVertical)
                {
                    deviceInfo +=
                    "  <PageWidth>8.27in</PageWidth>" +
                    "  <PageHeight>11.69in</PageHeight>";

                }
                else
                {
                    deviceInfo +=
                        "  <PageWidth>11.69in</PageWidth>" +
                        "  <PageHeight>8.27in</PageHeight>";
                }

                deviceInfo += "<MarginTop>0.25in</MarginTop>" +
                    "  <MarginLeft>0.4in</MarginLeft>" +
                    "  <MarginRight>0.4in</MarginRight>" +
                    "  <MarginBottom>0.25in</MarginBottom>" +
                    "  <EmbedFonts>None</EmbedFonts>" +
                    "</DeviceInfo>";

                byte[] bytes = this.reportViewer1.LocalReport.Render("PDF", deviceInfo);

                using (FileStream stream = new FileStream(rutaDestino, FileMode.Create))
                {
                    stream.Write(bytes, 0, bytes.Length);
                }

                bool enviado = Email.Enviar("hola", planDet.NombreColaborador, planDet.IdColaborador.CorreoElectronico, rutaDestino);

                if (enviado == true)
                {
                    planEnc.Codigo.Estado = PlanillaEstado.Enviada;
                    bLLPlanillaPago.Update(planEnc.Codigo);
                    MessageBox.Show("La planilla con ID: " + planEnc.IdEncabezado + " se envió correctamente",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

