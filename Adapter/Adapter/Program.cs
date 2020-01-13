using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Humans;
using Adapter.Aliens;
using Adapter.Adapter;
using Adapter.Environment;
namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IAliens aliens = new Aliens.Marsians();
            HumanAdapter adapter = new HumanAdapter(aliens);
            InfoPrinter.PrintInfo(adapter);
            Console.ReadLine();

            Earth home = Earth.Inizialize();
            home.Add("Иван", "John");
            home.Print();

            Earth home2 = Earth.Inizialize();
            home2.Print();

            Console.WriteLine(home.GetHashCode());
            Console.WriteLine(home2.GetHashCode());

            Environment.Mars al = new Environment.Mars();
            al.Add();
            al.Print();
            Console.ReadLine();
        }
    }
}
