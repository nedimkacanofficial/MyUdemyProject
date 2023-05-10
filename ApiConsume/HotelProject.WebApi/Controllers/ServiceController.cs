using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var serviceList = this._serviceService.TGetList();
            return Ok(serviceList);
        }
        [HttpGet("{id}")]
        public IActionResult GetServiceById([FromRoute] int id)
        {
            var service=this._serviceService.TGetById(id);
            return Ok(service);
        }
        [HttpPost]
        public IActionResult AddService()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteService()
        {
            return Ok();
        }

    }
}
