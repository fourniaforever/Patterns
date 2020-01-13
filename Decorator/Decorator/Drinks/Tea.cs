using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Drinks
{
    class Tea:DrinksBase
    {
        public Tea()
        {
            Description = "Black tea";
        }
        public override double GetCost()
        {
            return 70;
        }
    }
}
