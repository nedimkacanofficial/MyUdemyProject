using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
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
        public IActionResult AddTestimonial([FromBody] Testimonial testimonial)
        {
            this._testimonialService.TInsert(testimonial);
            return Ok(testimonial);
        }
        [HttpPut] 
        public IActionResult UpdateTestimonial([FromBody] Testimonial testimonial) 
        {
            this._testimonialService.TUpdate(testimonial);
            return Ok(testimonial);
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial([FromRoute] int id)
        {
            var testimonial = this._testimonialService.TGetById(id);
            this._testimonialService.TDelete(testimonial);
            return Ok(testimonial);
        }
    }
}
