using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureCalc;
namespace FigureCalcTests
{
    [TestClass]
    public class FigureTest
    {
        [TestMethod] 
        public void CircleCalcSquareTest()
        {
            double expectedValue = 12.56;
            Circle circle = new Circle(2);
            Assert.AreEqual(expectedValue, Math.Round(circle.Calculate()),2);
        }

        [TestMethod]
        public void TriangleCalcSquareTest()
        {
            double expectedValue = 6;
            Triangle triangle = new Triangle(3,4,5);
            Assert.AreEqual(expectedValue, triangle.Calculate());
        }

        [TestMethod]
        public void TriangleIsRightTest()
        {
            bool expectedValue = true;
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(expectedValue, triangle.IsRightTriangle);
        }

        [TestMethod]
        public void TriangleErrorWithSidesTest()
        {
            Assert.ThrowsException<Exception>(() =>
            {
                var triangle = new Triangle(10, 2, 2);
                
            });
        }


    }
}
