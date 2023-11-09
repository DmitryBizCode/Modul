using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModulWork;
using System;

namespace UnitTestProj
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]

        public void CalculateArea_ValidInput_ReturnsCorrectArea()
        {
            PentagonalPyramid pyramid = new PentagonalPyramid(4, 6);
            double area = pyramid.CalculateArea();
            Assert.AreEqual(79.24, area, 0.01); // Додаємо допустиму похибку
        }

        [TestMethod]
        public void CalculateVolume_ValidInput_ReturnsCorrectVolume()
        {
            PentagonalPyramid pyramid = new PentagonalPyramid(4, 6);
            double volume = pyramid.CalculateVolume();           
            Assert.AreEqual(32, volume);
        }
    }
}
