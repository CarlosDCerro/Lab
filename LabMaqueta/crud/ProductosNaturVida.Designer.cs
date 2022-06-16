namespace crud
{
    partial class frmProductosNaturVida
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
            this.lbTittleProductosNaturVida = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLimpiarIngresar = new System.Windows.Forms.Button();
            this.btnGuardarIngresar = new System.Windows.Forms.Button();
            this.txtCantidadIngresar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorIngresar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescIngresar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoIngresar = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridProductos = new System.Windows.Forms.DataGridView();
            this.proCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultarCons = new System.Windows.Forms.Button();
            this.cmbProductoConsultar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnConsultarMod = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtCantidadMod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorMod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescMod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodidoMod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbProductoModificar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmbProductoEliminar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTittleProductosNaturVida
            // 
            this.lbTittleProductosNaturVida.AutoEllipsis = true;
            this.lbTittleProductosNaturVida.AutoSize = true;
            this.lbTittleProductosNaturVida.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTittleProductosNaturVida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTittleProductosNaturVida.Location = new System.Drawing.Point(187, 9);
            this.lbTittleProductosNaturVida.Name = "lbTittleProductosNaturVida";
            this.lbTittleProductosNaturVida.Size = new System.Drawing.Size(341, 41);
            this.lbTittleProductosNaturVida.TabIndex = 1;
            this.lbTittleProductosNaturVida.Text = "Gestión de Productos";
            this.lbTittleProductosNaturVida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(691, 385);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLimpiarIngresar);
            this.tabPage1.Controls.Add(this.btnGuardarIngresar);
            this.tabPage1.Controls.Add(this.txtCantidadIngresar);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtValorIngresar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtDescIngresar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtCodigoIngresar);
            this.tabPage1.Controls.Add(this.lblUser);
            this.tabPage1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(683, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresar producto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarIngresar
            // 
            this.btnLimpiarIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLimpiarIngresar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiarIngresar.ForeColor = System.Drawing.Color.Green;
            this.btnLimpiarIngresar.Location = new System.Drawing.Point(375, 280);
            this.btnLimpiarIngresar.Name = "btnLimpiarIngresar";
            this.btnLimpiarIngresar.Size = new System.Drawing.Size(92, 26);
            this.btnLimpiarIngresar.TabIndex = 13;
            this.btnLimpiarIngresar.Text = "Limpiar";
            this.btnLimpiarIngresar.UseVisualStyleBackColor = false;
            this.btnLimpiarIngresar.Click += new System.EventHandler(this.btnLimpiarIngresar_Click);
            // 
            // btnGuardarIngresar
            // 
            this.btnGuardarIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuardarIngresar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarIngresar.ForeColor = System.Drawing.Color.Green;
            this.btnGuardarIngresar.Location = new System.Drawing.Point(236, 280);
            this.btnGuardarIngresar.Name = "btnGuardarIngresar";
            this.btnGuardarIngresar.Size = new System.Drawing.Size(92, 26);
            this.btnGuardarIngresar.TabIndex = 12;
            this.btnGuardarIngresar.Text = "Guardar";
            this.btnGuardarIngresar.UseVisualStyleBackColor = false;
            this.btnGuardarIngresar.Click += new System.EventHandler(this.btnGuardarIngresar_Click);
            // 
            // txtCantidadIngresar
            // 
            this.txtCantidadIngresar.Location = new System.Drawing.Point(202, 206);
            this.txtCantidadIngresar.Name = "txtCantidadIngresar";
            this.txtCantidadIngresar.Size = new System.Drawing.Size(297, 25);
            this.txtCantidadIngresar.TabIndex = 11;
            this.txtCantidadIngresar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadIngresar_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(92, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtValorIngresar
            // 
            this.txtValorIngresar.Location = new System.Drawing.Point(202, 158);
            this.txtValorIngresar.Name = "txtValorIngresar";
            this.txtValorIngresar.Size = new System.Drawing.Size(297, 25);
            this.txtValorIngresar.TabIndex = 9;
            this.txtValorIngresar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorIngresar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(131, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescIngresar
            // 
            this.txtDescIngresar.Location = new System.Drawing.Point(202, 108);
            this.txtDescIngresar.Name = "txtDescIngresar";
            this.txtDescIngresar.Size = new System.Drawing.Size(297, 25);
            this.txtDescIngresar.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(71, 108);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(130, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descripción:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigoIngresar
            // 
            this.txtCodigoIngresar.Location = new System.Drawing.Point(202, 60);
            this.txtCodigoIngresar.Name = "txtCodigoIngresar";
            this.txtCodigoIngresar.Size = new System.Drawing.Size(297, 25);
            this.txtCodigoIngresar.TabIndex = 5;
            // 
            // lblUser
            // 
            this.lblUser.AutoEllipsis = true;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(116, 59);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(85, 26);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Código:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridProductos);
            this.tabPage2.Controls.Add(this.btnConsultarCons);
            this.tabPage2.Controls.Add(this.cmbProductoConsultar);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(683, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar producto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridProductos
            // 
            this.dataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proCodigo,
            this.proDescripcion,
            this.proValor,
            this.proCantidad});
            this.dataGridProductos.Location = new System.Drawing.Point(6, 76);
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.RowTemplate.Height = 25;
            this.dataGridProductos.Size = new System.Drawing.Size(671, 267);
            this.dataGridProductos.TabIndex = 14;
            this.dataGridProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProductos_CellContentClick);
            // 
            // proCodigo
            // 
            this.proCodigo.HeaderText = "Código";
            this.proCodigo.Name = "proCodigo";
            // 
            // proDescripcion
            // 
            this.proDescripcion.HeaderText = "Descripción";
            this.proDescripcion.Name = "proDescripcion";
            this.proDescripcion.Width = 230;
            // 
            // proValor
            // 
            this.proValor.HeaderText = "Valor";
            this.proValor.Name = "proValor";
            this.proValor.Width = 130;
            // 
            // proCantidad
            // 
            this.proCantidad.HeaderText = "Cantidad";
            this.proCantidad.Name = "proCantidad";
            this.proCantidad.Width = 150;
            // 
            // btnConsultarCons
            // 
            this.btnConsultarCons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConsultarCons.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarCons.ForeColor = System.Drawing.Color.Green;
            this.btnConsultarCons.Location = new System.Drawing.Point(540, 25);
            this.btnConsultarCons.Name = "btnConsultarCons";
            this.btnConsultarCons.Size = new System.Drawing.Size(92, 26);
            this.btnConsultarCons.TabIndex = 13;
            this.btnConsultarCons.Text = "Consultar";
            this.btnConsultarCons.UseVisualStyleBackColor = false;
            this.btnConsultarCons.Click += new System.EventHandler(this.btnConsultarCons_Click);
            // 
            // cmbProductoConsultar
            // 
            this.cmbProductoConsultar.FormattingEnabled = true;
            this.cmbProductoConsultar.Location = new System.Drawing.Point(171, 24);
            this.cmbProductoConsultar.Name = "cmbProductoConsultar";
            this.cmbProductoConsultar.Size = new System.Drawing.Size(363, 31);
            this.cmbProductoConsultar.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(57, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Producto:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnConsultarMod);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.txtCantidadMod);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtValorMod);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtDescMod);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtCodidoMod);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.cmbProductoModificar);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(683, 349);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificar producto";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnConsultarMod
            // 
            this.btnConsultarMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConsultarMod.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarMod.ForeColor = System.Drawing.Color.Green;
            this.btnConsultarMod.Location = new System.Drawing.Point(545, 27);
            this.btnConsultarMod.Name = "btnConsultarMod";
            this.btnConsultarMod.Size = new System.Drawing.Size(92, 26);
            this.btnConsultarMod.TabIndex = 25;
            this.btnConsultarMod.Text = "Consultar";
            this.btnConsultarMod.UseVisualStyleBackColor = false;
            this.btnConsultarMod.Click += new System.EventHandler(this.btnConsultarMod_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(292, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 26);
            this.button3.TabIndex = 24;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCantidadMod
            // 
            this.txtCantidadMod.Location = new System.Drawing.Point(197, 228);
            this.txtCantidadMod.Name = "txtCantidadMod";
            this.txtCantidadMod.Size = new System.Drawing.Size(297, 31);
            this.txtCantidadMod.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(87, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 26);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cantidad:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtValorMod
            // 
            this.txtValorMod.Location = new System.Drawing.Point(197, 180);
            this.txtValorMod.Name = "txtValorMod";
            this.txtValorMod.Size = new System.Drawing.Size(297, 31);
            this.txtValorMod.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(126, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 26);
            this.label8.TabIndex = 20;
            this.label8.Text = "Valor:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescMod
            // 
            this.txtDescMod.Location = new System.Drawing.Point(197, 130);
            this.txtDescMod.Name = "txtDescMod";
            this.txtDescMod.Size = new System.Drawing.Size(297, 31);
            this.txtDescMod.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(66, 130);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(130, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = "Descripción:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodidoMod
            // 
            this.txtCodidoMod.Location = new System.Drawing.Point(197, 82);
            this.txtCodidoMod.Name = "txtCodidoMod";
            this.txtCodidoMod.Size = new System.Drawing.Size(297, 31);
            this.txtCodidoMod.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(111, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 26);
            this.label10.TabIndex = 16;
            this.label10.Text = "Código:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbProductoModificar
            // 
            this.cmbProductoModificar.FormattingEnabled = true;
            this.cmbProductoModificar.Items.AddRange(new object[] {
            "Aceite de Almendras",
            "Caléndula",
            "Embrión de Pato",
            "Lecitina de Soya",
            "Omega 3",
            "Té Verde",
            "Valeriana",
            "Vitamina C",
            "Vitamina E"});
            this.cmbProductoModificar.Location = new System.Drawing.Point(140, 24);
            this.cmbProductoModificar.Name = "cmbProductoModificar";
            this.cmbProductoModificar.Size = new System.Drawing.Size(383, 31);
            this.cmbProductoModificar.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Producto:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnEliminar);
            this.tabPage4.Controls.Add(this.cmbProductoEliminar);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(683, 349);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eliminar producto";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.Green;
            this.btnEliminar.Location = new System.Drawing.Point(532, 24);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 26);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cmbProductoEliminar
            // 
            this.cmbProductoEliminar.FormattingEnabled = true;
            this.cmbProductoEliminar.Items.AddRange(new object[] {
            "Aceite de Almendras",
            "Caléndula",
            "Embrión de Pato",
            "Lecitina de Soya",
            "Omega 3",
            "Té Verde",
            "Valeriana",
            "Vitamina C",
            "Vitamina E"});
            this.cmbProductoEliminar.Location = new System.Drawing.Point(140, 23);
            this.cmbProductoEliminar.Name = "cmbProductoEliminar";
            this.cmbProductoEliminar.Size = new System.Drawing.Size(372, 31);
            this.cmbProductoEliminar.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Producto:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmProductosNaturVida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 458);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbTittleProductosNaturVida);
            this.Name = "frmProductosNaturVida";
            this.Text = "Productos NaturVida";
            this.Load += new System.EventHandler(this.frmProductosNaturVida_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTittleProductosNaturVida;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox txtCantidadIngresar;
        private Label label3;
        private TextBox txtValorIngresar;
        private Label label2;
        private TextBox txtDescIngresar;
        private Label label1;
        private TextBox txtCodigoIngresar;
        private Label lblUser;
        private Button btnLimpiarIngresar;
        private Button btnGuardarIngresar;
        private ComboBox cmbProductoConsultar;
        private Label label4;
        private Button btnConsultarCons;
        private DataGridView dataGridProductos;
        private ComboBox cmbProductoModificar;
        private Label label5;
        private ComboBox cmbProductoEliminar;
        private Label label6;
        private Button btnConsultarMod;
        private Button button3;
        private TextBox txtCantidadMod;
        private Label label7;
        private TextBox txtValorMod;
        private Label label8;
        private TextBox txtDescMod;
        private Label label9;
        private TextBox txtCodidoMod;
        private Label label10;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn proCodigo;
        private DataGridViewTextBoxColumn proDescripcion;
        private DataGridViewTextBoxColumn proValor;
        private DataGridViewTextBoxColumn proCantidad;
    }
}