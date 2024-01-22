using Hotels.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Commands.HotelCommands
{
    public class UpdateHotelCommand
    {
        public int HotelId { get; set; }
        public int HotelTypeId { get; set; }
        public HotelType HotelType { get; set; }
        public string CoverImageUrl { get; set; }
        public string BigImageUrl { get; set; }
    }
}
