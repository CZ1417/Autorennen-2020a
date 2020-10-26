using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorennen
{
    class CFahrrad : CFahrzeug


    {
        public CFahrrad(Color farbe, int y) : base(farbe, y, 10, 0.5, 1.5, 40)
        {
            // Empty
        }
        protected override void ZeichneMich(Graphics g)
        { 

            var bReifen = new SolidBrush(Color.Black);
            var bKreis = new SolidBrush(Color.White);
            var bWagen = new SolidBrush(Farbe);
            var p = new Pen(Color.Black, 3);

        }


    }
}
