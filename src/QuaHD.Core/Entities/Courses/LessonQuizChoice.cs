using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Core.Entities.Courses
{
    public class LessonQuizChoice : Entity
    {
        public int LessonQuizId { get; set; }
        public virtual LessonQuiz LessonQuiz { get; set; }

        public string? Content { get; set; }

        public bool Answers { get; set; }
    }
}
