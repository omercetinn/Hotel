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
    public class GetHotelDescriptionCommandHandler
    {
        private readonly IRepository<HotelDescription> _repository;

        public GetHotelDescriptionCommandHandler(IRepository<HotelDescription> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetHotelDescriptionQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetHotelDescriptionQueryResult {  
                HotelId = x.HotelId,
                Description = x.Description,
                HotelDescriptionId = x.HotelDescriptionId,
            
            }).ToList();
        }
    }
}
