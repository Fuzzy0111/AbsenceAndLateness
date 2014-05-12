using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.PresenceInfo
{
    public class Presence
    {
        public Student student;
        public double timeArrived;

        public Presence()
        {
            student.ID = "";
            timeArrived = 8.00;
        }
    }
}
