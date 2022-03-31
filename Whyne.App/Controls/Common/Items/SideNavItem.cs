﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whyne.App.Controls.Common.Items
{
    public partial class SideNavItem : UserControl
    {
        public SideNavItem(string label)
        {
            InitializeComponent();
            ItemLabel.Text = label;
        }
    }
}
