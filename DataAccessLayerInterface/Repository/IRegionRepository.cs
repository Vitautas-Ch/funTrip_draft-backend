using ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface.Repository
{
    public interface IRegionRepository : IGenericRepository<Region>
    {
        IEnumerable<Region> FilterRegionsByName(Func<Region, bool> predicate, bool includeCities);
    }
}
