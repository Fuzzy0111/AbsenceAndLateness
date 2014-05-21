namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Core.StudentInfo;    
    using Microsoft.Practices.EnterpriseLibrary.Common;
    using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

    public class Student : Person
    {
        #region Constructor

        public Student(string studentID)
        {
            this.ID = studentID;
        }

        public Student(string iD, string first, string last)
        {
            this.ID = iD;
            this.Name = new FullName(first, last);
        }

        public Student(string iD, string first, string last, string studentStreet, string studentCity, string responsiblePartyFirstName, string responsiblePartyLastName, string responsiblePartyMobileNumber, string responsiblePartyHomeAddressStreet, string responsiblePartyHomeAddressCity)
        {
            this.ID = iD;
            this.Name = new FullName(first, last);
            this.PersonResponsible = new ResponsibleParty(responsiblePartyFirstName, responsiblePartyLastName, responsiblePartyMobileNumber, responsiblePartyHomeAddressStreet, responsiblePartyHomeAddressCity);
            this.ContactNumber = new PhoneNumber();
        }

        #endregion

        #region Properties

        [StringLengthValidator(1, 3)]
        public string ID 
        { 
            get; 
            set; 
        }

        public ResponsibleParty PersonResponsible
        {
            get;
            set;
        }

        #endregion
    }
}
