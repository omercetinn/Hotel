﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Domain.Entities
{
    public class Pricing
    {
        public int PricingId { get; set; }
        public string Name { get; set; }
        public List<RoomPricing> RoomPricings { get; set; }
    }
}