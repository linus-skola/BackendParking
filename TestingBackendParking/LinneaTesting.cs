using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingLotLogic;
using VehicleObjects;

namespace TestingBackendParking
{
    [TestClass]
    public class LinneaTesting
    {
        public TestContext TestContext { get; set; }
        private static ParkingLot pLot;

        private ParkingLot PLot
        {
            get => pLot;
        }

        #region ClassInitialize
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            pLot = new ParkingLot();
            context.WriteLine("Creating testing parkinglot");
            pLot.AddParkingSpot(100,10);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
        }
        #endregion


        // Cars
        [DataRow("aaa", 0)]
        [DataRow("bbb", 1)]
        [DataRow("ccc", 2)]

        [TestMethod]
        public void TestAddCarParkingLot(string regNr, int expectedSpot)
        {
            Car c = new Car(DateTime.Now, regNr);
            int spot = pLot.AddVehicle(c);

            Assert.AreEqual(expectedSpot, spot);
        }

        // Mc's
        [DataRow("ddd", 3)]
        [DataRow("eee", 3)]
        [DataRow("fff", 4)]
        [TestMethod]
        public void TestAddMcParkingLot(string regNr, int expectedSpot)
        {
            MC c = new MC(DateTime.Now, regNr);
            int spot = pLot.AddVehicle(c);

            Assert.AreEqual(expectedSpot, spot);
        }

        [DataRow("ggg", "hhh", 5)]
        [TestMethod]
        public void TestAddTwoMcAtSameSpotParkingLot(string firstRegNr, string secondRegNr, int expectedSpot)
        {
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
            IVehicle actualMc = pLot.RemoveVehicle(regNr);

            Assert.AreEqual(regNr, actualMc.RegNum);
        }

        [DataRow("hhh")]
        [TestMethod]
        public void TestSearchVehicleParkingLot(string regNr)
        {
            IVehicle vehicle = pLot.SearchVehicle(regNr, out int location);

            Assert.AreEqual(regNr, vehicle.RegNum);
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
