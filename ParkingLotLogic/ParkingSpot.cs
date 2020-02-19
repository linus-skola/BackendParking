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

<<<<<<< HEAD
        internal List<IVehicle> vehiclesInSpot = new List<IVehicle>();

        internal ParkingSpot(int maxCapacity)
=======
        List<IVehicle> vehiclesInSpot = new List<IVehicle>();
        /// <summary>
        /// Standard car sized parkingspot.
        /// </summary>
        internal ParkingSpot()
>>>>>>> master
        {
            this.maxCapacity = maxCapacity;
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
            ParkingSpot clonedParkingSpot = new ParkingSpot(this.maxCapacity);
            foreach (IVehicle vehicle in this.vehiclesInSpot)
            {
                IVehicle clonedVehicle = vehicle.Clone() as IVehicle;
                clonedParkingSpot.vehiclesInSpot.Add(clonedVehicle);
            }
            return clonedParkingSpot;
        }
    }
}
