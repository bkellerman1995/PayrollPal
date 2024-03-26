namespace PayrollPal.UI.Mantenimientos
{
    partial class frmMantenimientoSolicitudVacaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoSolicitudVacaciones));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvSolicitudesVacaciones = new System.Windows.Forms.DataGridView();
            this.cmbColaborador = new System.Windows.Forms.ComboBox();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.lblColaborador = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.toolStripMantEmpresa = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSalir = new System.Windows.Forms.ToolStripButton();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblCantDias = new System.Windows.Forms.Label();
            this.nudCantDias = new System.Windows.Forms.NumericUpDown();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblObservacionesFinales = new System.Windows.Forms.Label();
            this.cmbObservacionesFinales = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesVacaciones)).BeginInit();
            this.toolStripMantEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantDias)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.cmbObservacionesFinales);
            this.splitContainer1.Panel1.Controls.Add(this.lblObservacionesFinales);
            this.splitContainer1.Panel1.Controls.Add(this.txtObservaciones);
            this.splitContainer1.Panel1.Controls.Add(this.lblObservaciones);
            this.splitContainer1.Panel1.Controls.Add(this.nudCantDias);
            this.splitContainer1.Panel1.Controls.Add(this.lblCantDias);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaHasta);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaDesde);
            this.splitContainer1.Panel1.Controls.Add(this.lblFechaHasta);
            this.splitContainer1.Panel1.Controls.Add(this.lblFechaDesde);
            this.splitContainer1.Panel1.Controls.Add(this.cmbColaborador);
            this.splitContainer1.Panel1.Controls.Add(this.Codigo);
            this.splitContainer1.Panel1.Controls.Add(this.lblColaborador);
            this.splitContainer1.Panel1.Controls.Add(this.lblCodigo);
            this.splitContainer1.Panel1.Controls.Add(this.toolStripMantEmpresa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvSolicitudesVacaciones);
            this.splitContainer1.Size = new System.Drawing.Size(1626, 1352);
            this.splitContainer1.SplitterDistance = 799;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvSolicitudesVacaciones
            // 
            this.dgvSolicitudesVacaciones.AllowUserToAddRows = false;
            this.dgvSolicitudesVacaciones.AllowUserToDeleteRows = false;
            this.dgvSolicitudesVacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudesVacaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSolicitudesVacaciones.Location = new System.Drawing.Point(0, 0);
            this.dgvSolicitudesVacaciones.Name = "dgvSolicitudesVacaciones";
            this.dgvSolicitudesVacaciones.ReadOnly = true;
            this.dgvSolicitudesVacaciones.RowHeadersWidth = 102;
            this.dgvSolicitudesVacaciones.RowTemplate.Height = 40;
            this.dgvSolicitudesVacaciones.Size = new System.Drawing.Size(1626, 549);
            this.dgvSolicitudesVacaciones.TabIndex = 4;
            // 
            // cmbColaborador
            // 
            this.cmbColaborador.FormattingEnabled = true;
            this.cmbColaborador.Location = new System.Drawing.Point(364, 216);
            this.cmbColaborador.Name = "cmbColaborador";
            this.cmbColaborador.Size = new System.Drawing.Size(332, 39);
            this.cmbColaborador.TabIndex = 43;
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(364, 142);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(392, 38);
            this.Codigo.TabIndex = 40;
            // 
            // lblColaborador
            // 
            this.lblColaborador.AutoSize = true;
            this.lblColaborador.Location = new System.Drawing.Point(20, 216);
            this.lblColaborador.Name = "lblColaborador";
            this.lblColaborador.Size = new System.Drawing.Size(171, 32);
            this.lblColaborador.TabIndex = 37;
            this.lblColaborador.Text = "Colaborador";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 142);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(105, 32);
            this.lblCodigo.TabIndex = 36;
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
            this.toolStripMantEmpresa.Size = new System.Drawing.Size(1626, 52);
            this.toolStripMantEmpresa.TabIndex = 35;
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
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(364, 390);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(436, 38);
            this.dtpFechaHasta.TabIndex = 57;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(364, 321);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(455, 38);
            this.dtpFechaDesde.TabIndex = 56;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(20, 396);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(174, 32);
            this.lblFechaHasta.TabIndex = 55;
            this.lblFechaHasta.Text = "Fecha Hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(20, 321);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(182, 32);
            this.lblFechaDesde.TabIndex = 54;
            this.lblFechaDesde.Text = "Fecha Desde";
            // 
            // lblCantDias
            // 
            this.lblCantDias.AutoSize = true;
            this.lblCantDias.Location = new System.Drawing.Point(28, 487);
            this.lblCantDias.Name = "lblCantDias";
            this.lblCantDias.Size = new System.Drawing.Size(232, 32);
            this.lblCantDias.TabIndex = 58;
            this.lblCantDias.Text = "Cantidad de Días";
            // 
            // nudCantDias
            // 
            this.nudCantDias.Location = new System.Drawing.Point(364, 481);
            this.nudCantDias.Name = "nudCantDias";
            this.nudCantDias.Size = new System.Drawing.Size(120, 38);
            this.nudCantDias.TabIndex = 59;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(364, 572);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(392, 38);
            this.txtObservaciones.TabIndex = 61;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(20, 572);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(204, 32);
            this.lblObservaciones.TabIndex = 60;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // lblObservacionesFinales
            // 
            this.lblObservacionesFinales.AutoSize = true;
            this.lblObservacionesFinales.Location = new System.Drawing.Point(20, 665);
            this.lblObservacionesFinales.Name = "lblObservacionesFinales";
            this.lblObservacionesFinales.Size = new System.Drawing.Size(164, 32);
            this.lblObservacionesFinales.TabIndex = 62;
            this.lblObservacionesFinales.Text = "Estado final";
            // 
            // cmbObservacionesFinales
            // 
            this.cmbObservacionesFinales.FormattingEnabled = true;
            this.cmbObservacionesFinales.Location = new System.Drawing.Point(364, 662);
            this.cmbObservacionesFinales.Name = "cmbObservacionesFinales";
            this.cmbObservacionesFinales.Size = new System.Drawing.Size(332, 39);
            this.cmbObservacionesFinales.TabIndex = 63;
            // 
            // frmMantenimientoSolicitudVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 1352);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMantenimientoSolicitudVacaciones";
            this.Text = "Mantenimiento Solicitud de Vacaciones";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesVacaciones)).EndInit();
            this.toolStripMantEmpresa.ResumeLayout(false);
            this.toolStripMantEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantDias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvSolicitudesVacaciones;
        private System.Windows.Forms.ComboBox cmbColaborador;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.Label lblColaborador;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ToolStrip toolStripMantEmpresa;
        private System.Windows.Forms.ToolStripButton toolStripButtonAgregar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminar;
        private System.Windows.Forms.ToolStripButton toolStripButtonLimpiar;
        private System.Windows.Forms.ToolStripButton toolStripButtonSalir;
        private System.Windows.Forms.Label lblCantDias;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.NumericUpDown nudCantDias;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblObservacionesFinales;
        private System.Windows.Forms.ComboBox cmbObservacionesFinales;
    }
}