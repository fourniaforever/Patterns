using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Humans;
namespace Adapter
{
    class InfoPrinter
    {
        public static void PrintInfo (IHuman human)
        {
            Console.WriteLine("Досье:");
            Console.WriteLine("Имя: {0}", human.Name);
            Console.Write("Приветствие: ");
            human.Greeting();
            Console.Write("Разговор: ");
            human.Speak();
            Console.WriteLine();




        }
    }
}
