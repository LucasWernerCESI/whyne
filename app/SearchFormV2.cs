using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whyne.App
{
    public partial class SearchFormV2 : Form
    {
        
        public SearchFormV2()
        {
            InitializeComponent();
        }

        private void Modbt() //création des bouton de modification/suppression des données ; pas fini
        {
            Button Modbt = new Button();
            Modbt.Text = "...";
            Modbt.UseVisualStyleBackColor = true;

            Controls.Add(Modbt);

        }

        private void Filterbox2_Click(object sender, EventArgs e)
        {
            foreach (string familly in )
            {
                ToolStripTextBox FamMenubt = new ToolStripTextBox();
                FamMenubt.Text = familly;
            }

        }

        private void Filterbox3_Click(object sender, EventArgs e)
        {
            foreach (string providers in )
            {
                ToolStripTextBox provMenubt = new ToolStripTextBox();
                provMenubt.Text = providers;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
