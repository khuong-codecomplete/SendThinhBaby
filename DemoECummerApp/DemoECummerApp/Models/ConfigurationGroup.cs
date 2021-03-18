using System;
using System.Collections.Generic;

#nullable disable

namespace DemoECummerApp.Models
{
    public partial class ConfigurationGroup
    {
        public ConfigurationGroup()
        {
            Configurations = new HashSet<Configuration>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Configuration> Configurations { get; set; }
    }
}
