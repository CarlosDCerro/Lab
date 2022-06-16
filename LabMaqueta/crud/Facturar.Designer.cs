namespace crud
{
    partial class frmFacturar
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
            this.txtNumeroFact = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.cmbClienteFact = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPckrFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbProductoFact = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadFact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarProd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTotalFact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTerminarFact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTittleProductosNaturVida
            // 
            this.lbTittleProductosNaturVida.AutoEllipsis = true;
            this.lbTittleProductosNaturVida.AutoSize = true;
            this.lbTittleProductosNaturVida.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTittleProductosNaturVida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTittleProductosNaturVida.Location = new System.Drawing.Point(305, 9);
            this.lbTittleProductosNaturVida.Name = "lbTittleProductosNaturVida";
            this.lbTittleProductosNaturVida.Size = new System.Drawing.Size(203, 35);
            this.lbTittleProductosNaturVida.TabIndex = 2;
            this.lbTittleProductosNaturVida.Text = "Facturaración";
            this.lbTittleProductosNaturVida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumeroFact
            // 
            this.txtNumeroFact.Location = new System.Drawing.Point(133, 66);
            this.txtNumeroFact.Name = "txtNumeroFact";
            this.txtNumeroFact.Size = new System.Drawing.Size(333, 23);
            this.txtNumeroFact.TabIndex = 7;
            // 
            // lblUser
            // 
            this.lblUser.AutoEllipsis = true;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(28, 63);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(99, 26);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Número:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbClienteFact
            // 
            this.cmbClienteFact.FormattingEnabled = true;
            this.cmbClienteFact.Items.AddRange(new object[] {
            "Aceite de Almendras",
            "Caléndula",
            "Embrión de Pato",
            "Lecitina de Soya",
            "Omega 3",
            "Té Verde",
            "Valeriana",
            "Vitamina C",
            "Vitamina E"});
            this.cmbClienteFact.Location = new System.Drawing.Point(133, 106);
            this.cmbClienteFact.Name = "cmbClienteFact";
            this.cmbClienteFact.Size = new System.Drawing.Size(427, 23);
            this.cmbClienteFact.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(33, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Clientes:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(483, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtPckrFecha
            // 
            this.dtPckrFecha.Location = new System.Drawing.Point(566, 66);
            this.dtPckrFecha.Name = "dtPckrFecha";
            this.dtPckrFecha.Size = new System.Drawing.Size(222, 23);
            this.dtPckrFecha.TabIndex = 11;
            // 
            // cmbProductoFact
            // 
            this.cmbProductoFact.FormattingEnabled = true;
            this.cmbProductoFact.Items.AddRange(new object[] {
            "Aceite de Almendras",
            "Caléndula",
            "Embrión de Pato",
            "Lecitina de Soya",
            "Omega 3",
            "Té Verde",
            "Valeriana",
            "Vitamina C",
            "Vitamina E"});
            this.cmbProductoFact.Location = new System.Drawing.Point(133, 146);
            this.cmbProductoFact.Name = "cmbProductoFact";
            this.cmbProductoFact.Size = new System.Drawing.Size(333, 23);
            this.cmbProductoFact.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Productos:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCantidadFact
            // 
            this.txtCantidadFact.Location = new System.Drawing.Point(133, 186);
            this.txtCantidadFact.Name = "txtCantidadFact";
            this.txtCantidadFact.Size = new System.Drawing.Size(333, 23);
            this.txtCantidadFact.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cantidad:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregarProd.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarProd.ForeColor = System.Drawing.Color.Green;
            this.btnAgregarProd.Location = new System.Drawing.Point(641, 186);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(147, 26);
            this.btnAgregarProd.TabIndex = 16;
            this.btnAgregarProd.Text = "Agregar producto";
            this.btnAgregarProd.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(770, 174);
            this.dataGridView1.TabIndex = 17;
            // 
            // txtTotalFact
            // 
            this.txtTotalFact.Location = new System.Drawing.Point(455, 418);
            this.txtTotalFact.Name = "txtTotalFact";
            this.txtTotalFact.Size = new System.Drawing.Size(333, 23);
            this.txtTotalFact.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(305, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total factura:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTerminarFact
            // 
            this.btnTerminarFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTerminarFact.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTerminarFact.ForeColor = System.Drawing.Color.Green;
            this.btnTerminarFact.Location = new System.Drawing.Point(18, 417);
            this.btnTerminarFact.Name = "btnTerminarFact";
            this.btnTerminarFact.Size = new System.Drawing.Size(147, 26);
            this.btnTerminarFact.TabIndex = 20;
            this.btnTerminarFact.Text = "Terminar factura";
            this.btnTerminarFact.UseVisualStyleBackColor = false;
            // 
            // frmFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTerminarFact);
            this.Controls.Add(this.txtTotalFact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAgregarProd);
            this.Controls.Add(this.txtCantidadFact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProductoFact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtPckrFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClienteFact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumeroFact);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lbTittleProductosNaturVida);
            this.Name = "frmFacturar";
            this.Text = "Facturar";
            this.Load += new System.EventHandler(this.frmFacturar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTittleProductosNaturVida;
        private TextBox txtNumeroFact;
        private Label lblUser;
        private ComboBox cmbClienteFact;
        private Label label4;
        private Label label1;
        private DateTimePicker dtPckrFecha;
        private ComboBox cmbProductoFact;
        private Label label2;
        private TextBox txtCantidadFact;
        private Label label3;
        private Button btnAgregarProd;
        private DataGridView dataGridView1;
        private TextBox txtTotalFact;
        private Label label5;
        private Button btnTerminarFact;
    }
}