using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Autorennen
{
    class CFlotte
    {
        private Form1 frm; // Verweis auf das Formular

        // private List<CFahrzeug> fahrzeuge;

        private Dictionary<CFahrzeug, FahrzeugControl> dicFahrzeuge
            = new Dictionary<CFahrzeug, FahrzeugControl>();

        private Color[] Farben = { Color.Red, Color.Blue, Color.Green, Color.Purple,
        Color.Pink, Color.Brown, Color.BlueViolet, Color.DarkCyan };

        public CFlotte(Form1 frm)
        {
            this.frm = frm;
        }

        public void ErzeugeAuto()
        {
            if (dicFahrzeuge.Count == Farben.Length) return;
            CAuto auto = new CAuto(10 + 50 * dicFahrzeuge.Count,
                Farben[dicFahrzeuge.Count]);
            FahrzeugHinzufuegen(auto);
        }

        public void ErzeugeFahrrad()
        {
            if (dicFahrzeuge.Count == Farben.Length) return;
            CFahrrad fahrrad = new CFahrrad(30 + 50 * dicFahrzeuge.Count,
                Farben[dicFahrzeuge.Count]);
            FahrzeugHinzufuegen(fahrrad);
        }

        private void FahrzeugHinzufuegen(CFahrzeug fahrzeug)
        {
            foreach (CFahrzeug fahrzeug2 in Fahrzeuge)
            {
                fahrzeug2.Schreck += fahrzeug.OnSchreck;
                fahrzeug.Schreck += fahrzeug2.OnSchreck;
            }
            FahrzeugControl fahrzeugControl = new FahrzeugControl(fahrzeug);
            fahrzeugControl.Text = "Fahrzeug " + (dicFahrzeuge.Count + 1);
            fahrzeugControl.Location =
                new Point(180 * dicFahrzeuge.Count + 10, 450);
            dicFahrzeuge.Add(fahrzeug, fahrzeugControl);
            frm.Controls.Add(fahrzeugControl);
        }

        public List<CFahrzeug> Fahrzeuge
        {
            get
            {
                return dicFahrzeuge.Keys.ToList<CFahrzeug>();
            }
        }

        public FahrzeugControl ControlZumFahrzeug(CFahrzeug fahrzeug)
        {
            return dicFahrzeuge[fahrzeug];
        }

    }
}
