using PayrollPal.Layers.UI.Mantenimientos;
using PayrollPal.UI.Consultas;
using PayrollPal.UI.Mantenimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPal.UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento para salir de la 
        /// aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro(a) que desea salir de la aplicación?","Pregunta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Evento para abrir el form de Mantenimiento de Usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoUsuarios frm = new frmMantenimientoUsuarios();
            frm.ShowDialog();
        }

        /// <summary>
        /// Evento para abrir el form de Mantenimiento de Colaboradores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoColaboradores frm = new frmMantenimientoColaboradores();
            frm.ShowDialog();
        }

        /// <summary>
        /// Evento para abrir el form de Mantenimiento de Roles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoRol frm = new frmMantenimientoRol();
            frm.ShowDialog();
        }

        /// <summary>
        /// Evento para abrir el form de Mantenimiento de Puestos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void puestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoPuestos frm = new frmMantenimientoPuestos();
            frm.ShowDialog();
        }

        /// <summary>
        /// Evento para abrir el form de Mantenimiento de Supervisores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supervisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoSupervisores frm = new frmMantenimientoSupervisores();
            frm.ShowDialog();
        }

        /// <summary>
        /// Método para abrir el form de consulta de 
        /// marcas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaMarcas frm = new frmConsultaMarcas();
            frm.ShowDialog();
        }

        private void planillasDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoPlanillas frm = new frmMantenimientoPlanillas();
            frm.ShowDialog();
        }
    }


}
