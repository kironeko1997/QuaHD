using AutoMapper;
using QuaHD.Application.Courses;
using QuaHD.Application.Shared.Courses;
using QuaHD.Core.Entities.Courses;
using QuaHD.Mvc.Areas.Admin.Models;
using QuaHD.Mvc.Areas.Admin.Models.Courses;

namespace QuaHD.Mvc.Areas.Admin.Factories.Courses
{
    public class LessonQuizChoiceFactory : ILessonQuizChoiceFactory
    {
        private readonly ILessonQuizChoicesAppService _lessonQuizChoicesAppService;
        private readonly IMapper _mapper;

        public LessonQuizChoiceFactory(ILessonQuizChoicesAppService lessonQuizChoicesAppService, IMapper mapper)
        {
            _lessonQuizChoicesAppService = lessonQuizChoicesAppService;
            _mapper = mapper;
        }

        public LessonQuizChoiceViewModel PrepareLessonQuizChoiceViewModel(LessonQuizChoiceSearchModel searchModel)
        {
            var lessonQuizChoices = _lessonQuizChoicesAppService.GetAll(_mapper.Map<GetAllLessonQuizChoiceInput>(searchModel));

            return new LessonQuizChoiceViewModel
            {
                SearchModel = searchModel,
                LessonQuizChoiceModels = new Page<LessonQuizChoiceModel>(_mapper.Map<List<LessonQuizChoiceModel>>(lessonQuizChoices), searchModel)
            };
        }

        public LessonQuizChoiceModel PrepareLessonQuizChoiceModel(LessonQuizChoice? lessonQuizChoice)
        {
            var model = new LessonQuizChoiceModel();
            if (lessonQuizChoice != null)
            {
                model = _mapper.Map<LessonQuizChoiceModel>(lessonQuizChoice);
            }

            return model;
        }
    }
}
