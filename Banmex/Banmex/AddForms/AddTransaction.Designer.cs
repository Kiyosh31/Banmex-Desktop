namespace Banmex.AddForms
{
    partial class AddTransaction
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
            this.destinationGridView = new System.Windows.Forms.DataGridView();
            this.detinationLabel = new System.Windows.Forms.Label();
            this.origenDataGridView = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.origenLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.accountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.acceptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.destinationGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // destinationGridView
            // 
            this.destinationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.destinationGridView.Location = new System.Drawing.Point(387, 35);
            this.destinationGridView.Name = "destinationGridView";
            this.destinationGridView.RowTemplate.Height = 24;
            this.destinationGridView.Size = new System.Drawing.Size(292, 150);
            this.destinationGridView.TabIndex = 10;
            // 
            // detinationLabel
            // 
            this.detinationLabel.AutoSize = true;
            this.detinationLabel.Location = new System.Drawing.Point(576, 15);
            this.detinationLabel.Name = "detinationLabel";
            this.detinationLabel.Size = new System.Drawing.Size(103, 17);
            this.detinationLabel.TabIndex = 9;
            this.detinationLabel.Text = "Cliente Destino";
            // 
            // origenDataGridView
            // 
            this.origenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.origenDataGridView.Location = new System.Drawing.Point(26, 35);
            this.origenDataGridView.Name = "origenDataGridView";
            this.origenDataGridView.RowTemplate.Height = 24;
            this.origenDataGridView.Size = new System.Drawing.Size(300, 150);
            this.origenDataGridView.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // origenLabel
            // 
            this.origenLabel.AutoSize = true;
            this.origenLabel.Location = new System.Drawing.Point(36, 15);
            this.origenLabel.Name = "origenLabel";
            this.origenLabel.Size = new System.Drawing.Size(98, 17);
            this.origenLabel.TabIndex = 6;
            this.origenLabel.Text = "Cliente Origen";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(36, 208);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(64, 17);
            this.quantityLabel.TabIndex = 11;
            this.quantityLabel.Text = "Cantidad";
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Location = new System.Drawing.Point(36, 270);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(103, 17);
            this.accountTypeLabel.TabIndex = 12;
            this.accountTypeLabel.Text = "Tipo de cuenta";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(39, 229);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(121, 22);
            this.quantityTextBox.TabIndex = 13;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // accountTypeComboBox
            // 
            this.accountTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountTypeComboBox.FormattingEnabled = true;
            this.accountTypeComboBox.Items.AddRange(new object[] {
            "Credito",
            "Debito"});
            this.accountTypeComboBox.Location = new System.Drawing.Point(39, 291);
            this.accountTypeComboBox.Name = "accountTypeComboBox";
            this.accountTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.accountTypeComboBox.TabIndex = 14;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(564, 270);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(115, 55);
            this.acceptButton.TabIndex = 15;
            this.acceptButton.Text = "Aceptar";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 346);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.accountTypeComboBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.accountTypeLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.destinationGridView);
            this.Controls.Add(this.detinationLabel);
            this.Controls.Add(this.origenDataGridView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.origenLabel);
            this.Name = "AddTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Transaccion";
            this.Load += new System.EventHandler(this.AddTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.destinationGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView destinationGridView;
        private System.Windows.Forms.Label detinationLabel;
        private System.Windows.Forms.DataGridView origenDataGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label origenLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.ComboBox accountTypeComboBox;
        private System.Windows.Forms.Button acceptButton;
    }
}