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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supervisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planillasDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deduccionesYPercepcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deduccionesYPercepcionesPorColaboradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesDeVacacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 420);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(863, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(115, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 29);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.rolToolStripMenuItem,
            this.puestoToolStripMenuItem,
            this.supervisorToolStripMenuItem,
            this.colaboradoresToolStripMenuItem,
            this.planillasDePagoToolStripMenuItem,
            this.deduccionesYPercepcionesToolStripMenuItem,
            this.deduccionesYPercepcionesPorColaboradorToolStripMenuItem,
            this.solicitudesDeVacacionesToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(135, 25);
            this.mantenimientosToolStripMenuItem.Text = "&Mantenimientos";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(402, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // rolToolStripMenuItem
            // 
            this.rolToolStripMenuItem.Name = "rolToolStripMenuItem";
            this.rolToolStripMenuItem.Size = new System.Drawing.Size(402, 26);
            this.rolToolStripMenuItem.Text = "Rol";
            this.rolToolStripMenuItem.Click += new System.EventHandler(this.rolToolStripMenuItem_Click);
            // 
            // puestoToolStripMenuItem
            // 
            this.puestoToolStripMenuItem.Name = "puestoToolStripMenuItem";
            this.puestoToolStripMenuItem.Size = new System.Drawing.Size(402, 26);
            this.puestoToolStripMenuItem.Text = "Puesto";
            this.puestoToolStripMenuItem.Click += new System.EventHandler(this.puestoToolStripMenuItem_Click);
            // 
            // supervisorToolStripMenuItem
            // 
            this.supervisorToolStripMenuItem.Name = "supervisorToolStripMenuItem";
            this.supervisorToolStripMenuItem.Size = new System.Drawing.Size(402, 26);
            this.supervisorToolStripMenuItem.Text = "Supervisor";
            this.supervisorToolStripMenuItem.Click += new System.EventHandler(this.supervisorToolStripMenuItem_Click);
            // 
            // colaboradoresToolStripMenuItem
            // 
            this.colaboradoresToolStripMenuItem.Name = "colaboradoresToolStripMenuItem";
            this.colaboradoresToolStripMenuItem.Size = new System.Drawing.Size(402, 26);
            this.colaboradoresToolStripMenuItem.Text = "Colaboradores";
            this.colaboradoresToolStripMenuItem.Click += new System.EventHandler(this.colaboradoresToolStripMenuItem_Click);
            // 
            // planillasDePagoToolStripMenuItem
            // 
            this.planillasDePagoToolStripMenuItem.Name = "planillasDePagoToolStripMenuItem";
            this.planillasDePagoToolStripMenuItem.Size = new System.Drawing.Size(402, 26);
            this.planillasDePagoToolStripMenuItem.Text = "Planillas de Pago";
            this.planillasDePagoToolStripMenuItem.Click += new System.EventHandler(this.planillasDePagoToolStripMenuItem_Click);
            // 
            // deduccionesYPercepcionesToolStripMenuItem
            // 
            this.deduccionesYPercepcionesToolStripMenuItem.Name = "deduccionesYPercepcionesToolStripMenuItem";
            this.deduccionesYPercepcionesToolStripMenuItem.Size = new System.Drawing.Size(402, 26);
            this.deduccionesYPercepcionesToolStripMenuItem.Text = "Deducciones y Percepciones";
            this.deduccionesYPercepcionesToolStripMenuItem.Click += new System.EventHandler(this.deduccionesYPercepcionesToolStripMenuItem_Click);
            // 
            // deduccionesYPercepcionesPorColaboradorToolStripMenuItem
            // 
            this.deduccionesYPercepcionesPorColaboradorToolStripMenuItem.Name = "deduccionesYPercepcionesPorColaboradorToolStripMenuItem";
            this.deduccionesYPercepcionesPorColaboradorToolStripMenuItem.Size = new System.Drawing.Size(402, 26);
            this.deduccionesYPercepcionesPorColaboradorToolStripMenuItem.Text = "Deducciones y Percepciones (Por Colaborador)";
            this.deduccionesYPercepcionesPorColaboradorToolStripMenuItem.Click += new System.EventHandler(this.deduccionesYPercepcionesPorColaboradorToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.procesosToolStripMenuItem.Text = "&Procesos";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.consultasToolStripMenuItem.Text = "&Consultas";
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.reportesToolStripMenuItem.Text = "&Reportes";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.ayudaToolStripMenuItem.Text = "A&yuda";
            // 
            // solicitudesDeVacacionesToolStripMenuItem
            // 
            this.solicitudesDeVacacionesToolStripMenuItem.Name = "solicitudesDeVacacionesToolStripMenuItem";
            this.solicitudesDeVacacionesToolStripMenuItem.Size = new System.Drawing.Size(402, 26);
            this.solicitudesDeVacacionesToolStripMenuItem.Text = "Solicitudes de Vacaciones";
            this.solicitudesDeVacacionesToolStripMenuItem.Click += new System.EventHandler(this.solicitudesDeVacacionesToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImage = global::PayrollPal.Properties.Resources.Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 445);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmPrincipal";
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supervisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaboradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planillasDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deduccionesYPercepcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deduccionesYPercepcionesPorColaboradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesDeVacacionesToolStripMenuItem;
    }
}