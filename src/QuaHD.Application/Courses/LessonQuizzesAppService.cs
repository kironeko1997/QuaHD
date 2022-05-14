using QuaHD.Application.Shared.Courses;
using QuaHD.Core.Entities.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Courses
{
    public class LessonQuizzesAppService : ILessonQuizzesAppService
    {
        private readonly IRepository<LessonQuiz> _lessonQuizRepository;

        public LessonQuizzesAppService(IRepository<LessonQuiz> lessonQuizRepository)
        {
            _lessonQuizRepository = lessonQuizRepository;
        }

        public List<LessonQuiz> GetAll(GetAllLessonQuizInput input)
        {
            var lessonQuizzes = _lessonQuizRepository.GetAll();

            if (!string.IsNullOrWhiteSpace(input.Filter))
            {
                lessonQuizzes = lessonQuizzes.Where(x => x.Quiz.ToLower().Trim().Contains(input.Filter));
            }

            if (input.LessonId.HasValue)
            {
                lessonQuizzes = lessonQuizzes.Where(x=> x.LessonId == input.LessonId);
            }

            return lessonQuizzes.ToList();
        }

        public LessonQuiz GetById(int id)
        {
            return _lessonQuizRepository.GetById(id);
        }

        public void Insert(LessonQuiz lessonQuiz)
        {
            _lessonQuizRepository.Insert(lessonQuiz);
        }

        public void Update(LessonQuiz lessonQuiz)
        {
            _lessonQuizRepository.Update(lessonQuiz);
        }

        public void Delete(LessonQuiz lessonQuiz)
        {
            _lessonQuizRepository.Delete(lessonQuiz);
        }
    }
}
