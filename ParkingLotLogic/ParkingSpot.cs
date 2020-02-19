using System;
using System.Collections.Generic;
using System.Text;
using VehicleObjects;

namespace ParkingLotLogic
{
    class ParkingSpot
    {
        int maxCapacity { get; set; }
        int currentCapacity { get; set; }

        List<IVehicle> vehiclesInSpot = new List<IVehicle>();

        internal ParkingSpot()
        {

        }
        internal bool AddVehicle(IVehicle vehicle)
        {
            throw new NotImplementedException();
        }
        internal IVehicle RemoveVehicle(string regNum)
        {
            throw new NotImplementedException();
        }
        internal bool FindVehicle(string regNum)
        {
            throw new NotImplementedException();
        }

        internal object CloneSpot()
        {
            throw new NotImplementedException();
        }
    }
}
