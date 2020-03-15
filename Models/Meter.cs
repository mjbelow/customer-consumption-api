using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonApiDotNetCore.Models;

namespace customer_consumption_api.Models
{
    public class Meter : Identifiable<string>
    {
        [Attr]
        public string MeterType { get; set; }
        [Attr]
        public string ServiceType { get; set; }
        [Attr]
        public string Region { get; set; }
        [Attr]
        public int IntervalLength { get; set; }
        [Attr]
        public string Channel1RawUom { get; set; }
        [Attr]
        public string Channel2RawUom { get; set; }
        [Attr]
        public string Channel3RawUom { get; set; }
        [Attr]
        public string Channel4RawUom { get; set; }
        [Attr]
        public string Channel5RawUom { get; set; }
        [Attr]
        public string Channel6RawUom { get; set; }
        [Attr]
        public string Channel7RawUom { get; set; }
        [Attr]
        public string Channel8RawUom { get; set; }
        [Attr]
        public string Channel1Multiplier { get; set; }
        [Attr]
        public string Channel2Multiplier { get; set; }
        [Attr]
        public string Channel3Multiplier { get; set; }
        [Attr]
        public string Channel4Multiplier { get; set; }
        [Attr]
        public string Channel5Multiplier { get; set; }
        [Attr]
        public string Channel6Multiplier { get; set; }
        [Attr]
        public string Channel7Multiplier { get; set; }
        [Attr]
        public string Channel8Multiplier { get; set; }
        [Attr]
        public string Channel1FinalUom { get; set; }
        [Attr]
        public string Channel2FinalUom { get; set; }
        [Attr]
        public string Channel3FinalUom { get; set; }
        [Attr]
        public string Channel4FinalUom { get; set; }
        [Attr]
        public string Channel5FinalUom { get; set; }
        [Attr]
        public string Channel6FinalUom { get; set; }
        [Attr]
        public string Channel7FinalUom { get; set; }
        [Attr]
        public string Channel8FinalUom { get; set; }
        [Attr]
        public string MeterCycle { get; set; }

        // 'Meters table' and 'Locations table' has many to many relationship.
        // We have a bridge table 'MeterLocations'.
        [HasMany]
        public ICollection<MeterLocation> MeterLocations { get; set; }
        [HasMany]
        public ICollection<MeterInterval> MeterIntervals { get; set; }
    }
}
