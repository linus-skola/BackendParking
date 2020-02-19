﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleObjects
{
    public class MC : IVehicle
    {
        public DateTime InTime { get; set; }
        public string RegNum { get; set; }
        public int Size { get; set; }

        public MC()
        {
            Size = 5;
        }
    }
}
