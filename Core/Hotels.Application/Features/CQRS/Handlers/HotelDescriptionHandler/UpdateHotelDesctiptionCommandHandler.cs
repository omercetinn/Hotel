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
    public class UpdateHotelDesctiptionCommandHandler
    {
        private readonly IRepository<HotelDescription> _repository;

        public UpdateHotelDesctiptionCommandHandler(IRepository<HotelDescription> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateHotelDescriptionCommand command)
        {
            var values = await _repository.GetByIdAsync(command.HotelDescriptionId);
            values.Description = command.Description;
            values.HotelId= command.HotelId;
            await _repository.UpdateAsync(values);
        }
    }
}
