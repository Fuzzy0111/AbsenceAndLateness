namespace BLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Core;
    using Core.PresenceInfo;
    using DAL.Mocking;

    /// -----------------------------------------------------------------
    ///   Namespace:      <BLL>
    ///   Class:          <LateDirectory>
    ///   Description:    <Description>
    ///   Author:         <Author>                    Date: <DateTime>
    ///   Notes:          <=>
    ///   Revision History:
    ///   Name: Jaya          Date: 21/05/2014       Description: The Late directory
    /// -----------------------------------------------------------------
    public class LateDirectory
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="LateDirectory"/> class.
        /// </summary>
        /// <param name="ticketID">a ticketID</param>
        public LateDirectory(string ticketID)
        {
            this.Ticket = new LateTicket(ticketID);
            this.LatenessAmount = 0;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets: Ticket
        /// </summary>
        private LateTicket Ticket 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// Gets or sets: amount of lateness
        /// </summary>
        private int LatenessAmount 
        { 
            get; 
            set; 
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Calculate the amount of lateness for a particular student when given a student's first name and last name.
        /// </summary>
        /// <param name="studentFirstName">first name of a student</param>
        /// <param name="studentLastName">last name of the student</param>
        /// <returns>amount of lateness of a student</returns>
        public int CalculateLatenessAmountOfParticularStudent(string studentFirstName, string studentLastName)
        {
            Repository newList = new Repository();

            List<LateTicket> lateList = newList.MockingDataSource();

            foreach (LateTicket lateStudent in lateList)
            {
                if (lateStudent.StudentInfo.Name.First == studentFirstName && lateStudent.StudentInfo.Name.Last == studentLastName && lateStudent.TimeArrived > 8.15)
                {
                    this.LatenessAmount += 1;
                }
            }
            
            return this.LatenessAmount;
        }

        /// <summary>
        /// Calculate the amount of lateness for a particular student when given a student's iD.
        /// </summary>
        /// <param name="studentID">student iD</param>
        /// <returns>amount of lateness of that student</returns>
        public int CalculateLatenessAmountOfParticularStudent(string studentID)
        {
            Repository newList = new Repository();

            List<LateTicket> lateList = newList.MockingDataSource();

            foreach (LateTicket lateStudent in lateList)
            {
                if (lateStudent.StudentInfo.ID == studentID)
                {
                    this.LatenessAmount += 1;
                }
            }

            return this.LatenessAmount;
        }

        /// <summary>
        /// Returns the data of a particular Ticket when given the Ticket's iD.
        /// </summary>
        /// <param name="ticketID">Ticket iD</param>
        /// <returns>data of that particular Ticket</returns>
        public LateTicket RetrieveParticularTicketData(string ticketID)
        {
            Repository newList = new Repository();
            LateTicket tempTicket = new LateTicket(ticketID);
            List<LateTicket> retrieveTicket = newList.MockingDataSource();
            foreach (LateTicket ticket in retrieveTicket)
            {
                if (ticket.ID == ticketID)
                {
                    tempTicket = ticket;
                }
            }

            return tempTicket;
        }

        /// <summary>
        /// Returns all the lateness of a particular date given.
        /// </summary>
        /// <param name="year">the year's tickets we are looking for</param>
        /// <param name="month">the month's tickets we are looking for</param>
        /// <param name="day">the day's tickets we are looking for</param>
        /// <returns>info of all the tickets given on that day</returns>
        public List<LateTicket> RetrieveParticularDateInfo(int year, int month, int day)
        {
            List<LateTicket> listOfADay = new List<LateTicket>();

            Repository newList = new Repository();

            List<LateTicket> lateList = newList.MockingDataSource();

            foreach (LateTicket lateStudent in lateList)
            {
                if (lateStudent.IssueDate.Day == day && lateStudent.IssueDate.Month == month && lateStudent.IssueDate.Year == year)
                {
                    listOfADay.Add(lateStudent);
                }
            }

            return listOfADay;
        }

        /// <summary>
        /// returns all the lateness records from the beginning.
        /// </summary>
        /// <returns>all tickets</returns>
        public List<LateTicket> GetAllTickets()
        {
            Repository newList = new Repository();

            List<LateTicket> allLateTickets = newList.MockingDataSource();

            return allLateTickets;
        }

        #endregion
    }
}
