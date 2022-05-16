namespace QuaHD.Mvc.Areas.Admin.Models.Courses
{
    public class LessonViewModel
    {
        public LessonViewModel()
        {
            SearchModel = new LessonSearchModel();
            LessonModels = new Page<LessonModel>();
        }

        public LessonSearchModel SearchModel { get; set; }

        public Page<LessonModel> LessonModels { get; set; }
    }
}
