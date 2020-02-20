using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory.Maskara;

namespace AbstractFactory.Factory.Lipstick
{
    class EsteeLauderLipstick:AbLipstick
    {
        public override void Interact()
        {
            Console.WriteLine("Creating lipstick");
        }
    }
}
