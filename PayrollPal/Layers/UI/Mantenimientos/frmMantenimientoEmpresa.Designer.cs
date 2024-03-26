namespace PayrollPal.UI.Mantenimientos
{
    partial class frmMantenimientoEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoEmpresa));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStripMantEmpresa = new System.Windows.Forms.ToolStrip();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblTipoIdentificacion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.rdbActiva = new System.Windows.Forms.RadioButton();
            this.rdbInactiva = new System.Windows.Forms.RadioButton();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.toolStripButtonAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSalir = new System.Windows.Forms.ToolStripButton();
            this.cmbTipoID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripMantEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.cmbTipoID);
            this.splitContainer1.Panel1.Controls.Add(this.rdbInactiva);
            this.splitContainer1.Panel1.Controls.Add(this.rdbActiva);
            this.splitContainer1.Panel1.Controls.Add(this.txtDireccion);
            this.splitContainer1.Panel1.Controls.Add(this.txtTelefono);
            this.splitContainer1.Panel1.Controls.Add(this.txtNombre);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxId);
            this.splitContainer1.Panel1.Controls.Add(this.lblLogo);
            this.splitContainer1.Panel1.Controls.Add(this.pctLogo);
            this.splitContainer1.Panel1.Controls.Add(this.lblEstado);
            this.splitContainer1.Panel1.Controls.Add(this.lblDireccion);
            this.splitContainer1.Panel1.Controls.Add(this.lblTelefono);
            this.splitContainer1.Panel1.Controls.Add(this.lblNombre);
            this.splitContainer1.Panel1.Controls.Add(this.lblTipoIdentificacion);
            this.splitContainer1.Panel1.Controls.Add(this.lblIdentificacion);
            this.splitContainer1.Panel1.Controls.Add(this.toolStripMantEmpresa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvEmpresa);
            this.splitContainer1.Size = new System.Drawing.Size(2005, 1429);
            this.splitContainer1.SplitterDistance = 647;
            this.splitContainer1.TabIndex = 0;
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
            this.toolStripMantEmpresa.Size = new System.Drawing.Size(2005, 52);
            this.toolStripMantEmpresa.TabIndex = 0;
            this.toolStripMantEmpresa.Text = "toolStrip1";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(23, 114);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(182, 32);
            this.lblIdentificacion.TabIndex = 1;
            this.lblIdentificacion.Text = "Identificacion";
            // 
            // lblTipoIdentificacion
            // 
            this.lblTipoIdentificacion.AutoSize = true;
            this.lblTipoIdentificacion.Location = new System.Drawing.Point(23, 188);
            this.lblTipoIdentificacion.Name = "lblTipoIdentificacion";
            this.lblTipoIdentificacion.Size = new System.Drawing.Size(284, 32);
            this.lblTipoIdentificacion.TabIndex = 2;
            this.lblTipoIdentificacion.Text = "Tipo de Identificación";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 267);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(114, 32);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(23, 345);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(126, 32);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(23, 421);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(133, 32);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(847, 175);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(103, 32);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(1375, 30);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(78, 32);
            this.lblLogo.TabIndex = 10;
            this.lblLogo.Text = "Logo";
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.AllowUserToAddRows = false;
            this.dgvEmpresa.AllowUserToDeleteRows = false;
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpresa.Location = new System.Drawing.Point(0, 0);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.ReadOnly = true;
            this.dgvEmpresa.RowHeadersWidth = 102;
            this.dgvEmpresa.RowTemplate.Height = 40;
            this.dgvEmpresa.Size = new System.Drawing.Size(2005, 778);
            this.dgvEmpresa.TabIndex = 0;
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(367, 114);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(392, 38);
            this.txtBoxId.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(367, 261);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(392, 38);
            this.txtNombre.TabIndex = 12;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(367, 339);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(392, 38);
            this.txtTelefono.TabIndex = 13;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(367, 421);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(976, 144);
            this.txtDireccion.TabIndex = 14;
            // 
            // rdbActiva
            // 
            this.rdbActiva.AutoSize = true;
            this.rdbActiva.Location = new System.Drawing.Point(1050, 132);
            this.rdbActiva.Name = "rdbActiva";
            this.rdbActiva.Size = new System.Drawing.Size(129, 36);
            this.rdbActiva.TabIndex = 15;
            this.rdbActiva.TabStop = true;
            this.rdbActiva.Text = "Activa";
            this.rdbActiva.UseVisualStyleBackColor = true;
            // 
            // rdbInactiva
            // 
            this.rdbInactiva.AutoSize = true;
            this.rdbInactiva.Location = new System.Drawing.Point(1050, 239);
            this.rdbInactiva.Name = "rdbInactiva";
            this.rdbInactiva.Size = new System.Drawing.Size(149, 36);
            this.rdbInactiva.TabIndex = 16;
            this.rdbInactiva.TabStop = true;
            this.rdbInactiva.Text = "Inactiva";
            this.rdbInactiva.UseVisualStyleBackColor = true;
            // 
            // pctLogo
            // 
            this.pctLogo.Location = new System.Drawing.Point(1381, 103);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(542, 462);
            this.pctLogo.TabIndex = 9;
            this.pctLogo.TabStop = false;
            // 
            // toolStripButtonAgregar
            // 
            this.toolStripButtonAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAgregar.Image")));
            this.toolStripButtonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAgregar.Name = "toolStripButtonAgregar";
            this.toolStripButtonAgregar.Size = new System.Drawing.Size(128, 45);
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
            // cmbTipoID
            // 
            this.cmbTipoID.FormattingEnabled = true;
            this.cmbTipoID.Location = new System.Drawing.Point(367, 188);
            this.cmbTipoID.Name = "cmbTipoID";
            this.cmbTipoID.Size = new System.Drawing.Size(332, 39);
            this.cmbTipoID.TabIndex = 17;
            // 
            // frmMantenimientoEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2005, 1429);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMantenimientoEmpresa";
            this.Text = "Mantenimiento de Empresa";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStripMantEmpresa.ResumeLayout(false);
            this.toolStripMantEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStripMantEmpresa;
        private System.Windows.Forms.ToolStripButton toolStripButtonAgregar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminar;
        private System.Windows.Forms.ToolStripButton toolStripButtonLimpiar;
        private System.Windows.Forms.ToolStripButton toolStripButtonSalir;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoIdentificacion;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.RadioButton rdbInactiva;
        private System.Windows.Forms.RadioButton rdbActiva;
        private System.Windows.Forms.ComboBox cmbTipoID;
    }
}