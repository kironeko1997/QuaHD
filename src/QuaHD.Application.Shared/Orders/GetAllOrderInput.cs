using QuaHD.Application.Shared.Orders.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Shared.Orders
{
    public class GetAllOrderInput : Input
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