using QuaHD.Application.Shared.Orders.Enum;

namespace QuaHD.Mvc.Areas.Admin.Models.Orders
{
    public class OrderModel : Model
    {
        public int UserId { get; set; }

        public string? Code { get; set; }

        public OrderStatus Status { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public DateTime? CompletedDate { get; set; }
    }
}
