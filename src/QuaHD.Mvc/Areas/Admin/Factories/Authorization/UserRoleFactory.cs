using AutoMapper;
using QuaHD.Application.Authorization;
using QuaHD.Application.Shared.Authorization;
using QuaHD.Core.Entities.Authorization;
using QuaHD.Mvc.Areas.Admin.Models;
using QuaHD.Mvc.Areas.Admin.Models.Authorization;

namespace QuaHD.Mvc.Areas.Admin.Factories.Authorization
{
    public class UserRoleFactory : IUserRoleFactory
    {
        private readonly IUserRolesAppService _userRolesAppService;
        private readonly IMapper _mapper;

        public UserRoleFactory(IUserRolesAppService userRolesAppService, IMapper mapper)
        {
            _userRolesAppService = userRolesAppService;
            _mapper = mapper;
        }

        public UserRoleViewModel PrepareUserRoleViewModel(UserRoleSearchModel searchModel)
        {
            var userRoles = _userRolesAppService.GetAll(_mapper.Map<GetAllUserRoleInput>(searchModel));

            return new UserRoleViewModel
            {
                SearchModel = searchModel,
                UserRoleModels = new Page<UserRoleModel>(_mapper.Map<List<UserRoleModel>>(userRoles), searchModel)
            };
        }

        public UserRoleModel PrepareUserRoleModel (UserRole? userRole)
        {
            var model = new UserRoleModel();
            if (userRole != null)
            {
                model = _mapper.Map<UserRoleModel>(userRole);
            }

            return model;
        }
    }
}
