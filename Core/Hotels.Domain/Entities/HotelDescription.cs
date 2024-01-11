using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Domain.Entities
{
    public class HotelDescription
    {
        public int HotelDescriptionId { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel{ get; set; }
        public string Description{ get; set; }
    }
}
