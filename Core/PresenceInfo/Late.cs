using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.PresenceInfo
{
    public class Late
    {
        public Student StudentInfo { get; set; }
        public double TimeArrived { get; set; }
        public int LatenessAmount { get; set; }

        public Late()
        {
        }

        public Late(Student studentInfo, double timeArrived)
        {
            StudentInfo = studentInfo;
            TimeArrived = timeArrived;
            LatenessAmount = 0;
        }        
    }
}
