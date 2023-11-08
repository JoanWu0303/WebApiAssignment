using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiAssignment.Models;

namespace WebApiAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetController : ControllerBase
    {
        [HttpGet("route/{lastName}/{firstName}")]
        public string GetRoute([FromRoute] string lastName, string firstName) {
            return string.Format("lastName:{0} , firstNmae:{1}", lastName, firstName);
        }

        [HttpGet("query")]
        public string GetQuery([FromQuery] string lastName, string firstName)
        {
            return string.Format("lastName:{0} , firstNmae:{1}", lastName, firstName);
        }

        [HttpGet("iAction")]
        public IActionResult GetIAction([FromQuery] string lastName, string firstName)
        {
            string name = lastName + "," + firstName;
            return Ok(name);

        }

        [HttpGet("iAction2")]
        public IActionResult GetIAction2([FromQuery] Person person)
        {
            return Ok(person.toString() + Environment.NewLine+ "Good try !!");
        }
        //HttpGet can not use [FromBody]
    }
}
