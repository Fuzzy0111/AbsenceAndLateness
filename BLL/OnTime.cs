using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OnTime
    {
        private double time;

        public OnTime()
        {
            time = 8.15;
        }
        
        public bool IsOnTime(double timeArrived)
        {
            if (time > timeArrived)
            {
                return true;
            }

            else
                return false;
        }
    }
}
