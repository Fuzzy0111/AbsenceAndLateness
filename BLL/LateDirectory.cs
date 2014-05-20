using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.PresenceInfo;
using DAL.Mocking;
using System.ComponentModel.DataAnnotations;

namespace BLL
{
    public class LateDirectory
    {
        #region Properties

        private LateTicket LateStudent { get; set; }
        
        private double Time { get; set; }

        [Range(0,251)]
        private int LatenessAmount { get; set; }

        #endregion

        #region Constructor

        public LateDirectory(string ticketID)
        {
            LateStudent = new LateTicket(ticketID);
            Time = 8.00;
            LatenessAmount = 0;
        }

        #endregion 

        #region Public Methods

        public int CalculateLatenessAmountOfParticularStudent(string studentFirstName, string studentLastName)
        {
            Repository newList = new Repository();

            List<LateTicket> aLateList = newList.MockingDataSource();

            foreach (LateTicket LateStudent in aLateList)
            {
                if (LateStudent.StudentInfo.Name.First == studentFirstName && LateStudent.StudentInfo.Name.Last == studentLastName && LateStudent.TimeArrived > 8.15)
                    LatenessAmount += 1;
            }
            
            return LatenessAmount;
        }

        public int CalculateLatenessAmountOfParticularStudent(string studentID)
        {
            Repository newList = new Repository();

            List<LateTicket> aLateList = newList.MockingDataSource();

            foreach (LateTicket LateStudent in aLateList)
            {
                if (LateStudent.StudentInfo.ID == studentID)
                    LatenessAmount += 1;
            }

            return LatenessAmount;
        }

        public LateTicket RetrieveParticularTicketData(string ticketID)
        {
            Repository newList = new Repository();
            LateTicket tempTicket = new LateTicket(ticketID);
            List<LateTicket> RetrieveTicket = newList.MockingDataSource();
            foreach(LateTicket ticket in RetrieveTicket)
            {
                if (ticket.ID==ticketID)
                {
                    tempTicket = ticket;
                }
            }
            return tempTicket;
        }

        public List<LateTicket> RetrieveParticularDateInfo(int year, int month, int day)
        {
            List<LateTicket> ListOfADay = new List<LateTicket>();

            Repository newList = new Repository();

            List<LateTicket> aLateList = newList.MockingDataSource();

            foreach (LateTicket LateStudent in aLateList)
            {
                if (LateStudent.IssueDate.Day == day && LateStudent.IssueDate.Month == month && LateStudent.IssueDate.Year == year)
                    ListOfADay.Add(LateStudent);
            }

            return ListOfADay;
        }

        public List<LateTicket> GetAllTickets()
        {
            Repository newList = new Repository();

            List<LateTicket> allLateTickets = newList.MockingDataSource();

            return allLateTickets;
        }

        #endregion
    }
}
