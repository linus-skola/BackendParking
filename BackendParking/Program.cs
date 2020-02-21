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
            TestAddVehcle(parking);
            int location;
            TestMoveVehcle(parking, parking.SearchVehicle("test", out location), 2);
            //TestAddManyVehcle(parking);
            //TestOptimize(parking);

        }

        private static void TestAddAndMove(ParkingLot parking)
        {
            Car car = new Car(DateTime.Now, "test");
            int location = parking.AddVehicle(car);
            TestMoveVehcle(parking, car, 20);
        }
        private static void TestOptimize(ParkingLot parking)
        {
            for (int i = 0; i < 20; i++)
            {
                Car car = new Car(DateTime.Now, "test" + i);
                int location = parking.AddVehicle(car);
                Console.WriteLine($"Parkerade ny {car.VehicleType.ToString()} till plats {location}.");

                Random random = new Random();
                TestMoveVehcle(parking, car, 50+i);

            }
            List<string> orders = parking.OptimizeParkingLot();
            foreach (string item in orders)
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();


        }

        private static void TestAddAndremove(ParkingLot parking)
        {
            Car car = (Car)TestAddVehcle(parking);


            TestRemoveVehcle(parking, car);
        }

        private static IVehicle TestAddVehcle(ParkingLot parking)
        {
            Console.WriteLine("Hej");

            Car car = new Car(DateTime.Now, "test");
            int location = parking.AddVehicle(car);

            Console.WriteLine(location);
            return car;
        }
        private static void TestAddManyVehcle(ParkingLot parking)
        {
            Console.WriteLine("Hej");
            for (int i = 0; i < 10; i++)
            {
                Car car = new Car(DateTime.Now, "test" + i);
                int location = parking.AddVehicle(car);
                Console.WriteLine(location);
                if (i <= 5)
                {
                    TestRemoveVehcle(parking, car);

                }
                else
                {
                    TestMoveVehcle(parking, car, i + 30);
                }

            }
        }
        private static void TestRemoveVehcle(ParkingLot parking, IVehicle vehicle)
        {
            IVehicle removedVehcle = parking.RemoveVehicle(vehicle.RegNum);

            Console.WriteLine(removedVehcle.RegNum);
        }
        
        private static void TestMoveVehcle(ParkingLot parking, IVehicle vehicle, int position)
        {
            
            int moveToPosition = parking.MoveVehicle(vehicle.RegNum, position);
            Console.WriteLine($"flyttade till plats {moveToPosition}.");
        }
    }
}
