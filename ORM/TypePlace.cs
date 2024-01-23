using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class TypePlace
    {
        public long Id { get; set; }

        public string? Type { get; set; }

        public virtual ICollection<Place>? Places { get; set; }
    }
}
