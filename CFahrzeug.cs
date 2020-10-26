using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorennen
{
    public abstract class CFahrzeug
    {
        #region Attribute

        private Color farbe;
        private double x;
        private double y;
        private double maxGeschwindigkeit;
        private double beschleunigung;
        private double bremskraft;
        protected double geschwindigkeit;
        private int laenge;

        #endregion

        #region Konstruktor

        public CFahrzeug(Color farbe, double y, double maxGeschwindigkeit,
            double beschleunigung, double bremskraft, int laenge)
        {
            this.farbe = farbe;
            x = 100 - laenge;
            this.y = y;
            geschwindigkeit = 0;
            this.maxGeschwindigkeit = maxGeschwindigkeit;
            this.beschleunigung = beschleunigung;
            this.bremskraft = bremskraft;
            this.laenge = laenge;
        }

        #endregion

        #region Eigenschaften

        public int X { get { return (int)x; } }
        public int Y { get { return (int)y; } }
        public Color Farbe { get { return farbe; } }

        #endregion

        #region Methoden
        
        public void Beschleunigen()
        {
            geschwindigkeit += beschleunigung;
            if (geschwindigkeit > maxGeschwindigkeit) geschwindigkeit = maxGeschwindigkeit;
        }

        public void Bremsen()
        {
            geschwindigkeit -= bremskraft;
            if (geschwindigkeit < 0) geschwindigkeit = 0;
        }

        public void Anzeigen(Graphics g)
        {
            x += geschwindigkeit;
            if (x > g.VisibleClipBounds.Width) x = -laenge;
            ZeichneMich(g);
        }

        public int GetGeschwindigkeit()
        {
            return (int)geschwindigkeit;
        }

        protected abstract void ZeichneMich(Graphics g);

        #endregion
    }
}
