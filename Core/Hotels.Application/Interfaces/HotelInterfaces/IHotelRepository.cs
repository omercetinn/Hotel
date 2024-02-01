using Hotels.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Interfaces.HotelInterfaces
{
    public interface IHotelRepository
    {
        List<Hotel> GetHotelListWithHotelType();
    }
}
