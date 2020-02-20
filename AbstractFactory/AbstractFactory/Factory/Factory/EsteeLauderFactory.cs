using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory.Maskara;
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
        public override AbMaskara CreateMaskara()
        {
            Console.WriteLine("Creating EsteeLauderMaskara...");
            return new EsteeLauderM();
        }

    }
}
