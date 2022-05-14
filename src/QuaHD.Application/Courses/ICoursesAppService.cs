using QuaHD.Application.Shared.Courses;
using QuaHD.Core.Entities.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Courses
{
    public interface ICoursesAppService
    {
        List<Course> GetAll(GetAllCourseInput input);

        Course GetById(int id);

        void Insert(Course course);

        void Update(Course course);

        void Delete(Course course);
    }
}
