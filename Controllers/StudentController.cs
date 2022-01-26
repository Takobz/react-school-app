using Microsoft.AspNetCore.Mvc;
using SchoolApp.Services;

namespace SchoolApp.Controllers 
{
    public class StudentController : ControllerBase 
    {
        private readonly ISchoolAppDatabaseService schoolAppDatabaseService;

        public StudentController(ISchoolAppDatabaseService schoolAppDatabase)
        {
            this.schoolAppDatabaseService = schoolAppDatabase;
        }

        [HttpPost]
        [Route("api/student/add")]
        public ActionResult AddStudent(string name, string surname, int? studentNumber)
        {
            if(string.IsNullOrEmpty(name))
            {
                return BadRequest("Provide name");
            }
            if(string.IsNullOrEmpty(surname))
            {
                return BadRequest("Provide surname");
            }
            if(studentNumber == null)
            {
                return BadRequest("Provide student number");
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

        [HttpGet]
        [Route("api/student/get")]
        public IActionResult GetStudent(int? studentNumber)
        {
            if(studentNumber == null)
            {
                return BadRequest("Provide student number");
            }

            var student  = schoolAppDatabaseService.GetStudent(studentNumber);
            if(student == null)
            {
                return Ok($"Couldn't find student with student number: {studentNumber}");
            }

            return Ok(student);
        }
    }
}