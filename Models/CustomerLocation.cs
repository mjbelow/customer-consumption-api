using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using JsonApiDotNetCore.Models;

namespace customer_consumption_api.Models
{
    public class CustomerLocation : Identifiable
    {
        [Attr]
        public string AccountLocationKey {get; set;}
        [Attr]
        public DateTime ServiceStart { get; set; }
        [Attr]
        public DateTime ServiceEnd { get; set; }

        // 'Customers table' and 'Locations table' has many to many relationship.
        // We have a bridge table 'CustomerLocations'.
        [HasOne]
        public Customer Customer { get; set; }
        public string CustomerId { get; set; }
        [HasOne]
        public Location Location { get; set; }
        public string LocationId { get; set; }
    }
}
