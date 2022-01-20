using Microsoft.AspNetCore.Mvc;
using SchoolApp.Services;

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
        public IActionResult CreatePost()
        {
            //TODO: Finish post 
            return Ok();
        }

        //get posts.
        //get post.
    }
}