﻿using System;
using System.Collections.Generic;
using System.Text;
using VehicleObjects;

namespace ParkingLotLogic
{
    public class ParkingLot
    {
        private List<ParkingSpot> parkingSpots = new List<ParkingSpot>();

        public ParkingLot()
        {

        }
        /// <summary>
        /// Add a vehicle in position. Can find best positon with AddVehicle(IVheicle) method.
        /// </summary>
        /// <param name="vehicle"></param>
        /// <param name="parkingSpot"></param>
        /// <returns></returns>
        public int AddVehicle(IVehicle vehicle, int parkingSpot)
        {
            bool sucssesfullAdd = parkingSpots[parkingSpot].AddVehicle(vehicle);
            if (sucssesfullAdd == false)
            {
                parkingSpot = -1;
            }
            return parkingSpot;
        }
        public int AddVehicle(IVehicle vehicle)
        {
            return FindSpot(vehicle, pSpot => pSpot.AddVehicle(vehicle));
        }

        internal int FindSpot(IVehicle vehicle, Action<ParkingSpot> toDoWithSpot)
        {
            int foundSpot = -1;
            int currentSpotIndex = 0;
            int vehicleSize = vehicle.Size;
            foreach (ParkingSpot pSpot in parkingSpots)
            {
                if (pSpot.currentCapacity >= vehicleSize)
                {
                    foundSpot = currentSpotIndex;
                    toDoWithSpot(pSpot);
                    break;
                }
                currentSpotIndex++;
            }

            return foundSpot;
        }

        public IVehicle RemoveVehicle(string regNum)
        {
            int location = 0;
            IVehicle matchingVehicle = SearchVehicle(regNum, out location);
            if(matchingVehicle != null)
            {
                parkingSpots[location].RemoveVehicle(regNum);
            }
            return matchingVehicle;
        }
        public IVehicle SearchVehicle(string regNum, out int location)
        {
            location = 0;
            foreach(ParkingSpot pSpot in parkingSpots)
            {
                var foundVehicle = pSpot.FindVehicle(regNum);
                if (foundVehicle.vehicle != null)
                {
                    return foundVehicle.vehicle;
                }
                location++;
            }
            return null;
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
        /// <summary>
        /// Loop throug all vehicles and moves if there is a better spot. returns a move order that can be displayed in frontend.
        /// </summary>
        /// <returns></returns>
        public List<string> OptimizeParkingLot()
        {
            List<string> orderMessages = new List<string>();
            int maxSized = 10;
            // loopar det sista fordonet och loppar nedåt.
            for (int i = parkingSpots.Count - 1; i >= 0; i--)
            {
                ParkingSpot parkingSpot = parkingSpots[i];
                for (int y = 0; y < parkingSpot.vehiclesInSpot.Count; y++)
                {
                    var vehicle = parkingSpot.vehiclesInSpot[y];

                    // kollar bästa möjliga plats att flytta varje fordon.

                    int moveLocation = FindSpot(vehicle, x => x.ToString());
                    if (moveLocation < i)
                    {
                        RemoveVehicle(vehicle.RegNum);
                        AddVehicle(vehicle, moveLocation);
                        string orderMessage = String.Format($"Flytta fordon med regnummer {vehicle.RegNum} från plats {i} till plats {moveLocation + 1}");
                        orderMessages.Add(orderMessage);
                        y--;
                    }
                    else
                    {
                        if (maxSized > 0)
                        {
                            maxSized -= 5;
                        }
                    }
                }
            }
            return orderMessages;
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
        public int Count()
        {
            int counter = 0;
            foreach(var item in parkingSpots)
            {
                counter++;
            }
            return counter;
        }
    }
}
