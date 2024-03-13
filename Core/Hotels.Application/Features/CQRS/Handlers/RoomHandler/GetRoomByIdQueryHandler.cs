using Hotels.Application.Features.CQRS.Queries.HotelQueries;
using Hotels.Application.Features.CQRS.Queries.RoomQueries;
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
    public class GetRoomByIdQueryHandler
    {
        private readonly IRepository<Room> _repository;

        public GetRoomByIdQueryHandler(IRepository<Room> repository)
        {
            _repository = repository;
        }

        public async Task<GetRoomByIdQueryResult> Handle(GetRoomByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetRoomByIdQueryResult
            {
                HotelId = value.HotelId,
                BigImageUrl = value.BigImageUrl,
                CoverImageUrl = value.CoverImageUrl,
                EarlyEntry = value.EarlyEntry,
                FreeFruitBasket = value.FreeFruitBasket,              
                Name = value.Name,
                RoomTypeId = value.RoomTypeId,
                LeavingLate = value.LeavingLate
            };
        }
    }
}
