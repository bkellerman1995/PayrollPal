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

namespace PayrollPal.Layers.UI.Consultas
{
    public partial class frmConsultaPlanillas : Form
    {

        IBLLPlanilla_Encabezado bLLPlanilla_Encabezado = new BLLPlanilla_Encabezado();
        IBLLPlanilla_Detalle bLLPlanilla_Detalle = new BLLPlanilla_Detalle();
        public frmConsultaPlanillas()
        {
            InitializeComponent();
        }

        private void frmConsultaPlanillas_Load(object sender, EventArgs e)
        {
            this.btnConsultar.Enabled = false;
            this.btnEnviar.Enabled = false;
            this.txtColab.Text = "col21";
            string idColaborador = this.txtColab.Text;
            CargarPlanillasDePagoPorFecha(idColaborador);


            this.reportViewer1.RefreshReport();
        }



        private void CargarPlanillasDePagoPorFecha(string pIdColaborador)
        {
            List<Planilla_Encabezado> listaPlanEnc = bLLPlanilla_Encabezado.SelectAll();
            List<Planilla_Detalle> listaPlanDet = bLLPlanilla_Detalle.SelectAll().Where(
                det => det.IdColaborador.IDColaborador == pIdColaborador).ToList();

            var querySQL = from encabezado in listaPlanEnc
                           join detalle in listaPlanDet on encabezado.IdEncabezado equals detalle.IdEncabezado.IdEncabezado
                           select encabezado;

            //List<Planilla_Encabezado> listaEnc = new List<Planilla_Encabezado>();

            //foreach (var planEnc in querySQL)
            //{
            //    listaEnc.Add(planEnc);
            //}


            this.dgvPlanillas.DataSource = querySQL.OrderBy(enc => enc.Fechahoy).ToList();
            this.dgvPlanillas.ClearSelection();
            ConfigurarDateTimePickerFechaDesde(querySQL.First());
            ConfigurarDateTimePickerFechaHasta(querySQL.Last());
        }

        private void ConfigurarDateTimePickerFechaDesde(Planilla_Encabezado planilla_Encabezado)
        {
            this.dtpFechaDesde.Value = planilla_Encabezado.Fechahoy;
            this.dtpFechaDesde.MinDate = this.dtpFechaDesde.Value;
            this.dtpFechaDesde.MaxDate = this.dtpFechaDesde.Value;

        }

        private void ConfigurarDateTimePickerFechaHasta(Planilla_Encabezado planilla_Encabezado)
        {
            this.dtpFechaDesde.Value = planilla_Encabezado.Fechahoy;
            this.dtpFechaDesde.MinDate = this.dtpFechaDesde.Value;
            this.dtpFechaDesde.MaxDate = this.dtpFechaDesde.Value;
        }

        private void dgvPlanillas_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvPlanillas.SelectedRows.Count == 1)
            {
                this.btnConsultar.Enabled = true;
                this.btnEnviar.Enabled = true;
            }
            else
            {
                this.btnConsultar.Enabled = false;
                this.btnEnviar.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
