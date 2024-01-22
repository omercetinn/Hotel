using Hotels.Application.Features.CQRS.Queries.HotelQueries;
using Hotels.Application.Features.CQRS.Queries.HotelTypeQueries;
using Hotels.Application.Features.CQRS.Results.HotelResult;
using Hotels.Application.Features.CQRS.Results.HotelTypeResult;
using Hotels.Application.Interfaces;
using Hotels.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Handlers.HotelTypeHandler
{
    public class GetHotelTypeByIdQueryHandler
    {
        private readonly IRepository<HotelType> _repository;

        public GetHotelTypeByIdQueryHandler(IRepository<HotelType> repository)
        {
            _repository = repository;
        }
        public async Task<GetHotelTypeByIdQueryResult> Handle(GetHotelTypeByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetHotelTypeByIdQueryResult
            {
                HotelTypeId = value.HotelTypeId,
                Name = value.Name
            };
        }
    }
}
