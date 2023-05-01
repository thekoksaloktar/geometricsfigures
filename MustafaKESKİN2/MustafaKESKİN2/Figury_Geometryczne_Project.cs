using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MustafaKESKİN2
{
    internal class Figury_Geometryczne_Project
    {
        public class Punkt
        {
            const int MKPromienPunktu = 5;

            public enum MKFiguryGeometryczne : byte
            {
                Punkt, Linia, Kwadrat, KwadratWyp, Prostokąt, Okrąg, Koło, Elipsa, FillEllipse, DrawArc, DrawPie, FillPie, WielokątForemny, WielokątWyp, LiniaCiągła, KrzywaBeziera, KrzywaKardyn, DrawClosedCurve, FillClosedCurve, DrawString, DrawBezier, KrzywaKardynalna, ZamkniętaKrzywaKardynalna, ZamkniętaWypełnionaKrzywaKardynalna
            }

            public MKFiguryGeometryczne Figura
            {
                get;
                protected set;
            }

            protected int MKX;
            protected int MKY;
            protected bool MKWidoczny;

            public int MKWspółrzędnaX
            {
                get
                {
                    return MKX;
                }
                
                protected set
                {
                    MKX = value;
                }
            }

            public int MKWspółrzędnaY
            {
                get
                {
                    return MKY;
                }

                protected set
                {
                    MKY = value;
                }
            }

            public int MKŚrednicaPunktu
            {
                get;
                protected set;
            }

            public Color MKKolor
            {
                get;
                protected set;
            }

            public float MKGrubośćLinii
            {
                get;
                protected set;
            }

            public DashStyle MKStylLinii
            {
                get;
                protected set;
            }

            public Color MKKolorWypełnienia
            {
                get;
                protected set;
            }

            public Punkt(Color Kolor)
            {
                Figura = MKFiguryGeometryczne.Punkt;
                MKKolor = Color.Black;
                MKGrubośćLinii = 1.0F;
                MKStylLinii = DashStyle.Solid;
                MKKolorWypełnienia = Color.Sienna;
                MKWidoczny = false;

                this.MKKolor = Kolor;
            }

            public Punkt(int x, int y)
            {
                Figura = MKFiguryGeometryczne.Punkt;
                MKWidoczny = false;
                MKŚrednicaPunktu = 2 * MKPromienPunktu;
                MKX = x; MKY = y;
                MKKolor = Color.Black;
                MKGrubośćLinii = 1.0F;
                MKStylLinii = DashStyle.Solid;
                MKKolorWypełnienia = Color.Sienna;
            }

            public Punkt(int X, int Y, Color Kolor) : this(X, Y)
            {
                this.MKKolor = Kolor;
            }

            public Punkt(int X, int Y, Color Kolor, int ŚrednicaPunktu) : this(X, Y, Kolor)
            {
                this.MKŚrednicaPunktu = ŚrednicaPunktu;
            }

            public virtual void Wykreśl(Graphics Rysownica)
            {
                using (SolidBrush Pędzel1 = new SolidBrush(MKKolor))
                {
                    Rysownica.FillEllipse(Pędzel1, MKX - MKŚrednicaPunktu / 2, MKY - MKŚrednicaPunktu / 2, MKŚrednicaPunktu, MKŚrednicaPunktu);
                    MKWidoczny = true;
                }
            }

            public virtual void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (MKWidoczny)
                {
                    using (SolidBrush Pędzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        Rysownica.FillEllipse(Pędzel, MKX - MKŚrednicaPunktu / 2, MKY - MKŚrednicaPunktu / 2, MKŚrednicaPunktu, MKŚrednicaPunktu);
                        MKWidoczny = false;
                    }
                }
            }

            public virtual void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int Xn, int Yn)
            {
                MKX = Xn; MKY = Yn;
                Wykreśl(Rysownica);
            }

        }

        public class Linia : Punkt
        {
            int MKXk, MKYk;

            public Linia(int Xp, int Yp, int Xk, int Yk, Color KolorLonii, DashStyle StylLinii, float GrubośćLinii) : base(Xp, Yp, KolorLonii)
            {
                Figura = MKFiguryGeometryczne.Linia;

                this.MKXk = Xk;
                this.MKYk = Yk;
                this.MKStylLinii = StylLinii;
                this.MKGrubośćLinii = GrubośćLinii;
            }

            public override void Wykreśl(Graphics Rysownica)
            {
                using (Pen Pióro = new Pen(MKKolor, MKGrubośćLinii))
                {
                    Pióro.DashStyle = MKStylLinii;
                    Rysownica.DrawLine(Pióro, MKX, MKY, MKXk, MKYk);

                    MKWidoczny = true;
                }
            }

            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (MKWidoczny)
                {
                    using (Pen Pióro = new Pen(Kontrolka.BackColor, MKGrubośćLinii))
                    {
                        Pióro.DashStyle = MKStylLinii;
                        Rysownica.DrawLine(Pióro, MKX, MKY, MKXk, MKYk);

                        MKWidoczny = false;
                    }
                }
            }

            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int Xn, int Yn)
            {
                int Dx, Dy;

                if (Xn > MKX)
                {
                    Dx = Xn - MKX;
                }

                else
                {
                    Dx = MKX - Xn;
                }

                if (Xn > MKY)
                {
                    Dy = Yn - MKY;
                }

                else
                {
                    Dy = MKY - Yn;
                }

                MKX = Xn; MKY = Yn;
                MKXk = (MKXk + Dx) % Kontrolka.Width;
                MKYk = (MKYk + Dy) % Kontrolka.Height;

                Wykreśl(Rysownica);
            }
        }

        public class Elipsa : Punkt
        {
            protected int MKOśDuża, MKOśMała;

            public Elipsa(int x, int y, int ośDuża, int ośMała, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii) : base(x, y, KolorLinii)
            {
                Figura = MKFiguryGeometryczne.Elipsa;
                MKOśDuża = ośDuża;
                MKOśMała = ośMała;
                MKWidoczny = false;

                this.MKStylLinii = StylLinii;
                this.MKGrubośćLinii = GrubośćLinii;
            }

            public override void Wykreśl(Graphics Rysownica)
            {
                using (Pen MKPióro = new Pen(MKKolor, MKGrubośćLinii))
                {
                    MKPióro.DashStyle = MKStylLinii;
                    Rysownica.DrawEllipse(MKPióro, MKX - MKOśDuża / 2, MKY - MKOśMała / 2, MKOśDuża, MKOśMała);

                    MKWidoczny = true;
                }
            }

            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (MKWidoczny)
                {
                    using (Pen MKPióro = new Pen(Kontrolka.BackColor, MKGrubośćLinii))
                    {
                        MKPióro.DashStyle = MKStylLinii;
                        Rysownica.DrawEllipse(MKPióro, MKX - MKOśDuża / 2, MKY - MKOśMała / 2, MKOśDuża, MKOśMała);

                        MKWidoczny = false;
                    }
                }
            }
        }

        public class FillElipsa : Elipsa
        {
            public FillElipsa(int x, int y, int ośDuża, int ośMała, Color KolorWypełnienia, DashStyle StylLinii, float GrubośćLinii) : base(x, y, ośDuża, ośMała, KolorWypełnienia, StylLinii, GrubośćLinii)
            {
                Figura = MKFiguryGeometryczne.FillEllipse;

                MKWidoczny = false;

            }

            public override void Wykreśl(Graphics Rysownica)
            {
                using (SolidBrush MKPędzel = new SolidBrush(MKKolor))
                {
                    Rysownica.FillEllipse(MKPędzel, MKX - MKOśDuża / 2, MKY - MKOśMała / 2, MKOśDuża, MKOśMała);

                    MKWidoczny = true;
                }

            }

            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (MKWidoczny)
                {
                    using (SolidBrush MKPędzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        Rysownica.FillEllipse(MKPędzel, MKX - MKOśDuża / 2, MKY - MKOśMała / 2, MKOśDuża, MKOśMała);

                        MKWidoczny = false;
                    }
                }
            }
        }

        public class ŁukElipsy : Elipsa
        {
            protected int MKLocX;
            protected int MKLocY;

            public ŁukElipsy(int x, int y, int OśDuża, int OśMała, int LocationX, int LocationY, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii): base(x, y, OśDuża, OśMała, KolorLinii, StylLinii, GrubośćLinii)
            {
                Figura = MKFiguryGeometryczne.DrawArc;

                MKLocX = LocationX;
                MKLocY = LocationY;

                MKWidoczny = false;

                this.MKStylLinii = StylLinii;
                this.MKGrubośćLinii = GrubośćLinii;
            }

            public override void Wykreśl(Graphics Rysownica)
            {
                using (Pen MKPióro = new Pen(MKKolor, MKGrubośćLinii))
                {
                    MKPióro.DashStyle = MKStylLinii;
                    Rysownica.DrawArc(MKPióro, MKX, MKY, MKOśDuża, MKOśMała, MKLocX, MKLocY);

                    MKWidoczny = true;
                }
            }

            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (MKWidoczny)
                {
                    using (Pen MKPióro = new Pen(Kontrolka.BackColor, MKGrubośćLinii))
                    {
                        MKPióro.DashStyle = MKStylLinii;
                        Rysownica.DrawArc(MKPióro, MKX, MKY, MKOśDuża, MKOśMała, MKLocX, MKLocY);

                        MKWidoczny = false;
                    }
                }
            }
        }
        public class Okrąg : Elipsa
        {
            public int MKPromień
            {
                get
                {
                    return MKOśDuża;
                }

                set
                {
                    MKOśDuża = value;
                    MKOśMała = value;
                }
            }

            public Okrąg(int x, int y, int MKPromień, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii) : base(x, y, 2 * MKPromień, 2 * MKPromień, KolorLinii, StylLinii, GrubośćLinii)
            {
                Figura = MKFiguryGeometryczne.Okrąg;
            }
        }

        public class Koło : FillElipsa
        {
            public Koło(int x, int y, int MKPromień, Color KolorWypełnienia, DashStyle StylLinii, float GrubośćLinii) : base(x, y, MKPromień, MKPromień, KolorWypełnienia, StylLinii, GrubośćLinii)
            {
                Figura = MKFiguryGeometryczne.Koło;
            }
        }

        public class DrawPie : ŁukElipsy
        {
            public DrawPie(int x, int y, int OśDuża, int OśMała, int LocationX, int LocationY, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii): base(x, y, OśDuża, OśMała, LocationX, LocationY, KolorLinii, StylLinii, GrubośćLinii)
            {
                Figura = MKFiguryGeometryczne.DrawPie;

                MKWidoczny = false;
            }

            public override void Wykreśl(Graphics Rysownica)
            {
                using (Pen MKPióro = new Pen(MKKolor, MKGrubośćLinii))
                {
                    MKPióro.DashStyle = MKStylLinii;
                    Rysownica.DrawPie(MKPióro, MKX, MKY, MKOśDuża, MKOśMała, MKLocX, MKLocY);

                    MKWidoczny = true;
                }
            }

            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (MKWidoczny)
                {
                    using (Pen MKPióro = new Pen(Kontrolka.BackColor, MKGrubośćLinii))
                    {
                        MKPióro.DashStyle = MKStylLinii;
                        Rysownica.DrawPie(MKPióro, MKX, MKY, MKOśDuża, MKOśMała, MKLocX, MKLocY);

                        MKWidoczny = false;
                    }
                }
            }
        }

        public class FillPie : ŁukElipsy
        {
            public FillPie(int x, int y, int OśDuża, int OśMała, int LocationX, int LocationY, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii): base(x, y, OśDuża, OśMała, LocationX, LocationY, KolorLinii, StylLinii, GrubośćLinii)
            {
                Figura = MKFiguryGeometryczne.FillPie;

                MKWidoczny = false;

            }

            public override void Wykreśl(Graphics Rysownica)
            {
                using (SolidBrush MKPędzel = new SolidBrush(MKKolor))
                {
                    Rysownica.FillPie(MKPędzel, MKX, MKY, MKOśDuża, MKOśMała, MKLocX, MKLocY);

                    MKWidoczny = true;
                }
            }

            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (MKWidoczny)
                {
                    using (SolidBrush MKPędzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        Rysownica.FillPie(MKPędzel, MKX, MKY, MKOśDuża, MKOśMała, MKLocX, MKLocY);

                        MKWidoczny = false;
                    }
                }
            }
        }

        public class Prostokąt : Punkt
        {
            protected int MKSzerokość;
            protected int MKWysokość;

            public Prostokąt(int x, int y, int Szerokość, int Wysokość, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii) : base(x, y, KolorLinii)
            {
                Figura = MKFiguryGeometryczne.Prostokąt;

                MKSzerokość = Szerokość;
                MKWysokość = Wysokość;
                this.MKStylLinii = StylLinii;
                this.MKGrubośćLinii = GrubośćLinii;

                MKWidoczny = false;
            }

            public override void Wykreśl(Graphics Rysownica)
            {
                using (Pen MKPióro = new Pen(MKKolor, MKGrubośćLinii))
                {
                    MKPióro.DashStyle = MKStylLinii;
                    Rysownica.DrawRectangle(MKPióro, MKX, MKY, MKSzerokość, MKWysokość);

                    MKWidoczny = true;
                }
            }

            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (MKWidoczny)
                {
                    using (Pen MKPióro = new Pen(Kontrolka.BackColor, MKGrubośćLinii))
                    {
                        MKPióro.DashStyle = MKStylLinii;
                        Rysownica.DrawRectangle(MKPióro, MKX, MKY, MKSzerokość, MKWysokość);

                        MKWidoczny = false;
                    }
                }
            }
        }

        public class ProstokątWyp : Prostokąt
        {
            public ProstokątWyp(int x, int y, int Szerokość, int Wysokość, Color KolorWypełnienia, DashStyle StylLinii, float GrubośćLinii): base(x, y, Szerokość, Wysokość, KolorWypełnienia, StylLinii, GrubośćLinii)
            {
                Figura = MKFiguryGeometryczne.Prostokąt;
            }

            public override void Wykreśl(Graphics Rysownica)
            {
                using (SolidBrush MKPędzel = new SolidBrush(MKKolor))
                {
                    Rysownica.FillRectangle(MKPędzel, MKX, MKY, MKSzerokość, MKWysokość);

                    MKWidoczny = true;
                }
            }

            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (MKWidoczny)
                {
                    using (SolidBrush MKPędzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        Rysownica.FillRectangle(MKPędzel, MKX, MKY, MKSzerokość, MKWysokość);

                        MKWidoczny = false;
                    }
                }
            }
        }

        public class Kwadrat : Prostokąt
        {
            public int MKSzerokoscKwadtara
            {
                get
                {
                    return MKSzerokość;
                }

                set
                {
                    MKSzerokość = value;
                    MKWysokość = value;
                }
            }

            public Kwadrat(int x, int y, int MKSzerokoscKwadtara, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii): base(x, y, MKSzerokoscKwadtara, MKSzerokoscKwadtara, KolorLinii, StylLinii, GrubośćLinii)
            {
                Figura = MKFiguryGeometryczne.Kwadrat;
            }
        }

        public class KwadratWyp : Kwadrat
        {
            public int MKSzerokośćKwadrataWyp
            {
                get
                {
                    return MKSzerokość;
                }

                set
                {
                    MKSzerokość = value;
                    MKWysokość = value;
                }
            }

            public KwadratWyp(int x, int y, int MKSzerokośćKwadrataWyp, Color KolorWypełnienia, DashStyle StylLinii, float GrubośćLinii): base(x, y, MKSzerokośćKwadrataWyp, KolorWypełnienia, StylLinii, GrubośćLinii)
            {
                Figura = MKFiguryGeometryczne.KwadratWyp;
            }

            public override void Wykreśl(Graphics Rysownica)
            {
                using (SolidBrush MKPędzel = new SolidBrush(MKKolor))
                {
                    Rysownica.FillRectangle(MKPędzel, MKX, MKY, MKSzerokośćKwadrataWyp, MKSzerokośćKwadrataWyp);

                    MKWidoczny = true;
                }
            }

            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (MKWidoczny)
                {
                    using (SolidBrush MKPędzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        Rysownica.FillRectangle(MKPędzel, MKX, MKY, MKSzerokośćKwadrataWyp, MKSzerokośćKwadrataWyp);

                        MKWidoczny = false;
                    }
                }
            }
        }

        public class Wielokąt_Foremny : Punkt
        {
            protected ushort MKStopeńWielokąta;
            protected int MKR;

            public Wielokąt_Foremny(int x, int y, ushort StopieńWielokąta, int Promień, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii) : base(x, y, KolorLinii)
            {
                Figura = MKFiguryGeometryczne.WielokątForemny;

                MKStopeńWielokąta = StopieńWielokąta;
                MKR = Promień;

                this.MKStylLinii = StylLinii;
                this.MKGrubośćLinii = GrubośćLinii;

                MKWidoczny = false;
            }

            public override void Wykreśl(Graphics Rysownica)
            {
                using (Pen MKPióro = new Pen(MKKolor, MKGrubośćLinii))
                {
                    MKPióro.DashStyle = MKStylLinii;

                    Point[] MKwierzchołkiWielokąta = new Point[MKStopeńWielokąta];

                    double MKKątPołożeniaPierwszegoWierzchołka = 0.0;
                    double MKKątMiędzyWierzchołkamiWilokąta = 360.0 / MKStopeńWielokąta;

                    for (int i = 0; i < MKStopeńWielokąta; i++)
                    {
                        MKwierzchołkiWielokąta[i].X = MKX + (int)(MKR * Math.Cos(Math.PI * (MKKątPołożeniaPierwszegoWierzchołka + i * MKKątMiędzyWierzchołkamiWilokąta) / 180.0));
                        MKwierzchołkiWielokąta[i].Y = MKY - (int)(MKR * Math.Sin(Math.PI * (MKKątPołożeniaPierwszegoWierzchołka + i * MKKątMiędzyWierzchołkamiWilokąta) / 180.0));
                    }

                    Rysownica.DrawPolygon(MKPióro, MKwierzchołkiWielokąta);

                    MKWidoczny = true;
                }
            }

            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (MKWidoczny)
                {
                    using (Pen MKPióro = new Pen(Kontrolka.BackColor, MKGrubośćLinii))
                    {
                        MKPióro.DashStyle = MKStylLinii;

                        Point[] MKwierzchołkiWielokąta = new Point[MKStopeńWielokąta];

                        double MKKątPołożeniaPierwszegoWierzchołka = 0.0;
                        double MKKątMiędzyWierzchołkamiWilokąta = 360.0 / MKStopeńWielokąta;

                        for (int i = 0; i < MKStopeńWielokąta; i++)
                        {
                            MKwierzchołkiWielokąta[i].X = MKX + (int)(MKR * Math.Cos(Math.PI * (MKKątPołożeniaPierwszegoWierzchołka + i * MKKątMiędzyWierzchołkamiWilokąta) / 180.0));
                            MKwierzchołkiWielokąta[i].Y = MKY - (int)(MKR * Math.Sin(Math.PI * (MKKątPołożeniaPierwszegoWierzchołka + i * MKKątMiędzyWierzchołkamiWilokąta) / 180.0));
                        }

                        Rysownica.DrawPolygon(MKPióro, MKwierzchołkiWielokąta);

                        MKWidoczny = false;
                    }
                }
            }
        }

        public class Wielokąt_Wypełniony : Wielokąt_Foremny
        {
            public Wielokąt_Wypełniony(int x, int y, ushort StopieńWielokąta, int Promień, Color KolorWypełnienia, DashStyle StylLinii, float GrubośćLinii): base(x, y, StopieńWielokąta, Promień, KolorWypełnienia, StylLinii, GrubośćLinii)
            {
                Figura = MKFiguryGeometryczne.WielokątForemny;

                MKStopeńWielokąta = StopieńWielokąta;
                MKR = Promień;

                MKWidoczny = false;
            }

            public override void Wykreśl(Graphics Rysownica)
            {
                using (SolidBrush MKPedzel = new SolidBrush(MKKolor))
                {
                    Point[] MKwierzchołkiWielokąta = new Point[MKStopeńWielokąta];

                    double MKKątPołożeniaPierwszegoWierzchołka = 0.0;
                    double MKKątMiędzyWierzchołkamiWilokąta = 360.0 / MKStopeńWielokąta;

                    for (int i = 0; i < MKStopeńWielokąta; i++)
                    {
                        MKwierzchołkiWielokąta[i].X = MKX + (int)(MKR * Math.Cos(Math.PI * (MKKątPołożeniaPierwszegoWierzchołka + i * MKKątMiędzyWierzchołkamiWilokąta) / 180.0));
                        MKwierzchołkiWielokąta[i].Y = MKY - (int)(MKR * Math.Sin(Math.PI * (MKKątPołożeniaPierwszegoWierzchołka + i * MKKątMiędzyWierzchołkamiWilokąta) / 180.0));
                    }

                    Rysownica.FillPolygon(MKPedzel, MKwierzchołkiWielokąta);

                    MKWidoczny = true;
                }
            }

            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (MKWidoczny)
                {
                    using (SolidBrush MKPedzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        Point[] MKwierzchołkiWielokąta = new Point[MKStopeńWielokąta];

                        double MKKątPołożeniaPierwszegoWierzchołka = 0.0;
                        double MKKątMiędzyWierzchołkamiWilokąta = 360.0 / MKStopeńWielokąta;

                        for (int i = 0; i < MKStopeńWielokąta; i++)
                        {
                            MKwierzchołkiWielokąta[i].X = MKX + (int)(MKR * Math.Cos(Math.PI * (MKKątPołożeniaPierwszegoWierzchołka + i * MKKątMiędzyWierzchołkamiWilokąta) / 180.0));
                            MKwierzchołkiWielokąta[i].Y = MKY - (int)(MKR * Math.Sin(Math.PI * (MKKątPołożeniaPierwszegoWierzchołka + i * MKKątMiędzyWierzchołkamiWilokąta) / 180.0));
                        }

                        Rysownica.FillPolygon(MKPedzel, MKwierzchołkiWielokąta);

                        MKWidoczny = false;
                    }
                }
            }
        }

        public class LiniaCiągła : Punkt
        {
            protected int MKLokackacjaX;
            protected int MKLokackacjaY;

            public LiniaCiągła(int x, int y, int LokacjaX, int LokacjaY, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii) : base(x, y, KolorLinii)
            {
                Figura = MKFiguryGeometryczne.LiniaCiągła;
                MKLokackacjaX = LokacjaX;
                MKLokackacjaY = LokacjaY;

                this.MKStylLinii = StylLinii;
                this.MKGrubośćLinii = GrubośćLinii;

                MKWidoczny = false;
            }

            public override void Wykreśl(Graphics Rysownica)
            {
                using (Pen MKPióro = new Pen(MKKolor, MKGrubośćLinii))
                {
                    MKPióro.DashStyle = MKStylLinii;
                    Rysownica.DrawLine(MKPióro, MKX, MKY, MKLokackacjaX, MKLokackacjaY);

                    MKWidoczny = true;
                }
            }

            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (MKWidoczny)
                {
                    using (Pen MKPióro = new Pen(Kontrolka.BackColor, MKGrubośćLinii))
                    {
                        MKPióro.DashStyle = MKStylLinii;
                        Rysownica.DrawLine(MKPióro, MKX, MKY, MKLokackacjaX, MKLokackacjaY);

                        MKWidoczny = false;
                    }
                }
            }
        }

        public class DrawString : Punkt
        {
            protected string MKText;
            protected Font MKFont;

            public DrawString(int x, int y, string Text, Font Czcionka, Color KolorWypełnienia) : base(x, y, KolorWypełnienia)
            {
                Figura = MKFiguryGeometryczne.DrawString;

                MKText = Text;
                MKFont = Czcionka;

                MKWidoczny = false;
            }

            public override void Wykreśl(Graphics Rysownica)
            {
                using (SolidBrush MKPędzel = new SolidBrush(MKKolor))
                {
                    Rysownica.DrawString(MKText, MKFont, MKPędzel, MKX, MKY);

                    MKWidoczny = true;
                }
            }

            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (MKWidoczny)
                {
                    using (SolidBrush MKPędzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        Rysownica.DrawString(MKText, MKFont, MKPędzel, MKX, MKY);

                        MKWidoczny = false;
                    }
                }
            }
        }

        public class DrawBezier : Punkt
        {
            protected Point MKPunkt0;
            protected Point MKPunkt1;
            protected Point MKPunkt2;
            protected Point MKPunkt3;

            public DrawBezier(Point MKPunkt0, Point MKPunkt1, Point MKPunkt2, Point MKPunkt3, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii) : base(KolorLinii)
            {
                Figura = MKFiguryGeometryczne.DrawBezier;

                this.MKPunkt0 = MKPunkt0;
                this.MKPunkt1 = MKPunkt1;
                this.MKPunkt2 = MKPunkt2;
                this.MKPunkt3 = MKPunkt3;

                this.MKStylLinii = StylLinii;
                this.MKGrubośćLinii = GrubośćLinii;

                MKWidoczny = false;
            }

            public override void Wykreśl(Graphics Rysownica)
            {
                using (Pen MKPióro = new Pen(MKKolor, MKGrubośćLinii))
                {
                    MKPióro.DashStyle = MKStylLinii;
                    Rysownica.DrawBezier(MKPióro, MKPunkt0, MKPunkt1, MKPunkt2, MKPunkt3);

                    MKWidoczny = true;
                }
            }

            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (MKWidoczny)
                {
                    using (Pen MKPióro = new Pen(Kontrolka.BackColor))
                    {
                        MKPióro.DashStyle = MKStylLinii;
                        Rysownica.DrawBezier(MKPióro, MKPunkt0, MKPunkt1, MKPunkt2, MKPunkt3);

                        MKWidoczny = false;
                    }
                }
            }
        }

        public class KrzywaKardynalna : DrawBezier
        {
            public KrzywaKardynalna(Point MKPunkt0, Point MKPunkt1, Point MKPunkt2, Point MKPunkt3, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii): base(MKPunkt0, MKPunkt1, MKPunkt2, MKPunkt3, KolorLinii, StylLinii, GrubośćLinii)
            {
                Figura = MKFiguryGeometryczne.KrzywaKardynalna;
            }

            public override void Wykreśl(Graphics Rysownica)
            {
                using (Pen MKPióro = new Pen(MKKolor, MKGrubośćLinii))
                {
                    PointF[] MKPoints = { MKPunkt0, MKPunkt1, MKPunkt2, MKPunkt3 };
                    Rysownica.DrawCurve(MKPióro, MKPoints);

                    MKWidoczny = true;
                }
            }

            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (MKWidoczny)
                {
                    using (Pen MKPióro = new Pen(Kontrolka.BackColor, MKGrubośćLinii))
                    {
                        PointF[] MKPoints = { MKPunkt0, MKPunkt1, MKPunkt2, MKPunkt3 };
                        Rysownica.DrawCurve(MKPióro, MKPoints);

                        MKWidoczny = false;
                    }
                }
            }
        }

        public class ZamkniętaKrzywaKardynalna : KrzywaKardynalna
        {
            public ZamkniętaKrzywaKardynalna(Point MKPunkt0, Point MKPunkt1, Point MKPunkt2, Point MKPunkt3, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii): base(MKPunkt0, MKPunkt1, MKPunkt2, MKPunkt3, KolorLinii, StylLinii, GrubośćLinii)
            {
                Figura = MKFiguryGeometryczne.ZamkniętaKrzywaKardynalna;
            }

            public override void Wykreśl(Graphics Rysownica)
            {
                using (Pen MKPióro = new Pen(MKKolor, MKGrubośćLinii))
                {
                    PointF[] MKPoints = { MKPunkt0, MKPunkt1, MKPunkt2, MKPunkt3 };
                    Rysownica.DrawClosedCurve(MKPióro, MKPoints);

                    MKWidoczny = true;
                }
            }

            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (MKWidoczny)
                {
                    using (Pen MKPióro = new Pen(Kontrolka.BackColor, MKGrubośćLinii))
                    {
                        PointF[] MKPoints = { MKPunkt0, MKPunkt1, MKPunkt2, MKPunkt3 };
                        Rysownica.DrawClosedCurve(MKPióro, MKPoints);

                        MKWidoczny = false;
                    }
                }
            }
        }

        public class ZamkniętaWypełnionaKrzywaKardynalna : ZamkniętaKrzywaKardynalna
        {
            public ZamkniętaWypełnionaKrzywaKardynalna(Point MKPunkt0, Point MKPunkt1, Point MKPunkt2, Point MKPunkt3, Color KolorWypłnienia, DashStyle StylLinii, float GrubośćLinii): base(MKPunkt0, MKPunkt1, MKPunkt2, MKPunkt3, KolorWypłnienia, StylLinii, GrubośćLinii)
            {
                Figura = MKFiguryGeometryczne.ZamkniętaWypełnionaKrzywaKardynalna;
            }

            public override void Wykreśl(Graphics Rysownica)
            {
                using (SolidBrush MKPędzel = new SolidBrush(MKKolor))
                {
                    PointF[] MKPoints = { MKPunkt0, MKPunkt1, MKPunkt2, MKPunkt3 };
                    Rysownica.FillClosedCurve(MKPędzel, MKPoints);

                    MKWidoczny = true;
                }
            }

            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (MKWidoczny)
                {
                    using (SolidBrush MKPędzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        PointF[] MKPoints = { MKPunkt0, MKPunkt1, MKPunkt2, MKPunkt3 };
                        Rysownica.FillClosedCurve(MKPędzel, MKPoints);

                        MKWidoczny = false;
                    }
                }
            }
        }
    }
}