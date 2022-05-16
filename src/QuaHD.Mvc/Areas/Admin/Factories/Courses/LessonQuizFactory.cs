using AutoMapper;
using QuaHD.Application.Courses;
using QuaHD.Application.Shared.Courses;
using QuaHD.Core.Entities.Courses;
using QuaHD.Mvc.Areas.Admin.Models.Courses;

namespace QuaHD.Mvc.Areas.Admin.Factories.Courses
{
    public class LessonQuizFactory : ILessonQuizFactory
    {
        private readonly ILessonQuizzesAppService _lessonQuizzesAppService;
        private readonly IMapper _mapper;

        public LessonQuizFactory(ILessonQuizzesAppService lessonQuizzesAppService, IMapper mapper)
        {
            _lessonQuizzesAppService = lessonQuizzesAppService;
            _mapper = mapper;
        }

        public LessonQuizViewModel PrepareLessonQuizViewModel(LessonQuizSearchModel searchModel)
        {
            var lessonQuizzes = _lessonQuizzesAppService.GetAll(_mapper.Map<GetAllLessonQuizInput>(searchModel));

            return new LessonQuizViewModel
            {
                SearchModel = searchModel,
                LessonQuizModels = new Models.Page<LessonQuizModel>(_mapper.Map<List<LessonQuizModel>>(lessonQuizzes), searchModel)
            };
        }

        public LessonQuizModel PrepareLessonQuizModel(LessonQuiz? lessonQuiz)
        {
            var model = new LessonQuizModel();
            if (lessonQuiz != null)
            {
                model = _mapper.Map<LessonQuizModel>(lessonQuiz);
            }

            return model;
        }
    }
}
