using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using QuaHD.Application.Authorization;
using QuaHD.Core.Entities.Authorization;
using QuaHD.Mvc.Areas.Admin.Factories.Authorization;
using QuaHD.Mvc.Areas.Admin.Models.Authorization;

namespace QuaHD.Mvc.Areas.Admin.Controllers
{
    public class UsersController : AdminBase
    {
        private readonly IUserFactory _userFactory;
        private readonly IUsersAppService _usersAppService;
        private readonly IMapper _mapper;

        public UsersController(IUserFactory userFactory, IUsersAppService usersAppService, IMapper mapper)
        {
            _userFactory = userFactory;
            _usersAppService = usersAppService;
            _mapper = mapper;
        }

        public IActionResult Index(UserSearchModel searchModel)
        {
            var model = _userFactory.PrepareUserViewModel(searchModel);

            return View(model);
        }

        public IActionResult CreateOrUpdate(int id)
        {
            var user = _usersAppService.GetById(id);

            var model = _userFactory.PrepareUserModel(user);

            return View(model);
        }

        [HttpPost]
        public IActionResult CreateOrUpdate(UserModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<User>(model);

                if (model.Id == 0)
                {
                    _usersAppService.Insert(user);
                }
                else
                {
                    _usersAppService.Update(user);
                }
            }

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            var user = _usersAppService.GetById(id);

            var model = _userFactory.PrepareUserModel(user);

            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(UserModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<User>(model);
                _usersAppService.Delete(user);
            }

            return RedirectToAction("Index");
        }
    }
}
