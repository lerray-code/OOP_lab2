using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace FigureLib

{
    public class SquareDrawer : FigureDrawer
    {
        public override void Draw(Graphics g, Pen pen, int x, int y) => g.DrawRectangle(pen, x, y, 50, 50);
    }
}