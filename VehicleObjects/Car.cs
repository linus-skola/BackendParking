using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleObjects
{
<<<<<<< HEAD
    public class Car : IVehicle
=======
    public partial class Car : IVehicle
>>>>>>> 32e74fefaae2fdf679b7648db674fbea49df5486
    {
        public DateTime InTime { get; }
        public string RegNum { get; }
        public int Size { get; }

        public Car()
        {
            Size = 10;
        }

<<<<<<< HEAD
        public Car(DateTime inTime, string regNum, int size)
        {
            InTime = inTime;
            RegNum = regNum;
            Size = size;
        }

        public object Clone()
        {
            return new Car(DateTime.Parse(InTime.ToString()),
                           (string) RegNum.Clone(),
                           Size);
=======
        public object Clone()
        {
            throw new NotImplementedException();
>>>>>>> 32e74fefaae2fdf679b7648db674fbea49df5486
        }
    }
}
