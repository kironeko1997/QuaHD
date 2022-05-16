using QuaHD.Core.Entities.Orders;
using QuaHD.Mvc.Areas.Admin.Models.Orders;

namespace QuaHD.Mvc.Areas.Admin.Factories.Orders
{
    public interface IOrderFactory
    {
        OrderViewModel PrepareOrderViewModel(OrderSearchModel searchModel);

        OrderModel PrepareOrderModel(Order? order);
    }
}
