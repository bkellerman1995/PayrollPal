namespace PayrollPal.UI.Mantenimientos
{
    partial class frmMantenimientoEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoEmpresa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mktTelefono = new System.Windows.Forms.MaskedTextBox();
            this.mktID = new System.Windows.Forms.MaskedTextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCargarLogo = new System.Windows.Forms.Button();
            this.cmbTipoID = new System.Windows.Forms.ComboBox();
            this.rdbInactiva = new System.Windows.Forms.RadioButton();
            this.rdbActiva = new System.Windows.Forms.RadioButton();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipoIdentificacion = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.toolStripMantEmpresa = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslblUsuarioConectado = new System.Windows.Forms.ToolStripLabel();
            this.errProv1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.toolStripMantEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mktTelefono);
            this.splitContainer1.Panel1.Controls.Add(this.mktID);
            this.splitContainer1.Panel1.Controls.Add(this.btnConfirmar);
            this.splitContainer1.Panel1.Controls.Add(this.btnCargarLogo);
            this.splitContainer1.Panel1.Controls.Add(this.cmbTipoID);
            this.splitContainer1.Panel1.Controls.Add(this.rdbInactiva);
            this.splitContainer1.Panel1.Controls.Add(this.rdbActiva);
            this.splitContainer1.Panel1.Controls.Add(this.txtDireccion);
            this.splitContainer1.Panel1.Controls.Add(this.txtNombre);
            this.splitContainer1.Panel1.Controls.Add(this.lblLogo);
            this.splitContainer1.Panel1.Controls.Add(this.pctLogo);
            this.splitContainer1.Panel1.Controls.Add(this.lblEstado);
            this.splitContainer1.Panel1.Controls.Add(this.lblDireccion);
            this.splitContainer1.Panel1.Controls.Add(this.lblTelefono);
            this.splitContainer1.Panel1.Controls.Add(this.lblNombre);
            this.splitContainer1.Panel1.Controls.Add(this.lblTipoIdentificacion);
            this.splitContainer1.Panel1.Controls.Add(this.lblIdentificacion);
            this.splitContainer1.Panel1.Controls.Add(this.toolStripMantEmpresa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvEmpresa);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(847, 667);
            this.splitContainer1.SplitterDistance = 301;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // mktTelefono
            // 
            this.mktTelefono.Location = new System.Drawing.Point(149, 149);
            this.mktTelefono.Mask = "0000-0000";
            this.mktTelefono.Name = "mktTelefono";
            this.mktTelefono.Size = new System.Drawing.Size(159, 29);
            this.mktTelefono.TabIndex = 66;
            this.mktTelefono.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mktTelefono_KeyUp);
            // 
            // mktID
            // 
            this.mktID.Location = new System.Drawing.Point(171, 76);
            this.mktID.Mask = "0-0000-0000";
            this.mktID.Name = "mktID";
            this.mktID.Size = new System.Drawing.Size(159, 29);
            this.mktID.TabIndex = 65;
            this.mktID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mktID_KeyUp);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(15, 246);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 35);
            this.btnConfirmar.TabIndex = 63;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCargarLogo
            // 
            this.btnCargarLogo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarLogo.Location = new System.Drawing.Point(746, 7);
            this.btnCargarLogo.Name = "btnCargarLogo";
            this.btnCargarLogo.Size = new System.Drawing.Size(79, 26);
            this.btnCargarLogo.TabIndex = 61;
            this.btnCargarLogo.Text = "Cargar";
            this.btnCargarLogo.UseVisualStyleBackColor = true;
            this.btnCargarLogo.Click += new System.EventHandler(this.btnCargarLogo_Click);
            // 
            // cmbTipoID
            // 
            this.cmbTipoID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoID.FormattingEnabled = true;
            this.cmbTipoID.Location = new System.Drawing.Point(182, 40);
            this.cmbTipoID.Margin = new System.Windows.Forms.Padding(1);
            this.cmbTipoID.Name = "cmbTipoID";
            this.cmbTipoID.Size = new System.Drawing.Size(159, 29);
            this.cmbTipoID.TabIndex = 17;
            this.cmbTipoID.SelectedIndexChanged += new System.EventHandler(this.cmbTipoID_SelectedIndexChanged);
            this.cmbTipoID.SelectedValueChanged += new System.EventHandler(this.cmbTipoID_SelectedValueChanged);
            // 
            // rdbInactiva
            // 
            this.rdbInactiva.AutoSize = true;
            this.rdbInactiva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInactiva.Location = new System.Drawing.Point(492, 93);
            this.rdbInactiva.Margin = new System.Windows.Forms.Padding(1);
            this.rdbInactiva.Name = "rdbInactiva";
            this.rdbInactiva.Size = new System.Drawing.Size(81, 25);
            this.rdbInactiva.TabIndex = 16;
            this.rdbInactiva.TabStop = true;
            this.rdbInactiva.Text = "Inactiva";
            this.rdbInactiva.UseVisualStyleBackColor = true;
            // 
            // rdbActiva
            // 
            this.rdbActiva.AutoSize = true;
            this.rdbActiva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActiva.Location = new System.Drawing.Point(492, 50);
            this.rdbActiva.Margin = new System.Windows.Forms.Padding(1);
            this.rdbActiva.Name = "rdbActiva";
            this.rdbActiva.Size = new System.Drawing.Size(70, 25);
            this.rdbActiva.TabIndex = 15;
            this.rdbActiva.TabStop = true;
            this.rdbActiva.Text = "Activa";
            this.rdbActiva.UseVisualStyleBackColor = true;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(149, 182);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(1);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(393, 60);
            this.txtDireccion.TabIndex = 14;
            this.txtDireccion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDireccion_KeyUp);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(149, 109);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(1);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 29);
            this.txtNombre.TabIndex = 12;
            this.txtNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyUp);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(604, 9);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(45, 21);
            this.lblLogo.TabIndex = 10;
            this.lblLogo.Text = "Logo";
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.Location = new System.Drawing.Point(608, 43);
            this.pctLogo.Margin = new System.Windows.Forms.Padding(1);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(217, 185);
            this.pctLogo.TabIndex = 9;
            this.pctLogo.TabStop = false;
            this.pctLogo.Click += new System.EventHandler(this.pctLogo_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(411, 67);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 21);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(11, 185);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 21);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(11, 146);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(68, 21);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(11, 112);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 21);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTipoIdentificacion
            // 
            this.lblTipoIdentificacion.AutoSize = true;
            this.lblTipoIdentificacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoIdentificacion.Location = new System.Drawing.Point(11, 43);
            this.lblTipoIdentificacion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTipoIdentificacion.Name = "lblTipoIdentificacion";
            this.lblTipoIdentificacion.Size = new System.Drawing.Size(157, 21);
            this.lblTipoIdentificacion.TabIndex = 2;
            this.lblTipoIdentificacion.Text = "Tipo de Identificación";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.Location = new System.Drawing.Point(11, 76);
            this.lblIdentificacion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(102, 21);
            this.lblIdentificacion.TabIndex = 1;
            this.lblIdentificacion.Text = "Identificacion";
            // 
            // toolStripMantEmpresa
            // 
            this.toolStripMantEmpresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMantEmpresa.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStripMantEmpresa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEditar,
            this.btnEliminar,
            this.btnLimpiar,
            this.btnSalir});
            this.toolStripMantEmpresa.Location = new System.Drawing.Point(0, 0);
            this.toolStripMantEmpresa.Name = "toolStripMantEmpresa";
            this.toolStripMantEmpresa.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMantEmpresa.Size = new System.Drawing.Size(847, 28);
            this.toolStripMantEmpresa.TabIndex = 0;
            this.toolStripMantEmpresa.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.AllowUserToAddRows = false;
            this.dgvEmpresa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEmpresa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvEmpresa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpresa.Location = new System.Drawing.Point(0, 0);
            this.dgvEmpresa.Margin = new System.Windows.Forms.Padding(1);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.ReadOnly = true;
            this.dgvEmpresa.RowHeadersVisible = false;
            this.dgvEmpresa.RowHeadersWidth = 102;
            this.dgvEmpresa.RowTemplate.Height = 40;
            this.dgvEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpresa.Size = new System.Drawing.Size(847, 339);
            this.dgvEmpresa.TabIndex = 6;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblUsuarioConectado});
            this.toolStrip1.Location = new System.Drawing.Point(0, 339);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(847, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslblUsuarioConectado
            // 
            this.tslblUsuarioConectado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslblUsuarioConectado.Name = "tslblUsuarioConectado";
            this.tslblUsuarioConectado.Size = new System.Drawing.Size(115, 22);
            this.tslblUsuarioConectado.Text = "toolStripLabel1";
            // 
            // errProv1
            // 
            this.errProv1.ContainerControl = this;
            // 
            // frmMantenimientoEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(847, 667);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmMantenimientoEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Empresa";
            this.Load += new System.EventHandler(this.frmMantenimientoEmpresa_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.toolStripMantEmpresa.ResumeLayout(false);
            this.toolStripMantEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStripMantEmpresa;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoIdentificacion;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RadioButton rdbInactiva;
        private System.Windows.Forms.RadioButton rdbActiva;
        private System.Windows.Forms.ComboBox cmbTipoID;
        private System.Windows.Forms.Button btnCargarLogo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslblUsuarioConectado;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.ErrorProvider errProv1;
        private System.Windows.Forms.MaskedTextBox mktID;
        private System.Windows.Forms.MaskedTextBox mktTelefono;
    }
}