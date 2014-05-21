namespace Core.StudentInfo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Core.StudentInfo;

    public class ResponsibleParty: Person
    {
        #region Constructors

        public ResponsibleParty(string first, string last, string contactNumber, string street, string city)
        {            
            base.Name = new FullName(first, last);
            base.ContactNumber = new PhoneNumber(contactNumber);
            base.HomeAddress = new ResidentialAddress(street, city);
        }
       
        public ResponsibleParty(string first, string last, string mobileNumber, string homeNumber, string street, string city)
        {
            base.Name = new FullName(first, last);
            base.ContactNumber = new PhoneNumber(homeNumber, mobileNumber);
            base.HomeAddress = new ResidentialAddress(street, city);
        }

        #endregion
    }
}
