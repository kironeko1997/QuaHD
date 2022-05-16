using QuaHD.Core.Entities.Courses;
using QuaHD.Mvc.Areas.Admin.Models.Courses;

namespace QuaHD.Mvc.Areas.Admin.Factories.Courses
{
    public interface ILessonQuizFactory
    {
        LessonQuizViewModel PrepareLessonQuizViewModel(LessonQuizSearchModel searchModel);

        LessonQuizModel PrepareLessonQuizModel(LessonQuiz? lessonQuiz);
    }
}
