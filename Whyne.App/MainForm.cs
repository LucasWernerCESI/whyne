using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whyne;
using Whyne.App.Controls;
using Whyne.App.Controls.Account;
using Whyne.App.Controls.Common;
using Whyne.Models;

namespace Whyne.App
{
    public partial class MainForm : Form
    {
        private readonly ApiClient _apiClient;

        private User _user = null;

        public User User => _user;

        public ApiClient ApiClient => _apiClient;

        public MainForm()
        {
            InitializeComponent();

            _apiClient = new ApiClient("https://localhost:44373/api/");

            // Initialize login control
            LoginControlLayoutPanel.Controls.Add(new LoginControl(this));

            // Initialize header and home controls
            MainControlLayoutPanel.Controls.Add(new HeaderControl(this), 0, 0);
            MainControlLayoutPanel.Controls.Add(new HomeControl(this), 0, 1);

            if (_user == null)
            {
                LoginControlLayoutPanel.Show();
            }
            else
            {
                MainControlLayoutPanel.Show();
            }
        }

        public async void LogIn(Credentials credentials) //si problème vérifier le port dans _apiClient
        {
            _user = await _apiClient.Login(credentials);
            if (_user != null)
            {
                ResetMainPanel();
                LoginControlLayoutPanel.Hide();
                MainControlLayoutPanel.Show();
            }
        }

        public async void LogOut()
        {
            _user = null;

            ResetMainPanel();

            // Hide controls and show login again
            MainControlLayoutPanel.Hide();
            LoginControlLayoutPanel.Show();
        }

        public void ResetMainPanel()
        {
            EmptyMainPanel();
            FillMainPanel(new HomeControl(this));
        }

        public void EmptyMainPanel() => MainControlLayoutPanel.Controls.RemoveAt(1);

        public void FillMainPanel(Control control) => MainControlLayoutPanel.Controls.Add(control, 0, 1);

    }
}