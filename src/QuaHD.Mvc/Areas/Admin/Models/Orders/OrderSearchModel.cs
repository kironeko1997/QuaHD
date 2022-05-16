using QuaHD.Application.Shared.Orders.Enum;

namespace QuaHD.Mvc.Areas.Admin.Models.Orders
{
    public class OrderSearchModel : SearchModel
    {
        public int? UserId { get; set; }

        public List<OrderStatus> Statuses { get; set; }

        public DateTime? FromOrderDate { get; set; }

        public DateTime? ToOrderDate { get; set; }

        public DateTime? FromDeliveryDate { get; set; }

        public DateTime? ToDeliveryDate { get; set; }

        public DateTime? FromCompletedDate { get; set; }

        public DateTime? ToCompletedDate { get; set; }
    }
}
