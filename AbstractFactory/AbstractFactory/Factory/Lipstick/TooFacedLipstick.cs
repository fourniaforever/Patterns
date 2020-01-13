using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory.Chemicals;

namespace AbstractFactory.Factory.Lipstick
{
    class TooFacedLipstick:AbLipstick
    {
        public override void Interact(AbChemicals chemicals)
        {
            Console.WriteLine(GetHashCode() + " interact with " + chemicals.GetHashCode());
        }
    }
}
