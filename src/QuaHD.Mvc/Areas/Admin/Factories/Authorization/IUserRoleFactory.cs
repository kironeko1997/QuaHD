using QuaHD.Core.Entities.Authorization;
using QuaHD.Mvc.Areas.Admin.Models.Authorization;

namespace QuaHD.Mvc.Areas.Admin.Factories.Authorization
{
    public interface IUserRoleFactory
    {
        UserRoleViewModel PrepareUserRoleViewModel(UserRoleSearchModel searchModel);

        UserRoleModel PrepareUserRoleModel(UserRole? userRole);
    }
}
