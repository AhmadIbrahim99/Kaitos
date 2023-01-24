using Kaitos.Data.DataBaseContext;
using Kaitos.Models;
using Kaitos.Repository.Base;
using Kaitos.Repository.Interface;

namespace Kaitos.Repository
{
    public class ServiceModelRepository : BaseEntityRepository<ServiceModel>, IServiceModelRepository
    {
        public ServiceModelRepository(KatiosDbContext context) : base(context)
        {
        }
    }
}
