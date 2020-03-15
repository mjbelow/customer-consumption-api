using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using JsonApiDotNetCore.Models;

namespace customer_consumption_api.Models
{
    public class MeterLocation : Identifiable
    {
        [Attr]
        public DateTime ActiveDate { get; set; }
        [Attr]
        public DateTime InactiveDate { get; set; }

        // 'Meters table' and 'Locations table' has many to many relationship.
        // We have a bridge table 'MeterLocations'.
        [HasOne]
        public Location Location { get; set; }  
        public string LocationId { get; set; }
        [HasOne]
        public Meter Meter { get; set; }
        public string MeterId { get; set; }
    }
}
