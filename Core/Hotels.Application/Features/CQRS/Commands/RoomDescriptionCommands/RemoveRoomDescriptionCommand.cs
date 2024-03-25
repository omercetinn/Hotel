using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Commands.RoomDescriptionCommands
{
    public class RemoveRoomDescriptionCommand
    {
        public int Id { get; set; }

        public RemoveRoomDescriptionCommand(int id)
        {
            Id = id;
        }
    }
}
