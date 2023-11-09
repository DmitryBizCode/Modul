using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModulWork;
using System;

namespace UnitTestProj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculatePerimeter_ValidInput_ReturnsCorrectPerimeter()
        {
            Trapezoid trapezoid = new Trapezoid(3, 7, 4);
            double perimeter = trapezoid.CalculatePerimeter();
            Assert.AreEqual(18.944, perimeter, 0.001); // Додаємо допустиму похибку
        }

        [TestMethod]
        public void CalculateArea_ValidInput_ReturnsCorrectArea()
        {
            Trapezoid trapezoid = new Trapezoid(3, 7, 4);
            double area = trapezoid.CalculateArea();
            Assert.AreEqual(20, area);
        }

        [TestMethod]
        public void CalculateCircumscribedCircleRadius_ValidInput_ReturnsCorrectRadius()
        {
            Trapezoid trapezoid = new Trapezoid(3, 7, 4);
            double radius = trapezoid.CalculateCircumscribedCircleRadius();
            Assert.AreEqual(2.872, radius, 0.001); // Додаємо допустиму похибку
        }
    }
}
