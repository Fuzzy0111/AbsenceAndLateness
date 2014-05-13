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

        public int CalcNumLateness(bool isLate, int latenessAmount)
        {
            return latenessAmount += isLate ? 1 : 0;
        }
    }
}
