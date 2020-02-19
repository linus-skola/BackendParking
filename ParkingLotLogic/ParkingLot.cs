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
        /// <summary>
        /// Add a vehicle in position. Can find best positon with AddVehicle(IVheicle) method.
        /// </summary>
        /// <param name="vehicle"></param>
        /// <param name="parkingSpot"></param>
        /// <returns></returns>
        public int AddVehicle(IVehicle vehicle, int parkingSpot)
        {
            bool sucssesfullAdd = parkingSpots[parkingSpot].AddVehicle(vehicle, parkingSpot);
            if (sucssesfullAdd == false)
            {
                parkingSpot = -1;
            }
            return parkingSpot;
        }
        private int AddVehicle(IVehicle vehicle)
        {
            int foundSpot = -1;
            int currentSpotIndex = 1;
            int vehicleSize = vehicle.Size;
            foreach (ParkingSpot pSpot in parkingSpots)
            {
                if(pSpot.currentCapacity >= vehicleSize)
                {
                    foundSpot = currentSpotIndex;
                    break;
                }
                currentSpotIndex++;
            }

            return foundSpot;
        }
        public IVehicle RemoveVehicle(string regNum)
        {
            IVehicle matchingVehicle = SearchVehicle(regNum, out int location);
            if(matchingVehicle != null)
            {
                parkingSpots[location].RemoveVehicle(regNum);
            }
            return matchingVehicle;
        }
        public IVehicle SearchVehicle(string regNum, out int location)
        {
            foreach(ParkingSpot pSpot in parkingSpots)
            {
                if(pSpot.)
            }
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
                    int moveLocation = AddVehicle(vehicle);
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
