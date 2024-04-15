using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollPal.Layers.IBLL;
using PayrollPal.Layers.BLL;
using PayrollPal.Layers.Entities;
using PayrollPal.Enumeraciones;
using System.IO;
using PayrollPal.Layers.Util;
using System.Drawing.Imaging;
using Microsoft.Reporting.WinForms;
using System.Reflection;

namespace PayrollPal.Layers.UI.Consultas
{
    public partial class frmConsultaPlanillas : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        IBLLPlanilla_Encabezado bLLPlanilla_Encabezado = new BLLPlanilla_Encabezado();
        IBLLPlanilla_Detalle bLLPlanilla_Detalle = new BLLPlanilla_Detalle();
        IBLLColaborador bLLColaborador = new BLLColaborador();
        IBLLSolicitudVacaciones bLLSolicitudVacaciones = new BLLSolicitudVacaciones();
        IBLLDeducciones_Percepciones_Por_Colaborador bLLDeducciones_Percepciones_Por_Colaborador = new BLLDeducciones_Percepciones_Por_Colaborador();
        IBLLPlanillaPago bLLPlanillaPago = new BLLPlanillaPago();
        IBLLControlDeMarcas bLLControlDeMarcas = new BLLControlDeMarcas();

        Planilla_Encabezado planEnc = new Planilla_Encabezado();
        Planilla_Detalle planDet = new Planilla_Detalle();

        DSPlanillaEnviar dSPlanillaEnviar = new DSPlanillaEnviar();


        DSPlanillaEnviarTableAdapters.DataTable2TableAdapter tableAdapter = new DSPlanillaEnviarTableAdapters.DataTable2TableAdapter();

        public frmConsultaPlanillas()
        {
            InitializeComponent();
        }

        private void frmConsultaPlanillas_Load(object sender, EventArgs e)
        {
            this.tslblUsuarioConectado.Text = "Usuario Conectado: " + frmLogin.colaboradorLoggeado.IDUsuario.IDUsuario +
    " Rol: " + frmLogin.colaboradorLoggeado.IDRol.Descripcion;
            this.btnEnviar.Enabled = false;
            this.txtColab.Text = frmLogin.colaboradorLoggeado.IDColaborador;
            string idColaborador = this.txtColab.Text;
            CargarPlanillasDePagoPorFecha(idColaborador);


            ReportDataSource reportDataSource = new ReportDataSource("DataSetPlanillaEnviar", dSPlanillaEnviar.Tables["DataTable2"]);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer1.LocalReport.EnableExternalImages = true;
            ReportParameter param = new ReportParameter("quickResponse", "Cargar Código");
            this.reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();

        }

        private void CargarPlanillasDePagoPorFecha(string pIdColaborador)
        {
            List<Planilla_Encabezado> listaPlanEnc = bLLPlanilla_Encabezado.SelectAll();
            List<Planilla_Detalle> listaPlanDet = bLLPlanilla_Detalle.SelectAll().Where(
                det => det.IdColaborador.IDColaborador == pIdColaborador && 
                (det.IdEncabezado.Codigo.Estado == PlanillaEstado.PorEnviar ||
                det.IdEncabezado.Codigo.Estado == PlanillaEstado.Enviada
                || det.IdEncabezado.Codigo.Estado == PlanillaEstado.Activa)).ToList();

            var querySQL = from encabezado in listaPlanEnc
                           join detalle in listaPlanDet on encabezado.IdEncabezado equals detalle.IdEncabezado.IdEncabezado
                           select encabezado;


            this.dgvPlanillas.DataSource = querySQL.OrderBy(enc => enc.Fechahoy).ToList();
            this.dgvPlanillas.ClearSelection();

            if (querySQL.Count() > 0)
            {
                DateTime fechaPagoPrimer = querySQL.First().Codigo.FechaPago;
                DateTime fechaPagoUltimo = querySQL.Last().Codigo.FechaPago;
                ConfigurarDateTimePickerFechaDesde(fechaPagoPrimer);
                ConfigurarDateTimePickerFechaHasta(fechaPagoUltimo);
            }


        }

        private void ConfigurarDateTimePickerFechaDesde(DateTime fechaPagoPrimer)
        {
            this.dtpFechaDesde.Value = fechaPagoPrimer;
            this.dtpFechaDesde.MinDate = this.dtpFechaDesde.Value;
            this.dtpFechaDesde.MaxDate = this.dtpFechaDesde.Value;

        }

        private void ConfigurarDateTimePickerFechaHasta(DateTime fechaPagoUltimo)
        {
            this.dtpFechaHasta.Value = fechaPagoUltimo;
            this.dtpFechaHasta.MinDate = this.dtpFechaDesde.Value;
            this.dtpFechaHasta.MaxDate = this.dtpFechaDesde.Value;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

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
                    GenerarPDF(this.reportViewer1, rutaPDF);
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
                Colaborador oColaborador = bLLColaborador.SelectById(this.txtColab.Text);

                //Crear la instancia de Planillaencabezado
                

                planEnc = this.dgvPlanillas.SelectedRows[0].DataBoundItem as Planilla_Encabezado;


                //Crear la instancia de PlanillaDetalle

                var obtenerPlanDet = bLLPlanilla_Detalle.SelectAll().Where(det => det.IdEncabezado.IdEncabezado == planEnc.IdEncabezado).ToList();

                foreach (var item in obtenerPlanDet)
                {
                    planDet = item;
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
                double dolares = (double)bLLPlanilla_Detalle.CalcularSalarioDolares(planDet, dolar);
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

        private void GenerarPDF(ReportViewer reportViewer, string rutaDestino)
        {
            if (!Directory.Exists(@"C:\temp"))
                Directory.CreateDirectory(@"C:\temp");

            string deviceInfo =

             "<DeviceInfo>" +
             "  <OutputFormat>PDF</OutputFormat>" +
             "  <PageWidth>8.5in</PageWidth>" +
             "  <PageHeight>11in</PageHeight>" +
             "  <MarginTop>0.5in</MarginTop>" +
             "  <MarginLeft>0.5in</MarginLeft>" +
             "  <MarginRight>0.5in</MarginRight>" +
             "  <MarginBottom>0.5in</MarginBottom>" +
             "</DeviceInfo>";

            Warning[] warnings;
            string[] streamIds;
            string mimeType;
            string encoding;
            string fileNameExtension;

            // Render the report to byte array
            byte[] bytes = this.reportViewer1.LocalReport.Render("PDF", deviceInfo, out mimeType, out encoding, out fileNameExtension, out streamIds, out warnings);

            // Save the byte array to a file
            File.WriteAllBytes(rutaDestino, bytes);

            bool enviado = Email.Enviar("hola", planDet.NombreColaborador, planDet.IdColaborador.CorreoElectronico, rutaDestino);

            if (enviado == true)
            {
                planEnc.Codigo.Estado = PlanillaEstado.Enviada;
                bLLPlanillaPago.Update(planEnc.Codigo);
                MessageBox.Show("La planilla con ID: " + planEnc.IdEncabezado + " se envió correctamente",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvPlanillas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvPlanillas.SelectedRows.Count == 1)
            {

                this.btnEnviar.Enabled = true;

                CrearActualizarPlanEncyDetalle();
            }
            else
            {
                this.btnEnviar.Enabled = false;
            }
        }

        private void dgvPlanillas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (frmLogin.colaboradorLoggeado.IDRol.IDRol)
            {
                case 1:
                    if (this.dgvPlanillas.SelectedRows.Count == 1)
                    {

                        this.btnEliminar.Visible = true;
                    }
                    else
                    {
                        this.btnEliminar.Enabled = false;
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el cálculo de planilla?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Colaborador oColaborador = bLLColaborador.SelectById(this.txtColab.Text);

                    planEnc = this.dgvPlanillas.SelectedRows[0].DataBoundItem as Planilla_Encabezado;


                    //Crear la instancia de PlanillaDetalle

                    var obtenerPlanDet = bLLPlanilla_Detalle.SelectAll().Where(det => det.IdEncabezado.IdEncabezado == planEnc.IdEncabezado).ToList();

                    foreach (var item in obtenerPlanDet)
                    {
                        planDet = item;
                        break;
                    }

                    bLLPlanilla_Detalle.Delete(planDet.IdDetalle);
                    bLLPlanilla_Encabezado.Delete(planEnc.IdEncabezado);

                    foreach (var item in bLLControlDeMarcas.SelectAll().Where(cont => cont.IdColaborador == oColaborador.IDColaborador
                    && DateTime.Parse(cont.Fecha) >= planEnc.Codigo.FechaDesde && DateTime.Parse(cont.Fecha) <= planEnc.Codigo.FechaHasta
                    && planEnc.Codigo.Estado == PlanillaEstado.PorEnviar).ToList())
                    {
                        bLLControlDeMarcas.DELETEBYID(item.idMarca);
                    }

                    MessageBox.Show("Planilla de pago: " + planEnc.IdEncabezado + " eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
