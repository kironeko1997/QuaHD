using QuaHD.Application.Shared.Orders;
using QuaHD.Core.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Orders
{
    public interface IOrdersAppService
    {
        List<Order> GetAll(GetAllOrderInput input);

        Order GetById(int id);

        void Insert(Order order);

        void Update(Order order);

        void Delete(Order order);
    }
}
