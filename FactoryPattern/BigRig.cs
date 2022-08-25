using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class BigRig : IVehicle
    {
        public int Wheels { get; set; } = 18;
        public int Year { get; set; } = 2010;
        public string Make { get; set; } = "Mack";
        public string Model { get; set; } = "Truck";
    }
}
