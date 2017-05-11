namespace Banmex.CancelForms
{
    partial class CancelDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelDeposit));
            this.cancelDepositDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cancelDepositDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelDepositDataGridView
            // 
            this.cancelDepositDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cancelDepositDataGridView.Location = new System.Drawing.Point(12, 75);
            this.cancelDepositDataGridView.Name = "cancelDepositDataGridView";
            this.cancelDepositDataGridView.RowTemplate.Height = 24;
            this.cancelDepositDataGridView.Size = new System.Drawing.Size(825, 424);
            this.cancelDepositDataGridView.TabIndex = 2;
            // 
            // CancelDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(847, 511);
            this.Controls.Add(this.cancelDepositDataGridView);
            this.Name = "CancelDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Deposito";
            this.Load += new System.EventHandler(this.CancelDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cancelDepositDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cancelDepositDataGridView;
    }
}