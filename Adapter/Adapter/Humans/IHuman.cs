using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Humans
{
    interface IHuman
    {
        string Name { get; set; }
        void Greeting();
        void Speak();
    }
}
