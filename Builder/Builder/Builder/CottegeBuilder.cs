using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class CottegeBuilder:BuilderBase
    {
        public CottegeBuilder() : base()
        {
        }

        public override void BuildFacade()
        {
            house.Facade = "brick";
        }

        public override void BuildDoor()
        {
            house.Door += "Del Mare white tree F010";
        }

        public override void BuildRoof()
        {
            house.Roof = "metal tile";
        }

        public override void BuildLadders()
        {
            house.Ladders = "Spiral staircase SPIRAL EFFECT";
        }

        public override void BuildWindow()
        {
            house.Window = "Rehau";
        }

        public override void BuildSafety()
        {
            house.Safety = "signaling";
        }
    }
}
