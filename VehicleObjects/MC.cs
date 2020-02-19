using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleObjects
{
    public partial class MC : IVehicle
    {
        public DateTime InTime { get; set; }
        public string RegNum { get; set; }
        public int Sizeee { get; set; }

        public MC()
        {
            Size = 5;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
