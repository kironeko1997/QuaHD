using QuaHD.Core.Entities.Authorization;
using QuaHD.Mvc.Areas.Admin.Models.Authorization;

namespace QuaHD.Mvc.Areas.Admin.Factories.Authorization
{
    public interface IUserFactory
    {
        UserViewModel PrepareUserViewModel(UserSearchModel searchModel);

        UserModel PrepareUserModel(User? user);
    }
}
