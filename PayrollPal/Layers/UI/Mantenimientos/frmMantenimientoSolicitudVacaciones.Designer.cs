﻿namespace PayrollPal.UI.Mantenimientos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoSolicitudVacaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rdbInactiva = new System.Windows.Forms.RadioButton();
            this.rdbActiva = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dtpFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.lblFechaSolicitud = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtCantDias = new System.Windows.Forms.TextBox();
            this.cmbObservacionesFinales = new System.Windows.Forms.ComboBox();
            this.lblObservacionesFinales = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblCantDias = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.cmbColaborador = new System.Windows.Forms.ComboBox();
            this.lblColaborador = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.toolStripMantSolicitudVacaciones = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.dgvSolicitud = new System.Windows.Forms.DataGridView();
            this.IDSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSolicitarDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSolicitarHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones_Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSolicitudesVacaciones = new System.Windows.Forms.DataGridView();
            this.errProv1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripMantSolicitudVacaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesVacaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProv1)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.txtID);
            this.splitContainer1.Panel1.Controls.Add(this.rdbInactiva);
            this.splitContainer1.Panel1.Controls.Add(this.rdbActiva);
            this.splitContainer1.Panel1.Controls.Add(this.lblEstado);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaSolicitud);
            this.splitContainer1.Panel1.Controls.Add(this.lblFechaSolicitud);
            this.splitContainer1.Panel1.Controls.Add(this.btnConfirmar);
            this.splitContainer1.Panel1.Controls.Add(this.txtCantDias);
            this.splitContainer1.Panel1.Controls.Add(this.cmbObservacionesFinales);
            this.splitContainer1.Panel1.Controls.Add(this.lblObservacionesFinales);
            this.splitContainer1.Panel1.Controls.Add(this.txtObservaciones);
            this.splitContainer1.Panel1.Controls.Add(this.lblObservaciones);
            this.splitContainer1.Panel1.Controls.Add(this.lblCantDias);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaHasta);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaDesde);
            this.splitContainer1.Panel1.Controls.Add(this.lblFechaHasta);
            this.splitContainer1.Panel1.Controls.Add(this.lblFechaDesde);
            this.splitContainer1.Panel1.Controls.Add(this.cmbColaborador);
            this.splitContainer1.Panel1.Controls.Add(this.lblColaborador);
            this.splitContainer1.Panel1.Controls.Add(this.lblID);
            this.splitContainer1.Panel1.Controls.Add(this.toolStripMantSolicitudVacaciones);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvSolicitud);
            this.splitContainer1.Panel2.Controls.Add(this.dgvSolicitudesVacaciones);
            this.splitContainer1.Size = new System.Drawing.Size(1212, 769);
            this.splitContainer1.SplitterDistance = 453;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // rdbInactiva
            // 
            this.rdbInactiva.AutoSize = true;
            this.rdbInactiva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInactiva.Location = new System.Drawing.Point(743, 91);
            this.rdbInactiva.Name = "rdbInactiva";
            this.rdbInactiva.Size = new System.Drawing.Size(81, 25);
            this.rdbInactiva.TabIndex = 75;
            this.rdbInactiva.TabStop = true;
            this.rdbInactiva.Text = "Inactiva";
            this.rdbInactiva.UseVisualStyleBackColor = true;
            // 
            // rdbActiva
            // 
            this.rdbActiva.AutoSize = true;
            this.rdbActiva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActiva.Location = new System.Drawing.Point(743, 49);
            this.rdbActiva.Name = "rdbActiva";
            this.rdbActiva.Size = new System.Drawing.Size(70, 25);
            this.rdbActiva.TabIndex = 74;
            this.rdbActiva.TabStop = true;
            this.rdbActiva.Text = "Activa";
            this.rdbActiva.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(590, 51);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 21);
            this.lblEstado.TabIndex = 73;
            this.lblEstado.Text = "Estado";
            // 
            // dtpFechaSolicitud
            // 
            this.dtpFechaSolicitud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaSolicitud.Location = new System.Drawing.Point(136, 123);
            this.dtpFechaSolicitud.Margin = new System.Windows.Forms.Padding(1);
            this.dtpFechaSolicitud.Name = "dtpFechaSolicitud";
            this.dtpFechaSolicitud.Size = new System.Drawing.Size(288, 29);
            this.dtpFechaSolicitud.TabIndex = 68;
            // 
            // lblFechaSolicitud
            // 
            this.lblFechaSolicitud.AutoSize = true;
            this.lblFechaSolicitud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaSolicitud.Location = new System.Drawing.Point(8, 123);
            this.lblFechaSolicitud.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFechaSolicitud.Name = "lblFechaSolicitud";
            this.lblFechaSolicitud.Size = new System.Drawing.Size(114, 21);
            this.lblFechaSolicitud.TabIndex = 67;
            this.lblFechaSolicitud.Text = "Fecha Solicitud";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(1100, 399);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 35);
            this.btnConfirmar.TabIndex = 66;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtCantDias
            // 
            this.txtCantDias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantDias.Location = new System.Drawing.Point(136, 249);
            this.txtCantDias.Margin = new System.Windows.Forms.Padding(1);
            this.txtCantDias.Name = "txtCantDias";
            this.txtCantDias.ReadOnly = true;
            this.txtCantDias.Size = new System.Drawing.Size(150, 29);
            this.txtCantDias.TabIndex = 65;
            // 
            // cmbObservacionesFinales
            // 
            this.cmbObservacionesFinales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObservacionesFinales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbObservacionesFinales.FormattingEnabled = true;
            this.cmbObservacionesFinales.Location = new System.Drawing.Point(136, 398);
            this.cmbObservacionesFinales.Margin = new System.Windows.Forms.Padding(1);
            this.cmbObservacionesFinales.Name = "cmbObservacionesFinales";
            this.cmbObservacionesFinales.Size = new System.Drawing.Size(127, 29);
            this.cmbObservacionesFinales.TabIndex = 63;
            // 
            // lblObservacionesFinales
            // 
            this.lblObservacionesFinales.AutoSize = true;
            this.lblObservacionesFinales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacionesFinales.Location = new System.Drawing.Point(8, 399);
            this.lblObservacionesFinales.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblObservacionesFinales.Name = "lblObservacionesFinales";
            this.lblObservacionesFinales.Size = new System.Drawing.Size(90, 21);
            this.lblObservacionesFinales.TabIndex = 62;
            this.lblObservacionesFinales.Text = "Estado final";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(136, 291);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(1);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(342, 92);
            this.txtObservaciones.TabIndex = 61;
            this.txtObservaciones.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtObservaciones_KeyUp);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(8, 291);
            this.lblObservaciones.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(112, 21);
            this.lblObservaciones.TabIndex = 60;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // lblCantDias
            // 
            this.lblCantDias.AutoSize = true;
            this.lblCantDias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantDias.Location = new System.Drawing.Point(7, 252);
            this.lblCantDias.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCantDias.Name = "lblCantDias";
            this.lblCantDias.Size = new System.Drawing.Size(127, 21);
            this.lblCantDias.TabIndex = 58;
            this.lblCantDias.Text = "Cantidad de Días";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHasta.Location = new System.Drawing.Point(136, 199);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(1);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(288, 29);
            this.dtpFechaHasta.TabIndex = 57;
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDesde.Location = new System.Drawing.Point(136, 158);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(1);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(288, 29);
            this.dtpFechaDesde.TabIndex = 56;
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.Location = new System.Drawing.Point(8, 201);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(93, 21);
            this.lblFechaHasta.TabIndex = 55;
            this.lblFechaHasta.Text = "Fecha Hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.Location = new System.Drawing.Point(8, 158);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(97, 21);
            this.lblFechaDesde.TabIndex = 54;
            this.lblFechaDesde.Text = "Fecha Desde";
            // 
            // cmbColaborador
            // 
            this.cmbColaborador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColaborador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColaborador.FormattingEnabled = true;
            this.cmbColaborador.Location = new System.Drawing.Point(136, 86);
            this.cmbColaborador.Margin = new System.Windows.Forms.Padding(1);
            this.cmbColaborador.Name = "cmbColaborador";
            this.cmbColaborador.Size = new System.Drawing.Size(288, 29);
            this.cmbColaborador.TabIndex = 43;
            // 
            // lblColaborador
            // 
            this.lblColaborador.AutoSize = true;
            this.lblColaborador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColaborador.Location = new System.Drawing.Point(8, 86);
            this.lblColaborador.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblColaborador.Name = "lblColaborador";
            this.lblColaborador.Size = new System.Drawing.Size(97, 21);
            this.lblColaborador.TabIndex = 37;
            this.lblColaborador.Text = "Colaborador";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(8, 45);
            this.lblID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 21);
            this.lblID.TabIndex = 36;
            this.lblID.Text = "ID";
            // 
            // toolStripMantSolicitudVacaciones
            // 
            this.toolStripMantSolicitudVacaciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMantSolicitudVacaciones.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStripMantSolicitudVacaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEditar,
            this.btnEliminar,
            this.btnLimpiar,
            this.btnSalir});
            this.toolStripMantSolicitudVacaciones.Location = new System.Drawing.Point(0, 0);
            this.toolStripMantSolicitudVacaciones.Name = "toolStripMantSolicitudVacaciones";
            this.toolStripMantSolicitudVacaciones.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMantSolicitudVacaciones.Size = new System.Drawing.Size(1212, 28);
            this.toolStripMantSolicitudVacaciones.TabIndex = 35;
            this.toolStripMantSolicitudVacaciones.Text = "toolStrip1";
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
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(71, 25);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            // dgvSolicitud
            // 
            this.dgvSolicitud.AllowUserToAddRows = false;
            this.dgvSolicitud.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSolicitud.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSolicitud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSolicitud.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitud.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSolicitud,
            this.IDColaborador,
            this.FechaSolicitud,
            this.FechaSolicitarDesde,
            this.FechaSolicitarHasta,
            this.CantidadDias,
            this.Observaciones,
            this.Estado,
            this.Observaciones_Final});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSolicitud.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSolicitud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSolicitud.Location = new System.Drawing.Point(0, 0);
            this.dgvSolicitud.Margin = new System.Windows.Forms.Padding(1);
            this.dgvSolicitud.Name = "dgvSolicitud";
            this.dgvSolicitud.ReadOnly = true;
            this.dgvSolicitud.RowHeadersVisible = false;
            this.dgvSolicitud.RowHeadersWidth = 102;
            this.dgvSolicitud.RowTemplate.Height = 40;
            this.dgvSolicitud.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitud.Size = new System.Drawing.Size(1212, 314);
            this.dgvSolicitud.TabIndex = 5;
            this.dgvSolicitud.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitud_CellContentDoubleClick);
            this.dgvSolicitud.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSolicitud_CellFormatting);
            // 
            // IDSolicitud
            // 
            this.IDSolicitud.DataPropertyName = "IDSolicitudVacas";
            this.IDSolicitud.HeaderText = "ID";
            this.IDSolicitud.Name = "IDSolicitud";
            this.IDSolicitud.ReadOnly = true;
            // 
            // IDColaborador
            // 
            this.IDColaborador.DataPropertyName = "IDColaborador";
            this.IDColaborador.HeaderText = "Colaborador";
            this.IDColaborador.Name = "IDColaborador";
            this.IDColaborador.ReadOnly = true;
            // 
            // FechaSolicitud
            // 
            this.FechaSolicitud.DataPropertyName = "FechaSolicitud";
            this.FechaSolicitud.HeaderText = "Fecha de Solicitud";
            this.FechaSolicitud.Name = "FechaSolicitud";
            this.FechaSolicitud.ReadOnly = true;
            // 
            // FechaSolicitarDesde
            // 
            this.FechaSolicitarDesde.DataPropertyName = "FechaSolicitarDesde";
            this.FechaSolicitarDesde.HeaderText = "Desde";
            this.FechaSolicitarDesde.Name = "FechaSolicitarDesde";
            this.FechaSolicitarDesde.ReadOnly = true;
            // 
            // FechaSolicitarHasta
            // 
            this.FechaSolicitarHasta.DataPropertyName = "FechaSolicitarHasta";
            this.FechaSolicitarHasta.HeaderText = "Hasta";
            this.FechaSolicitarHasta.Name = "FechaSolicitarHasta";
            this.FechaSolicitarHasta.ReadOnly = true;
            // 
            // CantidadDias
            // 
            this.CantidadDias.DataPropertyName = "CantidadDias";
            this.CantidadDias.HeaderText = "Cantidad de Días";
            this.CantidadDias.Name = "CantidadDias";
            this.CantidadDias.ReadOnly = true;
            // 
            // Observaciones
            // 
            this.Observaciones.DataPropertyName = "Observaciones";
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Observaciones_Final
            // 
            this.Observaciones_Final.DataPropertyName = "Observaciones_Final";
            this.Observaciones_Final.HeaderText = "Observación Final";
            this.Observaciones_Final.Name = "Observaciones_Final";
            this.Observaciones_Final.ReadOnly = true;
            // 
            // dgvSolicitudesVacaciones
            // 
            this.dgvSolicitudesVacaciones.AllowUserToAddRows = false;
            this.dgvSolicitudesVacaciones.AllowUserToDeleteRows = false;
            this.dgvSolicitudesVacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudesVacaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSolicitudesVacaciones.Location = new System.Drawing.Point(0, 0);
            this.dgvSolicitudesVacaciones.Margin = new System.Windows.Forms.Padding(1);
            this.dgvSolicitudesVacaciones.Name = "dgvSolicitudesVacaciones";
            this.dgvSolicitudesVacaciones.ReadOnly = true;
            this.dgvSolicitudesVacaciones.RowHeadersWidth = 102;
            this.dgvSolicitudesVacaciones.RowTemplate.Height = 40;
            this.dgvSolicitudesVacaciones.Size = new System.Drawing.Size(1212, 314);
            this.dgvSolicitudesVacaciones.TabIndex = 4;
            // 
            // errProv1
            // 
            this.errProv1.ContainerControl = this;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(136, 45);
            this.txtID.Margin = new System.Windows.Forms.Padding(1);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(134, 29);
            this.txtID.TabIndex = 76;
            this.txtID.Text = "sol";
            // 
            // frmMantenimientoSolicitudVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 769);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmMantenimientoSolicitudVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Solicitud de Vacaciones";
            this.Load += new System.EventHandler(this.frmMantenimientoSolicitudVacaciones_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStripMantSolicitudVacaciones.ResumeLayout(false);
            this.toolStripMantSolicitudVacaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesVacaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvSolicitudesVacaciones;
        private System.Windows.Forms.ComboBox cmbColaborador;
        private System.Windows.Forms.Label lblColaborador;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ToolStrip toolStripMantSolicitudVacaciones;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Label lblCantDias;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblObservacionesFinales;
        private System.Windows.Forms.ComboBox cmbObservacionesFinales;
        private System.Windows.Forms.TextBox txtCantDias;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView dgvSolicitud;
        private System.Windows.Forms.DateTimePicker dtpFechaSolicitud;
        private System.Windows.Forms.Label lblFechaSolicitud;
        private System.Windows.Forms.ErrorProvider errProv1;
        private System.Windows.Forms.RadioButton rdbInactiva;
        private System.Windows.Forms.RadioButton rdbActiva;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSolicitarDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSolicitarHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones_Final;
        private System.Windows.Forms.TextBox txtID;
    }
}