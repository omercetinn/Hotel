using Hotels.Application.Features.CQRS.Commands.HotelTypeCommands;
using Hotels.Application.Features.CQRS.Handlers.HotelTypeHandler;
using Hotels.Application.Features.CQRS.Queries.HotelTypeQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelTypes.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelTypesController : ControllerBase
    {
        private readonly GetHotelTypeQueryHandler _getHotelTypeQueryHandler;
        private readonly GetHotelTypeByIdQueryHandler _getHotelTypeByIdQueryHandler;
        private readonly CreateHotelTypeCommandHandler _createHotelTypeCommandHandler;
        private readonly UpdateHotelTypeCommandHandler _updateHotelTypeCommandHandler;
        private readonly RemoveHotelTypeCommandHandler _removeHotelTypeCommandHandler;

        public HotelTypesController(GetHotelTypeQueryHandler getHotelTypeQueryHandler, GetHotelTypeByIdQueryHandler getHotelTypeByIdQueryHandler, CreateHotelTypeCommandHandler createHotelTypeCommandHandler, UpdateHotelTypeCommandHandler updateHotelTypeCommandHandler, RemoveHotelTypeCommandHandler removeHotelTypeCommandHandler)
        {
            _getHotelTypeQueryHandler = getHotelTypeQueryHandler;
            _getHotelTypeByIdQueryHandler = getHotelTypeByIdQueryHandler;
            _createHotelTypeCommandHandler = createHotelTypeCommandHandler;
            _updateHotelTypeCommandHandler = updateHotelTypeCommandHandler;
            _removeHotelTypeCommandHandler = removeHotelTypeCommandHandler;
        }
        [HttpGet]
        public async Task<IActionResult> HotelTypeList()
        {
            var values = await _getHotelTypeQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHotelType(int id)
        {
            var value = await _getHotelTypeByIdQueryHandler.Handle(new GetHotelTypeByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateHotelType(CreateHotelTypeCommand command)
        {
            await _createHotelTypeCommandHandler.Handle(command);
            return Ok("Hotel Type Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteHotelType(RemoveHotelTypeCommand id)
        {
            await _removeHotelTypeCommandHandler.Handle(id);
            return Ok("Hotel Type Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateHotelType(UpdateHotelTypeCommand command)
        {
            await _updateHotelTypeCommandHandler.Handle(command);
            return Ok("Hotel Type Güncellendi");
        }
    }
}
