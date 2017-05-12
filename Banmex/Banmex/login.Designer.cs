namespace Banmex
{
    partial class login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.userTextbox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.userPicturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // userTextbox
            // 
            this.userTextbox.Location = new System.Drawing.Point(104, 213);
            this.userTextbox.Name = "userTextbox";
            this.userTextbox.Size = new System.Drawing.Size(213, 22);
            this.userTextbox.TabIndex = 0;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userLabel.Location = new System.Drawing.Point(101, 193);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(57, 17);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Usuario";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordLabel.Location = new System.Drawing.Point(101, 257);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(81, 17);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Contraseña";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(104, 277);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(213, 22);
            this.passwordTextbox.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(130, 327);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(150, 55);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Iniciar Sesión";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userPicturebox
            // 
            this.userPicturebox.BackColor = System.Drawing.Color.Transparent;
            this.userPicturebox.ErrorImage = null;
            this.userPicturebox.Image = global::Banmex.Properties.Resources.user_icon;
            this.userPicturebox.InitialImage = ((System.Drawing.Image)(resources.GetObject("userPicturebox.InitialImage")));
            this.userPicturebox.Location = new System.Drawing.Point(130, 24);
            this.userPicturebox.Name = "userPicturebox";
            this.userPicturebox.Size = new System.Drawing.Size(150, 144);
            this.userPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicturebox.TabIndex = 5;
            this.userPicturebox.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(404, 458);
            this.Controls.Add(this.userPicturebox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.userTextbox);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión BANMEX";
            ((System.ComponentModel.ISupportInitialize)(this.userPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userTextbox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox userPicturebox;
    }
}

