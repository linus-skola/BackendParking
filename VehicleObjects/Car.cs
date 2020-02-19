using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleObjects
{
    class Car
    {
        public DateTime InTime { get; set; }
        public string RegNum { get; set; }
        public int Size { get; set; }

        public Car()
        {
            Size = 10;
        }
    }
}
