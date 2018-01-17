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
    public partial class Historia : Form
    {
        public Historia()
        {
            InitializeComponent();
        }

        private void Historia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fakturyDBDataSet.Naglowek' table. You can move, or remove it, as needed.
            this.naglowekTableAdapter.Fill(this.fakturyDBDataSet.Naglowek);

        }
    }
}
