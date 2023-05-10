using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var testimonialList = this._testimonialService.TGetList();
            return Ok(testimonialList);
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonialById([FromRoute] int id)
        {
            var testimonial=this._testimonialService.TGetById(id);
            return Ok(testimonial);
        }
        [HttpPost]
        public IActionResult AddTestimonial()
        {
            return Ok();
        }
        [HttpPut] 
        public IActionResult UpdateTestimonial() 
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial()
        {
            return Ok();
        }
    }
}
