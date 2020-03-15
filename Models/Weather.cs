using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonApiDotNetCore.Models;

namespace customer_consumption_api.Models
{
    public class Weather : Identifiable<Guid>
    {
        [Attr]
        public string StationId { get; set; }
        [Attr]
        public string DataTypeId { get; set; }
        [Attr]
        public DateTime ReadDate { get; set; }
        [Attr]
        public int ReadHour { get; set; }
        [Attr]
        public DateTime ReadDateTime { get; set; }
        [Attr]
        public Decimal Value { get; set; }
        [Attr]
        public string Uom { get; set; }
        [Attr]
        public string AlphaValue { get; set; }
        [Attr]
        public string QualityCode { get; set; }
    }
}