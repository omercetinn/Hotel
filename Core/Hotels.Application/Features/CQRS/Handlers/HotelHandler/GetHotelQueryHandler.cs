using Hotels.Application.Features.CQRS.Results.HotelResult;
using Hotels.Application.Interfaces;
using Hotels.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Handlers.HotelHandler
{
    public class GetHotelQueryHandler
    {
        private readonly IRepository<Hotel> _repository;

        public GetHotelQueryHandler(IRepository<Hotel> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetHotelQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetHotelQueryResult
            {
                HotelId = x.HotelId,
                HotelTypeId =x.HotelTypeId,
                CoverImageUrl =x.CoverImageUrl,
                BigImageUrl =x.BigImageUrl
            }).ToList();
        }
    }
}
