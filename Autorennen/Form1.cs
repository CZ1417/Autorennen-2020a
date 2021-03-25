using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autorennen
{
    public partial class Form1 : Form
    {
        CFlotte flotte;

        private BufferedGraphicsContext GraphicManager;
        private BufferedGraphics ManagedBackBuffer;


        public Form1()
        {
            InitializeComponent();
            GraphicManager = BufferedGraphicsManager.Current;
            GraphicManager.MaximumBuffer = new Size(pnlFahrbahn.Width + 1,
                pnlFahrbahn.Height + 1);
            ManagedBackBuffer = GraphicManager.Allocate(pnlFahrbahn.CreateGraphics(),
                ClientRectangle);
            flotte = new CFlotte(this);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlFahrbahn.Invalidate();

        }

        private void autoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flotte.ErzeugeAuto();
        }

        private void fahrradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flotte.ErzeugeFahrrad();
        }

        private void pnlFahrbahn_Paint(object sender, PaintEventArgs e)
        {
            ManagedBackBuffer.Graphics.FillRectangle(new SolidBrush(pnlFahrbahn.BackColor),
                0, 0, pnlFahrbahn.Width, pnlFahrbahn.Height);
            foreach (CFahrzeug fahrzeug in flotte.Fahrzeuge)
            {
                fahrzeug.Anzeigen(ManagedBackBuffer.Graphics);
                if (fahrzeug.GetType() == typeof(CAuto))
                {
                    flotte.ControlZumFahrzeug(fahrzeug).Tacho =
                        ((CAuto)fahrzeug).Tacho;
                }
            }
            ManagedBackBuffer.Render(e.Graphics);
        }
    }
}
