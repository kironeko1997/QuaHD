using AutoMapper;
using QuaHD.Application.Authorization;
using QuaHD.Application.Shared.Authorization;
using QuaHD.Core.Entities.Authorization;
using QuaHD.Mvc.Areas.Admin.Models;
using QuaHD.Mvc.Areas.Admin.Models.Authorization;

namespace QuaHD.Mvc.Areas.Admin.Factories.Authorization
{
    public class PermissionFactory : IPermissionFactory
    {
        private readonly IPermissionsAppService _permissionsAppService;
        private readonly IMapper _mapper;

        public PermissionFactory(IPermissionsAppService permissionsAppService, IMapper mapper)
        {
            _permissionsAppService = permissionsAppService;
            _mapper = mapper;
        }

        public PermissionViewModel PreparePermissionViewModel(PermissionSearchModel searchModel)
        {
            var permissions = _permissionsAppService.GetAll(_mapper.Map<GetAllPermissionInput>(searchModel));

            return new PermissionViewModel
            {
                SearchModel = searchModel,
                PermissionModels = new Page<PermissionModel>(_mapper.Map<List<PermissionModel>>(permissions), searchModel)
            };
        }

        public PermissionModel PreparePermissionModel(Permission? permission)
        {
            var model = new PermissionModel();
            if (permission != null)
            {
                model = _mapper.Map<PermissionModel>(permission);
            }

            return model;
        }
    }
}
