using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class ImageRegions
    {
        public long Id { get; set; }
        //public long Id { get; set; }
        public string? Image { get; set; }
        public string? ImageAlt { get; set; }
        /*public string? Name { get; set; }
        public string? Description { get; set; }*/
        //public ImageRegion() { }
        public virtual Regions? Region { get; set; }
    }
}
