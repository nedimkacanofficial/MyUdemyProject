using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var staffList = this._subscribeService.TGetList();
            return Ok(staffList);
        }
        [HttpGet("{id}")]
        public IActionResult GetSubscribeById([FromRoute] int id)
        {
            var staff=this._subscribeService.TGetById(id);
            return Ok(staff);
        }
        [HttpPost]
        public IActionResult AddSubscribe([FromBody] Subscribe subscribe)
        {
            this._subscribeService.TInsert(subscribe);
            return Ok(subscribe);
        }
        [HttpPut]
        public IActionResult UpdateSubscribe([FromBody] Subscribe subscribe)
        {
            this._subscribeService.TUpdate(subscribe);
            return Ok(subscribe);
        }
        [HttpDelete]
        public IActionResult DeleteSubscribe([FromRoute] int id)
        {
            var subscribe = this._subscribeService.TGetById(id);
            this._subscribeService.TDelete(subscribe);
            return Ok(subscribe);
        }
    }
}
