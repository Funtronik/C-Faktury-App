using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fakturki
{
    public class StatusWorker
    {
        public ToolStripLabel przekazanyLabel;

        private void pokaz(string Message,string typMessage)
        {
            this.przekazanyLabel.Text = Message;
            przekazanyLabel.Visible = true;
            switch (typMessage)
            {
                case "war":
                    {
                        przekazanyLabel.Image = Properties.Resources.warning;
                        break;
                    }
                case "ok":
                    {
                        przekazanyLabel.Image = Properties.Resources.OK;
                        break;
                    }
                case "err":
                    {
                        przekazanyLabel.Image = Properties.Resources.Error;
                        break;
                    }
            }
            Thread.Sleep(10000);
        }
        private void ukryj()
        {
            przekazanyLabel.Visible = false;
            przekazanyLabel.Text = "MESSAGE";
            przekazanyLabel.Image = null;
        }
        public void WarningBrakCell(string RowIndex)
        {
            var tresc = "Brakuje wartości w komórce wiersza: " + RowIndex + " !";
            pokaz(tresc,"war");
            ukryj();
        }

        public void OkMessageForRow(string RowIndex)
        {
            var tresc = "Wiersz " + RowIndex + " jest teraz poprawny !";
            pokaz(tresc,"ok");
            ukryj();
        }

        public void checkOK()
        {
            pokaz("Dokument poprawnie wygenerowany. Można wydrukować !","ok");
            ukryj();
        }
        public void ErrorNrDok()
        {
            pokaz("Numer dokumentu zawiera błędy. Popraw !","err");
            ukryj();
        }
        public void ErrorKlient()
        {
            pokaz("Dane klienta zawierają błędy. Popraw !","err");
            ukryj();
        }
        public void ErrorFormaPlatnosci()
        {
            pokaz("Nie wybrano formy płatności. Popraw !","err");
            ukryj();
        }
        public void ErrorBrakMaterialow()
        {
            pokaz("Nie dodano żadnych materiałów. Popraw !", "err");
            ukryj();
        }
        public void ErrorSekcjaMaterialowZawieraWarningi()
        {
            pokaz("Sekcja materiałów zawiera błędy. Uzupełnij !","err");
            ukryj();
        }
    }
}
