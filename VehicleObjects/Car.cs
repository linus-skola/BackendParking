using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleObjects
{
    public partial class Car : IVehicle
    {
        public DateTime InTime { get; set; }
        public string RegNum { get; set; }
        public int Size { get; set; }

        public Car()
        {
            Size = 10;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
