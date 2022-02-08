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
        private readonly ProviderService _ProviderS;
        public SearchFormV2()
        {
            InitializeComponent();

            var fam = _ItemS.GetEveryFamilly;           //
            var prov = _ProviderS.GetProvider;          // tempo

            List<string> famillies = new List<string>();    //liste à remplir
            foreach (string familly in famillies)
            {
                ToolStripTextBox FamMenubt = new ToolStripTextBox();
                FamMenubt.Text = familly;

                Filterbox2.DropDownItems.Add(FamMenubt);
            }
            List<string> providers = new List<string>();    //liste à remplir
            foreach (string provider in providers)
            {
                ToolStripTextBox provMenubt = new ToolStripTextBox();
                provMenubt.Text = provider;

                Filterbox3.DropDownItems.Add(provMenubt);
            }
        }

        DataTable Tablesource;                      //tempo
        private void starttable()                   //  
        {
            Tablesource = new DataTable();          //
            dataGridView1.DataSource = Tablesource; //
        }                                           //



        private void Filterbox2_Click(object sender, EventArgs e)    //using FamillyFilter //les filtres ne s'aditionnent pas, il s'écrasent entre eux
        {
            var memo = _ItemS.FamillyFilter;
            if (Filterbox3.Text == null)
            {
                DataView dv2 = Tablesource.DefaultView;
                dv2.RowFilter = Filterbox2.Text;
                dataGridView1.DataSource = dv2;
            }
            else
            {
                DataView dv2 = Tablesource.DefaultView;
                dv2.RowFilter = Filterbox2.Text;
                dataGridView1.DataSource = dv2;
            }
        }

        private void Filterbox3_Click(object sender, EventArgs e)   //using ProviderFilter //les filtres ne s'aditionnent pas, il s'écrasent entre eux
        {
            var memo = _ItemS.ProviderFilter;
            if (Filterbox2.Text == null)
            {
                DataView dv3 = Tablesource.DefaultView;
                dv3.RowFilter = Filterbox3.Text;
                dataGridView1.DataSource = dv3;
            }
            else
            {
                DataView dv3 = Tablesource.DefaultView;
                dv3.RowFilter = Filterbox3.Text;
                dataGridView1.DataSource = dv3;
            }
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
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")    //utilisation de AddItemForm
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
