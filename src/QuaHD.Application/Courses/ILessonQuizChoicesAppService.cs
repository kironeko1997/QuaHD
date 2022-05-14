using QuaHD.Application.Shared.Courses;
using QuaHD.Core.Entities.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Courses
{
    public interface ILessonQuizChoicesAppService
    {
        List<LessonQuizChoice> GetAll(GetAllLessonQuizChoiceInput input);

        LessonQuizChoice GetById(int id);

        void Insert(LessonQuizChoice lessonQuizChoice);

        void Update(LessonQuizChoice lessonQuizChoice);

        void Delete(LessonQuizChoice lessonQuizChoice);
    }
}
