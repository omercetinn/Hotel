using Hotels.Application.Features.CQRS.Results.AboutResults;
using Hotels.Application.Features.Mediator.Queries.FeatureQueries;
using Hotels.Application.Features.Mediator.Results.FeatureResults;
using Hotels.Application.Interfaces;
using Hotels.Domain.Entities;
using MediatR;


namespace Hotels.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class GetFeatureByIdQueryHandler : IRequestHandler<GetFeatureByIdQuery, GetFeatureByIdQueryResult>
    {
        private readonly IRepository<Feature> _repository;

        public GetFeatureByIdQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task<GetFeatureByIdQueryResult> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetFeatureByIdQueryResult
            {
               FeatureId= values.FeatureId,
               Name=values.Name
            };
        }
    }
}
