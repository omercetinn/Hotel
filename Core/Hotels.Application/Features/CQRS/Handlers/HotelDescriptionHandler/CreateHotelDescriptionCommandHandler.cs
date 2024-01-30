using Hotels.Application.Features.CQRS.Commands.HotelCommands;
using Hotels.Application.Features.CQRS.Commands.HotelDescriptionCommands;
using Hotels.Application.Interfaces;
using Hotels.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Handlers.HotelDescriptionHandler
{
    public class CreateHotelDescriptionCommandHandler
    {
        private readonly IRepository<HotelDescription> _repository;

        public CreateHotelDescriptionCommandHandler(IRepository<HotelDescription> repository)
        {
            _repository = repository;
        }

        private async Task Handle(CreateHotelDescriptionCommand command)
        {
            await _repository.CreateAsync(new HotelDescription
            {
                HotelId=command.HotelId,
                Description=command.Description       

            });
            
        }
    }
}
