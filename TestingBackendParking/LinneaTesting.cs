﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingLotLogic;
using VehicleObjects;

namespace TestingBackendParking
{
    [TestClass]
    public class LinneaTesting
    {
        // Fix
        [DataRow(0, 0)]
        [DataRow(5, 60)]

        [TestMethod]
        public void TestAddVehicleParkingLot()
        {
            int expectedSpot = 1;
            ParkingLot pLot = new ParkingLot();
            pLot.AddParkingSpot(100, 10);

            Car c = new Car(DateTime.Now, "aaa");
            int spot = pLot.AddVehicle(c);

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
