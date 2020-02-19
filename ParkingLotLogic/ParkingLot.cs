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
        public int AddVehicle(IVehicle vehicle)
        {
            throw new NotImplementedException();
        }
        public IVehicle RemoveVehicle(string regNum)
        {
            throw new NotImplementedException();
        }
        public IVehicle SearchVehicle(string regNum, out int location)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// ´Metod som flyttar ett fordon från en plats till en annan
        /// </summary>
        /// <param name="regNum"></param>
        /// <param name="newLocation"></param>
        /// <returns></returns>
        public int MoveVehicle(string regNum, int newLocation)
        {
            int oldLocation = 0;

            IVehicle vehicleToMove = SearchVehicle(regNum, out oldLocation);
            RemoveVehicle(vehicleToMove.RegNum);

            if (vehicleToMove != null)
            {
                int newSpot = AddVehicle(vehicleToMove, newLocation);

                if(newSpot == -1)
                {
                    AddVehicle(vehicleToMove, oldLocation);
                    return newSpot;
                }
                else
                {
                    return newSpot;
                }
            }

            else
            {
                return -1;
            }
        }
        /// <summary>
        /// Skickar tillbaka en lista av IVehicles med hjälp av Clonespot i parkingspot.
        /// </summary>
        /// <param name="location">platsen att clona</param>
        /// <returns></returns>
        public List<IVehicle> ParkingSpotContent(int location)
        {
            ParkingSpot spot  = parkingSpots[location - 1].CloneSpot() as ParkingSpot;
            List<IVehicle> vehicles = spot.vehiclesInSpot;
            return vehicles;    
        }
        public List<string> OptimizeParkingLot()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Lägger till nya platser i parkeringen av valfri storlek
        /// </summary>
        /// <param name="amount"> så många platser vi vill lägga till</param>
        /// <param name="spotSize">storleken på platsen</param>
        /// <returns></returns>
        public bool AddParkingSpot(int amount, int spotSize)
        {
            int parkingcount = parkingSpots.Count;

            for (int i = 0; i < amount; i++)
            {
                ParkingSpot spot = new ParkingSpot(spotSize);
                parkingSpots.Add(spot);
            }

            if (parkingSpots.Count == parkingcount + amount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
