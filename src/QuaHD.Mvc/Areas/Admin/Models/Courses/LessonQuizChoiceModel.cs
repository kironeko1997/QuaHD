namespace QuaHD.Mvc.Areas.Admin.Models.Courses
{
    public class LessonQuizChoiceModel : Model
    {
        public int LessonQuizId { get; set; }

        public string? Content { get; set; }

        public bool Answers { get; set; }
    }
}
