namespace Banmex.Menu
{
    partial class AddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccount));
            this.addButton = new System.Windows.Forms.Button();
            this.nipLabel = new System.Windows.Forms.Label();
            this.niptextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.maximumCreditTextBox = new System.Windows.Forms.TextBox();
            this.maximumCreditLabel = new System.Windows.Forms.Label();
            this.cutOffDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cutOffDayLabel = new System.Windows.Forms.Label();
            this.accountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(106, 353);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(109, 52);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Agregar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nipLabel
            // 
            this.nipLabel.AutoSize = true;
            this.nipLabel.Location = new System.Drawing.Point(59, 49);
            this.nipLabel.Name = "nipLabel";
            this.nipLabel.Size = new System.Drawing.Size(29, 17);
            this.nipLabel.TabIndex = 1;
            this.nipLabel.Text = "Nip";
            // 
            // niptextBox
            // 
            this.niptextBox.Location = new System.Drawing.Point(62, 69);
            this.niptextBox.Name = "niptextBox";
            this.niptextBox.Size = new System.Drawing.Size(201, 22);
            this.niptextBox.TabIndex = 2;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(62, 125);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(201, 22);
            this.balanceTextBox.TabIndex = 4;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(59, 105);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(44, 17);
            this.balanceLabel.TabIndex = 3;
            this.balanceLabel.Text = "Saldo";
            // 
            // maximumCreditTextBox
            // 
            this.maximumCreditTextBox.Location = new System.Drawing.Point(62, 182);
            this.maximumCreditTextBox.Name = "maximumCreditTextBox";
            this.maximumCreditTextBox.Size = new System.Drawing.Size(201, 22);
            this.maximumCreditTextBox.TabIndex = 6;
            // 
            // maximumCreditLabel
            // 
            this.maximumCreditLabel.AutoSize = true;
            this.maximumCreditLabel.Location = new System.Drawing.Point(59, 162);
            this.maximumCreditLabel.Name = "maximumCreditLabel";
            this.maximumCreditLabel.Size = new System.Drawing.Size(104, 17);
            this.maximumCreditLabel.TabIndex = 5;
            this.maximumCreditLabel.Text = "Credito maximo";
            // 
            // cutOffDayDateTimePicker
            // 
            this.cutOffDayDateTimePicker.Location = new System.Drawing.Point(62, 238);
            this.cutOffDayDateTimePicker.Name = "cutOffDayDateTimePicker";
            this.cutOffDayDateTimePicker.Size = new System.Drawing.Size(201, 22);
            this.cutOffDayDateTimePicker.TabIndex = 7;
            // 
            // cutOffDayLabel
            // 
            this.cutOffDayLabel.AutoSize = true;
            this.cutOffDayLabel.Location = new System.Drawing.Point(59, 218);
            this.cutOffDayLabel.Name = "cutOffDayLabel";
            this.cutOffDayLabel.Size = new System.Drawing.Size(103, 17);
            this.cutOffDayLabel.TabIndex = 8;
            this.cutOffDayLabel.Text = "Fecha de corte";
            // 
            // accountTypeComboBox
            // 
            this.accountTypeComboBox.FormattingEnabled = true;
            this.accountTypeComboBox.Items.AddRange(new object[] {
            "Credito",
            "Debito"});
            this.accountTypeComboBox.Location = new System.Drawing.Point(62, 301);
            this.accountTypeComboBox.Name = "accountTypeComboBox";
            this.accountTypeComboBox.Size = new System.Drawing.Size(201, 24);
            this.accountTypeComboBox.TabIndex = 9;
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Location = new System.Drawing.Point(59, 281);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(103, 17);
            this.accountTypeLabel.TabIndex = 10;
            this.accountTypeLabel.Text = "Tipo de cuenta";
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(333, 448);
            this.Controls.Add(this.accountTypeLabel);
            this.Controls.Add(this.accountTypeComboBox);
            this.Controls.Add(this.cutOffDayLabel);
            this.Controls.Add(this.cutOffDayDateTimePicker);
            this.Controls.Add(this.maximumCreditTextBox);
            this.Controls.Add(this.maximumCreditLabel);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.niptextBox);
            this.Controls.Add(this.nipLabel);
            this.Controls.Add(this.addButton);
            this.Name = "AddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label nipLabel;
        private System.Windows.Forms.TextBox niptextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox maximumCreditTextBox;
        private System.Windows.Forms.Label maximumCreditLabel;
        private System.Windows.Forms.DateTimePicker cutOffDayDateTimePicker;
        private System.Windows.Forms.Label cutOffDayLabel;
        private System.Windows.Forms.ComboBox accountTypeComboBox;
        private System.Windows.Forms.Label accountTypeLabel;
    }
}