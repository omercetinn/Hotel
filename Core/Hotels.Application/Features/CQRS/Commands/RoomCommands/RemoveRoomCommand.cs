using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Commands.RoomCommands
{
    public class RemoveRoomCommand
    {
        public int Id { get; set; }

        public RemoveRoomCommand(int id)
        {
            Id = id;
        }
    }
}
