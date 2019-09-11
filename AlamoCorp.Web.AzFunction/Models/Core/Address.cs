﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AlamoCorp.Web.AzFunction.Models.Core
{
    public class Address
    {
       
        public long AddressID { get; set; }
        public string StreetName { get; set; }
        public string SecondStreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
    }
}
