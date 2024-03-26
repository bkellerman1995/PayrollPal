namespace PayrollPal.UI.Procesos
{
    partial class frmProcesoCalcularPlanilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoCalcularPlanilla));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStripMantEmpresa = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSalir = new System.Windows.Forms.ToolStripButton();
            this.btnCalcularPlanilla = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblColaborador = new System.Windows.Forms.Label();
            this.cmbColaborador = new System.Windows.Forms.ComboBox();
            this.dgvOrdvsExt = new System.Windows.Forms.DataGridView();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.lblHorasOrdvsExt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTipoCambio = new System.Windows.Forms.Label();
            this.txtTipoCambio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripMantEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdvsExt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtTipoCambio);
            this.splitContainer1.Panel1.Controls.Add(this.lblTipoCambio);
            this.splitContainer1.Panel1.Controls.Add(this.lblHorasOrdvsExt);
            this.splitContainer1.Panel1.Controls.Add(this.lblMarcas);
            this.splitContainer1.Panel1.Controls.Add(this.dgvMarcas);
            this.splitContainer1.Panel1.Controls.Add(this.dgvOrdvsExt);
            this.splitContainer1.Panel1.Controls.Add(this.cmbColaborador);
            this.splitContainer1.Panel1.Controls.Add(this.lblColaborador);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaHasta);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaDesde);
            this.splitContainer1.Panel1.Controls.Add(this.lblFechaHasta);
            this.splitContainer1.Panel1.Controls.Add(this.txtNombre);
            this.splitContainer1.Panel1.Controls.Add(this.lblNombre);
            this.splitContainer1.Panel1.Controls.Add(this.lblFechaDesde);
            this.splitContainer1.Panel1.Controls.Add(this.txtCodigo);
            this.splitContainer1.Panel1.Controls.Add(this.lblCodigo);
            this.splitContainer1.Panel1.Controls.Add(this.btnCalcularPlanilla);
            this.splitContainer1.Panel1.Controls.Add(this.toolStripMantEmpresa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1149, 659);
            this.splitContainer1.SplitterDistance = 754;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStripMantEmpresa
            // 
            this.toolStripMantEmpresa.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStripMantEmpresa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLimpiar,
            this.toolStripButtonSalir});
            this.toolStripMantEmpresa.Location = new System.Drawing.Point(0, 0);
            this.toolStripMantEmpresa.Name = "toolStripMantEmpresa";
            this.toolStripMantEmpresa.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMantEmpresa.Size = new System.Drawing.Size(754, 25);
            this.toolStripMantEmpresa.TabIndex = 18;
            this.toolStripMantEmpresa.Text = "toolStrip1";
            // 
            // toolStripButtonLimpiar
            // 
            this.toolStripButtonLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLimpiar.Image")));
            this.toolStripButtonLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLimpiar.Name = "toolStripButtonLimpiar";
            this.toolStripButtonLimpiar.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonLimpiar.Text = "Limpiar";
            // 
            // toolStripButtonSalir
            // 
            this.toolStripButtonSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSalir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSalir.Image")));
            this.toolStripButtonSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSalir.Name = "toolStripButtonSalir";
            this.toolStripButtonSalir.Size = new System.Drawing.Size(33, 22);
            this.toolStripButtonSalir.Text = "Salir";
            // 
            // btnCalcularPlanilla
            // 
            this.btnCalcularPlanilla.Location = new System.Drawing.Point(12, 578);
            this.btnCalcularPlanilla.Name = "btnCalcularPlanilla";
            this.btnCalcularPlanilla.Size = new System.Drawing.Size(167, 38);
            this.btnCalcularPlanilla.TabIndex = 19;
            this.btnCalcularPlanilla.Text = "Calcular Planilla";
            this.btnCalcularPlanilla.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(9, 46);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(90, 13);
            this.lblCodigo.TabIndex = 20;
            this.lblCodigo.Text = "Código de planilla";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(126, 43);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 21;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(12, 141);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(71, 13);
            this.lblFechaDesde.TabIndex = 22;
            this.lblFechaDesde.Text = "Fecha Desde";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 99);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(126, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 24;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(12, 178);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(68, 13);
            this.lblFechaHasta.TabIndex = 25;
            this.lblFechaHasta.Text = "Fecha Hasta";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(117, 141);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 26;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(117, 178);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 27;
            // 
            // lblColaborador
            // 
            this.lblColaborador.AutoSize = true;
            this.lblColaborador.Location = new System.Drawing.Point(12, 225);
            this.lblColaborador.Name = "lblColaborador";
            this.lblColaborador.Size = new System.Drawing.Size(64, 13);
            this.lblColaborador.TabIndex = 28;
            this.lblColaborador.Text = "Colaborador";
            // 
            // cmbColaborador
            // 
            this.cmbColaborador.FormattingEnabled = true;
            this.cmbColaborador.Location = new System.Drawing.Point(117, 222);
            this.cmbColaborador.Name = "cmbColaborador";
            this.cmbColaborador.Size = new System.Drawing.Size(121, 21);
            this.cmbColaborador.TabIndex = 29;
            // 
            // dgvOrdvsExt
            // 
            this.dgvOrdvsExt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdvsExt.Location = new System.Drawing.Point(413, 315);
            this.dgvOrdvsExt.Name = "dgvOrdvsExt";
            this.dgvOrdvsExt.Size = new System.Drawing.Size(321, 212);
            this.dgvOrdvsExt.TabIndex = 31;
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(15, 315);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.Size = new System.Drawing.Size(321, 212);
            this.dgvMarcas.TabIndex = 32;
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Location = new System.Drawing.Point(19, 289);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(42, 13);
            this.lblMarcas.TabIndex = 33;
            this.lblMarcas.Text = "Marcas";
            // 
            // lblHorasOrdvsExt
            // 
            this.lblHorasOrdvsExt.AutoSize = true;
            this.lblHorasOrdvsExt.Location = new System.Drawing.Point(410, 289);
            this.lblHorasOrdvsExt.Name = "lblHorasOrdvsExt";
            this.lblHorasOrdvsExt.Size = new System.Drawing.Size(159, 13);
            this.lblHorasOrdvsExt.TabIndex = 34;
            this.lblHorasOrdvsExt.Text = "Horas Ordinarias y Extrardinarias";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 659);
            this.textBox1.TabIndex = 0;
            // 
            // lblTipoCambio
            // 
            this.lblTipoCambio.AutoSize = true;
            this.lblTipoCambio.Location = new System.Drawing.Point(410, 50);
            this.lblTipoCambio.Name = "lblTipoCambio";
            this.lblTipoCambio.Size = new System.Drawing.Size(168, 13);
            this.lblTipoCambio.TabIndex = 35;
            this.lblTipoCambio.Text = "Tipo de Cambio del dólar para hoy";
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.Location = new System.Drawing.Point(597, 50);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.ReadOnly = true;
            this.txtTipoCambio.Size = new System.Drawing.Size(100, 20);
            this.txtTipoCambio.TabIndex = 36;
            // 
            // frmProcesoCalcularPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 659);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmProcesoCalcularPlanilla";
            this.Text = "Cálculo de Planilla";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStripMantEmpresa.ResumeLayout(false);
            this.toolStripMantEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdvsExt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStripMantEmpresa;
        private System.Windows.Forms.ToolStripButton toolStripButtonLimpiar;
        private System.Windows.Forms.ToolStripButton toolStripButtonSalir;
        private System.Windows.Forms.Button btnCalcularPlanilla;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblColaborador;
        private System.Windows.Forms.ComboBox cmbColaborador;
        private System.Windows.Forms.DataGridView dgvOrdvsExt;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.Label lblHorasOrdvsExt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTipoCambio;
        private System.Windows.Forms.TextBox txtTipoCambio;
    }
}