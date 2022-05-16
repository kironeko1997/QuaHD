using QuaHD.Core.Entities.Authorization;
using QuaHD.Mvc.Areas.Admin.Models.Authorization;

namespace QuaHD.Mvc.Areas.Admin.Factories.Authorization
{
    public interface IRoleFactory
    {
        RoleViewModel PrepareRoleViewModel(RoleSearchModel searchModel);

        RoleModel PrepareRoleModel(Role? role);
    }
}
