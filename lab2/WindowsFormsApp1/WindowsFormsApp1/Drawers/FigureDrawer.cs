using System;
using System.Drawing;

namespace FigureLib
{
     public abstract class FigureDrawer
    {

        public int X { get; private set; }
        public int Y { get; private set; }
        public string Color { get; set; }

        

        public virtual void Draw(Graphics g, Pen pen,  int x, int y) { }
       
              
    }
}
