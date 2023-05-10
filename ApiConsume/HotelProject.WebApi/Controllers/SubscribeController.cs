using HotelProject.BusinessLayer.Abstract;
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
        public IActionResult AddSubscribe()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSubscribe()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSubscribe()
        {
            return Ok();
        }
    }
}
