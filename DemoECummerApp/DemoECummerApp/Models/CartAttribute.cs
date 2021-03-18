using System;
using System.Collections.Generic;

#nullable disable

namespace DemoECummerApp.Models
{
    public partial class CartAttribute
    {
        public Guid Id { get; set; }
        public Guid? Customerid { get; set; }
        public Guid? Productid { get; set; }
        public Guid? Productoptionid { get; set; }
        public Guid? Productoptionvalueid { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Products Product { get; set; }
        public virtual ProductsOption Productoption { get; set; }
        public virtual ProductsOptionsValue Productoptionvalue { get; set; }
    }
}
