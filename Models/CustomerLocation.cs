using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace customer_consumption_api.Models
{
    public class CustomerLocation
    {
        [Key]
        public string CustomerId { get; set; }
        
        public string LocationId { get; set; }
        
        public string AccountLocationKey {get; set;}
        public DateTime ServiceStart { get; set; }
        public DateTime ServiceEnd { get; set; }

        // 'Customers table' and 'Locations table' has many to many relationship.
        // We have a bridge table 'CustomerLocations'.
        public Customer Customer { get; set; }
        public Location Location { get; set; }
    }
}
