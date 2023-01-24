using AutoMapper;
using Kaitos.Admin.Controllers.Repository;
using Kaitos.Models;
using Kaitos.Repository.Interface;
using Kaitos.Service.Interface;
using Kaitos.ViewModels.AboutUsVM;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace Kaitos.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutUsController : BaseRepositoryController<AboutUs, AboutUsUpdateVm, AboutUsCreateVm>
    {
        private readonly IImageUploaderService _service;
        private readonly IMapper _mapper;
        private readonly IAboutUsRepository _repository;
        public AboutUsController(IImageUploaderService service, IAboutUsRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _service = service;
            _mapper = mapper;
            _repository = repository;
        }

        public override async Task<IActionResult> Create(AboutUsCreateVm entity)
        {
            if (!ModelState.IsValid) return View(entity);
            if(entity.ImageFile == null) return View(entity);
            entity.Iamge = await _service.UploadImageAsync(entity.ImageFile);

            await _repository.CreateAsync(_mapper.Map<AboutUs>(entity));

            return RedirectToAction(nameof(Index));
        }
    }
}
