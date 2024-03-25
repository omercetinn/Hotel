﻿using Hotels.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Results.RoomDescriptionResult
{
    public class GetRoomDescriptionByIdQueryResult
    {
        public int RoomDescriptionId { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public string Description { get; set; }
    }
}
