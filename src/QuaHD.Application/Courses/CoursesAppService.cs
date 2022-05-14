using QuaHD.Application.Shared.Courses;
using QuaHD.Core.Entities.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Courses
{
    public class CoursesAppService : ICoursesAppService
    {
        private readonly IRepository<Course> _courseRepository;

        public CoursesAppService(IRepository<Course> courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public List<Course> GetAll(GetAllCourseInput input)
        {
            var courses = _courseRepository.GetAll();

            if (!string.IsNullOrWhiteSpace(input.Filter))
            {
                courses = courses.Where(x => x.Name.ToLower().Trim().Contains(input.Filter) || x.Description.ToLower().Trim().Contains(input.Filter));
            }

            return courses.ToList();
        }

        public Course GetById(int id)
        {
            return _courseRepository.GetById(id);
        }

        public void Insert(Course course)
        {
            _courseRepository.Insert(course);
        }

        public void Update(Course course)
        {
            _courseRepository.Update(course);
        }

        public void Delete(Course course)
        {
            _courseRepository.Delete(course);
        }
    }
}
