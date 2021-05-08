using System;
using System.Drawing;

namespace FigureLib
{
     public abstract class Figure
    {

        string Color { get; set; }

        int X { get; set; }
        int Y { get; set; }

        protected Figure() { }

        protected Figure(string color, int x, int y)
        {
            Color = color;
            X = x;
            Y = y;
        }


    }
}
