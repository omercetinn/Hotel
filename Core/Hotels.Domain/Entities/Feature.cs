using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Domain.Entities
{
    public class Feature
    {
        public int FeatureId { get; set; }
        public string Name { get; set; }
        public List<HotelFeature> HotelFeatures { get; set; }
        public List<RoomFeature> RoomFeatures { get; set; }
    }
}
