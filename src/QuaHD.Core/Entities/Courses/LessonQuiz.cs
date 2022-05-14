using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Core.Entities.Courses
{
    public class LessonQuiz : Entity
    {
        public int LessonId { get; set; }
        public virtual Lesson Lesson { get; set; }

        public string? Quiz { get; set; }
    }
}
