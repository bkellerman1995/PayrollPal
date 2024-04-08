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
        private bool click_Agregar;
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
                        this.errProv1.Clear();
                        HabilitarBotonMostrarLista();
                        ofd.Dispose();
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
            click_Agregar = false;
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
                click_Agregar = true;
                this.errProv1.Clear();
                ControlDeMarcas control = new ControlDeMarcas();
                BLLControlDeMarcas.DELETE();
                control.ObtenerMarcasJSON(this.txtRutaArchivoJSON.Text);
                VerificarRegistrosDeMarcaIncompletos();
                this.dgvListaMarcas.DataSource = BLLControlDeMarcas.SelectAll();
                RevisarSiHayMarcas();
                this.dgvListaMarcas.ClearSelection();

            }
            catch (Exception er)
            {
                MessageBox.Show("Ocurrió un error al cargar las marcas en la tabla: " + er.Message);
            }
        }

        private void VerificarRegistrosDeMarcaIncompletos()
        {
            List<ControlDeMarcas> listaRegistrosIncompletos = BLLControlDeMarcas.SelectAll().Where(marca => marca.HoraEntrada == ""||
                marca.HoraSalida == "").ToList();

            int contadorRegistrosIncompletos = BLLControlDeMarcas.SelectAll().Where(marca => marca.HoraEntrada == "" ||
                marca.HoraSalida == "").ToList().Count;

            if (contadorRegistrosIncompletos > 0)
            {
                foreach (var marca in listaRegistrosIncompletos)
                {
                    if ((!String.Equals(marca.HoraEntrada, "") && (String.Equals(marca.HoraSalida,""))))
                    {
                        marca.HoraSalida = "17:00";
                        BLLControlDeMarcas.Update(marca);
                    }
                    else if ((String.Equals(marca.HoraEntrada, "") && (!String.Equals(marca.HoraSalida, ""))))
                    {
                        marca.HoraEntrada = "7:00";
                        BLLControlDeMarcas.Update(marca);
                    }
                    else
                    {
                        marca.HoraEntrada = "00:00";
                        marca.HoraSalida = "00:00";
                        BLLControlDeMarcas.Update(marca);

                    }
                }
            }
        }

        private void RevisarSiHayMarcas()
        {
            if (BLLControlDeMarcas.SelectAll().Count == 0)
            {
                MessageBox.Show("¡No se puede proceder sin marcas en el sistema!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }
        }
        private void frmConsultaMarcas_FormClosing(object sender, FormClosingEventArgs e)
        {
            ImageConverter convertidor = new ImageConverter();
            var arreglo1 = (byte[])convertidor.ConvertTo(this.pctCargarJSON.Image, typeof(byte[]));
            var arreglo2 = (byte[])convertidor.ConvertTo(PayrollPal.Properties.Resources.Json_sinCheck, typeof(byte[]));
           
            if (arreglo1.Length == arreglo2.Length)
            {
                e.Cancel = true;
                this.errProv1.SetError(this.pctCargarJSON, "¡No se puede proceder sin un archivo válido JSON que contenga las marcas!");

            }

            if (this.btnCargarArchivoJson.Enabled && click_Agregar == false)
            {
                e.Cancel = true;
                this.errProv1.SetError(this.btnMostrarListaMarcas, "Debe darle click al botón Mostrar primero");
            }


        }
    }
}
