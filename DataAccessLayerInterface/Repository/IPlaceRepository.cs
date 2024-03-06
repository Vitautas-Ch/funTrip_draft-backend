using DataAccessLayer.Interface.Repository;
using ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface.Repository
{
    public interface IPlaceRepository : IGenericRepository<Place>
    {
        IEnumerable<Place> FilterPlacesByCity(Func<Place, bool> predicate, bool includeCities = false);
    }
}