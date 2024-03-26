using PayrollPal.Entities;
using PayrollPal.Layers.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPal.UI.Consultas
{
    public partial class frmConsultaMarcas : Form
    {
        public frmConsultaMarcas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para cargar el archivo JSON que contiene el control de marcas
        /// de los colaboradores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCargarArchivoJson_Click(object sender, EventArgs e)
        {
            try
            {
                //Configurar los atributos del objeto OpenFileDialog
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Seleccione el archivo JSON de las marcas";
                ofd.SupportMultiDottedExtensions = true;
                ofd.DefaultExt = "*.json";
                ofd.Filter = "Archivo JSON (*.json) | *.json";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ofd.FileName = "";

                //Verificacion de que el archivo se seleccione
                if (ofd.ShowDialog(this) == DialogResult.OK) 
                {
                    try
                    {
                        this.txtRutaArchivoJSON.Text = ofd.FileName;
                        this.pctCargarJSON.Image = PayrollPal.Properties.Resources.Json_conCheck;
                        HabilitarBotonMostrarLista();
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Ocurrió un error al cargar el archivo: "+ er.Message, 
                            "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Ocurrió un error: " + er.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HabilitarBotonMostrarLista()
        {
            this.btnMostrarListaMarcas.Enabled = true;
        }

        private void frmConsultaMarcas_Load(object sender, EventArgs e)
        {
            CargarEstadoBotones();
            this.pctCargarJSON.Image = PayrollPal.Properties.Resources.Json_sinCheck;
        }

        private void CargarEstadoBotones()
        {
            this.btnCargarArchivoJson.Enabled = true;
            this.btnMostrarListaMarcas.Enabled = false;

        }

        private void btnMostrarListaMarcas_Click(object sender, EventArgs e)
        {
            try
            {
                ControlDeMarcas control = new ControlDeMarcas();
                BLLControlDeMarcas.DELETE();
                control.ObtenerMarcasJSON(this.txtRutaArchivoJSON.Text);
                this.dgvListaMarcas.DataSource = BLLControlDeMarcas.SelectAll();
                this.dgvListaMarcas.ClearSelection();

            }
            catch (Exception er)
            {
                MessageBox.Show("Ocurrió un error al cargar las marcas en la tabla: " + er.Message);
            }
        }
    }
}
