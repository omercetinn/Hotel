using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Domain.Entities
{
    public class RoomPricing
    {
        public int RoomPricingId { get; set; }
        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int PricingId { get; set; }
        public Pricing Pricing { get; set; }
        public decimal Amount { get; set; }

    }
}
