using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facad.Machine
{
    class Face
    {
        private Foundation foundation;
        private Blush blush;
        private Lipstick lip;
        private Eyeshadow shadow;

        public Face(Foundation foundation, Blush blush, Lipstick lip, Eyeshadow shadow)
        {
            this.foundation = foundation;
            this.blush = blush;
            this.lip = lip;
            this.shadow = shadow;
        }

        public string GetTone()
        {
            return blush.GetTone();
        }

        public void MakeupCoolTone()
        {
            foundation.Resistance(20);
            blush.GetTone();
            lip.Shine();
            shadow.Apply();
            shadow.Stop();

        }

        public void MakeupWarmTone()
        {
            foundation.Resistance(24);
            blush.GetTone();
            blush.WarmUp();
            lip.Matte();
            shadow.Apply();
            shadow.Stop();
        }
    }
}
