using System;
using System.Collections.Generic;

#nullable disable

namespace DemoECummerApp.Models
{
    public partial class OrdersProduct
    {
        public OrdersProduct()
        {
            Id = Guid.NewGuid();
            OrderProductAttributes = new HashSet<OrderProductAttribute>();
            Productstax = 0;
        }

        public Guid Id { get; set; }
        public Guid? Orderid { get; set; }
        public Guid Productid { get; set; }
        public string Productname { get; set; }
        public decimal Productprice { get; set; }
        public decimal Finalprice { get; set; }
        public decimal Productstax { get; set; }
        public int Productqty { get; set; }

        public virtual Order Order { get; set; }
        public virtual Products Product { get; set; }
        public virtual ICollection<OrderProductAttribute> OrderProductAttributes { get; set; }
    }
}
