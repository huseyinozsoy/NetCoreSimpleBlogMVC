using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBlogService
    {
        Task<int> BlogCount();
        Task<List<Blog>> GetBlogsAsync();
        Task<Blog> GetBlogDetailAsync(int id);
    }
}