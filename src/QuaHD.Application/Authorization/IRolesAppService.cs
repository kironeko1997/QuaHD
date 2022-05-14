using QuaHD.Application.Shared.Authorization;
using QuaHD.Core.Entities.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Authorization
{
    public interface IRolesAppService
    {
        List<Role> GetAll(GetAllRoleInput input);

        Role GetById(int id);

        void Insert(Role role);

        void Update(Role role);

        void Delete(Role role);
    }
}
