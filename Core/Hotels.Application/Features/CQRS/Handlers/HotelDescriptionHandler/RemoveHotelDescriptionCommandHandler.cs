using Hotels.Application.Features.CQRS.Commands.BannerCommands;
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
    public class RemoveHotelDescriptionCommandHandler
    {
        private readonly IRepository<HotelDescription> _repository;

        public RemoveHotelDescriptionCommandHandler(IRepository<HotelDescription> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveHotelDescriptionCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoteAsync(values);
        }
    }
}
