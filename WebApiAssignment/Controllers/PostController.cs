using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiAssignment.Models;

namespace WebApiAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {

        [HttpPost("class")]
        public Person postClass ([FromBody] Person person)
        {
            string lastN = person.lastName;
            string firstN=person.firstName;
            int age=person.age;
            string gender=person.gender;

            Person person1 = new Person();
            person1.lastName = lastN + "_hello";
            person1.firstName = firstN;
            person1.age = age + 20;
            person1.gender = gender + "!";

            return person1;
        }

        [HttpPost("iAction")]
        public IActionResult postIAction([FromBody] Person person)
        {
            try
            {
               // if (person.lastName == null) throw new Exception("lastName should not be null");
               // if (person.firstName == null) throw new Exception("firstName should not be null");
                if (person.age <=18) throw new Exception("age should older than 18");
               // if (person.gender == null) throw new Exception("gender should not be null");
               
                string lastN = person.lastName;
                string firstN = person.firstName;
                int age = person.age;
                string gender = person.gender;

                Person person1 = new Person();
                person1.lastName = lastN + "_hello";
                person1.firstName = firstN;
                person1.age = age + 20;
                person1.gender = gender + "!";

                return Ok(person1);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
