using QuaHD.Core.Entities.Authorization;
using QuaHD.Mvc.Areas.Admin.Models.Authorization;

namespace QuaHD.Mvc.Areas.Admin.Factories.Authorization
{
    public interface IPermissionFactory
    {
        PermissionViewModel PreparePermissionViewModel(PermissionSearchModel searchModel);

        PermissionModel PreparePermissionModel(Permission? permission);
    }
}
