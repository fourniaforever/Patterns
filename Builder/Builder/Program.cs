using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Builder;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new CottegeBuilder();
            builder.BuildFacade(); 
            builder.BuildDoor(); 
            builder.BuildWindow();
            var house = builder.GetHouse();
            Console.WriteLine(house);

            builder.BuildSafety();
            house = builder.GetHouse();
            Console.WriteLine(house);
            Console.ReadLine();






        }
    }
}
