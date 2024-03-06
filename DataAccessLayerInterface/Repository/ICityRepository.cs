using ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface.Repository
{
    public interface ICityRepository : IGenericRepository<City>
    {
        IEnumerable<City> FilterCitiesByName(Func<City, bool> predicate, bool includeRegions = false);
    }
}