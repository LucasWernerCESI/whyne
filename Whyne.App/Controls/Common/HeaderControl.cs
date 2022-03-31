using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whyne.App.Controls.People;

namespace Whyne.App.Controls.Common
{
    public partial class HeaderControl : UserControl
    {
        private readonly MainForm _mainForm;
        public HeaderControl(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void HeaderControl_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            _mainForm.LogOut();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            _mainForm.ResetMainPanel();
        }

        private void PeopleButton_Click(object sender, EventArgs e)
        {
            _mainForm.EmptyMainPanel();
            PeopleControl peopleControl = new PeopleControl(_mainForm);
            peopleControl.FillBody(new SupplierControl(_mainForm));
            _mainForm.FillMainPanel(peopleControl);
        }
    }
}
