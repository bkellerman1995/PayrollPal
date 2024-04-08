namespace PayrollPal.UI.Consultas
{
    partial class frmConsultaMarcas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCargarArchivoJson = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnMostrarListaMarcas = new System.Windows.Forms.Button();
            this.txtRutaArchivoJSON = new System.Windows.Forms.TextBox();
            this.lblRutaArchivoJSON = new System.Windows.Forms.Label();
            this.pctCargarJSON = new System.Windows.Forms.PictureBox();
            this.dgvListaMarcas = new System.Windows.Forms.DataGridView();
            this.errProv1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCargarJSON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProv1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarArchivoJson
            // 
            this.btnCargarArchivoJson.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarArchivoJson.Location = new System.Drawing.Point(12, 35);
            this.btnCargarArchivoJson.Name = "btnCargarArchivoJson";
            this.btnCargarArchivoJson.Size = new System.Drawing.Size(119, 37);
            this.btnCargarArchivoJson.TabIndex = 1;
            this.btnCargarArchivoJson.Text = "Cargar JSON";
            this.btnCargarArchivoJson.UseVisualStyleBackColor = true;
            this.btnCargarArchivoJson.Click += new System.EventHandler(this.btnCargarArchivoJson_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.btnMostrarListaMarcas);
            this.splitContainer1.Panel1.Controls.Add(this.txtRutaArchivoJSON);
            this.splitContainer1.Panel1.Controls.Add(this.lblRutaArchivoJSON);
            this.splitContainer1.Panel1.Controls.Add(this.pctCargarJSON);
            this.splitContainer1.Panel1.Controls.Add(this.btnCargarArchivoJson);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvListaMarcas);
            this.splitContainer1.Size = new System.Drawing.Size(826, 516);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnMostrarListaMarcas
            // 
            this.btnMostrarListaMarcas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarListaMarcas.Location = new System.Drawing.Point(341, 146);
            this.btnMostrarListaMarcas.Name = "btnMostrarListaMarcas";
            this.btnMostrarListaMarcas.Size = new System.Drawing.Size(119, 28);
            this.btnMostrarListaMarcas.TabIndex = 6;
            this.btnMostrarListaMarcas.Text = "Mostrar Marcas";
            this.btnMostrarListaMarcas.UseVisualStyleBackColor = true;
            this.btnMostrarListaMarcas.Click += new System.EventHandler(this.btnMostrarListaMarcas_Click);
            // 
            // txtRutaArchivoJSON
            // 
            this.txtRutaArchivoJSON.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaArchivoJSON.Location = new System.Drawing.Point(176, 99);
            this.txtRutaArchivoJSON.Multiline = true;
            this.txtRutaArchivoJSON.Name = "txtRutaArchivoJSON";
            this.txtRutaArchivoJSON.ReadOnly = true;
            this.txtRutaArchivoJSON.Size = new System.Drawing.Size(627, 41);
            this.txtRutaArchivoJSON.TabIndex = 5;
            // 
            // lblRutaArchivoJSON
            // 
            this.lblRutaArchivoJSON.AutoSize = true;
            this.lblRutaArchivoJSON.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaArchivoJSON.Location = new System.Drawing.Point(3, 108);
            this.lblRutaArchivoJSON.Name = "lblRutaArchivoJSON";
            this.lblRutaArchivoJSON.Size = new System.Drawing.Size(167, 21);
            this.lblRutaArchivoJSON.TabIndex = 4;
            this.lblRutaArchivoJSON.Text = "Ruta del Archivo JSON";
            // 
            // pctCargarJSON
            // 
            this.pctCargarJSON.Location = new System.Drawing.Point(149, 35);
            this.pctCargarJSON.Name = "pctCargarJSON";
            this.pctCargarJSON.Size = new System.Drawing.Size(54, 51);
            this.pctCargarJSON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCargarJSON.TabIndex = 2;
            this.pctCargarJSON.TabStop = false;
            // 
            // dgvListaMarcas
            // 
            this.dgvListaMarcas.AllowUserToAddRows = false;
            this.dgvListaMarcas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListaMarcas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaMarcas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaMarcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListaMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaMarcas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListaMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaMarcas.Location = new System.Drawing.Point(0, 0);
            this.dgvListaMarcas.Margin = new System.Windows.Forms.Padding(1);
            this.dgvListaMarcas.Name = "dgvListaMarcas";
            this.dgvListaMarcas.ReadOnly = true;
            this.dgvListaMarcas.RowHeadersVisible = false;
            this.dgvListaMarcas.RowHeadersWidth = 102;
            this.dgvListaMarcas.RowTemplate.Height = 40;
            this.dgvListaMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaMarcas.Size = new System.Drawing.Size(826, 327);
            this.dgvListaMarcas.TabIndex = 5;
            // 
            // errProv1
            // 
            this.errProv1.ContainerControl = this;
            // 
            // frmConsultaMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(826, 516);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmConsultaMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Marcas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultaMarcas_FormClosing);
            this.Load += new System.EventHandler(this.frmConsultaMarcas_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctCargarJSON)).EndInit();
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
    }
}