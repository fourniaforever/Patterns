using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory.Factory;
using AbstractFactory.Factory.Maskara;
using AbstractFactory.Factory.Lipstick;

namespace AbstractFactory.Factory
{
    class Client
    {
        private AbMaskara maskara;
        private AbLipstick lipstick;
        public Client(AFactory factory)
        {
            maskara = factory.CreateMaskara();
            lipstick = factory.CreateLipstick();
        }
        public void Run()
        {
            Console.WriteLine("Begining flow...");
            lipstick.Interact();
            maskara.Interact();
        }

    }
}
