namespace PayrollPal.UI.Mantenimientos
{
    partial class frmMantenimientoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoUsuarios));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblContrasenna = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.toolStripMantEmpresa = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSalir = new System.Windows.Forms.ToolStripButton();
            this.mktContrasenna = new System.Windows.Forms.MaskedTextBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripMantEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.mktContrasenna);
            this.splitContainer1.Panel1.Controls.Add(this.txtNombre);
            this.splitContainer1.Panel1.Controls.Add(this.lblNombre);
            this.splitContainer1.Panel1.Controls.Add(this.txtID);
            this.splitContainer1.Panel1.Controls.Add(this.lblContrasenna);
            this.splitContainer1.Panel1.Controls.Add(this.lblID);
            this.splitContainer1.Panel1.Controls.Add(this.toolStripMantEmpresa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvUsuarios);
            this.splitContainer1.Size = new System.Drawing.Size(1313, 1315);
            this.splitContainer1.SplitterDistance = 639;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(364, 190);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(392, 38);
            this.txtNombre.TabIndex = 54;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 190);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(258, 32);
            this.lblNombre.TabIndex = 53;
            this.lblNombre.Text = "Nombre de Usuario";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(364, 135);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(392, 38);
            this.txtID.TabIndex = 48;
            // 
            // lblContrasenna
            // 
            this.lblContrasenna.AutoSize = true;
            this.lblContrasenna.Location = new System.Drawing.Point(20, 405);
            this.lblContrasenna.Name = "lblContrasenna";
            this.lblContrasenna.Size = new System.Drawing.Size(161, 32);
            this.lblContrasenna.TabIndex = 45;
            this.lblContrasenna.Text = "Contraseña";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(20, 135);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(41, 32);
            this.lblID.TabIndex = 44;
            this.lblID.Text = "ID";
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
            this.toolStripMantEmpresa.Size = new System.Drawing.Size(1313, 52);
            this.toolStripMantEmpresa.TabIndex = 43;
            this.toolStripMantEmpresa.Text = "toolStrip1";
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
            // mktContrasenna
            // 
            this.mktContrasenna.Location = new System.Drawing.Point(364, 399);
            this.mktContrasenna.Name = "mktContrasenna";
            this.mktContrasenna.Size = new System.Drawing.Size(350, 38);
            this.mktContrasenna.TabIndex = 55;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 102;
            this.dgvUsuarios.RowTemplate.Height = 40;
            this.dgvUsuarios.Size = new System.Drawing.Size(1313, 672);
            this.dgvUsuarios.TabIndex = 4;
            // 
            // frmMantenimientoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 1315);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMantenimientoUsuarios";
            this.Text = "Mantenimiento de Usuarios";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStripMantEmpresa.ResumeLayout(false);
            this.toolStripMantEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblContrasenna;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ToolStrip toolStripMantEmpresa;
        private System.Windows.Forms.ToolStripButton toolStripButtonAgregar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminar;
        private System.Windows.Forms.ToolStripButton toolStripButtonLimpiar;
        private System.Windows.Forms.ToolStripButton toolStripButtonSalir;
        private System.Windows.Forms.MaskedTextBox mktContrasenna;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}