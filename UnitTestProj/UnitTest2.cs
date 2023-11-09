using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModulWork;
using System;

namespace UnitTestProj
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void CalculatePerimeter_ValidInput_ReturnsCorrectPerimeter()
        {
            Rhombus rhombus = new Rhombus(5);
            double perimeter = rhombus.CalculatePerimeter();
            Assert.AreEqual(20, perimeter);
        }

        [TestMethod]
        public void CalculateArea_ValidInput_ReturnsCorrectArea()
        {
            Rhombus rhombus = new Rhombus(5);
            double area = rhombus.CalculateArea();
            Assert.AreEqual(25, area);
        }

        [TestMethod]
        public void CalculateInscribedCircleRadius_ValidInput_ReturnsCorrectRadius()
        {
            Rhombus rhombus = new Rhombus(5);
            double radius = rhombus.CalculateInscribedCircleRadius();
            Assert.AreEqual(2.5, radius);
        }

        [TestMethod]
        public void CalculateCircumscribedCircleRadius_ValidInput_ReturnsCorrectRadius()
        {
            Rhombus rhombus = new Rhombus(5);
            double radius = rhombus.CalculateCircumscribedCircleRadius();
            Assert.AreEqual(3.53, radius, 0.01); // Додаємо допустиму похибку
        }
    }
}
