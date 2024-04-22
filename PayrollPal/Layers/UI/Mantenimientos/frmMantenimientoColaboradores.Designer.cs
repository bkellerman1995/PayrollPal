namespace PayrollPal.UI.Mantenimientos
{
    partial class frmMantenimientoColaboradores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoColaboradores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblIDSupervisor = new System.Windows.Forms.Label();
            this.cmbIDSup = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbPuestos = new System.Windows.Forms.ComboBox();
            this.rdbInactivo = new System.Windows.Forms.RadioButton();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblColon = new System.Windows.Forms.Label();
            this.mktSalarioHora = new System.Windows.Forms.MaskedTextBox();
            this.lblCR = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.mktCuentaIBAN = new System.Windows.Forms.MaskedTextBox();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.cmbSupervisor = new System.Windows.Forms.ComboBox();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCuentaIBAN = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblSalarioHora = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.toolStripMantEmpresa = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.dgvColaboradores = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaIBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fotografia = new System.Windows.Forms.DataGridViewImageColumn();
            this.errProv1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslblUsuarioConectado = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            this.toolStripMantEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProv1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightBlue;
            this.splitContainer1.Panel1.Controls.Add(this.lblIDSupervisor);
            this.splitContainer1.Panel1.Controls.Add(this.cmbIDSup);
            this.splitContainer1.Panel1.Controls.Add(this.txtID);
            this.splitContainer1.Panel1.Controls.Add(this.cmbPuestos);
            this.splitContainer1.Panel1.Controls.Add(this.rdbInactivo);
            this.splitContainer1.Panel1.Controls.Add(this.rdbActivo);
            this.splitContainer1.Panel1.Controls.Add(this.lblEstado);
            this.splitContainer1.Panel1.Controls.Add(this.lblColon);
            this.splitContainer1.Panel1.Controls.Add(this.mktSalarioHora);
            this.splitContainer1.Panel1.Controls.Add(this.lblCR);
            this.splitContainer1.Panel1.Controls.Add(this.cmbUsuario);
            this.splitContainer1.Panel1.Controls.Add(this.btnConfirmar);
            this.splitContainer1.Panel1.Controls.Add(this.mktCuentaIBAN);
            this.splitContainer1.Panel1.Controls.Add(this.btnCargarFoto);
            this.splitContainer1.Panel1.Controls.Add(this.cmbSupervisor);
            this.splitContainer1.Panel1.Controls.Add(this.lblSupervisor);
            this.splitContainer1.Panel1.Controls.Add(this.lblUsuario);
            this.splitContainer1.Panel1.Controls.Add(this.lblCuentaIBAN);
            this.splitContainer1.Panel1.Controls.Add(this.cmbRol);
            this.splitContainer1.Panel1.Controls.Add(this.lblRol);
            this.splitContainer1.Panel1.Controls.Add(this.lblPuesto);
            this.splitContainer1.Panel1.Controls.Add(this.txtCorreoElectronico);
            this.splitContainer1.Panel1.Controls.Add(this.lblCorreoElectronico);
            this.splitContainer1.Panel1.Controls.Add(this.lblSalarioHora);
            this.splitContainer1.Panel1.Controls.Add(this.cmbDepartamento);
            this.splitContainer1.Panel1.Controls.Add(this.lblDepartamento);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaIngreso);
            this.splitContainer1.Panel1.Controls.Add(this.lblFechaIngreso);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaNacimiento);
            this.splitContainer1.Panel1.Controls.Add(this.lblFechaNacimiento);
            this.splitContainer1.Panel1.Controls.Add(this.txtApellido2);
            this.splitContainer1.Panel1.Controls.Add(this.lblSegundoApellido);
            this.splitContainer1.Panel1.Controls.Add(this.txtApellido1);
            this.splitContainer1.Panel1.Controls.Add(this.lblPrimerApellido);
            this.splitContainer1.Panel1.Controls.Add(this.txtDireccion);
            this.splitContainer1.Panel1.Controls.Add(this.txtNombre);
            this.splitContainer1.Panel1.Controls.Add(this.lblFoto);
            this.splitContainer1.Panel1.Controls.Add(this.pctFoto);
            this.splitContainer1.Panel1.Controls.Add(this.lblDireccion);
            this.splitContainer1.Panel1.Controls.Add(this.lblNombre);
            this.splitContainer1.Panel1.Controls.Add(this.lblIdentificacion);
            this.splitContainer1.Panel1.Controls.Add(this.toolStripMantEmpresa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvColaboradores);
            this.splitContainer1.Size = new System.Drawing.Size(3572, 2348);
            this.splitContainer1.SplitterDistance = 1599;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblIDSupervisor
            // 
            this.lblIDSupervisor.AutoSize = true;
            this.lblIDSupervisor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDSupervisor.Location = new System.Drawing.Point(2258, 1080);
            this.lblIDSupervisor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDSupervisor.Name = "lblIDSupervisor";
            this.lblIDSupervisor.Size = new System.Drawing.Size(315, 54);
            this.lblIDSupervisor.TabIndex = 73;
            this.lblIDSupervisor.Text = "ID de Supervisor";
            // 
            // cmbIDSup
            // 
            this.cmbIDSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDSup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIDSup.FormattingEnabled = true;
            this.cmbIDSup.Location = new System.Drawing.Point(2610, 1072);
            this.cmbIDSup.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIDSup.Name = "cmbIDSup";
            this.cmbIDSup.Size = new System.Drawing.Size(629, 62);
            this.cmbIDSup.TabIndex = 72;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(460, 85);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(392, 61);
            this.txtID.TabIndex = 71;
            this.txtID.Text = "col";
            // 
            // cmbPuestos
            // 
            this.cmbPuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuestos.FormattingEnabled = true;
            this.cmbPuestos.Location = new System.Drawing.Point(1580, 998);
            this.cmbPuestos.Margin = new System.Windows.Forms.Padding(8);
            this.cmbPuestos.Name = "cmbPuestos";
            this.cmbPuestos.Size = new System.Drawing.Size(632, 62);
            this.cmbPuestos.TabIndex = 70;
            // 
            // rdbInactivo
            // 
            this.rdbInactivo.AutoSize = true;
            this.rdbInactivo.Location = new System.Drawing.Point(1580, 1428);
            this.rdbInactivo.Margin = new System.Windows.Forms.Padding(8);
            this.rdbInactivo.Name = "rdbInactivo";
            this.rdbInactivo.Size = new System.Drawing.Size(198, 58);
            this.rdbInactivo.TabIndex = 69;
            this.rdbInactivo.TabStop = true;
            this.rdbInactivo.Text = "Inactivo";
            this.rdbInactivo.UseVisualStyleBackColor = true;
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.Location = new System.Drawing.Point(1580, 1302);
            this.rdbActivo.Margin = new System.Windows.Forms.Padding(8);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(170, 58);
            this.rdbActivo.TabIndex = 68;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(1235, 1370);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(141, 54);
            this.lblEstado.TabIndex = 67;
            this.lblEstado.Text = "Estado";
            // 
            // lblColon
            // 
            this.lblColon.AutoSize = true;
            this.lblColon.Location = new System.Drawing.Point(310, 1025);
            this.lblColon.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblColon.Name = "lblColon";
            this.lblColon.Size = new System.Drawing.Size(45, 54);
            this.lblColon.TabIndex = 66;
            this.lblColon.Text = "₡";
            // 
            // mktSalarioHora
            // 
            this.mktSalarioHora.Location = new System.Drawing.Point(358, 1018);
            this.mktSalarioHora.Margin = new System.Windows.Forms.Padding(8);
            this.mktSalarioHora.Mask = "0000";
            this.mktSalarioHora.Name = "mktSalarioHora";
            this.mktSalarioHora.Size = new System.Drawing.Size(394, 61);
            this.mktSalarioHora.TabIndex = 65;
            this.mktSalarioHora.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mktSalarioHora_KeyUp);
            // 
            // lblCR
            // 
            this.lblCR.AutoSize = true;
            this.lblCR.Location = new System.Drawing.Point(1512, 768);
            this.lblCR.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCR.Name = "lblCR";
            this.lblCR.Size = new System.Drawing.Size(72, 54);
            this.lblCR.TabIndex = 64;
            this.lblCR.Text = "CR";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(1580, 875);
            this.cmbUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(632, 62);
            this.cmbUsuario.TabIndex = 63;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(12, 1370);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(8);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(250, 88);
            this.btnConfirmar.TabIndex = 62;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // mktCuentaIBAN
            // 
            this.mktCuentaIBAN.Location = new System.Drawing.Point(1580, 760);
            this.mktCuentaIBAN.Margin = new System.Windows.Forms.Padding(8);
            this.mktCuentaIBAN.Mask = "00000000000000000000";
            this.mktCuentaIBAN.Name = "mktCuentaIBAN";
            this.mktCuentaIBAN.Size = new System.Drawing.Size(632, 61);
            this.mktCuentaIBAN.TabIndex = 61;
            this.mktCuentaIBAN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mktCuentaIBAN_KeyUp);
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarFoto.Location = new System.Drawing.Point(2095, 85);
            this.btnCargarFoto.Margin = new System.Windows.Forms.Padding(8);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(198, 65);
            this.btnCargarFoto.TabIndex = 60;
            this.btnCargarFoto.Text = "Cargar";
            this.btnCargarFoto.UseVisualStyleBackColor = true;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // cmbSupervisor
            // 
            this.cmbSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupervisor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupervisor.FormattingEnabled = true;
            this.cmbSupervisor.Location = new System.Drawing.Point(1582, 1158);
            this.cmbSupervisor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSupervisor.Name = "cmbSupervisor";
            this.cmbSupervisor.Size = new System.Drawing.Size(629, 62);
            this.cmbSupervisor.TabIndex = 55;
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervisor.Location = new System.Drawing.Point(1235, 1178);
            this.lblSupervisor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(209, 54);
            this.lblSupervisor.TabIndex = 54;
            this.lblSupervisor.Text = "Supervisor";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(1235, 882);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(157, 54);
            this.lblUsuario.TabIndex = 52;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblCuentaIBAN
            // 
            this.lblCuentaIBAN.AutoSize = true;
            this.lblCuentaIBAN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaIBAN.Location = new System.Drawing.Point(1235, 768);
            this.lblCuentaIBAN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuentaIBAN.Name = "lblCuentaIBAN";
            this.lblCuentaIBAN.Size = new System.Drawing.Size(250, 54);
            this.lblCuentaIBAN.TabIndex = 50;
            this.lblCuentaIBAN.Text = "Cuenta IBAN";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(1580, 1072);
            this.cmbRol.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(632, 62);
            this.cmbRol.TabIndex = 49;
            this.cmbRol.SelectedValueChanged += new System.EventHandler(this.cmbRol_SelectedValueChanged);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(1235, 1092);
            this.lblRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(79, 54);
            this.lblRol.TabIndex = 48;
            this.lblRol.Text = "Rol";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(1235, 1010);
            this.lblPuesto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(143, 54);
            this.lblPuesto.TabIndex = 46;
            this.lblPuesto.Text = "Puesto";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoElectronico.Location = new System.Drawing.Point(360, 1132);
            this.txtCorreoElectronico.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(392, 61);
            this.txtCorreoElectronico.TabIndex = 45;
            this.txtCorreoElectronico.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCorreoElectronico_KeyUp);
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoElectronico.Location = new System.Drawing.Point(12, 1132);
            this.lblCorreoElectronico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(348, 54);
            this.lblCorreoElectronico.TabIndex = 44;
            this.lblCorreoElectronico.Text = "Correo Electrónico";
            // 
            // lblSalarioHora
            // 
            this.lblSalarioHora.AutoSize = true;
            this.lblSalarioHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioHora.Location = new System.Drawing.Point(12, 1018);
            this.lblSalarioHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalarioHora.Name = "lblSalarioHora";
            this.lblSalarioHora.Size = new System.Drawing.Size(264, 54);
            this.lblSalarioHora.TabIndex = 42;
            this.lblSalarioHora.Text = "Salario / Hora";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(358, 880);
            this.cmbDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(394, 62);
            this.cmbDepartamento.TabIndex = 41;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(20, 888);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(279, 54);
            this.lblDepartamento.TabIndex = 40;
            this.lblDepartamento.Text = "Departamento";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(360, 762);
            this.dtpFechaIngreso.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(762, 61);
            this.dtpFechaIngreso.TabIndex = 39;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(15, 768);
            this.lblFechaIngreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(325, 54);
            this.lblFechaIngreso.TabIndex = 38;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(460, 435);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(732, 61);
            this.dtpFechaNacimiento.TabIndex = 37;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(2, 435);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(395, 54);
            this.lblFechaNacimiento.TabIndex = 36;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // txtApellido2
            // 
            this.txtApellido2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.Location = new System.Drawing.Point(460, 340);
            this.txtApellido2.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(392, 61);
            this.txtApellido2.TabIndex = 35;
            this.txtApellido2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtApellido2_KeyUp);
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.Location = new System.Drawing.Point(0, 340);
            this.lblSegundoApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(341, 54);
            this.lblSegundoApellido.TabIndex = 34;
            this.lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.Location = new System.Drawing.Point(460, 255);
            this.txtApellido1.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(392, 61);
            this.txtApellido1.TabIndex = 33;
            this.txtApellido1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtApellido1_KeyUp);
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.Location = new System.Drawing.Point(2, 255);
            this.lblPrimerApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(297, 54);
            this.lblPrimerApellido.TabIndex = 32;
            this.lblPrimerApellido.Text = "Primer Apellido";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(360, 548);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(1332, 144);
            this.txtDireccion.TabIndex = 29;
            this.txtDireccion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDireccion_KeyUp);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(460, 170);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(392, 61);
            this.txtNombre.TabIndex = 27;
            this.txtNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyUp);
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(1760, 90);
            this.lblFoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(103, 54);
            this.lblFoto.TabIndex = 25;
            this.lblFoto.Text = "Foto";
            // 
            // pctFoto
            // 
            this.pctFoto.Location = new System.Drawing.Point(1755, 170);
            this.pctFoto.Margin = new System.Windows.Forms.Padding(2);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(542, 462);
            this.pctFoto.TabIndex = 24;
            this.pctFoto.TabStop = false;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(15, 548);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(188, 54);
            this.lblDireccion.TabIndex = 22;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(2, 178);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(169, 54);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.Location = new System.Drawing.Point(2, 98);
            this.lblIdentificacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(261, 54);
            this.lblIdentificacion.TabIndex = 18;
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
            this.toolStripMantEmpresa.Size = new System.Drawing.Size(3572, 65);
            this.toolStripMantEmpresa.TabIndex = 17;
            this.toolStripMantEmpresa.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 58);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.toolStripButtonSalir_Click);
            // 
            // dgvColaboradores
            // 
            this.dgvColaboradores.AllowUserToAddRows = false;
            this.dgvColaboradores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvColaboradores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvColaboradores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvColaboradores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColaboradores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido1,
            this.Apellido2,
            this.FechaNacimiento,
            this.Direccion,
            this.FechaIngreso,
            this.IDDepartamento,
            this.SalarioHora,
            this.CorreoElectronico,
            this.CodigoPuesto,
            this.IDRol,
            this.CuentaIBAN,
            this.IDUsuario,
            this.IDSupervisor,
            this.Estado,
            this.Fotografia});
            this.dgvColaboradores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColaboradores.Location = new System.Drawing.Point(0, 0);
            this.dgvColaboradores.Margin = new System.Windows.Forms.Padding(2);
            this.dgvColaboradores.Name = "dgvColaboradores";
            this.dgvColaboradores.ReadOnly = true;
            this.dgvColaboradores.RowHeadersVisible = false;
            this.dgvColaboradores.RowHeadersWidth = 102;
            this.dgvColaboradores.RowTemplate.Height = 40;
            this.dgvColaboradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColaboradores.Size = new System.Drawing.Size(3572, 744);
            this.dgvColaboradores.TabIndex = 5;
            this.dgvColaboradores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColaboradores_CellContentDoubleClick);
            this.dgvColaboradores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvColaboradores_CellFormatting);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IdColaborador";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 12;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 116;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 12;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 223;
            // 
            // Apellido1
            // 
            this.Apellido1.DataPropertyName = "Apellido1";
            this.Apellido1.HeaderText = "Apellido1";
            this.Apellido1.MinimumWidth = 12;
            this.Apellido1.Name = "Apellido1";
            this.Apellido1.ReadOnly = true;
            this.Apellido1.Width = 247;
            // 
            // Apellido2
            // 
            this.Apellido2.DataPropertyName = "Apellido2";
            this.Apellido2.HeaderText = "Apellido2";
            this.Apellido2.MinimumWidth = 12;
            this.Apellido2.Name = "Apellido2";
            this.Apellido2.ReadOnly = true;
            this.Apellido2.Width = 247;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "Fec.Nac.";
            this.FechaNacimiento.MinimumWidth = 12;
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Width = 222;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.MinimumWidth = 12;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 242;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.DataPropertyName = "FechaIngreso";
            this.FechaIngreso.HeaderText = "Fec.Ing.";
            this.FechaIngreso.MinimumWidth = 12;
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            this.FechaIngreso.Width = 212;
            // 
            // IDDepartamento
            // 
            this.IDDepartamento.DataPropertyName = "IDDepartamento";
            this.IDDepartamento.HeaderText = "Departamento";
            this.IDDepartamento.MinimumWidth = 12;
            this.IDDepartamento.Name = "IDDepartamento";
            this.IDDepartamento.ReadOnly = true;
            this.IDDepartamento.Width = 333;
            // 
            // SalarioHora
            // 
            this.SalarioHora.DataPropertyName = "SalarioHora";
            this.SalarioHora.HeaderText = "Salario/Hora";
            this.SalarioHora.MinimumWidth = 12;
            this.SalarioHora.Name = "SalarioHora";
            this.SalarioHora.ReadOnly = true;
            this.SalarioHora.Width = 296;
            // 
            // CorreoElectronico
            // 
            this.CorreoElectronico.DataPropertyName = "CorreoElectronico";
            this.CorreoElectronico.HeaderText = "E-Mail";
            this.CorreoElectronico.MinimumWidth = 12;
            this.CorreoElectronico.Name = "CorreoElectronico";
            this.CorreoElectronico.ReadOnly = true;
            this.CorreoElectronico.Width = 189;
            // 
            // CodigoPuesto
            // 
            this.CodigoPuesto.DataPropertyName = "CodigoPuesto";
            this.CodigoPuesto.HeaderText = "Puesto";
            this.CodigoPuesto.MinimumWidth = 12;
            this.CodigoPuesto.Name = "CodigoPuesto";
            this.CodigoPuesto.ReadOnly = true;
            this.CodigoPuesto.Width = 197;
            // 
            // IDRol
            // 
            this.IDRol.DataPropertyName = "IDRol";
            this.IDRol.HeaderText = "Rol";
            this.IDRol.MinimumWidth = 12;
            this.IDRol.Name = "IDRol";
            this.IDRol.ReadOnly = true;
            this.IDRol.Width = 133;
            // 
            // CuentaIBAN
            // 
            this.CuentaIBAN.DataPropertyName = "CuentaIBAN";
            this.CuentaIBAN.HeaderText = "Cta.IBAN";
            this.CuentaIBAN.MinimumWidth = 12;
            this.CuentaIBAN.Name = "CuentaIBAN";
            this.CuentaIBAN.ReadOnly = true;
            this.CuentaIBAN.Width = 235;
            // 
            // IDUsuario
            // 
            this.IDUsuario.DataPropertyName = "IDUsuario";
            this.IDUsuario.HeaderText = "Usuario";
            this.IDUsuario.MinimumWidth = 12;
            this.IDUsuario.Name = "IDUsuario";
            this.IDUsuario.ReadOnly = true;
            this.IDUsuario.Width = 211;
            // 
            // IDSupervisor
            // 
            this.IDSupervisor.DataPropertyName = "IDSupervisor";
            this.IDSupervisor.HeaderText = "Supervisor";
            this.IDSupervisor.MinimumWidth = 12;
            this.IDSupervisor.Name = "IDSupervisor";
            this.IDSupervisor.ReadOnly = true;
            this.IDSupervisor.Width = 263;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 12;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 195;
            // 
            // Fotografia
            // 
            this.Fotografia.DataPropertyName = "Foto";
            this.Fotografia.HeaderText = "Foto";
            this.Fotografia.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Fotografia.MinimumWidth = 12;
            this.Fotografia.Name = "Fotografia";
            this.Fotografia.ReadOnly = true;
            this.Fotografia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Fotografia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Fotografia.Width = 157;
            // 
            // errProv1
            // 
            this.errProv1.ContainerControl = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblUsuarioConectado});
            this.toolStrip1.Location = new System.Drawing.Point(0, 2287);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(3572, 61);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslblUsuarioConectado
            // 
            this.tslblUsuarioConectado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslblUsuarioConectado.Name = "tslblUsuarioConectado";
            this.tslblUsuarioConectado.Size = new System.Drawing.Size(291, 54);
            this.tslblUsuarioConectado.Text = "toolStripLabel1";
            // 
            // frmMantenimientoColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(3572, 2348);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMantenimientoColaboradores";
            this.Text = "Mantenimiento de Colaboradores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMantenimientoColaboradores_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            this.toolStripMantEmpresa.ResumeLayout(false);
            this.toolStripMantEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProv1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.PictureBox pctFoto;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.ToolStrip toolStripMantEmpresa;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblSalarioHora;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblCuentaIBAN;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbSupervisor;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.Button btnCargarFoto;
        private System.Windows.Forms.MaskedTextBox mktCuentaIBAN;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.DataGridView dgvColaboradores;
        private System.Windows.Forms.Label lblCR;
        private System.Windows.Forms.ErrorProvider errProv1;
        private System.Windows.Forms.MaskedTextBox mktSalarioHora;
        private System.Windows.Forms.Label lblColon;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.RadioButton rdbInactivo;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaIBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewImageColumn Fotografia;
        private System.Windows.Forms.ComboBox cmbPuestos;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslblUsuarioConectado;
        private System.Windows.Forms.Label lblIDSupervisor;
        private System.Windows.Forms.ComboBox cmbIDSup;
    }
}