using Hotels.Application.Features.CQRS.Commands.RoomDescriptionCommands;
using Hotels.Application.Interfaces;
using Hotels.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Handlers.RoomDescriptionHandler
{
    public class RemoveRoomDescriptionCommandHandler
    {
        private readonly IRepository<RoomDescription> _repository;

        public RemoveRoomDescriptionCommandHandler(IRepository<RoomDescription> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveRoomDescriptionCommand command)
        {
            var value =await _repository.GetByIdAsync(command.Id);
            await _repository.RemoteAsync(value);
        }
    }
}
