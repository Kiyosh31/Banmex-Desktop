namespace Banmex.Menu
{
    partial class ShowClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowClients));
            this.clientsGridView = new System.Windows.Forms.DataGridView();
            this.modifyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.deleteAccountButton = new System.Windows.Forms.Button();
            this.modifyAccountButton = new System.Windows.Forms.Button();
            this.accountdGridView = new System.Windows.Forms.DataGridView();
            this.accountsLabel = new System.Windows.Forms.Label();
            this.clientsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountdGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientsGridView
            // 
            this.clientsGridView.AllowUserToAddRows = false;
            this.clientsGridView.AllowUserToDeleteRows = false;
            this.clientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsGridView.Location = new System.Drawing.Point(12, 46);
            this.clientsGridView.Name = "clientsGridView";
            this.clientsGridView.ReadOnly = true;
            this.clientsGridView.RowTemplate.Height = 24;
            this.clientsGridView.Size = new System.Drawing.Size(597, 436);
            this.clientsGridView.TabIndex = 0;
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(218, 501);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(147, 68);
            this.modifyButton.TabIndex = 1;
            this.modifyButton.Text = "Modificar Cliente";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(393, 503);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(157, 65);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Eliminar Cliente";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addAccountButton
            // 
            this.addAccountButton.Location = new System.Drawing.Point(52, 501);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(147, 68);
            this.addAccountButton.TabIndex = 3;
            this.addAccountButton.Text = "Agregar Cuenta";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Click += new System.EventHandler(this.addAccount_Click);
            // 
            // deleteAccountButton
            // 
            this.deleteAccountButton.Location = new System.Drawing.Point(951, 501);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.Size = new System.Drawing.Size(157, 65);
            this.deleteAccountButton.TabIndex = 8;
            this.deleteAccountButton.Text = "Eliminar Cuenta";
            this.deleteAccountButton.UseVisualStyleBackColor = true;
            this.deleteAccountButton.Click += new System.EventHandler(this.deleteAccountButton_Click);
            // 
            // modifyAccountButton
            // 
            this.modifyAccountButton.Location = new System.Drawing.Point(776, 499);
            this.modifyAccountButton.Name = "modifyAccountButton";
            this.modifyAccountButton.Size = new System.Drawing.Size(147, 68);
            this.modifyAccountButton.TabIndex = 7;
            this.modifyAccountButton.Text = "Modificar Cuenta";
            this.modifyAccountButton.UseVisualStyleBackColor = true;
            this.modifyAccountButton.Click += new System.EventHandler(this.modifyAccountButton_Click);
            // 
            // accountdGridView
            // 
            this.accountdGridView.AllowUserToAddRows = false;
            this.accountdGridView.AllowUserToDeleteRows = false;
            this.accountdGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountdGridView.Location = new System.Drawing.Point(615, 46);
            this.accountdGridView.Name = "accountdGridView";
            this.accountdGridView.ReadOnly = true;
            this.accountdGridView.RowTemplate.Height = 24;
            this.accountdGridView.Size = new System.Drawing.Size(583, 436);
            this.accountdGridView.TabIndex = 4;
            // 
            // accountsLabel
            // 
            this.accountsLabel.AutoSize = true;
            this.accountsLabel.BackColor = System.Drawing.Color.Transparent;
            this.accountsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.accountsLabel.Location = new System.Drawing.Point(905, 13);
            this.accountsLabel.Name = "accountsLabel";
            this.accountsLabel.Size = new System.Drawing.Size(60, 17);
            this.accountsLabel.TabIndex = 6;
            this.accountsLabel.Text = "Cuentas";
            // 
            // clientsLabel
            // 
            this.clientsLabel.AutoSize = true;
            this.clientsLabel.BackColor = System.Drawing.Color.Transparent;
            this.clientsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clientsLabel.Location = new System.Drawing.Point(239, 13);
            this.clientsLabel.Name = "clientsLabel";
            this.clientsLabel.Size = new System.Drawing.Size(58, 17);
            this.clientsLabel.TabIndex = 5;
            this.clientsLabel.Text = "Clientes";
            // 
            // ShowClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1210, 581);
            this.Controls.Add(this.deleteAccountButton);
            this.Controls.Add(this.modifyAccountButton);
            this.Controls.Add(this.accountsLabel);
            this.Controls.Add(this.clientsLabel);
            this.Controls.Add(this.accountdGridView);
            this.Controls.Add(this.addAccountButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.clientsGridView);
            this.Name = "ShowClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Clientes BANMEX";
            this.Load += new System.EventHandler(this.ShowClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountdGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clientsGridView;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.Button deleteAccountButton;
        private System.Windows.Forms.Button modifyAccountButton;
        private System.Windows.Forms.DataGridView accountdGridView;
        private System.Windows.Forms.Label accountsLabel;
        private System.Windows.Forms.Label clientsLabel;
    }
}