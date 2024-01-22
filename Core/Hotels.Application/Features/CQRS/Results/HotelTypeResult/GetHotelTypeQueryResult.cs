using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Results.HotelTypeResult
{
    public class GetHotelTypeQueryResult
    {
        public int HotelTypeId { get; set; }
        public string Name { get; set; }
    }
}
