using AutoMapper;
using Kaitos.Models;
using Kaitos.Repository.Base.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Kaitos.Controllers.Repository
{
    public class BaseRepositoryController<T, TUpdate, TCreate> : Controller where T : class, IBaseEntity, new()
    {
        private readonly IBaseEntityRepository<T> _repository;
        private readonly IMapper _mapper;
        public BaseRepositoryController(IBaseEntityRepository<T> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public virtual async Task<IActionResult> Index()
         => View(await _repository.GetAllAsync());

        [HttpGet]

        public virtual async Task<IActionResult> Update(int id)
            => View(await _repository.GetByIdAsync(id));
        
        [HttpPost]
        public virtual async Task<IActionResult> Update(TUpdate entity)
        {
            if (!ModelState.IsValid) return View(entity);

            await _repository.UpdateAsync(_mapper.Map<T>(entity));

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public virtual async Task<IActionResult> Create (TCreate entity)
        {
            if (!ModelState.IsValid) return View();

            await _repository.CreateAsync(_mapper.Map<T>(entity));

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public virtual async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
