namespace QuaHD.Mvc.Areas.Admin.Models.Courses
{
    public class LessonModel : Model
    {
        public int CourseId { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? ShortDescription { get; set; }
    }
}
