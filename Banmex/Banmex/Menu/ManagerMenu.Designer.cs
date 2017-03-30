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
            this.employeesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeesButton
            // 
            this.employeesButton.Location = new System.Drawing.Point(12, 48);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(129, 54);
            this.employeesButton.TabIndex = 0;
            this.employeesButton.Text = "Ver Empleados";
            this.employeesButton.UseVisualStyleBackColor = true;
            this.employeesButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 399);
            this.Controls.Add(this.employeesButton);
            this.Name = "ManagerMenu";
            this.Text = "Menu Administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button employeesButton;
    }
}