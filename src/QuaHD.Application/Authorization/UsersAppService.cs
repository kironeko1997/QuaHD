using QuaHD.Application.Shared.Authorization;
using QuaHD.Core.Entities.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Authorization
{
    public class UsersAppService : IUsersAppService
    {
        private readonly IRepository<User> _userRepository;

        public UsersAppService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAll(GetAllUserInput input)
        {
            var users = _userRepository.GetAll();

            if (!string.IsNullOrWhiteSpace(input.Filter))
            {
                users = users.Where(x => x.UserName.ToLower().Trim().Contains(input.Filter) || x.Email.ToLower().ToLower().Contains(input.Filter));
            }

            return users.ToList();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void Insert(User user)
        {
            _userRepository.Insert(user);
        }

        public void Update(User user)
        {
            _userRepository.Update(user);
        }

        public void Delete(User user)
        {
            _userRepository.Delete(user);
        }
    }
}
