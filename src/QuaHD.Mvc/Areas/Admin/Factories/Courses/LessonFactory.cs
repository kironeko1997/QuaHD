using AutoMapper;
using QuaHD.Application.Courses;
using QuaHD.Application.Shared.Courses;
using QuaHD.Core.Entities.Courses;
using QuaHD.Mvc.Areas.Admin.Models;
using QuaHD.Mvc.Areas.Admin.Models.Courses;

namespace QuaHD.Mvc.Areas.Admin.Factories.Courses
{
    public class LessonFactory : ILessonFactory
    {
        private readonly ILessonsAppService _lessonsAppService;
        private readonly IMapper _mapper;

        public LessonFactory(ILessonsAppService lessonsAppService, IMapper mapper)
        {
            _lessonsAppService = lessonsAppService;
            _mapper = mapper;
        }

        public LessonViewModel PrepareLessonViewModel(LessonSearchModel searchModel)
        {
            var lessons = _lessonsAppService.GetAll(_mapper.Map<GetAllLessonInput>(searchModel));

            return new LessonViewModel
            {
                SearchModel = searchModel,
                LessonModels = new Page<LessonModel>(_mapper.Map<List<LessonModel>>(lessons), searchModel)
            };
        }

        public LessonModel PrepareLessonModel(Lesson? lesson)
        {
            var model = new LessonModel();
            if (lesson != null)
            {
                model = _mapper.Map<LessonModel>(lesson);
            }

            return model;
        }
    }
}
