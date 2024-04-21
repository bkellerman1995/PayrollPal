namespace PayrollPal.UI
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslblUsuarioConectado = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supervisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planillasDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deduccionesYPercepcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deduccionesYPercepcionesPorColaboradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesDeVacacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularPlanillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultaPlanillasColab = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planillasPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesDeVacacionesPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblUsuarioConectado});
            this.toolStrip1.Location = new System.Drawing.Point(0, 879);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(2158, 61);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslblUsuarioConectado
            // 
            this.tslblUsuarioConectado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslblUsuarioConectado.Name = "tslblUsuarioConectado";
            this.tslblUsuarioConectado.Size = new System.Drawing.Size(291, 54);
            this.tslblUsuarioConectado.Text = "toolStripLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(15, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(2158, 68);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = global::PayrollPal.Properties.Resources.document;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(220, 58);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Checked = true;
            this.salirToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.salirToolStripMenuItem.Image = global::PayrollPal.Properties.Resources.cross_9403277;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(424, 62);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Image = global::PayrollPal.Properties.Resources.logout_1828479;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(424, 62);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.rolToolStripMenuItem,
            this.puestoToolStripMenuItem,
            this.supervisorToolStripMenuItem,
            this.colaboradoresToolStripMenuItem,
            this.planillasDePagoToolStripMenuItem,
            this.deduccionesYPercepcionesToolStripMenuItem,
            this.deduccionesYPercepcionesPorColaboradorToolStripMenuItem,
            this.solicitudesDeVacacionesToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Image = global::PayrollPal.Properties.Resources.tools;
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(376, 58);
            this.mantenimientosToolStripMenuItem.Text = "&Mantenimientos";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Image = global::PayrollPal.Properties.Resources.building;
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(1016, 62);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::PayrollPal.Properties.Resources.user_1077114;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(1016, 62);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // rolToolStripMenuItem
            // 
            this.rolToolStripMenuItem.Image = global::PayrollPal.Properties.Resources.builder;
            this.rolToolStripMenuItem.Name = "rolToolStripMenuItem";
            this.rolToolStripMenuItem.Size = new System.Drawing.Size(1016, 62);
            this.rolToolStripMenuItem.Text = "Rol";
            this.rolToolStripMenuItem.Click += new System.EventHandler(this.rolToolStripMenuItem_Click);
            // 
            // puestoToolStripMenuItem
            // 
            this.puestoToolStripMenuItem.Image = global::PayrollPal.Properties.Resources.candidates;
            this.puestoToolStripMenuItem.Name = "puestoToolStripMenuItem";
            this.puestoToolStripMenuItem.Size = new System.Drawing.Size(1016, 62);
            this.puestoToolStripMenuItem.Text = "Puesto";
            this.puestoToolStripMenuItem.Click += new System.EventHandler(this.puestoToolStripMenuItem_Click);
            // 
            // supervisorToolStripMenuItem
            // 
            this.supervisorToolStripMenuItem.Image = global::PayrollPal.Properties.Resources.hierarchy_structure;
            this.supervisorToolStripMenuItem.Name = "supervisorToolStripMenuItem";
            this.supervisorToolStripMenuItem.Size = new System.Drawing.Size(1016, 62);
            this.supervisorToolStripMenuItem.Text = "Supervisor";
            this.supervisorToolStripMenuItem.Click += new System.EventHandler(this.supervisorToolStripMenuItem_Click);
            // 
            // colaboradoresToolStripMenuItem
            // 
            this.colaboradoresToolStripMenuItem.Image = global::PayrollPal.Properties.Resources.workers;
            this.colaboradoresToolStripMenuItem.Name = "colaboradoresToolStripMenuItem";
            this.colaboradoresToolStripMenuItem.Size = new System.Drawing.Size(1016, 62);
            this.colaboradoresToolStripMenuItem.Text = "Colaboradores";
            this.colaboradoresToolStripMenuItem.Click += new System.EventHandler(this.colaboradoresToolStripMenuItem_Click);
            // 
            // planillasDePagoToolStripMenuItem
            // 
            this.planillasDePagoToolStripMenuItem.Image = global::PayrollPal.Properties.Resources.wallet;
            this.planillasDePagoToolStripMenuItem.Name = "planillasDePagoToolStripMenuItem";
            this.planillasDePagoToolStripMenuItem.Size = new System.Drawing.Size(1016, 62);
            this.planillasDePagoToolStripMenuItem.Text = "Planillas de Pago";
            this.planillasDePagoToolStripMenuItem.Click += new System.EventHandler(this.planillasDePagoToolStripMenuItem_Click);
            // 
            // deduccionesYPercepcionesToolStripMenuItem
            // 
            this.deduccionesYPercepcionesToolStripMenuItem.Image = global::PayrollPal.Properties.Resources.taxation;
            this.deduccionesYPercepcionesToolStripMenuItem.Name = "deduccionesYPercepcionesToolStripMenuItem";
            this.deduccionesYPercepcionesToolStripMenuItem.Size = new System.Drawing.Size(1016, 62);
            this.deduccionesYPercepcionesToolStripMenuItem.Text = "Deducciones y Percepciones";
            this.deduccionesYPercepcionesToolStripMenuItem.Click += new System.EventHandler(this.deduccionesYPercepcionesToolStripMenuItem_Click);
            // 
            // deduccionesYPercepcionesPorColaboradorToolStripMenuItem
            // 
            this.deduccionesYPercepcionesPorColaboradorToolStripMenuItem.Image = global::PayrollPal.Properties.Resources.taxes;
            this.deduccionesYPercepcionesPorColaboradorToolStripMenuItem.Name = "deduccionesYPercepcionesPorColaboradorToolStripMenuItem";
            this.deduccionesYPercepcionesPorColaboradorToolStripMenuItem.Size = new System.Drawing.Size(1016, 62);
            this.deduccionesYPercepcionesPorColaboradorToolStripMenuItem.Text = "Deducciones y Percepciones (Por Colaborador)";
            this.deduccionesYPercepcionesPorColaboradorToolStripMenuItem.Click += new System.EventHandler(this.deduccionesYPercepcionesPorColaboradorToolStripMenuItem_Click);
            // 
            // solicitudesDeVacacionesToolStripMenuItem
            // 
            this.solicitudesDeVacacionesToolStripMenuItem.Image = global::PayrollPal.Properties.Resources.vacations;
            this.solicitudesDeVacacionesToolStripMenuItem.Name = "solicitudesDeVacacionesToolStripMenuItem";
            this.solicitudesDeVacacionesToolStripMenuItem.Size = new System.Drawing.Size(1016, 62);
            this.solicitudesDeVacacionesToolStripMenuItem.Text = "Solicitudes de Vacaciones";
            this.solicitudesDeVacacionesToolStripMenuItem.Click += new System.EventHandler(this.solicitudesDeVacacionesToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularPlanillaToolStripMenuItem});
            this.procesosToolStripMenuItem.Image = global::PayrollPal.Properties.Resources.iteration;
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(242, 58);
            this.procesosToolStripMenuItem.Text = "&Procesos";
            // 
            // calcularPlanillaToolStripMenuItem
            // 
            this.calcularPlanillaToolStripMenuItem.Image = global::PayrollPal.Properties.Resources.payslip;
            this.calcularPlanillaToolStripMenuItem.Name = "calcularPlanillaToolStripMenuItem";
            this.calcularPlanillaToolStripMenuItem.Size = new System.Drawing.Size(470, 62);
            this.calcularPlanillaToolStripMenuItem.Text = "Calcular Planilla";
            this.calcularPlanillaToolStripMenuItem.Click += new System.EventHandler(this.calcularPlanillaToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConsultaPlanillasColab});
            this.consultasToolStripMenuItem.Image = global::PayrollPal.Properties.Resources.data_searching;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(259, 58);
            this.consultasToolStripMenuItem.Text = "&Consultas";
            // 
            // ConsultaPlanillasColab
            // 
            this.ConsultaPlanillasColab.Image = global::PayrollPal.Properties.Resources.protection;
            this.ConsultaPlanillasColab.Name = "ConsultaPlanillasColab";
            this.ConsultaPlanillasColab.Size = new System.Drawing.Size(632, 62);
            this.ConsultaPlanillasColab.Text = "Planillas por colaborador";
            this.ConsultaPlanillasColab.Click += new System.EventHandler(this.ConsultaPlanillasColab_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planillasPorFechaToolStripMenuItem,
            this.solicitudesDeVacacionesPorFechaToolStripMenuItem});
            this.reportesToolStripMenuItem.Image = global::PayrollPal.Properties.Resources.business_report;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(244, 58);
            this.reportesToolStripMenuItem.Text = "&Reportes";
            // 
            // planillasPorFechaToolStripMenuItem
            // 
            this.planillasPorFechaToolStripMenuItem.Image = global::PayrollPal.Properties.Resources.report;
            this.planillasPorFechaToolStripMenuItem.Name = "planillasPorFechaToolStripMenuItem";
            this.planillasPorFechaToolStripMenuItem.Size = new System.Drawing.Size(819, 62);
            this.planillasPorFechaToolStripMenuItem.Text = "Planillas por fecha";
            this.planillasPorFechaToolStripMenuItem.Click += new System.EventHandler(this.planillasPorFechaToolStripMenuItem_Click);
            // 
            // solicitudesDeVacacionesPorFechaToolStripMenuItem
            // 
            this.solicitudesDeVacacionesPorFechaToolStripMenuItem.Image = global::PayrollPal.Properties.Resources.report2;
            this.solicitudesDeVacacionesPorFechaToolStripMenuItem.Name = "solicitudesDeVacacionesPorFechaToolStripMenuItem";
            this.solicitudesDeVacacionesPorFechaToolStripMenuItem.Size = new System.Drawing.Size(819, 62);
            this.solicitudesDeVacacionesPorFechaToolStripMenuItem.Text = "Solicitudes de vacaciones por fecha";
            this.solicitudesDeVacacionesPorFechaToolStripMenuItem.Click += new System.EventHandler(this.solicitudesDeVacacionesPorFechaToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImage = global::PayrollPal.Properties.Resources.Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2158, 940);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrincipal";
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslblUsuarioConectado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supervisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaboradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultaPlanillasColab;
        private System.Windows.Forms.ToolStripMenuItem planillasDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deduccionesYPercepcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deduccionesYPercepcionesPorColaboradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesDeVacacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularPlanillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planillasPorFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesDeVacacionesPorFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
    }
}