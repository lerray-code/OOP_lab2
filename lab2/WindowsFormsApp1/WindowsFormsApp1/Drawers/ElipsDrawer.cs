using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib
{
    public class ElipsDrawer : FigureDrawer
    {
        public override void Draw(Graphics g, Pen pen, int x, int y) => g.DrawEllipse(pen, x, y, 50, 80);
    }
}
