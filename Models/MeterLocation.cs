using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace customer_consumption_api.Models
{
    public class MeterLocation
    {
        public string MeterId { get; set; }
        public string LocationId { get; set; }
        public DateTime ActiveDate { get; set; }
        public DateTime InactiveDate { get; set; }

        // 'Meters table' and 'Locations table' has many to many relationship.
        // We have a bridge table 'MeterLocations'.
        public Location Location { get; set; }
        public Meter Meter { get; set; }
    }
}
