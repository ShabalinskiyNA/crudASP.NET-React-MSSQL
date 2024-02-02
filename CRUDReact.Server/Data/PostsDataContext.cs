using CRUDReact.Server.Model;

namespace CRUDReact.Server.Data
{
    public class PostsDataContext
    {
        public List<PostModel> Posts { get; set; }

        public PostsDataContext()
        {
            Posts = new List<PostModel>() { new PostModel() { Id = 0, Header = "Default", Text = "manera"} };
        }
    }
}
