using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facad.Machine
{
    class Blush
    {
        public string GetTone()
        {
            return "Pink";
        }
        
        public void WarmUp()
        {
            if (GetTone() == "Pink")
            { Console.WriteLine("Your blush is peach"); }
        }
    }
}
