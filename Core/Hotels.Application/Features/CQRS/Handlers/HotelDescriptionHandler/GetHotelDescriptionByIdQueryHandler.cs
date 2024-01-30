using Hotels.Application.Features.CQRS.Queries.HotelDescriptionQueries;
using Hotels.Application.Features.CQRS.Results.HotelDescriptionResult;
using Hotels.Application.Interfaces;
using Hotels.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Handlers.HotelDescriptionHandler
{
    public class GetHotelDescriptionByIdQueryHandler
    {
        private readonly IRepository<HotelDescription> _repository;

        public GetHotelDescriptionByIdQueryHandler(IRepository<HotelDescription> repository)
        {
            _repository = repository;
        }

        public async Task<GetHotelDescriptionByIdQueryResult> Handle(GetHotelDescriptionByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetHotelDescriptionByIdQueryResult
            {
                HotelDescriptionId = value.HotelDescriptionId,
                Description = value.Description,
                HotelId = value.HotelId
            };
        }
    }
}
