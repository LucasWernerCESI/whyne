using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whyne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ApiClient client = new ApiClient("https://localhost:5001/");
            Account account = await client.Get<Account>("account");
            List<Account> accounts = new List<Account>();
            accounts.Add(account);
            dataGridView1.DataSource = accounts;
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
        }
    }

}
