using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whyne.Models.People;

namespace Whyne.App.Controls.People
{
    public partial class SupplierControl : UserControl
    {
        private readonly MainForm _mainForm;
        public SupplierControl(MainForm mainForm)
        {
            InitializeComponent();
            this._mainForm = mainForm;
        }

        private void SupplierControl_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            await _mainForm
                .ApiClient
                .Post("Suppliers", new Supplier
                {
                    Name = SupplierNameTextBox.Text,
                    RegistrationNumber = RegistrationNumberTextBox.Text,
                    TaxNumber = TaxNumberTextBox.Text
                });
        }
    }
}
