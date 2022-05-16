using QuaHD.Core.Entities.Courses;
using QuaHD.Mvc.Areas.Admin.Models.Courses;

namespace QuaHD.Mvc.Areas.Admin.Factories.Courses
{
    public interface ILessonQuizChoiceFactory
    {
        LessonQuizChoiceViewModel PrepareLessonQuizChoiceViewModel(LessonQuizChoiceSearchModel searchModel);

        LessonQuizChoiceModel PrepareLessonQuizChoiceModel(LessonQuizChoice? lessonQuizChoice);
    }
}
