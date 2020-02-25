using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingLotLogic;
using VehicleObjects;

namespace TestingBackendParking
{
    [TestClass]
    public class LinneaTesting
    {
        // Cars
        [DataRow("aaa", 1)]
        [DataRow("bbb", 1)]
        [DataRow("ccc", 1)]

        [TestMethod]
        public void TestAddCarParkingLot(string regNr, int expectedSpot)
        {
            ParkingLot pLot = new ParkingLot();
            pLot.AddParkingSpot(100, 10);

            Car c = new Car(DateTime.Now, regNr);
            int spot = pLot.AddVehicle(c);

            Assert.AreEqual(spot, expectedSpot);
        }

        [DataRow("aaa", 1)]
        [DataRow("bbb", 1)]
        [DataRow("ccc", 1)]
        [TestMethod]
        public void TestAddMcParkingLot(string regNr, int expectedSpot)
        {
            ParkingLot pLot = new ParkingLot();
            pLot.AddParkingSpot(100, 10);

            MC c = new MC(DateTime.Now, regNr);
            int spot = pLot.AddVehicle(c);

            Assert.AreEqual(spot, expectedSpot);
        }

        [DataRow("aaa", 1)]
        [DataRow("bbb", 2)]
        [TestMethod]
        public void TestAddTwoMcAtSameSpotParkingLot(string firstRegNr, string secondRegNr, int expectedSpot)
        {
            ParkingLot pLot = new ParkingLot();
            pLot.AddParkingSpot(100, 10);

            MC c = new MC(DateTime.Now, firstRegNr);
            MC mc = new MC(DateTime.Now, secondRegNr);
            int spot = pLot.AddVehicle(c, 5);
            pLot.AddVehicle(mc, 5);

            // Check vehicles at parkinglot

            Assert.AreEqual(spot, expectedSpot);
        }

        [TestMethod]
        public void TestFindSpotParkingLot()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void TestRemoveVehicleParkingLot()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void TestSearchVehicleParkingLot()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void TestParkingSpotContentParkingLot()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void TestOptimizeParkingLotParkingLot()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void TestAddParkingSpotParkingLot()
        {
            Assert.Inconclusive();
        }
    }
}
