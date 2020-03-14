using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonApiDotNetCore.Models;

namespace customer_consumption_api.Models
{
    public class MeterInterval : Identifiable<Guid>
    {
        //public Guid Id { get; set; }

        [Attr]
        public string ChannelId { get; set; }
        [Attr]
        public DateTime ReadDate { get; set; }
        [Attr]
        public int ReadHour { get; set; }
        [Attr]
        public int Read30Min { get; set; }
        [Attr]
        public int Read15Min { get; set; }
        [Attr]
        public int Read5Min { get; set; }
        [Attr]
        public DateTime ReadDateTime { get; set; }
        [Attr]
        public decimal ReadValue { get; set; }
        [Attr]
        public string Uom { get; set; }
        [HasOne]
        public Meter Meter { get; set; }
        public string MeterId { get; set; }
    }
}
