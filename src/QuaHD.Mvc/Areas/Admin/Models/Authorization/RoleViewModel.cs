namespace QuaHD.Mvc.Areas.Admin.Models.Authorization
{
    public class RoleViewModel
    {
        public RoleViewModel()
        {
            SearchModel = new RoleSearchModel();
            RoleModels = new Page<RoleModel>();
        }

        public RoleSearchModel SearchModel { get; set; }

        public Page<RoleModel> RoleModels { get; set; }
    }
}
