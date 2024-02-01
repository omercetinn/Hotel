using Hotels.Application.Features.CQRS.Results.HotelResult;
using Hotels.Application.Interfaces;
using Hotels.Application.Interfaces.HotelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Handlers.HotelHandler
{
    public class GetHotelWithHotelTypeQueryHandler
    {
        private readonly IHotelRepository _hotelRepository;

        public GetHotelWithHotelTypeQueryHandler(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }
      
        public async Task<List<GetHotelWithHotelTypeQueryResult>> Handle()
        {
            var values =  _hotelRepository.GetHotelListWithHotelType();
            return values.Select(x => new GetHotelWithHotelTypeQueryResult
            {
                HotelId = x.HotelId,
                HotelTypeName = x.HotelType.Name,
                HotelTypeId = x.HotelTypeId,
                CoverImageUrl = x.CoverImageUrl,
                BigImageUrl = x.BigImageUrl
            }).ToList();
        }
    }
}
