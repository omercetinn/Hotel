using Hotels.Application.Features.CQRS.Commands.HotelCommands;
using Hotels.Application.Interfaces;
using Hotels.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Handlers.HotelHandler
{
    public class RemoveHotelCommandHandler
    {
        private readonly IRepository<Hotel> _repository;

        public RemoveHotelCommandHandler(IRepository<Hotel> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveHotelCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoteAsync(value);

        }
    }
}
