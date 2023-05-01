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
    internal class figury_geometryczne
    {
        public class Punkt
        {
            const int PromienPunktu = 5;

            public enum FiguryGeometryczne : byte
            {
                Punkt, Elipsa, Linia, Okrąg
            };

            public FiguryGeometryczne Figura
            {
                get;
                protected set;
            }

            protected int X;
            protected int Y;
            protected bool Widoczny;


            public int WspółrzędnaX
            {
                get
                {
                    return X;
                }
                
                protected set
                {
                    X = value;
                }
            }

            public int WspółrzędnaY
            {
                get
                {
                    return Y;
                }

                protected set
                {
                    Y = value;
                }
            }

            public int ŚrednicaPunktu
            {
                get;
                protected set;
            }

            public Color Kolor
            {
                get;
                protected set;
            }


            public float GrubośćLinii
            {
                get;
                protected set;
            }

            public DashStyle StylLinii
            {
                get;
                protected set;
            }

            public Color KolorWypełnienia
            {
                get;
                protected set;
            }


            public Punkt(int x, int y)
            {
                Figura = FiguryGeometryczne.Punkt;
                Widoczny = false;
                ŚrednicaPunktu = 2 * PromienPunktu;
                X = x; Y = y;
                Kolor = Color.Black;
                GrubośćLinii = 1.0F;
                StylLinii = DashStyle.Solid;
                KolorWypełnienia = Color.Sienna;
            }

            public Punkt(int X, int Y, Color Kolor) : this(X, Y)
            {
                this.Kolor = Kolor;
            }

            public Punkt(int X, int Y, Color Kolor, int ŚrednicaPunktu) : this(X, Y, Kolor)
            {
                this.ŚrednicaPunktu = ŚrednicaPunktu;
            }

            private void UstawXY(Point NowaLokalizaja)
            {
                X = NowaLokalizaja.X;
                Y = NowaLokalizaja.Y;
            }

            public virtual void Wykreśl(Graphics Rysownica)
            {
                SolidBrush Pędzel = new SolidBrush(Kolor);
                Rysownica.FillEllipse(Pędzel, X - ŚrednicaPunktu / 2, Y - ŚrednicaPunktu / 2, ŚrednicaPunktu, ŚrednicaPunktu);
                Widoczny = true;

                using (SolidBrush Pędzel2 = new SolidBrush(Kolor))
                {
                    Rysownica.FillEllipse(Pędzel2, X - ŚrednicaPunktu / 2, Y - ŚrednicaPunktu / 2, ŚrednicaPunktu, ŚrednicaPunktu);
                    Widoczny = true;
                }

            }

            public virtual void Wymaż(Control Kontrolka, Graphics Rysownica)
            { 
                if (Widoczny)
                {
                    using (SolidBrush Pędzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        Rysownica.FillEllipse(Pędzel, X - ŚrednicaPunktu / 2, Y - ŚrednicaPunktu / 2, ŚrednicaPunktu, ŚrednicaPunktu);
                        Widoczny = false;
                    }
                }
            }

            public virtual void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int Xn, int Yn)
            {
                X = Xn; Y = Yn;
                Wykreśl(Rysownica);
            }

        }

        public class Linia : Punkt
        {
            int Xk, Yk;

            public Linia(int Xp, int Yp, int Xk, int Yk) : base(Xp, Yp)
            {
                this.Xk = Xk;
                this.Yk = Yk;

                Figura = FiguryGeometryczne.Linia;
            }

            public Linia(int Xp, int Yp, int Xk, int Yk, Color KolorLonii, DashStyle StylLinii, float GrubośćLinii): base(Xp, Yp, KolorLonii)
            {
                Figura = FiguryGeometryczne.Linia;
                this.Xk = Xk;
                this.Yk = Yk;
                this.StylLinii = StylLinii;
                this.GrubośćLinii = GrubośćLinii;
            }

            public override void Wykreśl(Graphics Rysownica)
            {
                using (Pen Pióro = new Pen(Kolor, GrubośćLinii))
                {
                    Pióro.DashStyle = StylLinii;
                    Rysownica.DrawLine(Pióro, X, Y, Xk, Yk);

                    Widoczny = true;
                }
            }

            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                {
                    using (Pen Pióro = new Pen(Kontrolka.BackColor, GrubośćLinii))
                    {
                        Pióro.DashStyle = StylLinii;
                        Rysownica.DrawLine(Pióro, X, Y, Xk, Yk);

                        Widoczny = false;
                    }
                }
            }

            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int Xn, int Yn)
            {
                int Dx, Dy;

                if (Xn > X)
                {
                    Dx = Xn - X;
                }

                else
                {
                    Dx = X - Xn;
                }

                if (Xn > Y)
                {
                    Dy = Yn - Y;
                }

                else
                {
                    Dy = Y - Yn;
                }

                X = Xn; Y = Yn;
                Xk = (Xk + Dx) % Kontrolka.Width;
                Yk = (Yk + Dy) % Kontrolka.Height;

                Wykreśl(Rysownica);
            }
        }

        public class Elipsa : Punkt
        {
            protected int OśDuża, OśMała;

            public Elipsa(int x, int y, int ośDuża, int ośMała, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii) : base(x, y, KolorLinii)
            {
                Figura = FiguryGeometryczne.Elipsa;
                OśDuża = ośDuża;
                OśMała = ośMała;

                Widoczny = false;
                this.StylLinii = StylLinii;
                this.GrubośćLinii = GrubośćLinii;

            }

            public override void Wykreśl(Graphics Rysownica)
            {
                using (Pen Pióro = new Pen(Kolor, GrubośćLinii))
                {
                    Pióro.DashStyle = StylLinii;
                    Rysownica.DrawEllipse(Pióro, X - OśDuża / 2, Y - OśMała / 2, OśDuża, OśMała);

                    Widoczny = true;
                }

            }

            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                {
                    using (Pen Pióro = new Pen(Kontrolka.BackColor, GrubośćLinii))
                    {
                        Pióro.DashStyle = StylLinii;
                        Rysownica.DrawEllipse(Pióro, X - OśDuża / 2, Y - OśMała / 2, OśDuża, OśMała);

                        Widoczny = false;
                    }
                }
            }
        }

        public class Okrąg : Elipsa
        {
            public int Promień
            {
                get
                {
                    return OśDuża;
                }

                set
                {
                    OśDuża = value;
                    OśMała = value;
                }
            }

            public Okrąg(int x, int y, int Promień, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii): base(x, y, 2 * Promień, 2 * Promień, KolorLinii, StylLinii, GrubośćLinii)
            {
                Figura = FiguryGeometryczne.Okrąg;
            }
        }
    }
}