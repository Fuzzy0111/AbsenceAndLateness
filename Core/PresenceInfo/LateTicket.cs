namespace Core.PresenceInfo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LateTicket
    {      
        #region Constructor

        public LateTicket(string iD)
        {
            this.ID = iD;
        }

        public LateTicket(string iD, string studentID)
        {
            this.ID = iD;
            this.StudentInfo = new Student(studentID);
        }

        public LateTicket(string iD, int year, int month, int day, string studentID, string firstName, string lastName, double timeArrived)
        {
            this.ID = iD;
            this.IssueDate = new DateTime(year, month, day);
            this.StudentInfo = new Student(studentID, firstName, lastName);
            this.TimeArrived = timeArrived;
        }  

        #endregion

        #region Properties

        public string ID 
        { 
            get; 
            set; 
        }        
       
        public DateTime IssueDate 
        { 
            get; 
            set; 
        }

        public Student StudentInfo 
        { 
            get; 
            set; 
        }

        public double TimeArrived 
        { 
            get; 
            set; 
        }

        #endregion               
    }
}
