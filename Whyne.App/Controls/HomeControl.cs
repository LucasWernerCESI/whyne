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

namespace Whyne.App.Controls
{
    public partial class HomeControl : UserControl
    {
        private readonly MainForm _mainForm;

        public HomeControl(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            if (_mainForm.User != null)
            {
                UsernameLabel.Text = "Nom d'utilisateur : " + _mainForm.User.UserName;
                EmailLabel.Text = "Adresse mail : " + _mainForm.User.Email;
                PhoneNumberLabel.Text = "N° de téléphone : " + (_mainForm.User.PhoneNumber ?? "non renseigné");
            }
        }
    }
}