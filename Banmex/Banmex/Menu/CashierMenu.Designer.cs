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
            this.modifyClientButton = new System.Windows.Forms.Button();
            this.deleteClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addClientButton
            // 
            this.addClientButton.Location = new System.Drawing.Point(36, 49);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(127, 52);
            this.addClientButton.TabIndex = 0;
            this.addClientButton.Text = "Agregar";
            this.addClientButton.UseVisualStyleBackColor = true;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(70, 9);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(51, 17);
            this.clientLabel.TabIndex = 1;
            this.clientLabel.Text = "Cliente";
            // 
            // showClientButton
            // 
            this.showClientButton.Location = new System.Drawing.Point(36, 120);
            this.showClientButton.Name = "showClientButton";
            this.showClientButton.Size = new System.Drawing.Size(127, 52);
            this.showClientButton.TabIndex = 2;
            this.showClientButton.Text = "Ver";
            this.showClientButton.UseVisualStyleBackColor = true;
            // 
            // modifyClientButton
            // 
            this.modifyClientButton.Location = new System.Drawing.Point(36, 201);
            this.modifyClientButton.Name = "modifyClientButton";
            this.modifyClientButton.Size = new System.Drawing.Size(127, 52);
            this.modifyClientButton.TabIndex = 3;
            this.modifyClientButton.Text = "Modificar";
            this.modifyClientButton.UseVisualStyleBackColor = true;
            // 
            // deleteClientButton
            // 
            this.deleteClientButton.Location = new System.Drawing.Point(36, 281);
            this.deleteClientButton.Name = "deleteClientButton";
            this.deleteClientButton.Size = new System.Drawing.Size(127, 52);
            this.deleteClientButton.TabIndex = 4;
            this.deleteClientButton.Text = "Eliminar";
            this.deleteClientButton.UseVisualStyleBackColor = true;
            // 
            // CashierMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 445);
            this.Controls.Add(this.deleteClientButton);
            this.Controls.Add(this.modifyClientButton);
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
        private System.Windows.Forms.Button modifyClientButton;
        private System.Windows.Forms.Button deleteClientButton;
    }
}