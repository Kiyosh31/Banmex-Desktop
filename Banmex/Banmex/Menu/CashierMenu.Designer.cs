namespace Banmex.Menu
{
    partial class CashierMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierMenu));
            this.addClientButton = new System.Windows.Forms.Button();
            this.clientLabel = new System.Windows.Forms.Label();
            this.showClientButton = new System.Windows.Forms.Button();
            this.retrieveClientsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addClientButton
            // 
            this.addClientButton.Location = new System.Drawing.Point(106, 49);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(127, 52);
            this.addClientButton.TabIndex = 0;
            this.addClientButton.Text = "Agregar";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.BackColor = System.Drawing.Color.Transparent;
            this.clientLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientLabel.Location = new System.Drawing.Point(140, 9);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(51, 17);
            this.clientLabel.TabIndex = 1;
            this.clientLabel.Text = "Cliente";
            // 
            // showClientButton
            // 
            this.showClientButton.Location = new System.Drawing.Point(106, 120);
            this.showClientButton.Name = "showClientButton";
            this.showClientButton.Size = new System.Drawing.Size(127, 52);
            this.showClientButton.TabIndex = 2;
            this.showClientButton.Text = "Ver";
            this.showClientButton.UseVisualStyleBackColor = true;
            this.showClientButton.Click += new System.EventHandler(this.showClientButton_Click);
            // 
            // retrieveClientsButton
            // 
            this.retrieveClientsButton.Location = new System.Drawing.Point(106, 188);
            this.retrieveClientsButton.Name = "retrieveClientsButton";
            this.retrieveClientsButton.Size = new System.Drawing.Size(127, 52);
            this.retrieveClientsButton.TabIndex = 3;
            this.retrieveClientsButton.Text = "Recuperar";
            this.retrieveClientsButton.UseVisualStyleBackColor = true;
            this.retrieveClientsButton.Click += new System.EventHandler(this.retrieveClientsButton_Click);
            // 
            // CashierMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(343, 312);
            this.Controls.Add(this.retrieveClientsButton);
            this.Controls.Add(this.showClientButton);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.addClientButton);
            this.Name = "CashierMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Cajero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Button showClientButton;
        private System.Windows.Forms.Button retrieveClientsButton;
    }
}