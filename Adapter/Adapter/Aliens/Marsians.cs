using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Aliens
{
    class Marsians:IAliens
    {
        public string Race { get { return "Марсианин"; } }
        public void Greeting ()
        {
            Console.WriteLine("До покорения земли осталось...");

        }
        public void Sign ()
        {
            Console.WriteLine("*Пришелец разводит руками и просто начинает расстрел*");
        }
    }
}
