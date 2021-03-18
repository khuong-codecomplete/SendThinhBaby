using System;
using System.Collections.Generic;

#nullable disable

namespace DemoECummerApp.Models
{
    public partial class Cart
    {
        public Cart()
        {
            Id = Guid.NewGuid();
            Addedon = DateTime.Now;
        }
        public Guid Id { get; set; }
        public Guid? Customerid { get; set; }
        public Guid? Productid { get; set; }
        public int Qty { get; set; }
        public decimal Finalprice { get; set; }
        public DateTime Addedon { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Products Product { get; set; }
    }
}
