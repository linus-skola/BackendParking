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

        internal ParkingSpot()
        {

        }
        internal bool AddVehicle(IVehicle vehicle, int position)
        {
            if (vehicle.Size <= currentCapacity)
            {
                vehiclesInSpot.Add(vehicle);
                currentCapacity -= vehicle.Size;
                return true;
            }
            else
            {
                return false;
            }
        }
        internal IVehicle RemoveVehicle(string regNum)
        {
            throw new NotImplementedException();
        }
        internal (IVehicle, int) FindVehicle(string regNum)
        {
            int foundAtIndex = -1;
            IVehicle foundVehicle = null;
            int currentIndex = 0;
            foreach (IVehicle vehicle in vehiclesInSpot)
            {
                if(vehicle.RegNum == regNum)
                {
                    foundVehicle = vehicle;
                    foundAtIndex = currentIndex; 
                    break;
                }
                currentIndex++;
            }
            return (foundVehicle, foundAtIndex);
        }

        internal object CloneSpot()
        {
            throw new NotImplementedException();
        }
    }
}
