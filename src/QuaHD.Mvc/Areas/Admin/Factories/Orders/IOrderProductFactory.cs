using QuaHD.Core.Entities.Orders;
using QuaHD.Mvc.Areas.Admin.Models.Orders;

namespace QuaHD.Mvc.Areas.Admin.Factories.Orders
{
    public interface IOrderProductFactory
    {
        OrderProductViewModel PrepareOrderProductViewModel(OrderProductSearchModel searchModel);

        OrderProductModel PrepareOrderProductModel(OrderProduct? orderProduct);
    }
}
