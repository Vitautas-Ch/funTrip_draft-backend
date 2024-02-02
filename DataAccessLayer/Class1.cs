using ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Class1
    {
        public ApplicationContext Context { get; set; }
        public Class1()
        {
            //Context = new ApplicationContext();
            //Region? region = Context.Regions.FirstOrDefault(x => x.Name == "Brest region");
        }
    }
}
