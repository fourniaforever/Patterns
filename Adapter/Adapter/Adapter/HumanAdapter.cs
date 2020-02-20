using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Humans;
using Adapter.Aliens;
namespace Adapter.Adapter
{
    class HumanAdapter: IHuman
    {
        private IAliens aliens;
        public HumanAdapter(IAliens aliens)
        {
            this.aliens = aliens;
        }
        public string Name
        {
            get
            {
                return aliens.Race;

            }
            set { }
        }
        public void Greeting() {
            aliens.Greeting();
        }
        public void Speak()
        {
            aliens.Sign();
        }

    }
}
