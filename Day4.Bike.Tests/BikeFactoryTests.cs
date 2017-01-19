using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day4.Bike.Tests
{
    [TestClass]
    public class BikeFactoryTests
    {
        [TestMethod]
        public void BikeFactoryCanCreateXBikes()
        {
            var listOfBikes = BikeFactory.CreateXBikes(5);
            Assert.AreEqual(5, listOfBikes.Count);
        }
    }
}
