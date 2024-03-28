using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPal.UI.Mantenimientos
{
    public partial class frmMantenimientoColaboradores : Form
    {
        public frmMantenimientoColaboradores()
        {
            InitializeComponent();
        }

        private void frmMantenimientoColaboradores_Load(object sender, EventArgs e)
        {
            //Método para configurar los valores del datetimepicker
            ConfigurarDateTimePicker();

            //Método para refrescar la lista del datagridview


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
    }
}
