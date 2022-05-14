using QuaHD.Core.Entities.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Core.Entities.Products
{
    public class Product : Entity
    {
        public string? Name { get; set; }

        public string? Code { get; set; }

        public decimal Price { get; set; }

        public int ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; }

        public int? CourseId { get; set; }
        public virtual Course Course { get; set; }

        public string? Description { get; set; }

        public bool IsPublished { get; set; }
    }
}
