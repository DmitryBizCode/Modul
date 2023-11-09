using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModulWork;
using System;

namespace UnitTestProj
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void CalculatePerimeter_ValidInput_ReturnsCorrectPerimeter()
        {
            IsoscelesTriangle triangle = new IsoscelesTriangle(6, 8);
            double perimeter = triangle.CalculatePerimeter();
            Assert.AreEqual(29.08, perimeter, 0.01);// Додаємо допустиму похибку
        }

        [TestMethod]
        public void CalculateArea_ValidInput_ReturnsCorrectArea()
        {
            IsoscelesTriangle triangle = new IsoscelesTriangle(6, 8);
            double area = triangle.CalculateArea();
            Assert.AreEqual(24, area);
        }

        [TestMethod]
        public void CalculateInscribedCircleRadius_ValidInput_ReturnsCorrectRadius()
        {
            IsoscelesTriangle triangle = new IsoscelesTriangle(6, 8);
            double radius = triangle.CalculateInscribedCircleRadius();
            Assert.AreEqual(2.079, radius, 0.0001); // Додаємо допустиму похибку
        }
    }
}
