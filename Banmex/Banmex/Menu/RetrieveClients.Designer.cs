namespace Banmex.Menu
{
    partial class RetrieveClients
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
            this.retrieveButton = new System.Windows.Forms.Button();
            this.clientsGridView = new System.Windows.Forms.DataGridView();
            this.deleteDefinetly = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // retrieveButton
            // 
            this.retrieveButton.Location = new System.Drawing.Point(793, 48);
            this.retrieveButton.Name = "retrieveButton";
            this.retrieveButton.Size = new System.Drawing.Size(128, 96);
            this.retrieveButton.TabIndex = 4;
            this.retrieveButton.Text = "Reactivar";
            this.retrieveButton.UseVisualStyleBackColor = true;
            this.retrieveButton.Click += new System.EventHandler(this.retrieveButton_Click);
            // 
            // clientsGridView
            // 
            this.clientsGridView.AllowUserToAddRows = false;
            this.clientsGridView.AllowUserToDeleteRows = false;
            this.clientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsGridView.Location = new System.Drawing.Point(12, 12);
            this.clientsGridView.Name = "clientsGridView";
            this.clientsGridView.ReadOnly = true;
            this.clientsGridView.RowTemplate.Height = 24;
            this.clientsGridView.Size = new System.Drawing.Size(728, 439);
            this.clientsGridView.TabIndex = 3;
            // 
            // deleteDefinetly
            // 
            this.deleteDefinetly.Location = new System.Drawing.Point(793, 296);
            this.deleteDefinetly.Name = "deleteDefinetly";
            this.deleteDefinetly.Size = new System.Drawing.Size(128, 96);
            this.deleteDefinetly.TabIndex = 5;
            this.deleteDefinetly.Text = "Eliminar Definitivamente";
            this.deleteDefinetly.UseVisualStyleBackColor = true;
            this.deleteDefinetly.Click += new System.EventHandler(this.deleteDefinetly_Click);
            // 
            // RetrieveClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 465);
            this.Controls.Add(this.deleteDefinetly);
            this.Controls.Add(this.retrieveButton);
            this.Controls.Add(this.clientsGridView);
            this.Name = "RetrieveClients";
            this.Text = "Recuperar Clientes BANMEX";
            this.Load += new System.EventHandler(this.RetrieveClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button retrieveButton;
        private System.Windows.Forms.DataGridView clientsGridView;
        private System.Windows.Forms.Button deleteDefinetly;
    }
}