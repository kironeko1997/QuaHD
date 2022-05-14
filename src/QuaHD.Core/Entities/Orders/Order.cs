using QuaHD.Application.Shared.Orders.Enum;
using QuaHD.Core.Entities.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Core.Entities.Orders
{
    public class Order : Entity
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public string? Code { get; set; }

        public OrderStatus Status { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public DateTime? CompletedDate { get; set; }
    }
}
