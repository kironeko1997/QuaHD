using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using QuaHD.Application.Courses;
using QuaHD.Core.Entities.Courses;
using QuaHD.Mvc.Areas.Admin.Factories.Courses;
using QuaHD.Mvc.Areas.Admin.Models.Courses;

namespace QuaHD.Mvc.Areas.Admin.Controllers
{
    public class CoursesController : AdminBase
    {
        private readonly ICourseFactory _courseFactory;
        private readonly ICoursesAppService _coursesAppService;
        private readonly IMapper _mapper;

        public CoursesController(ICourseFactory courseFactory, ICoursesAppService coursesAppService, IMapper mapper)
        {
            _courseFactory = courseFactory;
            _coursesAppService = coursesAppService;
            _mapper = mapper;
        }

        public IActionResult Index(CourseSearchModel searchModel)
        {
            var model = _courseFactory.PrepareCourseViewModel(searchModel);

            return View(model);
        }

        public IActionResult CreateOrUpdate(int id)
        {
            var course = _coursesAppService.GetById(id);

            var model = _courseFactory.PrepareCourseModel(course);

            return View(model);
        }

        [HttpPost]
        public IActionResult CreateOrUpdate(CourseModel model)
        {
            if (ModelState.IsValid)
            {
                var course = _mapper.Map<Course>(model);

                if (model.Id == 0)
                {
                    _coursesAppService.Insert(course);
                }
                else
                {
                    _coursesAppService.Update(course);
                }
            }

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            var course = _coursesAppService.GetById(id);

            var model = _courseFactory.PrepareCourseModel(course);

            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(CourseModel model)
        {
            if (ModelState.IsValid)
            {
                var course = _mapper.Map<Course>(model);
                _coursesAppService.Delete(course);
            }

            return RedirectToAction("Index");
        }
    }
}
