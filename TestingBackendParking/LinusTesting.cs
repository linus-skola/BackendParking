using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleObjects;
using ParkingLotLogic;

namespace TestingBackendParking
{
    public partial class UnitTesting
    {
        [TestMethod]
        public void LinusTestMethod()
        {
            IVehicle vehicle = new Car(DateTime.UtcNow, "2Fast4You");


        }
    }
}
