using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private BlogContext _context;
        public UnitOfWork(BlogContext context)
        {
            _context = context;
        }
        public async void Commit()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}