using QuaHD.Core.Entities.Courses;
using QuaHD.Mvc.Areas.Admin.Models.Courses;

namespace QuaHD.Mvc.Areas.Admin.Factories.Courses
{
    public interface ICourseFactory
    {
        CourseViewModel PrepareCourseViewModel(CourseSearchModel searchModel);

        CourseModel PrepareCourseModel(Course? course);
    }
}
