namespace PayrollPal.Layers.UI.Mantenimientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoSupervisores));
            this.toolTipSupervisor = new System.Windows.Forms.ToolTip(this.components);
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblListaColaboradoresSup = new System.Windows.Forms.Label();
            this.lblListaColaboradoresALL = new System.Windows.Forms.Label();
            this.btnQuitarColab = new System.Windows.Forms.Button();
            this.btnAgregarCol = new System.Windows.Forms.Button();
            this.lstColaboradoresSup = new System.Windows.Forms.ListBox();
            this.lstColaboradoresALL = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslblUsuarioConectado = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupervisores)).BeginInit();
            this.toolStripMantSupervisor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(14, 329);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSupervisores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSupervisores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupervisores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupervisores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSupervisores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupervisores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSupervisor,
            this.IDRol,
            this.Descripcion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupervisores.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.dgvSupervisores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupervisores_CellContentDoubleClick);
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
            this.splitContainer1.Panel1.Controls.Add(this.txtID);
            this.splitContainer1.Panel1.Controls.Add(this.lblListaColaboradoresSup);
            this.splitContainer1.Panel1.Controls.Add(this.lblListaColaboradoresALL);
            this.splitContainer1.Panel1.Controls.Add(this.btnQuitarColab);
            this.splitContainer1.Panel1.Controls.Add(this.btnAgregarCol);
            this.splitContainer1.Panel1.Controls.Add(this.lstColaboradoresSup);
            this.splitContainer1.Panel1.Controls.Add(this.lstColaboradoresALL);
            this.splitContainer1.Panel1.Controls.Add(this.btnConfirmar);
            this.splitContainer1.Panel1.Controls.Add(this.txtDescripcion);
            this.splitContainer1.Panel1.Controls.Add(this.txtRol);
            this.splitContainer1.Panel1.Controls.Add(this.lblRol);
            this.splitContainer1.Panel1.Controls.Add(this.lblDescripcion);
            this.splitContainer1.Panel1.Controls.Add(this.lblID);
            this.splitContainer1.Panel1.Controls.Add(this.toolStripMantSupervisor);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.dgvSupervisores);
            this.splitContainer1.Size = new System.Drawing.Size(1132, 775);
            this.splitContainer1.SplitterDistance = 367;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(165, 46);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(150, 29);
            this.txtID.TabIndex = 67;
            this.txtID.Text = "sup";
            // 
            // lblListaColaboradoresSup
            // 
            this.lblListaColaboradoresSup.AutoSize = true;
            this.lblListaColaboradoresSup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaColaboradoresSup.Location = new System.Drawing.Point(793, 9);
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
            this.btnQuitarColab.Location = new System.Drawing.Point(650, 213);
            this.btnQuitarColab.Name = "btnQuitarColab";
            this.btnQuitarColab.Size = new System.Drawing.Size(84, 35);
            this.btnQuitarColab.TabIndex = 64;
            this.btnQuitarColab.Text = "Quitar";
            this.btnQuitarColab.UseVisualStyleBackColor = true;
            this.btnQuitarColab.Click += new System.EventHandler(this.btnQuitarColab_Click);
            // 
            // btnAgregarCol
            // 
            this.btnAgregarCol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCol.Location = new System.Drawing.Point(650, 123);
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
            this.lstColaboradoresSup.Location = new System.Drawing.Point(797, 45);
            this.lstColaboradoresSup.Name = "lstColaboradoresSup";
            this.lstColaboradoresSup.Size = new System.Drawing.Size(219, 319);
            this.lstColaboradoresSup.TabIndex = 62;
            this.lstColaboradoresSup.SelectedValueChanged += new System.EventHandler(this.lstColaboradoresSup_SelectedValueChanged);
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
            this.lstColaboradoresALL.SelectedValueChanged += new System.EventHandler(this.lstColaboradoresALL_SelectedValueChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblUsuarioConectado});
            this.toolStrip1.Location = new System.Drawing.Point(0, 381);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(1132, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslblUsuarioConectado
            // 
            this.tslblUsuarioConectado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslblUsuarioConectado.Name = "tslblUsuarioConectado";
            this.tslblUsuarioConectado.Size = new System.Drawing.Size(115, 22);
            this.tslblUsuarioConectado.Text = "toolStripLabel1";
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMantenimientoSupervisores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupervisores)).EndInit();
            this.toolStripMantSupervisor.ResumeLayout(false);
            this.toolStripMantSupervisor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv1)).EndInit();
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

        private System.Windows.Forms.ToolTip toolTipSupervisor;
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
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslblUsuarioConectado;
    }
}