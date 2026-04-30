namespace sistemaPresentacion
{
    partial class FrmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.TabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtTotalID = new System.Windows.Forms.TextBox();
            this.txtTotalImpuestosID = new System.Windows.Forms.TextBox();
            this.txtSubTotalID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvMostrarDetalles = new System.Windows.Forms.DataGridView();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnAnular = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ChkSeleccionar = new System.Windows.Forms.CheckBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTotalimpuesto = new System.Windows.Forms.TextBox();
            this.txtsubTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.btnverArticulos = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnbuscarCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnumComprobante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtserieComprobante = new System.Windows.Forms.TextBox();
            this.cboComprobante = new System.Windows.Forms.ComboBox();
            this.txtnombreCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TabPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPrincipal
            // 
            this.TabPrincipal.Controls.Add(this.tabPage1);
            this.TabPrincipal.Controls.Add(this.tabPage2);
            this.TabPrincipal.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPrincipal.Location = new System.Drawing.Point(0, 127);
            this.TabPrincipal.Name = "TabPrincipal";
            this.TabPrincipal.SelectedIndex = 0;
            this.TabPrincipal.Size = new System.Drawing.Size(1247, 787);
            this.TabPrincipal.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelDetalle);
            this.tabPage1.Controls.Add(this.BtnSalir);
            this.tabPage1.Controls.Add(this.BtnAnular);
            this.tabPage1.Controls.Add(this.LblTotal);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Controls.Add(this.ChkSeleccionar);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.TxtBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1239, 758);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelDetalle
            // 
            this.panelDetalle.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelDetalle.Controls.Add(this.btnCerrar);
            this.panelDetalle.Controls.Add(this.txtTotalID);
            this.panelDetalle.Controls.Add(this.txtTotalImpuestosID);
            this.panelDetalle.Controls.Add(this.txtSubTotalID);
            this.panelDetalle.Controls.Add(this.label12);
            this.panelDetalle.Controls.Add(this.label13);
            this.panelDetalle.Controls.Add(this.label14);
            this.panelDetalle.Controls.Add(this.dgvMostrarDetalles);
            this.panelDetalle.Location = new System.Drawing.Point(231, 134);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(947, 530);
            this.panelDetalle.TabIndex = 9;
            this.panelDetalle.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCerrar.Location = new System.Drawing.Point(851, 15);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(68, 44);
            this.btnCerrar.TabIndex = 27;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtTotalID
            // 
            this.txtTotalID.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalID.Location = new System.Drawing.Point(795, 432);
            this.txtTotalID.Name = "txtTotalID";
            this.txtTotalID.Size = new System.Drawing.Size(124, 22);
            this.txtTotalID.TabIndex = 26;
            // 
            // txtTotalImpuestosID
            // 
            this.txtTotalImpuestosID.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalImpuestosID.Location = new System.Drawing.Point(795, 396);
            this.txtTotalImpuestosID.Name = "txtTotalImpuestosID";
            this.txtTotalImpuestosID.Size = new System.Drawing.Size(124, 22);
            this.txtTotalImpuestosID.TabIndex = 25;
            // 
            // txtSubTotalID
            // 
            this.txtSubTotalID.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotalID.Location = new System.Drawing.Point(795, 359);
            this.txtSubTotalID.Name = "txtSubTotalID";
            this.txtSubTotalID.Size = new System.Drawing.Size(124, 22);
            this.txtSubTotalID.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(645, 432);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(645, 396);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 18);
            this.label13.TabIndex = 23;
            this.label13.Text = "Total Impuestos:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(645, 359);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 18);
            this.label14.TabIndex = 22;
            this.label14.Text = "Sub Total:";
            // 
            // dgvMostrarDetalles
            // 
            this.dgvMostrarDetalles.AllowUserToAddRows = false;
            this.dgvMostrarDetalles.AllowUserToDeleteRows = false;
            this.dgvMostrarDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarDetalles.Location = new System.Drawing.Point(23, 74);
            this.dgvMostrarDetalles.Name = "dgvMostrarDetalles";
            this.dgvMostrarDetalles.ReadOnly = true;
            this.dgvMostrarDetalles.Size = new System.Drawing.Size(896, 256);
            this.dgvMostrarDetalles.TabIndex = 0;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.BtnSalir.ImageKey = "salir.png";
            this.BtnSalir.ImageList = this.imageList1;
            this.BtnSalir.Location = new System.Drawing.Point(136, 683);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(90, 58);
            this.BtnSalir.TabIndex = 8;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "salir.png");
            this.imageList1.Images.SetKeyName(1, "actualizar.png");
            this.imageList1.Images.SetKeyName(2, "eliminar.png");
            this.imageList1.Images.SetKeyName(3, "nuevo.png");
            this.imageList1.Images.SetKeyName(4, "reporte.png");
            this.imageList1.Images.SetKeyName(5, "desactivar.jpg");
            this.imageList1.Images.SetKeyName(6, "actualizar.png");
            this.imageList1.Images.SetKeyName(7, "eliminar.png");
            this.imageList1.Images.SetKeyName(8, "icono1.ico");
            this.imageList1.Images.SetKeyName(9, "icono2.ico");
            this.imageList1.Images.SetKeyName(10, "logo.png");
            this.imageList1.Images.SetKeyName(11, "lupa.ico");
            this.imageList1.Images.SetKeyName(12, "lupa.png");
            this.imageList1.Images.SetKeyName(13, "nuevo.png");
            this.imageList1.Images.SetKeyName(14, "palanca.png");
            this.imageList1.Images.SetKeyName(15, "reporte.png");
            this.imageList1.Images.SetKeyName(16, "retornar.ico");
            this.imageList1.Images.SetKeyName(17, "retornar1.ico");
            this.imageList1.Images.SetKeyName(18, "salir.png");
            // 
            // BtnAnular
            // 
            this.BtnAnular.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnAnular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.BtnAnular.ImageKey = "eliminar.png";
            this.BtnAnular.ImageList = this.imageList1;
            this.BtnAnular.Location = new System.Drawing.Point(23, 683);
            this.BtnAnular.Name = "BtnAnular";
            this.BtnAnular.Size = new System.Drawing.Size(90, 58);
            this.BtnAnular.TabIndex = 7;
            this.BtnAnular.Text = "Anular";
            this.BtnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAnular.UseVisualStyleBackColor = false;
            this.BtnAnular.Click += new System.EventHandler(this.BtnAnular_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(923, 470);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(49, 18);
            this.LblTotal.TabIndex = 4;
            this.LblTotal.Text = "Total:";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListado.Location = new System.Drawing.Point(6, 48);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.Size = new System.Drawing.Size(1172, 399);
            this.DgvListado.TabIndex = 2;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // ChkSeleccionar
            // 
            this.ChkSeleccionar.AutoSize = true;
            this.ChkSeleccionar.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkSeleccionar.Location = new System.Drawing.Point(8, 470);
            this.ChkSeleccionar.Name = "ChkSeleccionar";
            this.ChkSeleccionar.Size = new System.Drawing.Size(108, 22);
            this.ChkSeleccionar.TabIndex = 3;
            this.ChkSeleccionar.Text = "Seleccionar";
            this.ChkSeleccionar.UseVisualStyleBackColor = true;
            this.ChkSeleccionar.CheckedChanged += new System.EventHandler(this.ChkSeleccionar_CheckedChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.Thistle;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnBuscar.Location = new System.Drawing.Point(528, 13);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(101, 29);
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(8, 16);
            this.TxtBuscar.Multiline = true;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(494, 26);
            this.TxtBuscar.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnInsertar);
            this.tabPage2.Controls.Add(this.groupbox);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1239, 758);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(599, 699);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 31);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(367, 699);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(122, 31);
            this.btnInsertar.TabIndex = 21;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.label11);
            this.groupbox.Controls.Add(this.txtTotal);
            this.groupbox.Controls.Add(this.txtTotalimpuesto);
            this.groupbox.Controls.Add(this.txtsubTotal);
            this.groupbox.Controls.Add(this.label10);
            this.groupbox.Controls.Add(this.label9);
            this.groupbox.Controls.Add(this.label8);
            this.groupbox.Controls.Add(this.dgvDetalle);
            this.groupbox.Controls.Add(this.btnverArticulos);
            this.groupbox.Controls.Add(this.label7);
            this.groupbox.Controls.Add(this.txtCodigo);
            this.groupbox.Location = new System.Drawing.Point(41, 236);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(1017, 439);
            this.groupbox.TabIndex = 14;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Detalle";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(325, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "Los campos marcados con (*) son obligatorios";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(784, 387);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(124, 22);
            this.txtTotal.TabIndex = 20;
            // 
            // txtTotalimpuesto
            // 
            this.txtTotalimpuesto.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalimpuesto.Location = new System.Drawing.Point(784, 351);
            this.txtTotalimpuesto.Name = "txtTotalimpuesto";
            this.txtTotalimpuesto.Size = new System.Drawing.Size(124, 22);
            this.txtTotalimpuesto.TabIndex = 19;
            // 
            // txtsubTotal
            // 
            this.txtsubTotal.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubTotal.Location = new System.Drawing.Point(784, 314);
            this.txtsubTotal.Name = "txtsubTotal";
            this.txtsubTotal.Size = new System.Drawing.Size(124, 22);
            this.txtsubTotal.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(634, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(634, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Total Impuestos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(634, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Sub Total:";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(45, 102);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(922, 179);
            this.dgvDetalle.TabIndex = 16;
            this.dgvDetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellEndEdit);
            this.dgvDetalle.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvDetalle_RowsRemoved);
            // 
            // btnverArticulos
            // 
            this.btnverArticulos.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverArticulos.Location = new System.Drawing.Point(873, 45);
            this.btnverArticulos.Name = "btnverArticulos";
            this.btnverArticulos.Size = new System.Drawing.Size(94, 31);
            this.btnverArticulos.TabIndex = 14;
            this.btnverArticulos.Text = "Ver";
            this.btnverArticulos.UseVisualStyleBackColor = true;
            this.btnverArticulos.Click += new System.EventHandler(this.btnverArticulos_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Artículo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(134, 49);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(708, 22);
            this.txtCodigo.TabIndex = 14;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtImpuesto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.btnbuscarCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtnumComprobante);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtserieComprobante);
            this.groupBox1.Controls.Add(this.cboComprobante);
            this.groupBox1.Controls.Add(this.txtnombreCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdCliente);
            this.groupBox1.Location = new System.Drawing.Point(41, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1032, 143);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cabecera";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuesto.Location = new System.Drawing.Point(826, 97);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(116, 22);
            this.txtImpuesto.TabIndex = 13;
            this.txtImpuesto.Text = "0.18";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(711, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Impuesto(*):";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(826, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(116, 22);
            this.txtId.TabIndex = 11;
            // 
            // btnbuscarCliente
            // 
            this.btnbuscarCliente.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarCliente.Location = new System.Drawing.Point(687, 28);
            this.btnbuscarCliente.Name = "btnbuscarCliente";
            this.btnbuscarCliente.Size = new System.Drawing.Size(94, 31);
            this.btnbuscarCliente.TabIndex = 10;
            this.btnbuscarCliente.Text = "Buscar";
            this.btnbuscarCliente.UseVisualStyleBackColor = true;
            this.btnbuscarCliente.Click += new System.EventHandler(this.btnbuscarCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(564, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Número";
            // 
            // txtnumComprobante
            // 
            this.txtnumComprobante.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumComprobante.Location = new System.Drawing.Point(514, 99);
            this.txtnumComprobante.Name = "txtnumComprobante";
            this.txtnumComprobante.Size = new System.Drawing.Size(162, 22);
            this.txtnumComprobante.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Serie";
            // 
            // txtserieComprobante
            // 
            this.txtserieComprobante.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserieComprobante.Location = new System.Drawing.Point(342, 99);
            this.txtserieComprobante.Name = "txtserieComprobante";
            this.txtserieComprobante.Size = new System.Drawing.Size(124, 22);
            this.txtserieComprobante.TabIndex = 6;
            // 
            // cboComprobante
            // 
            this.cboComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComprobante.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboComprobante.FormattingEnabled = true;
            this.cboComprobante.Items.AddRange(new object[] {
            "FACTURA",
            "TICKET",
            "BOLETA",
            "GUIA"});
            this.cboComprobante.Location = new System.Drawing.Point(167, 100);
            this.cboComprobante.Name = "cboComprobante";
            this.cboComprobante.Size = new System.Drawing.Size(121, 24);
            this.cboComprobante.TabIndex = 5;
            // 
            // txtnombreCliente
            // 
            this.txtnombreCliente.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreCliente.Location = new System.Drawing.Point(347, 33);
            this.txtnombreCliente.Name = "txtnombreCliente";
            this.txtnombreCliente.ReadOnly = true;
            this.txtnombreCliente.Size = new System.Drawing.Size(313, 22);
            this.txtnombreCliente.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Comprobante(*):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente(*):";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(167, 32);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(124, 22);
            this.txtIdCliente.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 99);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTAS";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 1032);
            this.Controls.Add(this.TabPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.TabPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtTotalID;
        private System.Windows.Forms.TextBox txtTotalImpuestosID;
        private System.Windows.Forms.TextBox txtSubTotalID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvMostrarDetalles;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnAnular;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.CheckBox ChkSeleccionar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTotalimpuesto;
        private System.Windows.Forms.TextBox txtsubTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btnverArticulos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnbuscarCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnumComprobante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtserieComprobante;
        private System.Windows.Forms.ComboBox cboComprobante;
        private System.Windows.Forms.TextBox txtnombreCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
    }
}