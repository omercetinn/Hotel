using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Queries.RoomQueries
{
    internal class GetRoomByIdQuery
    {
        public int Id { get; set; }

        public GetRoomByIdQuery(int id)
        {
            Id = id;
        }
    }
}
