using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Core.Entities.Common
{
    public class Video : Entity<Guid>
    {
        public string Url { get; set; }

        public string? Title { get; set; }
    }
}
