using Hotels.Application.Features.CQRS.Commands.RoomDescriptionCommands;
using Hotels.Application.Features.CQRS.Handlers.RoomDescriptionHandler;
using Hotels.Application.Features.CQRS.Queries.RoomDescriptionQueries;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomDescriptionsController : Controller
    {
        private readonly GetRoomDescriptionQueryHandler _getRoomDescriptionQueryHandler;
        private readonly GetRoomDescriptionByIdQueryHandler _getRoomDescriptionByIdQueryHandler;
        private readonly CreateRoomDescriptionCommandHandler _createRoomDescriptionCommandHandler;
        private readonly UpdateRoomDescriptionCommandHandler _updateRoomDescriptionCommandHandler;
        private readonly RemoveRoomDescriptionCommandHandler _removeRoomDescriptionCommandHandler;

        public RoomDescriptionsController(GetRoomDescriptionQueryHandler getRoomDescriptionQueryHandler, GetRoomDescriptionByIdQueryHandler getRoomDescriptionByIdQueryHandler, CreateRoomDescriptionCommandHandler createRoomDescriptionCommandHandler, UpdateRoomDescriptionCommandHandler updateRoomDescriptionCommandHandler, RemoveRoomDescriptionCommandHandler removeRoomDescriptionCommandHandler)
        {
            _getRoomDescriptionQueryHandler = getRoomDescriptionQueryHandler;
            _getRoomDescriptionByIdQueryHandler = getRoomDescriptionByIdQueryHandler;
            _createRoomDescriptionCommandHandler = createRoomDescriptionCommandHandler;
            _updateRoomDescriptionCommandHandler = updateRoomDescriptionCommandHandler;
            _removeRoomDescriptionCommandHandler = removeRoomDescriptionCommandHandler;
        }
        [HttpGet]
        public async Task<IActionResult> RoomDescriptionList()
        {
            var values = await _getRoomDescriptionQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoomDescription(int id)
        {
            var value = await _getRoomDescriptionByIdQueryHandler.Handle(new GetRoomDescriptionByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateRoomDescription(CreateRoomDescriptionCommand command)
        {
            await _createRoomDescriptionCommandHandler.Handle(command);
            return Ok("Hotel Type Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteRoomDescription(RemoveRoomDescriptionCommand id)
        {
            await _removeRoomDescriptionCommandHandler.Handle(id);
            return Ok("Hotel Type Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateRoomDescription(UpdateRoomDescriptionCommand command)
        {
            await _updateRoomDescriptionCommandHandler.Handle(command);
            return Ok("Hotel Type Güncellendi");
        }
    }
}
