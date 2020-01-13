using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory.Factory;
using AbstractFactory.Factory.Chemicals;
using AbstractFactory.Factory.Lipstick;

namespace AbstractFactory.Factory
{
    class Client
    {
        private AbChemicals chemicals;
        private AbLipstick lipstick;
        public Client(AFactory factory)
        {
            chemicals = factory.CreateChemicals();
            lipstick = factory.CreateLipstick();
        }
        public void Run()
        {
            Console.WriteLine("Begining flow...");
            lipstick.Interact(chemicals);
        }

    }
}
