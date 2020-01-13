using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Humans
{
    class Russians:IHuman
    {
        public string Name { get; set; }
        public Russians(string Name)
        {
            this.Name = Name;
        }
        public void Greeting()
        {
            Console.WriteLine("ZDAROVA");
        }
        public void Speak()
        {
            Console.WriteLine("CHEGO");
        }

    }
}


