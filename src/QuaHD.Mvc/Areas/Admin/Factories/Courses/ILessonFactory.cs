using QuaHD.Core.Entities.Courses;
using QuaHD.Mvc.Areas.Admin.Models.Courses;

namespace QuaHD.Mvc.Areas.Admin.Factories.Courses
{
    public interface ILessonFactory
    {
        LessonViewModel PrepareLessonViewModel(LessonSearchModel searchModel);

        LessonModel PrepareLessonModel(Lesson? lesson);
    }
}
