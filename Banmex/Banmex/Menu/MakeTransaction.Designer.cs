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
            this.origenComboBox = new System.Windows.Forms.ComboBox();
            this.destinationComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(10, 167);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(166, 22);
            this.quantityTextBox.TabIndex = 3;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(12, 147);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(64, 17);
            this.quantityLabel.TabIndex = 7;
            this.quantityLabel.Text = "Cantidad";
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Location = new System.Drawing.Point(12, 212);
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
            this.accountTypeComboBox.Location = new System.Drawing.Point(10, 232);
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
            this.origenLabel.Location = new System.Drawing.Point(7, 24);
            this.origenLabel.Name = "origenLabel";
            this.origenLabel.Size = new System.Drawing.Size(100, 17);
            this.origenLabel.TabIndex = 0;
            this.origenLabel.Text = "Cuenta Origen";
            // 
            // detinationLabel
            // 
            this.detinationLabel.AutoSize = true;
            this.detinationLabel.Location = new System.Drawing.Point(12, 85);
            this.detinationLabel.Name = "detinationLabel";
            this.detinationLabel.Size = new System.Drawing.Size(105, 17);
            this.detinationLabel.TabIndex = 4;
            this.detinationLabel.Text = "Cuenta Destino";
            // 
            // origenComboBox
            // 
            this.origenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.origenComboBox.FormattingEnabled = true;
            this.origenComboBox.Location = new System.Drawing.Point(10, 44);
            this.origenComboBox.Name = "origenComboBox";
            this.origenComboBox.Size = new System.Drawing.Size(166, 24);
            this.origenComboBox.TabIndex = 6;
            // 
            // destinationComboBox
            // 
            this.destinationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinationComboBox.FormattingEnabled = true;
            this.destinationComboBox.Location = new System.Drawing.Point(10, 105);
            this.destinationComboBox.Name = "destinationComboBox";
            this.destinationComboBox.Size = new System.Drawing.Size(166, 24);
            this.destinationComboBox.TabIndex = 2;
            // 
            // MakeTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 425);
            this.Controls.Add(this.transactionButton);
            this.Controls.Add(this.accountTypeComboBox);
            this.Controls.Add(this.accountTypeLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.origenComboBox);
            this.Controls.Add(this.detinationLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.destinationComboBox);
            this.Controls.Add(this.origenLabel);
            this.Name = "MakeTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaccion";
            this.Load += new System.EventHandler(this.MakeTransaction_Load);
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
        private System.Windows.Forms.ComboBox origenComboBox;
        private System.Windows.Forms.ComboBox destinationComboBox;
    }
}