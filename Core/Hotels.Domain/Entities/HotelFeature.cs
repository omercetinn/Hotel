using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Domain.Entities
{
    public class HotelFeature
    {
        public int HotelFeatureId { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public int FeatureId { get; set; }
        public Feature Feature { get; set; }
        public bool Available { get; set; }
    }
}
