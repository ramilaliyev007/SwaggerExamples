using Microsoft.AspNetCore.Mvc;
using SwaggerExamples.DTO;
using SwaggerExamples.DTO.Examples;
using Swashbuckle.AspNetCore.Filters;

namespace SwaggerExamples.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {
        [HttpPut]
        public IActionResult CreateEmployee(CreateEmployeeRequest request)
        {
            // Do something

            return Ok();
        }
    }
}
