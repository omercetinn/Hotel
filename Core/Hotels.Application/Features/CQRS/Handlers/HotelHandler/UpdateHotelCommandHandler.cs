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
    public class UpdateHotelCommandHandler
    {
        private readonly IRepository<Hotel> _repository;

        public UpdateHotelCommandHandler(IRepository<Hotel> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateHotelCommand command)
        {
            var values = await _repository.GetByIdAsync(command.HotelId);
            values.CoverImageUrl = command.CoverImageUrl;
            values.BigImageUrl = command.BigImageUrl;
            values.HotelTypeId = command.HotelTypeId;
            await _repository.UpdateAsync(values);
        }
    }
}
