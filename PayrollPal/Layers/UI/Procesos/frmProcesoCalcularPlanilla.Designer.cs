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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoCalcularPlanilla));
            this.btnGenerarColilla = new System.Windows.Forms.Button();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblColaborador = new System.Windows.Forms.Label();
            this.cmbColaborador = new System.Windows.Forms.ComboBox();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.lblHorasOrdvsExt = new System.Windows.Forms.Label();
            this.lblTipoCambio = new System.Windows.Forms.Label();
            this.txtTipoCambio = new System.Windows.Forms.TextBox();
            this.lblPlanillaEnc = new System.Windows.Forms.Label();
            this.cmbPlanillas = new System.Windows.Forms.ComboBox();
            this.lblIDPlanEnc = new System.Windows.Forms.Label();
            this.txtIdEncPlan = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHorOrdvsExt = new System.Windows.Forms.DataGridView();
            this.dgvListaMarcas = new System.Windows.Forms.DataGridView();
            this.idMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasTrabajadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMantEmpresa = new System.Windows.Forms.ToolStrip();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.txtImprimir = new System.Windows.Forms.TextBox();
            this.errProv1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.HorasOrdinarias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasExtraordinarias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTipoCambio2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorOrdvsExt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMarcas)).BeginInit();
            this.toolStripMantEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarColilla
            // 
            this.btnGenerarColilla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarColilla.Location = new System.Drawing.Point(702, 318);
            this.btnGenerarColilla.Name = "btnGenerarColilla";
            this.btnGenerarColilla.Size = new System.Drawing.Size(142, 50);
            this.btnGenerarColilla.TabIndex = 19;
            this.btnGenerarColilla.Text = "Generar Colilla";
            this.btnGenerarColilla.UseVisualStyleBackColor = true;
            this.btnGenerarColilla.Click += new System.EventHandler(this.btnGenerarColilla_Click);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.Location = new System.Drawing.Point(12, 165);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(97, 21);
            this.lblFechaDesde.TabIndex = 22;
            this.lblFechaDesde.Text = "Fecha Desde";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.Location = new System.Drawing.Point(12, 223);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(93, 21);
            this.lblFechaHasta.TabIndex = 25;
            this.lblFechaHasta.Text = "Fecha Hasta";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDesde.Location = new System.Drawing.Point(117, 165);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(219, 29);
            this.dtpFechaDesde.TabIndex = 26;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHasta.Location = new System.Drawing.Point(117, 223);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(219, 29);
            this.dtpFechaHasta.TabIndex = 27;
            // 
            // lblColaborador
            // 
            this.lblColaborador.AutoSize = true;
            this.lblColaborador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColaborador.Location = new System.Drawing.Point(12, 280);
            this.lblColaborador.Name = "lblColaborador";
            this.lblColaborador.Size = new System.Drawing.Size(97, 21);
            this.lblColaborador.TabIndex = 28;
            this.lblColaborador.Text = "Colaborador";
            // 
            // cmbColaborador
            // 
            this.cmbColaborador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColaborador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColaborador.FormattingEnabled = true;
            this.cmbColaborador.Location = new System.Drawing.Point(117, 277);
            this.cmbColaborador.Name = "cmbColaborador";
            this.cmbColaborador.Size = new System.Drawing.Size(219, 29);
            this.cmbColaborador.TabIndex = 29;
            this.cmbColaborador.SelectedIndexChanged += new System.EventHandler(this.cmbColaborador_SelectedIndexChanged);
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.Location = new System.Drawing.Point(12, 336);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(60, 21);
            this.lblMarcas.TabIndex = 33;
            this.lblMarcas.Text = "Marcas";
            // 
            // lblHorasOrdvsExt
            // 
            this.lblHorasOrdvsExt.AutoSize = true;
            this.lblHorasOrdvsExt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasOrdvsExt.Location = new System.Drawing.Point(8, 620);
            this.lblHorasOrdvsExt.Name = "lblHorasOrdvsExt";
            this.lblHorasOrdvsExt.Size = new System.Drawing.Size(239, 21);
            this.lblHorasOrdvsExt.TabIndex = 34;
            this.lblHorasOrdvsExt.Text = "Horas Ordinarias y Extrardinarias";
            // 
            // lblTipoCambio
            // 
            this.lblTipoCambio.AutoSize = true;
            this.lblTipoCambio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCambio.Location = new System.Drawing.Point(465, 7);
            this.lblTipoCambio.Name = "lblTipoCambio";
            this.lblTipoCambio.Size = new System.Drawing.Size(188, 21);
            this.lblTipoCambio.TabIndex = 35;
            this.lblTipoCambio.Text = "Tipo de Cambio del dólar ";
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoCambio.Location = new System.Drawing.Point(668, 30);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.ReadOnly = true;
            this.txtTipoCambio.Size = new System.Drawing.Size(136, 29);
            this.txtTipoCambio.TabIndex = 36;
            // 
            // lblPlanillaEnc
            // 
            this.lblPlanillaEnc.AutoSize = true;
            this.lblPlanillaEnc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanillaEnc.Location = new System.Drawing.Point(12, 103);
            this.lblPlanillaEnc.Name = "lblPlanillaEnc";
            this.lblPlanillaEnc.Size = new System.Drawing.Size(60, 21);
            this.lblPlanillaEnc.TabIndex = 37;
            this.lblPlanillaEnc.Text = "Planilla";
            // 
            // cmbPlanillas
            // 
            this.cmbPlanillas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanillas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlanillas.FormattingEnabled = true;
            this.cmbPlanillas.Location = new System.Drawing.Point(117, 100);
            this.cmbPlanillas.Name = "cmbPlanillas";
            this.cmbPlanillas.Size = new System.Drawing.Size(219, 29);
            this.cmbPlanillas.TabIndex = 38;
            this.cmbPlanillas.SelectedIndexChanged += new System.EventHandler(this.cmbPlanilla_SelectedIndexChanged);
            // 
            // lblIDPlanEnc
            // 
            this.lblIDPlanEnc.AutoSize = true;
            this.lblIDPlanEnc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPlanEnc.Location = new System.Drawing.Point(8, 56);
            this.lblIDPlanEnc.Name = "lblIDPlanEnc";
            this.lblIDPlanEnc.Size = new System.Drawing.Size(146, 21);
            this.lblIDPlanEnc.TabIndex = 39;
            this.lblIDPlanEnc.Text = "Planilla Encabezado";
            // 
            // txtIdEncPlan
            // 
            this.txtIdEncPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEncPlan.Location = new System.Drawing.Point(164, 53);
            this.txtIdEncPlan.Name = "txtIdEncPlan";
            this.txtIdEncPlan.ReadOnly = true;
            this.txtIdEncPlan.Size = new System.Drawing.Size(172, 29);
            this.txtIdEncPlan.TabIndex = 40;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblTipoCambio2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dgvHorOrdvsExt);
            this.splitContainer1.Panel1.Controls.Add(this.dgvListaMarcas);
            this.splitContainer1.Panel1.Controls.Add(this.txtIdEncPlan);
            this.splitContainer1.Panel1.Controls.Add(this.lblIDPlanEnc);
            this.splitContainer1.Panel1.Controls.Add(this.cmbPlanillas);
            this.splitContainer1.Panel1.Controls.Add(this.lblPlanillaEnc);
            this.splitContainer1.Panel1.Controls.Add(this.txtTipoCambio);
            this.splitContainer1.Panel1.Controls.Add(this.lblTipoCambio);
            this.splitContainer1.Panel1.Controls.Add(this.lblHorasOrdvsExt);
            this.splitContainer1.Panel1.Controls.Add(this.lblMarcas);
            this.splitContainer1.Panel1.Controls.Add(this.cmbColaborador);
            this.splitContainer1.Panel1.Controls.Add(this.lblColaborador);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaHasta);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaDesde);
            this.splitContainer1.Panel1.Controls.Add(this.lblFechaHasta);
            this.splitContainer1.Panel1.Controls.Add(this.lblFechaDesde);
            this.splitContainer1.Panel1.Controls.Add(this.btnGenerarColilla);
            this.splitContainer1.Panel1.Controls.Add(this.toolStripMantEmpresa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtImprimir);
            this.splitContainer1.Size = new System.Drawing.Size(1471, 900);
            this.splitContainer1.SplitterDistance = 857;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(664, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Planilla";
            // 
            // dgvHorOrdvsExt
            // 
            this.dgvHorOrdvsExt.AllowUserToAddRows = false;
            this.dgvHorOrdvsExt.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHorOrdvsExt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvHorOrdvsExt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorOrdvsExt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHorOrdvsExt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorOrdvsExt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HorasOrdinarias,
            this.HorasExtraordinarias});
            this.dgvHorOrdvsExt.Location = new System.Drawing.Point(12, 651);
            this.dgvHorOrdvsExt.Margin = new System.Windows.Forms.Padding(1);
            this.dgvHorOrdvsExt.Name = "dgvHorOrdvsExt";
            this.dgvHorOrdvsExt.ReadOnly = true;
            this.dgvHorOrdvsExt.RowHeadersVisible = false;
            this.dgvHorOrdvsExt.RowHeadersWidth = 102;
            this.dgvHorOrdvsExt.RowTemplate.Height = 40;
            this.dgvHorOrdvsExt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorOrdvsExt.Size = new System.Drawing.Size(832, 236);
            this.dgvHorOrdvsExt.TabIndex = 42;
            // 
            // dgvListaMarcas
            // 
            this.dgvListaMarcas.AllowUserToAddRows = false;
            this.dgvListaMarcas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListaMarcas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListaMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaMarcas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMarca,
            this.IdColaborador,
            this.HoraEntrada,
            this.HoraSalida,
            this.Fecha,
            this.HorasTrabajadas});
            this.dgvListaMarcas.Location = new System.Drawing.Point(12, 372);
            this.dgvListaMarcas.Margin = new System.Windows.Forms.Padding(1);
            this.dgvListaMarcas.Name = "dgvListaMarcas";
            this.dgvListaMarcas.ReadOnly = true;
            this.dgvListaMarcas.RowHeadersVisible = false;
            this.dgvListaMarcas.RowHeadersWidth = 102;
            this.dgvListaMarcas.RowTemplate.Height = 40;
            this.dgvListaMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaMarcas.Size = new System.Drawing.Size(832, 236);
            this.dgvListaMarcas.TabIndex = 41;
            // 
            // idMarca
            // 
            this.idMarca.DataPropertyName = "idMarca";
            this.idMarca.HeaderText = "ID";
            this.idMarca.Name = "idMarca";
            this.idMarca.ReadOnly = true;
            // 
            // IdColaborador
            // 
            this.IdColaborador.DataPropertyName = "IdColaborador";
            this.IdColaborador.HeaderText = "Colaborador";
            this.IdColaborador.Name = "IdColaborador";
            this.IdColaborador.ReadOnly = true;
            // 
            // HoraEntrada
            // 
            this.HoraEntrada.DataPropertyName = "HoraEntrada";
            this.HoraEntrada.HeaderText = "Hora de Entrada";
            this.HoraEntrada.Name = "HoraEntrada";
            this.HoraEntrada.ReadOnly = true;
            // 
            // HoraSalida
            // 
            this.HoraSalida.DataPropertyName = "HoraSalida";
            this.HoraSalida.HeaderText = "Hora de Salida";
            this.HoraSalida.Name = "HoraSalida";
            this.HoraSalida.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // HorasTrabajadas
            // 
            this.HorasTrabajadas.DataPropertyName = "HorasTrabajadas";
            this.HorasTrabajadas.HeaderText = "Horas Trabajadas";
            this.HorasTrabajadas.Name = "HorasTrabajadas";
            this.HorasTrabajadas.ReadOnly = true;
            // 
            // toolStripMantEmpresa
            // 
            this.toolStripMantEmpresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMantEmpresa.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStripMantEmpresa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLimpiar,
            this.btnSalir});
            this.toolStripMantEmpresa.Location = new System.Drawing.Point(0, 0);
            this.toolStripMantEmpresa.Name = "toolStripMantEmpresa";
            this.toolStripMantEmpresa.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMantEmpresa.Size = new System.Drawing.Size(857, 28);
            this.toolStripMantEmpresa.TabIndex = 18;
            this.toolStripMantEmpresa.Text = "toolStrip1";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(45, 25);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtImprimir
            // 
            this.txtImprimir.Location = new System.Drawing.Point(-1, 3);
            this.txtImprimir.Multiline = true;
            this.txtImprimir.Name = "txtImprimir";
            this.txtImprimir.Size = new System.Drawing.Size(611, 935);
            this.txtImprimir.TabIndex = 0;
            // 
            // errProv1
            // 
            this.errProv1.ContainerControl = this;
            // 
            // HorasOrdinarias
            // 
            this.HorasOrdinarias.DataPropertyName = "devolverHorasTrabajadas";
            this.HorasOrdinarias.HeaderText = "Horas Ordinarias";
            this.HorasOrdinarias.Name = "HorasOrdinarias";
            this.HorasOrdinarias.ReadOnly = true;
            // 
            // HorasExtraordinarias
            // 
            this.HorasExtraordinarias.DataPropertyName = "devolverHorasExtras";
            this.HorasExtraordinarias.HeaderText = "Horas Extraordinarias";
            this.HorasExtraordinarias.Name = "HorasExtraordinarias";
            this.HorasExtraordinarias.ReadOnly = true;
            // 
            // lblTipoCambio2
            // 
            this.lblTipoCambio2.AutoSize = true;
            this.lblTipoCambio2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCambio2.Location = new System.Drawing.Point(504, 33);
            this.lblTipoCambio2.Name = "lblTipoCambio2";
            this.lblTipoCambio2.Size = new System.Drawing.Size(164, 21);
            this.lblTipoCambio2.TabIndex = 44;
            this.lblTipoCambio2.Text = "para hoy (venta)        ₡";
            // 
            // frmProcesoCalcularPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 900);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmProcesoCalcularPlanilla";
            this.Text = "Cálculo de Planilla";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProcesoCalcularPlanilla_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorOrdvsExt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMarcas)).EndInit();
            this.toolStripMantEmpresa.ResumeLayout(false);
            this.toolStripMantEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarColilla;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblColaborador;
        private System.Windows.Forms.ComboBox cmbColaborador;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.Label lblHorasOrdvsExt;
        private System.Windows.Forms.Label lblTipoCambio;
        private System.Windows.Forms.TextBox txtTipoCambio;
        private System.Windows.Forms.Label lblPlanillaEnc;
        private System.Windows.Forms.ComboBox cmbPlanillas;
        private System.Windows.Forms.Label lblIDPlanEnc;
        private System.Windows.Forms.TextBox txtIdEncPlan;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStripMantEmpresa;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.DataGridView dgvListaMarcas;
        private System.Windows.Forms.DataGridView dgvHorOrdvsExt;
        private System.Windows.Forms.ErrorProvider errProv1;
        private System.Windows.Forms.TextBox txtImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasTrabajadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasOrdinarias;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasExtraordinarias;
        private System.Windows.Forms.Label lblTipoCambio2;
    }
}