using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Houses
{
    class Truck:AbstractCar
    {
        public Truck()
        {
            horsepower = 100;
        }

        public override void Build(double longitude, double latitude)
        {
            Console.WriteLine("Была собрана легковая машина, {0} лошадиных сил; координаты: {1} широты и {2} долготы",
                horsepower, latitude, longitude);
        }
    }
}
