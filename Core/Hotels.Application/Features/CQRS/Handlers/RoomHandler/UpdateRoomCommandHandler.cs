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
    public class UpdateRoomCommandHandler
    {
        private readonly IRepository<Room> _repository;

        public UpdateRoomCommandHandler(IRepository<Room> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateRoomCommand command)
        {
            var values = await _repository.GetByIdAsync(command.HotelId);
            values.CoverImageUrl = command.CoverImageUrl;
            values.BigImageUrl = command.BigImageUrl;
            values.RoomTypeId = command.RoomTypeId;
            values.HotelId = command.HotelId;
            values.FreeFruitBasket = command.FreeFruitBasket;
            values.EarlyEntry= command.EarlyEntry;
            values.Name = command.Name;
            values.LeavingLate= command.LeavingLate;
            await _repository.UpdateAsync(values);
        }
    }
}
