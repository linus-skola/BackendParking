using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleObjects
{
    public interface IVehicle : ICloneable
    {
        DateTime InTime { get; }
        string RegNum { get;  }
        int Size { get; }
        VehicleType VehicleType { get; }
        
    }
}
