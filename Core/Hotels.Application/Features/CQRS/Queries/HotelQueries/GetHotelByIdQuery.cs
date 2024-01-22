﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Queries.HotelQueries
{
    public class GetHotelByIdQuery
    {
        public int Id { get; set; }

        public GetHotelByIdQuery(int id)
        {
            this.Id = id;
        }
    }
}
