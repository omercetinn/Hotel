using Hotels.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Results.RoomResult
{
    public class GetRoomQueryResult
    {
        public int RoomId { get; set; }
        public string Name { get; set; }
        public string CoverImageUrl { get; set; }
        public bool FreeFruitBasket { get; set; }
        public bool EarlyEntry { get; set; }
        public bool LeavingLate { get; set; }
        public string BigImageUrl { get; set; }
        public List<RoomFeature> RoomFeatures { get; set; }
        public List<RoomDescription> RoomDescriptions { get; set; }
        public int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }
}
