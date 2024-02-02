using Hotels.Application.Features.Mediator.Results.FeatureResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeatureQuery:IRequest<List<GetFeatureQueryResult>>
    {

    }
}
