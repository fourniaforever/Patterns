using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory;
using AbstractFactory.Factory.Factory;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = null;
            client = new Client(new EsteeLauderFactory());
            client.Run();
            Console.WriteLine();
            client = new Client(new TooFacedFactory());
            client.Run();
            Console.WriteLine();
            client = new Client(new LimeCrimeFactory());
            client.Run();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
