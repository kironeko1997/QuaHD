using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Core.Entities.Courses
{
    public class Lesson : Entity
    {
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? ShortDescription { get; set; }
    }
}
