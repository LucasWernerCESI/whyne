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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            Searchlist.Items.Clear();
            foreach (string str in Searchlist.Items)
            {
                Searchlist.Items.Add(str);
                Filterbox1.CharacterCasing = CharacterCasing.Lower;
            }
        }

        private void Filterbox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Filterbox1.Text) == false || Filterbox1.Text == "")
            {
                Searchlist.Items.Clear();
                foreach (string str in Searchlist.Items)
                {
                    if (str.StartsWith(Filterbox1.Text))
                    {
                        Searchlist.Items.Add(str);
                    }
                }
            }
        }

        private void Searchlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Searchbt_Click(object sender, EventArgs e)
        {

        }
    }
}
