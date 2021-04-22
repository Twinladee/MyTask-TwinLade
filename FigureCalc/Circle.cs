using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace FigureCalc
{
    public class Circle : Figure
    {
        public float Radius { get; set; }
        public Circle(float radius)
        {
            Name = FigureName.Circle;
            Radius = radius;
        }

        public double Calculate() => Math.PI * Math.Pow(Radius, 2);

    }
}
