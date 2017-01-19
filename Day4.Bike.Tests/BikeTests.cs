using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day4.Bike.Tests
{

    [TestClass]
    public class RaceTests
    {
        [TestMethod]
        public void RaceCanIdentifyWinner()
        {
            int finishLine = 10;
            bool isRunning = true;
            var bike = new Bike();

            bike.location = 40;

            isRunning = Program.TickRace(bike, isRunning, finishLine);

            Assert.AreEqual(false, isRunning);
        }

        [TestMethod]
        public void RaceWillAdvanceBikeIfNotWinner()
        {

            int finishLine = 20;
            bool isRunning = true;
            var bike = new Bike();

            isRunning = Program.TickRace(bike, isRunning, finishLine);

            Assert.AreEqual(true, isRunning);
            Assert.AreEqual(1, bike.location);

        }
    }

    [TestClass]
    public class BikeTests
    {
        [TestMethod]
        public void BikeValuesAreInitializedCorrectly()
        {
            var sut = new Bike();
            Assert.AreEqual(0, sut.GetSpeed());
            Assert.AreEqual(1, sut.GetSpeedModifier());
            Assert.AreEqual(0, sut.location);
            Assert.AreEqual(12, sut.GetSpeedLimit());
        }

        [TestMethod]
        public void BikeCanBeCreatedWithArgs()
        {
            var sut = new Bike(.8, 20);
            Assert.AreEqual(.8, sut.GetSpeedModifier());
            Assert.AreEqual(20, sut.GetSpeedLimit());
        }

        [TestMethod]
        public void BikeCanAccelerate()
        {
            var sut = new Bike();
            sut.Accelerate();
            Assert.AreEqual(1, sut.GetSpeed());
        }

        [TestMethod]
        public void BikeCanOnlyAccelerateToSpeedLimit()
        {
            var sut = new Bike();
            for (int i = 0; i < 20; i++)
            {
                sut.Accelerate();
            }
            Assert.AreEqual(12, sut.GetSpeed());
        }

        [TestMethod]
        public void BikeCanMoveForwardBasedOnSpeed()
        {
            var sut = new Bike();
            sut.Accelerate();
            sut.Accelerate();
            sut.Accelerate();
            sut.MoveForward();
            Assert.AreEqual(3, sut.location);
        }

        [TestMethod]
        public void BikeMoveForwardAbidesByTheSpeedLimit()
        {
            var sut = new Bike();
            for (int i = 0; i < 20; i++)
            {
                sut.Accelerate();
            }
            sut.MoveForward();
            Assert.AreEqual(12, sut.location);
        }


    }
}
