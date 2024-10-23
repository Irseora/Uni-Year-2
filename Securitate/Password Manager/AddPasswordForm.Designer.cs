namespace Password_Manager
{
    partial class AddPasswordForm
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
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.serviceTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.addPasswordButton = new System.Windows.Forms.Button();
            this.keyLengthLabel = new System.Windows.Forms.Label();
            this.exceptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(189, 31);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Add Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.passwordTextBox.Location = new System.Drawing.Point(91, 73);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(218, 21);
            this.passwordTextBox.TabIndex = 14;
            this.passwordTextBox.Text = "Enter password";
            // 
            // serviceTextBox
            // 
            this.serviceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.serviceTextBox.Location = new System.Drawing.Point(77, 46);
            this.serviceTextBox.Name = "serviceTextBox";
            this.serviceTextBox.Size = new System.Drawing.Size(232, 21);
            this.serviceTextBox.TabIndex = 13;
            this.serviceTextBox.Text = "Enter service name";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordLabel.Location = new System.Drawing.Point(12, 76);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 17);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password:";
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.serviceLabel.Location = new System.Drawing.Point(12, 49);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(59, 17);
            this.serviceLabel.TabIndex = 11;
            this.serviceLabel.Text = "Service:";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.keyTextBox.Location = new System.Drawing.Point(125, 100);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(184, 21);
            this.keyTextBox.TabIndex = 16;
            this.keyTextBox.Text = "Enter encryption key";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.keyLabel.Location = new System.Drawing.Point(12, 103);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(107, 17);
            this.keyLabel.TabIndex = 15;
            this.keyLabel.Text = "Encryption Key:";
            // 
            // addPasswordButton
            // 
            this.addPasswordButton.Location = new System.Drawing.Point(53, 156);
            this.addPasswordButton.Name = "addPasswordButton";
            this.addPasswordButton.Size = new System.Drawing.Size(217, 23);
            this.addPasswordButton.TabIndex = 17;
            this.addPasswordButton.Text = "Encrypt and Add to Manager";
            this.addPasswordButton.UseVisualStyleBackColor = true;
            this.addPasswordButton.Click += new System.EventHandler(this.addPasswordButton_Click);
            // 
            // keyLengthLabel
            // 
            this.keyLengthLabel.AutoSize = true;
            this.keyLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.keyLengthLabel.Location = new System.Drawing.Point(15, 120);
            this.keyLengthLabel.Name = "keyLengthLabel";
            this.keyLengthLabel.Size = new System.Drawing.Size(89, 15);
            this.keyLengthLabel.TabIndex = 18;
            this.keyLengthLabel.Text = "(16 characters)";
            // 
            // exceptionLabel
            // 
            this.exceptionLabel.AutoSize = true;
            this.exceptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.exceptionLabel.ForeColor = System.Drawing.Color.Red;
            this.exceptionLabel.Location = new System.Drawing.Point(50, 182);
            this.exceptionLabel.Name = "exceptionLabel";
            this.exceptionLabel.Size = new System.Drawing.Size(0, 15);
            this.exceptionLabel.TabIndex = 19;
            // 
            // AddPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 211);
            this.Controls.Add(this.exceptionLabel);
            this.Controls.Add(this.keyLengthLabel);
            this.Controls.Add(this.addPasswordButton);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.serviceTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.serviceLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "AddPasswordForm";
            this.Text = "AddPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox serviceTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Button addPasswordButton;
        private System.Windows.Forms.Label keyLengthLabel;
        private System.Windows.Forms.Label exceptionLabel;
    }
}