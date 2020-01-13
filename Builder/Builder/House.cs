using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class House
    {

        public string Facade { get; set; }
        public string Window { get; set; }
        public string Door { get; set; }
        public string Roof { get; set; }
        public string Ladders { get; set; }
        public string Safety { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("Facade: {0}\n", Facade);
            sb.AppendFormat("Window: {0}\n", Window);
            sb.AppendFormat("Door: {0}\n", Door);
            sb.AppendFormat("Roof: {0}\n", Roof);
            sb.AppendFormat("Ladders: {0}\n", Ladders);
            sb.AppendFormat("Safety: {0}\n", Safety);
            return sb.ToString();
        }
    }
}
