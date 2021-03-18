using System;
using System.Collections.Generic;

#nullable disable

namespace DemoECummerApp.Models
{
    public partial class ReviewsDetail
    {
        public Guid Id { get; set; }
        public Guid? Reviewid { get; set; }
        public string Text { get; set; }

        public virtual Review Review { get; set; }
    }
}
