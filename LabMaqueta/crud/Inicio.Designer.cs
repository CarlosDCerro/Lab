namespace crud
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTittle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblErrorUsrInvalido = new System.Windows.Forms.Label();
            this.lblErrorUsrVacio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTittle
            // 
            this.lbTittle.AutoEllipsis = true;
            this.lbTittle.AutoSize = true;
            this.lbTittle.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTittle.Location = new System.Drawing.Point(82, 27);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(454, 82);
            this.lbTittle.TabIndex = 0;
            this.lbTittle.Text = "Sistema de Información \r\nTienda Naturista NaturVida";
            this.lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.AutoEllipsis = true;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(75, 152);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(92, 26);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Usuario:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoEllipsis = true;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(36, 191);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(131, 26);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Contraseña:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(173, 153);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(271, 25);
            this.txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(173, 191);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(271, 25);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIngresar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.ForeColor = System.Drawing.Color.Green;
            this.btnIngresar.Location = new System.Drawing.Point(268, 256);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(92, 26);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblErrorUsrInvalido
            // 
            this.lblErrorUsrInvalido.AutoEllipsis = true;
            this.lblErrorUsrInvalido.AutoSize = true;
            this.lblErrorUsrInvalido.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrorUsrInvalido.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUsrInvalido.Location = new System.Drawing.Point(146, 238);
            this.lblErrorUsrInvalido.Name = "lblErrorUsrInvalido";
            this.lblErrorUsrInvalido.Size = new System.Drawing.Size(343, 15);
            this.lblErrorUsrInvalido.TabIndex = 6;
            this.lblErrorUsrInvalido.Text = "Por favor valida que el usuario y la contraseña sean los correctos.";
            this.lblErrorUsrInvalido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorUsrInvalido.Visible = false;
            // 
            // lblErrorUsrVacio
            // 
            this.lblErrorUsrVacio.AutoEllipsis = true;
            this.lblErrorUsrVacio.AutoSize = true;
            this.lblErrorUsrVacio.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrorUsrVacio.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUsrVacio.Location = new System.Drawing.Point(60, 238);
            this.lblErrorUsrVacio.Name = "lblErrorUsrVacio";
            this.lblErrorUsrVacio.Size = new System.Drawing.Size(509, 15);
            this.lblErrorUsrVacio.TabIndex = 7;
            this.lblErrorUsrVacio.Text = "No puede ingresar sin verificar usuario y contraseña. Por favor ingrese los datos" +
    " correspondientes.";
            this.lblErrorUsrVacio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorUsrVacio.Visible = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 303);
            this.Controls.Add(this.lblErrorUsrInvalido);
            this.Controls.Add(this.lblErrorUsrVacio);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lbTittle);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTittle;
        private Label lblUser;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnIngresar;
        private Label lblErrorUsrInvalido;
        private Label lblErrorUsrVacio;
        public TextBox txtUser;
    }
}