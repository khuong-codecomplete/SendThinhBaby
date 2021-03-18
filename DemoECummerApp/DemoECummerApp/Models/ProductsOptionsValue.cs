using System;
using System.Collections.Generic;

#nullable disable

namespace DemoECummerApp.Models
{
    public partial class ProductsOptionsValue
    {
        public ProductsOptionsValue()
        {
            CartAttributes = new HashSet<CartAttribute>();
            ProductsAttributes = new HashSet<ProductsAttribute>();
            ProductsOptionsValuesMappings = new HashSet<ProductsOptionsValuesMapping>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CartAttribute> CartAttributes { get; set; }
        public virtual ICollection<ProductsAttribute> ProductsAttributes { get; set; }
        public virtual ICollection<ProductsOptionsValuesMapping> ProductsOptionsValuesMappings { get; set; }
    }
}
