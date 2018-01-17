using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace Fakturki
{
    public partial class Form1 : Form
    {
        static DataTable Zawartosci = new DataTable();
        Thread ShowStatus;
        StatusWorker StatusWorker = new StatusWorker();

        public Form1()
        {
            InitializeComponent();
            StatusWorker.przekazanyLabel = this.toolStripStatusLabel1;
            KolumnyNiesotrowalne();
            wypelnijNR();

        }
        private void wypelnijNR()
        {
            textRok.Text = DateTime.Today.Year.ToString();
            textMiesiac.Text = DateTime.Today.Month.ToString("d2");
            var FaNr = pobierzOstaniNrFa();
            textNr.Text = FaNr.ToString("d6");
        }

        private int pobierzOstaniNrFa()
        {
            int nrZPliku = 0;
            try
            {
                using (StreamReader sw = new StreamReader(Properties.Resources.FaNrFile))
                {
                    nrZPliku = int.Parse(sw.ReadLine().ToString());
                    sw.Close();
                }
            }
            catch { MessageBox.Show(Properties.Resources.FileNotFound); }

            nrZPliku = nrZPliku + 1;
            return nrZPliku;
        }
        private void dodajOstatniNrFa()
        {
            using (StreamWriter sw = new StreamWriter(Properties.Resources.FaNrFile))
            {
                var NumerDlaTextBox = textNr.Text;
                sw.Write(NumerDlaTextBox);
                sw.Close();
                textNr.Text = (int.Parse(NumerDlaTextBox) + 1).ToString("d6");
            }
        }
        private void KolumnyNiesotrowalne()
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            //recount ids
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                var current = item.Index + 1;
                dataGridView1.Rows[item.Index].Cells[0].Value = current;
            }
            Summary("Usun");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();

            var MaxID = 0;
            if (dataGridView1.Rows.Count > 1) { MaxID = dataGridView1.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells["Id"].Value)); }

            dataGridView1[0, MaxID].Value = MaxID + 1;
            dataGridView1[6, MaxID].Value = "PLN";

            dataGridView1.ReadOnly = false;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            bool valNettoMissing, valIloscMissing, valNrMatMissing, valNazwaMissing, valJMMissing;
            valNettoMissing = valIloscMissing = valNrMatMissing = valNazwaMissing = valJMMissing = true;

            var errorOccured = 0;
            var rowNumberFroOkIndicator = row.Index;

            for (int i = 1; i < 6; i++)
            {
                try
                {
                    var isValue = row.Cells[i].Value.ToString();
                    row.Cells[i].Style.BackColor = Color.White;
                }
                catch
                {
                    row.Cells[i].Style.BackColor = Color.LightYellow;
                    errorOccured++;
                    ShowStatus = new Thread(() => StatusWorker.WarningBrakCell((rowNumberFroOkIndicator + 1).ToString()));
                    ShowStatus.Start();
                }
            }
            if (errorOccured == 0)
            {
                string valueIlosc = row.Cells[Ilosc.Index].Value.ToString();
                string valueNetto = row.Cells[Netto.Index].Value.ToString();
                var valueBrutto = (double.Parse(valueNetto) * 1.23);
                row.Cells["VAT"].Value = (double.Parse(valueNetto) * 0.23);
                row.Cells["Brutto"].Value = valueBrutto.ToString();
                row.Cells["Razem"].Value = (double.Parse(valueIlosc) * valueBrutto).ToString();
                ShowStatus = new Thread(() => StatusWorker.OkMessageForRow((rowNumberFroOkIndicator + 1).ToString()));
                ShowStatus.Start();

                Summary("");
            }

        }
        private void Summary(string Operacja)
        {
            if (dataGridView1.Rows.Count == 0 && Operacja == "Usun") { labelRazemNetto.Text = "-"; labelRazemBrutto.Text = "-"; return; }
            var labelNetto = 0.0;
            var labelBrutto = 0.0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                string RazemFromItem;
                try { RazemFromItem = item.Cells[9].Value.ToString(); } catch { continue; }
                {
                    labelNetto += (double.Parse(item.Cells[5].Value.ToString()) * double.Parse(item.Cells[3].Value.ToString()));
                    labelBrutto += double.Parse(RazemFromItem);
                }
            }

            labelRazemNetto.Text = labelNetto.ToString() + " PLN";
            labelRazemBrutto.Text = labelBrutto.ToString() + " PLN";
        }
        private void myDatagridView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var hitTestInfo = dataGridView1.HitTest(e.X, e.Y);
                if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
                    dataGridView1.BeginEdit(true);
                else
                    dataGridView1.EndEdit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stream str = Properties.Resources.imperial_march;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void datetimes()
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        dateTimePicker2.Value = DateTime.Today;
                        break;
                    }
                case 1:
                    {
                        dateTimePicker2.Value = DateTime.Today;
                        break;
                    }
                case 2:
                    {
                        dateTimePicker2.Value = DateTime.Today;
                        break;
                    }
                case 3:
                    {
                        dateTimePicker2.Value = dateTimePicker1.Value.AddDays(14);
                        break;
                    }
                case 4:
                    {
                        dateTimePicker2.Value = dateTimePicker1.Value.AddDays(30);
                        break;
                    }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            datetimes();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            datetimes();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dane1.Tables["Header"].Rows.Count > 0 || dane1.Tables["Items"].Rows.Count > 0)
            {
                dane1.Tables["Header"].Rows.Clear();
                dane1.Tables["Items"].Rows.Clear();
            }

            var fanr = textNr.Text + textMiesiac.Text + textRok.Text;
            double razemVat = 0.0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                razemVat += double.Parse(item.Cells["Vat"].Value.ToString());
            }
                dane1.Tables["Header"].Rows.Add(
                fanr,
                dateTimePicker1.Value.Date.ToString("d"),
                dateTimePicker2.Value.Date.ToString("d"),
                textBox2.Text.ToString(),
                textBox3.Text.ToString(),
                textBox1.Text.ToString(),
                comboBox1.Text.ToString(),
                labelRazemNetto.Text.ToString(),
                razemVat.ToString(),
                labelRazemBrutto.Text.ToString()
                );
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                dane1.Tables["Items"].Rows.Add(
                   int.Parse(item.Cells[0].Value.ToString()),
                   item.Cells[1].Value.ToString(),
                   item.Cells[2].Value.ToString(),
                   item.Cells[3].Value.ToString(),
                   item.Cells[4].Value.ToString(),
                   item.Cells[5].Value.ToString(),
                   item.Cells[6].Value.ToString(),
                   item.Cells[7].Value.ToString(),
                   item.Cells[8].Value.ToString(),
                   item.Cells[9].Value.ToString(),
                   fanr
                    );
            }

            Fakturki.Drukowanie Drukowanko = new Drukowanie(dane1, fanr, "Oryginal");
            Drukowanko.Show();
            dodajOstatniNrFa();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sprawdzanie())
            {
                ShowStatus = new Thread(StatusWorker.checkOK);
                ShowStatus.Start();
                button5.Enabled = true;
            }
            else button5.Enabled = false;
        }
        private bool sprawdzanie()
        {
            if (textNr.Text == "" || textMiesiac.Text == "" || textRok.Text == "") { ShowStatus = new Thread(StatusWorker.ErrorNrDok); ShowStatus.Start(); return false; }
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "") { ShowStatus = new Thread(StatusWorker.ErrorKlient); ShowStatus.Start(); return false; }
            if (comboBox1.Text == "Wybierz...") { ShowStatus = new Thread(StatusWorker.ErrorFormaPlatnosci); ShowStatus.Start(); return false; }
            if (dataGridView1.Rows.Count == 0) { ShowStatus = new Thread(StatusWorker.ErrorBrakMaterialow); ShowStatus.Start(); return false; }
            return true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
