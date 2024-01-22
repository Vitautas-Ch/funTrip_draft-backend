using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Places
    {
        public long Id { get; set; }

        public string? Name { get; set; }
        public string? InfoLink { get; set; }
        public string? MapLink { get; set; }
        public string? Address { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public int DistanceFromZero { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Description { get; set; }
        public string? AverageBill { get; set; }

        public virtual Cities? City { get; set; }
        public virtual TypePlaces? TypePlace { get; set; }
        public virtual ICollection<ImagePlaces>? ImagePlaces { get; set; }
    }
}
