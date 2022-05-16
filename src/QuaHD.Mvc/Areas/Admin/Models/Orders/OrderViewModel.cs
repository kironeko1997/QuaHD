namespace QuaHD.Mvc.Areas.Admin.Models.Orders
{
    public class OrderViewModel
    {
        public OrderViewModel()
        {
            SearchModel = new OrderSearchModel();
            OrderModels = new Page<OrderModel>();
        }

        public OrderSearchModel SearchModel { get; set; }

        public Page<OrderModel> OrderModels { get; set; }
    }
}
