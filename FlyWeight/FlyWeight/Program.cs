using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyWeight.Houses;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            double longitude = 37.89;
            double latitude = 59.98;

            CarFactory houseFactory = new CarFactory();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                AbstractCar autocar = houseFactory.GetCar("Легковая");
                if (autocar != null)
                    autocar.Build(longitude, latitude);
                longitude += 0.2;
                latitude += 0.2;
            }

            for (int i = 0; i < n; i++)
            {
                AbstractCar truck = houseFactory.GetCar("Грузовая");
                if (truck != null)
                    truck.Build(longitude, latitude);
                longitude += 0.2;
                latitude += 0.2;
            }

            Console.ReadLine();
        }
    }
}
