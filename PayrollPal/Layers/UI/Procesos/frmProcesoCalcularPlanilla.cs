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
using PayrollPal.Layers.IBLL;
using System.IO;
using System.Drawing.Imaging;
using Microsoft.Reporting.WinForms;
using PayrollPal.Layers.UI;

namespace PayrollPal.UI.Procesos
{
    public partial class frmProcesoCalcularPlanilla : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");


        private ServicioBCCR servicioBCCR = new ServicioBCCR();

        private Planilla_Detalle planDet = new Planilla_Detalle();
        private Planilla_Encabezado planEnc = new Planilla_Encabezado();

        DSPlanillaEnviar dSPlanillaAEnviar = new DSPlanillaEnviar();


        DSPlanillaEnviarTableAdapters.DataTable2TableAdapter tableAdapter = new DSPlanillaEnviarTableAdapters.DataTable2TableAdapter();


        IBLLPlanilla_Encabezado bLLPlanilla_Encabezado = new BLLPlanilla_Encabezado();
        IBLLControlDeMarcas bLLControlDeMarcas = new BLLControlDeMarcas();
        IBLLColaborador bLLColaborador = new BLLColaborador();
        IBLLPlanillaPago bLLPlanillaPago = new BLLPlanillaPago();
        IBLLPlanilla_Detalle bLLPlanilla_Detalle = new BLLPlanilla_Detalle();
        IBLLDeducciones_Percepciones_Por_Colaborador bLLDeducciones_Percepciones_Por_Colaborador = new BLLDeducciones_Percepciones_Por_Colaborador();
        IBLLDeduccionesPercepciones bLLDeduccionesPercepciones = new BLLDeduccionesPercepciones();
        IBLLSolicitudVacaciones bLLSolicitudVacaciones = new BLLSolicitudVacaciones();


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
                this.tslblUsuarioConectado.Text = "Usuario Conectado: " + frmLogin.colaboradorLoggeado.IDUsuario.IDUsuario +
    " Rol: " + frmLogin.colaboradorLoggeado.IDRol.Descripcion;
                this.txtIdEncPlan.Text = "Enc" + DateTime.Now.ToString("yyyyMMdd") + bLLPlanilla_Encabezado.SecuenciadorPlanEnc();

                CargartxtTipoCambio();
                CargarCombos();

                //Limpiar los controles del form 
                LimpiarControles();
                RevisarCombosVacios();

                ReportDataSource reportDataSource = new ReportDataSource("DataSetPlanillaEnviar", dSPlanillaAEnviar.Tables["DataTable2"]);
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
                    this.dgvListaMarcas.DataSource = bLLControlDeMarcas.SelectAll().Where(marc => marc.IdColaborador == oColaborador.IDColaborador).ToList();
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

                    bLLColaborador.CalcularHorasOrdExt(oColab, oPago, planDet);

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
            List<PlanillaPago> listaPlanillas = bLLPlanillaPago.SelectAll().Where(planilla
                => planilla.Estado == Enumeraciones.PlanillaEstado.Activa).ToList();

            this.cmbPlanillas.Items.Add(" ====SELECCIONE====");

            foreach (var colab in listaPlanillas)
            {
                this.cmbPlanillas.Items.Add(colab);
            }

            List<Colaborador> listaColaboradores = bLLColaborador.SelectAll().Where(colab
                => colab.Estado == true).ToList();


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
                if (bLLPlanillaPago.SelectAll().Where(planilla => planilla.Estado
                == Enumeraciones.PlanillaEstado.Activa).ToList().Count != 0)
                {
                    this.errProv1.SetError(this.cmbPlanillas, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbPlanillas, "No puede generar una colilla de pago sin planilla");

                }

                if (bLLColaborador.SelectAll().Where(col => col.IDSupervisor.IDSupervisor != "0" && col.IDRol.IDRol == 3).Count() != 0)
                {
                    this.errProv1.SetError(this.cmbColaborador, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbColaborador, "No puede generar una colilla de pago para los colaboradores regulares o colaboradores sin supervisor." +
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
            foreach (Control c in this.Controls)
            {
                this.errProv1.SetError(c, String.Empty);
                this.errProv1.Clear();
            }
            CargarDGVMarcas();
            CargarDGVHorOrdExt();
        }

        private void cmbPlanilla_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                this.errProv1.SetError(c, String.Empty);
                this.errProv1.Clear();
            }
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
            //Crear la instancia de PlanillaDetalle


            oColaborador = this.cmbColaborador.SelectedItem as Colaborador;
            planDet.IdDetalle = bLLPlanilla_Detalle.SecuenciadorPlanDetalle();
            planDet.IdColaborador = oColaborador;
            planDet.NombreColaborador = oColaborador.Nombre + " " + oColaborador.Apellido1 + " " + oColaborador.Apellido2;
            planDet.hrsTrabajadas = planDet.hrsTrabajadas;
            planDet.hrsExtras = planDet.hrsExtras;
            planDet.MontoHora = oColaborador.SalarioHora;
            planDet.SalarioBruto = bLLPlanilla_Detalle.CalcularSalarioBruto(planDet);
            planDet.deducciones_Percepciones_Por_Colaborador = bLLDeducciones_Percepciones_Por_Colaborador.SelectTodo().Where(dedPerc
                => dedPerc.Estado = true && dedPerc.IdColaborador.IDColaborador == oColaborador.IDColaborador).ToList();

            planDet.SalarioNeto = bLLPlanilla_Detalle.CalcularSalarioNeto(planDet);

            //Crear la instancia de PlanillaEncabezado


            planEnc.IdEncabezado = this.txtIdEncPlan.Text;
            planEnc.Codigo = (PlanillaPago)this.cmbPlanillas.SelectedItem;
            planEnc.TipoCambio = Double.Parse(this.txtTipoCambio.Text);
            planEnc.TotalIngresos = (double)bLLPlanilla_Detalle.CalcularSalarioBruto(planDet);
            planEnc.TotalGastos = (double)bLLPlanilla_Detalle.CalcularSalarioBruto(planDet) - (double)bLLPlanilla_Detalle.CalcularSalarioNeto(planDet);
            planEnc.TotalPagar = (double)bLLPlanilla_Detalle.CalcularSalarioNeto(planDet);
            planEnc.Fechahoy = DateTime.Today;


            List<SolicitudVacaciones> solicitudVacaciones = bLLSolicitudVacaciones.SelectAll().Where(sol => sol.FechaSolicitarDesde
            >= planEnc.Codigo.FechaDesde && sol.FechaSolicitarHasta <= planEnc.Codigo.FechaHasta && sol.IDColaborador.IDColaborador == planDet.IdColaborador.IDColaborador
            && sol.Observaciones_Final == ObservacionSolicVacaciones.Aprobada && sol.Estado == true).ToList();

            decimal dolar = decimal.Parse(this.txtTipoCambio.Text);


            planEnc.Codigo.Estado = PlanillaEstado.PorEnviar;
            planDet.IdEncabezado = planEnc;

            bLLPlanillaPago.Update(planEnc.Codigo);

            bLLPlanilla_Encabezado.Create(planEnc);
            bLLPlanilla_Detalle.Create(planDet);

            #region Creacion Código QR
            //Se consulta si el directorio temp existe caso contrario lo crea
            if (!Directory.Exists(@"C:\temp"))
                Directory.CreateDirectory(@"C:\temp");
            // Convertir imagen a QR, se envía por parámetro lo que se requiere 

            string nombreCompletoColaborador = planDet.IdColaborador.Nombre + " " + planDet.IdColaborador.Apellido1 +
                " " + planDet.IdColaborador.Apellido2;
            string montoAPagarCol = planEnc.TotalPagar.ToString();
            double dolares = (double)bLLPlanilla_Detalle.CalcularSalarioDolares(planDet, decimal.Parse(this.txtTipoCambio.Text));
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



            this.tableAdapter.Fill(this.dSPlanillaAEnviar.DataTable2, planEnc.IdEncabezado);
            // Pasar parámetro siempre deberá llevar el mismo nombre del parametro 
            //creado y el valor

            ReportParameter param = new ReportParameter("quickResponse", ruta);

            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(param);
            //Se recarga el Reporte
            this.reportViewer1.RefreshReport();
            #endregion

            DialogResult resultado = MessageBox.Show("Planilla de pago: " + planEnc.Codigo.Codigo + "Generada" +
                "\n¿Desea enviarla al colaborador ahora?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                string rutaPDF = @"C:\temp\" + "Planilla-" + planEnc.IdEncabezado + "-Envío.pdf";
                GenerarPDF(this.reportViewer1,false, rutaPDF);
            }

        }

        private void GenerarPDF(ReportViewer reportViewer, Boolean pTipoVertical,string rutaDestino)
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
