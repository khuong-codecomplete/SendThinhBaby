using System;
using System.Collections.Generic;

#nullable disable

namespace DemoECummerApp.Models
{
    public partial class Currency
    {
        public Currency()
        {
            Countries = new HashSet<Country>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string Symboleleft { get; set; }
        public string Symbolright { get; set; }

        public virtual ICollection<Country> Countries { get; set; }
    }
}
