using Hotels.Application.Features.CQRS.Commands.HotelCommands;
using Hotels.Application.Features.CQRS.Commands.RoomCommands;
using Hotels.Application.Interfaces;
using Hotels.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Handlers.RoomHandler
{
    public class RemoveRoomCommandHandler
    {
        private readonly IRepository<Room> _repository;

        public RemoveRoomCommandHandler(IRepository<Room> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveRoomCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoteAsync(value);

        }
    }
}
