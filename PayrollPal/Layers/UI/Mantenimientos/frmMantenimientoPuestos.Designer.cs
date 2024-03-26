namespace PayrollPal.UI.Mantenimientos
{
    partial class frmMantenimientoPuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoPuestos));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblInactiva = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.toolStripMantEmpresa = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSalir = new System.Windows.Forms.ToolStripButton();
            this.dgvPuestos = new System.Windows.Forms.DataGridView();
            this.rdbInactiva = new System.Windows.Forms.RadioButton();
            this.rdbActiva = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripMantEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rdbInactiva);
            this.splitContainer1.Panel1.Controls.Add(this.rdbActiva);
            this.splitContainer1.Panel1.Controls.Add(this.lblInactiva);
            this.splitContainer1.Panel1.Controls.Add(this.txtNombre);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxId);
            this.splitContainer1.Panel1.Controls.Add(this.lblEstado);
            this.splitContainer1.Panel1.Controls.Add(this.lblNombre);
            this.splitContainer1.Panel1.Controls.Add(this.lblCodigo);
            this.splitContainer1.Panel1.Controls.Add(this.toolStripMantEmpresa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvPuestos);
            this.splitContainer1.Size = new System.Drawing.Size(1286, 1274);
            this.splitContainer1.SplitterDistance = 607;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblInactiva
            // 
            this.lblInactiva.AutoSize = true;
            this.lblInactiva.Location = new System.Drawing.Point(983, 228);
            this.lblInactiva.Name = "lblInactiva";
            this.lblInactiva.Size = new System.Drawing.Size(21, 32);
            this.lblInactiva.TabIndex = 31;
            this.lblInactiva.Text = " ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(368, 187);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(392, 38);
            this.txtNombre.TabIndex = 27;
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(368, 94);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(392, 38);
            this.txtBoxId.TabIndex = 26;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(24, 335);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(103, 32);
            this.lblEstado.TabIndex = 23;
            this.lblEstado.Text = "Estado";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 187);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(114, 32);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(24, 94);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(105, 32);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "Código";
            // 
            // toolStripMantEmpresa
            // 
            this.toolStripMantEmpresa.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStripMantEmpresa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAgregar,
            this.toolStripButtonEditar,
            this.toolStripButtonEliminar,
            this.toolStripButtonLimpiar,
            this.toolStripButtonSalir});
            this.toolStripMantEmpresa.Location = new System.Drawing.Point(0, 0);
            this.toolStripMantEmpresa.Name = "toolStripMantEmpresa";
            this.toolStripMantEmpresa.Size = new System.Drawing.Size(1286, 62);
            this.toolStripMantEmpresa.TabIndex = 17;
            this.toolStripMantEmpresa.Text = "toolStrip1";
            // 
            // toolStripButtonAgregar
            // 
            this.toolStripButtonAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAgregar.Image")));
            this.toolStripButtonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAgregar.Name = "toolStripButtonAgregar";
            this.toolStripButtonAgregar.Size = new System.Drawing.Size(128, 55);
            this.toolStripButtonAgregar.Text = "Agregar";
            // 
            // toolStripButtonEditar
            // 
            this.toolStripButtonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditar.Image")));
            this.toolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditar.Name = "toolStripButtonEditar";
            this.toolStripButtonEditar.Size = new System.Drawing.Size(97, 45);
            this.toolStripButtonEditar.Text = "Editar";
            // 
            // toolStripButtonEliminar
            // 
            this.toolStripButtonEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEliminar.Image")));
            this.toolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminar.Name = "toolStripButtonEliminar";
            this.toolStripButtonEliminar.Size = new System.Drawing.Size(126, 45);
            this.toolStripButtonEliminar.Text = "Eliminar";
            // 
            // toolStripButtonLimpiar
            // 
            this.toolStripButtonLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLimpiar.Image")));
            this.toolStripButtonLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLimpiar.Name = "toolStripButtonLimpiar";
            this.toolStripButtonLimpiar.Size = new System.Drawing.Size(119, 45);
            this.toolStripButtonLimpiar.Text = "Limpiar";
            // 
            // toolStripButtonSalir
            // 
            this.toolStripButtonSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSalir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSalir.Image")));
            this.toolStripButtonSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSalir.Name = "toolStripButtonSalir";
            this.toolStripButtonSalir.Size = new System.Drawing.Size(77, 45);
            this.toolStripButtonSalir.Text = "Salir";
            // 
            // dgvPuestos
            // 
            this.dgvPuestos.AllowUserToAddRows = false;
            this.dgvPuestos.AllowUserToDeleteRows = false;
            this.dgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPuestos.Location = new System.Drawing.Point(0, 0);
            this.dgvPuestos.Name = "dgvPuestos";
            this.dgvPuestos.ReadOnly = true;
            this.dgvPuestos.RowHeadersWidth = 102;
            this.dgvPuestos.RowTemplate.Height = 40;
            this.dgvPuestos.Size = new System.Drawing.Size(1286, 663);
            this.dgvPuestos.TabIndex = 1;
            // 
            // rdbInactiva
            // 
            this.rdbInactiva.AutoSize = true;
            this.rdbInactiva.Location = new System.Drawing.Point(368, 411);
            this.rdbInactiva.Name = "rdbInactiva";
            this.rdbInactiva.Size = new System.Drawing.Size(149, 36);
            this.rdbInactiva.TabIndex = 33;
            this.rdbInactiva.TabStop = true;
            this.rdbInactiva.Text = "Inactivo";
            this.rdbInactiva.UseVisualStyleBackColor = true;
            // 
            // rdbActiva
            // 
            this.rdbActiva.AutoSize = true;
            this.rdbActiva.Location = new System.Drawing.Point(368, 304);
            this.rdbActiva.Name = "rdbActiva";
            this.rdbActiva.Size = new System.Drawing.Size(129, 36);
            this.rdbActiva.TabIndex = 32;
            this.rdbActiva.TabStop = true;
            this.rdbActiva.Text = "Activo";
            this.rdbActiva.UseVisualStyleBackColor = true;
            // 
            // frmMantenimientoPuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1286, 1274);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMantenimientoPuestos";
            this.Text = "Mantenimiento de Puestos";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStripMantEmpresa.ResumeLayout(false);
            this.toolStripMantEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblInactiva;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ToolStrip toolStripMantEmpresa;
        private System.Windows.Forms.ToolStripButton toolStripButtonAgregar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminar;
        private System.Windows.Forms.ToolStripButton toolStripButtonLimpiar;
        private System.Windows.Forms.ToolStripButton toolStripButtonSalir;
        private System.Windows.Forms.DataGridView dgvPuestos;
        private System.Windows.Forms.RadioButton rdbInactiva;
        private System.Windows.Forms.RadioButton rdbActiva;
    }
}