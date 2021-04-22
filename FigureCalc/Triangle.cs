using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigureCalc
{
    public class Triangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public bool IsRightTriangle
        {
            get
            {
                return Pythagoras(SideA, SideB, SideC) || Pythagoras(SideC, SideA, SideB) ||
                       Pythagoras(SideC, SideB, SideA);
                bool Pythagoras(double leg1, double leg2, double hypo)
                {
                    return Math.Pow(leg1, 2) + Math.Pow(leg2, 2) == Math.Pow(hypo, 2);
                }
            }
        }

        public Triangle(double SideA, double SideB, double SideC)
        {
            double maxSide = Math.Max(SideA, Math.Max(SideB, SideC));
            /*double[] Sides = {SideA, SideB, SideC};
            double maxSide = Sides.Max();*/
            var p = (SideA + SideB + SideC);
            if (maxSide > p - maxSide)
                throw new Exception("Наибольшая сторона треуг. должна быть меньше суммы двух других.");

            Name = FigureName.Triangle;
            this.SideA = SideA;
            this.SideB = SideB;
            this.SideC = SideC;
            
        }

        public double Calculate()
        {
            var p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        
    }
}
