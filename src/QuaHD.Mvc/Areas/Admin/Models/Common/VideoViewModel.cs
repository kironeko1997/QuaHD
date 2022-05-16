namespace QuaHD.Mvc.Areas.Admin.Models.Common
{
    public class VideoViewModel
    {
        public VideoViewModel()
        {
            SearchModel = new VideoSearchModel();
            VideoModels = new Page<VideoModel>();
        }

        public VideoSearchModel SearchModel { get; set; }

        public Page<VideoModel> VideoModels { get; set; }
    }
}