using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public int Wheels { get; set; } = 4;
        public int Year { get; set; } = 2022;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Mustang";
    }
}
