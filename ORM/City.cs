using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class City
    {
        public long Id { get; set; }

        public string? Name { get; set; }
        public string? MapLink { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? Description { get; set; }

        public virtual Region? Region { get; set; }
        public virtual ICollection<ImageCity>? ImageCities { get; set; }
    }
}
