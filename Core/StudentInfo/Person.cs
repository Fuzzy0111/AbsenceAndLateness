namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Person
    {
        #region Constructor

        public Person()
        { 
        }

        public Person(string firstName, string lastName, string street, string city)
        {
            this.Name = new FullName(firstName, lastName);
            this.HomeAddress = new ResidentialAddress(street, city);
            this.ContactNumber = new PhoneNumber();
        }

        #endregion

        #region Properties

        public FullName Name 
        { 
            get; 
            set; 
        }

        public ResidentialAddress HomeAddress 
        { 
            get; 
            set; 
        }

        public PhoneNumber ContactNumber 
        { 
            get; 
            set; 
        }

        #endregion
    }
}
