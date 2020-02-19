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
            this.currentCapacity = maxCapacity;
        }
        internal bool AddVehicle(IVehicle vehicle)
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
            var result = FindVehicle(regNum);
            IVehicle vehicle = result.Item1;
            int spotIndex = result.Item2;
            if (spotIndex != -1)
            {
                vehicle = vehiclesInSpot[spotIndex];
                currentCapacity += vehicle.Size;
                vehiclesInSpot.Remove(vehicle);
            }
            return vehicle;
        }
        internal (IVehicle vehicle, int position) FindVehicle(string regNum)
        {
            int position = 0;
            foreach (IVehicle vehicle in vehiclesInSpot)
            {
                if (vehicle.RegNum == regNum)
                {
                    return (vehicle, position);
                }
                position++;
            }

            return (null, -1);
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
