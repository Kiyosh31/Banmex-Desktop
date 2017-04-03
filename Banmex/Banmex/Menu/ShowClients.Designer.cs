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
            this.clientsGridView = new System.Windows.Forms.DataGridView();
            this.modifyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientsGridView
            // 
            this.clientsGridView.AllowUserToAddRows = false;
            this.clientsGridView.AllowUserToDeleteRows = false;
            this.clientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsGridView.Location = new System.Drawing.Point(6, 12);
            this.clientsGridView.Name = "clientsGridView";
            this.clientsGridView.ReadOnly = true;
            this.clientsGridView.RowTemplate.Height = 24;
            this.clientsGridView.Size = new System.Drawing.Size(796, 471);
            this.clientsGridView.TabIndex = 0;
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(860, 112);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(147, 68);
            this.modifyButton.TabIndex = 1;
            this.modifyButton.Text = "Modificar";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(860, 257);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(147, 62);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ShowClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 495);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.clientsGridView);
            this.Name = "ShowClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Clientes BANMEX";
            this.Load += new System.EventHandler(this.ShowClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView clientsGridView;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button deleteButton;
    }
}