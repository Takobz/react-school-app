using Microsoft.AspNetCore.Mvc;
using SchoolApp.Services;

namespace SchoolApp.Controllers
{
    //Methods in here should be protected by Role Based Authentication
    //Certain people should only have the authority to create/delete subjects.
    [ApiController]
    [Route("controller")]
    public class SubjectsController : ControllerBase
    {
        private readonly ISchoolAppDatabaseService schoolAppDatabaseService;

        public SubjectsController(ISchoolAppDatabaseService schoolAppDatabaseService)
        {
            this.schoolAppDatabaseService = schoolAppDatabaseService;
        }

        [Route("create")]
        [HttpPost]
        public IActionResult CreateSubject(string name, string shortName, string description)
        {
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(shortName) || string.IsNullOrEmpty(description))
            {
                return BadRequest("name, short name or description of subject can't be null or empty");
            }

            //create schoolAppDatabaseService code to add subject.
            return Ok();
        }

    }
}