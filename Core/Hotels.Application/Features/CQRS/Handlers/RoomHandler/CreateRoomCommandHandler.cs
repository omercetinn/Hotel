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
    public class CreateRoomCommandHandler
    {
        private readonly IRepository<Room> _repository;

        public CreateRoomCommandHandler(IRepository<Room> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateRoomCommand command)
        {
            await _repository.CreateAsync(new Room
            {
                RoomTypeId = command.RoomTypeId,
                Name = command.Name,
                EarlyEntry = command.EarlyEntry,
                LeavingLate= command.LeavingLate,
                FreeFruitBasket = command.FreeFruitBasket,
                HotelId = command.HotelId,
                BigImageUrl = command.BigImageUrl,
                CoverImageUrl = command.CoverImageUrl

            });

        }
    }
}
