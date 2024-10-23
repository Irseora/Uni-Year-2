namespace Password_Manager
{
    partial class PasswordManagerForm
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
            this.generatePasswordButton = new System.Windows.Forms.Button();
            this.getPasswordButton = new System.Windows.Forms.Button();
            this.removePasswordButton = new System.Windows.Forms.Button();
            this.addPasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(247, 31);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Password Manager";
            // 
            // generatePasswordButton
            // 
            this.generatePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.generatePasswordButton.Location = new System.Drawing.Point(38, 74);
            this.generatePasswordButton.Name = "generatePasswordButton";
            this.generatePasswordButton.Size = new System.Drawing.Size(191, 34);
            this.generatePasswordButton.TabIndex = 2;
            this.generatePasswordButton.Text = "Generate New Password";
            this.generatePasswordButton.UseVisualStyleBackColor = true;
            this.generatePasswordButton.Click += new System.EventHandler(this.generatePasswordButton_Click);
            // 
            // getPasswordButton
            // 
            this.getPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.getPasswordButton.Location = new System.Drawing.Point(38, 114);
            this.getPasswordButton.Name = "getPasswordButton";
            this.getPasswordButton.Size = new System.Drawing.Size(191, 34);
            this.getPasswordButton.TabIndex = 3;
            this.getPasswordButton.Text = "Get Password";
            this.getPasswordButton.UseVisualStyleBackColor = true;
            this.getPasswordButton.Click += new System.EventHandler(this.getPasswordButton_Click);
            // 
            // removePasswordButton
            // 
            this.removePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.removePasswordButton.Location = new System.Drawing.Point(38, 194);
            this.removePasswordButton.Name = "removePasswordButton";
            this.removePasswordButton.Size = new System.Drawing.Size(191, 34);
            this.removePasswordButton.TabIndex = 4;
            this.removePasswordButton.Text = "Remove Password";
            this.removePasswordButton.UseVisualStyleBackColor = true;
            this.removePasswordButton.Click += new System.EventHandler(this.removePasswordButton_Click);
            // 
            // addPasswordButton
            // 
            this.addPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addPasswordButton.Location = new System.Drawing.Point(38, 154);
            this.addPasswordButton.Name = "addPasswordButton";
            this.addPasswordButton.Size = new System.Drawing.Size(191, 34);
            this.addPasswordButton.TabIndex = 5;
            this.addPasswordButton.Text = "Add Password";
            this.addPasswordButton.UseVisualStyleBackColor = true;
            this.addPasswordButton.Click += new System.EventHandler(this.addPasswordButton_Click);
            // 
            // PasswordManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 261);
            this.Controls.Add(this.addPasswordButton);
            this.Controls.Add(this.removePasswordButton);
            this.Controls.Add(this.getPasswordButton);
            this.Controls.Add(this.generatePasswordButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "PasswordManagerForm";
            this.Text = "PasswordManagerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button generatePasswordButton;
        private System.Windows.Forms.Button getPasswordButton;
        private System.Windows.Forms.Button removePasswordButton;
        private System.Windows.Forms.Button addPasswordButton;
    }
}