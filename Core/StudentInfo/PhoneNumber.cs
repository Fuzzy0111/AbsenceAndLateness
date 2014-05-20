using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class PhoneNumber
    {
        #region Properties

        [StringLength(12)]
        public string Home { get; set; }

        [StringLength(12)]
        public string Mobile { get; set; }

        [StringLength(12)]
        public string ContactNumber { get; set; }

        #endregion 


        #region Constructors

        public PhoneNumber()
        { }

        public PhoneNumber(string contactNumber)
        {
            ContactNumber = contactNumber;
        }

        public PhoneNumber(string home, string mobile)
        {
            Home = home;
            Mobile = mobile;
        }

        #endregion
    }
}
