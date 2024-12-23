﻿using PayrollPal.Layers.BLL;
using PayrollPal.Layers.Entities;
using PayrollPal.Layers.Interfaces;
using PayrollPal.Layers.UI;
using PayrollPal.Layers.UI.Consultas;
using PayrollPal.Layers.UI.Mantenimientos;
using PayrollPal.Layers.UI.Reportes;
using PayrollPal.UI.Consultas;
using PayrollPal.UI.Mantenimientos;
using PayrollPal.UI.Procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPal.UI
{
    public partial class frmPrincipal : Form
    {
        IBLLEmpresa bLLEmpresa = new BLLEmpresa();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            foreach (ToolStripItem item in this.menuStrip1.Items)
            {
                item.Visible = false;
            }
            
            frmLogin frm = new frmLogin();

            this.tslblUsuarioConectado.Text = "Usuario Conectado: ";

            frm.LoginFormClosed += frmLogin_LoginFormClosed;
            frm.MdiParent = this;
            frm.Show();

            ObtenerEstadoEmpresa();

        }

        private async void ObtenerEstadoEmpresa()
        {
            Task<List<Empresa>> taskListaEmpresas = bLLEmpresa.SelectAll();
            List<Empresa>empresaLista = await taskListaEmpresas;
            foreach (Empresa emp in empresaLista)
            {
                if (emp != null)
                {
                    frmMantenimientoEmpresa.empresaUnica = emp;
                    frmMantenimientoEmpresa.contEmpresa = 1;
                    break;

                }
            }
        }

        private void frmLogin_LoginFormClosed(object sender, EventArgs e)
        {
            if (frmLogin.colaboradorLoggeado.IDColaborador != null)
            {
                this.tslblUsuarioConectado.Text = "Usuario Conectado: " + frmLogin.colaboradorLoggeado.IDUsuario.IDUsuario + " Rol: " + frmLogin.colaboradorLoggeado.IDRol.Descripcion;


                switch (frmLogin.colaboradorLoggeado.IDRol.IDRol)
                {
                    case 1:

                        if (frmMantenimientoEmpresa.contEmpresa == 0 ||
                            frmMantenimientoEmpresa.empresaUnica.Estado == false)
                        {
                            MessageBox.Show("No existe empresa o el estado es inactivo " +
                                "\n" +
                                "\nLa empresa debe estar existir y/o estar activa para habilitar todas las funciones de mantenimiento" +
                                "\nprocesos (calcular planilla), consultas y reportes de la aplicación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.mantenimientosToolStripMenuItem.Visible = true;
                            this.empresaToolStripMenuItem.Visible = true;
                            this.archivoToolStripMenuItem.Visible = true;
                            this.usuariosToolStripMenuItem.Visible = false;
                            this.rolToolStripMenuItem.Visible = false;
                            this.puestoToolStripMenuItem.Visible = false;
                            this.supervisorToolStripMenuItem.Visible = false;
                            this.colaboradoresToolStripMenuItem.Visible = false;
                            this.planillasDePagoToolStripMenuItem.Visible = false;
                            this.deduccionesYPercepcionesToolStripMenuItem.Visible = false;
                            this.deduccionesYPercepcionesPorColaboradorToolStripMenuItem.Visible = false;
                            this.solicitudesDeVacacionesToolStripMenuItem.Visible = false;
                        }
                        else
                        {

                            this.mantenimientosToolStripMenuItem.Visible = true;
                            this.archivoToolStripMenuItem.Visible = true;
                            this.consultasToolStripMenuItem.Visible = true;

                            this.usuariosToolStripMenuItem.Visible = true;
                            this.rolToolStripMenuItem.Visible = true;
                            this.puestoToolStripMenuItem.Visible = true;
                            this.supervisorToolStripMenuItem.Visible = true;
                            this.colaboradoresToolStripMenuItem.Visible = true;
                            this.planillasDePagoToolStripMenuItem.Visible = true;
                            this.deduccionesYPercepcionesToolStripMenuItem.Visible = true;
                            this.deduccionesYPercepcionesPorColaboradorToolStripMenuItem.Visible = true;
                            this.solicitudesDeVacacionesToolStripMenuItem.Visible = true;


                            this.procesosToolStripMenuItem.Visible = true;
                            this.reportesToolStripMenuItem.Visible = true;
                        }


                        frmProcesoCargaDeMarcas frm = new frmProcesoCargaDeMarcas();
                        frm.ShowDialog();
                        break;

                    case 2:

                        if (frmMantenimientoEmpresa.contEmpresa == 0 ||
                            frmMantenimientoEmpresa.empresaUnica.Estado == false)
                        {
                            MessageBox.Show("No existe empresa o el estado es inactivo " +
                                "\n" +
                                "\nLa empresa debe estar existir y/o estar activa para habilitar las funciones de mantenimiento (solicitar, aprobar y rechazar vacaciones)" +
                                "\ny reportes de la aplicación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        else
                        {

                            this.archivoToolStripMenuItem.Visible = true;
                            this.mantenimientosToolStripMenuItem.Visible = true;
                            this.empresaToolStripMenuItem.Visible = false;
                            this.reportesToolStripMenuItem.Visible = true;
                            this.usuariosToolStripMenuItem.Visible = false;
                            this.rolToolStripMenuItem.Visible = false;
                            this.puestoToolStripMenuItem.Visible = false;
                            this.supervisorToolStripMenuItem.Visible = false;
                            this.colaboradoresToolStripMenuItem.Visible = false;
                            this.planillasDePagoToolStripMenuItem.Visible = false;
                            this.deduccionesYPercepcionesToolStripMenuItem.Visible = false;
                            this.deduccionesYPercepcionesPorColaboradorToolStripMenuItem.Visible = false;
                            this.procesosToolStripMenuItem.Visible = false;
                        }

                        break;
                    case 3:


                        if (frmMantenimientoEmpresa.contEmpresa == 0 ||
                            frmMantenimientoEmpresa.empresaUnica.Estado == false)
                        {
                            MessageBox.Show("No existe empresa o el estado es inactivo " +
                                "\n" +
                                "\nLa empresa debe estar existir y/o estar activa para habilitar las funciones de mantenimiento (solicitar vacaciones)" +
                                "\ny consultas de la aplicación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        else
                        {
                            this.mantenimientosToolStripMenuItem.Visible = true;
                            this.solicitudesDeVacacionesToolStripMenuItem.Visible = true;
                            this.archivoToolStripMenuItem.Visible = true;
                            this.consultasToolStripMenuItem.Visible = true;

                            this.empresaToolStripMenuItem.Visible = false;
                            this.usuariosToolStripMenuItem.Visible = false;
                            this.rolToolStripMenuItem.Visible = false;
                            this.puestoToolStripMenuItem.Visible = false;
                            this.supervisorToolStripMenuItem.Visible = false;
                            this.colaboradoresToolStripMenuItem.Visible = false;
                            this.planillasDePagoToolStripMenuItem.Visible = false;
                            this.deduccionesYPercepcionesToolStripMenuItem.Visible = false;
                            this.deduccionesYPercepcionesPorColaboradorToolStripMenuItem.Visible = false;

                            this.procesosToolStripMenuItem.Visible = false;
                            this.reportesToolStripMenuItem.Visible = false;
                        }

                        break;
                }
            }


        }

        private void frmMantEmp_MantEmpFormClosed(object sender, EventArgs e)
        {
            if (frmLogin.colaboradorLoggeado.IDRol.IDRol == 1)
            {
                if (frmMantenimientoEmpresa.empresaUnica.Estado == true && frmMantenimientoEmpresa.empresaUnica!= null)
                {
                    this.mantenimientosToolStripMenuItem.Visible = true;
                    this.archivoToolStripMenuItem.Visible = true;
                    this.consultasToolStripMenuItem.Visible = true;

                    this.usuariosToolStripMenuItem.Visible = true;
                    this.rolToolStripMenuItem.Visible = true;
                    this.puestoToolStripMenuItem.Visible = true;
                    this.supervisorToolStripMenuItem.Visible = true;
                    this.colaboradoresToolStripMenuItem.Visible = true;
                    this.planillasDePagoToolStripMenuItem.Visible = true;
                    this.deduccionesYPercepcionesToolStripMenuItem.Visible = true;
                    this.deduccionesYPercepcionesPorColaboradorToolStripMenuItem.Visible = true;
                    this.procesosToolStripMenuItem.Visible = true;
                    this.solicitudesDeVacacionesToolStripMenuItem.Visible = true;
                    this.reportesToolStripMenuItem.Visible = true;
                }
                else
                {
                    this.mantenimientosToolStripMenuItem.Visible = true;
                    this.empresaToolStripMenuItem.Visible = true;
                    this.archivoToolStripMenuItem.Visible = true;
                    this.consultasToolStripMenuItem.Visible = false;

                    this.usuariosToolStripMenuItem.Visible = false;
                    this.rolToolStripMenuItem.Visible = false;
                    this.puestoToolStripMenuItem.Visible = false;
                    this.supervisorToolStripMenuItem.Visible = false;
                    this.colaboradoresToolStripMenuItem.Visible = false;
                    this.planillasDePagoToolStripMenuItem.Visible = false;
                    this.deduccionesYPercepcionesToolStripMenuItem.Visible = false;
                    this.deduccionesYPercepcionesPorColaboradorToolStripMenuItem.Visible = false;
                    this.solicitudesDeVacacionesToolStripMenuItem.Visible = false;


                    this.procesosToolStripMenuItem.Visible = false;
                    this.reportesToolStripMenuItem.Visible = false;
                }
             }
        }

        /// <summary>
        /// Evento para salir de la 
        /// aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro(a) que desea salir de la aplicación?", "Pregunta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Environment.Exit(0);
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

        private void planillasDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoPlanillas frm = new frmMantenimientoPlanillas();
            frm.ShowDialog();
        }

        private void deduccionesYPercepcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoDeduccionesPercepciones frm = new frmMantenimientoDeduccionesPercepciones();
            frm.ShowDialog();
        }

        private void deduccionesYPercepcionesPorColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoDeduccionesPercepcionesColaborador frm = new frmMantenimientoDeduccionesPercepcionesColaborador();
            frm.ShowDialog();
        }

        private void solicitudesDeVacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoSolicitudVacaciones frm = new frmMantenimientoSolicitudVacaciones();
            frm.ShowDialog();
        }

        private void calcularPlanillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcesoCalcularPlanilla frm = new frmProcesoCalcularPlanilla();
            frm.ShowDialog();
        }

        private void ConsultaPlanillasColab_Click(object sender, EventArgs e)
        {
            frmConsultaPlanillas frm = new frmConsultaPlanillas();
            frm.ShowDialog();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cerrarSesion = MessageBox.Show("¿Está seguro(a) que desea cerrar sesión?", "Pregunta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cerrarSesion == DialogResult.Yes)
            {
                this.tslblUsuarioConectado.Text = "Usuario Conectado: ";
                frmLogin.colaboradorLoggeado = new Colaborador();
                frmPrincipal_Load(this, EventArgs.Empty);
            }
        }

        private void planillasPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportePlanillaPorFechas frm = new frmReportePlanillaPorFechas();
            frm.ShowDialog();
        }

        private void solicitudesDeVacacionesPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteSolVacasPorFecha frm = new frmReporteSolVacasPorFecha();
            frm.ShowDialog();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoEmpresa frm = new frmMantenimientoEmpresa();
            frm.MantEmpFormClosed += frmMantEmp_MantEmpFormClosed;
            frm.MdiParent = this;
            frm.Show();
        }

        private void cargarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcesoCargaDeMarcas frm = new frmProcesoCargaDeMarcas();
            frm.ShowDialog();
        }
    }


}
