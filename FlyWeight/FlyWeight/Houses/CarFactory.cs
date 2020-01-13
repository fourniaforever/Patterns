using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Houses
{
    class CarFactory
    {
        Dictionary<string, AbstractCar> cars = new Dictionary<string, AbstractCar>();
        public CarFactory()
        {
            cars.Add("Грузовая", new Truck());
            cars.Add("Легковая", new AutomobileCar());
        }

        public AbstractCar GetCar(string key)
        {
            if (cars.ContainsKey(key))
                return cars[key];
            else
                return null;
        }
    }
}
