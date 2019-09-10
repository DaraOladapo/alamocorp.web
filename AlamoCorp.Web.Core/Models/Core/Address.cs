using System;
using System.Collections.Generic;
using System.Text;

namespace AlamoCorp.Web.Core.Models.Core
{
    public class Address
    {
        public string StreetName { get; set; }
        public string SecondStreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
    }
}
