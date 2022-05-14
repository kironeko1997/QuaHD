using QuaHD.Application.Shared.Authorization;
using QuaHD.Core.Entities.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Authorization
{
    public class UserRolesAppService : IUserRolesAppService
    {
        private readonly IRepository<UserRole> _userRoleRepository;

        public UserRolesAppService(IRepository<UserRole> userRoleRepository)
        {
            _userRoleRepository = userRoleRepository;
        }

        public List<UserRole> GetAll(GetAllUserRoleInput input)
        {
            var userRoles = _userRoleRepository.GetAll();

            if (input.UserId.HasValue)
            {
                userRoles = userRoles.Where(x => x.UserId == input.UserId);
            }

            if (input.RoleId.HasValue)
            {
                userRoles = userRoles.Where(x => x.RoleId == input.RoleId);
            }

            return userRoles.ToList();
        }

        public UserRole GetById(int userId, int roleId)
        {
            return _userRoleRepository.GetAll().Where(x=> x.UserId == userId && x.RoleId == roleId).FirstOrDefault();
        }

        public void Insert(UserRole userRole)
        {
            _userRoleRepository.Insert(userRole);
        }

        public void Insert(List<UserRole> userRoles)
        {
            _userRoleRepository.Insert(userRoles);
        }

        public void Update(UserRole userRole)
        {
            _userRoleRepository.Update(userRole);
        }

        public void Update(List<UserRole> userRoles)
        {
            _userRoleRepository.Update(userRoles);
        }

        public void Delete(UserRole userRole)
        {
            _userRoleRepository.Delete(userRole);
        }

        public void Delete(List<UserRole> userRoles)
        {
            _userRoleRepository.Delete(userRoles);
        }
    }
}
