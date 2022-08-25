using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VehicleFactory
    {
        public static IVehicle GetVehicle(int numberOfWheels)
        {
            switch (numberOfWheels)
            {
                case 2:
                    return new Motorcycle();
                    break;
                case 4:
                    return new Car();
                    break;
                case 18:
                    return new BigRig();
                    break;
                default:
                    return new Car();
                        break;
            }

        }


    }
}
