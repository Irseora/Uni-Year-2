namespace Password_Manager
{
    partial class GetPasswordForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.getPasswordButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.serviceTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(185, 31);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Get Password";
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.serviceLabel.Location = new System.Drawing.Point(15, 53);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(59, 17);
            this.serviceLabel.TabIndex = 4;
            this.serviceLabel.Text = "Service:";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.keyLabel.Location = new System.Drawing.Point(15, 80);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(107, 17);
            this.keyLabel.TabIndex = 5;
            this.keyLabel.Text = "Encryption Key:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordLabel.Location = new System.Drawing.Point(15, 146);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 17);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password:";
            // 
            // getPasswordButton
            // 
            this.getPasswordButton.Location = new System.Drawing.Point(95, 167);
            this.getPasswordButton.Name = "getPasswordButton";
            this.getPasswordButton.Size = new System.Drawing.Size(217, 23);
            this.getPasswordButton.TabIndex = 7;
            this.getPasswordButton.Text = "Get Password";
            this.getPasswordButton.UseVisualStyleBackColor = true;
            this.getPasswordButton.Click += new System.EventHandler(this.getPasswordButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.passwordTextBox.Location = new System.Drawing.Point(95, 146);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(217, 21);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.Text = "Your password will appear here";
            // 
            // serviceTextBox
            // 
            this.serviceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.serviceTextBox.Location = new System.Drawing.Point(80, 50);
            this.serviceTextBox.Name = "serviceTextBox";
            this.serviceTextBox.Size = new System.Drawing.Size(232, 21);
            this.serviceTextBox.TabIndex = 9;
            this.serviceTextBox.Text = "Enter service name";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.keyTextBox.Location = new System.Drawing.Point(128, 77);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(184, 21);
            this.keyTextBox.TabIndex = 10;
            this.keyTextBox.Text = "Enter encryption key";
            // 
            // GetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 211);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.serviceTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.getPasswordButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.serviceLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "GetPasswordForm";
            this.Text = "GetPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button getPasswordButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox serviceTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
    }
}