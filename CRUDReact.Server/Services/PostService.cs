using CRUDReact.Server.Data;
using CRUDReact.Server.Model;
using CRUDReact.Server.Services.Iterfaces;

namespace CRUDReact.Server.Services
{
    public class PostService : IPostService
    {
        private PostsDataContext _context;
        public PostService(PostsDataContext postsDataContext)
        {
            _context = postsDataContext;
        }
        public PostModel Create(PostModel model)
        {
            var lastPost = _context.Posts.LastOrDefault();
            int newId = lastPost is null ? 0 : lastPost.Id + 1;

            model.Id = newId;
            _context.Posts.Add(model);
            return model;
        }

        public void Delete(int id)
        {
            PostModel modelToDelete = _context.Posts.FirstOrDefault(x => x.Id == id);
            _context.Posts.Remove(modelToDelete);
        }

        public PostModel Get(int id)
        {
            return _context.Posts.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<PostModel> Get()
        {
            return _context.Posts;
        }

        public PostModel Update(PostModel model)
        {
            PostModel modelToUpdate = _context.Posts.FirstOrDefault(x => x.Id == model.Id);

            modelToUpdate.Header = model.Header;
            modelToUpdate.Text = model.Text;

            return modelToUpdate;
        }
    }
}
