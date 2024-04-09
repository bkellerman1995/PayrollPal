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

namespace PayrollPal.UI.Procesos
{
    public partial class frmProcesoCalcularPlanilla : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        private DateTime fechaHoy = DateTime.Now;

        private bool encabezadoPlanCreado = false;

        private Planilla_Detalle planilla_Detalle = new Planilla_Detalle();
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

                this.txtIdEncPlan.Text = "Enc" + fechaHoy.ToString("yyyyMMdd") + BLLPlanilla_Encabezado.SecuenciadorPlanEnc();

                ConfigurarDateTimePickerFechaDesde();
                ConfigurarDateTimePickerFechaHasta();

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

        private void ConfigurarDateTimePickerFechaDesde()
        {
            this.dtpFechaDesde.Value = DateTime.Today;
            this.dtpFechaDesde.MinDate = this.dtpFechaDesde.Value;
            this.dtpFechaDesde.MaxDate = this.dtpFechaDesde.Value;
        }
        private void ConfigurarDateTimePickerFechaHasta()
        {
            this.dtpFechaHasta.Value = DateTime.Today;
            this.dtpFechaHasta.MinDate = this.dtpFechaHasta.Value;
            this.dtpFechaHasta.MaxDate = this.dtpFechaHasta.Value;
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
                    planilla_Detalle.IdDetalle = BLLPlanilla_Detalle.SecuenciadorPlanDetalle();
                    planilla_Detalle.IdColaborador = oColab;
                    planilla_Detalle.NombreColaborador = oColab.Nombre;
                    List<Planilla_Detalle> lista = new List<Planilla_Detalle>();

                    BLLColaborador.CalcularHorasOrdExt(oColab, oPago, planilla_Detalle);

                    lista.Add(planilla_Detalle);

                    this.dgvHorOrdvsExt.DataSource = lista;

                    this.dgvHorOrdvsExt.Columns["IdDetalle"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["IdEncabezado"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["IdColaborador"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["NombreColaborador"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["hrsTrabajadas"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["hrsExtras"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["MontoHora"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["SalarioBruto"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["CodigoDeduccionPercepcion"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["TipoDecPerc"].Visible = false;
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

        private void RevisarCombosVacios()
        {
            try
            {
                if (BLLPlanillaPago.SelectAll().Count != 0)
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

        private void InhabilitarControles()
        {
            try
            {
                ConfigurarDateTimePickerFechaDesde();
                ConfigurarDateTimePickerFechaHasta();

                this.txtImprimir.Text = "";

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
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
    }
}
