using QuaHD.Application.Shared.Authorization;
using QuaHD.Core.Entities.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Authorization
{
    public interface IUserRolesAppService
    {
        List<UserRole> GetAll(GetAllUserRoleInput input);

        UserRole GetById(int userId, int roleId);

        void Insert(UserRole userRole);

        void Insert(List<UserRole> userRoles);

        void Update(UserRole userRole);

        void Update(List<UserRole> userRoles);

        void Delete(UserRole userRole);

        void Delete(List<UserRole> userRoles);
    }
}
