namespace Banmex.Menu
{
    partial class ShowEmployees
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
            this.employesGridview = new System.Windows.Forms.DataGridView();
            this.modifyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employesGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // employesGridview
            // 
            this.employesGridview.AllowUserToAddRows = false;
            this.employesGridview.AllowUserToDeleteRows = false;
            this.employesGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employesGridview.Location = new System.Drawing.Point(12, 12);
            this.employesGridview.Name = "employesGridview";
            this.employesGridview.ReadOnly = true;
            this.employesGridview.RowTemplate.Height = 24;
            this.employesGridview.Size = new System.Drawing.Size(774, 439);
            this.employesGridview.TabIndex = 0;
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(828, 131);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(147, 68);
            this.modifyButton.TabIndex = 1;
            this.modifyButton.Text = "Modificar";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(828, 254);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(147, 69);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ShowEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 463);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.employesGridview);
            this.Name = "ShowEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Empleados";
            this.Load += new System.EventHandler(this.ShowEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employesGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employesGridview;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button deleteButton;
    }
}