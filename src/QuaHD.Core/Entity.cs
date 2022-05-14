using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Core
{
    public class Entity
    {
        public int Id { get; set; }
    }

    public class Entity<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
    }
}
