using Microsoft.AspNetCore.Mvc;
using SchoolApp.Services;
using SchoolApp.Models;

namespace SchoolApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly ISchoolAppDatabaseService schoolAppDatabaseService;
        public PostsController(ISchoolAppDatabaseService schoolAppDatabaseService)
        {
            this.schoolAppDatabaseService = schoolAppDatabaseService;
        }

        [Route("create")]
        [HttpPost]
        public IActionResult CreatePost(string heading, string text, string subjectName, int instructorId)
        {
            if(string.IsNullOrEmpty(heading) || string.IsNullOrEmpty(text))
            {
                return BadRequest("Heading Or Body Of Post Can't Be Empty.");
            }

            var subject = schoolAppDatabaseService.GetSubjectByName(subjectName);
            if(subject == null)
            {
                return BadRequest($"Can't Find Subject with {subjectName}");
            }

            var postModel = new Post
            {
                SubjectID = subject.ID,
                InstructorID = instructorId,
                Info = text,
                Heading = heading
            };

            schoolAppDatabaseService.CreatePost(postModel);
            return Ok("Subject Created.");
        }
    }
}