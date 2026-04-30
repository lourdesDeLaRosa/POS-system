namespace sistemaPresentacion
{
    partial class FrmArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArticulo));
            this.BtnSalir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnDesactivar = new System.Windows.Forms.Button();
            this.BtnActivar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnImagen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PicImagen = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.PnlCodigo = new System.Windows.Forms.Panel();
            this.BtnguardarCodigo = new System.Windows.Forms.Button();
            this.BtngenerarCodigo = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.ChkSeleccionar = new System.Windows.Forms.CheckBox();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.LblTotal = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TabPrincipal = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.TabPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.BtnSalir.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ImageKey = "salir.png";
            this.BtnSalir.ImageList = this.imageList1;
            this.BtnSalir.Location = new System.Drawing.Point(440, 728);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(94, 90);
            this.BtnSalir.TabIndex = 13;
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
            // BtnDesactivar
            // 
            this.BtnDesactivar.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnDesactivar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.BtnDesactivar.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesactivar.ImageKey = "palanca.png";
            this.BtnDesactivar.ImageList = this.imageList1;
            this.BtnDesactivar.Location = new System.Drawing.Point(240, 728);
            this.BtnDesactivar.Name = "BtnDesactivar";
            this.BtnDesactivar.Size = new System.Drawing.Size(94, 90);
            this.BtnDesactivar.TabIndex = 11;
            this.BtnDesactivar.Text = "Desactivar";
            this.BtnDesactivar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDesactivar.UseVisualStyleBackColor = false;
            this.BtnDesactivar.Click += new System.EventHandler(this.BtnDesactivar_Click);
            // 
            // BtnActivar
            // 
            this.BtnActivar.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnActivar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.BtnActivar.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActivar.ImageKey = "actualizar.png";
            this.BtnActivar.ImageList = this.imageList1;
            this.BtnActivar.Location = new System.Drawing.Point(140, 728);
            this.BtnActivar.Name = "BtnActivar";
            this.BtnActivar.Size = new System.Drawing.Size(94, 90);
            this.BtnActivar.TabIndex = 10;
            this.BtnActivar.Text = "Activar";
            this.BtnActivar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnActivar.UseVisualStyleBackColor = false;
            this.BtnActivar.Click += new System.EventHandler(this.BtnActivar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.BtnEliminar.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ImageKey = "eliminar.png";
            this.BtnEliminar.ImageList = this.imageList1;
            this.BtnEliminar.Location = new System.Drawing.Point(340, 728);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(94, 90);
            this.BtnEliminar.TabIndex = 12;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.BtnNuevo.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ImageKey = "nuevo.png";
            this.BtnNuevo.ImageList = this.imageList1;
            this.BtnNuevo.Location = new System.Drawing.Point(40, 728);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(94, 90);
            this.BtnNuevo.TabIndex = 9;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnImagen);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtstock);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtprecio);
            this.tabPage2.Controls.Add(this.PnlCodigo);
            this.tabPage2.Controls.Add(this.BtnguardarCodigo);
            this.tabPage2.Controls.Add(this.BtngenerarCodigo);
            this.tabPage2.Controls.Add(this.txtDescripcion);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cmbCategorias);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.BtnCancelar);
            this.tabPage2.Controls.Add(this.BtnGuardar);
            this.tabPage2.Controls.Add(this.txtCodigo);
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.BtnActualizar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1040, 564);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnImagen
            // 
            this.btnImagen.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnImagen.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImagen.Location = new System.Drawing.Point(670, 327);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(206, 51);
            this.btnImagen.TabIndex = 20;
            this.btnImagen.Text = "Agregar Imágen";
            this.btnImagen.UseVisualStyleBackColor = false;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PicImagen);
            this.groupBox1.Location = new System.Drawing.Point(558, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 271);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ImágenProducto";
            // 
            // PicImagen
            // 
            this.PicImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicImagen.Location = new System.Drawing.Point(6, 19);
            this.PicImagen.Name = "PicImagen";
            this.PicImagen.Size = new System.Drawing.Size(438, 240);
            this.PicImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImagen.TabIndex = 20;
            this.PicImagen.TabStop = false;
            this.PicImagen.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Stock:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtstock
            // 
            this.txtstock.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.Location = new System.Drawing.Point(180, 124);
            this.txtstock.Multiline = true;
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(99, 26);
            this.txtstock.TabIndex = 16;
            this.txtstock.Text = "0";
            this.txtstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Precio:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtprecio
            // 
            this.txtprecio.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(180, 171);
            this.txtprecio.Multiline = true;
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(99, 21);
            this.txtprecio.TabIndex = 14;
            this.txtprecio.Text = "0.00";
            this.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PnlCodigo
            // 
            this.PnlCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlCodigo.Location = new System.Drawing.Point(89, 336);
            this.PnlCodigo.Name = "PnlCodigo";
            this.PnlCodigo.Size = new System.Drawing.Size(367, 137);
            this.PnlCodigo.TabIndex = 13;
            this.PnlCodigo.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlCodigo_Paint);
            // 
            // BtnguardarCodigo
            // 
            this.BtnguardarCodigo.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnguardarCodigo.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnguardarCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnguardarCodigo.Location = new System.Drawing.Point(310, 280);
            this.BtnguardarCodigo.Name = "BtnguardarCodigo";
            this.BtnguardarCodigo.Size = new System.Drawing.Size(146, 41);
            this.BtnguardarCodigo.TabIndex = 12;
            this.BtnguardarCodigo.Text = "Guardar Código";
            this.BtnguardarCodigo.UseVisualStyleBackColor = false;
            this.BtnguardarCodigo.Click += new System.EventHandler(this.BtnguardarCodigo_Click);
            // 
            // BtngenerarCodigo
            // 
            this.BtngenerarCodigo.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtngenerarCodigo.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtngenerarCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtngenerarCodigo.Location = new System.Drawing.Point(89, 280);
            this.BtngenerarCodigo.Name = "BtngenerarCodigo";
            this.BtngenerarCodigo.Size = new System.Drawing.Size(158, 41);
            this.BtngenerarCodigo.TabIndex = 11;
            this.BtngenerarCodigo.Text = "Generar Código";
            this.BtngenerarCodigo.UseVisualStyleBackColor = false;
            this.BtngenerarCodigo.Click += new System.EventHandler(this.BtngenerarCodigo_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(630, 411);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(295, 125);
            this.txtDescripcion.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Codigo de Barra:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(180, 82);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(309, 24);
            this.cmbCategorias.TabIndex = 8;
            this.cmbCategorias.SelectedIndexChanged += new System.EventHandler(this.cmbCategorias_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 82);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnCancelar.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCancelar.Location = new System.Drawing.Point(333, 492);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(123, 44);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnGuardar.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGuardar.Location = new System.Drawing.Point(89, 492);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(125, 44);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(180, 212);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(231, 23);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(180, 41);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(309, 24);
            this.txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(627, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 41);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Artículo:";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnActualizar.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnActualizar.Location = new System.Drawing.Point(89, 492);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(125, 44);
            this.BtnActualizar.TabIndex = 5;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
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
            // ChkSeleccionar
            // 
            this.ChkSeleccionar.AutoSize = true;
            this.ChkSeleccionar.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkSeleccionar.Location = new System.Drawing.Point(8, 336);
            this.ChkSeleccionar.Name = "ChkSeleccionar";
            this.ChkSeleccionar.Size = new System.Drawing.Size(108, 22);
            this.ChkSeleccionar.TabIndex = 3;
            this.ChkSeleccionar.Text = "Seleccionar";
            this.ChkSeleccionar.UseVisualStyleBackColor = true;
            this.ChkSeleccionar.CheckedChanged += new System.EventHandler(this.ChkSeleccionar_CheckedChanged);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
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
            this.DgvListado.Size = new System.Drawing.Size(739, 282);
            this.DgvListado.TabIndex = 2;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(461, 340);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(49, 18);
            this.LblTotal.TabIndex = 4;
            this.LblTotal.Text = "Total:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LblTotal);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Controls.Add(this.ChkSeleccionar);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.TxtBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1040, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.Thistle;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnBuscar.Location = new System.Drawing.Point(528, 13);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(101, 29);
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TabPrincipal
            // 
            this.TabPrincipal.Controls.Add(this.tabPage1);
            this.TabPrincipal.Controls.Add(this.tabPage2);
            this.TabPrincipal.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPrincipal.Location = new System.Drawing.Point(0, 119);
            this.TabPrincipal.Name = "TabPrincipal";
            this.TabPrincipal.SelectedIndex = 0;
            this.TabPrincipal.Size = new System.Drawing.Size(1048, 593);
            this.TabPrincipal.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÓDULO ARTÍCULOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 99);
            this.panel1.TabIndex = 7;
            // 
            // FrmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 832);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnDesactivar);
            this.Controls.Add(this.TabPrincipal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnActivar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnEliminar);
            this.Name = "FrmArticulo";
            this.Text = "Módulo Categorías";
            this.Load += new System.EventHandler(this.FrmArticulo_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.TabPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button BtnDesactivar;
        private System.Windows.Forms.Button BtnActivar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox ChkSeleccionar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TabControl TabPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PnlCodigo;
        private System.Windows.Forms.Button BtnguardarCodigo;
        private System.Windows.Forms.Button BtngenerarCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PicImagen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Button btnImagen;
    }
}