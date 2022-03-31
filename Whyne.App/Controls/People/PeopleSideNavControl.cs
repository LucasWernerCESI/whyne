using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whyne.App.Controls.People
{
    public partial class PeopleSideNavControl : UserControl
    {
        private readonly PeopleControl _peopleControl;
        private readonly MainForm _mainForm;
        public PeopleSideNavControl(PeopleControl control, MainForm mainForm)
        {
            InitializeComponent();
            _peopleControl = control;
            _mainForm = mainForm;
        }

        private void PeopleSideNavControl_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        private void SupplierButton_Click(object sender, EventArgs e)
        {
            _peopleControl.EmptyBody();
            _peopleControl.FillBody(new SupplierControl(_mainForm));
        }
    }
}
