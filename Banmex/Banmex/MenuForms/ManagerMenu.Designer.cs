namespace Banmex.Menu
{
    partial class ManagerMenu
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
            this.showEmployeeButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.addClientButton = new System.Windows.Forms.Button();
            this.showClientButton = new System.Windows.Forms.Button();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.retrieveEmployeesButton = new System.Windows.Forms.Button();
            this.retrieveClientsButton = new System.Windows.Forms.Button();
            this.transactionsLabel = new System.Windows.Forms.Label();
            this.addTransactionButton = new System.Windows.Forms.Button();
            this.cancelTransactionButton = new System.Windows.Forms.Button();
            this.showTransactionButton = new System.Windows.Forms.Button();
            this.depositLabel = new System.Windows.Forms.Label();
            this.addDepositButton = new System.Windows.Forms.Button();
            this.showDepositButton = new System.Windows.Forms.Button();
            this.cancelDepositButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showEmployeeButton
            // 
            this.showEmployeeButton.Location = new System.Drawing.Point(12, 130);
            this.showEmployeeButton.Name = "showEmployeeButton";
            this.showEmployeeButton.Size = new System.Drawing.Size(149, 72);
            this.showEmployeeButton.TabIndex = 0;
            this.showEmployeeButton.Text = "Ver";
            this.showEmployeeButton.UseVisualStyleBackColor = true;
            this.showEmployeeButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(12, 34);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(149, 76);
            this.addEmployeeButton.TabIndex = 1;
            this.addEmployeeButton.Text = "Agregar";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // addClientButton
            // 
            this.addClientButton.Location = new System.Drawing.Point(180, 34);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(150, 76);
            this.addClientButton.TabIndex = 5;
            this.addClientButton.Text = "Agregar";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // showClientButton
            // 
            this.showClientButton.Location = new System.Drawing.Point(180, 130);
            this.showClientButton.Name = "showClientButton";
            this.showClientButton.Size = new System.Drawing.Size(150, 72);
            this.showClientButton.TabIndex = 4;
            this.showClientButton.Text = "Ver";
            this.showClientButton.UseVisualStyleBackColor = true;
            this.showClientButton.Click += new System.EventHandler(this.showClientButton_Click);
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.BackColor = System.Drawing.Color.Transparent;
            this.employeeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.employeeLabel.Location = new System.Drawing.Point(47, 9);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(78, 17);
            this.employeeLabel.TabIndex = 8;
            this.employeeLabel.Text = "Empleados";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.BackColor = System.Drawing.Color.Transparent;
            this.clientLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clientLabel.Location = new System.Drawing.Point(224, 9);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(58, 17);
            this.clientLabel.TabIndex = 9;
            this.clientLabel.Text = "Clientes";
            // 
            // retrieveEmployeesButton
            // 
            this.retrieveEmployeesButton.Location = new System.Drawing.Point(12, 222);
            this.retrieveEmployeesButton.Name = "retrieveEmployeesButton";
            this.retrieveEmployeesButton.Size = new System.Drawing.Size(149, 72);
            this.retrieveEmployeesButton.TabIndex = 10;
            this.retrieveEmployeesButton.Text = "Recuperar";
            this.retrieveEmployeesButton.UseVisualStyleBackColor = true;
            this.retrieveEmployeesButton.Click += new System.EventHandler(this.retrieveButton_Click);
            // 
            // retrieveClientsButton
            // 
            this.retrieveClientsButton.Location = new System.Drawing.Point(181, 222);
            this.retrieveClientsButton.Name = "retrieveClientsButton";
            this.retrieveClientsButton.Size = new System.Drawing.Size(149, 72);
            this.retrieveClientsButton.TabIndex = 11;
            this.retrieveClientsButton.Text = "Recuperar";
            this.retrieveClientsButton.UseVisualStyleBackColor = true;
            this.retrieveClientsButton.Click += new System.EventHandler(this.retrieveClientsButton_Click);
            // 
            // transactionsLabel
            // 
            this.transactionsLabel.AutoSize = true;
            this.transactionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.transactionsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.transactionsLabel.Location = new System.Drawing.Point(375, 9);
            this.transactionsLabel.Name = "transactionsLabel";
            this.transactionsLabel.Size = new System.Drawing.Size(101, 17);
            this.transactionsLabel.TabIndex = 12;
            this.transactionsLabel.Text = "Transacciones";
            // 
            // addTransactionButton
            // 
            this.addTransactionButton.Location = new System.Drawing.Point(353, 34);
            this.addTransactionButton.Name = "addTransactionButton";
            this.addTransactionButton.Size = new System.Drawing.Size(150, 76);
            this.addTransactionButton.TabIndex = 13;
            this.addTransactionButton.Text = "Realizar";
            this.addTransactionButton.UseVisualStyleBackColor = true;
            this.addTransactionButton.Click += new System.EventHandler(this.addTransactionButton_Click);
            // 
            // cancelTransactionButton
            // 
            this.cancelTransactionButton.Location = new System.Drawing.Point(353, 218);
            this.cancelTransactionButton.Name = "cancelTransactionButton";
            this.cancelTransactionButton.Size = new System.Drawing.Size(150, 76);
            this.cancelTransactionButton.TabIndex = 14;
            this.cancelTransactionButton.Text = "Canceladas";
            this.cancelTransactionButton.UseVisualStyleBackColor = true;
            this.cancelTransactionButton.Click += new System.EventHandler(this.cancelTransactionButton_Click);
            // 
            // showTransactionButton
            // 
            this.showTransactionButton.Location = new System.Drawing.Point(353, 126);
            this.showTransactionButton.Name = "showTransactionButton";
            this.showTransactionButton.Size = new System.Drawing.Size(150, 76);
            this.showTransactionButton.TabIndex = 15;
            this.showTransactionButton.Text = "Ver";
            this.showTransactionButton.UseVisualStyleBackColor = true;
            this.showTransactionButton.Click += new System.EventHandler(this.showTransactionButton_Click);
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.BackColor = System.Drawing.Color.Transparent;
            this.depositLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.depositLabel.Location = new System.Drawing.Point(560, 9);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(78, 17);
            this.depositLabel.TabIndex = 16;
            this.depositLabel.Text = "Despositos";
            // 
            // addDepositButton
            // 
            this.addDepositButton.Location = new System.Drawing.Point(526, 34);
            this.addDepositButton.Name = "addDepositButton";
            this.addDepositButton.Size = new System.Drawing.Size(150, 76);
            this.addDepositButton.TabIndex = 17;
            this.addDepositButton.Text = "Realizar";
            this.addDepositButton.UseVisualStyleBackColor = true;
            this.addDepositButton.Click += new System.EventHandler(this.addDepositButton_Click);
            // 
            // showDepositButton
            // 
            this.showDepositButton.Location = new System.Drawing.Point(526, 128);
            this.showDepositButton.Name = "showDepositButton";
            this.showDepositButton.Size = new System.Drawing.Size(150, 76);
            this.showDepositButton.TabIndex = 19;
            this.showDepositButton.Text = "Ver";
            this.showDepositButton.UseVisualStyleBackColor = true;
            this.showDepositButton.Click += new System.EventHandler(this.showDepositButton_Click);
            // 
            // cancelDepositButton
            // 
            this.cancelDepositButton.Location = new System.Drawing.Point(526, 220);
            this.cancelDepositButton.Name = "cancelDepositButton";
            this.cancelDepositButton.Size = new System.Drawing.Size(150, 76);
            this.cancelDepositButton.TabIndex = 18;
            this.cancelDepositButton.Text = "Canceladas";
            this.cancelDepositButton.UseVisualStyleBackColor = true;
            this.cancelDepositButton.Click += new System.EventHandler(this.cancelDepositButton_Click);
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 306);
            this.Controls.Add(this.showDepositButton);
            this.Controls.Add(this.cancelDepositButton);
            this.Controls.Add(this.addDepositButton);
            this.Controls.Add(this.depositLabel);
            this.Controls.Add(this.showTransactionButton);
            this.Controls.Add(this.cancelTransactionButton);
            this.Controls.Add(this.addTransactionButton);
            this.Controls.Add(this.transactionsLabel);
            this.Controls.Add(this.retrieveClientsButton);
            this.Controls.Add(this.retrieveEmployeesButton);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.showClientButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.showEmployeeButton);
            this.Name = "ManagerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showEmployeeButton;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Button showClientButton;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Button retrieveEmployeesButton;
        private System.Windows.Forms.Button retrieveClientsButton;
        private System.Windows.Forms.Label transactionsLabel;
        private System.Windows.Forms.Button addTransactionButton;
        private System.Windows.Forms.Button cancelTransactionButton;
        private System.Windows.Forms.Button showTransactionButton;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.Button addDepositButton;
        private System.Windows.Forms.Button showDepositButton;
        private System.Windows.Forms.Button cancelDepositButton;
    }
}