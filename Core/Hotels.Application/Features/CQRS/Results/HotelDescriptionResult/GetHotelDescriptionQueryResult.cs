using Hotels.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Results.HotelDescriptionResult
{
    public class GetHotelDescriptionQueryResult
    {
        public int HotelDescriptionId { get; set; }
        public int HotelId { get; set; }
        public string Description { get; set; }
    }
}
