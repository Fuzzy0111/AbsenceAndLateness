using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Late
    {
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
