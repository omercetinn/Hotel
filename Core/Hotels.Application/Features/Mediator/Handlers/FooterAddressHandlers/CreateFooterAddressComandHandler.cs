using Hotels.Application.Features.Mediator.Commands.FeatureCommands;
using Hotels.Application.Features.Mediator.Commands.FooterAddressCommands;
using Hotels.Application.Interfaces;
using Hotels.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    internal class CreateFooterAddressComandHandler:IRequestHandler<CreateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;

        public CreateFooterAddressComandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new FooterAddress
            {
                Adress = request.Adress,
                Description = request.Description,
                Email = request.Email,
                Phone = request.Phone,
           
            });
        }
    }
}
