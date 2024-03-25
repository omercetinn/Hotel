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
    public class UpdateRoomDescriptionCommandHandler
    {
        private readonly IRepository<RoomDescription> _repository;

        public UpdateRoomDescriptionCommandHandler(IRepository<RoomDescription> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateRoomDescriptionCommand command)
        {
            var values = await _repository.GetByIdAsync(command.RoomDescriptionId);
            values.Description = command.Description;
            values.RoomId = command.RoomId;
            await _repository.UpdateAsync(values);

        }
    }
}
