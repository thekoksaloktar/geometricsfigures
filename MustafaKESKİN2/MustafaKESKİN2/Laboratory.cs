using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static MustafaKESKİN2.figury_geometryczne;

namespace MustafaKESKİN2
{
    public partial class Laboratory : Form
    {
        const int Margines = 10;
        const int PromienOA = 5;

        public float Xd;
        public float Xg;

        Graphics Rysownica;
        Punkt[] TFG;

        ushort indexTFG;

        public Laboratory()
        {
            InitializeComponent();

            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);

            Rysownica = Graphics.FromImage(pbRysownica.Image);
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            ushort N;
            errorProvider1.Dispose();

            if (!ushort.TryParse(txtN.Text, out N))
            {
                errorProvider1.SetError(txtN, "ERROR: w zapisie liczby figur wystąpił błąd: niedozwolony znak");
                return;
            }

            txtN.Enabled = false;

            if (chlbFigury.CheckedItems.Count > 0)
            {
                btnStart.Enabled = true;
            }

            else
            {
                errorProvider1.SetError(chlbFigury, "UWAGA: musisz zaznaczyć (wybrać) co najmniej jedna figurę geometryczną");
            }
        }

        private void chlbFigury_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();

            if (!txtN.Enabled)
            {
                btnStart.Enabled = true;
            }
        }

        private void Laboratory_Load(object sender, EventArgs e)
        {
            //chlbFigury.Location = new Point(pbRysownica.Location.X +S pbRysownica.Width + Margines, pbRysownica.Location.Y);
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            //deklaracje pomocnicze 
            Random rnd = new Random();
            int Xn, Yn;
            int Xmax, Ymax;
            //wyczyszczenie powierzchni graficznej 
            Rysownica.Clear(pbRysownica.BackColor);

            //odczytanie rozmiarów powierzchni graficznej
            Xmax = pbRysownica.Width;
            Ymax = pbRysownica.Height;
            //przesunięcie wszystkich figur
            for (int i = 0; i < TFG.Length; i++)
            {
                //wulosowanie 
                Xn = rnd.Next(Margines, Xmax - Margines);
                Yn = rnd.Next(Margines, Ymax - Margines);

                //przesunięcie z wykreśliniem i-tej figury geom
                TFG[i].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xn, Yn);
            }
            //odswonięcie powierzchni graficznej
            pbRysownica.Refresh();
        }*/

        private void btnPoprzednia_Click(object sender, EventArgs e)
        {
            int N = int.Parse(txtNumerFigury.Text);
            TFG[N].Wymaż(pbRysownica, Rysownica);

            if (N == 0)
            {
                N = TFG.Length - 1;
            }

            else
            {
                N--;
                int Xmax = pbRysownica.Width;
                int Ymax = pbRysownica.Height;

                TFG[N].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
                pbRysownica.Refresh();

                txtNumerFigury.Text = N.ToString();
            }
        }

        private void btnNąstępna_Click(object sender, EventArgs e)
        {
            int N = int.Parse(txtNumerFigury.Text);

            TFG[N].Wymaż(pbRysownica, Rysownica);

            if (N == TFG.Length - 1)
            {
                N = 0;
            }

            else
            {
                N += 1;
                int Xmax = pbRysownica.Width;
                int Ymax = pbRysownica.Height;

                TFG[N].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
                pbRysownica.Refresh();

                txtNumerFigury.Text = N.ToString();
            }
        }

        private void txtNumerFigury_TextChanged(object sender, EventArgs e)
        {
            ushort N;

            if (!ushort.TryParse(txtNumerFigury.Text, out N))
            {
                errorProvider1.SetError(txtNumerFigury, "ERROR: w podanym zapisie numeru (indeksu) wystąpił niedozwolony znak");
                return;
            }

            if (N > TFG.Length - 1)
            {
                errorProvider1.SetError(txtNumerFigury, "ERROR: podany numer (indeks) wykracza poza zakres indeksów");
                return;
            }
        }

        private void rdbManual_CheckedChanged(object sender, EventArgs e)
        {
            txtNumerFigury.Enabled = true;
            txtNumerFigury.Text = 0.ToString();
        }

        private void btnWłącz_Click(object sender, EventArgs e)
        {
            Rysownica.Clear(pbRysownica.BackColor);
            pbRysownica.Refresh();

            if (rdbAutomatyczny.Checked)
            {
                timer1.Tag = 0;
                timer1.Enabled = true;
            }

            else
            {
                txtNumerFigury.Text = 0.ToString();
                int N;
                N = int.Parse(txtNumerFigury.Text);

                int Xmax = pbRysownica.Width;
                int Ymax = pbRysownica.Height;

                TFG[N].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
                pbRysownica.Refresh();

                btnNąstępna.Enabled = true;
                btnPoprzednia.Enabled = true;
            }

            btnWłącz.Enabled = false;
            btnWyłącz.Enabled = true;
        }

        private void btnWyłącz_Click(object sender, EventArgs e)
        {
            Rysownica.Clear(pbRysownica.BackColor);
            timer1.Enabled = false;
            btnWyłącz.Enabled = false;
            btnWłącz.Enabled = true;

            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            int Xn, Yn;
            Random rnd = new Random();

            for (int i = 0; i < TFG.Length; i++)
            {
                Xn = rnd.Next(Margines, Xmax - Margines);
                Yn = rnd.Next(Margines, Ymax - Margines);
                TFG[i].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xn, Yn);
            }

            pbRysownica.Refresh();
            btnNąstępna.Enabled = false;
            btnPoprzednia.Enabled = false;
            txtNumerFigury.Enabled = false;
            rdbAutomatyczny.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Rysownica.Clear(pbRysownica.BackColor);

            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            int N = int.Parse(timer1.Tag.ToString());

            TFG[(int)timer1.Tag].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
            pbRysownica.Refresh();

            timer1.Tag = (N + 1) % (TFG.Length);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();

            Random rnd = new Random();
            int Xmax, Ymax;
            int Xp, Yp;
            Color Kolor;
            float GrubośćLinii;
            DashStyle StylLinii;

            ushort N;
            N = ushort.Parse(txtN.Text);
            TFG = new Punkt[N];

            indexTFG = 0;

            CheckedListBox.CheckedItemCollection WybraneFG = chlbFigury.CheckedItems;
            Xmax = pbRysownica.Width; Ymax = pbRysownica.Height;

            for (ushort i = 0; i < N; i++)
            {
                Xp = rnd.Next(Margines, Xmax - Margines);
                Yp = rnd.Next(Margines, Ymax - Margines);
                Kolor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
                GrubośćLinii = (float)(rnd.NextDouble() * (double)(Margines - 0.5) + 0.5);

                switch (rnd.Next(0, 5))
                {
                    case 0: StylLinii = DashStyle.Solid; break;
                    case 1: StylLinii = DashStyle.Dash; break;
                    case 2: StylLinii = DashStyle.Dot; break;
                    case 3: StylLinii = DashStyle.DashDot; break;
                    case 4: StylLinii = DashStyle.DashDotDot; break;
                    default: StylLinii = DashStyle.Solid; break;
                }

                switch (WybraneFG[rnd.Next(WybraneFG.Count)].ToString())
                {
                    case "Punkt":
                    {
                        TFG[indexTFG] = new Punkt(Xp, Yp, Kolor);
                        TFG[indexTFG].Wykreśl(Rysownica);

                        indexTFG++;
                        break;

                    }

                    case "Linia":
                    {
                        int Xk = rnd.Next(Margines, Xmax - Margines);
                        int Yk = rnd.Next(Margines, Ymax - Margines);

                        TFG[indexTFG] = new Linia(Xp, Yp, Xk, Yk, Kolor, StylLinii, GrubośćLinii);
                        TFG[indexTFG].Wykreśl(Rysownica);

                        indexTFG++;
                        break;
                    }

                    case "Elipsa":
                    {
                        int OśDuża = rnd.Next(Margines, Xmax / 4);
                        int OśMała = rnd.Next(Margines, Ymax / 6);

                        TFG[indexTFG] = new Elipsa(Xp, Yp, OśDuża, OśMała, Kolor, StylLinii, GrubośćLinii);
                        TFG[indexTFG].Wykreśl(Rysownica);

                        indexTFG++;
                        break;
                    }

                    case "Okrąg":
                    {
                        int Promień = rnd.Next(Margines, Xmax / 4);

                        TFG[indexTFG] = new Okrąg(Xp, Yp, Promień, Kolor, StylLinii, GrubośćLinii);
                        TFG[indexTFG].Wykreśl(Rysownica);

                        indexTFG++;
                        break;
                    }

                    default:
                    {
                        MessageBox.Show("UWAGA: tej figury jeszcze nie wykreślam"); break;
                    }
                }
            }

            pbRysownica.Refresh();
            btnStart.Enabled = false;
            btnPrzesunDoNowegoXY.Enabled = true;
            btnWłącz.Enabled = true;
            gpbTrypPokazu.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartWindow form1 = new StartWindow();
            form1.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Laboratory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            MessageBox.Show("Autor programu: Mustafa Emirhan KESKIN: Nr albumu 64481.");
        }
        private void start_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}