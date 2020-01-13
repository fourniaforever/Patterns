using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Aliens;
using Adapter.Adapter;

namespace Adapter.Environment
{
    class Mars
    {
        List<IAliens> aliens = new List<IAliens>();
        private HumanAdapter adapter;
        public void Add()
        {
            aliens.Add(new Marsians());
        }
        public void Print()
        {
            foreach (var item in aliens)
            {
                adapter = new HumanAdapter(item);
                InfoPrinter.PrintInfo(adapter);
            }
        }
    }
}
