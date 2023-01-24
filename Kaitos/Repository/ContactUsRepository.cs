using Kaitos.Data.DataBaseContext;
using Kaitos.Models;
using Kaitos.Repository.Base;
using Kaitos.Repository.Interface;

namespace Kaitos.Repository
{
    public class ContactUsRepository : BaseEntityRepository<ContactUs>, IContactUsRepository
    {
        public ContactUsRepository(KatiosDbContext context) : base(context)
        {
        }
    }
}
