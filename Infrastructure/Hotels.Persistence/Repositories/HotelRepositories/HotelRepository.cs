using Hotels.Application.Interfaces.HotelInterfaces;
using Hotels.Domain.Entities;
using Hotels.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Persistence.Repositories.HotelRepositories
{
    public class HotelRepository : IHotelRepository
    {
        private readonly HotelContext _context;

        public HotelRepository(HotelContext context)
        {
            _context = context;
        }

        public List<Hotel> GetHotelListWithHotelType()
        {
           var values = _context.Hotels.Include(x => x.HotelType).ToList();
            return values;
        }
    }
}
