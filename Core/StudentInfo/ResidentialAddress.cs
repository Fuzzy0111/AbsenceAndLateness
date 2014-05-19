﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ResidentialAddress
    {
        public string Street { get; set; }
        public string City { get; set; }

        public ResidentialAddress(string street, string city)
        {
            Street = street;
            City = city;
        }
    }
}