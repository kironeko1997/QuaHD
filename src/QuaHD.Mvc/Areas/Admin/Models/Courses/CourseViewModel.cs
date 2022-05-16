namespace QuaHD.Mvc.Areas.Admin.Models.Courses
{
    public class CourseViewModel
    {
        public CourseViewModel()
        {
            SearchModel = new CourseSearchModel();
            CourseModels = new Page<CourseModel>();
        }

        public CourseSearchModel SearchModel { get; set; }

        public Page<CourseModel> CourseModels { get; set; }
    }
}
