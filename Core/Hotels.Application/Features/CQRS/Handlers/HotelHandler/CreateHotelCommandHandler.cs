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
    public class CreateHotelCommandHandler
    {
        private readonly IRepository<Hotel> _repository;

        public CreateHotelCommandHandler(IRepository<Hotel> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateHotelCommand command)
        {
            await _repository.CreateAsync(new Hotel
            {
                HotelTypeId = command.HotelTypeId,
                BigImageUrl = command.BigImageUrl,
                CoverImageUrl = command.CoverImageUrl
                
            });

        }
    }
}
