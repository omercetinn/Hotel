using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Queries.HotelDescriptionQueries
{
    public class GetHotelDescriptionByIdQuery
    {
        public int Id { get; set; }

        public GetHotelDescriptionByIdQuery(int id)
        {
            Id = id;
        }
    }
}
