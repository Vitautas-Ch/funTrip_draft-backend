using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Region
    {
        public long Id { get; set; }

        public string? Name { get; set; }
        public string? MapLink { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<City>? Cities { get; set; }
        public virtual ICollection<ImageRegion>? ImageRegions { get; set; }
    }
}
