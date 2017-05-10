namespace Banmex.ShowForms
{
    partial class ShowDeposit
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
            this.cancelDepositDataGridView = new System.Windows.Forms.DataGridView();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cancelDepositDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelDepositDataGridView
            // 
            this.cancelDepositDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cancelDepositDataGridView.Location = new System.Drawing.Point(13, 13);
            this.cancelDepositDataGridView.Name = "cancelDepositDataGridView";
            this.cancelDepositDataGridView.RowTemplate.Height = 24;
            this.cancelDepositDataGridView.Size = new System.Drawing.Size(612, 424);
            this.cancelDepositDataGridView.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(666, 119);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(154, 91);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ShowDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 449);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.cancelDepositDataGridView);
            this.Name = "ShowDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Despositos";
            this.Load += new System.EventHandler(this.ShowDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cancelDepositDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cancelDepositDataGridView;
        private System.Windows.Forms.Button cancelButton;
    }
}