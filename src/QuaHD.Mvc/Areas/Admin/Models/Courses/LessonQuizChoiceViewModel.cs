namespace QuaHD.Mvc.Areas.Admin.Models.Courses
{
    public class LessonQuizChoiceViewModel
    {
        public LessonQuizChoiceViewModel()
        {
            SearchModel = new LessonQuizChoiceSearchModel();
            LessonQuizChoiceModels = new Page<LessonQuizChoiceModel>();
        }

        public LessonQuizChoiceSearchModel SearchModel { get; set; }

        public Page<LessonQuizChoiceModel> LessonQuizChoiceModels { get; set; }
    }
}
