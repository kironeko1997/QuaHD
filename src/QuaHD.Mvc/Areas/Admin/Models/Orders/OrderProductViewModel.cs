namespace QuaHD.Mvc.Areas.Admin.Models.Orders
{
    public class OrderProductViewModel
    {
        public OrderProductViewModel()
        {
            SearchModel = new OrderProductSearchModel();
            OrderProductModels = new Page<OrderProductModel>();
        }

        public OrderProductSearchModel SearchModel { get; set; }

        public Page<OrderProductModel> OrderProductModels { get; set; }
    }
}
