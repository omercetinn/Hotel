using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Commands.HotelDescriptionCommands
{
    public class RemoveHotelDescriptionCommand
    {
        public int Id { get; set; }

        public RemoveHotelDescriptionCommand(int id)
        {
            Id = id;
        }
    }
}
