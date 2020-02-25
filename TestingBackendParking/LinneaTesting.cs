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
        [DataRow("aaa", 0)]
        [DataRow("bbb", 0)]
        [DataRow("ccc", 0)]

        [TestMethod]
        public void TestAddCarParkingLot(string regNr, int expectedSpot)
        {
            ParkingLot pLot = new ParkingLot();
            pLot.AddParkingSpot(100, 10);

            Car c = new Car(DateTime.Now, regNr);
            int spot = pLot.AddVehicle(c);

            Assert.AreEqual(expectedSpot, spot);
        }

        // Mc's
        [DataRow("aaa", 0)]
        [DataRow("bbb", 0)]
        [DataRow("ccc", 0)]
        [TestMethod]
        public void TestAddMcParkingLot(string regNr, int expectedSpot)
        {
            ParkingLot pLot = new ParkingLot();
            pLot.AddParkingSpot(100, 10);

            MC c = new MC(DateTime.Now, regNr);
            int spot = pLot.AddVehicle(c);

            Assert.AreEqual(expectedSpot, spot);
        }

        [DataRow("aaa", "bbb", 5)]
        [TestMethod]
        public void TestAddTwoMcAtSameSpotParkingLot(string firstRegNr, string secondRegNr, int expectedSpot)
        {
            ParkingLot pLot = new ParkingLot();
            pLot.AddParkingSpot(100, 10);

            MC c = new MC(DateTime.Now, firstRegNr);
            MC mc = new MC(DateTime.Now, secondRegNr);
            int spotFirst = pLot.AddVehicle(c, 5);
            int spotSecond = pLot.AddVehicle(mc, 5);

            // Check vehicles at parkinglot
            Assert.AreEqual(expectedSpot, spotFirst);
        }

        [DataRow("aaa")]
        [TestMethod]
        public void TestRemoveVehicleParkingLot(string regNr)
        {
            ParkingLot pLot = new ParkingLot();
            pLot.AddParkingSpot(100, 10);

            MC expectedMc = new MC(DateTime.Now, regNr);
            pLot.AddVehicle(expectedMc);
            IVehicle actualMc = pLot.RemoveVehicle(expectedMc.RegNum);

            Assert.AreEqual(expectedMc, actualMc);
        }

        [DataRow("aaa")]
        [TestMethod]
        public void TestSearchVehicleParkingLot(string regNr)
        {
            ParkingLot pLot = new ParkingLot();
            pLot.AddParkingSpot(100, 10);

            MC expectedMc = new MC(DateTime.Now, regNr);
            pLot.AddVehicle(expectedMc);
            IVehicle vehicle = pLot.SearchVehicle(expectedMc.RegNum, out int location);

            Assert.AreEqual(expectedMc, vehicle);
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
