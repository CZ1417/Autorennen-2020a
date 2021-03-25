using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autorennen
{
    public partial class FahrzeugControl : UserControl
    {
        private CFahrzeug fahrzeug;

        public FahrzeugControl(CFahrzeug fahrzeug)
        {
            InitializeComponent();
            this.fahrzeug = fahrzeug;
            Farbe = fahrzeug.Farbe;
            if (fahrzeug.GetType() == typeof(CFahrrad))
            {
                lblTacho.Visible = false;
                btnGas.Text = "Treten";
                btnHupe.Text = "Klingel";
            }
        }

        public Color Farbe
        {
            get
            {
                return grpFahrzeug.ForeColor;
            }
            set
            {
                grpFahrzeug.ForeColor = value;
            }
        }

        public override string Text
        {
            get
            {
                return grpFahrzeug.Text;
            }
            set
            {
                grpFahrzeug.Text = value;
            }
        }

        public String Tacho
        {
            get
            {
                return lblTacho.Text;
            }
            set
            {
                lblTacho.Text = value;
            }
        }

        private void btnGas_Click(object sender, EventArgs e)
        {
            fahrzeug.Beschleunigen();
        }

        private void btnBremse_Click(object sender, EventArgs e)
        {
            fahrzeug.Bremsen();
        }

        private void btnHupe_Click(object sender, EventArgs e)
        {
            if (fahrzeug.GetType() == typeof(CAuto))
            {
                //CAuto auto = (CAuto)fahrzeug;
                //auto.Hupen();
                ((CAuto)fahrzeug).Hupen();
            }
            else
            {
                ((CFahrrad)fahrzeug).Klingeln();
            }
        }
    }
}
