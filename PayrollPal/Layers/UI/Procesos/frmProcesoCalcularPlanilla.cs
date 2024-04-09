using PayrollPal.Layers.BLL;
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
using PayrollPal.Layers.Entities;
using PayrollPal.Layers.Util;
using PayrollPal.Layers;
using PayrollPal.Enumeraciones;

namespace PayrollPal.UI.Procesos
{
    public partial class frmProcesoCalcularPlanilla : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        private bool encabezadoPlanCreado = false;

        private ServicioBCCR servicioBCCR = new ServicioBCCR();

        private Planilla_Detalle planDet = new Planilla_Detalle();

        public frmProcesoCalcularPlanilla()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Método load del form 
        /// de Cálculo de Planilla 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProcesoCalcularPlanilla_Load(object sender, EventArgs e)
        {
            try
            {

                this.txtIdEncPlan.Text = "Enc" + DateTime.Now.ToString("yyyyMMdd") + BLLPlanilla_Encabezado.SecuenciadorPlanEnc();

                CargartxtTipoCambio();
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

        private void CargartxtTipoCambio()
        {
            try
            {
                foreach (var dolar in servicioBCCR.GetDolar(DateTime.Today, DateTime.Today, "318"))
                {
                    this.txtTipoCambio.Text = dolar.Monto.ToString();
                }

                this.lblTipoCambio2.Text = "para hoy " + DateTime.Today.ToString("dd/MM/yyyy") + " (venta)           ₡";
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

        private void CargarDGVMarcas()
        {
            try
            {
                if ((this.cmbColaborador.SelectedItem != null && this.cmbColaborador.SelectedIndex != 0)
                    && (this.cmbPlanillas.SelectedItem != null && this.cmbPlanillas.SelectedIndex != 0))
                {
                    Colaborador oColaborador = (Colaborador)this.cmbColaborador.SelectedItem;
                    this.dgvListaMarcas.DataSource = BLLControlDeMarcas.SelectAll().Where(marc => marc.HorasTrabajadas >= 10
                    && marc.IdColaborador == oColaborador.IDColaborador).ToList();
                    this.dgvListaMarcas.ClearSelection();
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

        private void CargarDGVHorOrdExt()
        {
            try
            {
                if ((this.cmbColaborador.SelectedItem != null && this.cmbColaborador.SelectedIndex != 0)
                    && (this.cmbPlanillas.SelectedItem != null && this.cmbPlanillas.SelectedIndex != 0))
                {
                    Colaborador oColab = (Colaborador)this.cmbColaborador.SelectedItem;
                    PlanillaPago oPago = (PlanillaPago)this.cmbPlanillas.SelectedItem;

                    planDet.IdColaborador = oColab;
                    planDet.NombreColaborador = oColab.Nombre;
                    List<Planilla_Detalle> lista = new List<Planilla_Detalle>();

                    BLLColaborador.CalcularHorasOrdExt(oColab, oPago, planDet);

                    lista.Add(planDet);

                    this.dgvHorOrdvsExt.DataSource = lista;

                    this.dgvHorOrdvsExt.Columns["IdDetalle"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["IdEncabezado"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["IdColaborador"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["NombreColaborador"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["hrsTrabajadas"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["hrsExtras"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["MontoHora"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["SalarioBruto"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["SalarioNeto"].Visible = false;

                    this.dgvHorOrdvsExt.ClearSelection();
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

        private void CargarCombos()
        {
            List<PlanillaPago> listaPlanillas = BLLPlanillaPago.SelectAll().Where(planilla
                => planilla.Estado == Enumeraciones.PlanillaEstado.Activa).ToList();

            this.cmbPlanillas.Items.Add(" ====SELECCIONE====");

            foreach (var colab in listaPlanillas)
            {
                this.cmbPlanillas.Items.Add(colab);
            }

            List<Colaborador> listaColaboradores = BLLColaborador.SelectAll().Where(colab
                => colab.IDRol.IDRol == 3 && colab.IDSupervisor.IDSupervisor != "0").ToList();


            this.cmbColaborador.Items.Add(" ====SELECCIONE====");
            foreach (var colab in listaColaboradores)
            {
                this.cmbColaborador.Items.Add(colab);
            }
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

                this.cmbPlanillas.SelectedIndex = 0;
                this.cmbColaborador.SelectedIndex = 0;
                this.txtImprimir.Clear();
                this.btnGenerarColilla.Enabled = true;
                this.btnGenerarColilla.Focus();

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
            try
            {
                if (BLLPlanillaPago.SelectAll().Where(planilla => planilla.Estado
                == Enumeraciones.PlanillaEstado.Activa).ToList().Count != 0)
                {
                    this.errProv1.SetError(this.cmbPlanillas, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbPlanillas, "No puede generar una colilla de pago sin planilla");

                }

                if (BLLColaborador.SelectAll().Where(col => col.IDSupervisor.IDSupervisor != "0" && col.IDRol.IDRol == 3).Count() != 0)
                {
                    this.errProv1.SetError(this.cmbColaborador, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbColaborador, "No puede generar una colilla de pago sin colaboradores o colaboradores sin supervisor." +
                        "\nRevise que existan colaboradores y que tengan un supervisor asignado.");

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
        private void cmbColaborador_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDGVMarcas();
            CargarDGVHorOrdExt();
        }

        private void cmbPlanilla_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDGVMarcas();
            CargarDGVHorOrdExt();

            PlanillaPago oPlanPago;
            if (this.cmbPlanillas.SelectedIndex != 0)
            {
                oPlanPago = this.cmbPlanillas.SelectedItem as PlanillaPago;
                this.dtpFechaDesde.Value = oPlanPago.FechaDesde;
                this.dtpFechaDesde.MinDate = this.dtpFechaDesde.Value;
                this.dtpFechaDesde.MaxDate = this.dtpFechaDesde.Value;

                this.dtpFechaHasta.Value = oPlanPago.FechaHasta;
                this.dtpFechaHasta.MinDate = this.dtpFechaHasta.Value;
                this.dtpFechaHasta.MaxDate = this.dtpFechaHasta.Value;
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnGenerarColilla_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    this.errProv1.SetError(c, String.Empty);
                    this.errProv1.Clear();
                }
                //Validar que todos los campos del form estén correctamente llenados 
                //para agregar o actualizar el colaborador correctamente
                if (!ValidarCampos())
                {
                    return;
                }
                this.btnGenerarColilla.Enabled = false;

                //Llamar al método que crea y actualiza los usuarios
                CrearActualizarPlanEncyDetalle();

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

                //Validar CargaTipoCambio

                if (!String.IsNullOrEmpty(this.txtTipoCambio.Text.Trim()))
                {
                    this.errProv1.SetError(this.txtTipoCambio, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.txtTipoCambio, "El valor del tipo de cambio del dólar no se cargó correctamente ");
                    return false;
                }

                //Validar combo Planilla

                if (this.cmbPlanillas.SelectedIndex != 0)
                {
                    this.errProv1.SetError(this.cmbPlanillas, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbPlanillas, "Campo planilla de pago no es correcto");
                    return false;
                }

                //Validar combo Colaborador

                if (this.cmbColaborador.SelectedIndex != 0)
                {
                    this.errProv1.SetError(this.cmbColaborador, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbColaborador, "Campo colaborador no es correcto");
                    return false;
                }

                //Validar dgvMarcas

                if (this.dgvListaMarcas.Rows.Count != 0)
                {
                    this.errProv1.SetError(this.dgvListaMarcas, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.dgvListaMarcas, "No existen marcas o no han sido correctamente cargadas");
                    return false;
                }

                //Validar dgvHorOrdExt

                if (this.dgvHorOrdvsExt.Rows.Count != 0)
                {
                    this.errProv1.SetError(this.dgvHorOrdvsExt, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.dgvHorOrdvsExt, "No existen horas o no han sido correctamente cargadas");
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

        private void CrearActualizarPlanEncyDetalle()
        {
            Colaborador oColaborador = new Colaborador();
            StringBuilder impresion = new StringBuilder();
            //Crear la instancia de PlanillaDetalle

            oColaborador = this.cmbColaborador.SelectedItem as Colaborador;
            planDet.IdDetalle = BLLPlanilla_Detalle.SecuenciadorPlanDetalle();
            planDet.IdColaborador = oColaborador;
            planDet.NombreColaborador = oColaborador.Nombre + " " + oColaborador.Apellido1 + " " + oColaborador.Apellido2;
            planDet.hrsTrabajadas = planDet.hrsTrabajadas;
            planDet.hrsExtras = planDet.hrsExtras;
            planDet.MontoHora = oColaborador.SalarioHora;
            planDet.SalarioBruto = BLLPlanilla_Detalle.CalcularSalarioBruto(planDet);
            planDet.deducciones_Percepciones_Por_Colaborador = BLLDeducciones_Percepciones_Por_Colaborador.SelectTodo().Where(dedPerc
                => dedPerc.Estado = true && dedPerc.IdColaborador.IDColaborador == oColaborador.IDColaborador).ToList();

            planDet.SalarioNeto = BLLPlanilla_Detalle.CalcularSalarioNeto(planDet);

            //Crear la instancia de PlanillaEncabezado
            Planilla_Encabezado planEnc = new Planilla_Encabezado();

            planEnc.IdEncabezado = this.txtIdEncPlan.Text;
            planEnc.Codigo = (PlanillaPago)this.cmbPlanillas.SelectedItem;
            planEnc.TipoCambio = Double.Parse(this.txtTipoCambio.Text);
            planEnc.TotalIngresos = (double)BLLPlanilla_Detalle.CalcularSalarioBruto(planDet);
            planEnc.TotalGastos = (double)BLLPlanilla_Detalle.CalcularSalarioBruto(planDet) - (double)BLLPlanilla_Detalle.CalcularSalarioNeto(planDet);
            planEnc.TotalPagar = (double)BLLPlanilla_Detalle.CalcularSalarioNeto(planDet);

            impresion.AppendLine("ENVIO DE PLANILLA:  " + planEnc.IdEncabezado);
            impresion.AppendLine("");
            impresion.AppendLine("Detalle de planilla:  " + planDet.IdDetalle);
            impresion.AppendLine("");
            impresion.AppendLine("ID Colaborador:  " + planDet.IdColaborador);
            impresion.AppendLine("Nombre completo:  " + planDet.NombreColaborador);
            impresion.AppendLine("");
            impresion.AppendLine("");
            impresion.AppendLine("Fecha de pago: " + planEnc.Codigo.FechaPago.ToString("dd/MM/yyyy"));
            impresion.AppendLine("");
            impresion.AppendLine("--Desde:  " + planEnc.Codigo.FechaDesde.ToString("dd/MM/yyyy"));
            impresion.AppendLine("--Hasta:  " + planEnc.Codigo.FechaHasta.ToString("dd/MM/yyyy"));
            impresion.AppendLine("");
            impresion.AppendLine("Horas Ordinarias trabajadas: " + planDet.hrsTrabajadas);
            impresion.AppendLine("Horas Extraordinarias trabajadas: " + planDet.hrsExtras);
            impresion.AppendLine("Total de Horas trabajadas: " + (planDet.hrsTrabajadas + planDet.hrsExtras));
            impresion.AppendLine("");
            impresion.AppendLine("Salario por Hora Ordinaria: ₡" + planDet.IdColaborador.SalarioHora);
            impresion.AppendLine("Salario por Hora Extraordinaria: ₡" + (planDet.IdColaborador.SalarioHora) * (decimal)1.5);
            impresion.AppendLine("");
            impresion.AppendLine("=================");
            impresion.AppendLine("DEDUCCIONES");
            impresion.AppendLine("=================");
            impresion.AppendLine("");

            foreach (var item in planDet.deducciones_Percepciones_Por_Colaborador)
            {
                Deducciones_Percepciones odedPerc = BLLDeduccionesPercepciones.SelectById(item.CodigoDeduccionPercepcion.CodigoDeduccionPercepcion);
                if (odedPerc.Tipo == Enumeraciones.TipoPercepcionDeduccion.Deduccion)
                {
                    impresion.AppendLine("-- " + odedPerc.ToString());
                }
            }
            impresion.AppendLine("");
            impresion.AppendLine("Total de Deducciones: ₡" + planEnc.TotalGastos);

            impresion.AppendLine("");
            impresion.AppendLine("");
            impresion.AppendLine("=================");
            impresion.AppendLine("PERCEPCIONES");
            impresion.AppendLine("=================");
            impresion.AppendLine("");


            foreach (var item in planDet.deducciones_Percepciones_Por_Colaborador)
            {
                Deducciones_Percepciones odedPerc = BLLDeduccionesPercepciones.SelectById(item.CodigoDeduccionPercepcion.CodigoDeduccionPercepcion);
                if (odedPerc.Tipo == Enumeraciones.TipoPercepcionDeduccion.Percepcion)
                {
                    impresion.AppendLine("-- " + odedPerc.ToString());
                }
            }
            impresion.AppendLine("-------------------------");
            impresion.AppendLine("Vacaciones disfutadas");
            impresion.AppendLine("-------------------------");

            List<SolicitudVacaciones> solicitudVacaciones = BLLSolicitudVacaciones.SelectAll().Where(sol => sol.FechaSolicitarDesde
            >= planEnc.Codigo.FechaDesde && sol.FechaSolicitarHasta <= planEnc.Codigo.FechaHasta && sol.IDColaborador.IDColaborador == planDet.IdColaborador.IDColaborador
            && sol.Observaciones_Final == ObservacionSolicVacaciones.Aprobada && sol.Estado == true).ToList();


            foreach (var item in solicitudVacaciones)
            { 
                impresion.AppendLine("-- " + item.ToString());
            }
            impresion.AppendLine("-----------------------");

            impresion.AppendLine("");
            impresion.AppendLine("");
            impresion.AppendLine("Total de Percepciones: ₡" + planEnc.TotalIngresos);
            impresion.AppendLine("");
            impresion.AppendLine("");
            impresion.AppendLine("TOTAL A PAGAR: ₡" + planEnc.TotalPagar);

            decimal dolar = decimal.Parse(this.txtTipoCambio.Text);

            impresion.AppendLine("TOTAL A PAGAR: $" + BLLPlanilla_Detalle.CalcularSalarioDolares(planDet, dolar));

            this.txtImprimir.Text = impresion.ToString();

            planEnc.Codigo.Estado = PlanillaEstado.PorEnviar;

            BLLPlanilla_Encabezado.Create(planEnc);
            BLLPlanilla_Detalle.Create(planDet);

        }
    }
}
