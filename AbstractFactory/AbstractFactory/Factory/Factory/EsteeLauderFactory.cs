using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory.Chemicals;
using AbstractFactory.Factory.Lipstick;

namespace AbstractFactory.Factory.Factory
{
    class EsteeLauderFactory : AFactory
    {
        public override AbLipstick CreateLipstick()
        {
            Console.WriteLine("Creating EsteeLauderLipstick...");
            return new EsteeLauderLipstick();
        }
        public override AbChemicals CreateChemicals()
        {
            Console.WriteLine("Creating EsteeLauderChemicals...");
            return new EsteeLauderCh();
        }

    }
}
