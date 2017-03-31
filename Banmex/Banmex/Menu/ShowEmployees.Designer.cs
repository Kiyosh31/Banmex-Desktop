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
            ((System.ComponentModel.ISupportInitialize)(this.employesGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // employesGridview
            // 
            this.employesGridview.AllowUserToAddRows = false;
            this.employesGridview.AllowUserToDeleteRows = false;
            this.employesGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employesGridview.Location = new System.Drawing.Point(13, 13);
            this.employesGridview.Name = "employesGridview";
            this.employesGridview.ReadOnly = true;
            this.employesGridview.RowTemplate.Height = 24;
            this.employesGridview.Size = new System.Drawing.Size(858, 352);
            this.employesGridview.TabIndex = 0;
            // 
            // ShowEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 377);
            this.Controls.Add(this.employesGridview);
            this.Name = "ShowEmployees";
            this.Text = "Mostrar Empleados";
            this.Load += new System.EventHandler(this.ShowEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employesGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employesGridview;
    }
}