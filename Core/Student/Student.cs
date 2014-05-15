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
        { }

        public Student(string first, string last)
        {
            ID = " ";
            Name = new FullName(first, last);
            ResidentialAddress = new Address();
            PhoneNumber = new ContactInfoPhone();
            
        }
    }
}
