using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory.Maskara
{
    class TooFacedM: AbMaskara
    {
        public override void Interact()
        {
            Console.WriteLine("Creating maskara");
        }
    }
}
