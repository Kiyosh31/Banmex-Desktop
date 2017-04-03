namespace Banmex.Menu
{
    partial class AddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClient));
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.rfcLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.cellphoneTextBox = new System.Windows.Forms.TextBox();
            this.rfcTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.firstNameLabel.Location = new System.Drawing.Point(65, 74);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(58, 17);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "Nombre";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(68, 94);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(203, 22);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(99, 359);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(131, 61);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Agregar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.lastNameLabel.Location = new System.Drawing.Point(65, 143);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 17);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Apellido";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneLabel.ForeColor = System.Drawing.Color.Transparent;
            this.phoneLabel.Location = new System.Drawing.Point(65, 209);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(52, 17);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Celular";
            // 
            // rfcLabel
            // 
            this.rfcLabel.AutoSize = true;
            this.rfcLabel.BackColor = System.Drawing.Color.Transparent;
            this.rfcLabel.ForeColor = System.Drawing.Color.Transparent;
            this.rfcLabel.Location = new System.Drawing.Point(65, 270);
            this.rfcLabel.Name = "rfcLabel";
            this.rfcLabel.Size = new System.Drawing.Size(35, 17);
            this.rfcLabel.TabIndex = 5;
            this.rfcLabel.Text = "RFC";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(68, 163);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(203, 22);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // cellphoneTextBox
            // 
            this.cellphoneTextBox.Location = new System.Drawing.Point(68, 229);
            this.cellphoneTextBox.Name = "cellphoneTextBox";
            this.cellphoneTextBox.Size = new System.Drawing.Size(203, 22);
            this.cellphoneTextBox.TabIndex = 7;
            // 
            // rfcTextBox
            // 
            this.rfcTextBox.Location = new System.Drawing.Point(68, 290);
            this.rfcTextBox.Name = "rfcTextBox";
            this.rfcTextBox.Size = new System.Drawing.Size(203, 22);
            this.rfcTextBox.TabIndex = 8;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(359, 462);
            this.Controls.Add(this.rfcTextBox);
            this.Controls.Add(this.cellphoneTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.rfcLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente BANMEX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label rfcLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox cellphoneTextBox;
        private System.Windows.Forms.TextBox rfcTextBox;
    }
}