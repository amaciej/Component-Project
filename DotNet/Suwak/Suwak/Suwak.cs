using System;
using System.Drawing;
using System.Windows.Forms;

namespace Suwak
{
    public enum Kolory
    {
        Czerwony,
        Niebieski,
        Zielony,
        Domyslny
    }

    public enum Orientacja
    {
        Pionowa,
        Pozioma
    }

    public class Suwak: TrackBar
    {
        private Orientation _polozenie;
        
        public Orientacja Polozenie
        {
            get
            {
                if (_polozenie == Orientation.Horizontal)
                    return Orientacja.Pozioma;

                return Orientacja.Pionowa;

            }

            set
            {
                if (value == Orientacja.Pozioma)
                    _polozenie = Orientation.Horizontal;
                if (value == Orientacja.Pionowa)
                    _polozenie = Orientation.Vertical;

                this.Orientation = _polozenie;
                this.Width = _szerokosc;
                this.Height = _wysokosc;
                this.Invalidate();
            }
        }

        private Color _kolor;

        public Kolory Kolor
        {
            get
            {
                if (_kolor == Color.Blue)
                    return Kolory.Niebieski;
                if (_kolor == Color.Red)
                    return Kolory.Czerwony;
                if (_kolor == Color.Green)
                    return Kolory.Zielony;

                return Kolory.Domyslny;
            }

            set
            {
                _kolor = Color.FromKnownColor(KnownColor.Control);

                if (value == Kolory.Czerwony)
                    _kolor = Color.Red;
                if (value == Kolory.Niebieski)
                    _kolor = Color.Blue;
                if (value == Kolory.Zielony)
                    _kolor = Color.Green;

                this.BackColor = _kolor;
                this.Invalidate();
            }
        }

        private int _wartosc;

        public int Wartosc
        {
            get { return _wartosc; }
            set { _wartosc = value; }
        }

        private int _szerokosc = 100;

        public int Szerokosc
        {
            get { return _szerokosc; }

            set
            {
                _szerokosc = value;

                this.Width = _szerokosc;
                this.Height = _wysokosc;
                this.Invalidate();
            }
        }

        private int _wysokosc = 100;

        public int Wysokosc
        {
            get { return _wysokosc; }
            set
            {
                _wysokosc = value;

                this.Height = _wysokosc;
                this.Width = _szerokosc;
                this.Invalidate();
            }
        }

        protected override void OnValueChanged(EventArgs e)
        {
            this.Wartosc = this.Value;

            base.OnValueChanged(e);
        }
    }
}
