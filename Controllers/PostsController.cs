using Microsoft.AspNetCore.Mvc;
using SchoolApp.Services;
using SchoolApp.Models;

namespace SchoolApp.Controllers
{
    public class PostsController : ControllerBase
    {
        private readonly ISchoolAppDatabaseService schoolAppDatabaseService;
        public PostsController(ISchoolAppDatabaseService schoolAppDatabaseService)
        {
            this.schoolAppDatabaseService = schoolAppDatabaseService;
        }

        [Route("api/posts/create")]
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
            return Ok("Post Created.");
        }

        [Route("api/posts/getPostById")]
        [HttpGet]
        public IActionResult GetPostById(int postId)
        {
            var post = schoolAppDatabaseService.GetPostById(postId);
            if(post == null)
            {
                return NotFound($"Post With Id {postId} doesn't exist");
            }

            return Ok(post);
        }

        [Route("api/posts/getPostsByInstructorId")]
        [HttpGet]
        public IActionResult GetPostByInstructorId(int instructorId)
        {
            var posts = schoolAppDatabaseService.GetPostsByInstructor(instructorId);
            if(posts == null || posts.Count == 0)
            {
                return NotFound($"Instructor Has No Post");
            }

            return Ok(posts);
        }

        [Route("api/posts/getPostsForSubject")]
        [HttpGet]
        public IActionResult GetPostsForSubject(int subjectId)
        {
            var posts = schoolAppDatabaseService.GetPostsForSubject(subjectId);

            if(posts == null || posts.Count == 0)
            {
                return NotFound($"No Posts For This Subject");
            }

            return Ok(posts);
        }
    }
}