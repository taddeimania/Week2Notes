using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day3.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SquareComputesCorrectly()
        {
            var sut = new Square(5, 3);
            Assert.AreEqual(sut.height, 5);
            Assert.AreEqual(sut.width, 3);
            Assert.AreEqual(sut.Area(), 15);
        }

        [TestMethod]
        public void CircleComputesCorrectly()
        {
            var sut = new Circle(5);
            Assert.AreEqual(sut.radius, 5);
            Assert.AreEqual(sut.diameter, 10);
            Assert.AreEqual(sut.Area(), 78.54, 0.01);
        }

        [TestMethod]
        public void ShapeComputesCorrectly()
        {
            var sut = new Shape();
            Assert.AreEqual(sut.height, 0);
            Assert.AreEqual(sut.width, 0);
            Assert.AreEqual(sut.radius, 0);
            Assert.AreEqual(sut.Area(), Double.PositiveInfinity);
        }
    }
}
