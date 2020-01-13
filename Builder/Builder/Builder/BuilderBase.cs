using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    abstract class BuilderBase
    {
        protected House house;

        protected BuilderBase()
        {
            house = new House();
        }

        public House GetHouse()
        {
            return house;
        }

        public abstract void BuildFacade();
        public abstract void BuildWindow();
        public abstract void BuildDoor();
        public abstract void BuildRoof();
        public abstract void BuildLadders();
        public abstract void BuildSafety();
    }
}
