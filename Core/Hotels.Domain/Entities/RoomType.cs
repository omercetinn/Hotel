using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Domain.Entities
{
    public class RoomType
    {
        public int RoomTypeId { get; set; }
        public string Name { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
