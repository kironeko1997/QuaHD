using QuaHD.Application.Shared.Orders;
using QuaHD.Core.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Orders
{
    public class OrdersAppService : IOrdersAppService
    {
        private readonly IRepository<Order> _orderRepository;

        public OrdersAppService(IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<Order> GetAll(GetAllOrderInput input)
        {
            var orders = _orderRepository.GetAll();

            if (!string.IsNullOrWhiteSpace(input.Filter))
            {
                orders = orders.Where(x => x.Code.ToLower().Trim().Contains(input.Filter.ToLower().Trim()));
            }

            if (input.Statuses != null && input.Statuses.Count > 0)
            {
                orders = orders.Where(x => input.Statuses.Contains(x.Status));
            }

            if (input.FromOrderDate.HasValue)
            {
                orders = orders.Where(x => x.OrderDate >= input.FromOrderDate);
            }

            if (input.ToOrderDate.HasValue)
            {
                orders = orders.Where(x => x.OrderDate <= input.ToOrderDate);
            }

            if (input.FromDeliveryDate.HasValue)
            {
                orders = orders.Where(x => x.DeliveryDate >= input.FromDeliveryDate);
            }

            if (input.ToDeliveryDate.HasValue)
            {
                orders = orders.Where(x => x.DeliveryDate <= input.ToDeliveryDate);
            }

            if (input.FromCompletedDate.HasValue)
            {
                orders = orders.Where(x => x.CompletedDate >= input.FromCompletedDate);
            }

            if (input.ToCompletedDate.HasValue)
            {
                orders = orders.Where(x => x.CompletedDate <= input.ToCompletedDate);
            }

            return orders.ToList();
        }

        public Order GetById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public void Insert(Order order)
        {
            _orderRepository.Insert(order);
        }

        public void Update(Order order)
        {
            _orderRepository.Update(order);
        }

        public void Delete(Order order)
        {
            _orderRepository.Delete(order);
        }
    }
}
