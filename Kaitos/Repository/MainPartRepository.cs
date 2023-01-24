using Kaitos.Data.DataBaseContext;
using Kaitos.Models;
using Kaitos.Repository.Base;
using Kaitos.Repository.Interface;

namespace Kaitos.Repository
{
    public class MainPartRepository : BaseEntityRepository<MainPart>, IMainPartRepository
    {
        public MainPartRepository(KatiosDbContext context) : base(context)
        {
        }
    }
}
