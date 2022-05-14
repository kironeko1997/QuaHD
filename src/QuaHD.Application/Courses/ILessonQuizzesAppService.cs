using QuaHD.Application.Shared.Courses;
using QuaHD.Core.Entities.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Courses
{
    public interface ILessonQuizzesAppService
    {
        List<LessonQuiz> GetAll(GetAllLessonQuizInput input);

        LessonQuiz GetById(int id);

        void Insert(LessonQuiz lessonQuiz);

        void Update(LessonQuiz lessonQuiz);

        void Delete(LessonQuiz lessonQuiz);
    }
}
