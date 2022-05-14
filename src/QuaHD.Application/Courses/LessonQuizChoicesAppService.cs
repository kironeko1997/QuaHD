using QuaHD.Application.Shared.Courses;
using QuaHD.Core.Entities.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Courses
{
    public class LessonQuizChoicesAppService : ILessonQuizChoicesAppService
    {
        private readonly IRepository<LessonQuizChoice> _lessonQuizChoiceRepository;

        public LessonQuizChoicesAppService(IRepository<LessonQuizChoice> lessonQuizChoiceRepository)
        {
            _lessonQuizChoiceRepository = lessonQuizChoiceRepository;
        }

        public List<LessonQuizChoice> GetAll(GetAllLessonQuizChoiceInput input)
        {
            var lessonQuizChoices = _lessonQuizChoiceRepository.GetAll();

            if (!string.IsNullOrWhiteSpace(input.Filter))
            {
                lessonQuizChoices = lessonQuizChoices.Where(x => x.Content.ToLower().Trim().Contains(input.Filter.ToLower().Trim()));
            }

            if (input.LessonQuizId.HasValue)
            {
                lessonQuizChoices = lessonQuizChoices.Where(x => x.LessonQuizId == input.LessonQuizId);
            }

            return lessonQuizChoices.ToList();
        }

        public LessonQuizChoice GetById(int id)
        {
            return _lessonQuizChoiceRepository.GetById(id);
        }

        public void Insert(LessonQuizChoice lessonQuizChoice)
        {
            _lessonQuizChoiceRepository.Insert(lessonQuizChoice);
        }

        public void Update(LessonQuizChoice lessonQuizChoice)
        {
            _lessonQuizChoiceRepository.Update(lessonQuizChoice);
        }

        public void Delete(LessonQuizChoice lessonQuizChoice)
        {
            _lessonQuizChoiceRepository.Delete(lessonQuizChoice);
        }
    }
}
