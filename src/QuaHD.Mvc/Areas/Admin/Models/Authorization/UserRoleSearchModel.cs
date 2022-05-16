namespace QuaHD.Mvc.Areas.Admin.Models.Authorization
{
    public class UserRoleSearchModel : SearchModel
    {
        public int? UserId { get; set; }

        public int? RoleId { get; set; }
    }
}
