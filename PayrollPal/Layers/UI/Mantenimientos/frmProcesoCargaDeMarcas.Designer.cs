namespace PayrollPal.UI.Consultas
{
    partial class frmProcesoCargaDeMarcas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoCargaDeMarcas));
            this.btnCargarArchivoJson = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnMostrarListaMarcas = new System.Windows.Forms.Button();
            this.txtRutaArchivoJSON = new System.Windows.Forms.TextBox();
            this.lblRutaArchivoJSON = new System.Windows.Forms.Label();
            this.pctCargarJSON = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslblUsuarioConectado = new System.Windows.Forms.ToolStripLabel();
            this.dgvListaMarcas = new System.Windows.Forms.DataGridView();
            this.idMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasTrabajadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errProv1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCargarJSON)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProv1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarArchivoJson
            // 
            this.btnCargarArchivoJson.AutoSize = true;
            this.btnCargarArchivoJson.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarArchivoJson.Location = new System.Drawing.Point(30, 88);
            this.btnCargarArchivoJson.Margin = new System.Windows.Forms.Padding(8);
            this.btnCargarArchivoJson.Name = "btnCargarArchivoJson";
            this.btnCargarArchivoJson.Size = new System.Drawing.Size(298, 92);
            this.btnCargarArchivoJson.TabIndex = 1;
            this.btnCargarArchivoJson.Text = "Cargar JSON";
            this.btnCargarArchivoJson.UseVisualStyleBackColor = true;
            this.btnCargarArchivoJson.Click += new System.EventHandler(this.btnCargarArchivoJson_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(8);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightBlue;
            this.splitContainer1.Panel1.Controls.Add(this.btnMostrarListaMarcas);
            this.splitContainer1.Panel1.Controls.Add(this.txtRutaArchivoJSON);
            this.splitContainer1.Panel1.Controls.Add(this.lblRutaArchivoJSON);
            this.splitContainer1.Panel1.Controls.Add(this.pctCargarJSON);
            this.splitContainer1.Panel1.Controls.Add(this.btnCargarArchivoJson);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.dgvListaMarcas);
            this.splitContainer1.Size = new System.Drawing.Size(2065, 1588);
            this.splitContainer1.SplitterDistance = 661;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnMostrarListaMarcas
            // 
            this.btnMostrarListaMarcas.AutoSize = true;
            this.btnMostrarListaMarcas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarListaMarcas.Location = new System.Drawing.Point(852, 419);
            this.btnMostrarListaMarcas.Margin = new System.Windows.Forms.Padding(8);
            this.btnMostrarListaMarcas.Name = "btnMostrarListaMarcas";
            this.btnMostrarListaMarcas.Size = new System.Drawing.Size(307, 70);
            this.btnMostrarListaMarcas.TabIndex = 6;
            this.btnMostrarListaMarcas.Text = "Mostrar Marcas";
            this.btnMostrarListaMarcas.UseVisualStyleBackColor = true;
            this.btnMostrarListaMarcas.Click += new System.EventHandler(this.btnMostrarListaMarcas_Click);
            // 
            // txtRutaArchivoJSON
            // 
            this.txtRutaArchivoJSON.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaArchivoJSON.Location = new System.Drawing.Point(440, 248);
            this.txtRutaArchivoJSON.Margin = new System.Windows.Forms.Padding(8);
            this.txtRutaArchivoJSON.Multiline = true;
            this.txtRutaArchivoJSON.Name = "txtRutaArchivoJSON";
            this.txtRutaArchivoJSON.ReadOnly = true;
            this.txtRutaArchivoJSON.Size = new System.Drawing.Size(1562, 96);
            this.txtRutaArchivoJSON.TabIndex = 5;
            // 
            // lblRutaArchivoJSON
            // 
            this.lblRutaArchivoJSON.AutoSize = true;
            this.lblRutaArchivoJSON.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaArchivoJSON.Location = new System.Drawing.Point(8, 270);
            this.lblRutaArchivoJSON.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblRutaArchivoJSON.Name = "lblRutaArchivoJSON";
            this.lblRutaArchivoJSON.Size = new System.Drawing.Size(420, 54);
            this.lblRutaArchivoJSON.TabIndex = 4;
            this.lblRutaArchivoJSON.Text = "Ruta del Archivo JSON";
            // 
            // pctCargarJSON
            // 
            this.pctCargarJSON.Location = new System.Drawing.Point(372, 88);
            this.pctCargarJSON.Margin = new System.Windows.Forms.Padding(8);
            this.pctCargarJSON.Name = "pctCargarJSON";
            this.pctCargarJSON.Size = new System.Drawing.Size(135, 128);
            this.pctCargarJSON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCargarJSON.TabIndex = 2;
            this.pctCargarJSON.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblUsuarioConectado});
            this.toolStrip1.Location = new System.Drawing.Point(0, 856);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(2065, 61);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslblUsuarioConectado
            // 
            this.tslblUsuarioConectado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslblUsuarioConectado.Name = "tslblUsuarioConectado";
            this.tslblUsuarioConectado.Size = new System.Drawing.Size(291, 54);
            this.tslblUsuarioConectado.Text = "toolStripLabel1";
            // 
            // dgvListaMarcas
            // 
            this.dgvListaMarcas.AllowUserToAddRows = false;
            this.dgvListaMarcas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListaMarcas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaMarcas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaMarcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMarca,
            this.IdColaborador,
            this.HoraEntrada,
            this.HoraSalida,
            this.Fecha,
            this.HorasTrabajadas});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaMarcas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaMarcas.Location = new System.Drawing.Point(0, 0);
            this.dgvListaMarcas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaMarcas.Name = "dgvListaMarcas";
            this.dgvListaMarcas.ReadOnly = true;
            this.dgvListaMarcas.RowHeadersVisible = false;
            this.dgvListaMarcas.RowHeadersWidth = 102;
            this.dgvListaMarcas.RowTemplate.Height = 40;
            this.dgvListaMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaMarcas.Size = new System.Drawing.Size(2065, 917);
            this.dgvListaMarcas.TabIndex = 5;
            // 
            // idMarca
            // 
            this.idMarca.DataPropertyName = "idMarca";
            this.idMarca.HeaderText = "ID";
            this.idMarca.MinimumWidth = 12;
            this.idMarca.Name = "idMarca";
            this.idMarca.ReadOnly = true;
            // 
            // IdColaborador
            // 
            this.IdColaborador.DataPropertyName = "IdColaborador";
            this.IdColaborador.HeaderText = "Colaborador";
            this.IdColaborador.MinimumWidth = 12;
            this.IdColaborador.Name = "IdColaborador";
            this.IdColaborador.ReadOnly = true;
            // 
            // HoraEntrada
            // 
            this.HoraEntrada.DataPropertyName = "HoraEntrada";
            this.HoraEntrada.HeaderText = "Hora de Entrada";
            this.HoraEntrada.MinimumWidth = 12;
            this.HoraEntrada.Name = "HoraEntrada";
            this.HoraEntrada.ReadOnly = true;
            // 
            // HoraSalida
            // 
            this.HoraSalida.DataPropertyName = "HoraSalida";
            this.HoraSalida.HeaderText = "Hora de Salida";
            this.HoraSalida.MinimumWidth = 12;
            this.HoraSalida.Name = "HoraSalida";
            this.HoraSalida.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 12;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // HorasTrabajadas
            // 
            this.HorasTrabajadas.DataPropertyName = "HorasTrabajadas";
            this.HorasTrabajadas.HeaderText = "Horas Trabajadas";
            this.HorasTrabajadas.MinimumWidth = 12;
            this.HorasTrabajadas.Name = "HorasTrabajadas";
            this.HorasTrabajadas.ReadOnly = true;
            // 
            // errProv1
            // 
            this.errProv1.ContainerControl = this;
            // 
            // frmProcesoCargaDeMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2065, 1588);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "frmProcesoCargaDeMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Carga de Marcas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultaMarcas_FormClosing);
            this.Load += new System.EventHandler(this.frmConsultaMarcas_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctCargarJSON)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCargarArchivoJson;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pctCargarJSON;
        private System.Windows.Forms.Label lblRutaArchivoJSON;
        private System.Windows.Forms.TextBox txtRutaArchivoJSON;
        private System.Windows.Forms.Button btnMostrarListaMarcas;
        private System.Windows.Forms.DataGridView dgvListaMarcas;
        private System.Windows.Forms.ErrorProvider errProv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasTrabajadas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslblUsuarioConectado;
    }
}