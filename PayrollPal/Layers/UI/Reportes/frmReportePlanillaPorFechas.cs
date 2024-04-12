using Microsoft.Reporting.WinForms;
using PayrollPal.Layers.BLL;
using PayrollPal.Layers.Entities;
using PayrollPal.Layers.IBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPal.Layers.UI.Reportes
{
    public partial class frmReportePlanillaPorFechas : Form
    {
        IBLLColaborador bLLColaborador = new BLLColaborador();

        DSPlanillaEnviar dSPlanillaPorFecha = new DSPlanillaEnviar();
        DSPlanillaEnviarTableAdapters.DataTable3TableAdapter tableAdapter = new DSPlanillaEnviarTableAdapters.DataTable3TableAdapter();

        public frmReportePlanillaPorFechas()
        {
            InitializeComponent();
        }


        private void frmReportePlanillaPorFechas_Load(object sender, EventArgs e)
        {
            List<Colaborador> listaColab = new List<Colaborador>();
            switch (frmLogin.colaboradorLoggeado.IDRol.IDRol)
            {
                case 1:
                    this.cmbColaborador.DataSource = bLLColaborador.SelectAll();
                    break;
                
                case 2:
                    this.cmbColaborador.DataSource = bLLColaborador.SelectAll().Where(
                            col => col.IDSupervisor.IDSupervisor == frmLogin.colaboradorLoggeado.supID).ToList();

                    break;
                case 3:
                    this.cmbColaborador.DataSource = frmLogin.colaboradorLoggeado;
                    break;
            }

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                this.errProv1.SetError(c, String.Empty);
                this.errProv1.Clear();
            }

            if (this.cmbColaborador.SelectedIndex > 0) 
            {
                Colaborador oColaborador = this.cmbColaborador.SelectedItem as Colaborador;
                this.errProv1.SetError(this.cmbColaborador, string.Empty);
                DateTime fechaInicio = new DateTime();
                DateTime fechaFinal = new DateTime();

                fechaInicio = this.dtpFechaDesde.Value.Date;
                fechaFinal = this.dtpFechaHasta.Value.Date;

                ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dSPlanillaPorFecha.Tables["DataTable3"]);
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                tableAdapter.Fill(dSPlanillaPorFecha.DataTable3, oColaborador.IDColaborador,fechaInicio.ToString("dd/MM/yyyy"),fechaFinal.ToString("dd/MM/yyyy"));
                this.reportViewer1.RefreshReport();
            }

            else
            {
                this.errProv1.SetError(this.cmbColaborador, "Campo colaborador no es correcto");

            }
        }
    }
}
