using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.PresenceInfo;
using DAL.Mocking;

namespace BLL
{
    public class LateDirectory
    {
        private LateTicket LateStudent { get; set; }
        private double Time { get; set; }
        private int LatenessAmount { get; set; }

        public LateDirectory(string ticketID)
        {
            LateStudent = new LateTicket(ticketID);
            Time = 8.00;
            LatenessAmount = 0;
        }

        public int CalculateLatenessAmount(string studentFirstName, string studentLastName)
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
    }
}
