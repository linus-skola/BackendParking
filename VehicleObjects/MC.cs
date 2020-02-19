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

        public MC()
        {
            Size = 5;
        }
<<<<<<< HEAD
        public MC(DateTime inTime, string regNum, int size)
        {
            InTime = inTime;
            RegNum = regNum;
            Size = size;
        }

        public object Clone()
        {
            return new Car(DateTime.Parse(InTime.ToString()),
                           (string)RegNum.Clone(),
                           Size);
=======

        public object Clone()
        {
            throw new NotImplementedException();
>>>>>>> 32e74fefaae2fdf679b7648db674fbea49df5486
        }
    }
}
