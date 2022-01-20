using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whyne.Controls.Account;

namespace Whyne.App
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Add(new UCAccountDetails());
        }
    }
}
