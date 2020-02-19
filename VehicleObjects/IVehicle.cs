using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleObjects
{
    public interface IVehicle : ICloneable
    {
        Enum VehicleType { get; }
        DateTime InTime { get; }
        string RegNum { get;  }
        int Size { get; }
        VehicleType VehicleType { get; }
        
    }
}
