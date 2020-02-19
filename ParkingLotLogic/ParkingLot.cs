using System;
using System.Collections.Generic;
using System.Text;
using VehicleObjects;

namespace ParkingLotLogic
{
    class ParkingLot
    {
        List<ParkingSpot> parkingSpots = new List<ParkingSpot>();

        public ParkingLot()
        {

        }
        public int AddVehicle(IVehicle vehicle, int parkingSpot)
        {
            location = parkingSpots[parkingSpot].AddVehicle(vehicle);
        }
        private int FindBestSpot(int parkingSpot, ) // type of vehicle
        {
            foreach(ParkingSpot pspot in parkingSpots)
            {

            }


            //
            // 
            // vehicleTypeLocaitonTwo = locationTwoVehicle.typeEnum
            // if(vehicleTypeLocationOne == enum.car || )
            //{
            //  return -1;
            //}
            //else if()
            //{
            //  
            //}
        }
        public IVehicle RemoveVehicle(string regNum)
        {
            throw new NotImplementedException();
        }
        public IVehicle SearchVehicle(string regNum, out int location)
        {
            throw new NotImplementedException();
        }
        public int MoveVehicle(string regNum, int newLocation)
        {
            throw new NotImplementedException();
        }
        public List<IVehicle> ParkingSpotContent(int location)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Loop throug all vehicles and moves if there is a better spot. returns a move order that can be displayed in frontend.
        /// </summary>
        /// <returns></returns>
        public List<string> OptimizeParkingLot()
        {
            List<string> orderMessages = new List<string>();
            int maxSized = 10;
            // loopar det sista fordonet och loppar nedåt.
            for (int i = parkingSpots.Count - 1; i >= 0; i--)
            {
                ParkingSpot parkingSpot = parkingSpots[i];
                foreach (var vehicle in parkingSpot.vehiclesInSpot)
                {
                    // kollar bästa möjliga plats att flytta varje fordon.
                    int moveLocation = FindBestSpot(vehicle.Size);
                    if (moveLocation < i)
                    {
                        RemoveVehicle(vehicle.RegNum);
                        AddVehicle(vehicle, moveLocation);
                        string orderMessage = String.Format($"Flytta fordon med regnummer {vehicle.RegNum} från plats {i} till plats {moveLocation}");
                        orderMessages.Add(orderMessage);

                    }
                    else
                    {
                        if (maxSized > 0)
                        {
                            maxSized -= 5;
                        }
                    }
                }
            }
            return orderMessages;
        }
        public bool AddParkingSpot(int amount, int spotSize)
        {
            throw new NotImplementedException();
        }
    }
}
