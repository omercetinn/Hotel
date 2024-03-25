using Hotels.Application.Features.CQRS.Queries.RoomDescriptionQueries;
using Hotels.Application.Features.CQRS.Results.HotelDescriptionResult;
using Hotels.Application.Features.CQRS.Results.RoomDescriptionResult;
using Hotels.Application.Interfaces;
using Hotels.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Handlers.RoomDescriptionHandler
{
    public class GetRoomDescriptionByIdQueryHandler
    {
        private readonly IRepository<RoomDescription> _repository;

        public GetRoomDescriptionByIdQueryHandler(IRepository<RoomDescription> repository)
        {
            _repository = repository;
        }

        public async Task<GetRoomDescriptionByIdQueryResult> Handle(GetRoomDescriptionByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetRoomDescriptionByIdQueryResult
            {
                Description=value.Description,
                RoomId=value.RoomId,                
            };
        }
        
    }
}
