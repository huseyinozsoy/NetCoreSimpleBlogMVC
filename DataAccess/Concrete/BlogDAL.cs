using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class BlogDAL:  Repository<Blog>, IBlogDAL
    {
        private BlogContext _context;
        public BlogDAL(BlogContext context): base(context)
        {
            _context=context;
        }

        public async Task<int> GetBlogCount()
        {
            return await _context.Blogs.CountAsync();
        }

        public async Task<List<Blog>> GetBlogsAsync()
        {
            return await _context.Blogs.Include(b => b.BlogCategories).ThenInclude(b => b.Category).ToListAsync();
        }
        public async Task<Blog> GetBlogDetailAsync(int id)
        {
            return await _context.Blogs.Where(b => b.Id == id).Include(b => b.BlogCategories).ThenInclude(b => b.Category).FirstOrDefaultAsync();
        }
    }
}