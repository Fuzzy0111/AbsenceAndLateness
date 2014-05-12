using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.PresenceInfo
{
    public class Absent
    {
        public Student student;
        public double timeArrived;
        private int numberOfAbsence;

        public Absent()
        {
            student.ID = "";
            timeArrived = 8.00;
            numberOfAbsence = 0;
        }
    }
}
