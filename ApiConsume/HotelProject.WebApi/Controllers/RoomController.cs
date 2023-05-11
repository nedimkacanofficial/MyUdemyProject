using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var roomList = this._roomService.TGetList();
            return Ok(roomList);
        }
        [HttpGet("{id}")]
        public IActionResult GetRoomById([FromRoute] int id)
        {
            var room = this._roomService.TGetById(id);
            return Ok(room);
        }
        [HttpPost]
        public IActionResult AddRoom([FromBody] Room room)
        {
            this._roomService.TInsert(room);
            return Ok(room);
        }
        [HttpPut]
        public IActionResult UpdateRoom([FromBody] Room room)
        {
            this._roomService.TUpdate(room);
            return Ok(room);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteRoom([FromRoute] int id)
        {
            var room = this._roomService.TGetById(id);
            this._roomService.TDelete(room);
            return Ok(room);
        }
    }
}
