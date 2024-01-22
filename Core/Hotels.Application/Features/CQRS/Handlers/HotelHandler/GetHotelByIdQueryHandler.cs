using Hotels.Application.Features.CQRS.Queries.HotelQueries;
using Hotels.Application.Features.CQRS.Results.AboutResults;
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
    public class GetHotelByIdQueryHandler
    {
        private readonly IRepository<Hotel> _repository;

        public GetHotelByIdQueryHandler(IRepository<Hotel> repository)
        {
            _repository = repository;
        }

        public async Task<GetHotelByIdQueryResult> Handle(GetHotelByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetHotelByIdQueryResult
            {
                HotelId = value.HotelId,
                BigImageUrl = value.BigImageUrl,
                CoverImageUrl = value.CoverImageUrl,
                HotelTypeId = value.HotelTypeId
            };
        }

    }
}
