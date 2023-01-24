using AutoMapper;
using Kaitos.Admin.Controllers.Repository;
using Kaitos.Models;
using Kaitos.Repository.Base.Interface;
using Kaitos.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Kaitos.Areas.Admin.Controllers
{
    public class SettingController : BaseRepositoryController<Setting, Setting, Setting>
    {
        public SettingController(ISettingRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
