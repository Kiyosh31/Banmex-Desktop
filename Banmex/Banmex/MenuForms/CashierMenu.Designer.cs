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
            this.transactionsLabel = new System.Windows.Forms.Label();
            this.makeTransaction = new System.Windows.Forms.Button();
            this.showTransactionButton = new System.Windows.Forms.Button();
            this.depositsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.canceledTransactionButton = new System.Windows.Forms.Button();
            this.cancelDepositButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addClientButton
            // 
            this.addClientButton.Location = new System.Drawing.Point(72, 107);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(142, 65);
            this.addClientButton.TabIndex = 0;
            this.addClientButton.Text = "Agregar";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.BackColor = System.Drawing.Color.Transparent;
            this.clientLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clientLabel.Location = new System.Drawing.Point(121, 67);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(51, 17);
            this.clientLabel.TabIndex = 1;
            this.clientLabel.Text = "Cliente";
            // 
            // showClientButton
            // 
            this.showClientButton.Location = new System.Drawing.Point(72, 188);
            this.showClientButton.Name = "showClientButton";
            this.showClientButton.Size = new System.Drawing.Size(142, 65);
            this.showClientButton.TabIndex = 2;
            this.showClientButton.Text = "Ver";
            this.showClientButton.UseVisualStyleBackColor = true;
            this.showClientButton.Click += new System.EventHandler(this.showClientButton_Click);
            // 
            // retrieveClientsButton
            // 
            this.retrieveClientsButton.Location = new System.Drawing.Point(72, 269);
            this.retrieveClientsButton.Name = "retrieveClientsButton";
            this.retrieveClientsButton.Size = new System.Drawing.Size(142, 68);
            this.retrieveClientsButton.TabIndex = 3;
            this.retrieveClientsButton.Text = "Recuperar";
            this.retrieveClientsButton.UseVisualStyleBackColor = true;
            this.retrieveClientsButton.Click += new System.EventHandler(this.retrieveClientsButton_Click);
            // 
            // transactionsLabel
            // 
            this.transactionsLabel.AutoSize = true;
            this.transactionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.transactionsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.transactionsLabel.Location = new System.Drawing.Point(259, 67);
            this.transactionsLabel.Name = "transactionsLabel";
            this.transactionsLabel.Size = new System.Drawing.Size(101, 17);
            this.transactionsLabel.TabIndex = 4;
            this.transactionsLabel.Text = "Transacciones";
            // 
            // makeTransaction
            // 
            this.makeTransaction.Location = new System.Drawing.Point(242, 107);
            this.makeTransaction.Name = "makeTransaction";
            this.makeTransaction.Size = new System.Drawing.Size(142, 65);
            this.makeTransaction.TabIndex = 5;
            this.makeTransaction.Text = "Realizar";
            this.makeTransaction.UseVisualStyleBackColor = true;
            this.makeTransaction.Click += new System.EventHandler(this.makeTransaction_Click);
            // 
            // showTransactionButton
            // 
            this.showTransactionButton.Location = new System.Drawing.Point(242, 188);
            this.showTransactionButton.Name = "showTransactionButton";
            this.showTransactionButton.Size = new System.Drawing.Size(142, 65);
            this.showTransactionButton.TabIndex = 6;
            this.showTransactionButton.Text = "Ver";
            this.showTransactionButton.UseVisualStyleBackColor = true;
            this.showTransactionButton.Click += new System.EventHandler(this.cancelTransaction_Click);
            // 
            // depositsLabel
            // 
            this.depositsLabel.AutoSize = true;
            this.depositsLabel.BackColor = System.Drawing.Color.Transparent;
            this.depositsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.depositsLabel.Location = new System.Drawing.Point(452, 67);
            this.depositsLabel.Name = "depositsLabel";
            this.depositsLabel.Size = new System.Drawing.Size(71, 17);
            this.depositsLabel.TabIndex = 7;
            this.depositsLabel.Text = "Depositos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 65);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 65);
            this.button2.TabIndex = 8;
            this.button2.Text = "Realizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // canceledTransactionButton
            // 
            this.canceledTransactionButton.Location = new System.Drawing.Point(242, 270);
            this.canceledTransactionButton.Name = "canceledTransactionButton";
            this.canceledTransactionButton.Size = new System.Drawing.Size(142, 68);
            this.canceledTransactionButton.TabIndex = 10;
            this.canceledTransactionButton.Text = "Canceladas";
            this.canceledTransactionButton.UseVisualStyleBackColor = true;
            this.canceledTransactionButton.Click += new System.EventHandler(this.canceledTransactionButton_Click);
            // 
            // cancelDepositButton
            // 
            this.cancelDepositButton.Location = new System.Drawing.Point(411, 270);
            this.cancelDepositButton.Name = "cancelDepositButton";
            this.cancelDepositButton.Size = new System.Drawing.Size(142, 68);
            this.cancelDepositButton.TabIndex = 11;
            this.cancelDepositButton.Text = "Canceladas";
            this.cancelDepositButton.UseVisualStyleBackColor = true;
            this.cancelDepositButton.Click += new System.EventHandler(this.cancelDepositButton_Click);
            // 
            // CashierMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 350);
            this.Controls.Add(this.cancelDepositButton);
            this.Controls.Add(this.canceledTransactionButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.depositsLabel);
            this.Controls.Add(this.showTransactionButton);
            this.Controls.Add(this.makeTransaction);
            this.Controls.Add(this.transactionsLabel);
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
        private System.Windows.Forms.Label transactionsLabel;
        private System.Windows.Forms.Button makeTransaction;
        private System.Windows.Forms.Button showTransactionButton;
        private System.Windows.Forms.Label depositsLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button canceledTransactionButton;
        private System.Windows.Forms.Button cancelDepositButton;
    }
}