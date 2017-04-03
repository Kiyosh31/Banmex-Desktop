namespace Banmex.Menu
{
    partial class ModifyClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyClient));
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.modifyButton = new System.Windows.Forms.Button();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.rfcLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.rfcTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.firstNameLabel.Location = new System.Drawing.Point(91, 72);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(58, 17);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "Nombre";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(94, 92);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(203, 22);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(125, 339);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(132, 54);
            this.modifyButton.TabIndex = 2;
            this.modifyButton.Text = "Modificar";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lastNameLabel.Location = new System.Drawing.Point(91, 135);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 17);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Apellido";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phoneLabel.Location = new System.Drawing.Point(91, 198);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(64, 17);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Telefono";
            // 
            // rfcLabel
            // 
            this.rfcLabel.AutoSize = true;
            this.rfcLabel.BackColor = System.Drawing.Color.Transparent;
            this.rfcLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rfcLabel.Location = new System.Drawing.Point(91, 255);
            this.rfcLabel.Name = "rfcLabel";
            this.rfcLabel.Size = new System.Drawing.Size(35, 17);
            this.rfcLabel.TabIndex = 5;
            this.rfcLabel.Text = "RFC";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(94, 155);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(203, 22);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Location = new System.Drawing.Point(94, 218);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(203, 22);
            this.phoneTextbox.TabIndex = 8;
            // 
            // rfcTextBox
            // 
            this.rfcTextBox.Location = new System.Drawing.Point(94, 275);
            this.rfcTextBox.Name = "rfcTextBox";
            this.rfcTextBox.Size = new System.Drawing.Size(203, 22);
            this.rfcTextBox.TabIndex = 9;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(94, 44);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(101, 22);
            this.idTextBox.TabIndex = 11;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.Transparent;
            this.idLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idLabel.Location = new System.Drawing.Point(91, 24);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 17);
            this.idLabel.TabIndex = 10;
            this.idLabel.Text = "ID";
            // 
            // ModifyClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(392, 419);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.rfcTextBox);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.rfcLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "ModifyClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Cliente BANMEX";
            this.Load += new System.EventHandler(this.ModifyClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label rfcLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox phoneTextbox;
        private System.Windows.Forms.TextBox rfcTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
    }
}