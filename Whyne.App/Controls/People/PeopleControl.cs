using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whyne.App.Controls.Common;

namespace Whyne.App.Controls.People
{
    public partial class PeopleControl : UserControl
    {
        private readonly MainForm _mainForm;

        public PeopleControl(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            CreateSideNav();
        }

        private void PeopleControl_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        private void CreateSideNav() => ContentControl.Controls.Add(new PeopleSideNavControl(this, _mainForm), 0, 0);

        public void EmptyBody() => ContentControl.Controls.RemoveAt(1);

        public void FillBody(Control control) => ContentControl.Controls.Add(control, 1, 0);
    }
}
