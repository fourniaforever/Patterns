using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory.Lipstick;
using AbstractFactory.Factory.Chemicals;
namespace AbstractFactory.Factory.Factory
{
    class LimeCrimeFactory:AFactory
    {
        public override AbLipstick CreateLipstick()
        {
            Console.WriteLine("Creating LimeCrimeLipstick...");
            return new LimeCrimeLipstick();
        }
        public override AbChemicals CreateChemicals()
        {
            Console.WriteLine("Creating LimeCrimeChemicals...");
            return new LimeCrimeCh();
        }

    }
}
