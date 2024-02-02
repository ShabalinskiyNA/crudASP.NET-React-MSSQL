using CRUDReact.Server.Model;

namespace CRUDReact.Server.Services.Iterfaces
{
    public interface IPostService
    {
        PostModel Create(PostModel model);
        PostModel Update(PostModel model);
        PostModel Get(int id);
        IEnumerable<PostModel> Get();
        void Delete(int id);


    }
}
