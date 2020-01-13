using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class IndustrialBuilder:BuilderBase
    {
        public IndustrialBuilder()
            : base()
        {
        }

        public override void BuildFacade()
        {
            house.Facade = "glasses";
        }

        public override void BuildDoor()
        {
            house.Door += "Del Mare white tree F010";
        }

        public override void BuildRoof()
        {
            house.Roof = "soft roof";
        }

        public override void BuildLadders()
        {
            house.Ladders = "staircase";
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
