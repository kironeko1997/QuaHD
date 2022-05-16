using AutoMapper;
using QuaHD.Application.Courses;
using QuaHD.Application.Shared.Courses;
using QuaHD.Core.Entities.Courses;
using QuaHD.Mvc.Areas.Admin.Models;
using QuaHD.Mvc.Areas.Admin.Models.Courses;

namespace QuaHD.Mvc.Areas.Admin.Factories.Courses
{
    public class CourseFactory : ICourseFactory
    {
        private readonly ICoursesAppService _coursesAppService;
        private readonly IMapper _mapper;

        public CourseFactory(ICoursesAppService coursesAppService, IMapper mapper)
        {
            _coursesAppService = coursesAppService;
            _mapper = mapper;
        }

        public CourseViewModel PrepareCourseViewModel(CourseSearchModel searchModel)
        {
            var courses = _coursesAppService.GetAll(_mapper.Map<GetAllCourseInput>(searchModel));

            return new CourseViewModel
            {
                SearchModel = searchModel,
                CourseModels = new Page<CourseModel>(_mapper.Map<List<CourseModel>>(courses), searchModel)
            };
        }

        public CourseModel PrepareCourseModel(Course? course)
        {
            var model = new CourseModel();
            if (course != null)
            {
                model = _mapper.Map<CourseModel>(course);
            }

            return model;
        }
    }
}
