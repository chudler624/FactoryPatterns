using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("The vehicle drives");
        }

        public int Wheels { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }








    }
}
