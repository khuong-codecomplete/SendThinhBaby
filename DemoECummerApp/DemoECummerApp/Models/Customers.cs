using System;
using System.Collections.Generic;

#nullable disable

namespace DemoECummerApp.Models
{
    public partial class Customers
    {
        //public Customers()
        //{
        //    AddressBooks = new HashSet<AddressBook>();
        //    CartAttributes = new HashSet<CartAttribute>();
        //    Carts = new HashSet<Cart>();
        //    CustomerInfos = new HashSet<CustomerInfo>();
        //    Orders = new HashSet<Order>();
        //}
        public Customers()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Gender { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public Guid Mainaddressid { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Password { get; set; }
        public bool Newsletteropted { get; set; }

        public virtual ICollection<AddressBook> AddressBooks { get; set; }
        public virtual ICollection<CartAttribute> CartAttributes { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<CustomerInfo> CustomerInfos { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
