using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.PresenceInfo
{
    public class LateTicket
    {
        public int ID { get; set; }
        public Date Today { get; set; }
        public Student StudentInfo { get; set; }
        public double TimeArrived { get; set; }
        public int LatenessAmount { get; set; }

        public LateTicket()
        {
            StudentInfo = new Student();
        }

        public LateTicket(int ID, int day, int month, int year, string firstName, string lastName, double timeArrived)
        {
            this.ID = ID;
            Today = new Date(day, month, year);
            StudentInfo = new Student(firstName, lastName);            
            TimeArrived = timeArrived;
            LatenessAmount = 1;
        }        
    }
}
