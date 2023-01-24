using AutoMapper;
using Kaitos.Admin.Controllers.Repository;
using Kaitos.Models;
using Kaitos.Repository.Base.Interface;
using Kaitos.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Kaitos.Areas.Admin.Controllers
{
    public class ServiceModelController : BaseRepositoryController<ServiceModel, ServiceModel, ServiceModel>
    {
        public ServiceModelController(IServiceModelRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
