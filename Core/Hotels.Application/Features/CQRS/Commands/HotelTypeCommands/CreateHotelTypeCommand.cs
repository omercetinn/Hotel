using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Commands.HotelTypeCommands
{
    public class CreateHotelTypeCommand
    {     
        public string Name { get; set; }
    }
}
