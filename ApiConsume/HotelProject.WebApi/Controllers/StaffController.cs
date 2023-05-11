using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var staffList = this._staffService.TGetList();
            return Ok(staffList);
        }
        [HttpGet("{id}")]
        public IActionResult GetStaffById([FromRoute] int id)
        {
            var staff = this._staffService.TGetById(id);
            return Ok(staff);
        }
        [HttpPost]
        public IActionResult AddStaff([FromBody] Staff staff)
        {
            this._staffService.TInsert(staff);
            return Ok(staff);
        }
        [HttpPut]
        public IActionResult UpdateStaff([FromBody] Staff staff)
        {
            this._staffService.TUpdate(staff);
            return Ok(staff);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStaff([FromRoute] int id)
        {
            var staff = this._staffService.TGetById(id);
            this._staffService.TDelete(staff);
            return Ok();
        }
    }
}
