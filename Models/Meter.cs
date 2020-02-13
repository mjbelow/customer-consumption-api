using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace customer_consumption_api.Models
{
    public class Meter
    {
        public string Id { get; set; }
        public string MeterType { get; set; }
        public string ServiceType { get; set; }
        public string Region { get; set; }
        public int IntervalLength { get; set; }
        public string Channel1RawUom { get; set; }
        public string Channel2RawUom { get; set; }
        public string Channel3RawUom { get; set; }
        public string Channel4RawUom { get; set; }
        public string Channel5RawUom { get; set; }
        public string Channel6RawUom { get; set; }
        public string Channel7RawUom { get; set; }
        public string Channel8RawUom { get; set; }
        public string Channel1Multiplier { get; set; }
        public string Channel2Multiplier { get; set; }
        public string Channel3Multiplier { get; set; }
        public string Channel4Multiplier { get; set; }
        public string Channel5Multiplier { get; set; }
        public string Channel6Multiplier { get; set; }
        public string Channel7Multiplier { get; set; }
        public string Channel8Multiplier { get; set; }
        public string Channel1FinalUom { get; set; }
        public string Channel2FinalUom { get; set; }
        public string Channel3FinalUom { get; set; }
        public string Channel4FinalUom { get; set; }
        public string Channel5FinalUom { get; set; }
        public string Channel6FinalUom { get; set; }
        public string Channel7FinalUom { get; set; }
        public string Channel8FinalUom { get; set; }
        public string MeterCycle { get; set; }

        // 'Meters table' and 'Locations table' has many to many relationship.
        // We have a bridge table 'MeterLocations'.
        public ICollection<MeterLocation> MeterLocations { get; set; }
        public ICollection<MeterInterval> MeterIntervals { get; set; }
    }
}
