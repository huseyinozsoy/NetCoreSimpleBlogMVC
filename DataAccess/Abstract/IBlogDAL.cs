using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IBlogDAL: IRepository<Blog>
    {
         Task<List<Blog>> GetBlogsAsync();
         Task<int> GetBlogCount();
        Task<Blog> GetBlogDetailAsync(int id);
    }
}