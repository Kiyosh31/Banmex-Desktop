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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMenu));
            this.showEmployeeButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.addClientButton = new System.Windows.Forms.Button();
            this.showClientButton = new System.Windows.Forms.Button();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
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
            this.employeeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeLabel.Location = new System.Drawing.Point(38, 9);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(78, 17);
            this.employeeLabel.TabIndex = 8;
            this.employeeLabel.Text = "Empleados";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.BackColor = System.Drawing.Color.Transparent;
            this.clientLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientLabel.Location = new System.Drawing.Point(236, 9);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(58, 17);
            this.clientLabel.TabIndex = 9;
            this.clientLabel.Text = "Clientes";
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(342, 242);
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
    }
}