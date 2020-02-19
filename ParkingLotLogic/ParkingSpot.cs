﻿using System;
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
            var result = FindVehicle(regNum);
            int spotIndex = result.Item1;
            vehiclesInSpot.Remove(spotIndex);
        }
        internal (IVehicle, int) FindVehicle(string regNum)
        {
            IVehicle foundVehicle = null;
            int currentIndex = 0;

            int foundAtIndex = vehiclesInSpot.IndexOf(x => x.RegNum == regNum);
            if (foundAtIndex != -1)
            {
                foundVehicle = vehiclesInSpot[foundAtIndex];
            }
            return (foundVehicle, foundAtIndex);
        }

        internal object CloneSpot()
        {
            throw new NotImplementedException();
        }
    }
}
