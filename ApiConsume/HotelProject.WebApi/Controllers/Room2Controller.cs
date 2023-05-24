using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;
        public Room2Controller(IRoomService roomService,IMapper mapper)
        {
            this._roomService = roomService;
            this._mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var values = this._roomService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRoom([FromBody] RoomAddDto roomAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = this._mapper.Map<Room>(roomAddDto);
            this._roomService.TInsert(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom([FromBody] UpdateRoomDto updateRoomDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = this._mapper.Map<Room>(updateRoomDto);
            this._roomService.TUpdate(values);
            return Ok();
        }
    }
}
