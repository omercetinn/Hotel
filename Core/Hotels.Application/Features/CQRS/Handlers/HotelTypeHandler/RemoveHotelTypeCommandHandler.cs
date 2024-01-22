using Hotels.Application.Features.CQRS.Commands.HotelTypeCommands;
using Hotels.Application.Interfaces;
using Hotels.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Handlers.HotelTypeHandler
{
    public class RemoveHotelTypeCommandHandler
    {
        private readonly IRepository<HotelType> _repository;

        public RemoveHotelTypeCommandHandler(IRepository<HotelType> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveHotelTypeCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoteAsync(value);
        }
    }
}
