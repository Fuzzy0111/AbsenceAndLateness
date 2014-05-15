using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.PresenceInfo;
using DAL;

namespace BLL
{
    public class LateDirectory
    {
        public LateTicket LateStudent { get; set; }
        public double Time { get; set; }
        public int LatenessAmount { get; set; }

        public LateDirectory()
        {
            LateStudent = new LateTicket();
            Time = 8.00;
            LatenessAmount = 0;
        }

        public int CalculateLatenessAmount(string studentID)
        {
            ListOfAttendance newList = new ListOfAttendance();

            List<LateTicket> aLateList = newList.GetAttendanceList();
            
            foreach (LateTicket LateStudent in aLateList)
            {
                if (studentID == LateStudent.StudentInfo.ID && LateStudent.TimeArrived > 8.15)
                    LatenessAmount += 1;
            }
            
            return LatenessAmount;
        }
    }
}
