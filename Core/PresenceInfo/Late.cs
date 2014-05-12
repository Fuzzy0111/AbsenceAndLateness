using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.PresenceInfo
{
    public class Late: Presence
    {
        public int LatenessAmount;

        public Late()
        {
            LatenessAmount = 0;
        }

        public void IsLate(String studentID, bool isOnTime)
        {
            if (!isOnTime)
            {
                //Add name to a list of latecomer
            }
        }

        public int Calc_num_lateness(bool isLate, int LatenessAmount)
        {
            if (isLate)
            {
                LatenessAmount += 1;
            }
            else
            {
                LatenessAmount += 0;
            }

            return LatenessAmount;
        }
    }
}
