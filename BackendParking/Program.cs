using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleObjects;
using ParkingLotLogic;

namespace BackendParking
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hej");
            ParkingLot parking = new ParkingLot();
            parking.AddParkingSpot(100, 10);

            Car car = new Car(DateTime.Now, "test", 10);
            int location = parking.AddVehicle(car);

            Console.WriteLine(location);

        }
    }
}
