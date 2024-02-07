using Hotels.Application.Features.Mediator.Queries.FeatureQueries;
using Hotels.Application.Features.Mediator.Queries.FooterAdressQueries;
using Hotels.Application.Features.Mediator.Results.FeatureResults;
using Hotels.Application.Features.Mediator.Results.FooterAddressResults;
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
    public partial class GetFooterAddressByIdQueryHandler : IRequestHandler<GetFooterAddressByIdQuery, GetFooterAddresByIdQueryResult>
    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressByIdQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<GetFooterAddresByIdQueryResult> Handle(GetFooterAddressByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetFooterAddresByIdQueryResult
            {
                Adress= values.Adress,
                Description= values.Description,
                Email= values.Email,
                FooterAddressId= values.FooterAddressId,
                Phone = values.Phone
            };
        }
    }
}
