using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whyne.App.Controls.Common.Items;

namespace Whyne.App.Controls.Common
{
    public partial class UserSideNavControl : UserControl
    {
        public UserSideNavControl(List<String> sideNavItems)
        {
            InitializeComponent();
            sideNavItems.ForEach(item =>
            {
                // TODO replace with sidenav items when designed
                SideNavPanel.Controls.Add(new Button
                {
                    Text = item,
                    Margin = new Padding(0, 5, 0, 5),
                    Width = 140,
                    Height = 30
                });
            });
        }

        private void SideNavControl_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }
    }
}
