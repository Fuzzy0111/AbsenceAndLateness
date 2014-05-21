namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PhoneNumber
    {
        #region Constructors

        public PhoneNumber()
        {
        }

        public PhoneNumber(string contactNumber)
        {
            this.ContactNumber = contactNumber;
        }

        public PhoneNumber(string home, string mobile)
        {
            this.Home = home;
            this.Mobile = mobile;
        }

        #endregion

        #region Properties

        public string Home 
        { 
            get; 
            set; 
        }

        public string Mobile 
        { 
            get; 
            set; 
        }

        public string ContactNumber 
        { 
            get; 
            set; 
        }

        #endregion
    }
}
