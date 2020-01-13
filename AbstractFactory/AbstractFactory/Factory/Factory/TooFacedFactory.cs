using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory.Chemicals;
using AbstractFactory.Factory.Lipstick;
namespace AbstractFactory.Factory.Factory
{
    class TooFacedFactory:AFactory
    {
        public override AbLipstick CreateLipstick()
        {
            Console.WriteLine("Creating TooFacedLipstick...");
            return new TooFacedLipstick();
        }
        public override AbChemicals CreateChemicals()
        {
            Console.WriteLine("Creating TooFacedChemicals...");
            return new TooFacedCh();
        }

    }
}
