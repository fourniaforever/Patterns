using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Humans;

namespace Adapter.Environment
{
    class Earth
    {
        private static Earth home = null;
        protected Earth() { }
        public static Earth  Inizialize()
        {
            if (home == null)
            {
                home = new Earth();
            }
            return home;
            
        }
       
        List<IHuman> humans = new List<IHuman>();
        public void Add(string name, string name2)
        {
            humans.Add(new Russians(name));
            humans.Add(new Americans(name2));
        }
        public void Print()
        {
            foreach (var item in humans)
            {
                InfoPrinter.PrintInfo(item);
            }
        }

        


    }
}
