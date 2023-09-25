using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTypesHomework.Models
{
    public class AddressModel
    {
        public string StreetAddress { private get; set; }
        public string City { private get; set; }
        public string Region { private get; set; }
        public string Country { private get; set; }
        public string PostalCode { private get; set; }
        public string FullAddress { 
            get
            {
                return $"{ StreetAddress }, { City }, { Region }, { Country }, { PostalCode }";
            } 
        }

        public AddressModel(string streetAddress, string city, string region, string country, string postalCode)
        {
            StreetAddress = streetAddress ;
            City = city ;
            Region = region ;
            Country = country ;
            PostalCode = postalCode ;
        }

    }
}
