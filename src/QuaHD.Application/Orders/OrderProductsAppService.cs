using QuaHD.Application.Shared.Orders;
using QuaHD.Core.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Orders
{
    public class OrderProductsAppService : IOrderProductsAppService
    {
        private readonly IRepository<OrderProduct> _orderProductRepository;

        public OrderProductsAppService(IRepository<OrderProduct> orderProductRepository)
        {
            _orderProductRepository = orderProductRepository;
        }

        public List<OrderProduct> GetAll(GetAllOrderProductInput input)
        {
            var orderProducts = _orderProductRepository.GetAll();

            if (input.OrderId.HasValue)
            {
                orderProducts = orderProducts.Where(x => x.OrderId == input.OrderId);
            }

            if (input.ProductId.HasValue)
            {
                orderProducts = orderProducts.Where(x => x.ProductId == input.ProductId);
            }

            return orderProducts.ToList();
        }

        public OrderProduct GetById(int id)
        {
            return _orderProductRepository.GetById(id);
        }

        public void Insert(OrderProduct orderProduct)
        {
            _orderProductRepository.Insert(orderProduct);
        }

        public void Insert(List<OrderProduct> orderProducts)
        {
            _orderProductRepository.Insert(orderProducts);
        }

        public void Update(OrderProduct orderProduct)
        {
            _orderProductRepository.Update(orderProduct);
        }

        public void Update(List<OrderProduct> orderProducts)
        {
            _orderProductRepository.Update(orderProducts);
        }

        public void Delete(OrderProduct orderProduct)
        {
            _orderProductRepository.Delete(orderProduct);
        }

        public void Delete(List<OrderProduct> orderProducts)
        {
            _orderProductRepository.Delete(orderProducts);
        }
    }
}
