using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingLotLogic;
using VehicleObjects;

namespace TestingBackendParking
{
    [TestClass]
    public partial class UnitTesting
    {
        [TestMethod]
        public void CarlsTestMethod()
        {
            //Arrange
            ParkingLot parking = new ParkingLot();
            var car = new Car();

            //Act
            DateTime date = Convert.ToDateTime("2019.01.02");
            car = new Car(date, "rirre");
            int parkingSpot = parking.AddVehicle(car);

            //Assert
            Assert.IsTrue(parkingSpot > 0);

        }
    }
}
