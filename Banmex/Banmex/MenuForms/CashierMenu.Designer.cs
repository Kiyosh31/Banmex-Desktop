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
            this.addClientButton = new System.Windows.Forms.Button();
            this.clientLabel = new System.Windows.Forms.Label();
            this.showClientButton = new System.Windows.Forms.Button();
            this.retrieveClientsButton = new System.Windows.Forms.Button();
            this.transactionsLabel = new System.Windows.Forms.Label();
            this.makeTransaction = new System.Windows.Forms.Button();
            this.cancelTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addClientButton
            // 
            this.addClientButton.Location = new System.Drawing.Point(91, 70);
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
            this.clientLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clientLabel.Location = new System.Drawing.Point(140, 30);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(51, 17);
            this.clientLabel.TabIndex = 1;
            this.clientLabel.Text = "Cliente";
            // 
            // showClientButton
            // 
            this.showClientButton.Location = new System.Drawing.Point(91, 151);
            this.showClientButton.Name = "showClientButton";
            this.showClientButton.Size = new System.Drawing.Size(142, 65);
            this.showClientButton.TabIndex = 2;
            this.showClientButton.Text = "Ver";
            this.showClientButton.UseVisualStyleBackColor = true;
            this.showClientButton.Click += new System.EventHandler(this.showClientButton_Click);
            // 
            // retrieveClientsButton
            // 
            this.retrieveClientsButton.Location = new System.Drawing.Point(91, 232);
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
            this.transactionsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.transactionsLabel.Location = new System.Drawing.Point(319, 30);
            this.transactionsLabel.Name = "transactionsLabel";
            this.transactionsLabel.Size = new System.Drawing.Size(101, 17);
            this.transactionsLabel.TabIndex = 4;
            this.transactionsLabel.Text = "Transacciones";
            // 
            // makeTransaction
            // 
            this.makeTransaction.Location = new System.Drawing.Point(302, 70);
            this.makeTransaction.Name = "makeTransaction";
            this.makeTransaction.Size = new System.Drawing.Size(142, 65);
            this.makeTransaction.TabIndex = 5;
            this.makeTransaction.Text = "Realizar";
            this.makeTransaction.UseVisualStyleBackColor = true;
            this.makeTransaction.Click += new System.EventHandler(this.makeTransaction_Click);
            // 
            // cancelTransaction
            // 
            this.cancelTransaction.Location = new System.Drawing.Point(302, 151);
            this.cancelTransaction.Name = "cancelTransaction";
            this.cancelTransaction.Size = new System.Drawing.Size(142, 65);
            this.cancelTransaction.TabIndex = 6;
            this.cancelTransaction.Text = "Cancelar";
            this.cancelTransaction.UseVisualStyleBackColor = true;
            this.cancelTransaction.Click += new System.EventHandler(this.cancelTransaction_Click);
            // 
            // CashierMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 312);
            this.Controls.Add(this.cancelTransaction);
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
        private System.Windows.Forms.Button cancelTransaction;
    }
}