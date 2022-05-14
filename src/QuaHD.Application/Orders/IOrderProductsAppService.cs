using QuaHD.Application.Shared.Orders;
using QuaHD.Core.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Orders
{
    public interface IOrderProductsAppService
    {
        List<OrderProduct> GetAll(GetAllOrderProductInput input);

        OrderProduct GetById(int id);

        void Insert(OrderProduct orderProduct);

        void Insert(List<OrderProduct> orderProducts);

        void Update(OrderProduct orderProduct);

        void Update(List<OrderProduct> orderProducts);

        void Delete(OrderProduct orderProduct);

        void Delete(List<OrderProduct> orderProducts);
    }
}
