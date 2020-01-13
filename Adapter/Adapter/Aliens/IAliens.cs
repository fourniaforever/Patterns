using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Aliens
{
    interface IAliens
    {
        string Race{get; }
        void Greeting();
        void Sign();
    }
}
