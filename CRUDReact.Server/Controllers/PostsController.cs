using CRUDReact.Server.Model;
using CRUDReact.Server.Services.Iterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDReact.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private IPostService postService;

        public PostsController(IPostService postService)
        {
            this.postService = postService;
        }


        [HttpPost]
        public PostModel Create(PostModel model)
        {
            return postService.Create(model);
        }
        [HttpPatch]
        public PostModel Update(PostModel model)
        {
            return postService.Update(model);

        }
        [HttpGet("{id}")]
        public PostModel Get(int id)
        {
            return postService.Get(id);
        }
        [HttpGet]
        public IEnumerable<PostModel> GetAll()
        {
           //return new List<PostModel>() { new PostModel(){ Id = 1, Header = "hardcode", };
            return postService.Get();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            postService.Delete(id);

            return RedirectToAction("Index");
        }

    }
}
