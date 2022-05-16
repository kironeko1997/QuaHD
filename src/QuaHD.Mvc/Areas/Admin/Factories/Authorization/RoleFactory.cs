using AutoMapper;
using QuaHD.Application.Authorization;
using QuaHD.Application.Shared.Authorization;
using QuaHD.Core.Entities.Authorization;
using QuaHD.Mvc.Areas.Admin.Models;
using QuaHD.Mvc.Areas.Admin.Models.Authorization;

namespace QuaHD.Mvc.Areas.Admin.Factories.Authorization
{
    public class RoleFactory : IRoleFactory
    {
        private readonly IRolesAppService _rolesAppService;
        private readonly IMapper _mapper;

        public RoleFactory(IRolesAppService rolesAppService, IMapper mapper)
        {
            _rolesAppService = rolesAppService;
            _mapper = mapper;
        }

        public RoleViewModel PrepareRoleViewModel(RoleSearchModel searchModel)
        {
            var roles = _rolesAppService.GetAll(_mapper.Map<GetAllRoleInput>(searchModel));

            return new RoleViewModel
            {
                SearchModel = searchModel,
                RoleModels = new Page<RoleModel>(_mapper.Map<List<RoleModel>>(roles), searchModel)
            };
        }

        public RoleModel PrepareRoleModel(Role? role)
        {
            var model = new RoleModel();
            if (role != null)
            {
                model = _mapper.Map<RoleModel>(role);
            }

            return model;
        }
    }
}
