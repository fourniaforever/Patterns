using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Humans
{
    public class Americans :IHuman
    {
        public string Name { get; set; }
        public Americans(string Name)
        {
            this.Name = Name;
        }
        public void Greeting()
        {
            Console.WriteLine("Hi! Nice to meet you there");
        }
        public void Speak()
        {
            Console.WriteLine("English");
        }


    }
}
