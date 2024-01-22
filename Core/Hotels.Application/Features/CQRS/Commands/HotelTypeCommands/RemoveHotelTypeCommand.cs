using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Commands.HotelTypeCommands
{
    public class RemoveHotelTypeCommand
    {
        public int Id { get; set; }

        public RemoveHotelTypeCommand(int id)
        {
            Id = id;
        }
    }
}
