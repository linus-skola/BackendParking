using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleObjects
{
    public class Car : IVehicle
    {
        public DateTime InTime { get; }
        public string RegNum { get; }
        public int Size { get; }
        public VehicleType VehicleType { get; }
        public Car()
        {
            Size = 10;
        }

        public Car(DateTime inTime, string regNum, int size)
        {
            InTime = inTime;
            RegNum = regNum;
            Size = size;
            VehicleType = VehicleType.CAR;
        }

        public object Clone()
        {
            return new Car(DateTime.Parse(InTime.ToString()),
                           (string)RegNum.Clone(),
                           Size);
        }
    }
}
