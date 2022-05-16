namespace QuaHD.Mvc.Areas.Admin.Models.Authorization
{
    public class UserViewModel 
    {
        public UserViewModel()
        {
            SearchModel = new UserSearchModel();
            UserModels = new Page<UserModel>();
        }

        public UserSearchModel SearchModel { get; set; }

        public Page<UserModel> UserModels { get; set; }
    }
}
