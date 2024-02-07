using Hotels.Application.Features.CQRS.Handlers.AboutHandler;
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
    public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQuery, List<GetFooterAddressQueryResult>>
    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFooterAddressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=>new GetFooterAddressQueryResult
            {
                Adress = x.Adress,
                Description = x.Description,
                Email = x.Email,
                FooterAddressId = x.FooterAddressId,
                Phone = x.Phone
            }).ToList();
          
        }
     
    }
}
