using QuaHD.Application.Shared.Authorization;
using QuaHD.Core.Entities.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Authorization
{
    public class RolesAppService : IRolesAppService
    {
        private readonly IRepository<Role> _roleRepository;

        public RolesAppService(IRepository<Role> roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public List<Role> GetAll(GetAllRoleInput input)
        {
            var roles = _roleRepository.GetAll();

            if (!string.IsNullOrWhiteSpace(input.Filter))
            {
                roles = roles.Where(x => x.Name == input.Filter);
            }

            return roles.ToList();
        }

        public Role GetById(int id)
        {
            return _roleRepository.GetById(id);
        }

        public void Insert(Role role)
        {
            _roleRepository.Insert(role);
        }

        public void Update(Role role)
        {
            _roleRepository.Update(role);
        }

        public void Delete(Role role)
        {
            _roleRepository.Delete(role);
        }
    }
}
