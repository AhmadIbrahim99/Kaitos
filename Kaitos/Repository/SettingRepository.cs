using Kaitos.Data.DataBaseContext;
using Kaitos.Models;
using Kaitos.Repository.Base;
using Kaitos.Repository.Interface;

namespace Kaitos.Repository
{
    public class SettingRepository : BaseEntityRepository<Setting>, ISettingRepository
    {
        public SettingRepository(KatiosDbContext context) : base(context)
        {
        }
    }
}
