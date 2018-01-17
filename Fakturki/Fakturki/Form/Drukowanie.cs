using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fakturki
{
    public partial class Drukowanie : Form
    {
        DataSet dataSetFromSource;
        string ParameterNrFa, Kopia;
        public Drukowanie(DataSet dataSetFromSource, string FaNr, string Kopia)
        {
            InitializeComponent();
            this.dataSetFromSource = dataSetFromSource;
            this.ParameterNrFa = FaNr;
            this.Kopia = Kopia;
        }

        private void Drukowanie_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Czy wydruk wygenerował się poprawnie ? Jeżeli nie, program pozwoli Ci wygenerować go jeszcze raz.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, "", buttons);
            if (result == System.Windows.Forms.DialogResult.No) e.Cancel = true;
        }

        private void Drukowanie_Load(object sender, EventArgs e)
        {
            itemsDataTableBindingSource.DataSource = this.dataSetFromSource.Tables["Items"];
            headerBindingSource.DataSource = this.dataSetFromSource.Tables["Header"];
            this.reportViewer1.RefreshReport();
        }
    }
}
