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
        public int MoveVehicle(string regNum, int newLocation)
        {
            throw new NotImplementedException();
        }
        public List<IVehicle> ParkingSpotContent(int location)
        {
            throw new NotImplementedException();
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
