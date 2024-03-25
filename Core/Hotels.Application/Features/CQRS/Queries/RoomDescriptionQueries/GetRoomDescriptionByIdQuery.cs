using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Queries.RoomDescriptionQueries
{
    public class GetRoomDescriptionByIdQuery
    {
        public int Id { get; set; }

        public GetRoomDescriptionByIdQuery(int id)
        {
            Id = id;
        }
    }
}
