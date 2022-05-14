using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Shared.Products
{
    public class GetAllProductInput : Input
    {
        public int? ProductTypeId { get; set; }

        public bool? CourseLink { get; set; }

        public int? CourseId { get; set; }

        public bool? IsPublished { get; set; }
    }
}
