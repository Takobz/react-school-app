using Microsoft.AspNetCore.Mvc;
using SchoolApp.Services;

namespace SchoolApp.Controllers
{
    public class InstructorController :ControllerBase
    {
        private readonly ISchoolAppDatabaseService schoolAppDatabaseService;

        public InstructorController(ISchoolAppDatabaseService schoolAppDatabaseService)
        {
            this.schoolAppDatabaseService = schoolAppDatabaseService;
        }

        [Route("api/instructor/add")]
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

        [Route("api/instructor/get")]
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

        [Route("api/instructor/getAll")]
        [HttpGet]
        public IActionResult GetAllInstructors()
        {
            var instructors = schoolAppDatabaseService.GetAllInstructors();
            if(instructors == null || instructors?.Count == 0)
            {
                return NotFound("No Instructors Found");
            }

            //PLEASE REMOVE SUB_ID IN DB.
            return Ok(instructors);
        }
    }
}
