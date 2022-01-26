using Microsoft.AspNetCore.Mvc;
using SchoolApp.Services;

namespace SchoolApp.Controllers
{
    public class SubjectsController : ControllerBase
    {
        private readonly ISchoolAppDatabaseService schoolAppDatabaseService;

        public SubjectsController(ISchoolAppDatabaseService schoolAppDatabaseService)
        {
            this.schoolAppDatabaseService = schoolAppDatabaseService;
        }

        [Route("api/subjects/create")]
        [HttpPost]
        public IActionResult CreateSubject(string name, string shortName, string description)
        {
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(shortName) || string.IsNullOrEmpty(description))
            {
                return BadRequest("name, short name or description of subject can't be null or empty");
            }

            var subjectModel = new Models.Subject
            {
                Name = name,
                ShortName = shortName,
                Description = description
            };

            schoolAppDatabaseService.CreateSubject(subjectModel);
            return Ok();
        }

        [Route("api/subjects/getbyid")]
        [HttpGet]
        public IActionResult GetSubjectById(int? id)
        {
            if(id == null)
            {
                return BadRequest("Subject id can't be null");
            }

            var subject = schoolAppDatabaseService.GetSubjectById((int)id);
            if(subject == null)
            {
                return BadRequest("Couldn't find subject");
            }
            return Ok(subject);
        }

        [Route("api/subjects/getbyname")]
        [HttpGet]
        public IActionResult GetSubjectById(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                return BadRequest("Subject name can't be null");
            }

            var subject = schoolAppDatabaseService.GetSubjectByName(name);
            if(subject == null)
            {
                return BadRequest("Couldn't find subject");
            }
            return Ok(subject);
        }

        [Route("api/subjects/getall")]
        [HttpGet]
        public IActionResult GetSubjectAllSubjects()
        {
            var subjects = schoolAppDatabaseService.GetAllSubjects();
            if(subjects == null)
            {
                return BadRequest("No subjects were found");
            }
            
            return Ok(subjects);
        }
    }
}