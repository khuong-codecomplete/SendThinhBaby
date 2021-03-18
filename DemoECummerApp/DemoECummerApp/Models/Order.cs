using System;
using System.Collections.Generic;

#nullable disable

namespace DemoECummerApp.Models
{
    public partial class Order
    {
        public Order()
        {
            Id = Guid.NewGuid();
            OrderProductAttributes = new HashSet<OrderProductAttribute>();
            OrdersProducts = new HashSet<OrdersProduct>();
            Datepurcahsed = DateTime.Now;
            Latsmodified = DateTime.Now;
            Shipingmethodid = Guid.NewGuid();
            Paymentmethodid = Guid.NewGuid();
            Shippingcost = 0;
            Orderdatefinished = DateTime.Now;
            Currency = "$";
            CurrencyValue = 0;
            Orderstatus = "Placed";
        }

        public Guid Id { get; set; }
        public Guid? Customerid { get; set; }
        public string Customername { get; set; }
        public string CustomerStreetaddress { get; set; }
        public string Customercity { get; set; }
        public string Customerstate { get; set; }
        public string Customerpostalcode { get; set; }
        public string Customercountry { get; set; }
        public string Customertelephone { get; set; }
        public string Customeremail { get; set; }
        public string Deliveryname { get; set; }
        public string Deliverystreetaddress { get; set; }
        public string Deliverycity { get; set; }
        public string Deliverystate { get; set; }
        public string Deliverypostalcode { get; set; }
        public string Deliverycountry { get; set; }
        public Guid? Paymentmethodid { get; set; }
        public DateTime Latsmodified { get; set; }
        public DateTime Datepurcahsed { get; set; }
        public decimal? Shippingcost { get; set; }
        public Guid? Shipingmethodid { get; set; }
        public string Orderstatus { get; set; }
        public DateTime Orderdatefinished { get; set; }
        public string Comments { get; set; }
        public string Currency { get; set; }
        public decimal CurrencyValue { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual ICollection<OrderProductAttribute> OrderProductAttributes { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }
    }
}
