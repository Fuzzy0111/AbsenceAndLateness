using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    public class Person
    {
        public FullName Name { get; set; }
        public ResidentialAddress HomeAddress { get; set; }
        public PhoneNumber ContactNumber { get; set; }

        public Person()
        { }

        public Person(string firstName, string lastName, string street, string city)
        {
            Name = new FullName(firstName, lastName);
            HomeAddress = new ResidentialAddress(street, city);
            ContactNumber = new PhoneNumber();
        }
    }
}
