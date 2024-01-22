using Hotels.Application.Features.CQRS.Commands.HotelCommands;
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
    public class CreateHotelTypeCommandHandler
    {
        private readonly IRepository<HotelType> _repository;

        public CreateHotelTypeCommandHandler(IRepository<HotelType> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateHotelTypeCommand command)
        {
            await _repository.CreateAsync(new HotelType
            {
                Name =command.Name
            });
        }
    }
}
