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
using PayrollPal.Layers.BLL;

namespace PayrollPal.UI.Mantenimientos
{
    public partial class frmMantenimientoColaboradores : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");
        public frmMantenimientoColaboradores()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para cerrar el form de Mantenimiento de 
        /// Colaboradores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Método load del form 
        /// de mantenimiento de colaboradores 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frmMantenimientoColaboradores_Load(object sender, EventArgs e)
        {
            try
            {
                //Método para configurar los valores del datetimepicker
                ConfigurarDateTimePicker();

                //Cargar el datagridview de usuarios con el SELECT_ALL 
                //del DALColaborador

                CargarLista();

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
        /// de colaboradores desde la base de datos 
        /// y cargarlo al datagridview
        /// </summary>
        private void CargarLista()
        {
            try
            {

                this.dgvColaboradores.DataSource = BLLColaborador.SelectAll();
                this.dgvColaboradores.ClearSelection();
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
                this.mktID.Clear();
                this.mktID.BackColor = Color.White;

                this.txtNombre.Clear();
                this.txtNombre.BackColor = Color.White;

                this.txtContrasenna.Clear();
                this.txtContrasenna.BackColor = Color.White;

                this.txtConfirmarContrasenna.Clear();
                this.txtConfirmarContrasenna.BackColor = Color.White;

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
        /// Método para configurar el datetimepicker
        /// para que la fecha mínima de nacimiento
        /// sea 18 años y la máxima 60
        /// </summary>
        private void ConfigurarDateTimePicker()
        {
            this.dtpFechaNacimiento.MinDate = DateTime.Today.AddYears(-65);
            this.dtpFechaNacimiento.MaxDate = DateTime.Today.AddYears(-18);
        }

        /// <summary>
        /// Evento del datetimepicker Fecha de nacimiento para
        /// no poder escoger una fecha antes del mínimo ni después 
        /// del máximo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            // deshabilitar fechas antes del mínimo
            if (this.dtpFechaNacimiento.Value < this.dtpFechaNacimiento.MinDate)
                this.dtpFechaNacimiento.Value = this.dtpFechaNacimiento.MinDate;

            // deshabilitar fechas después del máximo
            if (this.dtpFechaNacimiento.Value > this.dtpFechaNacimiento.MaxDate)
                this.dtpFechaNacimiento.Value = this.dtpFechaNacimiento.MaxDate;
        }
    }
}
