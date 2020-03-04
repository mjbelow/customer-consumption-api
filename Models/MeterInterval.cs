using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace customer_consumption_api.Models
{
    public class MeterInterval
    {
        public Guid Id { get; set; }
        public string MeterId { get; set; }
        public string ChannelId { get; set; }
        public DateTime ReadDate { get; set; }
        public int ReadHour { get; set; }
        public int Read30Min { get; set; }
        public int Read15Min { get; set; }
        public int Read5Min { get; set; }
        public DateTime ReadDateTime { get; set; }
        public decimal ReadValue { get; set; }
        public string Uom { get; set; }

        public Meter Meter { get; set; }
    }
}
