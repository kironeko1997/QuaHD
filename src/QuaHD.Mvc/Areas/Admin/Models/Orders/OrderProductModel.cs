﻿namespace QuaHD.Mvc.Areas.Admin.Models.Orders
{
    public class OrderProductModel : Model
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
