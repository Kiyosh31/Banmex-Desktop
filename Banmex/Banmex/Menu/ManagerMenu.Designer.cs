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
            this.modifyEmployeeButton = new System.Windows.Forms.Button();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.deleteClientButton = new System.Windows.Forms.Button();
            this.modifyClientButton = new System.Windows.Forms.Button();
            this.addClientButton = new System.Windows.Forms.Button();
            this.showClientButton = new System.Windows.Forms.Button();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showEmployeeButton
            // 
            this.showEmployeeButton.Location = new System.Drawing.Point(12, 103);
            this.showEmployeeButton.Name = "showEmployeeButton";
            this.showEmployeeButton.Size = new System.Drawing.Size(129, 54);
            this.showEmployeeButton.TabIndex = 0;
            this.showEmployeeButton.Text = "Ver";
            this.showEmployeeButton.UseVisualStyleBackColor = true;
            this.showEmployeeButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(12, 34);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(129, 54);
            this.addEmployeeButton.TabIndex = 1;
            this.addEmployeeButton.Text = "Agregar";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // modifyEmployeeButton
            // 
            this.modifyEmployeeButton.Location = new System.Drawing.Point(12, 175);
            this.modifyEmployeeButton.Name = "modifyEmployeeButton";
            this.modifyEmployeeButton.Size = new System.Drawing.Size(129, 54);
            this.modifyEmployeeButton.TabIndex = 2;
            this.modifyEmployeeButton.Text = "Modificar ";
            this.modifyEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.Location = new System.Drawing.Point(12, 248);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(129, 54);
            this.deleteEmployeeButton.TabIndex = 3;
            this.deleteEmployeeButton.Text = "Eliminar";
            this.deleteEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // deleteClientButton
            // 
            this.deleteClientButton.Location = new System.Drawing.Point(201, 248);
            this.deleteClientButton.Name = "deleteClientButton";
            this.deleteClientButton.Size = new System.Drawing.Size(129, 54);
            this.deleteClientButton.TabIndex = 7;
            this.deleteClientButton.Text = "Eliminar";
            this.deleteClientButton.UseVisualStyleBackColor = true;
            // 
            // modifyClientButton
            // 
            this.modifyClientButton.Location = new System.Drawing.Point(201, 175);
            this.modifyClientButton.Name = "modifyClientButton";
            this.modifyClientButton.Size = new System.Drawing.Size(129, 54);
            this.modifyClientButton.TabIndex = 6;
            this.modifyClientButton.Text = "Modificar";
            this.modifyClientButton.UseVisualStyleBackColor = true;
            // 
            // addClientButton
            // 
            this.addClientButton.Location = new System.Drawing.Point(201, 34);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(129, 54);
            this.addClientButton.TabIndex = 5;
            this.addClientButton.Text = "Agregar";
            this.addClientButton.UseVisualStyleBackColor = true;
            // 
            // showClientButton
            // 
            this.showClientButton.Location = new System.Drawing.Point(201, 103);
            this.showClientButton.Name = "showClientButton";
            this.showClientButton.Size = new System.Drawing.Size(129, 54);
            this.showClientButton.TabIndex = 4;
            this.showClientButton.Text = "Ver";
            this.showClientButton.UseVisualStyleBackColor = true;
            this.showClientButton.Click += new System.EventHandler(this.showClientButton_Click);
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Location = new System.Drawing.Point(38, 9);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(78, 17);
            this.employeeLabel.TabIndex = 8;
            this.employeeLabel.Text = "Empleados";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
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
            this.ClientSize = new System.Drawing.Size(342, 344);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.deleteClientButton);
            this.Controls.Add(this.modifyClientButton);
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.showClientButton);
            this.Controls.Add(this.deleteEmployeeButton);
            this.Controls.Add(this.modifyEmployeeButton);
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
        private System.Windows.Forms.Button modifyEmployeeButton;
        private System.Windows.Forms.Button deleteEmployeeButton;
        private System.Windows.Forms.Button deleteClientButton;
        private System.Windows.Forms.Button modifyClientButton;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Button showClientButton;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Label clientLabel;
    }
}