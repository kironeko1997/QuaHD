using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Core.Entities.Authorization
{
    public class Permission : Entity
    {
        public string Name { get; set; }

        public string NormalizedName { get; set; }

        public string? Entity { get; set; }

        public int? EntityId { get; set; }

        public int UserId { get; set; }

        public int RoleId { get; set; }
    }
}
