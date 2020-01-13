using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory.Chemicals;

namespace AbstractFactory.Factory.Lipstick
{
    abstract class AbLipstick
    {
        public abstract void Interact(AbChemicals chemicals);
    }
}
