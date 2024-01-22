using Hotels.Application.Features.CQRS.Results.HotelTypeResult;
using Hotels.Application.Interfaces;
using Hotels.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Handlers.HotelTypeHandler
{
    public class GetHotelTypeQueryHandler
    {
        private readonly IRepository<HotelType> _repository;

        public GetHotelTypeQueryHandler(IRepository<HotelType> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetHotelTypeQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetHotelTypeQueryResult
            {
                HotelTypeId = x.HotelTypeId,
                Name = x.Name
            }).ToList();
        }
    }
}
