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
        public bool AddParkingSpot(int amount, int spotSize)
        {
            throw new NotImplementedException();
        }
    }
}
