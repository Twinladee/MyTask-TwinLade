using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalc
{
    public abstract class Figure
    {
        public FigureName Name { get; set; }
        
    }

    public enum FigureName
    {
        Triangle,
        Circle
    }
}
