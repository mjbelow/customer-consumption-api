using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using JsonApiDotNetCore.Models;

namespace customer_consumption_api.Models
{
    public class Location : Identifiable<string>
    {
       // [Attr]
      //  public string Id { get; set; }
        [Attr]
        public string LocationClass { get; set; }
        [Attr]
        public string Address { get; set; }
        [Attr]
        public string City { get; set; }
        [Attr]
        public string State { get; set; }
        [Attr]
        public string PostalCode { get; set; }

        // 'Customers table' and 'Locations table' has many to many relationship.
        // We have a bridge table 'CustomerLocations'.
        [HasMany("Customer location")]
        public ICollection<CustomerLocation> CustomerLocations { get; set; }

        // 'Meters table' and 'Locations table' has many to many relationship.
        // We have a bridge table 'MeterLocations'.
         [HasMany("Meter location")]
        public ICollection<MeterLocation> MeterLocations { get; set; }
    }
}
