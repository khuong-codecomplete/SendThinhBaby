using System;
using System.Collections.Generic;

#nullable disable

namespace DemoECummerApp.Models
{
    public partial class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public Guid? Parentcatid { get; set; }
        public int Order { get; set; }
        public DateTime Addedon { get; set; }
        public DateTime Modifiedon { get; set; }
    }
}
