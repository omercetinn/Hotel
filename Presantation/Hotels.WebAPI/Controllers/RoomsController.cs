using Hotels.Application.Features.CQRS.Commands.RoomCommands;
using Hotels.Application.Features.CQRS.Handlers.RoomHandler;
using Hotels.Application.Features.CQRS.Queries.RoomQueries;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : Controller
    {
        private readonly GetRoomQueryHandler _getRoomQueryHandler;
        private readonly GetRoomByIdQueryHandler _getRoomByIdQueryHandler;
        private readonly CreateRoomCommandHandler _createRoomCommandHandler;
        private readonly UpdateRoomCommandHandler _updateRoomCommandHandler;
        private readonly RemoveRoomCommandHandler _removeRoomCommandHandler;

        public RoomsController(GetRoomQueryHandler getRoomQueryHandler, GetRoomByIdQueryHandler getRoomByIdQueryHandler, CreateRoomCommandHandler createRoomCommandHandler, UpdateRoomCommandHandler updateRoomCommandHandler, RemoveRoomCommandHandler removeRoomCommandHandler)
        {
            _getRoomQueryHandler = getRoomQueryHandler;
            _getRoomByIdQueryHandler = getRoomByIdQueryHandler;
            _createRoomCommandHandler = createRoomCommandHandler;
            _updateRoomCommandHandler = updateRoomCommandHandler;
            _removeRoomCommandHandler = removeRoomCommandHandler;
        }
        [HttpGet]
        public async Task<IActionResult> RoomList()
        {
            var values = await _getRoomQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoom(int id)
        {
            var value = await _getRoomByIdQueryHandler.Handle(new GetRoomByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateRoom(CreateRoomCommand command)
        {
            await _createRoomCommandHandler.Handle(command);
            return Ok("Hotel Type Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteRoom(RemoveRoomCommand id)
        {
            await _removeRoomCommandHandler.Handle(id);
            return Ok("Hotel Type Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateRoom(UpdateRoomCommand command)
        {
            await _updateRoomCommandHandler.Handle(command);
            return Ok("Hotel Type Güncellendi");
        }
    }
}
