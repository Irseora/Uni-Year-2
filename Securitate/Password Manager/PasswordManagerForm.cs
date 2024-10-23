using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class PasswordManagerForm : Form
    {
        public PasswordManagerForm()
        {
            InitializeComponent();
        }

        private void generatePasswordButton_Click(object sender, EventArgs e)
        {
            new PasswordGeneratorForm().Show();
        }

        private void getPasswordButton_Click(object sender, EventArgs e)
        {
            new GetPasswordForm().Show();
        }

        private void addPasswordButton_Click(object sender, EventArgs e)
        {
            new AddPasswordForm().Show();
        }

        private void removePasswordButton_Click(object sender, EventArgs e)
        {
            new RemovePasswordForm().Show();
        }
    }
}
