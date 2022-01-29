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

namespace Whyne.App
{
    public partial class SearchFormV2 : Form
    {
        
        public SearchFormV2()
        {
            InitializeComponent();
        }

        private void Filterbox2_Click(object sender, EventArgs e)
        {

        }

        private void Filterbox3_Click(object sender, EventArgs e)
        {
            string searching = Filterbox3.Text;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Columns[e.ColumnIndex].Name == " Delete")
            {
                if (MessageBox.Show("Are you sure to want to delete this ?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    customersBindingSource.Remove();
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
            }
        }

    }
}
