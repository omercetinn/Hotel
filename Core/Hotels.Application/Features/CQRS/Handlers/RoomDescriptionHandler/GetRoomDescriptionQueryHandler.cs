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
    public class GetRoomDescriptionQueryHandler
    {
        private readonly IRepository<RoomDescription> _repository;

        public GetRoomDescriptionQueryHandler(IRepository<RoomDescription> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetRoomDescriptionQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetRoomDescriptionQueryResult
            {
                RoomDescriptionId = x.RoomDescriptionId,
                RoomId = x.RoomId,
                Description = x.Description               
            
            }).ToList();
        }
    }
}
