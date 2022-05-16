using QuaHD.Application.Shared.Authorization;
using QuaHD.Core.Entities.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Authorization
{
    public interface IUsersAppService
    {
        List<User> GetAll(GetAllUserInput input);

        User GetById(int id);

        void Insert(User user);

        void Update(User user);

        void Delete(User user);
    }
}
