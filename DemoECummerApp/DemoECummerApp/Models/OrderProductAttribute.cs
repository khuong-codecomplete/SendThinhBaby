using System;
using System.Collections.Generic;

#nullable disable

namespace DemoECummerApp.Models
{
    public partial class OrderProductAttribute
    {
        public Guid Id { get; set; }
        public Guid? Orderid { get; set; }
        public Guid? Orderproductid { get; set; }
        public string Productoptions { get; set; }
        public string Productoptiobvalue { get; set; }
        public decimal Optionvalueprice { get; set; }
        public string PricePrefix { get; set; }

        public virtual Order Order { get; set; }
        public virtual OrdersProduct Orderproduct { get; set; }
    }
}
