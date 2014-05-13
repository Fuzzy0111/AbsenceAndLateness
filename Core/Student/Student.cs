using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Student
    {
        public string ID;
        public FullName Name;
        public Address ResidentialAddress { get; set; }
        public ContactInfoPhone PhoneNumber {get; set; }

        public Student()
        {
            ID = "";
            Name.first = "";
            Name.last = "";
            ResidentialAddress.street = "";
            ResidentialAddress.city = "";
            PhoneNumber.home = "";
            PhoneNumber.mobile = "";
            PhoneNumber.responsibleParty = "";

        }
    }
}
