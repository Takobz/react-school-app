using Microsoft.AspNetCore.Mvc;
using SchoolApp.Services;

namespace SchoolApp.Controllers 
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase 
    {
        private readonly ISchoolAppDatabaseService schoolAppDatabaseService;

        public StudentController(ISchoolAppDatabaseService schoolAppDatabase)
        {
            this.schoolAppDatabaseService = schoolAppDatabase;
        }

        [HttpPost]
        [Route("add")]
        public ActionResult AddStudent(string name, string surname, int? studentNumber)
        {
            if(string.IsNullOrEmpty(name))
            {
                return BadRequest("Insert name");
            }
            if(string.IsNullOrEmpty(surname))
            {
                return BadRequest("Insert name");
            }
            if(studentNumber == null)
            {
                return BadRequest("Insert name");
            }

            var studentModel = new SchoolApp.Models.Student
            {
                Name = name,
                Surname = surname,
                StudentNumber = (int)studentNumber
            };

            schoolAppDatabaseService.AddStudent(studentModel);

            return Ok("Student Created");
        }
    }
}