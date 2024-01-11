using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Domain.Entities
{
    public class HotelType
    {
        public int HotelTypeId { get; set; }
        public string Name { get; set; }
        public List<Hotel> Hotels { get; set; }
    }
}
