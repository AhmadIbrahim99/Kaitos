using Kaitos.Data.DataBaseContext;
using Kaitos.Models;
using Kaitos.Repository.Base;
using Kaitos.Repository.Interface;

namespace Kaitos.Repository
{
    public class AboutUsRepository : BaseEntityRepository<AboutUs>, IAboutUsRepository
    {
        public AboutUsRepository(KatiosDbContext context) : base(context)
        {
        }
    }
}
