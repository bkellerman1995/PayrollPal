﻿namespace PayrollPal.Layers.UI.Mantenimientos
{
    partial class frmMantenimientoSupervisores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoSupervisores));
            this.toolTipSupervisor = new System.Windows.Forms.ToolTip(this.components);
            this.mktID = new System.Windows.Forms.MaskedTextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dgvSupervisores = new System.Windows.Forms.DataGridView();
            this.IDSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripMantSupervisor = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.errProv1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblListaColaboradoresSup = new System.Windows.Forms.Label();
            this.lblListaColaboradoresALL = new System.Windows.Forms.Label();
            this.btnQuitarColab = new System.Windows.Forms.Button();
            this.btnAgregarCol = new System.Windows.Forms.Button();
            this.lstColaboradoresSup = new System.Windows.Forms.ListBox();
            this.lstColaboradoresALL = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupervisores)).BeginInit();
            this.toolStripMantSupervisor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mktID
            // 
            this.mktID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktID.Location = new System.Drawing.Point(165, 46);
            this.mktID.Mask = "sup0000";
            this.mktID.Name = "mktID";
            this.mktID.Size = new System.Drawing.Size(150, 29);
            this.mktID.TabIndex = 59;
            this.toolTipSupervisor.SetToolTip(this.mktID, "El ID de Supervisor debe tener el formato: sup0000 (4 dígitos)");
            this.mktID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mktID_KeyUp);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(909, 330);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 35);
            this.btnConfirmar.TabIndex = 60;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(165, 127);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(150, 29);
            this.txtDescripcion.TabIndex = 57;
            this.txtDescripcion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyUp);
            // 
            // txtRol
            // 
            this.txtRol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRol.Location = new System.Drawing.Point(165, 82);
            this.txtRol.Margin = new System.Windows.Forms.Padding(1);
            this.txtRol.Name = "txtRol";
            this.txtRol.ReadOnly = true;
            this.txtRol.Size = new System.Drawing.Size(150, 29);
            this.txtRol.TabIndex = 54;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(8, 88);
            this.lblRol.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(33, 21);
            this.lblRol.TabIndex = 53;
            this.lblRol.Text = "Rol";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(8, 130);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 21);
            this.lblDescripcion.TabIndex = 45;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(10, 49);
            this.lblID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 21);
            this.lblID.TabIndex = 44;
            this.lblID.Text = "ID";
            // 
            // dgvSupervisores
            // 
            this.dgvSupervisores.AllowUserToAddRows = false;
            this.dgvSupervisores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSupervisores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSupervisores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupervisores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupervisores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSupervisores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupervisores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSupervisor,
            this.IDRol,
            this.Descripcion});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupervisores.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSupervisores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupervisores.Location = new System.Drawing.Point(0, 0);
            this.dgvSupervisores.Margin = new System.Windows.Forms.Padding(1);
            this.dgvSupervisores.Name = "dgvSupervisores";
            this.dgvSupervisores.ReadOnly = true;
            this.dgvSupervisores.RowHeadersVisible = false;
            this.dgvSupervisores.RowHeadersWidth = 102;
            this.dgvSupervisores.RowTemplate.Height = 40;
            this.dgvSupervisores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupervisores.Size = new System.Drawing.Size(1132, 406);
            this.dgvSupervisores.TabIndex = 4;
            // 
            // IDSupervisor
            // 
            this.IDSupervisor.DataPropertyName = "IDSupervisor";
            this.IDSupervisor.HeaderText = "ID Supervisor";
            this.IDSupervisor.Name = "IDSupervisor";
            this.IDSupervisor.ReadOnly = true;
            // 
            // IDRol
            // 
            this.IDRol.DataPropertyName = "IDRol";
            this.IDRol.HeaderText = "Rol";
            this.IDRol.Name = "IDRol";
            this.IDRol.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(45, 25);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // toolStripMantSupervisor
            // 
            this.toolStripMantSupervisor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMantSupervisor.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStripMantSupervisor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEditar,
            this.btnEliminar,
            this.btnLimpiar,
            this.btnSalir});
            this.toolStripMantSupervisor.Location = new System.Drawing.Point(0, 0);
            this.toolStripMantSupervisor.Name = "toolStripMantSupervisor";
            this.toolStripMantSupervisor.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMantSupervisor.Size = new System.Drawing.Size(1132, 28);
            this.toolStripMantSupervisor.TabIndex = 43;
            this.toolStripMantSupervisor.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(70, 25);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(54, 25);
            this.btnEditar.Text = "Editar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(71, 25);
            this.btnEliminar.Text = "Eliminar";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(67, 25);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // errProv1
            // 
            this.errProv1.ContainerControl = this;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblListaColaboradoresSup);
            this.splitContainer1.Panel1.Controls.Add(this.lblListaColaboradoresALL);
            this.splitContainer1.Panel1.Controls.Add(this.btnQuitarColab);
            this.splitContainer1.Panel1.Controls.Add(this.btnAgregarCol);
            this.splitContainer1.Panel1.Controls.Add(this.lstColaboradoresSup);
            this.splitContainer1.Panel1.Controls.Add(this.lstColaboradoresALL);
            this.splitContainer1.Panel1.Controls.Add(this.btnConfirmar);
            this.splitContainer1.Panel1.Controls.Add(this.mktID);
            this.splitContainer1.Panel1.Controls.Add(this.txtDescripcion);
            this.splitContainer1.Panel1.Controls.Add(this.txtRol);
            this.splitContainer1.Panel1.Controls.Add(this.lblRol);
            this.splitContainer1.Panel1.Controls.Add(this.lblDescripcion);
            this.splitContainer1.Panel1.Controls.Add(this.lblID);
            this.splitContainer1.Panel1.Controls.Add(this.toolStripMantSupervisor);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvSupervisores);
            this.splitContainer1.Size = new System.Drawing.Size(1132, 775);
            this.splitContainer1.SplitterDistance = 367;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 1;
            // 
            // lblListaColaboradoresSup
            // 
            this.lblListaColaboradoresSup.AutoSize = true;
            this.lblListaColaboradoresSup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaColaboradoresSup.Location = new System.Drawing.Point(665, 9);
            this.lblListaColaboradoresSup.Name = "lblListaColaboradoresSup";
            this.lblListaColaboradoresSup.Size = new System.Drawing.Size(285, 21);
            this.lblListaColaboradoresSup.TabIndex = 66;
            this.lblListaColaboradoresSup.Text = "Lista de Colaboradores (Por Supervisor)";
            // 
            // lblListaColaboradoresALL
            // 
            this.lblListaColaboradoresALL.AutoSize = true;
            this.lblListaColaboradoresALL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaColaboradoresALL.Location = new System.Drawing.Point(349, 9);
            this.lblListaColaboradoresALL.Name = "lblListaColaboradoresALL";
            this.lblListaColaboradoresALL.Size = new System.Drawing.Size(215, 21);
            this.lblListaColaboradoresALL.TabIndex = 65;
            this.lblListaColaboradoresALL.Text = "Lista de Colaboradores (Total)";
            // 
            // btnQuitarColab
            // 
            this.btnQuitarColab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarColab.Location = new System.Drawing.Point(579, 130);
            this.btnQuitarColab.Name = "btnQuitarColab";
            this.btnQuitarColab.Size = new System.Drawing.Size(84, 35);
            this.btnQuitarColab.TabIndex = 64;
            this.btnQuitarColab.Text = "Quitar";
            this.btnQuitarColab.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCol
            // 
            this.btnAgregarCol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCol.Location = new System.Drawing.Point(579, 86);
            this.btnAgregarCol.Name = "btnAgregarCol";
            this.btnAgregarCol.Size = new System.Drawing.Size(84, 35);
            this.btnAgregarCol.TabIndex = 63;
            this.btnAgregarCol.Text = "Agregar";
            this.btnAgregarCol.UseVisualStyleBackColor = true;
            this.btnAgregarCol.Click += new System.EventHandler(this.btnAgregarCol_Click);
            // 
            // lstColaboradoresSup
            // 
            this.lstColaboradoresSup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstColaboradoresSup.FormattingEnabled = true;
            this.lstColaboradoresSup.ItemHeight = 21;
            this.lstColaboradoresSup.Location = new System.Drawing.Point(669, 45);
            this.lstColaboradoresSup.Name = "lstColaboradoresSup";
            this.lstColaboradoresSup.Size = new System.Drawing.Size(219, 319);
            this.lstColaboradoresSup.TabIndex = 62;
            // 
            // lstColaboradoresALL
            // 
            this.lstColaboradoresALL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstColaboradoresALL.FormattingEnabled = true;
            this.lstColaboradoresALL.ItemHeight = 21;
            this.lstColaboradoresALL.Location = new System.Drawing.Point(353, 45);
            this.lstColaboradoresALL.Name = "lstColaboradoresALL";
            this.lstColaboradoresALL.Size = new System.Drawing.Size(220, 319);
            this.lstColaboradoresALL.TabIndex = 61;
            // 
            // frmMantenimientoSupervisores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1132, 775);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMantenimientoSupervisores";
            this.Text = "Mantenimiento de Supervisores";
            this.Load += new System.EventHandler(this.frmMantenimientoSupervisores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupervisores)).EndInit();
            this.toolStripMantSupervisor.ResumeLayout(false);
            this.toolStripMantSupervisor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTipSupervisor;
        private System.Windows.Forms.MaskedTextBox mktID;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dgvSupervisores;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStrip toolStripMantSupervisor;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.ErrorProvider errProv1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lstColaboradoresALL;
        private System.Windows.Forms.ListBox lstColaboradoresSup;
        private System.Windows.Forms.Button btnAgregarCol;
        private System.Windows.Forms.Button btnQuitarColab;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Label lblListaColaboradoresSup;
        private System.Windows.Forms.Label lblListaColaboradoresALL;
    }
}