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
        public Name name;
        public Address address;
        public ContactInfoPhone contactInfoPhone;

        public Student()
        {
            ID = "";
            name.first = "";
            name.last = "";
            address.street = "";
            address.city = "";
            contactInfoPhone.home = "";
            contactInfoPhone.mobile = "";
            contactInfoPhone.responsibleParty = "";

        }
    }
}
