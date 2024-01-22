using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Results.HotelResult
{
    public class GetHotelByIdQueryResult
    {
        public int HotelId { get; set; }
        public int HotelTypeId { get; set; }
        public string CoverImageUrl { get; set; }
        public string BigImageUrl { get; set; }
    }
}
