using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ResidentialAddress
    {
        #region Properties

        [StringLength(50)]
        public string Street { get; set; }

        [StringLength(25)]
        public string City { get; set; }

        #endregion

        #region Constructors

        public ResidentialAddress(string street, string city)
        {
            Street = street;
            City = city;
        }

        #endregion
    }
}
