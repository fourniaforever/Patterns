using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Houses
{
    abstract class AbstractCar
    {
        protected int horsepower; // количество лошадиных сил

        public abstract void Build(double longitude, double latitude);
    }
}
