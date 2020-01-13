using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Drinks
{
    class Cacao:DrinksBase 
    {
        public Cacao(bool v)
        {
            Description = "Cacao with milk";
            vegan = v;
        }
      
        public override double GetCost()
        {
            return 100;
        }

    }
}
