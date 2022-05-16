namespace QuaHD.Mvc.Areas.Admin.Models.Authorization
{
    public class UserRoleViewModel
    {
        public UserRoleViewModel()
        {
            SearchModel = new UserRoleSearchModel();
            UserRoleModels = new Page<UserRoleModel>();
        }

        public UserRoleSearchModel SearchModel { get; set; }

        public Page<UserRoleModel> UserRoleModels { get; set; }
    }
}
