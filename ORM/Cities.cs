using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Cities
    {
        public long Id { get; set; }

        public string? Name { get; set; }
        public string? MapLink { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? Description { get; set; }

        public virtual Regions? Region { get; set; }
        public virtual ICollection<TypePlaces>? TypePlaces { get; set; }
        public virtual ICollection<ImageCities>? ImageCities { get; set; }
        //public string? Type { get; set; }
    }
}
