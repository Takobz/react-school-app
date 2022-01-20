using Microsoft.AspNetCore.Mvc;
using SchoolApp.Services;

namespace SchoolApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InstructorController :ControllerBase
    {
        private readonly ISchoolAppDatabaseService schoolAppDatabaseService;

        public InstructorController(ISchoolAppDatabaseService schoolAppDatabaseService)
        {
            this.schoolAppDatabaseService = schoolAppDatabaseService;
        }

        [Route("add")]
        [HttpPost]
        public IActionResult AddInstructor(string name, string surname)
        {
            if(string.IsNullOrEmpty(name))
            {
                return BadRequest("Provide name");
            }
            if(string.IsNullOrEmpty(surname))
            {
                return BadRequest("Provide surname");
            }

            var instructorModel = new Models.Instructor 
            {
                Name = name,
                Surname = surname
            };
            schoolAppDatabaseService.AddInstructor(instructorModel);

            return Ok("Instructor created successfully");
        }

        [Route("get")]
        [HttpGet]
        public IActionResult GetInstructor(int? instructorId)
        {
            if(instructorId == null)
            {
                return BadRequest("Instructor has no id");
            }

            var instructorModel = schoolAppDatabaseService.GetInstructor(instructorId);
            if(instructorModel == null)
            {
                return BadRequest($"Can't find instructor");
            }

            return Ok(instructorModel);
        }
    }
}
