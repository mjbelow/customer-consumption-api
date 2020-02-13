using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace customer_consumption_api.Models
{
    public class Location
    {
        public string Id { get; set; }
        public string LocationClass { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        // 'Customers table' and 'Locations table' has many to many relationship.
        // We have a bridge table 'CustomerLocations'.
        public ICollection<CustomerLocation> CustomerLocations { get; set; }

        // 'Meters table' and 'Locations table' has many to many relationship.
        // We have a bridge table 'MeterLocations'.
        public ICollection<MeterLocation> MeterLocations { get; set; }
    }
}
