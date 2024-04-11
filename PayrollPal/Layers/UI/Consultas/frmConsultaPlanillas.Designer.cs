namespace PayrollPal.Layers.UI.Consultas
{
    partial class frmConsultaPlanillas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaPlanillas));
            this.btnConsultar = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtColab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.dgvPlanillas = new System.Windows.Forms.DataGridView();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Planilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalIngresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalGastos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHoy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMantEmpresa = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillas)).BeginInit();
            this.toolStripMantEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(10, 151);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(125, 32);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStripMantEmpresa);
            this.splitContainer1.Panel1.Controls.Add(this.dgvPlanillas);
            this.splitContainer1.Panel1.Controls.Add(this.btnEnviar);
            this.splitContainer1.Panel1.Controls.Add(this.txtColab);
            this.splitContainer1.Panel1.Controls.Add(this.btnConsultar);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaHasta);
            this.splitContainer1.Panel1.Controls.Add(this.lblDesde);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaDesde);
            this.splitContainer1.Panel1.Controls.Add(this.lblHasta);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1462, 748);
            this.splitContainer1.SplitterDistance = 805;
            this.splitContainer1.TabIndex = 5;
            // 
            // txtColab
            // 
            this.txtColab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColab.Location = new System.Drawing.Point(111, 38);
            this.txtColab.Name = "txtColab";
            this.txtColab.ReadOnly = true;
            this.txtColab.Size = new System.Drawing.Size(100, 29);
            this.txtColab.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Colaborador";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHasta.Location = new System.Drawing.Point(457, 82);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 29);
            this.dtpFechaHasta.TabIndex = 8;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDesde.Location = new System.Drawing.Point(102, 84);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 29);
            this.dtpFechaDesde.TabIndex = 7;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(402, 90);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(49, 21);
            this.lblHasta.TabIndex = 10;
            this.lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(43, 92);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(53, 21);
            this.lblDesde.TabIndex = 9;
            this.lblDesde.Text = "Desde";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(677, 151);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(125, 32);
            this.btnEnviar.TabIndex = 13;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // dgvPlanillas
            // 
            this.dgvPlanillas.AllowUserToAddRows = false;
            this.dgvPlanillas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPlanillas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlanillas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanillas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanillas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPlanillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanillas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Planilla,
            this.TipoCambio,
            this.TotalIngresos,
            this.TotalGastos,
            this.TotalPagar,
            this.FechaHoy});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlanillas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPlanillas.Location = new System.Drawing.Point(0, 189);
            this.dgvPlanillas.Margin = new System.Windows.Forms.Padding(1);
            this.dgvPlanillas.Name = "dgvPlanillas";
            this.dgvPlanillas.ReadOnly = true;
            this.dgvPlanillas.RowHeadersVisible = false;
            this.dgvPlanillas.RowHeadersWidth = 102;
            this.dgvPlanillas.RowTemplate.Height = 40;
            this.dgvPlanillas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanillas.Size = new System.Drawing.Size(804, 558);
            this.dgvPlanillas.TabIndex = 14;
            this.dgvPlanillas.SelectionChanged += new System.EventHandler(this.dgvPlanillas_SelectionChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PayrollPal.test.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(653, 748);
            this.reportViewer1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IdEncabezado";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Planilla
            // 
            this.Planilla.DataPropertyName = "Codigo";
            this.Planilla.HeaderText = "Planilla";
            this.Planilla.Name = "Planilla";
            this.Planilla.ReadOnly = true;
            // 
            // TipoCambio
            // 
            this.TipoCambio.DataPropertyName = "TipoCambio";
            this.TipoCambio.HeaderText = "Tipo de Cambio";
            this.TipoCambio.Name = "TipoCambio";
            this.TipoCambio.ReadOnly = true;
            // 
            // TotalIngresos
            // 
            this.TotalIngresos.DataPropertyName = "TotalIngresos";
            this.TotalIngresos.HeaderText = "TotalIngresos";
            this.TotalIngresos.Name = "TotalIngresos";
            this.TotalIngresos.ReadOnly = true;
            // 
            // TotalGastos
            // 
            this.TotalGastos.DataPropertyName = "TotalGastos";
            this.TotalGastos.HeaderText = "TotalGastos";
            this.TotalGastos.Name = "TotalGastos";
            this.TotalGastos.ReadOnly = true;
            // 
            // TotalPagar
            // 
            this.TotalPagar.DataPropertyName = "TotalPagar";
            this.TotalPagar.HeaderText = "TotalPagar";
            this.TotalPagar.Name = "TotalPagar";
            this.TotalPagar.ReadOnly = true;
            // 
            // FechaHoy
            // 
            this.FechaHoy.DataPropertyName = "Fechahoy";
            this.FechaHoy.HeaderText = "Fecha Generada";
            this.FechaHoy.Name = "FechaHoy";
            this.FechaHoy.ReadOnly = true;
            // 
            // toolStripMantEmpresa
            // 
            this.toolStripMantEmpresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMantEmpresa.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStripMantEmpresa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.toolStripMantEmpresa.Location = new System.Drawing.Point(0, 0);
            this.toolStripMantEmpresa.Name = "toolStripMantEmpresa";
            this.toolStripMantEmpresa.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMantEmpresa.Size = new System.Drawing.Size(805, 28);
            this.toolStripMantEmpresa.TabIndex = 18;
            this.toolStripMantEmpresa.Text = "toolStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(45, 25);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmConsultaPlanillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1462, 748);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmConsultaPlanillas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Planillas";
            this.Load += new System.EventHandler(this.frmConsultaPlanillas_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillas)).EndInit();
            this.toolStripMantEmpresa.ResumeLayout(false);
            this.toolStripMantEmpresa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtColab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.DataGridView dgvPlanillas;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Planilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalIngresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalGastos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoy;
        private System.Windows.Forms.ToolStrip toolStripMantEmpresa;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}