using AutoMapper;
using QuaHD.Application.Authorization;
using QuaHD.Application.Shared.Authorization;
using QuaHD.Core.Entities.Authorization;
using QuaHD.Mvc.Areas.Admin.Models;
using QuaHD.Mvc.Areas.Admin.Models.Authorization;

namespace QuaHD.Mvc.Areas.Admin.Factories.Authorization
{
    public class UserFactory : IUserFactory
    {
        private readonly IUsersAppService _usersAppService;
        private readonly IMapper _mapper;

        public UserFactory(IUsersAppService usersAppService, IMapper mapper)
        {
            _usersAppService = usersAppService;
            _mapper = mapper;
        }

        public UserViewModel PrepareUserViewModel(UserSearchModel searchModel)
        {
            var users = _usersAppService.GetAll(_mapper.Map<GetAllUserInput>(searchModel));            

            return new UserViewModel
            {
                SearchModel = searchModel,
                UserModels = new Page<UserModel>(_mapper.Map<List<UserModel>>(users), searchModel)
            };
        }

        public UserModel PrepareUserModel(User? user)
        {
            var model = new UserModel();
            if(user != null)
            {
                model = _mapper.Map<UserModel>(user);
            }

            return model;
        }
    }
}
