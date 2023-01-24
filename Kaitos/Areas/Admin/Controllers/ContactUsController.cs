using Kaitos.Models;
using Microsoft.AspNetCore.Mvc;
using Kaitos.Controllers.Repository;
using AutoMapper;
using Kaitos.ViewModels.ContactUsVM;
using Kaitos.Repository.Interface;

namespace Kaitos.Admin.Controllers
{
    [Area("Admin")]
    public class ContactUsController : BaseRepositoryController<ContactUs, ContactUsCreateVM, ContactUsCreateVM>
    {

        private readonly IContactUsRepository _repository;
        private readonly IMapper _mapper;
        public ContactUsController(IContactUsRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //[HttpPost]
        //public override async Task<IActionResult> Create(ContactUsCreateVM entity)
        //{
        //    if (!ModelState.IsValid) return Redirect("/Home");

        //    await _repository.CreateAsync(_mapper.Map<ContactUs>(entity));

        //    return Redirect("/Home");
        //}
    }
}
