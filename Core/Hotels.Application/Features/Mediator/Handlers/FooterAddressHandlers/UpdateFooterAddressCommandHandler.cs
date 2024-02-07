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
    public class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;

        public UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.FooterAddressId);
            value.Adress = request.Adress;
            value.Phone = request.Phone;
            value.Description = request.Description;
            value.Email = request.Email;
            await _repository.UpdateAsync(value);   
        }
    }
}
