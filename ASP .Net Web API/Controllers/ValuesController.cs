using ASP_.Net_Web_API.Dto;
using ASP_.Net_Web_API.Entities;
using ASP_.Net_Web_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_.Net_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IEmployee _employees;
        
        // api/values
        [HttpGet]
        [Route("get-all")]
        public IActionResult GetAll()
        {
            return Ok(_employees);
        }
        // api/values/1
        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            try
            {
                return Ok(_employees.GetById(Id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
            return Ok();
        }
        [HttpPost]
        public IActionResult CreatNewEmployee(CreateEmployee input)
        {
            _employees.CreatEmployee(input);
            return Ok();
        }

    }
}
