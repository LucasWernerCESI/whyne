using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whyne.BL;

namespace Whyne.App
{
    public partial class SearchFormV2 : Form
    {
        private readonly ItemService _ItemS;
        public SearchFormV2()
        {
            InitializeComponent();
            List<string> famillies = new List<string>();
            foreach (string familly in famillies)
            {
                ToolStripTextBox FamMenubt = new ToolStripTextBox();
                FamMenubt.Text = familly;

                Filterbox2.DropDownItems.Add(FamMenubt);
            }
            List<string> providers = new List<string>();
            foreach (string provider in providers)
            {
                ToolStripTextBox provMenubt = new ToolStripTextBox();
                provMenubt.Text = provider;

                Filterbox3.DropDownItems.Add(provMenubt);
            }

        }


        private void Filterbox2_Click(object sender, EventArgs e)    //using FamillyFilter
        {

        }

        private void Filterbox3_Click(object sender, EventArgs e)   //using ProviderFilter
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name=="Delete")
            {
                DialogResult result = MessageBox.Show("Are you sure about deleting this row?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                    return;
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                return;
            }
            else
            {
                return;
            }
        }

        private void SearchFormV2_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
