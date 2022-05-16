namespace QuaHD.Mvc.Areas.Admin.Models.Authorization
{
    public class PermissionModel : Model
    {
        public string Name { get; set; }

        public string NormalizedName { get; set; }

        public string? Entity { get; set; }

        public int? EntityId { get; set; }

        public int UserId { get; set; }

        public int RoleId { get; set; }
    }
}
