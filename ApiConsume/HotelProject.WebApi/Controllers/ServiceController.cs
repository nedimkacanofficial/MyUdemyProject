using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
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
        public IActionResult AddService([FromBody] Service service)
        {
            this._serviceService.TInsert(service);
            return Ok(service);
        }
        [HttpPut]
        public IActionResult UpdateService([FromBody] Service service)
        {
            this._serviceService.TUpdate(service);
            return Ok(service);
        }
        [HttpDelete]
        public IActionResult DeleteService([FromRoute] int id)
        {
            var service = this._serviceService.TGetById(id);
            this._serviceService.TDelete(service);
            return Ok(service);
        }

    }
}
