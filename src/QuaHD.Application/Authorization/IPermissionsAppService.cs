using QuaHD.Application.Shared.Authorization;
using QuaHD.Core.Entities.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Authorization
{
    public interface IPermissionsAppService
    {
        public List<Permission> GetAll(GetAllPermissionInput input);

        public Permission GetPermission(GetPermissionInput input);

        public void Insert(Permission permission);

        public void Insert(List<Permission> permissions);

        public void Update(Permission permission);

        public void Update(List<Permission> permissions);

        public void Delete(Permission permission);

        public void Delete(List<Permission> permissions);
    }
}
