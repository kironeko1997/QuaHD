using QuaHD.Application.Shared.Courses;
using QuaHD.Core.Entities.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Courses
{
    public class LessonsAppService : ILessonsAppService
    {
        private readonly IRepository<Lesson> _lessonRepository;

        public LessonsAppService(IRepository<Lesson> lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }

        public List<Lesson> GetAll(GetAllLessonInput input)
        {
            var lessons = _lessonRepository.GetAll();

            if (!string.IsNullOrWhiteSpace(input.Filter))
            {
                lessons = lessons.Where(x => x.Name.ToLower().Trim().Contains(input.Filter) || x.Description.ToLower().Trim().Contains(input.Filter));
            }

            if (input.CourseId.HasValue)
            {
                lessons = lessons.Where(x => x.CourseId == input.CourseId);
            }

            return lessons.ToList();
        }

        public Lesson GetById(int id)
        {
            return _lessonRepository.GetById(id);
        }

        public void Insert(Lesson lesson)
        {
            _lessonRepository.Insert(lesson);
        }

        public void Update(Lesson lesson)
        {
            _lessonRepository.Update(lesson);
        }

        public void Delete(Lesson lesson)
        {
            _lessonRepository.Delete(lesson);
        }
    }
}
