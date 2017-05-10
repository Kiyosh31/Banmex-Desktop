namespace Banmex.CancelForms
{
    partial class CancelTransaction
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
            this.canceledDataGriedView = new System.Windows.Forms.DataGridView();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canceledDataGriedView)).BeginInit();
            this.SuspendLayout();
            // 
            // canceledDataGriedView
            // 
            this.canceledDataGriedView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.canceledDataGriedView.Location = new System.Drawing.Point(13, 13);
            this.canceledDataGriedView.Name = "canceledDataGriedView";
            this.canceledDataGriedView.RowTemplate.Height = 24;
            this.canceledDataGriedView.Size = new System.Drawing.Size(872, 424);
            this.canceledDataGriedView.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(918, 80);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 78);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CancelTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 449);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.canceledDataGriedView);
            this.Name = "CancelTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Transaccion";
            this.Load += new System.EventHandler(this.CancelTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canceledDataGriedView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView canceledDataGriedView;
        private System.Windows.Forms.Button cancelButton;
    }
}