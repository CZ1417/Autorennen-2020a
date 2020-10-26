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
        private CAuto auto;
        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();
            graphics = panelFahrbahn.CreateGraphics();
            auto = new CAuto(Color.Red, 10);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            graphics.FillRectangle(new SolidBrush(panelFahrbahn.BackColor), 
                0, 0, panelFahrbahn.Width, panelFahrbahn.Height);
            auto.Anzeigen(graphics);
            tachoLabel.Text = $"{auto.GetGeschwindigkeit():000}";
        }

        private void ButtonBremsen_Click(object sender, EventArgs e)
        {
            auto.Bremsen();
        }

        private void ButtonBeschleunigen_Click(object sender, EventArgs e)
        {
            auto.Beschleunigen();
        }

        private void ButtonHupe_Click(object sender, EventArgs e)
        {
            var player = new SoundPlayer(@"sounds\hupe.wav");
            player.Play();
        }
    }
}
