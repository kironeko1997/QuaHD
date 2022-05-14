
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Shared.Authorization
{
    public class GetPermissionInput
    {
        public string Name { get; set; }

        public int UserId { get; set; } 

        public int RoleId { get; set; }

        public string? Entity { get; set; }

        public int? EntityId { get; set; }
    }
}
