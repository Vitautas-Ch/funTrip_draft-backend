﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class ImageRegions
    {
        public long Id { get; set; }

        public string? Name { get; set; } //Image
        public string? Description { get; set; } //ImageAlt

        public virtual Regions? Region { get; set; }

        //public ImageRegion() { }
    }
}
