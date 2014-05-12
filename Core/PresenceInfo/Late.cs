using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.PresenceInfo
{
    public class Late: Absent
    {
        public int LatenessAmount;

        public Late()
        {
            LatenessAmount = 0;
        }        
    }
}
