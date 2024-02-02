using Hotels.Application.Features.CQRS.Queries.AboutQueries;
using Hotels.Application.Features.CQRS.Results.AboutResults;
using Hotels.Application.Interfaces;
using Hotels.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Handlers.AboutHandler
{
    public class GetAboutByIdQuery
    {
        private readonly IRepository<About> _repository;

        public GetAboutByIdQuery(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task<GetAboutByIdQueryResult> Handle(Queries.AboutQueries.GetAboutByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetAboutByIdQueryResult
            {
                AboutId = values.AboutId,
                Description = values.Description,
                ImageUrl = values.ImageUrl,
                Title = values.Title
            };
        }
    }
}
