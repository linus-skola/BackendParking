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
            bool sucssesfullAdd = parkingSpots[parkingSpot].AddVehicle(vehicle);
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
        public List<string> OptimizeParkingLot()
        {
            throw new NotImplementedException();
        }
        public bool AddParkingSpot(int amount, int spotSize)
        {
            throw new NotImplementedException();
        }
    }
}
