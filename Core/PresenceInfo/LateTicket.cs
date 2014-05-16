using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.PresenceInfo
{
    public class LateTicket
    {       
        public string ID { get; set; }
        public Date IssueDate { get; set; }
        public Student StudentInfo { get; set; }
        public double TimeArrived { get; set; }       

        public LateTicket(string ID)
        {
            this.ID = ID;
        }

        public LateTicket(string ID, string studentID)
        {
            this.ID = ID;
            StudentInfo = new Student(studentID);
        }  

        public LateTicket(string ID, int day, int month, int year, string studentID, string firstName, string lastName, double timeArrived)
        {
            this.ID = ID;
            IssueDate = new Date(day, month, year);
            StudentInfo = new Student(studentID, firstName, lastName);            
            TimeArrived = timeArrived;            
        }

        

              
    }
}
