using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.PresenceInfo;

namespace BLL
{
    public class LateDirectory
    {       
        public Late LateStudent { get; }
        public double Time { get; set; }

        public LateDirectory()
        {
            
        }

        public bool IsOnTime(double timeArrived)
        {
            return (Time > timeArrived ) ? true : false;            
        }

        public void IsLate(String studentID, bool isOnTime)
        {
            if (!isOnTime)
            {
                //Add name to a list of latecomer
            }
        }

        public int CalculateLatenessAmount(bool isOnTime, int latenessAmount)
        {
            return latenessAmount += isOnTime ? 0 : 1;
        }
    }
}
