namespace QuaHD.Mvc.Areas.Admin.Models.Authorization
{
    public class UserModel : Model
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PhoneNumber { get; set; }
    }
}
