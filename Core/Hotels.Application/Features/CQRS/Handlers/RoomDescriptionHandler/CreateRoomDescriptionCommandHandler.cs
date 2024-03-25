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
    public class CreateRoomDescriptionCommandHandler
    {
        private readonly IRepository<RoomDescription> _repository;

        public CreateRoomDescriptionCommandHandler(IRepository<RoomDescription> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateRoomDescriptionCommand command)
        {
            await _repository.CreateAsync(new RoomDescription
            {
                Description = command.Description,
                RoomId = command.RoomId,
            });   
        }
    }
}
