using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory.Chemicals;
using AbstractFactory.Factory.Lipstick;

namespace AbstractFactory.Factory.Factory
{
    abstract class AFactory
    {
        public abstract AbChemicals CreateChemicals();
        public abstract AbLipstick CreateLipstick();
    }
}
