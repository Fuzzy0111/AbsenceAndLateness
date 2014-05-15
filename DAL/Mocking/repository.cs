using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.PresenceInfo;
using Core;

namespace DAL.Mocking
{
    public class repository
    {

        public List<LateTicket> MockingDataSource()
        {
            List<LateTicket> mockLateList = new List<LateTicket>();
            LateTicket lateStudent1 = new LateTicket(2, 03, 2014, "Jane", "Smith", 8.20);
            LateTicket lateStudent2 = new LateTicket(2, 03, 2014, "Alex", "Rich", 8.25);
            LateTicket lateStudent3 = new LateTicket(2, 03, 2014, "Rita", "Ram", 8.26);
            LateTicket lateStudent4 = new LateTicket(3, 03, 2014, "Jane", "Smith", 8.40);
            LateTicket lateStudent5 = new LateTicket(3, 03, 2014, "Emily", "Raxon", 8.45);
            LateTicket lateStudent6 = new LateTicket(4, 03, 2014, "Rita", "Ram", 8.17);
            LateTicket lateStudent7 = new LateTicket(5, 03, 2014, "Bibi", "Mohammed", 8.20);

            mockLateList.Add(lateStudent1);
            mockLateList.Add(lateStudent2);
            mockLateList.Add(lateStudent3);
            mockLateList.Add(lateStudent4);
            mockLateList.Add(lateStudent5);
            mockLateList.Add(lateStudent6);
            mockLateList.Add(lateStudent7);

            return mockLateList;
        }


        public List<LateTicket> WriteToDataSource(int day, int month, int year, string studentFirstName, string studentLastName, double arrivalTime)
        {
            LateTicket lateStudent = new LateTicket();
            lateStudent.Today.Day = day;
            lateStudent.Today.Month = month;
            lateStudent.Today.Year = year;
            lateStudent.StudentInfo.Name.First = studentFirstName;
            lateStudent.StudentInfo.Name.Last = studentLastName;
            lateStudent.TimeArrived = arrivalTime;

            List<LateTicket> mockLateList = MockingDataSource();

            mockLateList.Add(lateStudent);

            return mockLateList;
        }

        public List<LateTicket> DeleteData(int ticketID)
        {            
            List<LateTicket> mockLateList = MockingDataSource();
            foreach(LateTicket ticket in mockLateList)
            {
                bool mustDelete = true;
                mustDelete = (ticket.ID == ticketID) ;
                if (mustDelete)
                {
                    mockLateList.Remove(ticket);
                }                
            }
            return mockLateList;
        }        

        public List<LateTicket> EditData(int ticketID, string firstNameToEdit, string lastNameToEdit, double arrivalTimeToEdit)
        {
            List<LateTicket> mockLateList = MockingDataSource();
            foreach(LateTicket ticket in mockLateList)
            {
                if (ticket.ID == ticketID)
                {
                    ticket.TimeArrived = arrivalTimeToEdit;
                    ticket.StudentInfo.Name.Last = lastNameToEdit;
                    ticket.StudentInfo.Name.First = firstNameToEdit;
                }
            }
            return mockLateList;
        }
    }
}
