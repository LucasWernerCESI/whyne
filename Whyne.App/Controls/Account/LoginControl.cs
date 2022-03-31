using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whyne.Models;

namespace Whyne.App.Controls.Account
{
    public partial class LoginControl : UserControl
    {
        private readonly MainForm _mainForm;

        public LoginControl(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Credentials credentials = new()
                {
                    Email = EmailTextBox.Text,
                    Password = PasswordTextBox.Text,
                };

            _mainForm.LogIn(credentials);
        }
    }
}