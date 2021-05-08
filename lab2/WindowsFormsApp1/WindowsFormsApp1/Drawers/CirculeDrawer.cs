using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace FigureLib
{
    public class CirculDrawer : FigureDrawer
    {
        public override void Draw(Graphics g, Pen pen,  int x, int y) => g.DrawEllipse(pen,  x, y, 50, 50);
    }
}
