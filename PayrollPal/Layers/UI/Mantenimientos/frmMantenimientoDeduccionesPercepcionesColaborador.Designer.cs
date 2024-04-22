namespace PayrollPal.Layers.UI.Mantenimientos
{
    partial class frmMantenimientoDeduccionesPercepcionesColaborador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoDeduccionesPercepcionesColaborador));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblListaColaboradoresALL = new System.Windows.Forms.Label();
            this.btnQuitarColab = new System.Windows.Forms.Button();
            this.btnAgregarCol = new System.Windows.Forms.Button();
            this.lstDedPercPorColab = new System.Windows.Forms.ListBox();
            this.lstColaboradoresALL = new System.Windows.Forms.ListBox();
            this.lblListaDedPercAsignadas = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.lblCodDedPerc = new System.Windows.Forms.Label();
            this.toolStripMantDedPercColab = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.errProv1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvDedPercColab = new System.Windows.Forms.DataGridView();
            this.CodigoDeduccionPercepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rdbInactiva = new System.Windows.Forms.RadioButton();
            this.rdbActiva = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbDedPercCol = new System.Windows.Forms.ComboBox();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslblUsuarioConectado = new System.Windows.Forms.ToolStripLabel();
            this.toolTipPercDedColaborador = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripMantDedPercColab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDedPercColab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListaColaboradoresALL
            // 
            this.lblListaColaboradoresALL.AutoSize = true;
            this.lblListaColaboradoresALL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaColaboradoresALL.Location = new System.Drawing.Point(1136, 75);
            this.lblListaColaboradoresALL.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblListaColaboradoresALL.Name = "lblListaColaboradoresALL";
            this.lblListaColaboradoresALL.Size = new System.Drawing.Size(901, 54);
            this.lblListaColaboradoresALL.TabIndex = 65;
            this.lblListaColaboradoresALL.Text = "Lista de Colaboradores Sin Deducción/Percepción";
            // 
            // btnQuitarColab
            // 
            this.btnQuitarColab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarColab.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarColab.Image")));
            this.btnQuitarColab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitarColab.Location = new System.Drawing.Point(1919, 469);
            this.btnQuitarColab.Margin = new System.Windows.Forms.Padding(8);
            this.btnQuitarColab.Name = "btnQuitarColab";
            this.btnQuitarColab.Size = new System.Drawing.Size(304, 121);
            this.btnQuitarColab.TabIndex = 64;
            this.btnQuitarColab.Text = "Quitar";
            this.btnQuitarColab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitarColab.UseVisualStyleBackColor = true;
            this.btnQuitarColab.Click += new System.EventHandler(this.btnQuitarColab_Click);
            // 
            // btnAgregarCol
            // 
            this.btnAgregarCol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCol.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCol.Image")));
            this.btnAgregarCol.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCol.Location = new System.Drawing.Point(1919, 273);
            this.btnAgregarCol.Margin = new System.Windows.Forms.Padding(8);
            this.btnAgregarCol.Name = "btnAgregarCol";
            this.btnAgregarCol.Size = new System.Drawing.Size(304, 123);
            this.btnAgregarCol.TabIndex = 63;
            this.btnAgregarCol.Text = "Agregar";
            this.btnAgregarCol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCol.UseVisualStyleBackColor = true;
            this.btnAgregarCol.Click += new System.EventHandler(this.btnAgregarCol_Click);
            // 
            // lstDedPercPorColab
            // 
            this.lstDedPercPorColab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDedPercPorColab.FormattingEnabled = true;
            this.lstDedPercPorColab.ItemHeight = 54;
            this.lstDedPercPorColab.Location = new System.Drawing.Point(2239, 165);
            this.lstDedPercPorColab.Margin = new System.Windows.Forms.Padding(8);
            this.lstDedPercPorColab.Name = "lstDedPercPorColab";
            this.lstDedPercPorColab.Size = new System.Drawing.Size(686, 760);
            this.lstDedPercPorColab.TabIndex = 62;
            this.lstDedPercPorColab.SelectedValueChanged += new System.EventHandler(this.lstDedPercPorColab_SelectedValueChanged);
            // 
            // lstColaboradoresALL
            // 
            this.lstColaboradoresALL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstColaboradoresALL.FormattingEnabled = true;
            this.lstColaboradoresALL.ItemHeight = 54;
            this.lstColaboradoresALL.Location = new System.Drawing.Point(1209, 165);
            this.lstColaboradoresALL.Margin = new System.Windows.Forms.Padding(8);
            this.lstColaboradoresALL.Name = "lstColaboradoresALL";
            this.lstColaboradoresALL.Size = new System.Drawing.Size(694, 760);
            this.lstColaboradoresALL.TabIndex = 61;
            this.lstColaboradoresALL.SelectedValueChanged += new System.EventHandler(this.lstColaboradoresALL_SelectedValueChanged);
            // 
            // lblListaDedPercAsignadas
            // 
            this.lblListaDedPercAsignadas.AutoSize = true;
            this.lblListaDedPercAsignadas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDedPercAsignadas.Location = new System.Drawing.Point(2083, 79);
            this.lblListaDedPercAsignadas.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblListaDedPercAsignadas.Name = "lblListaDedPercAsignadas";
            this.lblListaDedPercAsignadas.Size = new System.Drawing.Size(865, 54);
            this.lblListaDedPercAsignadas.TabIndex = 66;
            this.lblListaDedPercAsignadas.Text = "Colaboradores a Asignar Deducción/Percepción";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(35, 822);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(8);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(250, 88);
            this.btnConfirmar.TabIndex = 60;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridad.Location = new System.Drawing.Point(25, 325);
            this.lblPrioridad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(184, 54);
            this.lblPrioridad.TabIndex = 45;
            this.lblPrioridad.Text = "Prioridad";
            // 
            // lblCodDedPerc
            // 
            this.lblCodDedPerc.AutoSize = true;
            this.lblCodDedPerc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodDedPerc.Location = new System.Drawing.Point(25, 120);
            this.lblCodDedPerc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodDedPerc.Name = "lblCodDedPerc";
            this.lblCodDedPerc.Size = new System.Drawing.Size(442, 54);
            this.lblCodDedPerc.TabIndex = 44;
            this.lblCodDedPerc.Text = "Deducción / Percepción";
            // 
            // toolStripMantDedPercColab
            // 
            this.toolStripMantDedPercColab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMantDedPercColab.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStripMantDedPercColab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEditar,
            this.btnEliminar,
            this.btnLimpiar,
            this.btnSalir});
            this.toolStripMantDedPercColab.Location = new System.Drawing.Point(0, 0);
            this.toolStripMantDedPercColab.Name = "toolStripMantDedPercColab";
            this.toolStripMantDedPercColab.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMantDedPercColab.Size = new System.Drawing.Size(2982, 65);
            this.toolStripMantDedPercColab.TabIndex = 43;
            this.toolStripMantDedPercColab.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(170, 58);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(129, 58);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(168, 58);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(158, 58);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 58);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errProv1
            // 
            this.errProv1.ContainerControl = this;
            // 
            // dgvDedPercColab
            // 
            this.dgvDedPercColab.AllowUserToAddRows = false;
            this.dgvDedPercColab.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDedPercColab.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDedPercColab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDedPercColab.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDedPercColab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDedPercColab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDedPercColab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDeduccionPercepcion,
            this.IdColaborador,
            this.Prioridad,
            this.Estado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDedPercColab.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDedPercColab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDedPercColab.Location = new System.Drawing.Point(0, 0);
            this.dgvDedPercColab.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDedPercColab.Name = "dgvDedPercColab";
            this.dgvDedPercColab.ReadOnly = true;
            this.dgvDedPercColab.RowHeadersVisible = false;
            this.dgvDedPercColab.RowHeadersWidth = 102;
            this.dgvDedPercColab.RowTemplate.Height = 40;
            this.dgvDedPercColab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDedPercColab.Size = new System.Drawing.Size(2982, 1055);
            this.dgvDedPercColab.TabIndex = 4;
            this.dgvDedPercColab.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDedPercColab_CellContentDoubleClick);
            this.dgvDedPercColab.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDedPercColab_CellFormatting);
            // 
            // CodigoDeduccionPercepcion
            // 
            this.CodigoDeduccionPercepcion.DataPropertyName = "CodigoDeduccionPercepcion";
            this.CodigoDeduccionPercepcion.HeaderText = "Deducción Percepción";
            this.CodigoDeduccionPercepcion.MinimumWidth = 12;
            this.CodigoDeduccionPercepcion.Name = "CodigoDeduccionPercepcion";
            this.CodigoDeduccionPercepcion.ReadOnly = true;
            // 
            // IdColaborador
            // 
            this.IdColaborador.DataPropertyName = "IdColaborador";
            this.IdColaborador.HeaderText = "IdColaborador";
            this.IdColaborador.MinimumWidth = 12;
            this.IdColaborador.Name = "IdColaborador";
            this.IdColaborador.ReadOnly = true;
            // 
            // Prioridad
            // 
            this.Prioridad.DataPropertyName = "Prioridad";
            this.Prioridad.HeaderText = "Prioridad";
            this.Prioridad.MinimumWidth = 12;
            this.Prioridad.Name = "Prioridad";
            this.Prioridad.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 12;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightBlue;
            this.splitContainer1.Panel1.Controls.Add(this.rdbInactiva);
            this.splitContainer1.Panel1.Controls.Add(this.rdbActiva);
            this.splitContainer1.Panel1.Controls.Add(this.lblEstado);
            this.splitContainer1.Panel1.Controls.Add(this.cmbDedPercCol);
            this.splitContainer1.Panel1.Controls.Add(this.cmbPrioridad);
            this.splitContainer1.Panel1.Controls.Add(this.lblListaDedPercAsignadas);
            this.splitContainer1.Panel1.Controls.Add(this.lblListaColaboradoresALL);
            this.splitContainer1.Panel1.Controls.Add(this.btnQuitarColab);
            this.splitContainer1.Panel1.Controls.Add(this.btnAgregarCol);
            this.splitContainer1.Panel1.Controls.Add(this.lstDedPercPorColab);
            this.splitContainer1.Panel1.Controls.Add(this.lstColaboradoresALL);
            this.splitContainer1.Panel1.Controls.Add(this.btnConfirmar);
            this.splitContainer1.Panel1.Controls.Add(this.lblPrioridad);
            this.splitContainer1.Panel1.Controls.Add(this.lblCodDedPerc);
            this.splitContainer1.Panel1.Controls.Add(this.toolStripMantDedPercColab);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.dgvDedPercColab);
            this.splitContainer1.Size = new System.Drawing.Size(2982, 2010);
            this.splitContainer1.SplitterDistance = 950;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // rdbInactiva
            // 
            this.rdbInactiva.AutoSize = true;
            this.rdbInactiva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInactiva.Location = new System.Drawing.Point(412, 658);
            this.rdbInactiva.Margin = new System.Windows.Forms.Padding(8);
            this.rdbInactiva.Name = "rdbInactiva";
            this.rdbInactiva.Size = new System.Drawing.Size(195, 58);
            this.rdbInactiva.TabIndex = 72;
            this.rdbInactiva.TabStop = true;
            this.rdbInactiva.Text = "Inactiva";
            this.rdbInactiva.UseVisualStyleBackColor = true;
            // 
            // rdbActiva
            // 
            this.rdbActiva.AutoSize = true;
            this.rdbActiva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActiva.Location = new System.Drawing.Point(412, 552);
            this.rdbActiva.Margin = new System.Windows.Forms.Padding(8);
            this.rdbActiva.Name = "rdbActiva";
            this.rdbActiva.Size = new System.Drawing.Size(167, 58);
            this.rdbActiva.TabIndex = 71;
            this.rdbActiva.TabStop = true;
            this.rdbActiva.Text = "Activa";
            this.rdbActiva.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(30, 558);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(141, 54);
            this.lblEstado.TabIndex = 70;
            this.lblEstado.Text = "Estado";
            // 
            // cmbDedPercCol
            // 
            this.cmbDedPercCol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDedPercCol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDedPercCol.FormattingEnabled = true;
            this.cmbDedPercCol.Location = new System.Drawing.Point(465, 128);
            this.cmbDedPercCol.Margin = new System.Windows.Forms.Padding(8);
            this.cmbDedPercCol.Name = "cmbDedPercCol";
            this.cmbDedPercCol.Size = new System.Drawing.Size(659, 53);
            this.cmbDedPercCol.TabIndex = 69;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(412, 318);
            this.cmbPrioridad.Margin = new System.Windows.Forms.Padding(8);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(432, 62);
            this.cmbPrioridad.TabIndex = 68;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblUsuarioConectado});
            this.toolStrip1.Location = new System.Drawing.Point(0, 994);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(2982, 61);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslblUsuarioConectado
            // 
            this.tslblUsuarioConectado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslblUsuarioConectado.Name = "tslblUsuarioConectado";
            this.tslblUsuarioConectado.Size = new System.Drawing.Size(291, 54);
            this.tslblUsuarioConectado.Text = "toolStripLabel1";
            // 
            // frmMantenimientoDeduccionesPercepcionesColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2982, 2010);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "frmMantenimientoDeduccionesPercepcionesColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Deducciones y Percepciones por Colaborador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMantenimientoDeduccionesPercepcionesColaborador_Load);
            this.toolStripMantDedPercColab.ResumeLayout(false);
            this.toolStripMantDedPercColab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDedPercColab)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblListaColaboradoresALL;
        private System.Windows.Forms.Button btnQuitarColab;
        private System.Windows.Forms.Button btnAgregarCol;
        private System.Windows.Forms.ListBox lstDedPercPorColab;
        private System.Windows.Forms.ListBox lstColaboradoresALL;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.Label lblListaDedPercAsignadas;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ToolTip toolTipPercDedColaborador;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.Label lblCodDedPerc;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.ToolStrip toolStripMantDedPercColab;
        private System.Windows.Forms.ErrorProvider errProv1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvDedPercColab;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ComboBox cmbDedPercCol;
        private System.Windows.Forms.RadioButton rdbInactiva;
        private System.Windows.Forms.RadioButton rdbActiva;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDeduccionPercepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslblUsuarioConectado;
    }
}