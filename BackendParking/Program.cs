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

            ParkingLot parking = new ParkingLot();
            parking.AddParkingSpot(100, 10);
            

        }

        private static void TestAddAndMove(ParkingLot parking)
        {
            Car car = new Car(DateTime.Now, "test", 10);
            int location = parking.AddVehicle(car);
            Console.ReadKey();
            TestMoveVehcle(parking, car, 20);
        }
        private static void TestAddAndMoveAlot(ParkingLot parking)
        {
            for (int i = 0; i < 20; i++)
            {
                Car car = new Car(DateTime.Now, "test" + i, 10);
                int location = parking.AddVehicle(car);
                TestMoveVehcle(parking, car, 20);

            }
    
        }

        private static void TestAddAndremove(ParkingLot parking)
        {
            Car car = (Car)TestAddVehcle(parking);


            TestRemoveVehcle(parking, car);
        }

        private static IVehicle TestAddVehcle(ParkingLot parking)
        {
            Console.WriteLine("Hej");

            Car car = new Car(DateTime.Now, "test", 10);
            int location = parking.AddVehicle(car);

            Console.WriteLine(location);
            return car;
        }
        private static void TestRemoveVehcle(ParkingLot parking, IVehicle vehicle)
        {
            IVehicle removedVehcle = parking.RemoveVehicle(vehicle.RegNum);

            Console.WriteLine(removedVehcle.RegNum);
        }
        
        private static void TestMoveVehcle(ParkingLot parking, IVehicle vehicle, int position)
        {
            
            int moveToPosition = parking.MoveVehicle(vehicle.RegNum, position);
            Console.WriteLine(moveToPosition);
        }
    }
}
