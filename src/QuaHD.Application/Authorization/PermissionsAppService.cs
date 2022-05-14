using QuaHD.Application.Shared.Authorization;
using QuaHD.Core.Entities.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Authorization
{
    public class PermissionsAppService : IPermissionsAppService
    {
        private readonly IRepository<Permission> _permissionRepository;

        public PermissionsAppService(IRepository<Permission> permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }

        public List<Permission> GetAll(GetAllPermissionInput input)
        {
            var permissions = _permissionRepository.GetAll();

            if (input.UserId.HasValue)
            {
                permissions = permissions.Where(x => x.UserId == input.UserId);
            }

            if (input.RoleId.HasValue)
            {
                permissions = permissions.Where(x => x.RoleId == input.RoleId);
            }

            return permissions.ToList();
        }

        public Permission GetPermission(GetPermissionInput input)
        {
            var permission = _permissionRepository.GetAll().FirstOrDefault(x => x.Name == input.Name && x.UserId == input.UserId && x.RoleId == input.RoleId && x.Entity == input.Entity && x.EntityId == input.EntityId);

            return permission;
        }

        public void Insert(Permission permission)
        {
            _permissionRepository.Insert(permission);
        }

        public void Insert(List<Permission> permissions)
        {
            _permissionRepository.Insert(permissions);
        }

        public void Update(Permission permission)
        {
            _permissionRepository.Update(permission);
        }

        public void Update(List<Permission> permissions)
        {
            _permissionRepository.Update(permissions);
        }

        public void Delete(Permission permission)
        {
            _permissionRepository.Delete(permission);
        }

        public void Delete(List<Permission> permissions)
        {
            _permissionRepository.Delete(permissions);
        }
    }
}
