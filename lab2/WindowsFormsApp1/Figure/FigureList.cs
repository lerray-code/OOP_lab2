using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Text;

namespace FigureLib

{
    public class FigureList : IEquatable<FigureList>
    {
        public string Text { get; set; }
        public object Value { get; set; }
        
       

        public bool Equals(FigureList other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
