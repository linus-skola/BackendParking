using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleObjects
{
    public partial class MC : IVehicle
    {
        public DateTime InTime { get; }
        public string RegNum { get; }
        public int Size { get; }
        public VehicleType VehicleType { get; }
        public MC()
        {
            Size = 5;
        }
        public MC(DateTime inTime, string regNum, int size)
        {
            InTime = inTime;
            RegNum = regNum;
            Size = size;
            VehicleType = VehicleType.CM;
        }

        public object Clone()
        {
            return new Car(DateTime.Parse(InTime.ToString()),
                           (string)RegNum.Clone(),
                           Size);
        }
    }
}
