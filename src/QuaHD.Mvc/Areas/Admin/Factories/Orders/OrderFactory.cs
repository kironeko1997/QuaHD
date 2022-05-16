using AutoMapper;
using QuaHD.Application.Orders;
using QuaHD.Application.Shared.Orders;
using QuaHD.Core.Entities.Orders;
using QuaHD.Mvc.Areas.Admin.Models;
using QuaHD.Mvc.Areas.Admin.Models.Orders;

namespace QuaHD.Mvc.Areas.Admin.Factories.Orders
{
    public class OrderFactory : IOrderFactory
    {
        private readonly IOrdersAppService _ordersAppService;
        private readonly IMapper _mapper;

        public OrderFactory(IOrdersAppService ordersAppService, IMapper mapper)
        {
            _ordersAppService = ordersAppService;
            _mapper = mapper;
        }

        public OrderViewModel PrepareOrderViewModel(OrderSearchModel searchModel)
        {
            var orders = _ordersAppService.GetAll(_mapper.Map<GetAllOrderInput>(searchModel));

            return new OrderViewModel
            {
                SearchModel = searchModel,
                OrderModels = new Page<OrderModel>(_mapper.Map<List<OrderModel>>(orders), searchModel)
            };
        }

        public OrderModel PrepareOrderModel(Order? order)
        {
            var model = new OrderModel();
            if (order != null)
            {
                model = _mapper.Map<OrderModel>(order);
            }

            return model;
        }
    }
}
