using System;
using System.Collections.Generic;

#nullable disable

namespace DemoECummerApp.Models
{
    public partial class Review
    {
        public Review()
        {
            ReviewsDetails = new HashSet<ReviewsDetail>();
        }

        public Guid Id { get; set; }
        public Guid? Productid { get; set; }
        public Guid? Customerid { get; set; }
        public string Customername { get; set; }
        public int Rating { get; set; }
        public DateTime Addedon { get; set; }
        public DateTime Modifiedon { get; set; }

        public virtual Products Product { get; set; }
        public virtual ICollection<ReviewsDetail> ReviewsDetails { get; set; }
    }
}
