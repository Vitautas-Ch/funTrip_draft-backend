using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Regions
    {
        public long Id { get; set; }

        public string? Name { get; set; }
        public string? MapLink { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Cities>? Cities { get; set; }
        public virtual ICollection<ImageRegions>? ImageRegions { get; set; }
    }
}
