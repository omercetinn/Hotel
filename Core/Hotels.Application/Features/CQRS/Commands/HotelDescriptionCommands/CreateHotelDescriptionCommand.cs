using Hotels.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Commands.HotelDescriptionCommands
{
    public class CreateHotelDescriptionCommand
    {     
        public int HotelId { get; set; }
        public string Description { get; set; }
    }
}
