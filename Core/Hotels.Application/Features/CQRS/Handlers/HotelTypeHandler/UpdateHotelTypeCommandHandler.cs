using Hotels.Application.Features.CQRS.Commands.HotelCommands;
using Hotels.Application.Features.CQRS.Commands.HotelTypeCommands;
using Hotels.Application.Interfaces;
using Hotels.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Handlers.HotelTypeHandler
{
    public class UpdateHotelTypeCommandHandler
    {
        private readonly IRepository<HotelType> _repository;

        public UpdateHotelTypeCommandHandler(IRepository<HotelType> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateHotelTypeCommand command)
        {
            var values=await _repository.GetByIdAsync(command.HotelTypeId);
            command.Name = values.Name;
            await _repository.UpdateAsync(values);
        }
    }
}
