using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ContactInfoPhone
    {
        public string Home { get; set; }
        public string ResponsibleParty { get; set; }
        public string Mobile { get; set; }

        public ContactInfoPhone()
        {
            Home = " ";
            Mobile = " ";
            ResponsibleParty = " ";
        }
    }
}
