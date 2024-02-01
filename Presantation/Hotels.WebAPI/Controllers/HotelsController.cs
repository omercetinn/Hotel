using Hotels.Application.Features.CQRS.Commands.HotelCommands;
using Hotels.Application.Features.CQRS.Handlers.HotelHandler;
using Hotels.Application.Features.CQRS.Queries.HotelQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly GetHotelQueryHandler _getHotelQueryHandler;
        private readonly GetHotelByIdQueryHandler _getHotelByIdQueryHandler;
        private readonly CreateHotelCommandHandler _createHotelCommandHandler;
        private readonly UpdateHotelCommandHandler _updateHotelCommandHandler;
        private readonly RemoveHotelCommandHandler _removeHotelCommandHandler;
        private readonly GetHotelWithHotelTypeQueryHandler _getHotelWithHotelTypeQueryHandler;      

        public HotelsController(GetHotelQueryHandler getHotelQueryHandler, GetHotelByIdQueryHandler getHotelByIdQueryHandler, CreateHotelCommandHandler createHotelCommandHandler, UpdateHotelCommandHandler updateHotelCommandHandler, RemoveHotelCommandHandler removeHotelCommandHandler, GetHotelWithHotelTypeQueryHandler getHotelWithHotelTypeQueryHandler)
        {
            _getHotelQueryHandler = getHotelQueryHandler;
            _getHotelByIdQueryHandler = getHotelByIdQueryHandler;
            _createHotelCommandHandler = createHotelCommandHandler;
            _updateHotelCommandHandler = updateHotelCommandHandler;
            _removeHotelCommandHandler = removeHotelCommandHandler;
            _getHotelWithHotelTypeQueryHandler = getHotelWithHotelTypeQueryHandler;
        }
        [HttpGet]
        public async Task<IActionResult> HotelList()
        {
            var values = await _getHotelQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHotel(int id)
        {
            var value = await _getHotelByIdQueryHandler.Handle(new GetHotelByIdQuery(id));
            return Ok(value);

        }
        [HttpPost]
        public async Task<IActionResult> CreateHotel(CreateHotelCommand command)
        {
            await _createHotelCommandHandler.Handle(command);
            return Ok("Hotel Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteHotel(int id)
        {
            await _removeHotelCommandHandler.Handle(new RemoveHotelCommand(id));
            return Ok("Hotel Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateHotel(UpdateHotelCommand command)
        {
            await _updateHotelCommandHandler.Handle(command);
            return Ok("Hotel Güncellendi");
        }
        [HttpGet("GetHotelWithHotelType")]
        public IActionResult GetHotelWithHotelType()
        {
            var values = _getHotelWithHotelTypeQueryHandler.Handle();
            return Ok(values);
        }
    }
}
