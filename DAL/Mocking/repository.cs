namespace DAL.Mocking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Core;
    using Core.PresenceInfo;    

    public class Repository
    {
        #region Mocking Data Source

        public List<LateTicket> MockingDataSource()
        {
            List<LateTicket> mockLateList = new List<LateTicket>();
            LateTicket lateStudent1 = new LateTicket("1", 2014, 5, 2, "20", "Jane", "Smith", 8.20);
            LateTicket lateStudent2 = new LateTicket("2", 2014, 5, 2, "10", "Alex", "Rich", 8.25);
            LateTicket lateStudent3 = new LateTicket("3", 2014, 5, 2, "5", "Rita", "Ram", 8.26);
            LateTicket lateStudent4 = new LateTicket("4", 2014, 5, 3, "20", "Jane", "Smith", 8.40);
            LateTicket lateStudent5 = new LateTicket("5", 2014, 5, 3, "12", "Emily", "Raxon", 8.45);
            LateTicket lateStudent6 = new LateTicket("6", 2014, 5, 4, "5", "Rita", "Ram", 8.17);
            LateTicket lateStudent7 = new LateTicket("7", 2014, 5, 5, "2", "Bibi", "Mohammed", 8.20);

            mockLateList.Add(lateStudent1);
            mockLateList.Add(lateStudent2);
            mockLateList.Add(lateStudent3);
            mockLateList.Add(lateStudent4);
            mockLateList.Add(lateStudent5);
            mockLateList.Add(lateStudent6);
            mockLateList.Add(lateStudent7);

            return mockLateList;
        }

        #endregion

        #region Public Methods 

        public List<LateTicket> WriteToDataSource(string ticketID, int year, int month, int day, string studentID, string studentFirstName, string studentLastName, double arrivalTime)
        {
            LateTicket lateStudent = new LateTicket(ticketID);
            lateStudent.IssueDate = new DateTime(year, month, day);
            lateStudent.StudentInfo = new Student(studentID, studentFirstName, studentLastName);
            lateStudent.TimeArrived = arrivalTime;
            lateStudent.ID = "8";

            List<LateTicket> mockLateList = this.MockingDataSource();

            mockLateList.Add(lateStudent);

            return mockLateList;
        }

        public List<LateTicket> DeleteData(string ticketID)
        {
            LateTicket tempTicket = new LateTicket(ticketID);
            List<LateTicket> mockLateList = this.MockingDataSource();
            foreach (LateTicket ticket in mockLateList)
            {                
                if (ticket.ID == ticketID)
                {                   
                    tempTicket = ticket;
                }                
            }

            mockLateList.Remove(tempTicket);
            return mockLateList;
        }        

        public List<LateTicket> EditData(string ticketID, string studentID, string studentFirstName, string studentLastName, double arrivalTimeToEdit)
        {
            List<LateTicket> mockLateList = this.MockingDataSource();
            foreach (LateTicket ticket in mockLateList)
            {
                if (ticket.ID == ticketID)
                {
                    ticket.TimeArrived = arrivalTimeToEdit;
                    ticket.StudentInfo.ID = studentID;
                    ticket.StudentInfo.Name = new FullName(studentFirstName, studentLastName);                                
                }
            }

            return mockLateList;
        }

        #endregion
    }
}
