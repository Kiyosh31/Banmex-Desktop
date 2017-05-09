namespace Banmex.Menu
{
    partial class MakeTransaction
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
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.accountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.transactionButton = new System.Windows.Forms.Button();
            this.origenLabel = new System.Windows.Forms.Label();
            this.detinationLabel = new System.Windows.Forms.Label();
            this.origenDataGridView = new System.Windows.Forms.DataGridView();
            this.destinationDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.origenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(10, 255);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(166, 22);
            this.quantityTextBox.TabIndex = 3;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(12, 235);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(64, 17);
            this.quantityLabel.TabIndex = 7;
            this.quantityLabel.Text = "Cantidad";
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Location = new System.Drawing.Point(12, 300);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(103, 17);
            this.accountTypeLabel.TabIndex = 8;
            this.accountTypeLabel.Text = "Tipo de cuenta";
            // 
            // accountTypeComboBox
            // 
            this.accountTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountTypeComboBox.FormattingEnabled = true;
            this.accountTypeComboBox.Items.AddRange(new object[] {
            "Credito",
            "Debito"});
            this.accountTypeComboBox.Location = new System.Drawing.Point(10, 320);
            this.accountTypeComboBox.Name = "accountTypeComboBox";
            this.accountTypeComboBox.Size = new System.Drawing.Size(166, 24);
            this.accountTypeComboBox.TabIndex = 9;
            // 
            // transactionButton
            // 
            this.transactionButton.Location = new System.Drawing.Point(170, 358);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.Size = new System.Drawing.Size(129, 55);
            this.transactionButton.TabIndex = 10;
            this.transactionButton.Text = "Aceptar";
            this.transactionButton.UseVisualStyleBackColor = true;
            this.transactionButton.Click += new System.EventHandler(this.transactionButton_Click);
            // 
            // origenLabel
            // 
            this.origenLabel.AutoSize = true;
            this.origenLabel.Location = new System.Drawing.Point(76, 24);
            this.origenLabel.Name = "origenLabel";
            this.origenLabel.Size = new System.Drawing.Size(100, 17);
            this.origenLabel.TabIndex = 0;
            this.origenLabel.Text = "Cuenta Origen";
            // 
            // detinationLabel
            // 
            this.detinationLabel.AutoSize = true;
            this.detinationLabel.Location = new System.Drawing.Point(415, 24);
            this.detinationLabel.Name = "detinationLabel";
            this.detinationLabel.Size = new System.Drawing.Size(105, 17);
            this.detinationLabel.TabIndex = 4;
            this.detinationLabel.Text = "Cuenta Destino";
            // 
            // origenDataGridView
            // 
            this.origenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.origenDataGridView.Location = new System.Drawing.Point(10, 44);
            this.origenDataGridView.Name = "origenDataGridView";
            this.origenDataGridView.RowTemplate.Height = 24;
            this.origenDataGridView.Size = new System.Drawing.Size(253, 170);
            this.origenDataGridView.TabIndex = 11;
            // 
            // destinationDataGridView
            // 
            this.destinationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.destinationDataGridView.Location = new System.Drawing.Point(331, 44);
            this.destinationDataGridView.Name = "destinationDataGridView";
            this.destinationDataGridView.RowTemplate.Height = 24;
            this.destinationDataGridView.Size = new System.Drawing.Size(249, 170);
            this.destinationDataGridView.TabIndex = 12;
            // 
            // MakeTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 425);
            this.Controls.Add(this.destinationDataGridView);
            this.Controls.Add(this.origenDataGridView);
            this.Controls.Add(this.transactionButton);
            this.Controls.Add(this.accountTypeComboBox);
            this.Controls.Add(this.accountTypeLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.detinationLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.origenLabel);
            this.Name = "MakeTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaccion";
            this.Load += new System.EventHandler(this.MakeTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.origenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.ComboBox accountTypeComboBox;
        private System.Windows.Forms.Button transactionButton;
        private System.Windows.Forms.Label origenLabel;
        private System.Windows.Forms.Label detinationLabel;
        private System.Windows.Forms.DataGridView origenDataGridView;
        private System.Windows.Forms.DataGridView destinationDataGridView;
    }
}