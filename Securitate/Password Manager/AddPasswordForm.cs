using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class AddPasswordForm : Form
    {
        public AddPasswordForm()
        {
            InitializeComponent();
        }

        public AddPasswordForm(string password)
        {
            InitializeComponent();
            passwordTextBox.Text = password;
        }

        private void addPasswordButton_Click(object sender, EventArgs e)
        {
            // Init
            string service = serviceTextBox.Text;
            string plainTextPassword = passwordTextBox.Text;
            string key = keyTextBox.Text;
            
            try
            {
                // Add entry to saved passwords
                PasswordManager.AddEntry(service, plainTextPassword, key);
                exceptionLabel.Text = "";
            }
            catch (CryptographicException)
            {
                exceptionLabel.Text = "Incorrect key!";
            }
        }
    }
}
