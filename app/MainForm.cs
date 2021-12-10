using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Model;
using Whyne;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ApiClient client = new ApiClient("https://localhost:44373/api/");
            List<Account> accounts = await client.Get<List<Account>>("accounts");
            dataGridView1.DataSource = accounts;
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
        }
    }
}
