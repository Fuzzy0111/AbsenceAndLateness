namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ResidentialAddress
    {
        #region Constructors

        public ResidentialAddress(string street, string city)
        {
            this.Street = street;
            this.City = city;
        }

        #endregion

        #region Properties

        public string Street 
        { 
            get; 
            set; 
        }

        public string City 
        { 
            get; 
            set; 
        }

        #endregion
    }
}
