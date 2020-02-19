using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleObjects
{
    public interface IVehicle : ICloneable
    {
        DateTime InTime { get; set; }
        string RegNum { get; set; }
        int Size { get; set; }

    }
}
