using Hotels.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Results.HotelResult
{
    public class GetHotelWithHotelTypeQueryResult
    {
        public int HotelId { get; set; }
        public int HotelTypeId { get; set; }
        public string HotelTypeName { get; set; }
        public string CoverImageUrl { get; set; }
        public string BigImageUrl { get; set; }
        public List<HotelFeature> HotelFeatures { get; set; }
        public List<HotelDescription> HotelDescriptions { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
