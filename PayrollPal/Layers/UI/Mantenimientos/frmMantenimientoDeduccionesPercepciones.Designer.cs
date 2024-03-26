namespace PayrollPal.UI.Mantenimientos
{
    partial class frmMantenimientoDeduccionesPercepciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoDeduccionesPercepciones));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmbColaborador = new System.Windows.Forms.ComboBox();
            this.rdbInactiva = new System.Windows.Forms.RadioButton();
            this.rdbActiva = new System.Windows.Forms.RadioButton();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.lblColaborador = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.toolStripMantEmpresa = new System.Windows.Forms.ToolStrip();
            this.dgvDeduccionesPercepciones = new System.Windows.Forms.DataGridView();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.toolStripButtonAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSalir = new System.Windows.Forms.ToolStripButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.cmbTipoValor = new System.Windows.Forms.ComboBox();
            this.lblTipoValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripMantEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeduccionesPercepciones)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.cmbTipoValor);
            this.splitContainer1.Panel1.Controls.Add(this.lblTipoValor);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.lblValor);
            this.splitContainer1.Panel1.Controls.Add(this.cmbTipo);
            this.splitContainer1.Panel1.Controls.Add(this.lblTipo);
            this.splitContainer1.Panel1.Controls.Add(this.txtNombre);
            this.splitContainer1.Panel1.Controls.Add(this.lblNombre);
            this.splitContainer1.Panel1.Controls.Add(this.cmbPrioridad);
            this.splitContainer1.Panel1.Controls.Add(this.cmbColaborador);
            this.splitContainer1.Panel1.Controls.Add(this.rdbInactiva);
            this.splitContainer1.Panel1.Controls.Add(this.rdbActiva);
            this.splitContainer1.Panel1.Controls.Add(this.Codigo);
            this.splitContainer1.Panel1.Controls.Add(this.lblEstado);
            this.splitContainer1.Panel1.Controls.Add(this.lblPrioridad);
            this.splitContainer1.Panel1.Controls.Add(this.lblColaborador);
            this.splitContainer1.Panel1.Controls.Add(this.lblCodigo);
            this.splitContainer1.Panel1.Controls.Add(this.toolStripMantEmpresa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDeduccionesPercepciones);
            this.splitContainer1.Size = new System.Drawing.Size(1447, 1357);
            this.splitContainer1.SplitterDistance = 675;
            this.splitContainer1.TabIndex = 0;
            // 
            // cmbColaborador
            // 
            this.cmbColaborador.FormattingEnabled = true;
            this.cmbColaborador.Location = new System.Drawing.Point(364, 203);
            this.cmbColaborador.Name = "cmbColaborador";
            this.cmbColaborador.Size = new System.Drawing.Size(332, 39);
            this.cmbColaborador.TabIndex = 33;
            // 
            // rdbInactiva
            // 
            this.rdbInactiva.AutoSize = true;
            this.rdbInactiva.Location = new System.Drawing.Point(1047, 222);
            this.rdbInactiva.Name = "rdbInactiva";
            this.rdbInactiva.Size = new System.Drawing.Size(149, 36);
            this.rdbInactiva.TabIndex = 32;
            this.rdbInactiva.TabStop = true;
            this.rdbInactiva.Text = "Inactiva";
            this.rdbInactiva.UseVisualStyleBackColor = true;
            // 
            // rdbActiva
            // 
            this.rdbActiva.AutoSize = true;
            this.rdbActiva.Location = new System.Drawing.Point(1047, 115);
            this.rdbActiva.Name = "rdbActiva";
            this.rdbActiva.Size = new System.Drawing.Size(129, 36);
            this.rdbActiva.TabIndex = 31;
            this.rdbActiva.TabStop = true;
            this.rdbActiva.Text = "Activa";
            this.rdbActiva.UseVisualStyleBackColor = true;
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(364, 97);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(392, 38);
            this.Codigo.TabIndex = 27;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(844, 158);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(103, 32);
            this.lblEstado.TabIndex = 24;
            this.lblEstado.Text = "Estado";
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(20, 351);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(129, 32);
            this.lblPrioridad.TabIndex = 21;
            this.lblPrioridad.Text = "Prioridad";
            // 
            // lblColaborador
            // 
            this.lblColaborador.AutoSize = true;
            this.lblColaborador.Location = new System.Drawing.Point(20, 203);
            this.lblColaborador.Name = "lblColaborador";
            this.lblColaborador.Size = new System.Drawing.Size(171, 32);
            this.lblColaborador.TabIndex = 20;
            this.lblColaborador.Text = "Colaborador";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 97);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(105, 32);
            this.lblCodigo.TabIndex = 19;
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
            this.toolStripMantEmpresa.Size = new System.Drawing.Size(1447, 62);
            this.toolStripMantEmpresa.TabIndex = 18;
            this.toolStripMantEmpresa.Text = "toolStrip1";
            // 
            // dgvDeduccionesPercepciones
            // 
            this.dgvDeduccionesPercepciones.AllowUserToAddRows = false;
            this.dgvDeduccionesPercepciones.AllowUserToDeleteRows = false;
            this.dgvDeduccionesPercepciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeduccionesPercepciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeduccionesPercepciones.Location = new System.Drawing.Point(0, 0);
            this.dgvDeduccionesPercepciones.Name = "dgvDeduccionesPercepciones";
            this.dgvDeduccionesPercepciones.ReadOnly = true;
            this.dgvDeduccionesPercepciones.RowHeadersWidth = 102;
            this.dgvDeduccionesPercepciones.RowTemplate.Height = 40;
            this.dgvDeduccionesPercepciones.Size = new System.Drawing.Size(1447, 678);
            this.dgvDeduccionesPercepciones.TabIndex = 3;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(364, 362);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(332, 39);
            this.cmbPrioridad.TabIndex = 34;
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
            this.toolStripButtonEditar.Size = new System.Drawing.Size(97, 55);
            this.toolStripButtonEditar.Text = "Editar";
            // 
            // toolStripButtonEliminar
            // 
            this.toolStripButtonEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEliminar.Image")));
            this.toolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminar.Name = "toolStripButtonEliminar";
            this.toolStripButtonEliminar.Size = new System.Drawing.Size(126, 55);
            this.toolStripButtonEliminar.Text = "Eliminar";
            // 
            // toolStripButtonLimpiar
            // 
            this.toolStripButtonLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLimpiar.Image")));
            this.toolStripButtonLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLimpiar.Name = "toolStripButtonLimpiar";
            this.toolStripButtonLimpiar.Size = new System.Drawing.Size(119, 55);
            this.toolStripButtonLimpiar.Text = "Limpiar";
            // 
            // toolStripButtonSalir
            // 
            this.toolStripButtonSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSalir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSalir.Image")));
            this.toolStripButtonSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSalir.Name = "toolStripButtonSalir";
            this.toolStripButtonSalir.Size = new System.Drawing.Size(77, 55);
            this.toolStripButtonSalir.Text = "Salir";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(364, 152);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(392, 38);
            this.txtNombre.TabIndex = 36;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 152);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(114, 32);
            this.lblNombre.TabIndex = 35;
            this.lblNombre.Text = "Nombre";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(364, 280);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(332, 39);
            this.cmbTipo.TabIndex = 38;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(20, 280);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(70, 32);
            this.lblTipo.TabIndex = 37;
            this.lblTipo.Text = "Tipo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 431);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 38);
            this.textBox1.TabIndex = 40;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(20, 431);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(114, 32);
            this.lblValor.TabIndex = 39;
            this.lblValor.Text = "Nombre";
            // 
            // cmbTipoValor
            // 
            this.cmbTipoValor.FormattingEnabled = true;
            this.cmbTipoValor.Location = new System.Drawing.Point(364, 524);
            this.cmbTipoValor.Name = "cmbTipoValor";
            this.cmbTipoValor.Size = new System.Drawing.Size(332, 39);
            this.cmbTipoValor.TabIndex = 42;
            // 
            // lblTipoValor
            // 
            this.lblTipoValor.AutoSize = true;
            this.lblTipoValor.Location = new System.Drawing.Point(20, 531);
            this.lblTipoValor.Name = "lblTipoValor";
            this.lblTipoValor.Size = new System.Drawing.Size(129, 32);
            this.lblTipoValor.TabIndex = 41;
            this.lblTipoValor.Text = "Prioridad";
            // 
            // frmMantenimientoDeduccionesPercepciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1447, 1357);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMantenimientoDeduccionesPercepciones";
            this.Text = "Mantenimiento de Deducciones y Percepciones";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStripMantEmpresa.ResumeLayout(false);
            this.toolStripMantEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeduccionesPercepciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbColaborador;
        private System.Windows.Forms.RadioButton rdbInactiva;
        private System.Windows.Forms.RadioButton rdbActiva;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.Label lblColaborador;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ToolStrip toolStripMantEmpresa;
        private System.Windows.Forms.ToolStripButton toolStripButtonAgregar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminar;
        private System.Windows.Forms.ToolStripButton toolStripButtonLimpiar;
        private System.Windows.Forms.ToolStripButton toolStripButtonSalir;
        private System.Windows.Forms.DataGridView dgvDeduccionesPercepciones;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipoValor;
        private System.Windows.Forms.Label lblTipoValor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblValor;
    }
}