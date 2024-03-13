using Hotels.Application.Features.CQRS.Results.HotelResult;
using Hotels.Application.Features.CQRS.Results.RoomResult;
using Hotels.Application.Interfaces;
using Hotels.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Handlers.RoomHandler
{
    public class GetRoomQueryHandler
    {
        private readonly IRepository<Room> _repository;

        public GetRoomQueryHandler(IRepository<Room> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetRoomQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetRoomQueryResult
            {
                HotelId = x.HotelId,
                RoomTypeId = x.RoomTypeId,
                CoverImageUrl = x.CoverImageUrl,
                BigImageUrl = x.BigImageUrl,
                LeavingLate=x.LeavingLate,
                EarlyEntry=x.EarlyEntry,
                Name=x.Name,
                FreeFruitBasket=x.FreeFruitBasket,
            }).ToList();
        }
    }
}
