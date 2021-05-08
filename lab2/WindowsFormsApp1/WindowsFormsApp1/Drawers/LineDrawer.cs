using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace FigureLib

{
    public class LineDrawer : FigureDrawer
    {
        public override void Draw(Graphics g, Pen pen, int x, int y) => g.DrawLine(pen, x,y, x + 100, 180);
    }
}