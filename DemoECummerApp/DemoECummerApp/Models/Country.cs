using System;
using System.Collections.Generic;

#nullable disable

namespace DemoECummerApp.Models
{
    public partial class Country
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Isocode { get; set; }
        public Guid? Currencyid { get; set; }

        public virtual Currency Currency { get; set; }
    }
}
