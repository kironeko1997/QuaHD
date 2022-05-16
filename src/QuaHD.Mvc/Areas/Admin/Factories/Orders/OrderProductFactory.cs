using AutoMapper;
using QuaHD.Application.Orders;
using QuaHD.Application.Shared.Orders;
using QuaHD.Core.Entities.Orders;
using QuaHD.Mvc.Areas.Admin.Models;
using QuaHD.Mvc.Areas.Admin.Models.Orders;

namespace QuaHD.Mvc.Areas.Admin.Factories.Orders
{
    public class OrderProductFactory : IOrderProductFactory
    {
        private readonly IOrderProductsAppService _orderProductsAppService;
        private readonly IMapper _mapper;

        public OrderProductFactory(IOrderProductsAppService orderProductsAppService, IMapper mapper)
        {
            _orderProductsAppService = orderProductsAppService;
            _mapper = mapper;
        }

        public OrderProductViewModel PrepareOrderProductViewModel(OrderProductSearchModel searchModel)
        {
            var orderProducts = _orderProductsAppService.GetAll(_mapper.Map<GetAllOrderProductInput>(searchModel));

            return new OrderProductViewModel
            {
                SearchModel = searchModel,
                OrderProductModels = new Page<OrderProductModel>(_mapper.Map<List<OrderProductModel>>(orderProducts), searchModel)
            };
        }

        public OrderProductModel PrepareOrderProductModel(OrderProduct? orderProduct)
        {
            var model = new OrderProductModel();
            if (orderProduct != null)
            {
                model = _mapper.Map<OrderProductModel>(orderProduct);
            }

            return model;
        }
    }
}
