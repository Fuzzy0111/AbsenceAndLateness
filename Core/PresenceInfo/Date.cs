namespace Core.PresenceInfo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Date
    {
        public Date(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        public int Day 
        { 
            get; 
            set; 
        }

        public int Month 
        { 
            get; 
            set; 
        }

        public int Year 
        { 
            get; 
            set; 
        }        
    }
}
