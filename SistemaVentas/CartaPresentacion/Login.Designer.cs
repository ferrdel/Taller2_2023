
namespace CartaPresentacion
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labUser = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.labPassw = new System.Windows.Forms.Label();
            this.btnIngresar = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 164);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(45, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistema de Ventas";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(72, 204);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(158, 20);
            this.txtUser.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(72, 261);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(158, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUser.Location = new System.Drawing.Point(46, 186);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(57, 15);
            this.labUser.TabIndex = 6;
            this.labUser.Text = "Usuario";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ShopLock;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 110;
            this.iconPictureBox1.Location = new System.Drawing.Point(66, 36);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(144, 110);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // labPassw
            // 
            this.labPassw.AutoSize = true;
            this.labPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassw.Location = new System.Drawing.Point(46, 243);
            this.labPassw.Name = "labPassw";
            this.labPassw.Size = new System.Drawing.Size(80, 15);
            this.labPassw.TabIndex = 8;
            this.labPassw.Text = "Contraseña";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.btnIngresar.IconColor = System.Drawing.Color.Black;
            this.btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngresar.IconSize = 20;
            this.btnIngresar.Location = new System.Drawing.Point(35, 320);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(86, 34);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnCancel.IconSize = 20;
            this.btnCancel.Location = new System.Drawing.Point(153, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 34);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(274, 374);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.labPassw);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.labUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labUser;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label labPassw;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnCancel;
    }
}