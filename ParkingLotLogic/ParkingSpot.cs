using System;
using System.Collections.Generic;
using System.Text;
using VehicleObjects;

namespace ParkingLotLogic
{
    class ParkingSpot
    {
        internal int maxCapacity { get; set; }
        internal int currentCapacity { get; set; }

        internal List<IVehicle> vehiclesInSpot = new List<IVehicle>();

        internal ParkingSpot(int maxCapacity)
        {
            this.maxCapacity = maxCapacity;
            this.currentCapacity = currentCapacity;
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
