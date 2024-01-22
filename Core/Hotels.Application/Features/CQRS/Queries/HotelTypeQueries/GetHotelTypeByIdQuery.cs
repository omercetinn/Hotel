using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Queries.HotelTypeQueries
{
    public class GetHotelTypeByIdQuery
    {
        public int Id { get; set; }

        public GetHotelTypeByIdQuery(int id)
        {
            Id = id;
        }
    }
}
