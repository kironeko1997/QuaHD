namespace QuaHD.Mvc.Areas.Admin.Models.Authorization
{
    public class PermissionViewModel
    {
        public PermissionViewModel()
        {
            SearchModel = new PermissionSearchModel();
            PermissionModels = new Page<PermissionModel>();
        }

        public PermissionSearchModel SearchModel { get; set; }

        public Page<PermissionModel> PermissionModels { get; set; }
    }
}
