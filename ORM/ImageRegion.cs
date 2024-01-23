using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class ImageRegion
    {
        public long Id { get; set; }

        public string? Name { get; set; } //Image
        public string? Description { get; set; } //ImageAlt

        public virtual Region? Region { get; set; }

        //public ImageRegion() { }
    }
}
