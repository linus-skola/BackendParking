using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleObjects;
using ParkingLotLogic;

namespace TestingBackendParking
{
    public partial class UnitTesting
    {
        [TestMethod]
        public void RikardsTestAddParkingSpots()
        {
            int expectedLength = 100;
            ParkingLot parkingLot = new ParkingLot();

            //Act
            parkingLot.AddParkingSpot(100, 10);
            int actualLength = parkingLot.Count();
            //Assert
            Assert.AreEqual(expectedLength, actualLength);

        }
        [TestMethod]
        public void RikardsTestAddCar()
        {
            int expectedSpot = 3;
            IVehicle vehicle = new Car(DateTime.Now, "Test");
            ParkingLot parkingLot = new ParkingLot();
            parkingLot.AddParkingSpot(10, 10);

            //Act
            int spot = parkingLot.AddVehicle(vehicle, 3);
            //Assert
            Assert.AreEqual(expectedSpot, spot);

        }

    }
}
