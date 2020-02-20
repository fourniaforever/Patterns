using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory.Lipstick
{
    class TooFacedLipstick:AbLipstick
    {
        public override void Interact()
        {
            Console.WriteLine("Creating lipstick");
        }
    }
}
