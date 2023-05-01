using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MustafaKESKİN2.Figury_Geometryczne_Project;

namespace MustafaKESKİN2
{
    public partial class Project : Form
    {
        Graphics MKRysownica;
        int MKMargines = 10;

        Point MKPunkt;

        List<Punkt> MKLFG = new List<Punkt>();
        Font MKFontOpisuPunktów = new Font("Arial", 10, FontStyle.Bold);

        struct OpisKrzywejBeziera
        {
            public Point MKPunktP0;
            public Point MKPunktP1;
            public Point MKPunktP2;
            public Point MKPunktP3;
            public ushort MKNumerPunktuKontrolnego;
            public float MKPromienPunktuKontrolnego;
        }

        OpisKrzywejBeziera KrzywaBeziera;

        struct OpisKrzywejKardynalnej
        {
            public Point MKPunktP0;
            public Point MKPunktP1;
            public Point MKPunktP2;
            public Point MKPunktP3;
            public ushort MKNumerPunktu;
            public float MKPromienPunktu;
        }

        OpisKrzywejKardynalnej KrzywaKard;

        public Project()
        {
            InitializeComponent();
            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);
            MKRysownica = Graphics.FromImage(pbRysownica.Image);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Hide();
            Project form3 = new Project();
            form3.Show();
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

        private void Project_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            MessageBox.Show("Autor programu: Mustafa Emirhan KESKIN: Nr albumu 64481.");
        }

        private void pbRysownica_MouseDown(object sender, MouseEventArgs e)
        {
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();

            if (e.Button == MouseButtons.Left)
            {
                MKPunkt = e.Location;
            }
        }

        private void pbRysownica_MouseUp(object sender, MouseEventArgs e)
        {
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();

            int MKLewyGórnyNarożnikX = (MKPunkt.X > e.Location.X) ? e.Location.X : MKPunkt.X;
            int MKLewyGórnyNarożnikY = (MKPunkt.Y > e.Location.Y) ? e.Location.Y : MKPunkt.Y;
            int MKSzerokość = Math.Abs(MKPunkt.X - e.Location.X);
            int MKWysokość = Math.Abs(MKPunkt.Y - e.Location.Y);

            if (e.Button == MouseButtons.Left)
            {
                if (rdbPunkt.Checked)
                {
                    MKLFG.Add(new Punkt(MKPunkt.X, MKPunkt.Y, btnKolorLinii.BackColor));
                    MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                }

                if (rdbLinia.Checked)
                {
                    MKLFG.Add(new Linia(MKPunkt.X, MKPunkt.Y, e.Location.X, e.Location.Y, btnKolorLinii.BackColor, (DashStyle)cmbStylLinii.SelectedIndex, trackBar1.Value));
                    MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                }

                if (rdbKwadrat.Checked)
                {
                    MKLFG.Add(new Kwadrat(MKPunkt.X, MKPunkt.Y, MKSzerokość, btnKolorLinii.BackColor, (DashStyle)cmbStylLinii.SelectedIndex, trackBar1.Value));
                    MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                }

                if (rdbFillRect.Checked)
                {
                    MKLFG.Add(new KwadratWyp(MKPunkt.X, MKPunkt.Y, MKSzerokość, btnKolorWyp.BackColor, (DashStyle)cmbStylLinii.SelectedIndex, trackBar1.Value));
                    MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                }

                if (rdbProstokąt.Checked)
                {
                    MKLFG.Add(new Prostokąt(MKPunkt.X, MKPunkt.Y, MKSzerokość, MKWysokość, btnKolorLinii.BackColor, (DashStyle)(cmbStylLinii.SelectedIndex), trackBar1.Value));
                    MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                }

                if (rdbProstokWyp.Checked)
                {
                    MKLFG.Add(new ProstokątWyp(MKPunkt.X, MKPunkt.Y, MKSzerokość, MKWysokość, btnKolorWyp.BackColor, (DashStyle)cmbStylLinii.SelectedIndex, trackBar1.Value));
                    MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                }

                if (rdbOkrąg.Checked)
                {
                    MKLFG.Add(new Okrąg(MKPunkt.X, MKPunkt.Y, MKSzerokość, btnKolorLinii.BackColor, (DashStyle)(cmbStylLinii.SelectedIndex), trackBar1.Value));
                    MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                }

                if (rdbKoło.Checked)
                {
                    MKLFG.Add(new Koło(MKPunkt.X, MKPunkt.Y, MKSzerokość, btnKolorWyp.BackColor, (DashStyle)cmbStylLinii.SelectedIndex, trackBar1.Value));
                    MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                }

                if (rdbElipsa.Checked)
                {
                    MKLFG.Add(new Elipsa(MKPunkt.X, MKPunkt.Y, MKSzerokość, MKWysokość, btnKolorLinii.BackColor, (DashStyle)cmbStylLinii.SelectedIndex, trackBar1.Value));
                    MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                }

                if (rdbFillElipse.Checked)
                {
                    MKLFG.Add(new FillElipsa(MKPunkt.X, MKPunkt.Y, MKSzerokość, MKWysokość, btnKolorWyp.BackColor, (DashStyle)cmbStylLinii.SelectedIndex, trackBar1.Value));
                    MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                }

                if (rdbDrawArc.Checked)
                {
                    MKLFG.Add(new ŁukElipsy(MKPunkt.X, MKPunkt.Y, MKSzerokość, MKWysokość, e.Location.X, e.Location.Y, btnKolorLinii.BackColor, (DashStyle)cmbStylLinii.SelectedIndex, trackBar1.Value));
                    MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                }

                if (rdbDrawPie.Checked)
                {
                    MKLFG.Add(new DrawPie(MKPunkt.X, MKPunkt.Y, MKSzerokość, MKWysokość, e.Location.X, e.Location.Y, btnKolorLinii.BackColor, (DashStyle)cmbStylLinii.SelectedIndex, trackBar1.Value));
                    MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                }

                if (rdbFillPie.Checked)
                {
                    MKLFG.Add(new FillPie(MKPunkt.X, MKPunkt.Y, MKSzerokość, MKWysokość, e.Location.X, e.Location.Y, btnKolorWyp.BackColor, (DashStyle)cmbStylLinii.SelectedIndex, trackBar1.Value)); ;
                    MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                }

                if (rdbWielokatForemny.Checked)
                {
                    MKLFG.Add(new Wielokąt_Foremny(MKLewyGórnyNarożnikX, MKLewyGórnyNarożnikY, (ushort)(NumLiczbaKątów.Value), MKSzerokość, btnKolorLinii.BackColor, (DashStyle)(cmbStylLinii.SelectedIndex), trackBar1.Value));
                    MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                }

                if (rdbWielokatWyp.Checked)
                {
                    MKLFG.Add(new Wielokąt_Wypełniony(MKPunkt.X, MKPunkt.Y, (ushort)(NumLiczbaKątów.Value), MKSzerokość, btnKolorWyp.BackColor, (DashStyle)cmbStylLinii.SelectedIndex, trackBar1.Value));
                    MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                }

                if (rdbLiniaCiągła.Checked)
                {
                    MKLFG.Add(new LiniaCiągła(MKPunkt.X, MKPunkt.Y, e.Location.X, e.Location.Y, btnKolorLinii.BackColor, (DashStyle)(cmbStylLinii.SelectedIndex), trackBar1.Value));
                    MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                }

                if (rdbKrzywaBeziera.Checked)
                {
                    if (groupBox1.Enabled)
                    {
                        groupBox1.Enabled = false;

                        KrzywaBeziera.MKNumerPunktuKontrolnego = 0;
                        KrzywaBeziera.MKPromienPunktuKontrolnego = 5;

                        KrzywaBeziera.MKPunktP0 = MKPunkt;
                        MKLFG.Add(new Punkt(MKPunkt.X, MKPunkt.Y, btnKolorLinii.BackColor));
                        MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);

                        MKLFG.Add(new DrawString(MKPunkt.X, MKPunkt.Y, "p" + KrzywaBeziera.MKNumerPunktuKontrolnego.ToString(), MKFontOpisuPunktów, btnKolorWyp.BackColor));
                        MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                    }

                    else
                    {
                        KrzywaBeziera.MKNumerPunktuKontrolnego++;

                        switch (KrzywaBeziera.MKNumerPunktuKontrolnego)
                        {
                            case 1:
                                KrzywaBeziera.MKPunktP1 = MKPunkt;
                                break;
                            case 2:
                                KrzywaBeziera.MKPunktP2 = MKPunkt;
                                break;
                            case 3:
                                KrzywaBeziera.MKPunktP3 = MKPunkt;
                                break;
                        }

                        if (KrzywaBeziera.MKNumerPunktuKontrolnego < 3)
                        {
                            MKLFG.Add(new Punkt(MKPunkt.X, MKPunkt.Y, btnKolorLinii.BackColor));
                            MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);

                            MKLFG.Add(new DrawString(MKPunkt.X, MKPunkt.Y, "p" + KrzywaBeziera.MKNumerPunktuKontrolnego.ToString(), MKFontOpisuPunktów, btnKolorWyp.BackColor));
                            MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                        }

                        else
                        {
                            MKLFG.Add(new Punkt(MKPunkt.X, MKPunkt.Y, btnKolorLinii.BackColor));
                            MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);

                            MKLFG.Add(new DrawString(MKPunkt.X, MKPunkt.Y, "p" + KrzywaBeziera.MKNumerPunktuKontrolnego.ToString(), MKFontOpisuPunktów, btnKolorWyp.BackColor));
                            MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);

                            MKLFG.Add(new DrawBezier(KrzywaBeziera.MKPunktP0, KrzywaBeziera.MKPunktP1, KrzywaBeziera.MKPunktP2, KrzywaBeziera.MKPunktP3, btnKolorLinii.BackColor, (DashStyle)cmbStylLinii.SelectedIndex, trackBar1.Value));
                            MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);

                            groupBox1.Enabled = true;
                        }
                    }
                }

                if (rdbKrzywaKardynalna.Checked)
                {
                    if (groupBox1.Enabled)
                    {
                        groupBox1.Enabled = false;

                        KrzywaKard.MKNumerPunktu = 0;
                        KrzywaKard.MKPromienPunktu = 5;

                        KrzywaKard.MKPunktP0 = MKPunkt;
                        MKLFG.Add(new Punkt(MKPunkt.X, MKPunkt.Y, btnKolorLinii.BackColor));
                        MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);

                        MKLFG.Add(new DrawString(MKPunkt.X, MKPunkt.Y, "p" + KrzywaKard.MKNumerPunktu.ToString(), MKFontOpisuPunktów, btnKolorWyp.BackColor));
                        MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                    }

                    else
                    {
                        KrzywaKard.MKNumerPunktu++;

                        switch (KrzywaKard.MKNumerPunktu)
                        {
                            case 1:
                                KrzywaKard.MKPunktP1 = MKPunkt;
                                break;
                            case 2:
                                KrzywaKard.MKPunktP2 = MKPunkt;
                                break;
                            case 3:
                                KrzywaKard.MKPunktP3 = MKPunkt;
                                break;
                        }

                        if (KrzywaKard.MKNumerPunktu < 3)
                        {
                            MKLFG.Add(new Punkt(MKPunkt.X, MKPunkt.Y, btnKolorLinii.BackColor));
                            MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);

                            MKLFG.Add(new DrawString(MKPunkt.X, MKPunkt.Y, "p" + KrzywaKard.MKNumerPunktu.ToString(), MKFontOpisuPunktów, btnKolorWyp.BackColor));
                            MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                        }

                        else
                        {
                            MKLFG.Add(new Punkt(MKPunkt.X, MKPunkt.Y, btnKolorLinii.BackColor));
                            MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);

                            MKLFG.Add(new DrawString(MKPunkt.X, MKPunkt.Y, "p" + KrzywaKard.MKNumerPunktu.ToString(), MKFontOpisuPunktów, btnKolorWyp.BackColor));
                            MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);

                            MKLFG.Add(new KrzywaKardynalna(KrzywaKard.MKPunktP0, KrzywaKard.MKPunktP1, KrzywaKard.MKPunktP2, KrzywaKard.MKPunktP3, btnKolorLinii.BackColor, (DashStyle)cmbStylLinii.SelectedIndex, trackBar1.Value));
                            MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);

                            groupBox1.Enabled = true;
                        }
                    }
                }

                if (rdbDrawClosedCurve.Checked)
                {
                    if (groupBox1.Enabled)
                    {
                        groupBox1.Enabled = false;

                        KrzywaKard.MKNumerPunktu = 0;
                        KrzywaKard.MKPromienPunktu = 5;

                        KrzywaKard.MKPunktP0 = MKPunkt;
                        MKLFG.Add(new Punkt(MKPunkt.X, MKPunkt.Y, btnKolorLinii.BackColor));
                        MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);

                        MKLFG.Add(new DrawString(MKPunkt.X, MKPunkt.Y, "p" + KrzywaKard.MKNumerPunktu.ToString(), MKFontOpisuPunktów, btnKolorWyp.BackColor));
                        MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                    }

                    else
                    {
                        KrzywaKard.MKNumerPunktu++;

                        switch (KrzywaKard.MKNumerPunktu)
                        {
                            case 1:
                                KrzywaKard.MKPunktP1 = MKPunkt;
                                break;
                            case 2:
                                KrzywaKard.MKPunktP2 = MKPunkt;
                                break;
                            case 3:
                                KrzywaKard.MKPunktP3 = MKPunkt;
                                break;
                        }

                        if (KrzywaKard.MKNumerPunktu < 3)
                        {
                            MKLFG.Add(new Punkt(MKPunkt.X, MKPunkt.Y, btnKolorLinii.BackColor));
                            MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);

                            MKLFG.Add(new DrawString(MKPunkt.X, MKPunkt.Y, "p" + KrzywaKard.MKNumerPunktu.ToString(), MKFontOpisuPunktów, btnKolorWyp.BackColor));
                            MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                        }

                        else
                        {
                            MKLFG.Add(new Punkt(MKPunkt.X, MKPunkt.Y, btnKolorLinii.BackColor));
                            MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);

                            MKLFG.Add(new DrawString(MKPunkt.X, MKPunkt.Y, "p" + KrzywaKard.MKNumerPunktu.ToString(), MKFontOpisuPunktów, btnKolorWyp.BackColor));
                            MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);

                            MKLFG.Add(new ZamkniętaKrzywaKardynalna(KrzywaKard.MKPunktP0, KrzywaKard.MKPunktP1, KrzywaKard.MKPunktP2, KrzywaKard.MKPunktP3, btnKolorLinii.BackColor, (DashStyle)cmbStylLinii.SelectedIndex, trackBar1.Value));
                            MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);

                            groupBox1.Enabled = true;
                        }
                    }
                }

                if (rdbFillClosedCurve.Checked)
                {
                    if (groupBox1.Enabled)
                    {
                        groupBox1.Enabled = false;

                        KrzywaKard.MKNumerPunktu = 0;
                        KrzywaKard.MKPromienPunktu = 5;

                        KrzywaKard.MKPunktP0 = MKPunkt;
                        MKLFG.Add(new Punkt(MKPunkt.X, MKPunkt.Y, btnKolorLinii.BackColor));
                        MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);

                        MKLFG.Add(new DrawString(MKPunkt.X, MKPunkt.Y, "p" + KrzywaKard.MKNumerPunktu.ToString(), MKFontOpisuPunktów, btnKolorWyp.BackColor));
                        MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                    }

                    else
                    {
                        KrzywaKard.MKNumerPunktu++;

                        switch (KrzywaKard.MKNumerPunktu)
                        {
                            case 1:
                                KrzywaKard.MKPunktP1 = MKPunkt;
                                break;
                            case 2:
                                KrzywaKard.MKPunktP2 = MKPunkt;
                                break;
                            case 3:
                                KrzywaKard.MKPunktP3 = MKPunkt;
                                break;
                        }

                        if (KrzywaKard.MKNumerPunktu < 3)
                        {
                            MKLFG.Add(new Punkt(MKPunkt.X, MKPunkt.Y, btnKolorLinii.BackColor));
                            MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);

                            MKLFG.Add(new DrawString(MKPunkt.X, MKPunkt.Y, "p" + KrzywaKard.MKNumerPunktu.ToString(), MKFontOpisuPunktów, btnKolorWyp.BackColor));
                            MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                        }

                        else
                        {
                            MKLFG.Add(new Punkt(MKPunkt.X, MKPunkt.Y, btnKolorLinii.BackColor));
                            MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);

                            MKLFG.Add(new DrawString(MKPunkt.X, MKPunkt.Y, "p" + KrzywaKard.MKNumerPunktu.ToString(), MKFontOpisuPunktów, btnKolorWyp.BackColor));
                            MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);

                            MKLFG.Add(new ZamkniętaWypełnionaKrzywaKardynalna(KrzywaKard.MKPunktP0, KrzywaKard.MKPunktP1, KrzywaKard.MKPunktP2, KrzywaKard.MKPunktP3, btnKolorLinii.BackColor, (DashStyle)cmbStylLinii.SelectedIndex, trackBar1.Value));
                            MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);

                            groupBox1.Enabled = true;
                        }
                    }
                }
            }

            pbRysownica.Refresh();
        }

        private void rdbKrzywaBeziera_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKrzywaBeziera.Checked)
            {
                MessageBox.Show("Wykreślenie krzywej beziera wymaga zaznaczenia(kliknięciem) 4 punktów na Rysownicy", "Kreślenie krzywej Beziera", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rdbKrzywaKardynalna_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKrzywaKardynalna.Checked)
            {
                MessageBox.Show("Wykreślenie krzywej kardynalnej wymaga zaznaczenia(kliknięciem) 4 punktów na Rysownicy", "Kreślenie krzywej kardynalnej", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rdbDrawClosedCurve_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDrawClosedCurve.Checked)
            {
                MessageBox.Show("Wykreślenie zamkniętej krzywej kardynalnej wymaga zaznaczenia(kliknięciem) 4 punktów na Rysownicy", "Kreślenie zamkniętej krzywej kardynalnej", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rdbFillClosedCurve_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFillClosedCurve.Checked)
            {
                MessageBox.Show("Wykreślenie zamkniętej  wypełnionej krzywej kardynalnej wymaga zaznaczenia(kliknięciem) 4 punktów na Rysownicy", "Kreślenie zamkniętej wypełnionej krzywej kardynalnej", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pbRysownica_MouseMove(object sender, MouseEventArgs e)
        {
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();

            int MKLewyGórnyNarożnikX = (MKPunkt.X > e.Location.X) ? e.Location.X : MKPunkt.X;
            int MKLewyGórnyNarożnikY = (MKPunkt.Y > e.Location.Y) ? e.Location.Y : MKPunkt.Y;
            int MKSzerokość = Math.Abs(MKPunkt.X - e.Location.X);
            int MKWysokość = Math.Abs(MKPunkt.Y - e.Location.Y);

            if (e.Button == MouseButtons.Left)
            {
                if (rdbLiniaCiągła.Checked)
                {
                    MKLFG.Add(new LiniaCiągła(MKPunkt.X, MKPunkt.Y, e.Location.X, e.Location.Y, btnKolorLinii.BackColor, (DashStyle)(cmbStylLinii.SelectedIndex), trackBar1.Value));
                    MKLFG[MKLFG.Count - 1].Wykreśl(MKRysownica);
                    MKPunkt = e.Location;
                }
            }

            pbRysownica.Refresh();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            int MKXn, MKYn;
            Random MKrnd = new Random();

            MKRysownica.Clear(pbRysownica.BackColor);

            int MKXmax = pbRysownica.Width;
            int MKYmax = pbRysownica.Height;

            for (int MKi = 0; MKi < MKLFG.Count; MKi++)
            {
                MKXn = MKrnd.Next(MKMargines, MKXmax - MKMargines);
                MKYn = MKrnd.Next(MKMargines, MKYmax - MKMargines);

                MKLFG[MKi].PrzesunDoNowegoXY(pbRysownica, MKRysownica, MKXn, MKYn);
            }

            pbRysownica.Refresh();
        }

        private void rdbWielokatForemny_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWielokatForemny.Checked)
            {
                NumLiczbaKątów.Visible = true;
                txtLiczbaKątów.Visible = true;
                NumLiczbaKątów.Value = 3;
                NumLiczbaKątów.Enabled = true;
            }

            else
            {
                NumLiczbaKątów.Visible = false;
                txtLiczbaKątów.Visible = false;
            }
        }

        private void rdbWielokatWyp_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWielokatWyp.Checked)
            {
                NumLiczbaKątów.Visible = true;
                txtLiczbaKątów.Visible = true;
                NumLiczbaKątów.Value = 3;
                NumLiczbaKątów.Enabled = true;
            }

            else
            {
                NumLiczbaKątów.Visible = false;
                txtLiczbaKątów.Visible = false;
            }
        }

        private void btnKolorLinii_Click(object sender, EventArgs e)
        {
            ColorDialog MKpaletaKolorów = new ColorDialog();
            if (MKpaletaKolorów.ShowDialog() == DialogResult.OK)
            {
                btnKolorLinii.BackColor = MKpaletaKolorów.Color;
            }
        }

        private void btnKolorWyp_Click(object sender, EventArgs e)
        {
            ColorDialog MKpaletaKolorów = new ColorDialog();
            if (MKpaletaKolorów.ShowDialog() == DialogResult.OK)
            {
                btnKolorWyp.BackColor = MKpaletaKolorów.Color;
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog MKZapisanieBitMapy = new SaveFileDialog();
            MKZapisanieBitMapy.Filter = "Image Files|*.jpg;*.jpeg;*.png|Allfiles(*.*.)|*.*";
            MKZapisanieBitMapy.FilterIndex = 1;
            MKZapisanieBitMapy.RestoreDirectory = true;
            MKZapisanieBitMapy.InitialDirectory = "C:\\";
            MKZapisanieBitMapy.Title = "Zapisz BitMapę";

            if (MKZapisanieBitMapy.ShowDialog() == DialogResult.OK)
            {
                int MKSzerokośćRysownicy = Convert.ToInt32(pbRysownica.Width);
                int MKWysokośćRysownicy = Convert.ToInt32(pbRysownica.Height);

                using (Bitmap bmp = new Bitmap(MKSzerokośćRysownicy, MKWysokośćRysownicy))
                {
                    pbRysownica.DrawToBitmap(bmp, new Rectangle(0, 0, MKSzerokośćRysownicy, MKWysokośćRysownicy));
                    bmp.Save(MKZapisanieBitMapy.FileName, ImageFormat.Jpeg);
                }
            }
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog MKOdczytanieBitMapy = new OpenFileDialog();
            MKOdczytanieBitMapy.Title = "Odczytaj BitMapę";
            MKOdczytanieBitMapy.Filter = "Image Files|*.jpg;*.jpeg;*.png|Allfiles(*.*.)|*.*";
            MKOdczytanieBitMapy.FilterIndex = 1;
            MKOdczytanieBitMapy.RestoreDirectory = true;
            MKOdczytanieBitMapy.InitialDirectory = "C:\\";

            if (MKOdczytanieBitMapy.ShowDialog() == DialogResult.OK)
            {
                pbRysownica.Image = new Bitmap(MKOdczytanieBitMapy.FileName);
                this.Controls.Add(pbRysownica);
            }

            MKOdczytanieBitMapy.Dispose();
        }

        private void btnPokazFigur_Click(object sender, EventArgs e)
        {
            MKRysownica.Clear(pbRysownica.BackColor);
            pbRysownica.Refresh();

            if (rdbAutomatyczny.Checked)
            {
                timer1.Tag = 0.ToString();
                timer1.Enabled = true;
                btnWylaczPokazFigur.Enabled = true;
                btnWylaczPokazFigur.Enabled = false;

            }

            else
            {
                txtNumerFigury.Text = 0.ToString();
                int MKN;
                MKN = int.Parse(txtNumerFigury.Text);

                int MKXmax = pbRysownica.Width;
                int MKYmax = pbRysownica.Height;

                MKLFG[MKN].PrzesunDoNowegoXY(pbRysownica, MKRysownica, MKXmax / 2, MKYmax / 2);
                pbRysownica.Refresh();

                btnNastępny.Enabled = true;
                btnPoprzedni.Enabled = true;
            }

            btnPokazFigur.Enabled = false;
            btnWylaczPokazFigur.Enabled = true;
        }

        private void rdbManualny_CheckedChanged(object sender, EventArgs e)
        {
            txtNumerFigury.Enabled = true;
            txtNumerFigury.Text = 0.ToString();
        }

        private void txtNumerFigury_TextChanged(object sender, EventArgs e)
        {
            ushort MKN;
            if (!ushort.TryParse(txtNumerFigury.Text, out MKN))
            {
                errorProvider1.SetError(txtNumerFigury, "ERROR: w zapisie Numeru figury geometrycznej wystął niedozwolony znak");
                return;

            }

            if (MKN > MKLFG.Count)
            {
                errorProvider1.SetError(txtNumerFigury, "ERROR:nastąpoło przekroczenie liczby figur geometrycznych w LFG");
                return;
            }
        }

        private void btnNastępny_Click(object sender, EventArgs e)
        {
            int MKN = int.Parse(txtNumerFigury.Text);
            MKLFG[MKN].Wymaż(pbRysownica, MKRysownica);

            if (MKN == MKLFG.Count - 1)
            {
                MKN = 0;
            }

            else
            {
                MKN++;

                int MKXmax = pbRysownica.Width;
                int MKYmax = pbRysownica.Height;

                MKLFG[MKN].PrzesunDoNowegoXY(pbRysownica, MKRysownica, MKXmax / 2, MKYmax / 2);
                pbRysownica.Refresh();

                txtNumerFigury.Text = MKN.ToString();
            }
        }

        private void btnPoprzedni_Click(object sender, EventArgs e)
        {
            int MKN = int.Parse(txtNumerFigury.Text);
            MKLFG[MKN].Wymaż(pbRysownica, MKRysownica);

            if (MKN == 0)
            {
                MKN = MKLFG.Count;
            }

            else
            {
                MKN -= 1;

                int MKXmax = pbRysownica.Width;
                int MKYmax = pbRysownica.Height;

                MKLFG[MKN].PrzesunDoNowegoXY(pbRysownica, MKRysownica, MKXmax / 2, MKYmax / 2);
                pbRysownica.Refresh();

                txtNumerFigury.Text = MKN.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MKRysownica.Clear(pbRysownica.BackColor);

            int MKXmax = pbRysownica.Width;
            int MKYmax = pbRysownica.Height;
            int N = int.Parse(timer1.Tag.ToString());

            MKLFG[N].PrzesunDoNowegoXY(pbRysownica, MKRysownica, MKXmax / 2, MKYmax / 2);
            pbRysownica.Refresh();

            timer1.Tag = (N + 1) % (MKLFG.Count - 1);
        }

        private void btnWylaczPokazFigur_Click(object sender, EventArgs e)
        {
            MKRysownica.Clear(pbRysownica.BackColor);

            timer1.Enabled = false;
            btnWylaczPokazFigur.Enabled = false;
            btnPokazFigur.Enabled = true;

            int MKXmax = pbRysownica.Width;
            int MKYmax = pbRysownica.Height;

            int MKXn, MKYn;
            Random MKrnd = new Random();

            for (int MKi = 0; MKi < MKLFG.Count; MKi++)
            {
                MKXn = MKrnd.Next(MKMargines, MKXmax - MKMargines);
                MKYn = MKrnd.Next(MKMargines, MKYmax - MKMargines);
                MKLFG[MKi].PrzesunDoNowegoXY(pbRysownica, MKRysownica, MKXn, MKYn);
            }

            pbRysownica.Refresh();

            btnNastępny.Enabled = false;
            btnPoprzedni.Enabled = false;
            txtNumerFigury.Enabled = false;
            rdbAutomatyczny.Enabled = false;
        }

        private void Project_Load(object sender, EventArgs e)
        {

        }
    }
}