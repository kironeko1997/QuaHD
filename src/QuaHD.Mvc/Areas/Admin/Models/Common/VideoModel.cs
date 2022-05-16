namespace QuaHD.Mvc.Areas.Admin.Models.Common
{
    public class VideoModel : Model<Guid>
    {
        public string Url { get; set; }

        public string? Title { get; set; }
    }
}
