using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.StudentInfo;

namespace Core.StudentInfo
{
    public class ResponsibleParty: Person
    {    
        public ResponsibleParty(string first, string last, string contactNumber, string street, string city)
        {            
            Name = new FullName(first, last);
            ContactNumber = new PhoneNumber(contactNumber);
            HomeAddress = new ResidentialAddress(street, city);
        }
       
        public ResponsibleParty(string first, string last, string mobileNumber, string homeNumber, string street, string city)
        {
            Name = new FullName(first, last);
            ContactNumber = new PhoneNumber(homeNumber, mobileNumber);
            HomeAddress = new ResidentialAddress(street, city);
        }
    }
}
