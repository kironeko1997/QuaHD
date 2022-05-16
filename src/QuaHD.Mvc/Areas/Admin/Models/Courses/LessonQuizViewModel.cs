namespace QuaHD.Mvc.Areas.Admin.Models.Courses
{
    public class LessonQuizViewModel
    {
        public LessonQuizViewModel()
        {
            SearchModel = new LessonQuizSearchModel();
            LessonQuizModels = new Page<LessonQuizModel>();
        }

        public LessonQuizSearchModel SearchModel { get; set; }

        public Page<LessonQuizModel> LessonQuizModels { get; set; }
    }
}
