using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BlogService : IBlogService
    {
        private IBlogDAL _blogRepository;
        private IUnitOfWork _unitOfWork;
        public BlogService(IBlogDAL blogRepository, IUnitOfWork unitOfWork, BlogContext context)
        {
            _blogRepository = blogRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<int> BlogCount()
        {
            return await _blogRepository.GetBlogCount();
        }

        public async Task<List<Blog>> GetBlogsAsync()
        {
            return await _blogRepository.GetBlogsAsync();
        }
        public async Task<Blog> GetBlogDetailAsync(int id)
        {
            return await _blogRepository.GetBlogDetailAsync(id);
        }
    }
}