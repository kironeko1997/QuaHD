using QuaHD.Application.Shared.Courses;
using QuaHD.Core.Entities.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Courses
{
    public interface ILessonsAppService
    {
        List<Lesson> GetAll(GetAllLessonInput input);

        Lesson GetById(int id);

        void Insert(Lesson lesson);

        void Update(Lesson lesson);

        void Delete(Lesson lesson);
    }
}
