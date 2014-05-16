using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class PhoneNumber
    {
        public string Home { get; set; }        
        public string Mobile { get; set; }
        public string ContactNumber { get; set; }

        public PhoneNumber()
        { }

        public PhoneNumber(string contactNumber)
        {
            ContactNumber = contactNumber;
        }

        public PhoneNumber(string home, string mobile)
        {
            Home = home;
            Mobile = mobile;            
        }
    }
}
