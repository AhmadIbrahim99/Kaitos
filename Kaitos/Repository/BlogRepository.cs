using Kaitos.Data.DataBaseContext;
using Kaitos.Models;
using Kaitos.Repository.Base;
using Kaitos.Repository.Interface;

namespace Kaitos.Repository
{
    public class BlogRepository : BaseEntityRepository<Blog>, IBlogRepository
    {
        public BlogRepository(KatiosDbContext context) : base(context)
        {
        }
    }
}
