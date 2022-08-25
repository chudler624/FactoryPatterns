using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Motorcycle : IVehicle
    {
        public int Wheels { get; set; } = 2;
        public int Year { get; set; } = 2020;
        public string Make { get; set; } = "Harley Davidson";
        public string Model { get; set; } = "Fat Boy";
    }
}
