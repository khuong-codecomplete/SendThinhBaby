using System;
using System.Collections.Generic;

#nullable disable

namespace DemoECummerApp.Models
{
    public partial class Products
    {
        public Products()
        {
            CartAttributes = new HashSet<CartAttribute>();
            Carts = new HashSet<Cart>();
            OrdersProducts = new HashSet<OrdersProduct>();
            ProductsAttributes = new HashSet<ProductsAttribute>();
            Productsdetail = new HashSet<Productsdetail>();
            Reviews = new HashSet<Review>();
        }

        public Guid Id { get; set; }
        public int Qty { get; set; }
        public string Model { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public DateTime Addedon { get; set; }
        public DateTime Modifiedon { get; set; }
        public decimal Weight { get; set; }
        public byte Status { get; set; }
        public Guid? ManufactureId { get; set; }
        public Guid? Taxclassid { get; set; }

        public virtual ICollection<CartAttribute> CartAttributes { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }
        public virtual ICollection<ProductsAttribute> ProductsAttributes { get; set; }
        public virtual ICollection<Productsdetail> Productsdetail { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
