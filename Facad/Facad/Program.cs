using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facad.Machine;

namespace Facad
{
   class Program
    {
       static void Main(string[] args)
        {
            var found = new Foundation();
            var blush = new Blush();
            var shadow = new Eyeshadow();
            var lipstick = new Lipstick();

            var face = new Face(found, blush, lipstick,shadow);

            //Cool
            Console.WriteLine("Cool tone");
            face.MakeupCoolTone();

            Console.WriteLine();

            //Warm
            Console.WriteLine("Warm");
            face.MakeupWarmTone();
            Console.ReadLine();
        }
    }
}
